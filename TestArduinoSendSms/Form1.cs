using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace TestArduinoSendSms;

public partial class Form1 : Form
{

    private SerialPort? _serialPort;

    public Form1()
    {
        InitializeComponent();
        SetupSerialPort();

    }

    private void SetupSerialPort()
    {
        _serialPort = new SerialPort
        {
            PortName = "COM3", // Change this to your Arduino's COM port
            BaudRate = 9600,
            DataBits = 8,
            Parity = Parity.None,
            StopBits = StopBits.One,
            Handshake = Handshake.None,
            Encoding = Encoding.ASCII
        };

        _serialPort?.Open();
    }

    private void BtnSend_Click(object sender, EventArgs e)
    {
        string recipient = TxtbxRecepient.Text;
        string message = RtxtbxMessage.Text;

        if (_serialPort is null) return;

        if (_serialPort.IsOpen)
        {
            string command = $"SMS:{recipient},{message}\n";
            _serialPort.WriteLine(command);
        }
    }
}
