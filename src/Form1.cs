using MTConnect;
using MTConnect.Adapters.Shdr;
using MTConnect.Clients.Rest;
using MTConnect.Devices;
using MTConnect.Devices.DataItems.Events;
using MTConnect.Formatters;
using MTConnect.Observations;
using MTConnect.Observations.Events.Values;
using MTConnect.Shdr;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        bool connected;
        MTConnectClient _client;
        ShdrAdapter _adapter;
        IDevice _device;
        Dictionary<string, IDataItem> _dataItems = new Dictionary<string, IDataItem>();
        IDataItem _selectedDataItem;


        public Form1()
        {
            InitializeComponent();

            connectionStatusLabel.Text = "Not Connected";
            disconnectedPanel.BringToFront();
        }

        private async void LoadDevices()
        {
            deviceComboBox.Items.Clear();

            if (_client != null)
            {
                var devices = _client.GetProbe()?.Devices;
                if (!devices.IsNullOrEmpty())
                {
                    foreach (var device in devices)
                    {
                        deviceComboBox.Items.Add(device.Name);
                    }
                }
            }
        }

        private async void LoadDataItems(string deviceName)
        {
            dataItemsTreeView.Nodes.Clear();
            _device = null;
            _dataItems.Clear();

            if (_client != null)
            {
                var devices = _client.GetProbe()?.Devices;
                if (!devices.IsNullOrEmpty())
                {
                    _device = devices.FirstOrDefault(o => o.Name == deviceName);
                    if (_device != null)
                    {
                        // Add to Cached list
                        var dataItems = _device.GetDataItems();
                        foreach (var item in dataItems) _dataItems.Add(item.Id, item);


                        var rootNode = new TreeNode(_device.Name);

                        // DataItems
                        if (!_device.DataItems.IsNullOrEmpty())
                        {
                            var dataItemsNode = new TreeNode("DataItems");
                            foreach (var dataItem in _device.DataItems)
                            {
                                LoadDataItems(dataItemsNode, dataItem);
                            }
                            rootNode.Nodes.Add(dataItemsNode);
                        }

                        // Components
                        if (!_device.Components.IsNullOrEmpty())
                        {
                            var componentsNode = new TreeNode("Components");
                            foreach (var component in _device.Components)
                            {
                                LoadDataItems(componentsNode, component);
                            }
                            rootNode.Nodes.Add(componentsNode);
                        }

                        rootNode.ExpandAll();
                        dataItemsTreeView.Nodes.Add(rootNode);
                    }
                }
            }
        }

        private async void LoadDataItems(TreeNode node, IComponent component)
        {
            var label = component.Id;
            if (!string.IsNullOrEmpty(component.Name)) label += $" : ({component.Name})";

            var componentNode = new TreeNode(label);

            var tooltip = $"{component.Type} Component" + Environment.NewLine;
            tooltip += $"ID = {component.Id}" + Environment.NewLine;
            tooltip += $"Name = {component.Name}" + Environment.NewLine;
            componentNode.ToolTipText = tooltip;

            // DataItems
            if (!component.DataItems.IsNullOrEmpty())
            {
                var dataItemsNode = new TreeNode("DataItems");
                foreach (var dataItem in component.DataItems)
                {
                    LoadDataItems(dataItemsNode, dataItem);
                }
                componentNode.Nodes.Add(dataItemsNode);
            }

            // Components
            if (!component.Components.IsNullOrEmpty())
            {
                var componentsNode = new TreeNode("Components");
                foreach (var subcomponent in component.Components)
                {
                    LoadDataItems(componentsNode, subcomponent);
                }
                componentNode.Nodes.Add(componentsNode);
            }


            node.Nodes.Add(componentNode);
        }

        private async void LoadDataItems(TreeNode node, IDataItem dataItem)
        {
            var label = dataItem.Id;
            if (!string.IsNullOrEmpty(dataItem.Name)) label += $" : ({dataItem.Name})";

            var dataItemNode = new TreeNode(label);
            dataItemNode.Tag = dataItem.Id;

            var tooltip = $"{dataItem.Type} Component" + Environment.NewLine;
            tooltip += $"ID = {dataItem.Id}" + Environment.NewLine;
            tooltip += $"Name = {dataItem.Name}" + Environment.NewLine;
            dataItemNode.ToolTipText = tooltip;

            node.Nodes.Add(dataItemNode);
        }




        private void connectButton_Click(object sender, EventArgs e)
        {
            var hostname = hostnameTextBox.Text;
            var port = shdrPortTextBox.Text.ToInt();

            if (!connected)
            {
                if (_adapter != null) _adapter.Stop();
                _adapter = new ShdrAdapter(hostname, port);
                _adapter.AgentConnected += AgentConnected;
                _adapter.AgentDisconnected += AgentDisonnected;
                _adapter.LineSent += AdapterLineSent;
                _adapter.Start();
                connectionStatusLabel.Text = "Connecting...";
            }
            else
            {
                if (_adapter != null) _adapter.Stop();
            }
        }

        private void AgentConnected(object sender, string hostname)
        {
            connectionStatusLabel.Invoke(() =>
            {
                var hostname = hostnameTextBox.Text;
                var port = httpPortTextBox.Text.ToInt();

                _client = new MTConnectClient($"{hostname}:{port}");
                LoadDevices();

                connectionStatusLabel.Text = "Connected";
                connectButton.Text = "Disconnect";
                disconnectedPanel.SendToBack();
                connected = true;
            });
        }

        private void AgentDisonnected(object sender, string hostname)
        {
            connectionStatusLabel.Invoke(() =>
            {
                if (_client != null) _client.Stop();

                connectionStatusLabel.Text = "Disconnected";
                connectButton.Text = "Connect";
                disconnectedPanel.BringToFront();
                connected = false;
            });
        }

        private void AdapterLineSent(object sender, AdapterEventArgs args)
        {
            connectionStatusLabel.Invoke(() =>
            {
                outputListBox.Items.Insert(0, args.Message);
            });
        }


        private void sampleValueSendButton_Click(object sender, EventArgs e)
        {
            if (_adapter != null && _selectedDataItem != null)
            {
                switch (_selectedDataItem.Representation)
                {
                    case MTConnect.Devices.DataItems.DataItemRepresentation.VALUE:

                        if (_selectedDataItem.Category == MTConnect.Devices.DataItems.DataItemCategory.CONDITION)
                        {
                            SendConditionDataItem();
                        }
                        else
                        {
                            SendValueDataItem();
                        }

                        break;
                }
            }
        }

        private void SendValueDataItem()
        {
            var dataItemKey = sampleValueDataItemKeyTextBox.Text;
            var result = dataItemResultComboBox.Text;

            _adapter.AddDataItem(dataItemKey, result);
            _adapter.SendCurrent();
        }

        private void SendConditionDataItem()
        {
            var dataItemKey = sampleValueDataItemKeyTextBox.Text;
            var condition = new ShdrCondition(dataItemKey);

            var faultState = new ShdrFaultState();
            faultState.Level = dataItemLevelComboBox.Text.ConvertEnum<ConditionLevel>();
            faultState.NativeCode = dataItemConditionNativeCodeTextBox.Text;
            faultState.NativeSeverity = dataItemConditionNativeSeverityTextBox.Text;
            faultState.Qualifier = dataItemConditionQualifierComboBox.Text.ConvertEnum<ConditionQualifier>();
            faultState.Message = dataItemConditionMessageTextBox.Text;


            condition.AddFaultState(faultState);
            _adapter.AddCondition(condition);
            _adapter.SendCurrent();
        }

        private void assetSendButton_Click(object sender, EventArgs e)
        {
            var assetId = assetIdTextBox.Text;
            var assetType = assetTypeTextBox.Text;
            var assetBody = assetBodyTextBox.Text;

            if (_adapter != null)
            {
                var bodyBytes = Encoding.ASCII.GetBytes(assetBody);

                var assetResult = EntityFormatter.CreateAsset(DocumentFormat.XML, assetType, bodyBytes);
                if (assetResult.Success)
                {
                    var asset = assetResult.Entity;
                    asset.AssetId = assetId;
                    asset.Timestamp = UnixDateTime.Now;

                    _adapter.SendAsset(asset);
                }
            }
        }

        private void dataSetSendButton_Click(object sender, EventArgs e)
        {
            //var dataItemKey = dataSetDataItemKeyTextBox.Text;

            //var entries = new List<ShdrDataSetEntry>();
            //var m = dataSetDataGridView.RowCount;
            //for (var i = 0; i < m - 1; i++)
            //{
            //    var entry = new ShdrDataSetEntry();
            //    entry.Key = dataSetDataGridView[0, i].Value.ToString();
            //    entry.Value = dataSetDataGridView[1, i].Value.ToString();
            //    entries.Add(entry);
            //}

            //var dataSet = new ShdrDataSet();
            //dataSet.DataItemKey = dataItemKey;
            //dataSet.Entries = entries;

            //if (_adapter != null)
            //{
            //    _adapter.AddDataSet(dataSet);
            //    _adapter.SendCurrent();
            //}
        }


        private void deviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var deviceName = deviceComboBox.SelectedItem?.ToString();
            if (deviceName != null)
            {
                LoadDataItems(deviceName);
            }
        }

        private void dataItemsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null && e.Node.Tag != null)
            {
                var dataItemId = e.Node.Tag.ToString();
                SelectDataItem(dataItemId);
            }
        }

        private void SelectDataItem(string dataItemId)
        {
            _selectedDataItem = null;

            var dataItem = _dataItems.GetValueOrDefault(dataItemId);
            if (dataItem != null)
            {
                _selectedDataItem = dataItem;

                dataItemResultComboBox.Items.Clear();
                dataItemResultComboBox.Text = null;
                dataItemValueDescriptionTextBox.Text = null;

                dataItemTypeLabel.Text = dataItem.Type;
                dataItemTypeDescriptionTextBox.Text = dataItem.TypeDescription;

                dataItemSubTypeLabel.Text = dataItem.SubType;
                dataItemSubTypeDescription.Text = dataItem.SubTypeDescription;

                switch (dataItem.Category)
                {
                    case MTConnect.Devices.DataItems.DataItemCategory.CONDITION:
                        dataItemConditionPanel.BringToFront();
                        break;

                    case MTConnect.Devices.DataItems.DataItemCategory.EVENT:
                        dataItemValuePanel.BringToFront();
                        LoadDataItemValues(dataItem);
                        break;

                    case MTConnect.Devices.DataItems.DataItemCategory.SAMPLE:
                        dataItemValuePanel.BringToFront();
                        break;               
                }
            }

            sampleValueDataItemKeyTextBox.Text = dataItemId;
        }

        private void LoadDataItemValues(IDataItem dataItem)
        {
            var values = GetValueText(dataItem.Type, dataItem.SubType);
            if (!values.IsNullOrEmpty())
            {
                foreach (var value in values)
                {
                    dataItemResultComboBox.Items.Add(value);
                }
            }

            if (dataItem.Type != AvailabilityDataItem.TypeId)
            {
                dataItemResultComboBox.Items.Add(Observation.Unavailable);
            }
        }

        public static IEnumerable<string> GetValueText(string type, string subType)
        {
            switch (type.ToUnderscoreUpper())
            {
                case ActuatorStateDataItem.TypeId: return Enum.GetNames<ActuatorState>();
                case AvailabilityDataItem.TypeId: return Enum.GetNames<Availability>();
                case AxisCouplingDataItem.TypeId: return Enum.GetNames<AxisCoupling>();
                case AxisInterlockDataItem.TypeId: return Enum.GetNames<AxisInterlock>();
                case AxisStateDataItem.TypeId: return Enum.GetNames<AxisState>();
                case ChuckInterlockDataItem.TypeId: return Enum.GetNames<ChuckInterlock>();
                case ChuckStateDataItem.TypeId: return Enum.GetNames<ChuckState>();
                case CompositionStateDataItem.TypeId:

                    switch (subType.ToUnderscoreUpper().ConvertEnum<CompositionStateDataItem.SubTypes>())
                    {
                        case CompositionStateDataItem.SubTypes.ACTION: return Enum.GetNames<CompositionActionState>();
                        case CompositionStateDataItem.SubTypes.LATERAL: return Enum.GetNames<CompositionLateralState>();
                        case CompositionStateDataItem.SubTypes.MOTION: return Enum.GetNames<CompositionMotionState>();
                        case CompositionStateDataItem.SubTypes.SWITCHED: return Enum.GetNames<CompositionSwitchedState>();
                        case CompositionStateDataItem.SubTypes.VERTICAL: return Enum.GetNames<CompositionVerticalState>();
                    }
                    break;
                case ConnectionStatusDataItem.TypeId: return Enum.GetNames<ConnectionStatus>();
                case ControllerModeDataItem.TypeId: return Enum.GetNames<ControllerMode>();
                case ControllerModeOverrideDataItem.TypeId: return Enum.GetNames<ControllerModeOverrideValue>();
                case DirectionDataItem.TypeId:
                    switch (subType.ToUnderscoreUpper().ConvertEnum<DirectionDataItem.SubTypes>())
                    {
                        case DirectionDataItem.SubTypes.LINEAR: return Enum.GetNames<LinearDirection>();
                        case DirectionDataItem.SubTypes.ROTARY: return Enum.GetNames<RotaryDirection>();
                    }
                    break;
                case DoorStateDataItem.TypeId: return Enum.GetNames<DoorState>();
                case EmergencyStopDataItem.TypeId: return Enum.GetNames<EmergencyStop>();
                case EndOfBarDataItem.TypeId: return Enum.GetNames<EndOfBar>();
                case EquipmentModeDataItem.TypeId: return Enum.GetNames<EquipmentMode>();
                case ExecutionDataItem.TypeId: return Enum.GetNames<Execution>();
                case FunctionalModeDataItem.TypeId: return Enum.GetNames<FunctionalMode>();
                case InterfaceStateDataItem.TypeId: return Enum.GetNames<InterfaceState>();
                case LockStateDataItem.TypeId: return Enum.GetNames<LockState>();
                case PartDetectDataItem.TypeId: return Enum.GetNames<PartDetect>();
                case PartProcessingStateDataItem.TypeId: return Enum.GetNames<PartProcessingState>();
                case PartStatusDataItem.TypeId: return Enum.GetNames<PartStatus>();
                case PathModeDataItem.TypeId: return Enum.GetNames<PathMode>();
                case PowerStateDataItem.TypeId: return Enum.GetNames<MTConnect.Observations.Events.Values.PowerState>();
                case ProcessStateDataItem.TypeId: return Enum.GetNames<ProcessState>();
                case ProgramLocationTypeDataItem.TypeId: return Enum.GetNames<ProgramLocationType>();
                case RotaryModeDataItem.TypeId: return Enum.GetNames<RotaryMode>();
                case SpindleInterlockDataItem.TypeId: return Enum.GetNames<SpindleInterlock>();
                case ValveStateDataItem.TypeId: return Enum.GetNames<ValveState>();
                case WaitStateDataItem.TypeId: return Enum.GetNames<WaitState>();
            }

            return null;
        }

        private void dataItemResultComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var value = dataItemResultComboBox.SelectedItem?.ToString();
            if (value != null)
            {
                if (_selectedDataItem != null)
                {
                    var valueDescription = Observation.GetDescriptionText(_selectedDataItem.Category, _selectedDataItem.Type, _selectedDataItem.SubType, value); ;
                    dataItemValueDescriptionTextBox.Text = valueDescription;
                }
            }
        }

        private void dataItemLevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var level = dataItemLevelComboBox.SelectedItem?.ToString();
            if (level == ConditionLevel.NORMAL.ToString() || level == ConditionLevel.UNAVAILABLE.ToString())
            {
                dataItemConditionNativeCodeTextBox.Text = null;
                dataItemConditionNativeSeverityTextBox.Text = null;
                dataItemConditionQualifierComboBox.Text = null;
                dataItemConditionMessageTextBox.Text = null;
            }
        }
    }
}