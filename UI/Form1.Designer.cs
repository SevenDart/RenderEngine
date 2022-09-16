namespace UI;

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
			this.DrawField = new System.Windows.Forms.PictureBox();
			this.RenderObjectsList = new System.Windows.Forms.ListBox();
			this.CameraY = new System.Windows.Forms.NumericUpDown();
			this.CameraX = new System.Windows.Forms.NumericUpDown();
			this.CameraZ = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SetCameraSettingsButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.CameraFoV = new System.Windows.Forms.NumericUpDown();
			this.CameraScreenDist = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.CurrentObjZ = new System.Windows.Forms.NumericUpDown();
			this.CurrentObjX = new System.Windows.Forms.NumericUpDown();
			this.CurrentObjY = new System.Windows.Forms.NumericUpDown();
			this.SetObjectSettingsButton = new System.Windows.Forms.Button();
			this.labelYZ = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.CurrentObjLeanYZ = new System.Windows.Forms.NumericUpDown();
			this.CurrentObjLeanXY = new System.Windows.Forms.NumericUpDown();
			this.CurrentObjLeanXZ = new System.Windows.Forms.NumericUpDown();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.AddObjectButton = new System.Windows.Forms.Button();
			this.RemoveObjectButton = new System.Windows.Forms.Button();
			this.OpenObjFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.label11 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.labelXY = new System.Windows.Forms.Label();
			this.CameraLeanYZ = new System.Windows.Forms.NumericUpDown();
			this.CameraLeanXY = new System.Windows.Forms.NumericUpDown();
			this.CameraLeanXZ = new System.Windows.Forms.NumericUpDown();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.ObjectScaleX = new System.Windows.Forms.NumericUpDown();
			this.ObjectScaleZ = new System.Windows.Forms.NumericUpDown();
			this.ObjectScaleY = new System.Windows.Forms.NumericUpDown();
			this.UseCameraRadioButtion = new System.Windows.Forms.RadioButton();
			this.UseObjectRadioButton = new System.Windows.Forms.RadioButton();
			this.label21 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label22 = new System.Windows.Forms.Label();
			this.ObjectLockNoRadioButton = new System.Windows.Forms.RadioButton();
			this.ObjectLockYesRadioButton = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.DrawField)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraZ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraFoV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraScreenDist)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjZ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjLeanYZ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjLeanXY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjLeanXZ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraLeanYZ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraLeanXY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraLeanXZ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ObjectScaleX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ObjectScaleZ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ObjectScaleY)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// DrawField
			// 
			this.DrawField.BackColor = System.Drawing.Color.White;
			this.DrawField.Location = new System.Drawing.Point(274, 8);
			this.DrawField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.DrawField.Name = "DrawField";
			this.DrawField.Size = new System.Drawing.Size(1017, 645);
			this.DrawField.TabIndex = 0;
			this.DrawField.TabStop = false;
			// 
			// RenderObjectsList
			// 
			this.RenderObjectsList.FormattingEnabled = true;
			this.RenderObjectsList.ItemHeight = 20;
			this.RenderObjectsList.Location = new System.Drawing.Point(14, 8);
			this.RenderObjectsList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.RenderObjectsList.Name = "RenderObjectsList";
			this.RenderObjectsList.Size = new System.Drawing.Size(253, 644);
			this.RenderObjectsList.TabIndex = 1;
			this.RenderObjectsList.SelectedIndexChanged += new System.EventHandler(this.RenderObjectsList_SelectedIndexChanged);
			// 
			// CameraY
			// 
			this.CameraY.DecimalPlaces = 3;
			this.CameraY.Location = new System.Drawing.Point(1103, 712);
			this.CameraY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CameraY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.CameraY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
			this.CameraY.Name = "CameraY";
			this.CameraY.Size = new System.Drawing.Size(78, 27);
			this.CameraY.TabIndex = 2;
			// 
			// CameraX
			// 
			this.CameraX.DecimalPlaces = 3;
			this.CameraX.Location = new System.Drawing.Point(995, 711);
			this.CameraX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CameraX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.CameraX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
			this.CameraX.Name = "CameraX";
			this.CameraX.Size = new System.Drawing.Size(78, 27);
			this.CameraX.TabIndex = 3;
			// 
			// CameraZ
			// 
			this.CameraZ.DecimalPlaces = 3;
			this.CameraZ.Location = new System.Drawing.Point(1213, 711);
			this.CameraZ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CameraZ.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.CameraZ.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
			this.CameraZ.Name = "CameraZ";
			this.CameraZ.Size = new System.Drawing.Size(78, 27);
			this.CameraZ.TabIndex = 4;
			this.CameraZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(968, 713);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "X:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(1077, 712);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Y:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(1183, 713);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Z:";
			// 
			// SetCameraSettingsButton
			// 
			this.SetCameraSettingsButton.Location = new System.Drawing.Point(1121, 863);
			this.SetCameraSettingsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SetCameraSettingsButton.Name = "SetCameraSettingsButton";
			this.SetCameraSettingsButton.Size = new System.Drawing.Size(86, 31);
			this.SetCameraSettingsButton.TabIndex = 8;
			this.SetCameraSettingsButton.Text = "Set";
			this.SetCameraSettingsButton.UseVisualStyleBackColor = true;
			this.SetCameraSettingsButton.Click += new System.EventHandler(this.SetCameraSettings);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(1061, 671);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(154, 28);
			this.label4.TabIndex = 9;
			this.label4.Text = "Camera Settings";
			// 
			// CameraFoV
			// 
			this.CameraFoV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CameraFoV.Location = new System.Drawing.Point(1025, 816);
			this.CameraFoV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CameraFoV.Name = "CameraFoV";
			this.CameraFoV.Size = new System.Drawing.Size(51, 30);
			this.CameraFoV.TabIndex = 10;
			this.CameraFoV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.CameraFoV.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
			// 
			// CameraScreenDist
			// 
			this.CameraScreenDist.Location = new System.Drawing.Point(1220, 816);
			this.CameraScreenDist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CameraScreenDist.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.CameraScreenDist.Name = "CameraScreenDist";
			this.CameraScreenDist.Size = new System.Drawing.Size(71, 27);
			this.CameraScreenDist.TabIndex = 11;
			this.CameraScreenDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.CameraScreenDist.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(976, 818);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "FoV:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(1090, 818);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(125, 23);
			this.label6.TabIndex = 13;
			this.label6.Text = "1 / Screen Dist:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label7.Location = new System.Drawing.Point(609, 671);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(146, 28);
			this.label7.TabIndex = 14;
			this.label7.Text = "Object Settings";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label8.Location = new System.Drawing.Point(736, 711);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(24, 23);
			this.label8.TabIndex = 20;
			this.label8.Text = "Z:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label9.Location = new System.Drawing.Point(625, 712);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(23, 23);
			this.label9.TabIndex = 19;
			this.label9.Text = "Y:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label10.Location = new System.Drawing.Point(507, 714);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(24, 23);
			this.label10.TabIndex = 18;
			this.label10.Text = "X:";
			// 
			// CurrentObjZ
			// 
			this.CurrentObjZ.DecimalPlaces = 3;
			this.CurrentObjZ.Location = new System.Drawing.Point(766, 709);
			this.CurrentObjZ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CurrentObjZ.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.CurrentObjZ.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
			this.CurrentObjZ.Name = "CurrentObjZ";
			this.CurrentObjZ.Size = new System.Drawing.Size(78, 27);
			this.CurrentObjZ.TabIndex = 17;
			// 
			// CurrentObjX
			// 
			this.CurrentObjX.DecimalPlaces = 3;
			this.CurrentObjX.Location = new System.Drawing.Point(537, 711);
			this.CurrentObjX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CurrentObjX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.CurrentObjX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
			this.CurrentObjX.Name = "CurrentObjX";
			this.CurrentObjX.Size = new System.Drawing.Size(78, 27);
			this.CurrentObjX.TabIndex = 16;
			// 
			// CurrentObjY
			// 
			this.CurrentObjY.DecimalPlaces = 3;
			this.CurrentObjY.Location = new System.Drawing.Point(652, 711);
			this.CurrentObjY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CurrentObjY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.CurrentObjY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
			this.CurrentObjY.Name = "CurrentObjY";
			this.CurrentObjY.Size = new System.Drawing.Size(78, 27);
			this.CurrentObjY.TabIndex = 15;
			// 
			// SetObjectSettingsButton
			// 
			this.SetObjectSettingsButton.Location = new System.Drawing.Point(632, 863);
			this.SetObjectSettingsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SetObjectSettingsButton.Name = "SetObjectSettingsButton";
			this.SetObjectSettingsButton.Size = new System.Drawing.Size(86, 31);
			this.SetObjectSettingsButton.TabIndex = 21;
			this.SetObjectSettingsButton.Text = "Set";
			this.SetObjectSettingsButton.UseVisualStyleBackColor = true;
			this.SetObjectSettingsButton.Click += new System.EventHandler(this.SetObjectSettingsButton_Click);
			// 
			// labelYZ
			// 
			this.labelYZ.AutoSize = true;
			this.labelYZ.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelYZ.Location = new System.Drawing.Point(526, 766);
			this.labelYZ.Name = "labelYZ";
			this.labelYZ.Size = new System.Drawing.Size(33, 23);
			this.labelYZ.TabIndex = 27;
			this.labelYZ.Text = "YZ:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label12.Location = new System.Drawing.Point(630, 766);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(34, 23);
			this.label12.TabIndex = 26;
			this.label12.Text = "XZ:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label13.Location = new System.Drawing.Point(738, 768);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(33, 23);
			this.label13.TabIndex = 25;
			this.label13.Text = "XY:";
			// 
			// CurrentObjLeanYZ
			// 
			this.CurrentObjLeanYZ.Location = new System.Drawing.Point(564, 765);
			this.CurrentObjLeanYZ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CurrentObjLeanYZ.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.CurrentObjLeanYZ.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
			this.CurrentObjLeanYZ.Name = "CurrentObjLeanYZ";
			this.CurrentObjLeanYZ.Size = new System.Drawing.Size(51, 27);
			this.CurrentObjLeanYZ.TabIndex = 24;
			// 
			// CurrentObjLeanXY
			// 
			this.CurrentObjLeanXY.Location = new System.Drawing.Point(779, 765);
			this.CurrentObjLeanXY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CurrentObjLeanXY.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.CurrentObjLeanXY.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
			this.CurrentObjLeanXY.Name = "CurrentObjLeanXY";
			this.CurrentObjLeanXY.Size = new System.Drawing.Size(51, 27);
			this.CurrentObjLeanXY.TabIndex = 23;
			// 
			// CurrentObjLeanXZ
			// 
			this.CurrentObjLeanXZ.Location = new System.Drawing.Point(667, 764);
			this.CurrentObjLeanXZ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CurrentObjLeanXZ.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.CurrentObjLeanXZ.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
			this.CurrentObjLeanXZ.Name = "CurrentObjLeanXZ";
			this.CurrentObjLeanXZ.Size = new System.Drawing.Size(51, 27);
			this.CurrentObjLeanXZ.TabIndex = 22;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label14.Location = new System.Drawing.Point(416, 714);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(83, 25);
			this.label14.TabIndex = 28;
			this.label14.Text = "Position:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label15.Location = new System.Drawing.Point(444, 768);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(64, 25);
			this.label15.TabIndex = 29;
			this.label15.Text = "Leans:";
			// 
			// AddObjectButton
			// 
			this.AddObjectButton.Location = new System.Drawing.Point(14, 667);
			this.AddObjectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.AddObjectButton.Name = "AddObjectButton";
			this.AddObjectButton.Size = new System.Drawing.Size(125, 40);
			this.AddObjectButton.TabIndex = 30;
			this.AddObjectButton.Text = "Add";
			this.AddObjectButton.UseVisualStyleBackColor = true;
			this.AddObjectButton.Click += new System.EventHandler(this.AddObjectButton_Click);
			// 
			// RemoveObjectButton
			// 
			this.RemoveObjectButton.Location = new System.Drawing.Point(145, 667);
			this.RemoveObjectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.RemoveObjectButton.Name = "RemoveObjectButton";
			this.RemoveObjectButton.Size = new System.Drawing.Size(122, 40);
			this.RemoveObjectButton.TabIndex = 31;
			this.RemoveObjectButton.Text = "Remove";
			this.RemoveObjectButton.UseVisualStyleBackColor = true;
			this.RemoveObjectButton.Click += new System.EventHandler(this.RemoveObjectButton_Click);
			// 
			// OpenObjFileDialog
			// 
			this.OpenObjFileDialog.Filter = "OBJ files|*.obj";
			this.OpenObjFileDialog.InitialDirectory = "D:\\CODE\\ACG\\Objects";
			this.OpenObjFileDialog.Title = "Pick OBJ file";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label11.Location = new System.Drawing.Point(985, 766);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(33, 23);
			this.label11.TabIndex = 37;
			this.label11.Text = "YZ:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label16.Location = new System.Drawing.Point(1097, 766);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(34, 23);
			this.label16.TabIndex = 36;
			this.label16.Text = "XZ:";
			// 
			// labelXY
			// 
			this.labelXY.AutoSize = true;
			this.labelXY.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelXY.Location = new System.Drawing.Point(1199, 764);
			this.labelXY.Name = "labelXY";
			this.labelXY.Size = new System.Drawing.Size(33, 23);
			this.labelXY.TabIndex = 35;
			this.labelXY.Text = "XY:";
			// 
			// CameraLeanYZ
			// 
			this.CameraLeanYZ.Location = new System.Drawing.Point(1025, 762);
			this.CameraLeanYZ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CameraLeanYZ.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.CameraLeanYZ.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
			this.CameraLeanYZ.Name = "CameraLeanYZ";
			this.CameraLeanYZ.Size = new System.Drawing.Size(51, 27);
			this.CameraLeanYZ.TabIndex = 34;
			// 
			// CameraLeanXY
			// 
			this.CameraLeanXY.Location = new System.Drawing.Point(1240, 762);
			this.CameraLeanXY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CameraLeanXY.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.CameraLeanXY.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
			this.CameraLeanXY.Name = "CameraLeanXY";
			this.CameraLeanXY.Size = new System.Drawing.Size(51, 27);
			this.CameraLeanXY.TabIndex = 33;
			// 
			// CameraLeanXZ
			// 
			this.CameraLeanXZ.Location = new System.Drawing.Point(1134, 764);
			this.CameraLeanXZ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CameraLeanXZ.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.CameraLeanXZ.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
			this.CameraLeanXZ.Name = "CameraLeanXZ";
			this.CameraLeanXZ.Size = new System.Drawing.Size(51, 27);
			this.CameraLeanXZ.TabIndex = 32;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label17.Location = new System.Drawing.Point(444, 817);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(60, 25);
			this.label17.TabIndex = 44;
			this.label17.Text = "Scale:";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label18.Location = new System.Drawing.Point(526, 816);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(24, 23);
			this.label18.TabIndex = 43;
			this.label18.Text = "X:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label19.Location = new System.Drawing.Point(630, 816);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(23, 23);
			this.label19.TabIndex = 42;
			this.label19.Text = "Y:";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label20.Location = new System.Drawing.Point(738, 818);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(24, 23);
			this.label20.TabIndex = 41;
			this.label20.Text = "Z:";
			// 
			// ObjectScaleX
			// 
			this.ObjectScaleX.DecimalPlaces = 1;
			this.ObjectScaleX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.ObjectScaleX.Location = new System.Drawing.Point(564, 815);
			this.ObjectScaleX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ObjectScaleX.Name = "ObjectScaleX";
			this.ObjectScaleX.Size = new System.Drawing.Size(51, 27);
			this.ObjectScaleX.TabIndex = 40;
			// 
			// ObjectScaleZ
			// 
			this.ObjectScaleZ.DecimalPlaces = 1;
			this.ObjectScaleZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.ObjectScaleZ.Location = new System.Drawing.Point(779, 815);
			this.ObjectScaleZ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ObjectScaleZ.Name = "ObjectScaleZ";
			this.ObjectScaleZ.Size = new System.Drawing.Size(51, 27);
			this.ObjectScaleZ.TabIndex = 39;
			// 
			// ObjectScaleY
			// 
			this.ObjectScaleY.DecimalPlaces = 1;
			this.ObjectScaleY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.ObjectScaleY.Location = new System.Drawing.Point(667, 814);
			this.ObjectScaleY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ObjectScaleY.Name = "ObjectScaleY";
			this.ObjectScaleY.Size = new System.Drawing.Size(51, 27);
			this.ObjectScaleY.TabIndex = 38;
			// 
			// UseCameraRadioButtion
			// 
			this.UseCameraRadioButtion.AutoSize = true;
			this.UseCameraRadioButtion.Location = new System.Drawing.Point(96, 12);
			this.UseCameraRadioButtion.Name = "UseCameraRadioButtion";
			this.UseCameraRadioButtion.Size = new System.Drawing.Size(81, 24);
			this.UseCameraRadioButtion.TabIndex = 45;
			this.UseCameraRadioButtion.TabStop = true;
			this.UseCameraRadioButtion.Text = "Camera";
			this.UseCameraRadioButtion.UseVisualStyleBackColor = true;
			this.UseCameraRadioButtion.CheckedChanged += new System.EventHandler(this.UseCameraRadioButtion_CheckedChanged);
			// 
			// UseObjectRadioButton
			// 
			this.UseObjectRadioButton.AutoSize = true;
			this.UseObjectRadioButton.Location = new System.Drawing.Point(183, 12);
			this.UseObjectRadioButton.Name = "UseObjectRadioButton";
			this.UseObjectRadioButton.Size = new System.Drawing.Size(74, 24);
			this.UseObjectRadioButton.TabIndex = 46;
			this.UseObjectRadioButton.TabStop = true;
			this.UseObjectRadioButton.Text = "Object";
			this.UseObjectRadioButton.UseVisualStyleBackColor = true;
			this.UseObjectRadioButton.CheckedChanged += new System.EventHandler(this.UseObjectRadioButton_CheckedChanged);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label21.Location = new System.Drawing.Point(6, 10);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(82, 28);
			this.label21.TabIndex = 47;
			this.label21.Text = "Control:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label21);
			this.groupBox1.Controls.Add(this.UseObjectRadioButton);
			this.groupBox1.Controls.Add(this.UseCameraRadioButtion);
			this.groupBox1.Location = new System.Drawing.Point(1018, 901);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(273, 41);
			this.groupBox1.TabIndex = 48;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label22);
			this.groupBox2.Controls.Add(this.ObjectLockNoRadioButton);
			this.groupBox2.Controls.Add(this.ObjectLockYesRadioButton);
			this.groupBox2.Location = new System.Drawing.Point(1018, 950);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(274, 41);
			this.groupBox2.TabIndex = 49;
			this.groupBox2.TabStop = false;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label22.Location = new System.Drawing.Point(7, 9);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(119, 28);
			this.label22.TabIndex = 47;
			this.label22.Text = "Object Lock:";
			// 
			// ObjectLockNoRadioButton
			// 
			this.ObjectLockNoRadioButton.AutoSize = true;
			this.ObjectLockNoRadioButton.Location = new System.Drawing.Point(195, 13);
			this.ObjectLockNoRadioButton.Name = "ObjectLockNoRadioButton";
			this.ObjectLockNoRadioButton.Size = new System.Drawing.Size(50, 24);
			this.ObjectLockNoRadioButton.TabIndex = 46;
			this.ObjectLockNoRadioButton.TabStop = true;
			this.ObjectLockNoRadioButton.Text = "No";
			this.ObjectLockNoRadioButton.UseVisualStyleBackColor = true;
			// 
			// ObjectLockYesRadioButton
			// 
			this.ObjectLockYesRadioButton.AutoSize = true;
			this.ObjectLockYesRadioButton.Location = new System.Drawing.Point(132, 13);
			this.ObjectLockYesRadioButton.Name = "ObjectLockYesRadioButton";
			this.ObjectLockYesRadioButton.Size = new System.Drawing.Size(51, 24);
			this.ObjectLockYesRadioButton.TabIndex = 45;
			this.ObjectLockYesRadioButton.TabStop = true;
			this.ObjectLockYesRadioButton.Text = "Yes";
			this.ObjectLockYesRadioButton.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1305, 1011);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.ObjectScaleX);
			this.Controls.Add(this.ObjectScaleZ);
			this.Controls.Add(this.ObjectScaleY);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.labelXY);
			this.Controls.Add(this.CameraLeanYZ);
			this.Controls.Add(this.CameraLeanXY);
			this.Controls.Add(this.CameraLeanXZ);
			this.Controls.Add(this.RemoveObjectButton);
			this.Controls.Add(this.AddObjectButton);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.labelYZ);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.CurrentObjLeanYZ);
			this.Controls.Add(this.CurrentObjLeanXY);
			this.Controls.Add(this.CurrentObjLeanXZ);
			this.Controls.Add(this.SetObjectSettingsButton);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.CurrentObjZ);
			this.Controls.Add(this.CurrentObjX);
			this.Controls.Add(this.CurrentObjY);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.CameraScreenDist);
			this.Controls.Add(this.CameraFoV);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.SetCameraSettingsButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CameraZ);
			this.Controls.Add(this.CameraX);
			this.Controls.Add(this.CameraY);
			this.Controls.Add(this.RenderObjectsList);
			this.Controls.Add(this.DrawField);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.DrawField)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraFoV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraScreenDist)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjLeanYZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjLeanXY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjLeanXZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraLeanYZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraLeanXY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraLeanXZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ObjectScaleX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ObjectScaleZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ObjectScaleY)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private PictureBox DrawField;
    private ListBox RenderObjectsList;
    private NumericUpDown CameraY;
    private NumericUpDown CameraX;
    private NumericUpDown CameraZ;
    private Label label1;
	private Label label2;
	private Label label3;
	private Button SetCameraSettingsButton;
	private Label label4;
	private NumericUpDown CameraFoV;
	private NumericUpDown CameraScreenDist;
	private Label label5;
	private Label label6;
	private Label label7;
	private Label label8;
	private Label label9;
	private Label label10;
	private NumericUpDown CurrentObjZ;
	private NumericUpDown CurrentObjX;
	private NumericUpDown CurrentObjY;
	private Button SetObjectSettingsButton;
	private Label labelYZ;
	private Label label12;
	private Label label13;
	private NumericUpDown CurrentObjLeanYZ;
	private NumericUpDown CurrentObjLeanXY;
	private NumericUpDown CurrentObjLeanXZ;
	private Label label14;
	private Label label15;
	private Button AddObjectButton;
	private Button RemoveObjectButton;
	private OpenFileDialog OpenObjFileDialog;
	private Label label11;
	private Label label16;
	private Label labelXY;
	private NumericUpDown CameraLeanYZ;
	private NumericUpDown CameraLeanXY;
	private NumericUpDown CameraLeanXZ;
	private Label label17;
	private Label label18;
	private Label label19;
	private Label label20;
	private NumericUpDown ObjectScaleX;
	private NumericUpDown ObjectScaleZ;
	private NumericUpDown ObjectScaleY;
	private RadioButton UseCameraRadioButtion;
	private RadioButton UseObjectRadioButton;
	private Label label21;
	private GroupBox groupBox1;
	private GroupBox groupBox2;
	private Label label22;
	private RadioButton ObjectLockNoRadioButton;
	private RadioButton ObjectLockYesRadioButton;
}