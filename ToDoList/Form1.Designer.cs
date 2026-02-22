namespace ToDoList;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        groupBox1 = new System.Windows.Forms.GroupBox();
        label1 = new System.Windows.Forms.Label();
        editextpanel = new System.Windows.Forms.Panel();
        canceledit = new System.Windows.Forms.Button();
        SetNewName = new System.Windows.Forms.Button();
        edittext = new System.Windows.Forms.TextBox();
        listBox = new System.Windows.Forms.ListBox();
        groupBox2 = new System.Windows.Forms.GroupBox();
        load = new System.Windows.Forms.Button();
        save = new System.Windows.Forms.Button();
        AddTask = new System.Windows.Forms.Button();
        NameTask = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        editbtn = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        groupBox1.SuspendLayout();
        editextpanel.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(editextpanel);
        groupBox1.Controls.Add(listBox);
        groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 15F);
        groupBox1.Location = new System.Drawing.Point(204, 82);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(584, 356);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "List";
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 15F);
        label1.Location = new System.Drawing.Point(0, 323);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(147, 36);
        label1.TabIndex = 7;
        label1.Text = "Current tasks:";
        // 
        // editextpanel
        // 
        editextpanel.Controls.Add(canceledit);
        editextpanel.Controls.Add(SetNewName);
        editextpanel.Controls.Add(edittext);
        editextpanel.Location = new System.Drawing.Point(109, 109);
        editextpanel.Name = "editextpanel";
        editextpanel.Size = new System.Drawing.Size(349, 126);
        editextpanel.TabIndex = 6;
        editextpanel.Visible = false;
        // 
        // canceledit
        // 
        canceledit.BackColor = System.Drawing.Color.Red;
        canceledit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        canceledit.Location = new System.Drawing.Point(306, 0);
        canceledit.Name = "canceledit";
        canceledit.Size = new System.Drawing.Size(43, 39);
        canceledit.TabIndex = 6;
        canceledit.Text = "X";
        canceledit.UseVisualStyleBackColor = false;
        canceledit.Click += canceledit_Click;
        // 
        // SetNewName
        // 
        SetNewName.Location = new System.Drawing.Point(102, 82);
        SetNewName.Name = "SetNewName";
        SetNewName.Size = new System.Drawing.Size(140, 35);
        SetNewName.TabIndex = 7;
        SetNewName.Text = "Set Text";
        SetNewName.UseVisualStyleBackColor = true;
        SetNewName.Visible = false;
        SetNewName.Click += SetNewName_Click;
        // 
        // edittext
        // 
        edittext.Location = new System.Drawing.Point(54, 42);
        edittext.Name = "edittext";
        edittext.Size = new System.Drawing.Size(234, 34);
        edittext.TabIndex = 6;
        edittext.Visible = false;
        // 
        // listBox
        // 
        listBox.FormattingEnabled = true;
        listBox.Location = new System.Drawing.Point(53, 48);
        listBox.Name = "listBox";
        listBox.Size = new System.Drawing.Size(463, 256);
        listBox.TabIndex = 0;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(load);
        groupBox2.Controls.Add(save);
        groupBox2.Location = new System.Drawing.Point(5, 93);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(193, 344);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Select";
        // 
        // load
        // 
        load.Location = new System.Drawing.Point(7, 56);
        load.Name = "load";
        load.Size = new System.Drawing.Size(107, 28);
        load.TabIndex = 1;
        load.Text = "Load";
        load.UseVisualStyleBackColor = true;
        load.Click += load_Click;
        // 
        // save
        // 
        save.Location = new System.Drawing.Point(7, 22);
        save.Name = "save";
        save.Size = new System.Drawing.Size(107, 28);
        save.TabIndex = 0;
        save.Text = "Save";
        save.UseVisualStyleBackColor = true;
        save.Click += save_Click;
        // 
        // AddTask
        // 
        AddTask.Location = new System.Drawing.Point(12, 12);
        AddTask.Name = "AddTask";
        AddTask.Size = new System.Drawing.Size(71, 26);
        AddTask.TabIndex = 2;
        AddTask.Text = "AddTask";
        AddTask.UseVisualStyleBackColor = true;
        AddTask.Click += AddTask_Click;
        // 
        // NameTask
        // 
        NameTask.Location = new System.Drawing.Point(511, 45);
        NameTask.Name = "NameTask";
        NameTask.Size = new System.Drawing.Size(231, 23);
        NameTask.TabIndex = 3;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(12, 44);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(71, 23);
        button1.TabIndex = 4;
        button1.Text = "Remove";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // editbtn
        // 
        editbtn.Location = new System.Drawing.Point(92, 12);
        editbtn.Name = "editbtn";
        editbtn.Size = new System.Drawing.Size(71, 26);
        editbtn.TabIndex = 5;
        editbtn.Text = "Edit";
        editbtn.UseVisualStyleBackColor = true;
        editbtn.Click += editbtn_Click;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(511, 26);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(197, 16);
        label2.TabIndex = 6;
        label2.Text = "Enter New Task Name";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label2);
        Controls.Add(editbtn);
        Controls.Add(button1);
        Controls.Add(NameTask);
        Controls.Add(AddTask);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        Text = "ToDoList";
        groupBox1.ResumeLayout(false);
        editextpanel.ResumeLayout(false);
        editextpanel.PerformLayout();
        groupBox2.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button save;
    private System.Windows.Forms.Button load;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Button canceledit;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button SetNewName;

    private System.Windows.Forms.Panel editextpanel;

    private System.Windows.Forms.TextBox edittext;

    private System.Windows.Forms.Button editbtn;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.TextBox NameTask;

    private System.Windows.Forms.ListBox listBox;

    private System.Windows.Forms.Button AddTask;

    private System.Windows.Forms.GroupBox groupBox2;

    private System.Windows.Forms.GroupBox groupBox1;

    #endregion
}