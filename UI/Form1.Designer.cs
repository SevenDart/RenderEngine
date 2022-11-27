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
			this.UseLightRadioButton = new System.Windows.Forms.RadioButton();
			this.MovementSpeedControl = new System.Windows.Forms.NumericUpDown();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.MouseSpeedControl = new System.Windows.Forms.NumericUpDown();
			this.label25 = new System.Windows.Forms.Label();
			this.NearPlaneDist = new System.Windows.Forms.NumericUpDown();
			this.label22 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.LightColorR = new System.Windows.Forms.NumericUpDown();
			this.LightColorB = new System.Windows.Forms.NumericUpDown();
			this.LightColorG = new System.Windows.Forms.NumericUpDown();
			this.label28 = new System.Windows.Forms.Label();
			this.SetLightSettings = new System.Windows.Forms.Button();
			this.label29 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.LightPositionZ = new System.Windows.Forms.NumericUpDown();
			this.LightPositionX = new System.Windows.Forms.NumericUpDown();
			this.LightPositionY = new System.Windows.Forms.NumericUpDown();
			this.label32 = new System.Windows.Forms.Label();
			this.LightIntensity = new System.Windows.Forms.NumericUpDown();
			this.label33 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.label36 = new System.Windows.Forms.Label();
			this.label37 = new System.Windows.Forms.Label();
			this.label38 = new System.Windows.Forms.Label();
			this.AmbientCoefficientControl = new System.Windows.Forms.NumericUpDown();
			this.ReflectCoefficientControl = new System.Windows.Forms.NumericUpDown();
			this.DiffuseCoefficientControl = new System.Windows.Forms.NumericUpDown();
			this.label39 = new System.Windows.Forms.Label();
			this.GlitterCoefficientControl = new System.Windows.Forms.NumericUpDown();
			this.SetObjectColorDialog = new System.Windows.Forms.ColorDialog();
			this.ChooseColorButton = new System.Windows.Forms.Button();
			this.debugInfo = new System.Windows.Forms.Label();
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
			((System.ComponentModel.ISupportInitialize)(this.MovementSpeedControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MouseSpeedControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NearPlaneDist)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LightColorR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LightColorB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LightColorG)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LightPositionZ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LightPositionX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LightPositionY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LightIntensity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AmbientCoefficientControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ReflectCoefficientControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DiffuseCoefficientControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GlitterCoefficientControl)).BeginInit();
			this.SuspendLayout();
			// 
			// DrawField
			// 
			this.DrawField.BackColor = System.Drawing.Color.White;
			this.DrawField.Location = new System.Drawing.Point(166, 8);
			this.DrawField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.DrawField.Name = "DrawField";
			this.DrawField.Size = new System.Drawing.Size(1169, 665);
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
			this.RenderObjectsList.Size = new System.Drawing.Size(141, 664);
			this.RenderObjectsList.TabIndex = 1;
			this.RenderObjectsList.SelectedIndexChanged += new System.EventHandler(this.RenderObjectsList_SelectedIndexChanged);
			// 
			// CameraY
			// 
			this.CameraY.DecimalPlaces = 3;
			this.CameraY.Location = new System.Drawing.Point(623, 760);
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
			this.CameraX.Location = new System.Drawing.Point(623, 731);
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
			this.CameraZ.Location = new System.Drawing.Point(623, 789);
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
            4,
            0,
            0,
            -2147483648});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(593, 731);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "X:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(593, 760);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Y:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(593, 791);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Z:";
			// 
			// SetCameraSettingsButton
			// 
			this.SetCameraSettingsButton.Location = new System.Drawing.Point(737, 825);
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
			this.label4.Location = new System.Drawing.Point(704, 675);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(154, 28);
			this.label4.TabIndex = 9;
			this.label4.Text = "Camera Settings";
			// 
			// CameraFoV
			// 
			this.CameraFoV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CameraFoV.Location = new System.Drawing.Point(901, 728);
			this.CameraFoV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CameraFoV.Name = "CameraFoV";
			this.CameraFoV.Size = new System.Drawing.Size(63, 30);
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
			this.FarPlaneDist.Location = new System.Drawing.Point(901, 759);
			this.FarPlaneDist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.FarPlaneDist.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.FarPlaneDist.Name = "FarPlaneDist";
			this.FarPlaneDist.Size = new System.Drawing.Size(63, 27);
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
			this.label5.Location = new System.Drawing.Point(808, 732);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "FoV:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(808, 761);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 23);
			this.label6.TabIndex = 13;
			this.label6.Text = "Far Plane:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label7.Location = new System.Drawing.Point(306, 677);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(146, 28);
			this.label7.TabIndex = 14;
			this.label7.Text = "Object Settings";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label8.Location = new System.Drawing.Point(192, 799);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(24, 23);
			this.label8.TabIndex = 20;
			this.label8.Text = "Z:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label9.Location = new System.Drawing.Point(192, 764);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(23, 23);
			this.label9.TabIndex = 19;
			this.label9.Text = "Y:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label10.Location = new System.Drawing.Point(192, 739);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(24, 23);
			this.label10.TabIndex = 18;
			this.label10.Text = "X:";
			// 
			// CurrentObjZ
			// 
			this.CurrentObjZ.DecimalPlaces = 3;
			this.CurrentObjZ.Location = new System.Drawing.Point(222, 793);
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
			this.CurrentObjX.Location = new System.Drawing.Point(222, 735);
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
			this.CurrentObjY.Location = new System.Drawing.Point(222, 764);
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
			this.SetObjectSettingsButton.Location = new System.Drawing.Point(306, 828);
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
			this.labelYZ.Location = new System.Drawing.Point(306, 735);
			this.labelYZ.Name = "labelYZ";
			this.labelYZ.Size = new System.Drawing.Size(43, 23);
			this.labelYZ.TabIndex = 27;
			this.labelYZ.Text = "Yaw:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label12.Location = new System.Drawing.Point(306, 764);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(52, 23);
			this.label12.TabIndex = 26;
			this.label12.Text = "Pitch:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label13.Location = new System.Drawing.Point(306, 793);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(42, 23);
			this.label13.TabIndex = 25;
			this.label13.Text = "Roll:";
			// 
			// CurrentObjectYaw
			// 
			this.CurrentObjectYaw.Location = new System.Drawing.Point(362, 735);
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
			this.CurrentObjectRoll.Location = new System.Drawing.Point(362, 793);
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
			this.CurrentObjectPitch.Location = new System.Drawing.Point(362, 764);
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
			this.label14.Location = new System.Drawing.Point(222, 704);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(83, 25);
			this.label14.TabIndex = 28;
			this.label14.Text = "Position:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label15.Location = new System.Drawing.Point(358, 704);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(64, 25);
			this.label15.TabIndex = 29;
			this.label15.Text = "Leans:";
			// 
			// AddObjectButton
			// 
			this.AddObjectButton.Location = new System.Drawing.Point(14, 676);
			this.AddObjectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.AddObjectButton.Name = "AddObjectButton";
			this.AddObjectButton.Size = new System.Drawing.Size(69, 40);
			this.AddObjectButton.TabIndex = 30;
			this.AddObjectButton.Text = "Add";
			this.AddObjectButton.UseVisualStyleBackColor = true;
			this.AddObjectButton.Click += new System.EventHandler(this.AddObjectButton_Click);
			// 
			// RemoveObjectButton
			// 
			this.RemoveObjectButton.Location = new System.Drawing.Point(87, 676);
			this.RemoveObjectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.RemoveObjectButton.Name = "RemoveObjectButton";
			this.RemoveObjectButton.Size = new System.Drawing.Size(69, 40);
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
			this.label11.Location = new System.Drawing.Point(704, 729);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(43, 23);
			this.label11.TabIndex = 37;
			this.label11.Text = "Yaw:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label16.Location = new System.Drawing.Point(704, 759);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(52, 23);
			this.label16.TabIndex = 36;
			this.label16.Text = "Pitch:";
			// 
			// labelXY
			// 
			this.labelXY.AutoSize = true;
			this.labelXY.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelXY.Location = new System.Drawing.Point(704, 789);
			this.labelXY.Name = "labelXY";
			this.labelXY.Size = new System.Drawing.Size(42, 23);
			this.labelXY.TabIndex = 35;
			this.labelXY.Text = "Roll:";
			// 
			// CameraYaw
			// 
			this.CameraYaw.Location = new System.Drawing.Point(755, 728);
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
			this.CameraRoll.Location = new System.Drawing.Point(755, 787);
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
			this.CameraPitch.Location = new System.Drawing.Point(755, 757);
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
			this.label17.Location = new System.Drawing.Point(456, 705);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(60, 25);
			this.label17.TabIndex = 44;
			this.label17.Text = "Scale:";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label18.Location = new System.Drawing.Point(429, 740);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(24, 23);
			this.label18.TabIndex = 43;
			this.label18.Text = "X:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label19.Location = new System.Drawing.Point(429, 772);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(23, 23);
			this.label19.TabIndex = 42;
			this.label19.Text = "Y:";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label20.Location = new System.Drawing.Point(429, 801);
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
			this.ObjectScaleX.Location = new System.Drawing.Point(457, 737);
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
			this.ObjectScaleZ.Location = new System.Drawing.Point(457, 796);
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
			this.ObjectScaleY.Location = new System.Drawing.Point(457, 767);
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
			this.UseCameraRadioButton.Location = new System.Drawing.Point(6, 43);
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
			this.UseObjectRadioButton.Location = new System.Drawing.Point(88, 44);
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
			this.groupBox1.Controls.Add(this.UseLightRadioButton);
			this.groupBox1.Controls.Add(this.label21);
			this.groupBox1.Controls.Add(this.UseObjectRadioButton);
			this.groupBox1.Controls.Add(this.UseCameraRadioButton);
			this.groupBox1.Location = new System.Drawing.Point(14, 721);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(161, 97);
			this.groupBox1.TabIndex = 48;
			this.groupBox1.TabStop = false;
			// 
			// UseLightRadioButton
			// 
			this.UseLightRadioButton.AutoSize = true;
			this.UseLightRadioButton.Location = new System.Drawing.Point(6, 65);
			this.UseLightRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.UseLightRadioButton.Name = "UseLightRadioButton";
			this.UseLightRadioButton.Size = new System.Drawing.Size(63, 24);
			this.UseLightRadioButton.TabIndex = 48;
			this.UseLightRadioButton.TabStop = true;
			this.UseLightRadioButton.Text = "Light";
			this.UseLightRadioButton.UseVisualStyleBackColor = true;
			this.UseLightRadioButton.CheckedChanged += new System.EventHandler(this.UseLightRadioButton_CheckedChanged);
			// 
			// MovementSpeedControl
			// 
			this.MovementSpeedControl.DecimalPlaces = 1;
			this.MovementSpeedControl.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.MovementSpeedControl.Location = new System.Drawing.Point(161, 833);
			this.MovementSpeedControl.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.MovementSpeedControl.Name = "MovementSpeedControl";
			this.MovementSpeedControl.Size = new System.Drawing.Size(59, 27);
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
			this.label23.Location = new System.Drawing.Point(15, 833);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(146, 23);
			this.label23.TabIndex = 51;
			this.label23.Text = "Movement speed:";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label24.Location = new System.Drawing.Point(15, 868);
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
			this.MouseSpeedControl.Location = new System.Drawing.Point(161, 863);
			this.MouseSpeedControl.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.MouseSpeedControl.Name = "MouseSpeedControl";
			this.MouseSpeedControl.Size = new System.Drawing.Size(59, 27);
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
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label25.Location = new System.Drawing.Point(808, 789);
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
			this.NearPlaneDist.Location = new System.Drawing.Point(901, 788);
			this.NearPlaneDist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.NearPlaneDist.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.NearPlaneDist.Name = "NearPlaneDist";
			this.NearPlaneDist.Size = new System.Drawing.Size(63, 27);
			this.NearPlaneDist.TabIndex = 54;
			this.NearPlaneDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.NearPlaneDist.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label22.Location = new System.Drawing.Point(1091, 728);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(24, 23);
			this.label22.TabIndex = 70;
			this.label22.Text = "R:";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label26.Location = new System.Drawing.Point(1090, 757);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(26, 23);
			this.label26.TabIndex = 69;
			this.label26.Text = "G:";
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label27.Location = new System.Drawing.Point(1091, 788);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(24, 23);
			this.label27.TabIndex = 68;
			this.label27.Text = "B:";
			// 
			// LightColorR
			// 
			this.LightColorR.Location = new System.Drawing.Point(1120, 724);
			this.LightColorR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.LightColorR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.LightColorR.Name = "LightColorR";
			this.LightColorR.Size = new System.Drawing.Size(51, 27);
			this.LightColorR.TabIndex = 67;
			this.LightColorR.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
			// 
			// LightColorB
			// 
			this.LightColorB.Location = new System.Drawing.Point(1120, 783);
			this.LightColorB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.LightColorB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.LightColorB.Name = "LightColorB";
			this.LightColorB.Size = new System.Drawing.Size(51, 27);
			this.LightColorB.TabIndex = 66;
			this.LightColorB.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
			// 
			// LightColorG
			// 
			this.LightColorG.Location = new System.Drawing.Point(1120, 753);
			this.LightColorG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.LightColorG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.LightColorG.Name = "LightColorG";
			this.LightColorG.Size = new System.Drawing.Size(51, 27);
			this.LightColorG.TabIndex = 65;
			this.LightColorG.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label28.Location = new System.Drawing.Point(1027, 688);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(132, 28);
			this.label28.TabIndex = 64;
			this.label28.Text = "Light Settings";
			// 
			// SetLightSettings
			// 
			this.SetLightSettings.Location = new System.Drawing.Point(1046, 821);
			this.SetLightSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SetLightSettings.Name = "SetLightSettings";
			this.SetLightSettings.Size = new System.Drawing.Size(86, 31);
			this.SetLightSettings.TabIndex = 63;
			this.SetLightSettings.Text = "Set";
			this.SetLightSettings.UseVisualStyleBackColor = true;
			this.SetLightSettings.Click += new System.EventHandler(this.SetLightSettings_Click);
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label29.Location = new System.Drawing.Point(977, 787);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(24, 23);
			this.label29.TabIndex = 62;
			this.label29.Text = "Z:";
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label30.Location = new System.Drawing.Point(977, 757);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(23, 23);
			this.label30.TabIndex = 61;
			this.label30.Text = "Y:";
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label31.Location = new System.Drawing.Point(977, 728);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(24, 23);
			this.label31.TabIndex = 60;
			this.label31.Text = "X:";
			// 
			// LightPositionZ
			// 
			this.LightPositionZ.DecimalPlaces = 3;
			this.LightPositionZ.Location = new System.Drawing.Point(1007, 784);
			this.LightPositionZ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.LightPositionZ.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.LightPositionZ.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
			this.LightPositionZ.Name = "LightPositionZ";
			this.LightPositionZ.Size = new System.Drawing.Size(78, 27);
			this.LightPositionZ.TabIndex = 59;
			this.LightPositionZ.Value = new decimal(new int[] {
            4,
            0,
            0,
            -2147483648});
			// 
			// LightPositionX
			// 
			this.LightPositionX.DecimalPlaces = 3;
			this.LightPositionX.Location = new System.Drawing.Point(1007, 725);
			this.LightPositionX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.LightPositionX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.LightPositionX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
			this.LightPositionX.Name = "LightPositionX";
			this.LightPositionX.Size = new System.Drawing.Size(78, 27);
			this.LightPositionX.TabIndex = 58;
			// 
			// LightPositionY
			// 
			this.LightPositionY.DecimalPlaces = 3;
			this.LightPositionY.Location = new System.Drawing.Point(1007, 755);
			this.LightPositionY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.LightPositionY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.LightPositionY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
			this.LightPositionY.Name = "LightPositionY";
			this.LightPositionY.Size = new System.Drawing.Size(78, 27);
			this.LightPositionY.TabIndex = 57;
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label32.Location = new System.Drawing.Point(1178, 844);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(79, 23);
			this.label32.TabIndex = 72;
			this.label32.Text = "Intensity:";
			// 
			// LightIntensity
			// 
			this.LightIntensity.DecimalPlaces = 2;
			this.LightIntensity.Location = new System.Drawing.Point(1258, 840);
			this.LightIntensity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.LightIntensity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.LightIntensity.Name = "LightIntensity";
			this.LightIntensity.Size = new System.Drawing.Size(77, 27);
			this.LightIntensity.TabIndex = 71;
			this.LightIntensity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label33.Location = new System.Drawing.Point(511, 739);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(24, 23);
			this.label33.TabIndex = 78;
			this.label33.Text = "R:";
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label34.Location = new System.Drawing.Point(510, 768);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(26, 23);
			this.label34.TabIndex = 77;
			this.label34.Text = "G:";
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label35.Location = new System.Drawing.Point(511, 799);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(24, 23);
			this.label35.TabIndex = 76;
			this.label35.Text = "B:";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(539, 735);
			this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(51, 27);
			this.numericUpDown1.TabIndex = 75;
			this.numericUpDown1.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(539, 793);
			this.numericUpDown2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.numericUpDown2.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(51, 27);
			this.numericUpDown2.TabIndex = 74;
			this.numericUpDown2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Location = new System.Drawing.Point(539, 764);
			this.numericUpDown3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.numericUpDown3.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.numericUpDown3.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(51, 27);
			this.numericUpDown3.TabIndex = 73;
			this.numericUpDown3.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label36.Location = new System.Drawing.Point(1178, 727);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(79, 23);
			this.label36.TabIndex = 84;
			this.label36.Text = "Ambient:";
			// 
			// label37
			// 
			this.label37.AutoSize = true;
			this.label37.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label37.Location = new System.Drawing.Point(1178, 757);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(66, 23);
			this.label37.TabIndex = 83;
			this.label37.Text = "Diffuse:";
			// 
			// label38
			// 
			this.label38.AutoSize = true;
			this.label38.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label38.Location = new System.Drawing.Point(1178, 787);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(65, 23);
			this.label38.TabIndex = 82;
			this.label38.Text = "Reflect:";
			// 
			// AmbientCoefficientControl
			// 
			this.AmbientCoefficientControl.DecimalPlaces = 3;
			this.AmbientCoefficientControl.Location = new System.Drawing.Point(1258, 723);
			this.AmbientCoefficientControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.AmbientCoefficientControl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.AmbientCoefficientControl.Name = "AmbientCoefficientControl";
			this.AmbientCoefficientControl.Size = new System.Drawing.Size(77, 27);
			this.AmbientCoefficientControl.TabIndex = 81;
			this.AmbientCoefficientControl.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			// 
			// ReflectCoefficientControl
			// 
			this.ReflectCoefficientControl.DecimalPlaces = 3;
			this.ReflectCoefficientControl.Location = new System.Drawing.Point(1258, 781);
			this.ReflectCoefficientControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ReflectCoefficientControl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.ReflectCoefficientControl.Name = "ReflectCoefficientControl";
			this.ReflectCoefficientControl.Size = new System.Drawing.Size(77, 27);
			this.ReflectCoefficientControl.TabIndex = 80;
			this.ReflectCoefficientControl.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			// 
			// DiffuseCoefficientControl
			// 
			this.DiffuseCoefficientControl.DecimalPlaces = 3;
			this.DiffuseCoefficientControl.Location = new System.Drawing.Point(1258, 752);
			this.DiffuseCoefficientControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.DiffuseCoefficientControl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.DiffuseCoefficientControl.Name = "DiffuseCoefficientControl";
			this.DiffuseCoefficientControl.Size = new System.Drawing.Size(77, 27);
			this.DiffuseCoefficientControl.TabIndex = 79;
			this.DiffuseCoefficientControl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label39
			// 
			this.label39.AutoSize = true;
			this.label39.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label39.Location = new System.Drawing.Point(1178, 816);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(61, 23);
			this.label39.TabIndex = 86;
			this.label39.Text = "Glitter:";
			// 
			// GlitterCoefficientControl
			// 
			this.GlitterCoefficientControl.DecimalPlaces = 3;
			this.GlitterCoefficientControl.Location = new System.Drawing.Point(1258, 811);
			this.GlitterCoefficientControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GlitterCoefficientControl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.GlitterCoefficientControl.Name = "GlitterCoefficientControl";
			this.GlitterCoefficientControl.Size = new System.Drawing.Size(77, 27);
			this.GlitterCoefficientControl.TabIndex = 85;
			this.GlitterCoefficientControl.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// ChooseColorButton
			// 
			this.ChooseColorButton.Location = new System.Drawing.Point(399, 828);
			this.ChooseColorButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ChooseColorButton.Name = "ChooseColorButton";
			this.ChooseColorButton.Size = new System.Drawing.Size(103, 31);
			this.ChooseColorButton.TabIndex = 87;
			this.ChooseColorButton.Text = "Choose Color";
			this.ChooseColorButton.UseVisualStyleBackColor = true;
			this.ChooseColorButton.Click += new System.EventHandler(this.ChooseColorButton_Click);
			// 
			// debugInfo
			// 
			this.debugInfo.AutoSize = true;
			this.debugInfo.BackColor = System.Drawing.Color.Transparent;
			this.debugInfo.Location = new System.Drawing.Point(168, 10);
			this.debugInfo.Name = "debugInfo";
			this.debugInfo.Size = new System.Drawing.Size(0, 20);
			this.debugInfo.TabIndex = 88;
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1338, 908);
			this.Controls.Add(this.debugInfo);
			this.Controls.Add(this.ChooseColorButton);
			this.Controls.Add(this.label39);
			this.Controls.Add(this.GlitterCoefficientControl);
			this.Controls.Add(this.label36);
			this.Controls.Add(this.label37);
			this.Controls.Add(this.label38);
			this.Controls.Add(this.AmbientCoefficientControl);
			this.Controls.Add(this.ReflectCoefficientControl);
			this.Controls.Add(this.DiffuseCoefficientControl);
			this.Controls.Add(this.label33);
			this.Controls.Add(this.label34);
			this.Controls.Add(this.label35);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(this.numericUpDown3);
			this.Controls.Add(this.label32);
			this.Controls.Add(this.LightIntensity);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.label26);
			this.Controls.Add(this.label27);
			this.Controls.Add(this.LightColorR);
			this.Controls.Add(this.LightColorB);
			this.Controls.Add(this.LightColorG);
			this.Controls.Add(this.label28);
			this.Controls.Add(this.SetLightSettings);
			this.Controls.Add(this.label29);
			this.Controls.Add(this.label30);
			this.Controls.Add(this.label31);
			this.Controls.Add(this.LightPositionZ);
			this.Controls.Add(this.LightPositionX);
			this.Controls.Add(this.LightPositionY);
			this.Controls.Add(this.label25);
			this.Controls.Add(this.NearPlaneDist);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.MouseSpeedControl);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.MovementSpeedControl);
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
			((System.ComponentModel.ISupportInitialize)(this.MovementSpeedControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MouseSpeedControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NearPlaneDist)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LightColorR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LightColorB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LightColorG)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LightPositionZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LightPositionX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LightPositionY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LightIntensity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AmbientCoefficientControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ReflectCoefficientControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DiffuseCoefficientControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GlitterCoefficientControl)).EndInit();
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
	private NumericUpDown MovementSpeedControl;
	private Label label23;
	private Label label24;
	private NumericUpDown MouseSpeedControl;
	private Label label25;
	private NumericUpDown NearPlaneDist;
	private Label label22;
	private Label label26;
	private Label label27;
	private NumericUpDown LightColorR;
	private NumericUpDown LightColorB;
	private NumericUpDown LightColorG;
	private Label label28;
	private Button SetLightSettings;
	private Label label29;
	private Label label30;
	private Label label31;
	private NumericUpDown LightPositionZ;
	private NumericUpDown LightPositionX;
	private NumericUpDown LightPositionY;
	private RadioButton UseLightRadioButton;
	private Label label32;
	private NumericUpDown LightIntensity;
	private Label label33;
	private Label label34;
	private Label label35;
	private NumericUpDown numericUpDown1;
	private NumericUpDown numericUpDown2;
	private NumericUpDown numericUpDown3;
	private Label label36;
	private Label label37;
	private Label label38;
	private NumericUpDown AmbientCoefficientControl;
	private NumericUpDown ReflectCoefficientControl;
	private NumericUpDown DiffuseCoefficientControl;
	private Label label39;
	private NumericUpDown GlitterCoefficientControl;
	private ColorDialog SetObjectColorDialog;
	private Button ChooseColorButton;
	private Label debugInfo;
}