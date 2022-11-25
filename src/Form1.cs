using MTConnect;
using MTConnect.Adapters.Shdr;
using MTConnect.Formatters;
using MTConnect.Shdr;
using System.Text;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        bool connected;
        ShdrAdapter _adapter;


        public Form1()
        {
            InitializeComponent();

            connectionStatusLabel.Text = "Not Connected";
        }


        private void connectButton_Click(object sender, EventArgs e)
        {
            var hostname = hostnameTextBox.Text;
            var port = portTextBox.Text.ToInt();

            if (!connected)
            {
                if (_adapter != null) _adapter.Stop();
                _adapter = new ShdrAdapter(hostname, port);
                _adapter.AgentConnected += AgentConnected;
                _adapter.AgentDisconnected += AgentDisonnected;
                _adapter.LineSent += AdapterLineSent;
                _adapter.Start();
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
                connectionStatusLabel.Text = "Connected";
                connectButton.Text = "Disconnect";
                connected = true;
            });
        }

        private void AgentDisonnected(object sender, string hostname)
        {
            connectionStatusLabel.Invoke(() =>
            {
                connectionStatusLabel.Text = "Disconnected";
                connectButton.Text = "Connect";
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
            var dataItemKey = sampleValueDataItemKeyTextBox.Text;
            var result = sampleValueResultTextBox.Text;

            if (_adapter != null)
            {
                _adapter.AddDataItem(dataItemKey, result);
                _adapter.SendCurrent();
            }
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
            var dataItemKey = dataSetDataItemKeyTextBox.Text;

            var entries = new List<ShdrDataSetEntry>();
            var m = dataSetDataGridView.RowCount;
            for (var i = 0; i < m - 1; i++)
            {
                var entry = new ShdrDataSetEntry();
                entry.Key = dataSetDataGridView[0, i].Value.ToString();
                entry.Value = dataSetDataGridView[1, i].Value.ToString();
                entries.Add(entry);
            }

            var dataSet = new ShdrDataSet();
            dataSet.DataItemKey = dataItemKey;
            dataSet.Entries = entries;

            if (_adapter != null)
            {
                _adapter.AddDataSet(dataSet);
                _adapter.SendCurrent();
            }
        }
    }
}