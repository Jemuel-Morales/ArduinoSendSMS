namespace TestArduinoSendSms;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        RtxtbxMessage = new RichTextBox();
        BtnSend = new Button();
        label2 = new Label();
        TxtbxRecepient = new TextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(46, 78);
        label1.Name = "label1";
        label1.Size = new Size(94, 15);
        label1.TabIndex = 1;
        label1.Text = "Send a message:";
        // 
        // RtxtbxMessage
        // 
        RtxtbxMessage.Location = new Point(46, 96);
        RtxtbxMessage.Name = "RtxtbxMessage";
        RtxtbxMessage.Size = new Size(396, 90);
        RtxtbxMessage.TabIndex = 2;
        RtxtbxMessage.Text = "";
        // 
        // BtnSend
        // 
        BtnSend.Location = new Point(46, 192);
        BtnSend.Name = "BtnSend";
        BtnSend.Size = new Size(106, 39);
        BtnSend.TabIndex = 3;
        BtnSend.Text = "Send";
        BtnSend.UseVisualStyleBackColor = true;
        BtnSend.Click += BtnSend_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(46, 28);
        label2.Name = "label2";
        label2.Size = new Size(153, 15);
        label2.TabIndex = 4;
        label2.Text = "Recepient (+639xxxxxxxxx):";
        // 
        // TxtbxRecepient
        // 
        TxtbxRecepient.Location = new Point(46, 46);
        TxtbxRecepient.Name = "TxtbxRecepient";
        TxtbxRecepient.Size = new Size(396, 23);
        TxtbxRecepient.TabIndex = 5;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(514, 387);
        Controls.Add(TxtbxRecepient);
        Controls.Add(label2);
        Controls.Add(BtnSend);
        Controls.Add(RtxtbxMessage);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private RichTextBox RtxtbxMessage;
    private Button BtnSend;
    private Label label2;
    private TextBox TxtbxRecepient;
}
