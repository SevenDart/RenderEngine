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
			this.CameraLeanXY = new System.Windows.Forms.Label();
			this.CameraLeanYZ = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.CameraLeanXZ = new System.Windows.Forms.NumericUpDown();
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
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraLeanXZ)).BeginInit();
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
			this.SetCameraSettingsButton.Location = new System.Drawing.Point(1122, 870);
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
			this.label4.Location = new System.Drawing.Point(1091, 671);
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
			this.SetObjectSettingsButton.Location = new System.Drawing.Point(632, 825);
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
			this.labelYZ.Location = new System.Drawing.Point(728, 768);
			this.labelYZ.Name = "labelYZ";
			this.labelYZ.Size = new System.Drawing.Size(33, 23);
			this.labelYZ.TabIndex = 27;
			this.labelYZ.Text = "YZ:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label12.Location = new System.Drawing.Point(625, 769);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(34, 23);
			this.label12.TabIndex = 26;
			this.label12.Text = "XZ:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label13.Location = new System.Drawing.Point(520, 769);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(33, 23);
			this.label13.TabIndex = 25;
			this.label13.Text = "XY:";
			// 
			// CurrentObjLeanYZ
			// 
			this.CurrentObjLeanYZ.Location = new System.Drawing.Point(766, 767);
			this.CurrentObjLeanYZ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CurrentObjLeanYZ.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.CurrentObjLeanYZ.Name = "CurrentObjLeanYZ";
			this.CurrentObjLeanYZ.Size = new System.Drawing.Size(51, 27);
			this.CurrentObjLeanYZ.TabIndex = 24;
			// 
			// CurrentObjLeanXY
			// 
			this.CurrentObjLeanXY.Location = new System.Drawing.Point(561, 767);
			this.CurrentObjLeanXY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CurrentObjLeanXY.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.CurrentObjLeanXY.Name = "CurrentObjLeanXY";
			this.CurrentObjLeanXY.Size = new System.Drawing.Size(51, 27);
			this.CurrentObjLeanXY.TabIndex = 23;
			// 
			// CurrentObjLeanXZ
			// 
			this.CurrentObjLeanXZ.Location = new System.Drawing.Point(662, 767);
			this.CurrentObjLeanXZ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CurrentObjLeanXZ.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
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
			this.label15.Location = new System.Drawing.Point(440, 768);
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
			this.label11.Location = new System.Drawing.Point(1200, 765);
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
			// CameraLeanXY
			// 
			this.CameraLeanXY.AutoSize = true;
			this.CameraLeanXY.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CameraLeanXY.Location = new System.Drawing.Point(992, 766);
			this.CameraLeanXY.Name = "CameraLeanXY";
			this.CameraLeanXY.Size = new System.Drawing.Size(33, 23);
			this.CameraLeanXY.TabIndex = 35;
			this.CameraLeanXY.Text = "XY:";
			// 
			// CameraLeanYZ
			// 
			this.CameraLeanYZ.Location = new System.Drawing.Point(1240, 761);
			this.CameraLeanYZ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CameraLeanYZ.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.CameraLeanYZ.Name = "CameraLeanYZ";
			this.CameraLeanYZ.Size = new System.Drawing.Size(51, 27);
			this.CameraLeanYZ.TabIndex = 34;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(1033, 764);
			this.numericUpDown2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(51, 27);
			this.numericUpDown2.TabIndex = 33;
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
			this.CameraLeanXZ.Name = "CameraLeanXZ";
			this.CameraLeanXZ.Size = new System.Drawing.Size(51, 27);
			this.CameraLeanXZ.TabIndex = 32;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1305, 1011);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.CameraLeanXY);
			this.Controls.Add(this.CameraLeanYZ);
			this.Controls.Add(this.numericUpDown2);
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
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraLeanXZ)).EndInit();
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
	private Label CameraLeanXY;
	private NumericUpDown CameraLeanYZ;
	private NumericUpDown numericUpDown2;
	private NumericUpDown CameraLeanXZ;
}