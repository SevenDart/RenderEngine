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
			this.FarPlaneDist = new System.Windows.Forms.NumericUpDown();
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
			this.CurrentObjectYaw = new System.Windows.Forms.NumericUpDown();
			this.CurrentObjectRoll = new System.Windows.Forms.NumericUpDown();
			this.CurrentObjectPitch = new System.Windows.Forms.NumericUpDown();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.AddObjectButton = new System.Windows.Forms.Button();
			this.RemoveObjectButton = new System.Windows.Forms.Button();
			this.OpenObjFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.label11 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.labelXY = new System.Windows.Forms.Label();
			this.CameraYaw = new System.Windows.Forms.NumericUpDown();
			this.CameraRoll = new System.Windows.Forms.NumericUpDown();
			this.CameraPitch = new System.Windows.Forms.NumericUpDown();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.ObjectScaleX = new System.Windows.Forms.NumericUpDown();
			this.ObjectScaleZ = new System.Windows.Forms.NumericUpDown();
			this.ObjectScaleY = new System.Windows.Forms.NumericUpDown();
			this.UseCameraRadioButton = new System.Windows.Forms.RadioButton();
			this.UseObjectRadioButton = new System.Windows.Forms.RadioButton();
			this.label21 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label22 = new System.Windows.Forms.Label();
			this.ObjectLockNoRadioButton = new System.Windows.Forms.RadioButton();
			this.ObjectLockYesRadioButton = new System.Windows.Forms.RadioButton();
			this.MovementSpeedControl = new System.Windows.Forms.NumericUpDown();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.MouseSpeedControl = new System.Windows.Forms.NumericUpDown();
			this.label25 = new System.Windows.Forms.Label();
			this.NearPlaneDist = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.DrawField)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraZ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraFoV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FarPlaneDist)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjZ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjectYaw)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjectRoll)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjectPitch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraYaw)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraRoll)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraPitch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ObjectScaleX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ObjectScaleZ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ObjectScaleY)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MovementSpeedControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MouseSpeedControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NearPlaneDist)).BeginInit();
			this.SuspendLayout();
			// 
			// DrawField
			// 
			this.DrawField.BackColor = System.Drawing.Color.White;
			this.DrawField.Location = new System.Drawing.Point(274, 8);
			this.DrawField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.DrawField.Name = "DrawField";
			this.DrawField.Size = new System.Drawing.Size(1006, 660);
			this.DrawField.TabIndex = 0;
			this.DrawField.TabStop = false;
			this.DrawField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawField_MouseDown);
			this.DrawField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawField_MouseMove);
			this.DrawField.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawField_MouseUp);
			// 
			// RenderObjectsList
			// 
			this.RenderObjectsList.FormattingEnabled = true;
			this.RenderObjectsList.ItemHeight = 20;
			this.RenderObjectsList.Location = new System.Drawing.Point(14, 8);
			this.RenderObjectsList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.RenderObjectsList.Name = "RenderObjectsList";
			this.RenderObjectsList.Size = new System.Drawing.Size(253, 664);
			this.RenderObjectsList.TabIndex = 1;
			this.RenderObjectsList.SelectedIndexChanged += new System.EventHandler(this.RenderObjectsList_SelectedIndexChanged);
			// 
			// CameraY
			// 
			this.CameraY.DecimalPlaces = 3;
			this.CameraY.Location = new System.Drawing.Point(1080, 733);
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
			this.CameraX.Location = new System.Drawing.Point(973, 732);
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
			this.CameraZ.Location = new System.Drawing.Point(1190, 732);
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
			this.label1.Location = new System.Drawing.Point(945, 735);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "X:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(1054, 733);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Y:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(1160, 735);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Z:";
			// 
			// SetCameraSettingsButton
			// 
			this.SetCameraSettingsButton.Location = new System.Drawing.Point(1098, 938);
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
			this.label4.Location = new System.Drawing.Point(1038, 692);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(154, 28);
			this.label4.TabIndex = 9;
			this.label4.Text = "Camera Settings";
			// 
			// CameraFoV
			// 
			this.CameraFoV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CameraFoV.Location = new System.Drawing.Point(1002, 837);
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
			// FarPlaneDist
			// 
			this.FarPlaneDist.Location = new System.Drawing.Point(1198, 837);
			this.FarPlaneDist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.FarPlaneDist.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.FarPlaneDist.Name = "FarPlaneDist";
			this.FarPlaneDist.Size = new System.Drawing.Size(71, 27);
			this.FarPlaneDist.TabIndex = 11;
			this.FarPlaneDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.FarPlaneDist.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(953, 840);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "FoV:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(1101, 835);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 23);
			this.label6.TabIndex = 13;
			this.label6.Text = "Far Plane:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label7.Location = new System.Drawing.Point(586, 692);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(146, 28);
			this.label7.TabIndex = 14;
			this.label7.Text = "Object Settings";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label8.Location = new System.Drawing.Point(713, 732);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(24, 23);
			this.label8.TabIndex = 20;
			this.label8.Text = "Z:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label9.Location = new System.Drawing.Point(602, 733);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(23, 23);
			this.label9.TabIndex = 19;
			this.label9.Text = "Y:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label10.Location = new System.Drawing.Point(485, 736);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(24, 23);
			this.label10.TabIndex = 18;
			this.label10.Text = "X:";
			// 
			// CurrentObjZ
			// 
			this.CurrentObjZ.DecimalPlaces = 3;
			this.CurrentObjZ.Location = new System.Drawing.Point(743, 731);
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
			this.CurrentObjX.Location = new System.Drawing.Point(514, 732);
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
			this.CurrentObjY.Location = new System.Drawing.Point(629, 732);
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
			this.SetObjectSettingsButton.Location = new System.Drawing.Point(609, 884);
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
			this.labelYZ.Location = new System.Drawing.Point(485, 789);
			this.labelYZ.Name = "labelYZ";
			this.labelYZ.Size = new System.Drawing.Size(43, 23);
			this.labelYZ.TabIndex = 27;
			this.labelYZ.Text = "Yaw:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label12.Location = new System.Drawing.Point(591, 791);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(52, 23);
			this.label12.TabIndex = 26;
			this.label12.Text = "Pitch:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label13.Location = new System.Drawing.Point(711, 789);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(42, 23);
			this.label13.TabIndex = 25;
			this.label13.Text = "Roll:";
			// 
			// CurrentObjectYaw
			// 
			this.CurrentObjectYaw.Location = new System.Drawing.Point(533, 785);
			this.CurrentObjectYaw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CurrentObjectYaw.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.CurrentObjectYaw.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
			this.CurrentObjectYaw.Name = "CurrentObjectYaw";
			this.CurrentObjectYaw.Size = new System.Drawing.Size(51, 27);
			this.CurrentObjectYaw.TabIndex = 24;
			// 
			// CurrentObjectRoll
			// 
			this.CurrentObjectRoll.Location = new System.Drawing.Point(757, 787);
			this.CurrentObjectRoll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CurrentObjectRoll.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.CurrentObjectRoll.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
			this.CurrentObjectRoll.Name = "CurrentObjectRoll";
			this.CurrentObjectRoll.Size = new System.Drawing.Size(51, 27);
			this.CurrentObjectRoll.TabIndex = 23;
			// 
			// CurrentObjectPitch
			// 
			this.CurrentObjectPitch.Location = new System.Drawing.Point(645, 785);
			this.CurrentObjectPitch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CurrentObjectPitch.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.CurrentObjectPitch.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
			this.CurrentObjectPitch.Name = "CurrentObjectPitch";
			this.CurrentObjectPitch.Size = new System.Drawing.Size(51, 27);
			this.CurrentObjectPitch.TabIndex = 22;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label14.Location = new System.Drawing.Point(393, 736);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(83, 25);
			this.label14.TabIndex = 28;
			this.label14.Text = "Position:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label15.Location = new System.Drawing.Point(421, 789);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(64, 25);
			this.label15.TabIndex = 29;
			this.label15.Text = "Leans:";
			// 
			// AddObjectButton
			// 
			this.AddObjectButton.Location = new System.Drawing.Point(14, 688);
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
			this.RemoveObjectButton.Location = new System.Drawing.Point(145, 688);
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
			this.label11.Location = new System.Drawing.Point(954, 787);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(43, 23);
			this.label11.TabIndex = 37;
			this.label11.Text = "Yaw:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label16.Location = new System.Drawing.Point(1056, 787);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(52, 23);
			this.label16.TabIndex = 36;
			this.label16.Text = "Pitch:";
			// 
			// labelXY
			// 
			this.labelXY.AutoSize = true;
			this.labelXY.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelXY.Location = new System.Drawing.Point(1169, 787);
			this.labelXY.Name = "labelXY";
			this.labelXY.Size = new System.Drawing.Size(42, 23);
			this.labelXY.TabIndex = 35;
			this.labelXY.Text = "Roll:";
			// 
			// CameraYaw
			// 
			this.CameraYaw.Location = new System.Drawing.Point(1002, 784);
			this.CameraYaw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CameraYaw.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.CameraYaw.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
			this.CameraYaw.Name = "CameraYaw";
			this.CameraYaw.Size = new System.Drawing.Size(51, 27);
			this.CameraYaw.TabIndex = 34;
			// 
			// CameraRoll
			// 
			this.CameraRoll.Location = new System.Drawing.Point(1217, 784);
			this.CameraRoll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CameraRoll.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.CameraRoll.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
			this.CameraRoll.Name = "CameraRoll";
			this.CameraRoll.Size = new System.Drawing.Size(51, 27);
			this.CameraRoll.TabIndex = 33;
			// 
			// CameraPitch
			// 
			this.CameraPitch.Location = new System.Drawing.Point(1111, 785);
			this.CameraPitch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CameraPitch.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.CameraPitch.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
			this.CameraPitch.Name = "CameraPitch";
			this.CameraPitch.Size = new System.Drawing.Size(51, 27);
			this.CameraPitch.TabIndex = 32;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label17.Location = new System.Drawing.Point(421, 839);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(60, 25);
			this.label17.TabIndex = 44;
			this.label17.Text = "Scale:";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label18.Location = new System.Drawing.Point(503, 837);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(24, 23);
			this.label18.TabIndex = 43;
			this.label18.Text = "X:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label19.Location = new System.Drawing.Point(607, 837);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(23, 23);
			this.label19.TabIndex = 42;
			this.label19.Text = "Y:";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label20.Location = new System.Drawing.Point(715, 840);
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
			this.ObjectScaleX.Location = new System.Drawing.Point(542, 836);
			this.ObjectScaleX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ObjectScaleX.Name = "ObjectScaleX";
			this.ObjectScaleX.Size = new System.Drawing.Size(51, 27);
			this.ObjectScaleX.TabIndex = 40;
			this.ObjectScaleX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// ObjectScaleZ
			// 
			this.ObjectScaleZ.DecimalPlaces = 1;
			this.ObjectScaleZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.ObjectScaleZ.Location = new System.Drawing.Point(757, 836);
			this.ObjectScaleZ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ObjectScaleZ.Name = "ObjectScaleZ";
			this.ObjectScaleZ.Size = new System.Drawing.Size(51, 27);
			this.ObjectScaleZ.TabIndex = 39;
			this.ObjectScaleZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// ObjectScaleY
			// 
			this.ObjectScaleY.DecimalPlaces = 1;
			this.ObjectScaleY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.ObjectScaleY.Location = new System.Drawing.Point(645, 835);
			this.ObjectScaleY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ObjectScaleY.Name = "ObjectScaleY";
			this.ObjectScaleY.Size = new System.Drawing.Size(51, 27);
			this.ObjectScaleY.TabIndex = 38;
			this.ObjectScaleY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// UseCameraRadioButton
			// 
			this.UseCameraRadioButton.AutoSize = true;
			this.UseCameraRadioButton.Checked = true;
			this.UseCameraRadioButton.Location = new System.Drawing.Point(96, 12);
			this.UseCameraRadioButton.Name = "UseCameraRadioButton";
			this.UseCameraRadioButton.Size = new System.Drawing.Size(81, 24);
			this.UseCameraRadioButton.TabIndex = 45;
			this.UseCameraRadioButton.TabStop = true;
			this.UseCameraRadioButton.Text = "Camera";
			this.UseCameraRadioButton.UseVisualStyleBackColor = true;
			this.UseCameraRadioButton.CheckedChanged += new System.EventHandler(this.UseCameraRadioButton_CheckedChanged);
			// 
			// UseObjectRadioButton
			// 
			this.UseObjectRadioButton.AutoSize = true;
			this.UseObjectRadioButton.Location = new System.Drawing.Point(183, 12);
			this.UseObjectRadioButton.Name = "UseObjectRadioButton";
			this.UseObjectRadioButton.Size = new System.Drawing.Size(74, 24);
			this.UseObjectRadioButton.TabIndex = 46;
			this.UseObjectRadioButton.Text = "Object";
			this.UseObjectRadioButton.UseVisualStyleBackColor = true;
			this.UseObjectRadioButton.CheckedChanged += new System.EventHandler(this.UseObjectRadioButton_CheckedChanged);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label21.Location = new System.Drawing.Point(6, 11);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(82, 28);
			this.label21.TabIndex = 47;
			this.label21.Text = "Control:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label21);
			this.groupBox1.Controls.Add(this.UseObjectRadioButton);
			this.groupBox1.Controls.Add(this.UseCameraRadioButton);
			this.groupBox1.Location = new System.Drawing.Point(14, 744);
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
			this.groupBox2.Location = new System.Drawing.Point(14, 793);
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
			this.ObjectLockNoRadioButton.Checked = true;
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
			this.ObjectLockYesRadioButton.Location = new System.Drawing.Point(133, 13);
			this.ObjectLockYesRadioButton.Name = "ObjectLockYesRadioButton";
			this.ObjectLockYesRadioButton.Size = new System.Drawing.Size(51, 24);
			this.ObjectLockYesRadioButton.TabIndex = 45;
			this.ObjectLockYesRadioButton.TabStop = true;
			this.ObjectLockYesRadioButton.Text = "Yes";
			this.ObjectLockYesRadioButton.UseVisualStyleBackColor = true;
			// 
			// MovementSpeedControl
			// 
			this.MovementSpeedControl.DecimalPlaces = 1;
			this.MovementSpeedControl.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.MovementSpeedControl.Location = new System.Drawing.Point(181, 859);
			this.MovementSpeedControl.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.MovementSpeedControl.Name = "MovementSpeedControl";
			this.MovementSpeedControl.Size = new System.Drawing.Size(107, 27);
			this.MovementSpeedControl.TabIndex = 50;
			this.MovementSpeedControl.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.MovementSpeedControl.ValueChanged += new System.EventHandler(this.SetMovementSpeed);
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label23.Location = new System.Drawing.Point(11, 859);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(146, 23);
			this.label23.TabIndex = 51;
			this.label23.Text = "Movement speed:";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label24.Location = new System.Drawing.Point(11, 892);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(115, 23);
			this.label24.TabIndex = 53;
			this.label24.Text = "Mouse speed:";
			// 
			// MouseSpeedControl
			// 
			this.MouseSpeedControl.DecimalPlaces = 1;
			this.MouseSpeedControl.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.MouseSpeedControl.Location = new System.Drawing.Point(181, 892);
			this.MouseSpeedControl.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.MouseSpeedControl.Name = "MouseSpeedControl";
			this.MouseSpeedControl.Size = new System.Drawing.Size(107, 27);
			this.MouseSpeedControl.TabIndex = 52;
			this.MouseSpeedControl.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.MouseSpeedControl.ValueChanged += new System.EventHandler(this.SetMovementSpeed);
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label25.Location = new System.Drawing.Point(1086, 885);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(98, 23);
			this.label25.TabIndex = 55;
			this.label25.Text = "Near Plane:";
			// 
			// NearPlaneDist
			// 
			this.NearPlaneDist.DecimalPlaces = 3;
			this.NearPlaneDist.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.NearPlaneDist.Location = new System.Drawing.Point(1198, 881);
			this.NearPlaneDist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.NearPlaneDist.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.NearPlaneDist.Name = "NearPlaneDist";
			this.NearPlaneDist.Size = new System.Drawing.Size(71, 27);
			this.NearPlaneDist.TabIndex = 54;
			this.NearPlaneDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.NearPlaneDist.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1305, 1011);
			this.Controls.Add(this.label25);
			this.Controls.Add(this.NearPlaneDist);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.MouseSpeedControl);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.MovementSpeedControl);
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
			this.Controls.Add(this.CameraYaw);
			this.Controls.Add(this.CameraRoll);
			this.Controls.Add(this.CameraPitch);
			this.Controls.Add(this.RemoveObjectButton);
			this.Controls.Add(this.AddObjectButton);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.labelYZ);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.CurrentObjectYaw);
			this.Controls.Add(this.CurrentObjectRoll);
			this.Controls.Add(this.CurrentObjectPitch);
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
			this.Controls.Add(this.FarPlaneDist);
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
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.DrawField)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraFoV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FarPlaneDist)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjectYaw)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjectRoll)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentObjectPitch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraYaw)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraRoll)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraPitch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ObjectScaleX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ObjectScaleZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ObjectScaleY)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MovementSpeedControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MouseSpeedControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NearPlaneDist)).EndInit();
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
	private NumericUpDown FarPlaneDist;
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
	private NumericUpDown CurrentObjectYaw;
	private NumericUpDown CurrentObjectRoll;
	private NumericUpDown CurrentObjectPitch;
	private Label label14;
	private Label label15;
	private Button AddObjectButton;
	private Button RemoveObjectButton;
	private OpenFileDialog OpenObjFileDialog;
	private Label label11;
	private Label label16;
	private Label labelXY;
	private NumericUpDown CameraYaw;
	private NumericUpDown CameraRoll;
	private NumericUpDown CameraPitch;
	private Label label17;
	private Label label18;
	private Label label19;
	private Label label20;
	private NumericUpDown ObjectScaleX;
	private NumericUpDown ObjectScaleZ;
	private NumericUpDown ObjectScaleY;
	private RadioButton UseCameraRadioButton;
	private RadioButton UseObjectRadioButton;
	private Label label21;
	private GroupBox groupBox1;
	private GroupBox groupBox2;
	private Label label22;
	private RadioButton ObjectLockNoRadioButton;
	private RadioButton ObjectLockYesRadioButton;
	private NumericUpDown MovementSpeedControl;
	private Label label23;
	private Label label24;
	private NumericUpDown MouseSpeedControl;
	private Label label25;
	private NumericUpDown NearPlaneDist;
}