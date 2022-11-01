namespace utc2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.reset_button = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.filter_id_high_box = new System.Windows.Forms.TextBox();
            this.filter_id_low_box = new System.Windows.Forms.TextBox();
            this.label554 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.can_bus_load = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.query_button = new System.Windows.Forms.Button();
            this.nodes_groupBox = new System.Windows.Forms.GroupBox();
            this.steering_wheel_radio = new System.Windows.Forms.RadioButton();
            this.brake_light_radio = new System.Windows.Forms.RadioButton();
            this.fan_radio = new System.Windows.Forms.RadioButton();
            this.ams_lv_radio = new System.Windows.Forms.RadioButton();
            this.can_multiplexer_front_radio = new System.Windows.Forms.RadioButton();
            this.bcu_radio = new System.Windows.Forms.RadioButton();
            this.empty_radio = new System.Windows.Forms.RadioButton();
            this.can_multiplexer_rear_radio = new System.Windows.Forms.RadioButton();
            this.vcu_radio = new System.Windows.Forms.RadioButton();
            this.vcdu_radio = new System.Windows.Forms.RadioButton();
            this.ami_radio = new System.Windows.Forms.RadioButton();
            this.discharge_radio = new System.Windows.Forms.RadioButton();
            this.assi_radio = new System.Windows.Forms.RadioButton();
            this.precharge_radio = new System.Windows.Forms.RadioButton();
            this.ebs_radio = new System.Windows.Forms.RadioButton();
            this.ams_master_radio = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.open_file = new System.Windows.Forms.Button();
            this.close_file = new System.Windows.Forms.Button();
            this.download = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hotcell = new System.Windows.Forms.TextBox();
            this.label472 = new System.Windows.Forms.Label();
            this.label471 = new System.Windows.Forms.Label();
            this.current_box = new System.Windows.Forms.TextBox();
            this.label477 = new System.Windows.Forms.Label();
            this.label476 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.charging_current_box = new System.Windows.Forms.TextBox();
            this.label553 = new System.Windows.Forms.Label();
            this.label552 = new System.Windows.Forms.Label();
            this.charging_status_box = new System.Windows.Forms.TextBox();
            this.label551 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label500 = new System.Windows.Forms.Label();
            this.richTextBox_precharge_errors = new System.Windows.Forms.RichTextBox();
            this.richTextBox_precharge_status = new System.Windows.Forms.RichTextBox();
            this.label499 = new System.Windows.Forms.Label();
            this.airminus_box = new System.Windows.Forms.TextBox();
            this.label473 = new System.Windows.Forms.Label();
            this.label474 = new System.Windows.Forms.Label();
            this.label475 = new System.Windows.Forms.Label();
            this.airplus_box = new System.Windows.Forms.TextBox();
            this.prechrelay_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.group_vcu = new System.Windows.Forms.GroupBox();
            this.richTextBox_vcu = new System.Windows.Forms.RichTextBox();
            this.label550 = new System.Windows.Forms.Label();
            this.label549 = new System.Windows.Forms.Label();
            this.label526 = new System.Windows.Forms.Label();
            this.label528 = new System.Windows.Forms.Label();
            this.label530 = new System.Windows.Forms.Label();
            this.label531 = new System.Windows.Forms.Label();
            this.label532 = new System.Windows.Forms.Label();
            this.label533 = new System.Windows.Forms.Label();
            this.label534 = new System.Windows.Forms.Label();
            this.label535 = new System.Windows.Forms.Label();
            this.label536 = new System.Windows.Forms.Label();
            this.label537 = new System.Windows.Forms.Label();
            this.label538 = new System.Windows.Forms.Label();
            this.label539 = new System.Windows.Forms.Label();
            this.assi_current_box = new System.Windows.Forms.TextBox();
            this.gps_current_box = new System.Windows.Forms.TextBox();
            this.as_current_box = new System.Windows.Forms.TextBox();
            this.cameras_current_box = new System.Windows.Forms.TextBox();
            this.res_current_box = new System.Windows.Forms.TextBox();
            this.lidar_current_box = new System.Windows.Forms.TextBox();
            this.label527 = new System.Windows.Forms.Label();
            this.label529 = new System.Windows.Forms.Label();
            this.brake_light_current_box = new System.Windows.Forms.TextBox();
            this.vcdu_current_box = new System.Windows.Forms.TextBox();
            this.label513 = new System.Windows.Forms.Label();
            this.label514 = new System.Windows.Forms.Label();
            this.label515 = new System.Windows.Forms.Label();
            this.label516 = new System.Windows.Forms.Label();
            this.ebs_current_box = new System.Windows.Forms.TextBox();
            this.actuator_current_box = new System.Windows.Forms.TextBox();
            this.label449 = new System.Windows.Forms.Label();
            this.label487 = new System.Windows.Forms.Label();
            this.label488 = new System.Windows.Forms.Label();
            this.label485 = new System.Windows.Forms.Label();
            this.label489 = new System.Windows.Forms.Label();
            this.label484 = new System.Windows.Forms.Label();
            this.label490 = new System.Windows.Forms.Label();
            this.label483 = new System.Windows.Forms.Label();
            this.label493 = new System.Windows.Forms.Label();
            this.label480 = new System.Windows.Forms.Label();
            this.label494 = new System.Windows.Forms.Label();
            this.label479 = new System.Windows.Forms.Label();
            this.label478 = new System.Windows.Forms.Label();
            this.fan2_current_box = new System.Windows.Forms.TextBox();
            this.fan1_current_box = new System.Windows.Forms.TextBox();
            this.lcs_current_box = new System.Windows.Forms.TextBox();
            this.cooling_pump_current_box = new System.Windows.Forms.TextBox();
            this.inverter_current_box = new System.Windows.Forms.TextBox();
            this.tsal_current_box = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label492 = new System.Windows.Forms.Label();
            this.label540 = new System.Windows.Forms.Label();
            this.label541 = new System.Windows.Forms.Label();
            this.label491 = new System.Windows.Forms.Label();
            this.label486 = new System.Windows.Forms.Label();
            this.label482 = new System.Windows.Forms.Label();
            this.label525 = new System.Windows.Forms.Label();
            this.label524 = new System.Windows.Forms.Label();
            this.label523 = new System.Windows.Forms.Label();
            this.label522 = new System.Windows.Forms.Label();
            this.ams_lv_status_box = new System.Windows.Forms.TextBox();
            this.label521 = new System.Windows.Forms.Label();
            this.label501 = new System.Windows.Forms.Label();
            this.label520 = new System.Windows.Forms.Label();
            this.label517 = new System.Windows.Forms.Label();
            this.label518 = new System.Windows.Forms.Label();
            this.label519 = new System.Windows.Forms.Label();
            this.lv_voltage_cell_6_box = new System.Windows.Forms.TextBox();
            this.lv_temp_cell_6_box = new System.Windows.Forms.TextBox();
            this.label510 = new System.Windows.Forms.Label();
            this.label509 = new System.Windows.Forms.Label();
            this.lv_temp_cell_5_box = new System.Windows.Forms.TextBox();
            this.lv_voltage_cell_5_box = new System.Windows.Forms.TextBox();
            this.label511 = new System.Windows.Forms.Label();
            this.label508 = new System.Windows.Forms.Label();
            this.lv_temp_cell_4_box = new System.Windows.Forms.TextBox();
            this.label512 = new System.Windows.Forms.Label();
            this.label507 = new System.Windows.Forms.Label();
            this.label506 = new System.Windows.Forms.Label();
            this.label505 = new System.Windows.Forms.Label();
            this.lv_voltage_cell_4_box = new System.Windows.Forms.TextBox();
            this.label504 = new System.Windows.Forms.Label();
            this.lv_voltage_cell_2_box = new System.Windows.Forms.TextBox();
            this.lv_voltage_cell_3_box = new System.Windows.Forms.TextBox();
            this.lv_voltage_cell_1_box = new System.Windows.Forms.TextBox();
            this.lv_hottest_cell_box = new System.Windows.Forms.TextBox();
            this.label502 = new System.Windows.Forms.Label();
            this.label503 = new System.Windows.Forms.Label();
            this.lv_temp_cell_1_box = new System.Windows.Forms.TextBox();
            this.lv_temp_cell_3_box = new System.Windows.Forms.TextBox();
            this.lv_temp_cell_2_box = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.actuator_status_box = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rpm2_box = new System.Windows.Forms.TextBox();
            this.rpm1_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vcdu_status_box = new System.Windows.Forms.TextBox();
            this.motor_temp_box = new System.Windows.Forms.TextBox();
            this.inverter_temp_box = new System.Windows.Forms.TextBox();
            this.label451 = new System.Windows.Forms.Label();
            this.label450 = new System.Windows.Forms.Label();
            this.label452 = new System.Windows.Forms.Label();
            this.label453 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.cell_max_number = new System.Windows.Forms.Label();
            this.stack_max_number = new System.Windows.Forms.Label();
            this.label556 = new System.Windows.Forms.Label();
            this.voltage_max_box = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label558 = new System.Windows.Forms.Label();
            this.cell_min_number = new System.Windows.Forms.Label();
            this.stack_min_number = new System.Windows.Forms.Label();
            this.voltage_min_box = new System.Windows.Forms.TextBox();
            this.total_voltage_box = new System.Windows.Forms.TextBox();
            this.label498 = new System.Windows.Forms.Label();
            this.label495 = new System.Windows.Forms.Label();
            this.stack5_box = new System.Windows.Forms.TextBox();
            this.stack1_box = new System.Windows.Forms.TextBox();
            this.label455 = new System.Windows.Forms.Label();
            this.stack2_box = new System.Windows.Forms.TextBox();
            this.label456 = new System.Windows.Forms.Label();
            this.stack3_box = new System.Windows.Forms.TextBox();
            this.label457 = new System.Windows.Forms.Label();
            this.stack4_box = new System.Windows.Forms.TextBox();
            this.label458 = new System.Windows.Forms.Label();
            this.label459 = new System.Windows.Forms.Label();
            this.stack6_box = new System.Windows.Forms.TextBox();
            this.label460 = new System.Windows.Forms.Label();
            this.stack7_box = new System.Windows.Forms.TextBox();
            this.label461 = new System.Windows.Forms.Label();
            this.stack8_box = new System.Windows.Forms.TextBox();
            this.label470 = new System.Windows.Forms.Label();
            this.label462 = new System.Windows.Forms.Label();
            this.label469 = new System.Windows.Forms.Label();
            this.label463 = new System.Windows.Forms.Label();
            this.label468 = new System.Windows.Forms.Label();
            this.label464 = new System.Windows.Forms.Label();
            this.label467 = new System.Windows.Forms.Label();
            this.label465 = new System.Windows.Forms.Label();
            this.label466 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.brake_system_status_box = new System.Windows.Forms.TextBox();
            this.brake_pressure_box = new System.Windows.Forms.TextBox();
            this.label496 = new System.Windows.Forms.Label();
            this.ebs_pressure_box = new System.Windows.Forms.TextBox();
            this.label454 = new System.Windows.Forms.Label();
            this.sb_pressure_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ams_tabpage = new System.Windows.Forms.TabPage();
            this.clear_ams = new System.Windows.Forms.Button();
            this.richTextBox_master = new System.Windows.Forms.RichTextBox();
            this.richTextBox_slave1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_slave2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_slave3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_slave4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_slave5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_slave6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_slave7 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_slave8 = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.stack1 = new System.Windows.Forms.TabPage();
            this.stack_1u = new System.Windows.Forms.Label();
            this.clear_1 = new System.Windows.Forms.Button();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_34 = new System.Windows.Forms.TextBox();
            this.textBox_33 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox_36 = new System.Windows.Forms.TextBox();
            this.textBox_35 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox_30 = new System.Windows.Forms.TextBox();
            this.textBox_29 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox_28 = new System.Windows.Forms.TextBox();
            this.textBox_27 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox_26 = new System.Windows.Forms.TextBox();
            this.textBox_25 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox_32 = new System.Windows.Forms.TextBox();
            this.textBox_31 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_22 = new System.Windows.Forms.TextBox();
            this.textBox_21 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_24 = new System.Windows.Forms.TextBox();
            this.textBox_23 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_18 = new System.Windows.Forms.TextBox();
            this.textBox_17 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_16 = new System.Windows.Forms.TextBox();
            this.textBox_15 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_14 = new System.Windows.Forms.TextBox();
            this.textBox_13 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_20 = new System.Windows.Forms.TextBox();
            this.textBox_19 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_10 = new System.Windows.Forms.TextBox();
            this.textBox_9 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_12 = new System.Windows.Forms.TextBox();
            this.textBox_11 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_6 = new System.Windows.Forms.TextBox();
            this.textBox_5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_4 = new System.Windows.Forms.TextBox();
            this.textBox_3 = new System.Windows.Forms.TextBox();
            this.stack1_2 = new System.Windows.Forms.Label();
            this.textBox_2 = new System.Windows.Forms.TextBox();
            this.textBox_1 = new System.Windows.Forms.TextBox();
            this.stack1_1 = new System.Windows.Forms.Label();
            this.textBox_8 = new System.Windows.Forms.TextBox();
            this.textBox_7 = new System.Windows.Forms.TextBox();
            this.stack2 = new System.Windows.Forms.TabPage();
            this.stack_2u = new System.Windows.Forms.Label();
            this.clear_2 = new System.Windows.Forms.Button();
            this.label441 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.textBox_70 = new System.Windows.Forms.TextBox();
            this.textBox_69 = new System.Windows.Forms.TextBox();
            this.label100 = new System.Windows.Forms.Label();
            this.textBox_72 = new System.Windows.Forms.TextBox();
            this.textBox_71 = new System.Windows.Forms.TextBox();
            this.label101 = new System.Windows.Forms.Label();
            this.textBox_66 = new System.Windows.Forms.TextBox();
            this.textBox_65 = new System.Windows.Forms.TextBox();
            this.label102 = new System.Windows.Forms.Label();
            this.textBox_64 = new System.Windows.Forms.TextBox();
            this.textBox_63 = new System.Windows.Forms.TextBox();
            this.label103 = new System.Windows.Forms.Label();
            this.textBox_62 = new System.Windows.Forms.TextBox();
            this.textBox_61 = new System.Windows.Forms.TextBox();
            this.label104 = new System.Windows.Forms.Label();
            this.textBox_68 = new System.Windows.Forms.TextBox();
            this.textBox_67 = new System.Windows.Forms.TextBox();
            this.label105 = new System.Windows.Forms.Label();
            this.textBox_58 = new System.Windows.Forms.TextBox();
            this.textBox_57 = new System.Windows.Forms.TextBox();
            this.label106 = new System.Windows.Forms.Label();
            this.textBox_60 = new System.Windows.Forms.TextBox();
            this.textBox_59 = new System.Windows.Forms.TextBox();
            this.label107 = new System.Windows.Forms.Label();
            this.textBox_54 = new System.Windows.Forms.TextBox();
            this.textBox_53 = new System.Windows.Forms.TextBox();
            this.label108 = new System.Windows.Forms.Label();
            this.textBox_52 = new System.Windows.Forms.TextBox();
            this.textBox_51 = new System.Windows.Forms.TextBox();
            this.label109 = new System.Windows.Forms.Label();
            this.textBox_50 = new System.Windows.Forms.TextBox();
            this.textBox_49 = new System.Windows.Forms.TextBox();
            this.label110 = new System.Windows.Forms.Label();
            this.textBox_56 = new System.Windows.Forms.TextBox();
            this.textBox_55 = new System.Windows.Forms.TextBox();
            this.label111 = new System.Windows.Forms.Label();
            this.textBox_46 = new System.Windows.Forms.TextBox();
            this.textBox_45 = new System.Windows.Forms.TextBox();
            this.label112 = new System.Windows.Forms.Label();
            this.textBox_48 = new System.Windows.Forms.TextBox();
            this.textBox_47 = new System.Windows.Forms.TextBox();
            this.label113 = new System.Windows.Forms.Label();
            this.textBox_42 = new System.Windows.Forms.TextBox();
            this.textBox_41 = new System.Windows.Forms.TextBox();
            this.label114 = new System.Windows.Forms.Label();
            this.textBox_40 = new System.Windows.Forms.TextBox();
            this.textBox_39 = new System.Windows.Forms.TextBox();
            this.label115 = new System.Windows.Forms.Label();
            this.textBox_38 = new System.Windows.Forms.TextBox();
            this.textBox_37 = new System.Windows.Forms.TextBox();
            this.label116 = new System.Windows.Forms.Label();
            this.textBox_44 = new System.Windows.Forms.TextBox();
            this.textBox_43 = new System.Windows.Forms.TextBox();
            this.stack3 = new System.Windows.Forms.TabPage();
            this.stack_3u = new System.Windows.Forms.Label();
            this.clear_3 = new System.Windows.Forms.Button();
            this.label442 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.label125 = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.label127 = new System.Windows.Forms.Label();
            this.label128 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.label130 = new System.Windows.Forms.Label();
            this.label131 = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.label133 = new System.Windows.Forms.Label();
            this.label134 = new System.Windows.Forms.Label();
            this.label135 = new System.Windows.Forms.Label();
            this.label136 = new System.Windows.Forms.Label();
            this.label137 = new System.Windows.Forms.Label();
            this.label138 = new System.Windows.Forms.Label();
            this.label139 = new System.Windows.Forms.Label();
            this.label140 = new System.Windows.Forms.Label();
            this.label141 = new System.Windows.Forms.Label();
            this.label142 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.label144 = new System.Windows.Forms.Label();
            this.label145 = new System.Windows.Forms.Label();
            this.label146 = new System.Windows.Forms.Label();
            this.label147 = new System.Windows.Forms.Label();
            this.label148 = new System.Windows.Forms.Label();
            this.label149 = new System.Windows.Forms.Label();
            this.label150 = new System.Windows.Forms.Label();
            this.label151 = new System.Windows.Forms.Label();
            this.label152 = new System.Windows.Forms.Label();
            this.label153 = new System.Windows.Forms.Label();
            this.textBox_106 = new System.Windows.Forms.TextBox();
            this.textBox_105 = new System.Windows.Forms.TextBox();
            this.label154 = new System.Windows.Forms.Label();
            this.textBox_108 = new System.Windows.Forms.TextBox();
            this.textBox_107 = new System.Windows.Forms.TextBox();
            this.label155 = new System.Windows.Forms.Label();
            this.textBox_102 = new System.Windows.Forms.TextBox();
            this.textBox_101 = new System.Windows.Forms.TextBox();
            this.label156 = new System.Windows.Forms.Label();
            this.textBox_100 = new System.Windows.Forms.TextBox();
            this.textBox_99 = new System.Windows.Forms.TextBox();
            this.label157 = new System.Windows.Forms.Label();
            this.textBox_98 = new System.Windows.Forms.TextBox();
            this.textBox_97 = new System.Windows.Forms.TextBox();
            this.label158 = new System.Windows.Forms.Label();
            this.textBox_104 = new System.Windows.Forms.TextBox();
            this.textBox_103 = new System.Windows.Forms.TextBox();
            this.label159 = new System.Windows.Forms.Label();
            this.textBox_94 = new System.Windows.Forms.TextBox();
            this.textBox_93 = new System.Windows.Forms.TextBox();
            this.label160 = new System.Windows.Forms.Label();
            this.textBox_96 = new System.Windows.Forms.TextBox();
            this.textBox_95 = new System.Windows.Forms.TextBox();
            this.label161 = new System.Windows.Forms.Label();
            this.textBox_90 = new System.Windows.Forms.TextBox();
            this.textBox_89 = new System.Windows.Forms.TextBox();
            this.label162 = new System.Windows.Forms.Label();
            this.textBox_88 = new System.Windows.Forms.TextBox();
            this.textBox_87 = new System.Windows.Forms.TextBox();
            this.label163 = new System.Windows.Forms.Label();
            this.textBox_86 = new System.Windows.Forms.TextBox();
            this.textBox_85 = new System.Windows.Forms.TextBox();
            this.label164 = new System.Windows.Forms.Label();
            this.textBox_92 = new System.Windows.Forms.TextBox();
            this.textBox_91 = new System.Windows.Forms.TextBox();
            this.label165 = new System.Windows.Forms.Label();
            this.textBox_82 = new System.Windows.Forms.TextBox();
            this.textBox_81 = new System.Windows.Forms.TextBox();
            this.label166 = new System.Windows.Forms.Label();
            this.textBox_84 = new System.Windows.Forms.TextBox();
            this.textBox_83 = new System.Windows.Forms.TextBox();
            this.label167 = new System.Windows.Forms.Label();
            this.textBox_78 = new System.Windows.Forms.TextBox();
            this.textBox_77 = new System.Windows.Forms.TextBox();
            this.label168 = new System.Windows.Forms.Label();
            this.textBox_76 = new System.Windows.Forms.TextBox();
            this.textBox_75 = new System.Windows.Forms.TextBox();
            this.label169 = new System.Windows.Forms.Label();
            this.textBox_74 = new System.Windows.Forms.TextBox();
            this.textBox_73 = new System.Windows.Forms.TextBox();
            this.label170 = new System.Windows.Forms.Label();
            this.textBox_80 = new System.Windows.Forms.TextBox();
            this.textBox_79 = new System.Windows.Forms.TextBox();
            this.stack4 = new System.Windows.Forms.TabPage();
            this.stack_4u = new System.Windows.Forms.Label();
            this.clear_4 = new System.Windows.Forms.Button();
            this.label443 = new System.Windows.Forms.Label();
            this.label171 = new System.Windows.Forms.Label();
            this.label172 = new System.Windows.Forms.Label();
            this.label173 = new System.Windows.Forms.Label();
            this.label174 = new System.Windows.Forms.Label();
            this.label175 = new System.Windows.Forms.Label();
            this.label176 = new System.Windows.Forms.Label();
            this.label177 = new System.Windows.Forms.Label();
            this.label178 = new System.Windows.Forms.Label();
            this.label179 = new System.Windows.Forms.Label();
            this.label180 = new System.Windows.Forms.Label();
            this.label181 = new System.Windows.Forms.Label();
            this.label182 = new System.Windows.Forms.Label();
            this.label183 = new System.Windows.Forms.Label();
            this.label184 = new System.Windows.Forms.Label();
            this.label185 = new System.Windows.Forms.Label();
            this.label186 = new System.Windows.Forms.Label();
            this.label187 = new System.Windows.Forms.Label();
            this.label188 = new System.Windows.Forms.Label();
            this.label189 = new System.Windows.Forms.Label();
            this.label190 = new System.Windows.Forms.Label();
            this.label191 = new System.Windows.Forms.Label();
            this.label192 = new System.Windows.Forms.Label();
            this.label193 = new System.Windows.Forms.Label();
            this.label194 = new System.Windows.Forms.Label();
            this.label195 = new System.Windows.Forms.Label();
            this.label196 = new System.Windows.Forms.Label();
            this.label197 = new System.Windows.Forms.Label();
            this.label198 = new System.Windows.Forms.Label();
            this.label199 = new System.Windows.Forms.Label();
            this.label200 = new System.Windows.Forms.Label();
            this.label201 = new System.Windows.Forms.Label();
            this.label202 = new System.Windows.Forms.Label();
            this.label203 = new System.Windows.Forms.Label();
            this.label204 = new System.Windows.Forms.Label();
            this.label205 = new System.Windows.Forms.Label();
            this.label206 = new System.Windows.Forms.Label();
            this.label207 = new System.Windows.Forms.Label();
            this.textBox_142 = new System.Windows.Forms.TextBox();
            this.textBox_141 = new System.Windows.Forms.TextBox();
            this.label208 = new System.Windows.Forms.Label();
            this.textBox_144 = new System.Windows.Forms.TextBox();
            this.textBox_143 = new System.Windows.Forms.TextBox();
            this.label209 = new System.Windows.Forms.Label();
            this.textBox_138 = new System.Windows.Forms.TextBox();
            this.textBox_137 = new System.Windows.Forms.TextBox();
            this.label210 = new System.Windows.Forms.Label();
            this.textBox_136 = new System.Windows.Forms.TextBox();
            this.textBox_135 = new System.Windows.Forms.TextBox();
            this.label211 = new System.Windows.Forms.Label();
            this.textBox_134 = new System.Windows.Forms.TextBox();
            this.textBox_133 = new System.Windows.Forms.TextBox();
            this.label212 = new System.Windows.Forms.Label();
            this.textBox_140 = new System.Windows.Forms.TextBox();
            this.textBox_139 = new System.Windows.Forms.TextBox();
            this.label213 = new System.Windows.Forms.Label();
            this.textBox_130 = new System.Windows.Forms.TextBox();
            this.textBox_129 = new System.Windows.Forms.TextBox();
            this.label214 = new System.Windows.Forms.Label();
            this.textBox_132 = new System.Windows.Forms.TextBox();
            this.textBox_131 = new System.Windows.Forms.TextBox();
            this.label215 = new System.Windows.Forms.Label();
            this.textBox_126 = new System.Windows.Forms.TextBox();
            this.textBox_125 = new System.Windows.Forms.TextBox();
            this.label216 = new System.Windows.Forms.Label();
            this.textBox_124 = new System.Windows.Forms.TextBox();
            this.textBox_123 = new System.Windows.Forms.TextBox();
            this.label217 = new System.Windows.Forms.Label();
            this.textBox_122 = new System.Windows.Forms.TextBox();
            this.textBox_121 = new System.Windows.Forms.TextBox();
            this.label218 = new System.Windows.Forms.Label();
            this.textBox_128 = new System.Windows.Forms.TextBox();
            this.textBox_127 = new System.Windows.Forms.TextBox();
            this.label219 = new System.Windows.Forms.Label();
            this.textBox_118 = new System.Windows.Forms.TextBox();
            this.textBox_117 = new System.Windows.Forms.TextBox();
            this.label220 = new System.Windows.Forms.Label();
            this.textBox_120 = new System.Windows.Forms.TextBox();
            this.textBox_119 = new System.Windows.Forms.TextBox();
            this.label221 = new System.Windows.Forms.Label();
            this.textBox_114 = new System.Windows.Forms.TextBox();
            this.textBox_113 = new System.Windows.Forms.TextBox();
            this.label222 = new System.Windows.Forms.Label();
            this.textBox_112 = new System.Windows.Forms.TextBox();
            this.textBox_111 = new System.Windows.Forms.TextBox();
            this.label223 = new System.Windows.Forms.Label();
            this.textBox_110 = new System.Windows.Forms.TextBox();
            this.textBox_109 = new System.Windows.Forms.TextBox();
            this.label224 = new System.Windows.Forms.Label();
            this.textBox_116 = new System.Windows.Forms.TextBox();
            this.textBox_115 = new System.Windows.Forms.TextBox();
            this.stack5 = new System.Windows.Forms.TabPage();
            this.stack_5u = new System.Windows.Forms.Label();
            this.clear_5 = new System.Windows.Forms.Button();
            this.label444 = new System.Windows.Forms.Label();
            this.label225 = new System.Windows.Forms.Label();
            this.label226 = new System.Windows.Forms.Label();
            this.label227 = new System.Windows.Forms.Label();
            this.label228 = new System.Windows.Forms.Label();
            this.label229 = new System.Windows.Forms.Label();
            this.label230 = new System.Windows.Forms.Label();
            this.label231 = new System.Windows.Forms.Label();
            this.label232 = new System.Windows.Forms.Label();
            this.label233 = new System.Windows.Forms.Label();
            this.label234 = new System.Windows.Forms.Label();
            this.label235 = new System.Windows.Forms.Label();
            this.label236 = new System.Windows.Forms.Label();
            this.label237 = new System.Windows.Forms.Label();
            this.label238 = new System.Windows.Forms.Label();
            this.label239 = new System.Windows.Forms.Label();
            this.label240 = new System.Windows.Forms.Label();
            this.label241 = new System.Windows.Forms.Label();
            this.label242 = new System.Windows.Forms.Label();
            this.label243 = new System.Windows.Forms.Label();
            this.label244 = new System.Windows.Forms.Label();
            this.label245 = new System.Windows.Forms.Label();
            this.label246 = new System.Windows.Forms.Label();
            this.label247 = new System.Windows.Forms.Label();
            this.label248 = new System.Windows.Forms.Label();
            this.label249 = new System.Windows.Forms.Label();
            this.label250 = new System.Windows.Forms.Label();
            this.label251 = new System.Windows.Forms.Label();
            this.label252 = new System.Windows.Forms.Label();
            this.label253 = new System.Windows.Forms.Label();
            this.label254 = new System.Windows.Forms.Label();
            this.label255 = new System.Windows.Forms.Label();
            this.label256 = new System.Windows.Forms.Label();
            this.label257 = new System.Windows.Forms.Label();
            this.label258 = new System.Windows.Forms.Label();
            this.label259 = new System.Windows.Forms.Label();
            this.label260 = new System.Windows.Forms.Label();
            this.label261 = new System.Windows.Forms.Label();
            this.textBox_178 = new System.Windows.Forms.TextBox();
            this.textBox_177 = new System.Windows.Forms.TextBox();
            this.label262 = new System.Windows.Forms.Label();
            this.textBox_180 = new System.Windows.Forms.TextBox();
            this.textBox_179 = new System.Windows.Forms.TextBox();
            this.label263 = new System.Windows.Forms.Label();
            this.textBox_174 = new System.Windows.Forms.TextBox();
            this.textBox_173 = new System.Windows.Forms.TextBox();
            this.label264 = new System.Windows.Forms.Label();
            this.textBox_172 = new System.Windows.Forms.TextBox();
            this.textBox_171 = new System.Windows.Forms.TextBox();
            this.label265 = new System.Windows.Forms.Label();
            this.textBox_170 = new System.Windows.Forms.TextBox();
            this.textBox_169 = new System.Windows.Forms.TextBox();
            this.label266 = new System.Windows.Forms.Label();
            this.textBox_176 = new System.Windows.Forms.TextBox();
            this.textBox_175 = new System.Windows.Forms.TextBox();
            this.label267 = new System.Windows.Forms.Label();
            this.textBox_166 = new System.Windows.Forms.TextBox();
            this.textBox_165 = new System.Windows.Forms.TextBox();
            this.label268 = new System.Windows.Forms.Label();
            this.textBox_168 = new System.Windows.Forms.TextBox();
            this.textBox_167 = new System.Windows.Forms.TextBox();
            this.label269 = new System.Windows.Forms.Label();
            this.textBox_162 = new System.Windows.Forms.TextBox();
            this.textBox_161 = new System.Windows.Forms.TextBox();
            this.label270 = new System.Windows.Forms.Label();
            this.textBox_160 = new System.Windows.Forms.TextBox();
            this.textBox_159 = new System.Windows.Forms.TextBox();
            this.label271 = new System.Windows.Forms.Label();
            this.textBox_158 = new System.Windows.Forms.TextBox();
            this.textBox_157 = new System.Windows.Forms.TextBox();
            this.label272 = new System.Windows.Forms.Label();
            this.textBox_164 = new System.Windows.Forms.TextBox();
            this.textBox_163 = new System.Windows.Forms.TextBox();
            this.label273 = new System.Windows.Forms.Label();
            this.textBox_154 = new System.Windows.Forms.TextBox();
            this.textBox_153 = new System.Windows.Forms.TextBox();
            this.label274 = new System.Windows.Forms.Label();
            this.textBox_156 = new System.Windows.Forms.TextBox();
            this.textBox_155 = new System.Windows.Forms.TextBox();
            this.label275 = new System.Windows.Forms.Label();
            this.textBox_150 = new System.Windows.Forms.TextBox();
            this.textBox_149 = new System.Windows.Forms.TextBox();
            this.label276 = new System.Windows.Forms.Label();
            this.textBox_148 = new System.Windows.Forms.TextBox();
            this.textBox_147 = new System.Windows.Forms.TextBox();
            this.label277 = new System.Windows.Forms.Label();
            this.textBox_146 = new System.Windows.Forms.TextBox();
            this.textBox_145 = new System.Windows.Forms.TextBox();
            this.label278 = new System.Windows.Forms.Label();
            this.textBox_152 = new System.Windows.Forms.TextBox();
            this.textBox_151 = new System.Windows.Forms.TextBox();
            this.stack6 = new System.Windows.Forms.TabPage();
            this.stack_6u = new System.Windows.Forms.Label();
            this.clear_6 = new System.Windows.Forms.Button();
            this.label445 = new System.Windows.Forms.Label();
            this.label279 = new System.Windows.Forms.Label();
            this.label280 = new System.Windows.Forms.Label();
            this.label281 = new System.Windows.Forms.Label();
            this.label282 = new System.Windows.Forms.Label();
            this.label283 = new System.Windows.Forms.Label();
            this.label284 = new System.Windows.Forms.Label();
            this.label285 = new System.Windows.Forms.Label();
            this.label286 = new System.Windows.Forms.Label();
            this.label287 = new System.Windows.Forms.Label();
            this.label288 = new System.Windows.Forms.Label();
            this.label289 = new System.Windows.Forms.Label();
            this.label290 = new System.Windows.Forms.Label();
            this.label291 = new System.Windows.Forms.Label();
            this.label292 = new System.Windows.Forms.Label();
            this.label293 = new System.Windows.Forms.Label();
            this.label294 = new System.Windows.Forms.Label();
            this.label295 = new System.Windows.Forms.Label();
            this.label296 = new System.Windows.Forms.Label();
            this.label297 = new System.Windows.Forms.Label();
            this.label298 = new System.Windows.Forms.Label();
            this.label299 = new System.Windows.Forms.Label();
            this.label300 = new System.Windows.Forms.Label();
            this.label301 = new System.Windows.Forms.Label();
            this.label302 = new System.Windows.Forms.Label();
            this.label303 = new System.Windows.Forms.Label();
            this.label304 = new System.Windows.Forms.Label();
            this.label305 = new System.Windows.Forms.Label();
            this.label306 = new System.Windows.Forms.Label();
            this.label307 = new System.Windows.Forms.Label();
            this.label308 = new System.Windows.Forms.Label();
            this.label309 = new System.Windows.Forms.Label();
            this.label310 = new System.Windows.Forms.Label();
            this.label311 = new System.Windows.Forms.Label();
            this.label312 = new System.Windows.Forms.Label();
            this.label313 = new System.Windows.Forms.Label();
            this.label314 = new System.Windows.Forms.Label();
            this.label315 = new System.Windows.Forms.Label();
            this.textBox_214 = new System.Windows.Forms.TextBox();
            this.textBox_213 = new System.Windows.Forms.TextBox();
            this.label316 = new System.Windows.Forms.Label();
            this.textBox_216 = new System.Windows.Forms.TextBox();
            this.textBox_215 = new System.Windows.Forms.TextBox();
            this.label317 = new System.Windows.Forms.Label();
            this.textBox_210 = new System.Windows.Forms.TextBox();
            this.textBox_209 = new System.Windows.Forms.TextBox();
            this.label318 = new System.Windows.Forms.Label();
            this.textBox_208 = new System.Windows.Forms.TextBox();
            this.textBox_207 = new System.Windows.Forms.TextBox();
            this.label319 = new System.Windows.Forms.Label();
            this.textBox_206 = new System.Windows.Forms.TextBox();
            this.textBox_205 = new System.Windows.Forms.TextBox();
            this.label320 = new System.Windows.Forms.Label();
            this.textBox_212 = new System.Windows.Forms.TextBox();
            this.textBox_211 = new System.Windows.Forms.TextBox();
            this.label321 = new System.Windows.Forms.Label();
            this.textBox_202 = new System.Windows.Forms.TextBox();
            this.textBox_201 = new System.Windows.Forms.TextBox();
            this.label322 = new System.Windows.Forms.Label();
            this.textBox_204 = new System.Windows.Forms.TextBox();
            this.textBox_203 = new System.Windows.Forms.TextBox();
            this.label323 = new System.Windows.Forms.Label();
            this.textBox_198 = new System.Windows.Forms.TextBox();
            this.textBox_197 = new System.Windows.Forms.TextBox();
            this.label324 = new System.Windows.Forms.Label();
            this.textBox_196 = new System.Windows.Forms.TextBox();
            this.textBox_195 = new System.Windows.Forms.TextBox();
            this.label325 = new System.Windows.Forms.Label();
            this.textBox_194 = new System.Windows.Forms.TextBox();
            this.textBox_193 = new System.Windows.Forms.TextBox();
            this.label326 = new System.Windows.Forms.Label();
            this.textBox_200 = new System.Windows.Forms.TextBox();
            this.textBox_199 = new System.Windows.Forms.TextBox();
            this.label327 = new System.Windows.Forms.Label();
            this.textBox_190 = new System.Windows.Forms.TextBox();
            this.textBox_189 = new System.Windows.Forms.TextBox();
            this.label328 = new System.Windows.Forms.Label();
            this.textBox_192 = new System.Windows.Forms.TextBox();
            this.textBox_191 = new System.Windows.Forms.TextBox();
            this.label329 = new System.Windows.Forms.Label();
            this.textBox_186 = new System.Windows.Forms.TextBox();
            this.textBox_185 = new System.Windows.Forms.TextBox();
            this.label330 = new System.Windows.Forms.Label();
            this.textBox_184 = new System.Windows.Forms.TextBox();
            this.textBox_183 = new System.Windows.Forms.TextBox();
            this.label331 = new System.Windows.Forms.Label();
            this.textBox_182 = new System.Windows.Forms.TextBox();
            this.textBox_181 = new System.Windows.Forms.TextBox();
            this.label332 = new System.Windows.Forms.Label();
            this.textBox_188 = new System.Windows.Forms.TextBox();
            this.textBox_187 = new System.Windows.Forms.TextBox();
            this.stack7 = new System.Windows.Forms.TabPage();
            this.stack_7u = new System.Windows.Forms.Label();
            this.clear_7 = new System.Windows.Forms.Button();
            this.label446 = new System.Windows.Forms.Label();
            this.label333 = new System.Windows.Forms.Label();
            this.label334 = new System.Windows.Forms.Label();
            this.label335 = new System.Windows.Forms.Label();
            this.label336 = new System.Windows.Forms.Label();
            this.label337 = new System.Windows.Forms.Label();
            this.label338 = new System.Windows.Forms.Label();
            this.label339 = new System.Windows.Forms.Label();
            this.label340 = new System.Windows.Forms.Label();
            this.label341 = new System.Windows.Forms.Label();
            this.label342 = new System.Windows.Forms.Label();
            this.label343 = new System.Windows.Forms.Label();
            this.label344 = new System.Windows.Forms.Label();
            this.label345 = new System.Windows.Forms.Label();
            this.label346 = new System.Windows.Forms.Label();
            this.label347 = new System.Windows.Forms.Label();
            this.label348 = new System.Windows.Forms.Label();
            this.label349 = new System.Windows.Forms.Label();
            this.label350 = new System.Windows.Forms.Label();
            this.label351 = new System.Windows.Forms.Label();
            this.label352 = new System.Windows.Forms.Label();
            this.label353 = new System.Windows.Forms.Label();
            this.label354 = new System.Windows.Forms.Label();
            this.label355 = new System.Windows.Forms.Label();
            this.label356 = new System.Windows.Forms.Label();
            this.label357 = new System.Windows.Forms.Label();
            this.label358 = new System.Windows.Forms.Label();
            this.label359 = new System.Windows.Forms.Label();
            this.label360 = new System.Windows.Forms.Label();
            this.label361 = new System.Windows.Forms.Label();
            this.label362 = new System.Windows.Forms.Label();
            this.label363 = new System.Windows.Forms.Label();
            this.label364 = new System.Windows.Forms.Label();
            this.label365 = new System.Windows.Forms.Label();
            this.label366 = new System.Windows.Forms.Label();
            this.label367 = new System.Windows.Forms.Label();
            this.label368 = new System.Windows.Forms.Label();
            this.label369 = new System.Windows.Forms.Label();
            this.textBox_250 = new System.Windows.Forms.TextBox();
            this.textBox_249 = new System.Windows.Forms.TextBox();
            this.label370 = new System.Windows.Forms.Label();
            this.textBox_252 = new System.Windows.Forms.TextBox();
            this.textBox_251 = new System.Windows.Forms.TextBox();
            this.label371 = new System.Windows.Forms.Label();
            this.textBox_246 = new System.Windows.Forms.TextBox();
            this.textBox_245 = new System.Windows.Forms.TextBox();
            this.label372 = new System.Windows.Forms.Label();
            this.textBox_244 = new System.Windows.Forms.TextBox();
            this.textBox_243 = new System.Windows.Forms.TextBox();
            this.label373 = new System.Windows.Forms.Label();
            this.textBox_242 = new System.Windows.Forms.TextBox();
            this.textBox_241 = new System.Windows.Forms.TextBox();
            this.label374 = new System.Windows.Forms.Label();
            this.textBox_248 = new System.Windows.Forms.TextBox();
            this.textBox_247 = new System.Windows.Forms.TextBox();
            this.label375 = new System.Windows.Forms.Label();
            this.textBox_238 = new System.Windows.Forms.TextBox();
            this.textBox_237 = new System.Windows.Forms.TextBox();
            this.label376 = new System.Windows.Forms.Label();
            this.textBox_240 = new System.Windows.Forms.TextBox();
            this.textBox_239 = new System.Windows.Forms.TextBox();
            this.label377 = new System.Windows.Forms.Label();
            this.textBox_234 = new System.Windows.Forms.TextBox();
            this.textBox_233 = new System.Windows.Forms.TextBox();
            this.label378 = new System.Windows.Forms.Label();
            this.textBox_232 = new System.Windows.Forms.TextBox();
            this.textBox_231 = new System.Windows.Forms.TextBox();
            this.label379 = new System.Windows.Forms.Label();
            this.textBox_230 = new System.Windows.Forms.TextBox();
            this.textBox_229 = new System.Windows.Forms.TextBox();
            this.label380 = new System.Windows.Forms.Label();
            this.textBox_236 = new System.Windows.Forms.TextBox();
            this.textBox_235 = new System.Windows.Forms.TextBox();
            this.label381 = new System.Windows.Forms.Label();
            this.textBox_226 = new System.Windows.Forms.TextBox();
            this.textBox_225 = new System.Windows.Forms.TextBox();
            this.label382 = new System.Windows.Forms.Label();
            this.textBox_228 = new System.Windows.Forms.TextBox();
            this.textBox_227 = new System.Windows.Forms.TextBox();
            this.label383 = new System.Windows.Forms.Label();
            this.textBox_222 = new System.Windows.Forms.TextBox();
            this.textBox_221 = new System.Windows.Forms.TextBox();
            this.label384 = new System.Windows.Forms.Label();
            this.textBox_220 = new System.Windows.Forms.TextBox();
            this.textBox_219 = new System.Windows.Forms.TextBox();
            this.label385 = new System.Windows.Forms.Label();
            this.textBox_218 = new System.Windows.Forms.TextBox();
            this.textBox_217 = new System.Windows.Forms.TextBox();
            this.label386 = new System.Windows.Forms.Label();
            this.textBox_224 = new System.Windows.Forms.TextBox();
            this.textBox_223 = new System.Windows.Forms.TextBox();
            this.stack8 = new System.Windows.Forms.TabPage();
            this.stack_8u = new System.Windows.Forms.Label();
            this.clear_8 = new System.Windows.Forms.Button();
            this.label447 = new System.Windows.Forms.Label();
            this.label387 = new System.Windows.Forms.Label();
            this.label388 = new System.Windows.Forms.Label();
            this.label389 = new System.Windows.Forms.Label();
            this.label390 = new System.Windows.Forms.Label();
            this.label391 = new System.Windows.Forms.Label();
            this.label392 = new System.Windows.Forms.Label();
            this.label393 = new System.Windows.Forms.Label();
            this.label394 = new System.Windows.Forms.Label();
            this.label395 = new System.Windows.Forms.Label();
            this.label396 = new System.Windows.Forms.Label();
            this.label397 = new System.Windows.Forms.Label();
            this.label398 = new System.Windows.Forms.Label();
            this.label399 = new System.Windows.Forms.Label();
            this.label400 = new System.Windows.Forms.Label();
            this.label401 = new System.Windows.Forms.Label();
            this.label402 = new System.Windows.Forms.Label();
            this.label403 = new System.Windows.Forms.Label();
            this.label404 = new System.Windows.Forms.Label();
            this.label405 = new System.Windows.Forms.Label();
            this.label406 = new System.Windows.Forms.Label();
            this.label407 = new System.Windows.Forms.Label();
            this.label408 = new System.Windows.Forms.Label();
            this.label409 = new System.Windows.Forms.Label();
            this.label410 = new System.Windows.Forms.Label();
            this.label411 = new System.Windows.Forms.Label();
            this.label412 = new System.Windows.Forms.Label();
            this.label413 = new System.Windows.Forms.Label();
            this.label414 = new System.Windows.Forms.Label();
            this.label415 = new System.Windows.Forms.Label();
            this.label416 = new System.Windows.Forms.Label();
            this.label417 = new System.Windows.Forms.Label();
            this.label418 = new System.Windows.Forms.Label();
            this.label419 = new System.Windows.Forms.Label();
            this.label420 = new System.Windows.Forms.Label();
            this.label421 = new System.Windows.Forms.Label();
            this.label422 = new System.Windows.Forms.Label();
            this.label423 = new System.Windows.Forms.Label();
            this.textBox_286 = new System.Windows.Forms.TextBox();
            this.textBox_285 = new System.Windows.Forms.TextBox();
            this.label424 = new System.Windows.Forms.Label();
            this.textBox_288 = new System.Windows.Forms.TextBox();
            this.textBox_287 = new System.Windows.Forms.TextBox();
            this.label425 = new System.Windows.Forms.Label();
            this.textBox_282 = new System.Windows.Forms.TextBox();
            this.textBox_281 = new System.Windows.Forms.TextBox();
            this.label426 = new System.Windows.Forms.Label();
            this.textBox_280 = new System.Windows.Forms.TextBox();
            this.textBox_279 = new System.Windows.Forms.TextBox();
            this.label427 = new System.Windows.Forms.Label();
            this.textBox_278 = new System.Windows.Forms.TextBox();
            this.textBox_277 = new System.Windows.Forms.TextBox();
            this.label428 = new System.Windows.Forms.Label();
            this.textBox_284 = new System.Windows.Forms.TextBox();
            this.textBox_283 = new System.Windows.Forms.TextBox();
            this.label429 = new System.Windows.Forms.Label();
            this.textBox_274 = new System.Windows.Forms.TextBox();
            this.textBox_273 = new System.Windows.Forms.TextBox();
            this.label430 = new System.Windows.Forms.Label();
            this.textBox_276 = new System.Windows.Forms.TextBox();
            this.textBox_275 = new System.Windows.Forms.TextBox();
            this.label431 = new System.Windows.Forms.Label();
            this.textBox_270 = new System.Windows.Forms.TextBox();
            this.textBox_269 = new System.Windows.Forms.TextBox();
            this.label432 = new System.Windows.Forms.Label();
            this.textBox_268 = new System.Windows.Forms.TextBox();
            this.textBox_267 = new System.Windows.Forms.TextBox();
            this.label433 = new System.Windows.Forms.Label();
            this.textBox_266 = new System.Windows.Forms.TextBox();
            this.textBox_265 = new System.Windows.Forms.TextBox();
            this.label434 = new System.Windows.Forms.Label();
            this.textBox_272 = new System.Windows.Forms.TextBox();
            this.textBox_271 = new System.Windows.Forms.TextBox();
            this.label435 = new System.Windows.Forms.Label();
            this.textBox_262 = new System.Windows.Forms.TextBox();
            this.textBox_261 = new System.Windows.Forms.TextBox();
            this.label436 = new System.Windows.Forms.Label();
            this.textBox_264 = new System.Windows.Forms.TextBox();
            this.textBox_263 = new System.Windows.Forms.TextBox();
            this.label437 = new System.Windows.Forms.Label();
            this.textBox_258 = new System.Windows.Forms.TextBox();
            this.textBox_257 = new System.Windows.Forms.TextBox();
            this.label438 = new System.Windows.Forms.Label();
            this.textBox_256 = new System.Windows.Forms.TextBox();
            this.textBox_255 = new System.Windows.Forms.TextBox();
            this.label439 = new System.Windows.Forms.Label();
            this.textBox_254 = new System.Windows.Forms.TextBox();
            this.textBox_253 = new System.Windows.Forms.TextBox();
            this.label440 = new System.Windows.Forms.Label();
            this.textBox_260 = new System.Windows.Forms.TextBox();
            this.textBox_259 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabcontrol1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.nodes_groupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.group_vcu.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ams_tabpage.SuspendLayout();
            this.stack1.SuspendLayout();
            this.stack2.SuspendLayout();
            this.stack3.SuspendLayout();
            this.stack4.SuspendLayout();
            this.stack5.SuspendLayout();
            this.stack6.SuspendLayout();
            this.stack7.SuspendLayout();
            this.stack8.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.ReadBufferSize = 65536;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("3ds Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(3, 129);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(425, 809);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            this.richTextBox2.HScroll += new System.EventHandler(this.Form1_Load);
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // reset_button
            // 
            this.reset_button.BackColor = System.Drawing.SystemColors.Control;
            this.reset_button.Font = new System.Drawing.Font("3ds Light", 12F);
            this.reset_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reset_button.Location = new System.Drawing.Point(155, 89);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(117, 34);
            this.reset_button.TabIndex = 187;
            this.reset_button.Text = "Reset filter";
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // disconnect
            // 
            this.disconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.disconnect.Font = new System.Drawing.Font("3ds Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnect.Location = new System.Drawing.Point(189, 3);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(180, 36);
            this.disconnect.TabIndex = 27;
            this.disconnect.Text = "Disconnect";
            this.disconnect.UseVisualStyleBackColor = false;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightGray;
            this.comboBox1.Font = new System.Drawing.Font("3ds Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(189, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 38);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // filter_id_high_box
            // 
            this.filter_id_high_box.BackColor = System.Drawing.SystemColors.Control;
            this.filter_id_high_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filter_id_high_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.filter_id_high_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Italic);
            this.filter_id_high_box.Location = new System.Drawing.Point(79, 89);
            this.filter_id_high_box.MaxLength = 3;
            this.filter_id_high_box.Multiline = true;
            this.filter_id_high_box.Name = "filter_id_high_box";
            this.filter_id_high_box.Size = new System.Drawing.Size(70, 30);
            this.filter_id_high_box.TabIndex = 186;
            this.filter_id_high_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.filter_id_high_box.TextChanged += new System.EventHandler(this.filter_id_high_box_TextChanged);
            // 
            // filter_id_low_box
            // 
            this.filter_id_low_box.BackColor = System.Drawing.SystemColors.Control;
            this.filter_id_low_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filter_id_low_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.filter_id_low_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Italic);
            this.filter_id_low_box.Location = new System.Drawing.Point(3, 89);
            this.filter_id_low_box.MaxLength = 3;
            this.filter_id_low_box.Multiline = true;
            this.filter_id_low_box.Name = "filter_id_low_box";
            this.filter_id_low_box.Size = new System.Drawing.Size(70, 30);
            this.filter_id_low_box.TabIndex = 185;
            this.filter_id_low_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.filter_id_low_box.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label554
            // 
            this.label554.AutoSize = true;
            this.label554.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label554.Location = new System.Drawing.Point(3, 941);
            this.label554.Name = "label554";
            this.label554.Size = new System.Drawing.Size(206, 38);
            this.label554.TabIndex = 188;
            this.label554.Text = "CAN bus load:";
            this.label554.Click += new System.EventHandler(this.label554_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.update.Font = new System.Drawing.Font("3ds Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(3, 45);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(180, 36);
            this.update.TabIndex = 8;
            this.update.Text = "Update serial";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // can_bus_load
            // 
            this.can_bus_load.AutoSize = true;
            this.can_bus_load.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.can_bus_load.Location = new System.Drawing.Point(215, 941);
            this.can_bus_load.Name = "can_bus_load";
            this.can_bus_load.Size = new System.Drawing.Size(60, 38);
            this.can_bus_load.TabIndex = 189;
            this.can_bus_load.Text = "0%";
            // 
            // connect
            // 
            this.connect.BackColor = System.Drawing.Color.LightPink;
            this.connect.Font = new System.Drawing.Font("3ds Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect.Location = new System.Drawing.Point(3, 3);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(180, 36);
            this.connect.TabIndex = 9;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = false;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.connect);
            this.flowLayoutPanel1.Controls.Add(this.disconnect);
            this.flowLayoutPanel1.Controls.Add(this.update);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Controls.Add(this.filter_id_low_box);
            this.flowLayoutPanel1.Controls.Add(this.filter_id_high_box);
            this.flowLayoutPanel1.Controls.Add(this.reset_button);
            this.flowLayoutPanel1.Controls.Add(this.richTextBox2);
            this.flowLayoutPanel1.Controls.Add(this.label554);
            this.flowLayoutPanel1.Controls.Add(this.can_bus_load);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(435, 1009);
            this.flowLayoutPanel1.TabIndex = 190;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.tabcontrol1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(445, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1456, 988);
            this.flowLayoutPanel2.TabIndex = 190;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.tabPage1);
            this.tabcontrol1.Controls.Add(this.tabPage2);
            this.tabcontrol1.Controls.Add(this.ams_tabpage);
            this.tabcontrol1.Controls.Add(this.stack1);
            this.tabcontrol1.Controls.Add(this.stack2);
            this.tabcontrol1.Controls.Add(this.stack3);
            this.tabcontrol1.Controls.Add(this.stack4);
            this.tabcontrol1.Controls.Add(this.stack5);
            this.tabcontrol1.Controls.Add(this.stack6);
            this.tabcontrol1.Controls.Add(this.stack7);
            this.tabcontrol1.Controls.Add(this.stack8);
            this.tabcontrol1.Font = new System.Drawing.Font("3ds Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcontrol1.Location = new System.Drawing.Point(3, 3);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(1450, 953);
            this.tabcontrol1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.query_button);
            this.tabPage1.Controls.Add(this.nodes_groupBox);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.open_file);
            this.tabPage1.Controls.Add(this.close_file);
            this.tabPage1.Controls.Add(this.download);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Font = new System.Drawing.Font("3ds Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1442, 910);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Firmware";
            // 
            // query_button
            // 
            this.query_button.AutoSize = true;
            this.query_button.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.query_button.Location = new System.Drawing.Point(107, 366);
            this.query_button.Name = "query_button";
            this.query_button.Size = new System.Drawing.Size(287, 35);
            this.query_button.TabIndex = 26;
            this.query_button.Text = "request for device availability";
            this.query_button.UseVisualStyleBackColor = true;
            // 
            // nodes_groupBox
            // 
            this.nodes_groupBox.Controls.Add(this.steering_wheel_radio);
            this.nodes_groupBox.Controls.Add(this.brake_light_radio);
            this.nodes_groupBox.Controls.Add(this.fan_radio);
            this.nodes_groupBox.Controls.Add(this.ams_lv_radio);
            this.nodes_groupBox.Controls.Add(this.can_multiplexer_front_radio);
            this.nodes_groupBox.Controls.Add(this.bcu_radio);
            this.nodes_groupBox.Controls.Add(this.empty_radio);
            this.nodes_groupBox.Controls.Add(this.can_multiplexer_rear_radio);
            this.nodes_groupBox.Controls.Add(this.vcu_radio);
            this.nodes_groupBox.Controls.Add(this.vcdu_radio);
            this.nodes_groupBox.Controls.Add(this.ami_radio);
            this.nodes_groupBox.Controls.Add(this.discharge_radio);
            this.nodes_groupBox.Controls.Add(this.assi_radio);
            this.nodes_groupBox.Controls.Add(this.precharge_radio);
            this.nodes_groupBox.Controls.Add(this.ebs_radio);
            this.nodes_groupBox.Controls.Add(this.ams_master_radio);
            this.nodes_groupBox.Location = new System.Drawing.Point(20, 439);
            this.nodes_groupBox.Name = "nodes_groupBox";
            this.nodes_groupBox.Size = new System.Drawing.Size(509, 315);
            this.nodes_groupBox.TabIndex = 29;
            this.nodes_groupBox.TabStop = false;
            this.nodes_groupBox.Text = "Nodes";
            // 
            // steering_wheel_radio
            // 
            this.steering_wheel_radio.AutoSize = true;
            this.steering_wheel_radio.Font = new System.Drawing.Font("3ds Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steering_wheel_radio.ForeColor = System.Drawing.Color.DarkRed;
            this.steering_wheel_radio.Location = new System.Drawing.Point(315, 201);
            this.steering_wheel_radio.Name = "steering_wheel_radio";
            this.steering_wheel_radio.Size = new System.Drawing.Size(166, 30);
            this.steering_wheel_radio.TabIndex = 13;
            this.steering_wheel_radio.Text = "Steering Wheel";
            this.steering_wheel_radio.UseVisualStyleBackColor = true;
            // 
            // brake_light_radio
            // 
            this.brake_light_radio.AutoSize = true;
            this.brake_light_radio.Font = new System.Drawing.Font("3ds Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brake_light_radio.ForeColor = System.Drawing.Color.DarkRed;
            this.brake_light_radio.Location = new System.Drawing.Point(23, 201);
            this.brake_light_radio.Name = "brake_light_radio";
            this.brake_light_radio.Size = new System.Drawing.Size(133, 30);
            this.brake_light_radio.TabIndex = 5;
            this.brake_light_radio.Text = "Brake Light";
            this.brake_light_radio.UseVisualStyleBackColor = true;
            // 
            // fan_radio
            // 
            this.fan_radio.AutoSize = true;
            this.fan_radio.Font = new System.Drawing.Font("3ds Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fan_radio.ForeColor = System.Drawing.Color.DarkRed;
            this.fan_radio.Location = new System.Drawing.Point(315, 111);
            this.fan_radio.Name = "fan_radio";
            this.fan_radio.Size = new System.Drawing.Size(149, 30);
            this.fan_radio.TabIndex = 10;
            this.fan_radio.Text = "Fan regulator";
            this.fan_radio.UseVisualStyleBackColor = true;
            // 
            // ams_lv_radio
            // 
            this.ams_lv_radio.AutoSize = true;
            this.ams_lv_radio.Font = new System.Drawing.Font("3ds Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ams_lv_radio.ForeColor = System.Drawing.Color.DarkRed;
            this.ams_lv_radio.Location = new System.Drawing.Point(23, 171);
            this.ams_lv_radio.Name = "ams_lv_radio";
            this.ams_lv_radio.Size = new System.Drawing.Size(101, 30);
            this.ams_lv_radio.TabIndex = 4;
            this.ams_lv_radio.Text = "AMS LV";
            this.ams_lv_radio.UseVisualStyleBackColor = true;
            // 
            // can_multiplexer_front_radio
            // 
            this.can_multiplexer_front_radio.AutoSize = true;
            this.can_multiplexer_front_radio.Font = new System.Drawing.Font("3ds Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.can_multiplexer_front_radio.ForeColor = System.Drawing.Color.DarkRed;
            this.can_multiplexer_front_radio.Location = new System.Drawing.Point(23, 231);
            this.can_multiplexer_front_radio.Name = "can_multiplexer_front_radio";
            this.can_multiplexer_front_radio.Size = new System.Drawing.Size(141, 30);
            this.can_multiplexer_front_radio.TabIndex = 6;
            this.can_multiplexer_front_radio.Text = "CMUX Front";
            this.can_multiplexer_front_radio.UseVisualStyleBackColor = true;
            // 
            // bcu_radio
            // 
            this.bcu_radio.AutoSize = true;
            this.bcu_radio.Font = new System.Drawing.Font("3ds Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcu_radio.ForeColor = System.Drawing.Color.DarkRed;
            this.bcu_radio.Location = new System.Drawing.Point(23, 141);
            this.bcu_radio.Name = "bcu_radio";
            this.bcu_radio.Size = new System.Drawing.Size(72, 30);
            this.bcu_radio.TabIndex = 3;
            this.bcu_radio.Text = "BCU";
            this.bcu_radio.UseVisualStyleBackColor = true;
            // 
            // empty_radio
            // 
            this.empty_radio.AutoSize = true;
            this.empty_radio.Font = new System.Drawing.Font("3ds Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empty_radio.ForeColor = System.Drawing.Color.DarkRed;
            this.empty_radio.Location = new System.Drawing.Point(315, 261);
            this.empty_radio.Name = "empty_radio";
            this.empty_radio.Size = new System.Drawing.Size(91, 30);
            this.empty_radio.TabIndex = 15;
            this.empty_radio.Text = "Empty";
            this.empty_radio.UseVisualStyleBackColor = true;
            // 
            // can_multiplexer_rear_radio
            // 
            this.can_multiplexer_rear_radio.AutoSize = true;
            this.can_multiplexer_rear_radio.Font = new System.Drawing.Font("3ds Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.can_multiplexer_rear_radio.ForeColor = System.Drawing.Color.DarkRed;
            this.can_multiplexer_rear_radio.Location = new System.Drawing.Point(23, 261);
            this.can_multiplexer_rear_radio.Name = "can_multiplexer_rear_radio";
            this.can_multiplexer_rear_radio.Size = new System.Drawing.Size(133, 30);
            this.can_multiplexer_rear_radio.TabIndex = 7;
            this.can_multiplexer_rear_radio.Text = "CMUX Rear";
            this.can_multiplexer_rear_radio.UseVisualStyleBackColor = true;
            // 
            // vcu_radio
            // 
            this.vcu_radio.AutoSize = true;
            this.vcu_radio.Font = new System.Drawing.Font("3ds Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vcu_radio.ForeColor = System.Drawing.Color.DarkRed;
            this.vcu_radio.Location = new System.Drawing.Point(23, 111);
            this.vcu_radio.Name = "vcu_radio";
            this.vcu_radio.Size = new System.Drawing.Size(70, 30);
            this.vcu_radio.TabIndex = 2;
            this.vcu_radio.Text = "VCU";
            this.vcu_radio.UseVisualStyleBackColor = true;
            // 
            // vcdu_radio
            // 
            this.vcdu_radio.AutoSize = true;
            this.vcdu_radio.Font = new System.Drawing.Font("3ds Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vcdu_radio.ForeColor = System.Drawing.Color.DarkRed;
            this.vcdu_radio.Location = new System.Drawing.Point(315, 231);
            this.vcdu_radio.Name = "vcdu_radio";
            this.vcdu_radio.Size = new System.Drawing.Size(84, 30);
            this.vcdu_radio.TabIndex = 14;
            this.vcdu_radio.Text = "VCDU";
            this.vcdu_radio.UseVisualStyleBackColor = true;
            // 
            // ami_radio
            // 
            this.ami_radio.AutoSize = true;
            this.ami_radio.Font = new System.Drawing.Font("3ds Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ami_radio.ForeColor = System.Drawing.Color.DarkRed;
            this.ami_radio.Location = new System.Drawing.Point(315, 51);
            this.ami_radio.Name = "ami_radio";
            this.ami_radio.Size = new System.Drawing.Size(71, 30);
            this.ami_radio.TabIndex = 8;
            this.ami_radio.Text = "AMI";
            this.ami_radio.UseVisualStyleBackColor = true;
            // 
            // discharge_radio
            // 
            this.discharge_radio.AutoSize = true;
            this.discharge_radio.Font = new System.Drawing.Font("3ds Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discharge_radio.ForeColor = System.Drawing.Color.DarkRed;
            this.discharge_radio.Location = new System.Drawing.Point(23, 81);
            this.discharge_radio.Name = "discharge_radio";
            this.discharge_radio.Size = new System.Drawing.Size(120, 30);
            this.discharge_radio.TabIndex = 1;
            this.discharge_radio.Text = "Discharge";
            this.discharge_radio.UseVisualStyleBackColor = true;
            // 
            // assi_radio
            // 
            this.assi_radio.AutoSize = true;
            this.assi_radio.Font = new System.Drawing.Font("3ds Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assi_radio.ForeColor = System.Drawing.Color.DarkRed;
            this.assi_radio.Location = new System.Drawing.Point(315, 81);
            this.assi_radio.Name = "assi_radio";
            this.assi_radio.Size = new System.Drawing.Size(75, 30);
            this.assi_radio.TabIndex = 9;
            this.assi_radio.Text = "ASSI";
            this.assi_radio.UseVisualStyleBackColor = true;
            // 
            // precharge_radio
            // 
            this.precharge_radio.AutoSize = true;
            this.precharge_radio.Font = new System.Drawing.Font("3ds Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precharge_radio.ForeColor = System.Drawing.Color.DarkRed;
            this.precharge_radio.Location = new System.Drawing.Point(23, 51);
            this.precharge_radio.Name = "precharge_radio";
            this.precharge_radio.Size = new System.Drawing.Size(122, 30);
            this.precharge_radio.TabIndex = 0;
            this.precharge_radio.Text = "Precharge";
            this.precharge_radio.UseVisualStyleBackColor = true;
            // 
            // ebs_radio
            // 
            this.ebs_radio.AutoSize = true;
            this.ebs_radio.Font = new System.Drawing.Font("3ds Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ebs_radio.ForeColor = System.Drawing.Color.DarkRed;
            this.ebs_radio.Location = new System.Drawing.Point(315, 171);
            this.ebs_radio.Name = "ebs_radio";
            this.ebs_radio.Size = new System.Drawing.Size(68, 30);
            this.ebs_radio.TabIndex = 12;
            this.ebs_radio.Text = "EBS";
            this.ebs_radio.UseVisualStyleBackColor = true;
            // 
            // ams_master_radio
            // 
            this.ams_master_radio.AutoSize = true;
            this.ams_master_radio.Font = new System.Drawing.Font("3ds Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ams_master_radio.ForeColor = System.Drawing.Color.DarkRed;
            this.ams_master_radio.Location = new System.Drawing.Point(315, 141);
            this.ams_master_radio.Name = "ams_master_radio";
            this.ams_master_radio.Size = new System.Drawing.Size(142, 30);
            this.ams_master_radio.TabIndex = 11;
            this.ams_master_radio.Text = "AMS Master\r\n";
            this.ams_master_radio.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("3ds Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 30);
            this.label9.TabIndex = 28;
            this.label9.Text = "Strings:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("3ds Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 96);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(480, 200);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // open_file
            // 
            this.open_file.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.open_file.Font = new System.Drawing.Font("3ds Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_file.Location = new System.Drawing.Point(6, 7);
            this.open_file.Name = "open_file";
            this.open_file.Size = new System.Drawing.Size(190, 50);
            this.open_file.TabIndex = 0;
            this.open_file.Text = "Open .hex file";
            this.open_file.UseVisualStyleBackColor = false;
            // 
            // close_file
            // 
            this.close_file.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.close_file.Font = new System.Drawing.Font("3ds Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_file.Location = new System.Drawing.Point(202, 7);
            this.close_file.Name = "close_file";
            this.close_file.Size = new System.Drawing.Size(90, 50);
            this.close_file.TabIndex = 1;
            this.close_file.Text = "Close";
            this.close_file.UseVisualStyleBackColor = false;
            // 
            // download
            // 
            this.download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.download.Font = new System.Drawing.Font("3ds Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download.Location = new System.Drawing.Point(298, 7);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(190, 50);
            this.download.TabIndex = 2;
            this.download.Text = "Download";
            this.download.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.Font = new System.Drawing.Font("3ds Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(480, 27);
            this.textBox1.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 302);
            this.progressBar1.MarqueeAnimationSpeed = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(482, 10);
            this.progressBar1.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Font = new System.Drawing.Font("3ds Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1442, 910);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "General";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox9);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.group_vcu);
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1410, 1737);
            this.panel1.TabIndex = 190;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hotcell);
            this.groupBox3.Controls.Add(this.label472);
            this.groupBox3.Controls.Add(this.label471);
            this.groupBox3.Controls.Add(this.current_box);
            this.groupBox3.Controls.Add(this.label477);
            this.groupBox3.Controls.Add(this.label476);
            this.groupBox3.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Italic);
            this.groupBox3.Location = new System.Drawing.Point(684, 639);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 126);
            this.groupBox3.TabIndex = 253;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SERVICE";
            // 
            // hotcell
            // 
            this.hotcell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.hotcell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hotcell.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.hotcell.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hotcell.Location = new System.Drawing.Point(167, 31);
            this.hotcell.Multiline = true;
            this.hotcell.Name = "hotcell";
            this.hotcell.ReadOnly = true;
            this.hotcell.Size = new System.Drawing.Size(75, 25);
            this.hotcell.TabIndex = 188;
            this.hotcell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label472
            // 
            this.label472.AutoSize = true;
            this.label472.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label472.Location = new System.Drawing.Point(248, 30);
            this.label472.Name = "label472";
            this.label472.Size = new System.Drawing.Size(32, 26);
            this.label472.TabIndex = 189;
            this.label472.Text = "°C";
            // 
            // label471
            // 
            this.label471.AutoSize = true;
            this.label471.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label471.Location = new System.Drawing.Point(52, 33);
            this.label471.Name = "label471";
            this.label471.Size = new System.Drawing.Size(118, 26);
            this.label471.TabIndex = 187;
            this.label471.Text = "Hottest cell:";
            // 
            // current_box
            // 
            this.current_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.current_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.current_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.current_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.current_box.Location = new System.Drawing.Point(167, 63);
            this.current_box.Multiline = true;
            this.current_box.Name = "current_box";
            this.current_box.ReadOnly = true;
            this.current_box.Size = new System.Drawing.Size(75, 25);
            this.current_box.TabIndex = 197;
            this.current_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label477
            // 
            this.label477.AutoSize = true;
            this.label477.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label477.Location = new System.Drawing.Point(38, 65);
            this.label477.Name = "label477";
            this.label477.Size = new System.Drawing.Size(132, 26);
            this.label477.TabIndex = 199;
            this.label477.Text = "Total Current:";
            // 
            // label476
            // 
            this.label476.AutoSize = true;
            this.label476.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label476.Location = new System.Drawing.Point(248, 63);
            this.label476.Name = "label476";
            this.label476.Size = new System.Drawing.Size(26, 26);
            this.label476.TabIndex = 198;
            this.label476.Text = "A";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.charging_current_box);
            this.groupBox9.Controls.Add(this.label553);
            this.groupBox9.Controls.Add(this.label552);
            this.groupBox9.Controls.Add(this.charging_status_box);
            this.groupBox9.Controls.Add(this.label551);
            this.groupBox9.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Italic);
            this.groupBox9.Location = new System.Drawing.Point(986, 639);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(335, 126);
            this.groupBox9.TabIndex = 254;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Charging";
            // 
            // charging_current_box
            // 
            this.charging_current_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.charging_current_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.charging_current_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.charging_current_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.charging_current_box.Location = new System.Drawing.Point(188, 91);
            this.charging_current_box.Multiline = true;
            this.charging_current_box.Name = "charging_current_box";
            this.charging_current_box.ReadOnly = true;
            this.charging_current_box.Size = new System.Drawing.Size(75, 25);
            this.charging_current_box.TabIndex = 215;
            this.charging_current_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label553
            // 
            this.label553.AutoSize = true;
            this.label553.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label553.Location = new System.Drawing.Point(269, 93);
            this.label553.Name = "label553";
            this.label553.Size = new System.Drawing.Size(26, 26);
            this.label553.TabIndex = 214;
            this.label553.Text = "A";
            // 
            // label552
            // 
            this.label552.AutoSize = true;
            this.label552.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label552.Location = new System.Drawing.Point(6, 93);
            this.label552.Name = "label552";
            this.label552.Size = new System.Drawing.Size(176, 26);
            this.label552.TabIndex = 213;
            this.label552.Text = "Charging Currrent:";
            // 
            // charging_status_box
            // 
            this.charging_status_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.charging_status_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.charging_status_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.charging_status_box.Location = new System.Drawing.Point(8, 60);
            this.charging_status_box.Multiline = true;
            this.charging_status_box.Name = "charging_status_box";
            this.charging_status_box.ReadOnly = true;
            this.charging_status_box.Size = new System.Drawing.Size(321, 25);
            this.charging_status_box.TabIndex = 212;
            this.charging_status_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label551
            // 
            this.label551.AutoSize = true;
            this.label551.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label551.Location = new System.Drawing.Point(6, 30);
            this.label551.Name = "label551";
            this.label551.Size = new System.Drawing.Size(73, 26);
            this.label551.TabIndex = 211;
            this.label551.Text = "Status:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label500);
            this.groupBox4.Controls.Add(this.richTextBox_precharge_errors);
            this.groupBox4.Controls.Add(this.richTextBox_precharge_status);
            this.groupBox4.Controls.Add(this.label499);
            this.groupBox4.Controls.Add(this.airminus_box);
            this.groupBox4.Controls.Add(this.label473);
            this.groupBox4.Controls.Add(this.label474);
            this.groupBox4.Controls.Add(this.label475);
            this.groupBox4.Controls.Add(this.airplus_box);
            this.groupBox4.Controls.Add(this.prechrelay_box);
            this.groupBox4.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Italic);
            this.groupBox4.Location = new System.Drawing.Point(238, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(510, 336);
            this.groupBox4.TabIndex = 217;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PreCharge";
            // 
            // label500
            // 
            this.label500.AutoSize = true;
            this.label500.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label500.Location = new System.Drawing.Point(294, 138);
            this.label500.Name = "label500";
            this.label500.Size = new System.Drawing.Size(167, 26);
            this.label500.TabIndex = 254;
            this.label500.Text = "PreCharge Errors:";
            // 
            // richTextBox_precharge_errors
            // 
            this.richTextBox_precharge_errors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox_precharge_errors.Font = new System.Drawing.Font("Adobe Heiti Std R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox_precharge_errors.Location = new System.Drawing.Point(255, 167);
            this.richTextBox_precharge_errors.Name = "richTextBox_precharge_errors";
            this.richTextBox_precharge_errors.Size = new System.Drawing.Size(249, 164);
            this.richTextBox_precharge_errors.TabIndex = 253;
            this.richTextBox_precharge_errors.Text = "";
            // 
            // richTextBox_precharge_status
            // 
            this.richTextBox_precharge_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox_precharge_status.Font = new System.Drawing.Font("Adobe Heiti Std R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox_precharge_status.Location = new System.Drawing.Point(6, 167);
            this.richTextBox_precharge_status.Name = "richTextBox_precharge_status";
            this.richTextBox_precharge_status.Size = new System.Drawing.Size(249, 164);
            this.richTextBox_precharge_status.TabIndex = 252;
            this.richTextBox_precharge_status.Text = "";
            // 
            // label499
            // 
            this.label499.AutoSize = true;
            this.label499.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label499.Location = new System.Drawing.Point(44, 140);
            this.label499.Name = "label499";
            this.label499.Size = new System.Drawing.Size(170, 26);
            this.label499.TabIndex = 203;
            this.label499.Text = "PreCharge Status:";
            // 
            // airminus_box
            // 
            this.airminus_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.airminus_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.airminus_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.airminus_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.airminus_box.Location = new System.Drawing.Point(196, 36);
            this.airminus_box.Multiline = true;
            this.airminus_box.Name = "airminus_box";
            this.airminus_box.ReadOnly = true;
            this.airminus_box.Size = new System.Drawing.Size(85, 25);
            this.airminus_box.TabIndex = 194;
            this.airminus_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label473
            // 
            this.label473.AutoSize = true;
            this.label473.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label473.Location = new System.Drawing.Point(120, 38);
            this.label473.Name = "label473";
            this.label473.Size = new System.Drawing.Size(64, 26);
            this.label473.TabIndex = 191;
            this.label473.Text = "- AIR:";
            // 
            // label474
            // 
            this.label474.AutoSize = true;
            this.label474.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label474.Location = new System.Drawing.Point(116, 69);
            this.label474.Name = "label474";
            this.label474.Size = new System.Drawing.Size(68, 26);
            this.label474.TabIndex = 192;
            this.label474.Text = "+ AIR:";
            // 
            // label475
            // 
            this.label475.AutoSize = true;
            this.label475.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label475.Location = new System.Drawing.Point(29, 100);
            this.label475.Name = "label475";
            this.label475.Size = new System.Drawing.Size(155, 26);
            this.label475.TabIndex = 193;
            this.label475.Text = "Precharge relay:";
            // 
            // airplus_box
            // 
            this.airplus_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.airplus_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.airplus_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.airplus_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.airplus_box.Location = new System.Drawing.Point(196, 67);
            this.airplus_box.Multiline = true;
            this.airplus_box.Name = "airplus_box";
            this.airplus_box.ReadOnly = true;
            this.airplus_box.Size = new System.Drawing.Size(85, 25);
            this.airplus_box.TabIndex = 195;
            this.airplus_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prechrelay_box
            // 
            this.prechrelay_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.prechrelay_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prechrelay_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.prechrelay_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.prechrelay_box.Location = new System.Drawing.Point(196, 98);
            this.prechrelay_box.Multiline = true;
            this.prechrelay_box.Name = "prechrelay_box";
            this.prechrelay_box.ReadOnly = true;
            this.prechrelay_box.Size = new System.Drawing.Size(85, 25);
            this.prechrelay_box.TabIndex = 196;
            this.prechrelay_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("3ds Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1327, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 1734);
            this.button1.TabIndex = 212;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // group_vcu
            // 
            this.group_vcu.AutoSize = true;
            this.group_vcu.Controls.Add(this.richTextBox_vcu);
            this.group_vcu.Controls.Add(this.label550);
            this.group_vcu.Controls.Add(this.label549);
            this.group_vcu.Controls.Add(this.label526);
            this.group_vcu.Controls.Add(this.label528);
            this.group_vcu.Controls.Add(this.label530);
            this.group_vcu.Controls.Add(this.label531);
            this.group_vcu.Controls.Add(this.label532);
            this.group_vcu.Controls.Add(this.label533);
            this.group_vcu.Controls.Add(this.label534);
            this.group_vcu.Controls.Add(this.label535);
            this.group_vcu.Controls.Add(this.label536);
            this.group_vcu.Controls.Add(this.label537);
            this.group_vcu.Controls.Add(this.label538);
            this.group_vcu.Controls.Add(this.label539);
            this.group_vcu.Controls.Add(this.assi_current_box);
            this.group_vcu.Controls.Add(this.gps_current_box);
            this.group_vcu.Controls.Add(this.as_current_box);
            this.group_vcu.Controls.Add(this.cameras_current_box);
            this.group_vcu.Controls.Add(this.res_current_box);
            this.group_vcu.Controls.Add(this.lidar_current_box);
            this.group_vcu.Controls.Add(this.label527);
            this.group_vcu.Controls.Add(this.label529);
            this.group_vcu.Controls.Add(this.brake_light_current_box);
            this.group_vcu.Controls.Add(this.vcdu_current_box);
            this.group_vcu.Controls.Add(this.label513);
            this.group_vcu.Controls.Add(this.label514);
            this.group_vcu.Controls.Add(this.label515);
            this.group_vcu.Controls.Add(this.label516);
            this.group_vcu.Controls.Add(this.ebs_current_box);
            this.group_vcu.Controls.Add(this.actuator_current_box);
            this.group_vcu.Controls.Add(this.label449);
            this.group_vcu.Controls.Add(this.label487);
            this.group_vcu.Controls.Add(this.label488);
            this.group_vcu.Controls.Add(this.label485);
            this.group_vcu.Controls.Add(this.label489);
            this.group_vcu.Controls.Add(this.label484);
            this.group_vcu.Controls.Add(this.label490);
            this.group_vcu.Controls.Add(this.label483);
            this.group_vcu.Controls.Add(this.label493);
            this.group_vcu.Controls.Add(this.label480);
            this.group_vcu.Controls.Add(this.label494);
            this.group_vcu.Controls.Add(this.label479);
            this.group_vcu.Controls.Add(this.label478);
            this.group_vcu.Controls.Add(this.fan2_current_box);
            this.group_vcu.Controls.Add(this.fan1_current_box);
            this.group_vcu.Controls.Add(this.lcs_current_box);
            this.group_vcu.Controls.Add(this.cooling_pump_current_box);
            this.group_vcu.Controls.Add(this.inverter_current_box);
            this.group_vcu.Controls.Add(this.tsal_current_box);
            this.group_vcu.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Italic);
            this.group_vcu.Location = new System.Drawing.Point(754, 3);
            this.group_vcu.Name = "group_vcu";
            this.group_vcu.Size = new System.Drawing.Size(567, 625);
            this.group_vcu.TabIndex = 213;
            this.group_vcu.TabStop = false;
            this.group_vcu.Text = "VCU";
            // 
            // richTextBox_vcu
            // 
            this.richTextBox_vcu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox_vcu.Font = new System.Drawing.Font("Adobe Heiti Std R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox_vcu.Location = new System.Drawing.Point(167, 310);
            this.richTextBox_vcu.Name = "richTextBox_vcu";
            this.richTextBox_vcu.Size = new System.Drawing.Size(344, 263);
            this.richTextBox_vcu.TabIndex = 251;
            this.richTextBox_vcu.Text = "";
            // 
            // label550
            // 
            this.label550.AutoSize = true;
            this.label550.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label550.Location = new System.Drawing.Point(43, 196);
            this.label550.Name = "label550";
            this.label550.Size = new System.Drawing.Size(118, 26);
            this.label550.TabIndex = 249;
            this.label550.Text = "Brake Light:";
            // 
            // label549
            // 
            this.label549.AutoSize = true;
            this.label549.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label549.Location = new System.Drawing.Point(92, 165);
            this.label549.Name = "label549";
            this.label549.Size = new System.Drawing.Size(69, 26);
            this.label549.TabIndex = 248;
            this.label549.Text = "VCDU:";
            // 
            // label526
            // 
            this.label526.AutoSize = true;
            this.label526.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label526.Location = new System.Drawing.Point(334, 134);
            this.label526.Name = "label526";
            this.label526.Size = new System.Drawing.Size(94, 26);
            this.label526.TabIndex = 242;
            this.label526.Text = "Cameras:";
            // 
            // label528
            // 
            this.label528.AutoSize = true;
            this.label528.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label528.Location = new System.Drawing.Point(385, 258);
            this.label528.Name = "label528";
            this.label528.Size = new System.Drawing.Size(43, 26);
            this.label528.TabIndex = 239;
            this.label528.Text = "AS:";
            // 
            // label530
            // 
            this.label530.AutoSize = true;
            this.label530.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label530.Location = new System.Drawing.Point(517, 255);
            this.label530.Name = "label530";
            this.label530.Size = new System.Drawing.Size(26, 26);
            this.label530.TabIndex = 247;
            this.label530.Text = "A";
            // 
            // label531
            // 
            this.label531.AutoSize = true;
            this.label531.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label531.Location = new System.Drawing.Point(375, 227);
            this.label531.Name = "label531";
            this.label531.Size = new System.Drawing.Size(53, 26);
            this.label531.TabIndex = 237;
            this.label531.Text = "RES:";
            // 
            // label532
            // 
            this.label532.AutoSize = true;
            this.label532.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label532.Location = new System.Drawing.Point(517, 224);
            this.label532.Name = "label532";
            this.label532.Size = new System.Drawing.Size(26, 26);
            this.label532.TabIndex = 246;
            this.label532.Text = "A";
            // 
            // label533
            // 
            this.label533.AutoSize = true;
            this.label533.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label533.Location = new System.Drawing.Point(368, 196);
            this.label533.Name = "label533";
            this.label533.Size = new System.Drawing.Size(60, 26);
            this.label533.TabIndex = 236;
            this.label533.Text = "ASSI:";
            // 
            // label534
            // 
            this.label534.AutoSize = true;
            this.label534.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label534.Location = new System.Drawing.Point(517, 193);
            this.label534.Name = "label534";
            this.label534.Size = new System.Drawing.Size(26, 26);
            this.label534.TabIndex = 245;
            this.label534.Text = "A";
            // 
            // label535
            // 
            this.label535.AutoSize = true;
            this.label535.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label535.Location = new System.Drawing.Point(367, 165);
            this.label535.Name = "label535";
            this.label535.Size = new System.Drawing.Size(61, 26);
            this.label535.TabIndex = 234;
            this.label535.Text = "Lidar:";
            // 
            // label536
            // 
            this.label536.AutoSize = true;
            this.label536.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label536.Location = new System.Drawing.Point(517, 162);
            this.label536.Name = "label536";
            this.label536.Size = new System.Drawing.Size(26, 26);
            this.label536.TabIndex = 244;
            this.label536.Text = "A";
            // 
            // label537
            // 
            this.label537.AutoSize = true;
            this.label537.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label537.Location = new System.Drawing.Point(372, 103);
            this.label537.Name = "label537";
            this.label537.Size = new System.Drawing.Size(56, 26);
            this.label537.TabIndex = 231;
            this.label537.Text = "GPS:";
            // 
            // label538
            // 
            this.label538.AutoSize = true;
            this.label538.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label538.Location = new System.Drawing.Point(517, 131);
            this.label538.Name = "label538";
            this.label538.Size = new System.Drawing.Size(26, 26);
            this.label538.TabIndex = 243;
            this.label538.Text = "A";
            // 
            // label539
            // 
            this.label539.AutoSize = true;
            this.label539.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label539.Location = new System.Drawing.Point(517, 100);
            this.label539.Name = "label539";
            this.label539.Size = new System.Drawing.Size(26, 26);
            this.label539.TabIndex = 232;
            this.label539.Text = "A";
            // 
            // assi_current_box
            // 
            this.assi_current_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.assi_current_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assi_current_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.assi_current_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.assi_current_box.Location = new System.Drawing.Point(436, 194);
            this.assi_current_box.Multiline = true;
            this.assi_current_box.Name = "assi_current_box";
            this.assi_current_box.ReadOnly = true;
            this.assi_current_box.Size = new System.Drawing.Size(75, 25);
            this.assi_current_box.TabIndex = 238;
            this.assi_current_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gps_current_box
            // 
            this.gps_current_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gps_current_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gps_current_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.gps_current_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gps_current_box.Location = new System.Drawing.Point(436, 101);
            this.gps_current_box.Multiline = true;
            this.gps_current_box.Name = "gps_current_box";
            this.gps_current_box.ReadOnly = true;
            this.gps_current_box.Size = new System.Drawing.Size(75, 25);
            this.gps_current_box.TabIndex = 230;
            this.gps_current_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // as_current_box
            // 
            this.as_current_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.as_current_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.as_current_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.as_current_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.as_current_box.Location = new System.Drawing.Point(436, 256);
            this.as_current_box.Multiline = true;
            this.as_current_box.Name = "as_current_box";
            this.as_current_box.ReadOnly = true;
            this.as_current_box.Size = new System.Drawing.Size(75, 25);
            this.as_current_box.TabIndex = 241;
            this.as_current_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cameras_current_box
            // 
            this.cameras_current_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cameras_current_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cameras_current_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cameras_current_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cameras_current_box.Location = new System.Drawing.Point(436, 132);
            this.cameras_current_box.Multiline = true;
            this.cameras_current_box.Name = "cameras_current_box";
            this.cameras_current_box.ReadOnly = true;
            this.cameras_current_box.Size = new System.Drawing.Size(75, 25);
            this.cameras_current_box.TabIndex = 233;
            this.cameras_current_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // res_current_box
            // 
            this.res_current_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.res_current_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.res_current_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.res_current_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.res_current_box.Location = new System.Drawing.Point(436, 225);
            this.res_current_box.Multiline = true;
            this.res_current_box.Name = "res_current_box";
            this.res_current_box.ReadOnly = true;
            this.res_current_box.Size = new System.Drawing.Size(75, 25);
            this.res_current_box.TabIndex = 240;
            this.res_current_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lidar_current_box
            // 
            this.lidar_current_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lidar_current_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lidar_current_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lidar_current_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lidar_current_box.Location = new System.Drawing.Point(436, 163);
            this.lidar_current_box.Multiline = true;
            this.lidar_current_box.Name = "lidar_current_box";
            this.lidar_current_box.ReadOnly = true;
            this.lidar_current_box.Size = new System.Drawing.Size(75, 25);
            this.lidar_current_box.TabIndex = 235;
            this.lidar_current_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label527
            // 
            this.label527.AutoSize = true;
            this.label527.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label527.Location = new System.Drawing.Point(248, 193);
            this.label527.Name = "label527";
            this.label527.Size = new System.Drawing.Size(26, 26);
            this.label527.TabIndex = 229;
            this.label527.Text = "A";
            // 
            // label529
            // 
            this.label529.AutoSize = true;
            this.label529.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label529.Location = new System.Drawing.Point(248, 162);
            this.label529.Name = "label529";
            this.label529.Size = new System.Drawing.Size(26, 26);
            this.label529.TabIndex = 228;
            this.label529.Text = "A";
            // 
            // brake_light_current_box
            // 
            this.brake_light_current_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.brake_light_current_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brake_light_current_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.brake_light_current_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.brake_light_current_box.Location = new System.Drawing.Point(167, 194);
            this.brake_light_current_box.Multiline = true;
            this.brake_light_current_box.Name = "brake_light_current_box";
            this.brake_light_current_box.ReadOnly = true;
            this.brake_light_current_box.Size = new System.Drawing.Size(75, 25);
            this.brake_light_current_box.TabIndex = 227;
            this.brake_light_current_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vcdu_current_box
            // 
            this.vcdu_current_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.vcdu_current_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vcdu_current_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.vcdu_current_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.vcdu_current_box.Location = new System.Drawing.Point(167, 163);
            this.vcdu_current_box.Multiline = true;
            this.vcdu_current_box.Name = "vcdu_current_box";
            this.vcdu_current_box.ReadOnly = true;
            this.vcdu_current_box.Size = new System.Drawing.Size(75, 25);
            this.vcdu_current_box.TabIndex = 226;
            this.vcdu_current_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label513
            // 
            this.label513.AutoSize = true;
            this.label513.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label513.Location = new System.Drawing.Point(375, 72);
            this.label513.Name = "label513";
            this.label513.Size = new System.Drawing.Size(53, 26);
            this.label513.TabIndex = 219;
            this.label513.Text = "EBS:";
            // 
            // label514
            // 
            this.label514.AutoSize = true;
            this.label514.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label514.Location = new System.Drawing.Point(517, 69);
            this.label514.Name = "label514";
            this.label514.Size = new System.Drawing.Size(26, 26);
            this.label514.TabIndex = 223;
            this.label514.Text = "A";
            // 
            // label515
            // 
            this.label515.AutoSize = true;
            this.label515.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label515.Location = new System.Drawing.Point(334, 41);
            this.label515.Name = "label515";
            this.label515.Size = new System.Drawing.Size(94, 26);
            this.label515.TabIndex = 218;
            this.label515.Text = "Actuator:";
            // 
            // label516
            // 
            this.label516.AutoSize = true;
            this.label516.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label516.Location = new System.Drawing.Point(517, 38);
            this.label516.Name = "label516";
            this.label516.Size = new System.Drawing.Size(26, 26);
            this.label516.TabIndex = 222;
            this.label516.Text = "A";
            // 
            // ebs_current_box
            // 
            this.ebs_current_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ebs_current_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ebs_current_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ebs_current_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ebs_current_box.Location = new System.Drawing.Point(436, 70);
            this.ebs_current_box.Multiline = true;
            this.ebs_current_box.Name = "ebs_current_box";
            this.ebs_current_box.ReadOnly = true;
            this.ebs_current_box.Size = new System.Drawing.Size(75, 25);
            this.ebs_current_box.TabIndex = 221;
            this.ebs_current_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // actuator_current_box
            // 
            this.actuator_current_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.actuator_current_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.actuator_current_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.actuator_current_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.actuator_current_box.Location = new System.Drawing.Point(436, 39);
            this.actuator_current_box.Multiline = true;
            this.actuator_current_box.Name = "actuator_current_box";
            this.actuator_current_box.ReadOnly = true;
            this.actuator_current_box.Size = new System.Drawing.Size(75, 25);
            this.actuator_current_box.TabIndex = 220;
            this.actuator_current_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label449
            // 
            this.label449.AutoSize = true;
            this.label449.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label449.Location = new System.Drawing.Point(241, 281);
            this.label449.Name = "label449";
            this.label449.Size = new System.Drawing.Size(115, 26);
            this.label449.TabIndex = 217;
            this.label449.Text = "VCU Status:";
            // 
            // label487
            // 
            this.label487.AutoSize = true;
            this.label487.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label487.Location = new System.Drawing.Point(74, 71);
            this.label487.Name = "label487";
            this.label487.Size = new System.Drawing.Size(87, 26);
            this.label487.TabIndex = 208;
            this.label487.Text = "Inverter:";
            // 
            // label488
            // 
            this.label488.AutoSize = true;
            this.label488.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label488.Location = new System.Drawing.Point(94, 258);
            this.label488.Name = "label488";
            this.label488.Size = new System.Drawing.Size(67, 26);
            this.label488.TabIndex = 207;
            this.label488.Text = "Fan 2:";
            // 
            // label485
            // 
            this.label485.AutoSize = true;
            this.label485.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label485.Location = new System.Drawing.Point(248, 255);
            this.label485.Name = "label485";
            this.label485.Size = new System.Drawing.Size(26, 26);
            this.label485.TabIndex = 215;
            this.label485.Text = "A";
            // 
            // label489
            // 
            this.label489.AutoSize = true;
            this.label489.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label489.Location = new System.Drawing.Point(94, 227);
            this.label489.Name = "label489";
            this.label489.Size = new System.Drawing.Size(67, 26);
            this.label489.TabIndex = 206;
            this.label489.Text = "Fan 1:";
            // 
            // label484
            // 
            this.label484.AutoSize = true;
            this.label484.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label484.Location = new System.Drawing.Point(248, 224);
            this.label484.Name = "label484";
            this.label484.Size = new System.Drawing.Size(26, 26);
            this.label484.TabIndex = 214;
            this.label484.Text = "A";
            // 
            // label490
            // 
            this.label490.AutoSize = true;
            this.label490.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label490.Location = new System.Drawing.Point(18, 134);
            this.label490.Name = "label490";
            this.label490.Size = new System.Drawing.Size(143, 26);
            this.label490.TabIndex = 205;
            this.label490.Text = "Cooling Pump:";
            // 
            // label483
            // 
            this.label483.AutoSize = true;
            this.label483.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label483.Location = new System.Drawing.Point(248, 131);
            this.label483.Name = "label483";
            this.label483.Size = new System.Drawing.Size(26, 26);
            this.label483.TabIndex = 213;
            this.label483.Text = "A";
            // 
            // label493
            // 
            this.label493.AutoSize = true;
            this.label493.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label493.Location = new System.Drawing.Point(97, 102);
            this.label493.Name = "label493";
            this.label493.Size = new System.Drawing.Size(64, 26);
            this.label493.TabIndex = 202;
            this.label493.Text = "TSAL:";
            // 
            // label480
            // 
            this.label480.AutoSize = true;
            this.label480.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label480.Location = new System.Drawing.Point(248, 99);
            this.label480.Name = "label480";
            this.label480.Size = new System.Drawing.Size(26, 26);
            this.label480.TabIndex = 210;
            this.label480.Text = "A";
            // 
            // label494
            // 
            this.label494.AutoSize = true;
            this.label494.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label494.Location = new System.Drawing.Point(110, 40);
            this.label494.Name = "label494";
            this.label494.Size = new System.Drawing.Size(51, 26);
            this.label494.TabIndex = 201;
            this.label494.Text = "LCS:";
            // 
            // label479
            // 
            this.label479.AutoSize = true;
            this.label479.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label479.Location = new System.Drawing.Point(248, 68);
            this.label479.Name = "label479";
            this.label479.Size = new System.Drawing.Size(26, 26);
            this.label479.TabIndex = 209;
            this.label479.Text = "A";
            // 
            // label478
            // 
            this.label478.AutoSize = true;
            this.label478.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label478.Location = new System.Drawing.Point(248, 37);
            this.label478.Name = "label478";
            this.label478.Size = new System.Drawing.Size(26, 26);
            this.label478.TabIndex = 201;
            this.label478.Text = "A";
            // 
            // fan2_current_box
            // 
            this.fan2_current_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.fan2_current_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fan2_current_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.fan2_current_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fan2_current_box.Location = new System.Drawing.Point(167, 256);
            this.fan2_current_box.Multiline = true;
            this.fan2_current_box.Name = "fan2_current_box";
            this.fan2_current_box.ReadOnly = true;
            this.fan2_current_box.Size = new System.Drawing.Size(75, 25);
            this.fan2_current_box.TabIndex = 208;
            this.fan2_current_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fan1_current_box
            // 
            this.fan1_current_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.fan1_current_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fan1_current_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.fan1_current_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fan1_current_box.Location = new System.Drawing.Point(167, 225);
            this.fan1_current_box.Multiline = true;
            this.fan1_current_box.Name = "fan1_current_box";
            this.fan1_current_box.ReadOnly = true;
            this.fan1_current_box.Size = new System.Drawing.Size(75, 25);
            this.fan1_current_box.TabIndex = 207;
            this.fan1_current_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lcs_current_box
            // 
            this.lcs_current_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lcs_current_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lcs_current_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lcs_current_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lcs_current_box.Location = new System.Drawing.Point(167, 38);
            this.lcs_current_box.Multiline = true;
            this.lcs_current_box.Name = "lcs_current_box";
            this.lcs_current_box.ReadOnly = true;
            this.lcs_current_box.Size = new System.Drawing.Size(75, 25);
            this.lcs_current_box.TabIndex = 201;
            this.lcs_current_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cooling_pump_current_box
            // 
            this.cooling_pump_current_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cooling_pump_current_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cooling_pump_current_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cooling_pump_current_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cooling_pump_current_box.Location = new System.Drawing.Point(167, 132);
            this.cooling_pump_current_box.Multiline = true;
            this.cooling_pump_current_box.Name = "cooling_pump_current_box";
            this.cooling_pump_current_box.ReadOnly = true;
            this.cooling_pump_current_box.Size = new System.Drawing.Size(75, 25);
            this.cooling_pump_current_box.TabIndex = 206;
            this.cooling_pump_current_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverter_current_box
            // 
            this.inverter_current_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.inverter_current_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inverter_current_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.inverter_current_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inverter_current_box.Location = new System.Drawing.Point(167, 69);
            this.inverter_current_box.Multiline = true;
            this.inverter_current_box.Name = "inverter_current_box";
            this.inverter_current_box.ReadOnly = true;
            this.inverter_current_box.Size = new System.Drawing.Size(75, 25);
            this.inverter_current_box.TabIndex = 202;
            this.inverter_current_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tsal_current_box
            // 
            this.tsal_current_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsal_current_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsal_current_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tsal_current_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tsal_current_box.Location = new System.Drawing.Point(167, 100);
            this.tsal_current_box.Multiline = true;
            this.tsal_current_box.Name = "tsal_current_box";
            this.tsal_current_box.ReadOnly = true;
            this.tsal_current_box.Size = new System.Drawing.Size(75, 25);
            this.tsal_current_box.TabIndex = 203;
            this.tsal_current_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label492);
            this.groupBox8.Controls.Add(this.label540);
            this.groupBox8.Controls.Add(this.label541);
            this.groupBox8.Controls.Add(this.label491);
            this.groupBox8.Controls.Add(this.label486);
            this.groupBox8.Controls.Add(this.label482);
            this.groupBox8.Controls.Add(this.label525);
            this.groupBox8.Controls.Add(this.label524);
            this.groupBox8.Controls.Add(this.label523);
            this.groupBox8.Controls.Add(this.label522);
            this.groupBox8.Controls.Add(this.ams_lv_status_box);
            this.groupBox8.Controls.Add(this.label521);
            this.groupBox8.Controls.Add(this.label501);
            this.groupBox8.Controls.Add(this.label520);
            this.groupBox8.Controls.Add(this.label517);
            this.groupBox8.Controls.Add(this.label518);
            this.groupBox8.Controls.Add(this.label519);
            this.groupBox8.Controls.Add(this.lv_voltage_cell_6_box);
            this.groupBox8.Controls.Add(this.lv_temp_cell_6_box);
            this.groupBox8.Controls.Add(this.label510);
            this.groupBox8.Controls.Add(this.label509);
            this.groupBox8.Controls.Add(this.lv_temp_cell_5_box);
            this.groupBox8.Controls.Add(this.lv_voltage_cell_5_box);
            this.groupBox8.Controls.Add(this.label511);
            this.groupBox8.Controls.Add(this.label508);
            this.groupBox8.Controls.Add(this.lv_temp_cell_4_box);
            this.groupBox8.Controls.Add(this.label512);
            this.groupBox8.Controls.Add(this.label507);
            this.groupBox8.Controls.Add(this.label506);
            this.groupBox8.Controls.Add(this.label505);
            this.groupBox8.Controls.Add(this.lv_voltage_cell_4_box);
            this.groupBox8.Controls.Add(this.label504);
            this.groupBox8.Controls.Add(this.lv_voltage_cell_2_box);
            this.groupBox8.Controls.Add(this.lv_voltage_cell_3_box);
            this.groupBox8.Controls.Add(this.lv_voltage_cell_1_box);
            this.groupBox8.Controls.Add(this.lv_hottest_cell_box);
            this.groupBox8.Controls.Add(this.label502);
            this.groupBox8.Controls.Add(this.label503);
            this.groupBox8.Controls.Add(this.lv_temp_cell_1_box);
            this.groupBox8.Controls.Add(this.lv_temp_cell_3_box);
            this.groupBox8.Controls.Add(this.lv_temp_cell_2_box);
            this.groupBox8.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Italic);
            this.groupBox8.Location = new System.Drawing.Point(3, 474);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(198, 544);
            this.groupBox8.TabIndex = 221;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "AMS LV";
            // 
            // label492
            // 
            this.label492.AutoSize = true;
            this.label492.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label492.Location = new System.Drawing.Point(167, 341);
            this.label492.Name = "label492";
            this.label492.Size = new System.Drawing.Size(23, 26);
            this.label492.TabIndex = 249;
            this.label492.Text = "V";
            // 
            // label540
            // 
            this.label540.AutoSize = true;
            this.label540.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label540.Location = new System.Drawing.Point(167, 372);
            this.label540.Name = "label540";
            this.label540.Size = new System.Drawing.Size(23, 26);
            this.label540.TabIndex = 250;
            this.label540.Text = "V";
            // 
            // label541
            // 
            this.label541.AutoSize = true;
            this.label541.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label541.Location = new System.Drawing.Point(167, 403);
            this.label541.Name = "label541";
            this.label541.Size = new System.Drawing.Size(23, 26);
            this.label541.TabIndex = 251;
            this.label541.Text = "V";
            // 
            // label491
            // 
            this.label491.AutoSize = true;
            this.label491.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label491.Location = new System.Drawing.Point(21, 406);
            this.label491.Name = "label491";
            this.label491.Size = new System.Drawing.Size(67, 26);
            this.label491.TabIndex = 248;
            this.label491.Text = "Cell 6:";
            // 
            // label486
            // 
            this.label486.AutoSize = true;
            this.label486.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label486.Location = new System.Drawing.Point(21, 344);
            this.label486.Name = "label486";
            this.label486.Size = new System.Drawing.Size(67, 26);
            this.label486.TabIndex = 247;
            this.label486.Text = "Cell 4:";
            // 
            // label482
            // 
            this.label482.AutoSize = true;
            this.label482.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label482.Location = new System.Drawing.Point(21, 282);
            this.label482.Name = "label482";
            this.label482.Size = new System.Drawing.Size(67, 26);
            this.label482.TabIndex = 246;
            this.label482.Text = "Cell 2:";
            // 
            // label525
            // 
            this.label525.AutoSize = true;
            this.label525.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label525.Location = new System.Drawing.Point(161, 217);
            this.label525.Name = "label525";
            this.label525.Size = new System.Drawing.Size(32, 26);
            this.label525.TabIndex = 245;
            this.label525.Text = "°C";
            // 
            // label524
            // 
            this.label524.AutoSize = true;
            this.label524.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label524.Location = new System.Drawing.Point(161, 186);
            this.label524.Name = "label524";
            this.label524.Size = new System.Drawing.Size(32, 26);
            this.label524.TabIndex = 244;
            this.label524.Text = "°C";
            // 
            // label523
            // 
            this.label523.AutoSize = true;
            this.label523.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label523.Location = new System.Drawing.Point(161, 155);
            this.label523.Name = "label523";
            this.label523.Size = new System.Drawing.Size(32, 26);
            this.label523.TabIndex = 243;
            this.label523.Text = "°C";
            // 
            // label522
            // 
            this.label522.AutoSize = true;
            this.label522.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label522.Location = new System.Drawing.Point(161, 124);
            this.label522.Name = "label522";
            this.label522.Size = new System.Drawing.Size(32, 26);
            this.label522.TabIndex = 242;
            this.label522.Text = "°C";
            // 
            // ams_lv_status_box
            // 
            this.ams_lv_status_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ams_lv_status_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ams_lv_status_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ams_lv_status_box.Location = new System.Drawing.Point(3, 508);
            this.ams_lv_status_box.Multiline = true;
            this.ams_lv_status_box.Name = "ams_lv_status_box";
            this.ams_lv_status_box.ReadOnly = true;
            this.ams_lv_status_box.Size = new System.Drawing.Size(189, 25);
            this.ams_lv_status_box.TabIndex = 216;
            this.ams_lv_status_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label521
            // 
            this.label521.AutoSize = true;
            this.label521.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label521.Location = new System.Drawing.Point(161, 93);
            this.label521.Name = "label521";
            this.label521.Size = new System.Drawing.Size(32, 26);
            this.label521.TabIndex = 241;
            this.label521.Text = "°C";
            // 
            // label501
            // 
            this.label501.AutoSize = true;
            this.label501.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label501.Location = new System.Drawing.Point(39, 479);
            this.label501.Name = "label501";
            this.label501.Size = new System.Drawing.Size(146, 26);
            this.label501.TabIndex = 217;
            this.label501.Text = "AMS LV Status:";
            // 
            // label520
            // 
            this.label520.AutoSize = true;
            this.label520.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label520.Location = new System.Drawing.Point(161, 62);
            this.label520.Name = "label520";
            this.label520.Size = new System.Drawing.Size(32, 26);
            this.label520.TabIndex = 221;
            this.label520.Text = "°C";
            // 
            // label517
            // 
            this.label517.AutoSize = true;
            this.label517.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label517.Location = new System.Drawing.Point(9, 220);
            this.label517.Name = "label517";
            this.label517.Size = new System.Drawing.Size(81, 26);
            this.label517.TabIndex = 240;
            this.label517.Text = "temp 6:";
            // 
            // label518
            // 
            this.label518.AutoSize = true;
            this.label518.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label518.Location = new System.Drawing.Point(9, 189);
            this.label518.Name = "label518";
            this.label518.Size = new System.Drawing.Size(81, 26);
            this.label518.TabIndex = 239;
            this.label518.Text = "temp 5:";
            // 
            // label519
            // 
            this.label519.AutoSize = true;
            this.label519.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label519.Location = new System.Drawing.Point(9, 158);
            this.label519.Name = "label519";
            this.label519.Size = new System.Drawing.Size(81, 26);
            this.label519.TabIndex = 238;
            this.label519.Text = "temp 4:";
            // 
            // lv_voltage_cell_6_box
            // 
            this.lv_voltage_cell_6_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lv_voltage_cell_6_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_voltage_cell_6_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lv_voltage_cell_6_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lv_voltage_cell_6_box.Location = new System.Drawing.Point(100, 404);
            this.lv_voltage_cell_6_box.Multiline = true;
            this.lv_voltage_cell_6_box.Name = "lv_voltage_cell_6_box";
            this.lv_voltage_cell_6_box.ReadOnly = true;
            this.lv_voltage_cell_6_box.Size = new System.Drawing.Size(61, 25);
            this.lv_voltage_cell_6_box.TabIndex = 225;
            this.lv_voltage_cell_6_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lv_temp_cell_6_box
            // 
            this.lv_temp_cell_6_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lv_temp_cell_6_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_temp_cell_6_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lv_temp_cell_6_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lv_temp_cell_6_box.Location = new System.Drawing.Point(100, 218);
            this.lv_temp_cell_6_box.Multiline = true;
            this.lv_temp_cell_6_box.Name = "lv_temp_cell_6_box";
            this.lv_temp_cell_6_box.ReadOnly = true;
            this.lv_temp_cell_6_box.Size = new System.Drawing.Size(60, 25);
            this.lv_temp_cell_6_box.TabIndex = 237;
            this.lv_temp_cell_6_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label510
            // 
            this.label510.AutoSize = true;
            this.label510.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label510.Location = new System.Drawing.Point(166, 248);
            this.label510.Name = "label510";
            this.label510.Size = new System.Drawing.Size(23, 26);
            this.label510.TabIndex = 211;
            this.label510.Text = "V";
            // 
            // label509
            // 
            this.label509.AutoSize = true;
            this.label509.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label509.Location = new System.Drawing.Point(21, 375);
            this.label509.Name = "label509";
            this.label509.Size = new System.Drawing.Size(67, 26);
            this.label509.TabIndex = 234;
            this.label509.Text = "Cell 5:";
            // 
            // lv_temp_cell_5_box
            // 
            this.lv_temp_cell_5_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lv_temp_cell_5_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_temp_cell_5_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lv_temp_cell_5_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lv_temp_cell_5_box.Location = new System.Drawing.Point(100, 187);
            this.lv_temp_cell_5_box.Multiline = true;
            this.lv_temp_cell_5_box.Name = "lv_temp_cell_5_box";
            this.lv_temp_cell_5_box.ReadOnly = true;
            this.lv_temp_cell_5_box.Size = new System.Drawing.Size(60, 25);
            this.lv_temp_cell_5_box.TabIndex = 236;
            this.lv_temp_cell_5_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lv_voltage_cell_5_box
            // 
            this.lv_voltage_cell_5_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lv_voltage_cell_5_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_voltage_cell_5_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lv_voltage_cell_5_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lv_voltage_cell_5_box.Location = new System.Drawing.Point(100, 373);
            this.lv_voltage_cell_5_box.Multiline = true;
            this.lv_voltage_cell_5_box.Name = "lv_voltage_cell_5_box";
            this.lv_voltage_cell_5_box.ReadOnly = true;
            this.lv_voltage_cell_5_box.Size = new System.Drawing.Size(61, 25);
            this.lv_voltage_cell_5_box.TabIndex = 224;
            this.lv_voltage_cell_5_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label511
            // 
            this.label511.AutoSize = true;
            this.label511.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label511.Location = new System.Drawing.Point(166, 279);
            this.label511.Name = "label511";
            this.label511.Size = new System.Drawing.Size(23, 26);
            this.label511.TabIndex = 212;
            this.label511.Text = "V";
            // 
            // label508
            // 
            this.label508.AutoSize = true;
            this.label508.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label508.Location = new System.Drawing.Point(21, 313);
            this.label508.Name = "label508";
            this.label508.Size = new System.Drawing.Size(67, 26);
            this.label508.TabIndex = 233;
            this.label508.Text = "Cell 3:";
            // 
            // lv_temp_cell_4_box
            // 
            this.lv_temp_cell_4_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lv_temp_cell_4_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_temp_cell_4_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lv_temp_cell_4_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lv_temp_cell_4_box.Location = new System.Drawing.Point(100, 156);
            this.lv_temp_cell_4_box.Multiline = true;
            this.lv_temp_cell_4_box.Name = "lv_temp_cell_4_box";
            this.lv_temp_cell_4_box.ReadOnly = true;
            this.lv_temp_cell_4_box.Size = new System.Drawing.Size(60, 25);
            this.lv_temp_cell_4_box.TabIndex = 235;
            this.lv_temp_cell_4_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label512
            // 
            this.label512.AutoSize = true;
            this.label512.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label512.Location = new System.Drawing.Point(166, 310);
            this.label512.Name = "label512";
            this.label512.Size = new System.Drawing.Size(23, 26);
            this.label512.TabIndex = 213;
            this.label512.Text = "V";
            // 
            // label507
            // 
            this.label507.AutoSize = true;
            this.label507.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label507.Location = new System.Drawing.Point(21, 251);
            this.label507.Name = "label507";
            this.label507.Size = new System.Drawing.Size(67, 26);
            this.label507.TabIndex = 232;
            this.label507.Text = "Cell 1:";
            // 
            // label506
            // 
            this.label506.AutoSize = true;
            this.label506.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label506.Location = new System.Drawing.Point(9, 127);
            this.label506.Name = "label506";
            this.label506.Size = new System.Drawing.Size(81, 26);
            this.label506.TabIndex = 231;
            this.label506.Text = "temp 3:";
            // 
            // label505
            // 
            this.label505.AutoSize = true;
            this.label505.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label505.Location = new System.Drawing.Point(9, 96);
            this.label505.Name = "label505";
            this.label505.Size = new System.Drawing.Size(81, 26);
            this.label505.TabIndex = 230;
            this.label505.Text = "temp 2:";
            // 
            // lv_voltage_cell_4_box
            // 
            this.lv_voltage_cell_4_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lv_voltage_cell_4_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_voltage_cell_4_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lv_voltage_cell_4_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lv_voltage_cell_4_box.Location = new System.Drawing.Point(100, 342);
            this.lv_voltage_cell_4_box.Multiline = true;
            this.lv_voltage_cell_4_box.Name = "lv_voltage_cell_4_box";
            this.lv_voltage_cell_4_box.ReadOnly = true;
            this.lv_voltage_cell_4_box.Size = new System.Drawing.Size(60, 25);
            this.lv_voltage_cell_4_box.TabIndex = 223;
            this.lv_voltage_cell_4_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label504
            // 
            this.label504.AutoSize = true;
            this.label504.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label504.Location = new System.Drawing.Point(9, 65);
            this.label504.Name = "label504";
            this.label504.Size = new System.Drawing.Size(81, 26);
            this.label504.TabIndex = 229;
            this.label504.Text = "temp 1:";
            // 
            // lv_voltage_cell_2_box
            // 
            this.lv_voltage_cell_2_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lv_voltage_cell_2_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_voltage_cell_2_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lv_voltage_cell_2_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lv_voltage_cell_2_box.Location = new System.Drawing.Point(100, 280);
            this.lv_voltage_cell_2_box.Multiline = true;
            this.lv_voltage_cell_2_box.Name = "lv_voltage_cell_2_box";
            this.lv_voltage_cell_2_box.ReadOnly = true;
            this.lv_voltage_cell_2_box.Size = new System.Drawing.Size(60, 25);
            this.lv_voltage_cell_2_box.TabIndex = 222;
            this.lv_voltage_cell_2_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lv_voltage_cell_3_box
            // 
            this.lv_voltage_cell_3_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lv_voltage_cell_3_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_voltage_cell_3_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lv_voltage_cell_3_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lv_voltage_cell_3_box.Location = new System.Drawing.Point(100, 311);
            this.lv_voltage_cell_3_box.Multiline = true;
            this.lv_voltage_cell_3_box.Name = "lv_voltage_cell_3_box";
            this.lv_voltage_cell_3_box.ReadOnly = true;
            this.lv_voltage_cell_3_box.Size = new System.Drawing.Size(60, 25);
            this.lv_voltage_cell_3_box.TabIndex = 221;
            this.lv_voltage_cell_3_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lv_voltage_cell_1_box
            // 
            this.lv_voltage_cell_1_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lv_voltage_cell_1_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_voltage_cell_1_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lv_voltage_cell_1_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lv_voltage_cell_1_box.Location = new System.Drawing.Point(100, 249);
            this.lv_voltage_cell_1_box.Multiline = true;
            this.lv_voltage_cell_1_box.Name = "lv_voltage_cell_1_box";
            this.lv_voltage_cell_1_box.ReadOnly = true;
            this.lv_voltage_cell_1_box.Size = new System.Drawing.Size(60, 25);
            this.lv_voltage_cell_1_box.TabIndex = 220;
            this.lv_voltage_cell_1_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lv_hottest_cell_box
            // 
            this.lv_hottest_cell_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lv_hottest_cell_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_hottest_cell_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lv_hottest_cell_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lv_hottest_cell_box.Location = new System.Drawing.Point(100, 32);
            this.lv_hottest_cell_box.Multiline = true;
            this.lv_hottest_cell_box.Name = "lv_hottest_cell_box";
            this.lv_hottest_cell_box.ReadOnly = true;
            this.lv_hottest_cell_box.Size = new System.Drawing.Size(60, 25);
            this.lv_hottest_cell_box.TabIndex = 219;
            this.lv_hottest_cell_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label502
            // 
            this.label502.AutoSize = true;
            this.label502.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label502.Location = new System.Drawing.Point(161, 31);
            this.label502.Name = "label502";
            this.label502.Size = new System.Drawing.Size(32, 26);
            this.label502.TabIndex = 220;
            this.label502.Text = "°C";
            // 
            // label503
            // 
            this.label503.AutoSize = true;
            this.label503.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label503.Location = new System.Drawing.Point(6, 34);
            this.label503.Name = "label503";
            this.label503.Size = new System.Drawing.Size(84, 26);
            this.label503.TabIndex = 218;
            this.label503.Text = "Hottest:";
            // 
            // lv_temp_cell_1_box
            // 
            this.lv_temp_cell_1_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lv_temp_cell_1_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_temp_cell_1_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lv_temp_cell_1_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lv_temp_cell_1_box.Location = new System.Drawing.Point(100, 63);
            this.lv_temp_cell_1_box.Multiline = true;
            this.lv_temp_cell_1_box.Name = "lv_temp_cell_1_box";
            this.lv_temp_cell_1_box.ReadOnly = true;
            this.lv_temp_cell_1_box.Size = new System.Drawing.Size(60, 25);
            this.lv_temp_cell_1_box.TabIndex = 226;
            this.lv_temp_cell_1_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lv_temp_cell_3_box
            // 
            this.lv_temp_cell_3_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lv_temp_cell_3_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_temp_cell_3_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lv_temp_cell_3_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lv_temp_cell_3_box.Location = new System.Drawing.Point(100, 125);
            this.lv_temp_cell_3_box.Multiline = true;
            this.lv_temp_cell_3_box.Name = "lv_temp_cell_3_box";
            this.lv_temp_cell_3_box.ReadOnly = true;
            this.lv_temp_cell_3_box.Size = new System.Drawing.Size(60, 25);
            this.lv_temp_cell_3_box.TabIndex = 228;
            this.lv_temp_cell_3_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lv_temp_cell_2_box
            // 
            this.lv_temp_cell_2_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lv_temp_cell_2_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_temp_cell_2_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lv_temp_cell_2_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lv_temp_cell_2_box.Location = new System.Drawing.Point(100, 94);
            this.lv_temp_cell_2_box.Multiline = true;
            this.lv_temp_cell_2_box.Name = "lv_temp_cell_2_box";
            this.lv_temp_cell_2_box.ReadOnly = true;
            this.lv_temp_cell_2_box.Size = new System.Drawing.Size(60, 25);
            this.lv_temp_cell_2_box.TabIndex = 227;
            this.lv_temp_cell_2_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.actuator_status_box);
            this.groupBox7.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Italic);
            this.groupBox7.Location = new System.Drawing.Point(238, 521);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(335, 67);
            this.groupBox7.TabIndex = 220;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Actuator";
            // 
            // actuator_status_box
            // 
            this.actuator_status_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.actuator_status_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.actuator_status_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.actuator_status_box.Location = new System.Drawing.Point(6, 33);
            this.actuator_status_box.Multiline = true;
            this.actuator_status_box.Name = "actuator_status_box";
            this.actuator_status_box.ReadOnly = true;
            this.actuator_status_box.Size = new System.Drawing.Size(321, 25);
            this.actuator_status_box.TabIndex = 210;
            this.actuator_status_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rpm2_box);
            this.groupBox6.Controls.Add(this.rpm1_box);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Italic);
            this.groupBox6.Location = new System.Drawing.Point(575, 345);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(177, 99);
            this.groupBox6.TabIndex = 219;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "FAN Reg";
            // 
            // rpm2_box
            // 
            this.rpm2_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rpm2_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpm2_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rpm2_box.Location = new System.Drawing.Point(86, 67);
            this.rpm2_box.Multiline = true;
            this.rpm2_box.Name = "rpm2_box";
            this.rpm2_box.ReadOnly = true;
            this.rpm2_box.Size = new System.Drawing.Size(75, 25);
            this.rpm2_box.TabIndex = 9;
            this.rpm2_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rpm1_box
            // 
            this.rpm1_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rpm1_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpm1_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.rpm1_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rpm1_box.Location = new System.Drawing.Point(86, 36);
            this.rpm1_box.Multiline = true;
            this.rpm1_box.Name = "rpm1_box";
            this.rpm1_box.ReadOnly = true;
            this.rpm1_box.Size = new System.Drawing.Size(75, 25);
            this.rpm1_box.TabIndex = 8;
            this.rpm1_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label6.Location = new System.Drawing.Point(6, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "RPM2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "RPM1:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.vcdu_status_box);
            this.groupBox5.Controls.Add(this.motor_temp_box);
            this.groupBox5.Controls.Add(this.inverter_temp_box);
            this.groupBox5.Controls.Add(this.label451);
            this.groupBox5.Controls.Add(this.label450);
            this.groupBox5.Controls.Add(this.label452);
            this.groupBox5.Controls.Add(this.label453);
            this.groupBox5.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Italic);
            this.groupBox5.Location = new System.Drawing.Point(238, 345);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(335, 170);
            this.groupBox5.TabIndex = 218;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "VCDU";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label8.Location = new System.Drawing.Point(104, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 26);
            this.label8.TabIndex = 209;
            this.label8.Text = "VCDU Status:";
            // 
            // vcdu_status_box
            // 
            this.vcdu_status_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.vcdu_status_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vcdu_status_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.vcdu_status_box.Location = new System.Drawing.Point(8, 131);
            this.vcdu_status_box.Multiline = true;
            this.vcdu_status_box.Name = "vcdu_status_box";
            this.vcdu_status_box.ReadOnly = true;
            this.vcdu_status_box.Size = new System.Drawing.Size(319, 25);
            this.vcdu_status_box.TabIndex = 208;
            this.vcdu_status_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // motor_temp_box
            // 
            this.motor_temp_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.motor_temp_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.motor_temp_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.motor_temp_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.motor_temp_box.Location = new System.Drawing.Point(168, 32);
            this.motor_temp_box.Multiline = true;
            this.motor_temp_box.Name = "motor_temp_box";
            this.motor_temp_box.ReadOnly = true;
            this.motor_temp_box.Size = new System.Drawing.Size(75, 25);
            this.motor_temp_box.TabIndex = 15;
            this.motor_temp_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverter_temp_box
            // 
            this.inverter_temp_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.inverter_temp_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inverter_temp_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.inverter_temp_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inverter_temp_box.Location = new System.Drawing.Point(168, 63);
            this.inverter_temp_box.Multiline = true;
            this.inverter_temp_box.Name = "inverter_temp_box";
            this.inverter_temp_box.ReadOnly = true;
            this.inverter_temp_box.Size = new System.Drawing.Size(75, 25);
            this.inverter_temp_box.TabIndex = 16;
            this.inverter_temp_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label451
            // 
            this.label451.AutoSize = true;
            this.label451.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label451.Location = new System.Drawing.Point(46, 34);
            this.label451.Name = "label451";
            this.label451.Size = new System.Drawing.Size(123, 26);
            this.label451.TabIndex = 17;
            this.label451.Text = "Motor temp:";
            // 
            // label450
            // 
            this.label450.AutoSize = true;
            this.label450.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label450.Location = new System.Drawing.Point(31, 65);
            this.label450.Name = "label450";
            this.label450.Size = new System.Drawing.Size(138, 26);
            this.label450.TabIndex = 18;
            this.label450.Text = "Inverter temp:";
            // 
            // label452
            // 
            this.label452.AutoSize = true;
            this.label452.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label452.Location = new System.Drawing.Point(249, 31);
            this.label452.Name = "label452";
            this.label452.Size = new System.Drawing.Size(32, 26);
            this.label452.TabIndex = 19;
            this.label452.Text = "°C";
            // 
            // label453
            // 
            this.label453.AutoSize = true;
            this.label453.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label453.Location = new System.Drawing.Point(249, 62);
            this.label453.Name = "label453";
            this.label453.Size = new System.Drawing.Size(32, 26);
            this.label453.TabIndex = 20;
            this.label453.Text = "°C";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox11);
            this.groupBox1.Controls.Add(this.groupBox10);
            this.groupBox1.Controls.Add(this.total_voltage_box);
            this.groupBox1.Controls.Add(this.label498);
            this.groupBox1.Controls.Add(this.label495);
            this.groupBox1.Controls.Add(this.stack5_box);
            this.groupBox1.Controls.Add(this.stack1_box);
            this.groupBox1.Controls.Add(this.label455);
            this.groupBox1.Controls.Add(this.stack2_box);
            this.groupBox1.Controls.Add(this.label456);
            this.groupBox1.Controls.Add(this.stack3_box);
            this.groupBox1.Controls.Add(this.label457);
            this.groupBox1.Controls.Add(this.stack4_box);
            this.groupBox1.Controls.Add(this.label458);
            this.groupBox1.Controls.Add(this.label459);
            this.groupBox1.Controls.Add(this.stack6_box);
            this.groupBox1.Controls.Add(this.label460);
            this.groupBox1.Controls.Add(this.stack7_box);
            this.groupBox1.Controls.Add(this.label461);
            this.groupBox1.Controls.Add(this.stack8_box);
            this.groupBox1.Controls.Add(this.label470);
            this.groupBox1.Controls.Add(this.label462);
            this.groupBox1.Controls.Add(this.label469);
            this.groupBox1.Controls.Add(this.label463);
            this.groupBox1.Controls.Add(this.label468);
            this.groupBox1.Controls.Add(this.label464);
            this.groupBox1.Controls.Add(this.label467);
            this.groupBox1.Controls.Add(this.label465);
            this.groupBox1.Controls.Add(this.label466);
            this.groupBox1.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Italic);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 465);
            this.groupBox1.TabIndex = 214;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Battery";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.cell_max_number);
            this.groupBox11.Controls.Add(this.stack_max_number);
            this.groupBox11.Controls.Add(this.label556);
            this.groupBox11.Controls.Add(this.voltage_max_box);
            this.groupBox11.Font = new System.Drawing.Font("3ds Light", 12F);
            this.groupBox11.Location = new System.Drawing.Point(116, 346);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(107, 113);
            this.groupBox11.TabIndex = 213;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Max cell";
            // 
            // cell_max_number
            // 
            this.cell_max_number.AutoSize = true;
            this.cell_max_number.Font = new System.Drawing.Font("3ds Light", 12F);
            this.cell_max_number.Location = new System.Drawing.Point(6, 81);
            this.cell_max_number.Name = "cell_max_number";
            this.cell_max_number.Size = new System.Drawing.Size(63, 26);
            this.cell_max_number.TabIndex = 221;
            this.cell_max_number.Text = "Cell: -";
            // 
            // stack_max_number
            // 
            this.stack_max_number.AutoSize = true;
            this.stack_max_number.Font = new System.Drawing.Font("3ds Light", 12F);
            this.stack_max_number.Location = new System.Drawing.Point(6, 57);
            this.stack_max_number.Name = "stack_max_number";
            this.stack_max_number.Size = new System.Drawing.Size(78, 26);
            this.stack_max_number.TabIndex = 220;
            this.stack_max_number.Text = "Stack: -";
            // 
            // label556
            // 
            this.label556.AutoSize = true;
            this.label556.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label556.Location = new System.Drawing.Point(82, 31);
            this.label556.Name = "label556";
            this.label556.Size = new System.Drawing.Size(23, 26);
            this.label556.TabIndex = 219;
            this.label556.Text = "V";
            // 
            // voltage_max_box
            // 
            this.voltage_max_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.voltage_max_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.voltage_max_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.voltage_max_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.voltage_max_box.Location = new System.Drawing.Point(6, 29);
            this.voltage_max_box.Multiline = true;
            this.voltage_max_box.Name = "voltage_max_box";
            this.voltage_max_box.ReadOnly = true;
            this.voltage_max_box.Size = new System.Drawing.Size(75, 25);
            this.voltage_max_box.TabIndex = 217;
            this.voltage_max_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label558);
            this.groupBox10.Controls.Add(this.cell_min_number);
            this.groupBox10.Controls.Add(this.stack_min_number);
            this.groupBox10.Controls.Add(this.voltage_min_box);
            this.groupBox10.Font = new System.Drawing.Font("3ds Light", 12F);
            this.groupBox10.Location = new System.Drawing.Point(6, 346);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(107, 113);
            this.groupBox10.TabIndex = 212;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Min cell";
            // 
            // label558
            // 
            this.label558.AutoSize = true;
            this.label558.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label558.Location = new System.Drawing.Point(82, 31);
            this.label558.Name = "label558";
            this.label558.Size = new System.Drawing.Size(23, 26);
            this.label558.TabIndex = 219;
            this.label558.Text = "V";
            // 
            // cell_min_number
            // 
            this.cell_min_number.AutoSize = true;
            this.cell_min_number.Font = new System.Drawing.Font("3ds Light", 12F);
            this.cell_min_number.Location = new System.Drawing.Point(6, 81);
            this.cell_min_number.Name = "cell_min_number";
            this.cell_min_number.Size = new System.Drawing.Size(63, 26);
            this.cell_min_number.TabIndex = 221;
            this.cell_min_number.Text = "Cell: -";
            // 
            // stack_min_number
            // 
            this.stack_min_number.AutoSize = true;
            this.stack_min_number.Font = new System.Drawing.Font("3ds Light", 12F);
            this.stack_min_number.Location = new System.Drawing.Point(6, 57);
            this.stack_min_number.Name = "stack_min_number";
            this.stack_min_number.Size = new System.Drawing.Size(78, 26);
            this.stack_min_number.TabIndex = 220;
            this.stack_min_number.Text = "Stack: -";
            // 
            // voltage_min_box
            // 
            this.voltage_min_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.voltage_min_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.voltage_min_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.voltage_min_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.voltage_min_box.Location = new System.Drawing.Point(6, 29);
            this.voltage_min_box.Multiline = true;
            this.voltage_min_box.Name = "voltage_min_box";
            this.voltage_min_box.ReadOnly = true;
            this.voltage_min_box.Size = new System.Drawing.Size(75, 25);
            this.voltage_min_box.TabIndex = 217;
            this.voltage_min_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_voltage_box
            // 
            this.total_voltage_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.total_voltage_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total_voltage_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.total_voltage_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 16F, System.Drawing.FontStyle.Bold);
            this.total_voltage_box.Location = new System.Drawing.Point(88, 29);
            this.total_voltage_box.MaxLength = 8;
            this.total_voltage_box.Multiline = true;
            this.total_voltage_box.Name = "total_voltage_box";
            this.total_voltage_box.ReadOnly = true;
            this.total_voltage_box.Size = new System.Drawing.Size(109, 41);
            this.total_voltage_box.TabIndex = 203;
            this.total_voltage_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label498
            // 
            this.label498.AutoSize = true;
            this.label498.Font = new System.Drawing.Font("3ds Light", 16F);
            this.label498.Location = new System.Drawing.Point(197, 36);
            this.label498.Name = "label498";
            this.label498.Size = new System.Drawing.Size(30, 35);
            this.label498.TabIndex = 204;
            this.label498.Text = "V";
            // 
            // label495
            // 
            this.label495.AutoSize = true;
            this.label495.Font = new System.Drawing.Font("3ds Light", 16F, System.Drawing.FontStyle.Italic);
            this.label495.Location = new System.Drawing.Point(8, 33);
            this.label495.Name = "label495";
            this.label495.Size = new System.Drawing.Size(81, 35);
            this.label495.TabIndex = 202;
            this.label495.Text = "Total:";
            // 
            // stack5_box
            // 
            this.stack5_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.stack5_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stack5_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.stack5_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stack5_box.Location = new System.Drawing.Point(101, 203);
            this.stack5_box.Multiline = true;
            this.stack5_box.Name = "stack5_box";
            this.stack5_box.ReadOnly = true;
            this.stack5_box.Size = new System.Drawing.Size(75, 25);
            this.stack5_box.TabIndex = 66;
            this.stack5_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stack1_box
            // 
            this.stack1_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.stack1_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stack1_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.stack1_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stack1_box.Location = new System.Drawing.Point(101, 79);
            this.stack1_box.Multiline = true;
            this.stack1_box.Name = "stack1_box";
            this.stack1_box.ReadOnly = true;
            this.stack1_box.Size = new System.Drawing.Size(75, 25);
            this.stack1_box.TabIndex = 58;
            this.stack1_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label455
            // 
            this.label455.AutoSize = true;
            this.label455.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label455.Location = new System.Drawing.Point(182, 78);
            this.label455.Name = "label455";
            this.label455.Size = new System.Drawing.Size(23, 26);
            this.label455.TabIndex = 59;
            this.label455.Text = "V";
            // 
            // stack2_box
            // 
            this.stack2_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.stack2_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stack2_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.stack2_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stack2_box.Location = new System.Drawing.Point(101, 110);
            this.stack2_box.Multiline = true;
            this.stack2_box.Name = "stack2_box";
            this.stack2_box.ReadOnly = true;
            this.stack2_box.Size = new System.Drawing.Size(75, 25);
            this.stack2_box.TabIndex = 60;
            this.stack2_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label456
            // 
            this.label456.AutoSize = true;
            this.label456.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label456.Location = new System.Drawing.Point(182, 109);
            this.label456.Name = "label456";
            this.label456.Size = new System.Drawing.Size(23, 26);
            this.label456.TabIndex = 61;
            this.label456.Text = "V";
            // 
            // stack3_box
            // 
            this.stack3_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.stack3_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stack3_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.stack3_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stack3_box.Location = new System.Drawing.Point(101, 141);
            this.stack3_box.Multiline = true;
            this.stack3_box.Name = "stack3_box";
            this.stack3_box.ReadOnly = true;
            this.stack3_box.Size = new System.Drawing.Size(75, 25);
            this.stack3_box.TabIndex = 62;
            this.stack3_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label457
            // 
            this.label457.AutoSize = true;
            this.label457.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label457.Location = new System.Drawing.Point(182, 140);
            this.label457.Name = "label457";
            this.label457.Size = new System.Drawing.Size(23, 26);
            this.label457.TabIndex = 63;
            this.label457.Text = "V";
            // 
            // stack4_box
            // 
            this.stack4_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.stack4_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stack4_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.stack4_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stack4_box.Location = new System.Drawing.Point(101, 172);
            this.stack4_box.Multiline = true;
            this.stack4_box.Name = "stack4_box";
            this.stack4_box.ReadOnly = true;
            this.stack4_box.Size = new System.Drawing.Size(75, 25);
            this.stack4_box.TabIndex = 64;
            this.stack4_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label458
            // 
            this.label458.AutoSize = true;
            this.label458.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label458.Location = new System.Drawing.Point(182, 171);
            this.label458.Name = "label458";
            this.label458.Size = new System.Drawing.Size(23, 26);
            this.label458.TabIndex = 65;
            this.label458.Text = "V";
            // 
            // label459
            // 
            this.label459.AutoSize = true;
            this.label459.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label459.Location = new System.Drawing.Point(182, 202);
            this.label459.Name = "label459";
            this.label459.Size = new System.Drawing.Size(23, 26);
            this.label459.TabIndex = 67;
            this.label459.Text = "V";
            // 
            // stack6_box
            // 
            this.stack6_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.stack6_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stack6_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.stack6_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stack6_box.Location = new System.Drawing.Point(101, 234);
            this.stack6_box.Multiline = true;
            this.stack6_box.Name = "stack6_box";
            this.stack6_box.ReadOnly = true;
            this.stack6_box.Size = new System.Drawing.Size(75, 25);
            this.stack6_box.TabIndex = 68;
            this.stack6_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label460
            // 
            this.label460.AutoSize = true;
            this.label460.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label460.Location = new System.Drawing.Point(182, 233);
            this.label460.Name = "label460";
            this.label460.Size = new System.Drawing.Size(23, 26);
            this.label460.TabIndex = 69;
            this.label460.Text = "V";
            // 
            // stack7_box
            // 
            this.stack7_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.stack7_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stack7_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.stack7_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stack7_box.Location = new System.Drawing.Point(101, 265);
            this.stack7_box.Multiline = true;
            this.stack7_box.Name = "stack7_box";
            this.stack7_box.ReadOnly = true;
            this.stack7_box.Size = new System.Drawing.Size(75, 25);
            this.stack7_box.TabIndex = 70;
            this.stack7_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label461
            // 
            this.label461.AutoSize = true;
            this.label461.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label461.Location = new System.Drawing.Point(182, 264);
            this.label461.Name = "label461";
            this.label461.Size = new System.Drawing.Size(23, 26);
            this.label461.TabIndex = 71;
            this.label461.Text = "V";
            // 
            // stack8_box
            // 
            this.stack8_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.stack8_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stack8_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.stack8_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stack8_box.Location = new System.Drawing.Point(101, 296);
            this.stack8_box.Multiline = true;
            this.stack8_box.Name = "stack8_box";
            this.stack8_box.ReadOnly = true;
            this.stack8_box.Size = new System.Drawing.Size(75, 25);
            this.stack8_box.TabIndex = 72;
            this.stack8_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label470
            // 
            this.label470.AutoSize = true;
            this.label470.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label470.Location = new System.Drawing.Point(12, 112);
            this.label470.Name = "label470";
            this.label470.Size = new System.Drawing.Size(82, 26);
            this.label470.TabIndex = 81;
            this.label470.Text = "Stack 2:";
            // 
            // label462
            // 
            this.label462.AutoSize = true;
            this.label462.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label462.Location = new System.Drawing.Point(182, 295);
            this.label462.Name = "label462";
            this.label462.Size = new System.Drawing.Size(23, 26);
            this.label462.TabIndex = 73;
            this.label462.Text = "V";
            // 
            // label469
            // 
            this.label469.AutoSize = true;
            this.label469.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label469.Location = new System.Drawing.Point(12, 298);
            this.label469.Name = "label469";
            this.label469.Size = new System.Drawing.Size(82, 26);
            this.label469.TabIndex = 80;
            this.label469.Text = "Stack 8:";
            // 
            // label463
            // 
            this.label463.AutoSize = true;
            this.label463.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label463.Location = new System.Drawing.Point(12, 81);
            this.label463.Name = "label463";
            this.label463.Size = new System.Drawing.Size(82, 26);
            this.label463.TabIndex = 74;
            this.label463.Text = "Stack 1:";
            // 
            // label468
            // 
            this.label468.AutoSize = true;
            this.label468.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label468.Location = new System.Drawing.Point(12, 267);
            this.label468.Name = "label468";
            this.label468.Size = new System.Drawing.Size(82, 26);
            this.label468.TabIndex = 79;
            this.label468.Text = "Stack 7:";
            // 
            // label464
            // 
            this.label464.AutoSize = true;
            this.label464.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label464.Location = new System.Drawing.Point(12, 143);
            this.label464.Name = "label464";
            this.label464.Size = new System.Drawing.Size(82, 26);
            this.label464.TabIndex = 75;
            this.label464.Text = "Stack 3:";
            // 
            // label467
            // 
            this.label467.AutoSize = true;
            this.label467.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label467.Location = new System.Drawing.Point(12, 236);
            this.label467.Name = "label467";
            this.label467.Size = new System.Drawing.Size(82, 26);
            this.label467.TabIndex = 78;
            this.label467.Text = "Stack 6:";
            // 
            // label465
            // 
            this.label465.AutoSize = true;
            this.label465.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label465.Location = new System.Drawing.Point(12, 174);
            this.label465.Name = "label465";
            this.label465.Size = new System.Drawing.Size(82, 26);
            this.label465.TabIndex = 76;
            this.label465.Text = "Stack 4:";
            // 
            // label466
            // 
            this.label466.AutoSize = true;
            this.label466.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label466.Location = new System.Drawing.Point(12, 205);
            this.label466.Name = "label466";
            this.label466.Size = new System.Drawing.Size(82, 26);
            this.label466.TabIndex = 77;
            this.label466.Text = "Stack 5:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.brake_system_status_box);
            this.groupBox2.Controls.Add(this.brake_pressure_box);
            this.groupBox2.Controls.Add(this.label496);
            this.groupBox2.Controls.Add(this.ebs_pressure_box);
            this.groupBox2.Controls.Add(this.label454);
            this.groupBox2.Controls.Add(this.sb_pressure_box);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Italic);
            this.groupBox2.Location = new System.Drawing.Point(238, 601);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 200);
            this.groupBox2.TabIndex = 215;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brake System";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label7.Location = new System.Drawing.Point(83, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 26);
            this.label7.TabIndex = 205;
            this.label7.Text = "EBS Supervisor Status:";
            // 
            // brake_system_status_box
            // 
            this.brake_system_status_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.brake_system_status_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brake_system_status_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.brake_system_status_box.Location = new System.Drawing.Point(8, 164);
            this.brake_system_status_box.Multiline = true;
            this.brake_system_status_box.Name = "brake_system_status_box";
            this.brake_system_status_box.ReadOnly = true;
            this.brake_system_status_box.Size = new System.Drawing.Size(321, 25);
            this.brake_system_status_box.TabIndex = 204;
            this.brake_system_status_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // brake_pressure_box
            // 
            this.brake_pressure_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.brake_pressure_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brake_pressure_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.brake_pressure_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.brake_pressure_box.Location = new System.Drawing.Point(167, 36);
            this.brake_pressure_box.Multiline = true;
            this.brake_pressure_box.Name = "brake_pressure_box";
            this.brake_pressure_box.ReadOnly = true;
            this.brake_pressure_box.Size = new System.Drawing.Size(75, 25);
            this.brake_pressure_box.TabIndex = 1;
            this.brake_pressure_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label496
            // 
            this.label496.AutoSize = true;
            this.label496.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label496.Location = new System.Drawing.Point(248, 35);
            this.label496.Name = "label496";
            this.label496.Size = new System.Drawing.Size(40, 26);
            this.label496.TabIndex = 203;
            this.label496.Text = "bar";
            // 
            // ebs_pressure_box
            // 
            this.ebs_pressure_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ebs_pressure_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ebs_pressure_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ebs_pressure_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ebs_pressure_box.Location = new System.Drawing.Point(167, 68);
            this.ebs_pressure_box.Multiline = true;
            this.ebs_pressure_box.Name = "ebs_pressure_box";
            this.ebs_pressure_box.ReadOnly = true;
            this.ebs_pressure_box.Size = new System.Drawing.Size(75, 25);
            this.ebs_pressure_box.TabIndex = 2;
            this.ebs_pressure_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label454
            // 
            this.label454.AutoSize = true;
            this.label454.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label454.Location = new System.Drawing.Point(248, 99);
            this.label454.Name = "label454";
            this.label454.Size = new System.Drawing.Size(40, 26);
            this.label454.TabIndex = 202;
            this.label454.Text = "bar";
            // 
            // sb_pressure_box
            // 
            this.sb_pressure_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sb_pressure_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sb_pressure_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.sb_pressure_box.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sb_pressure_box.Location = new System.Drawing.Point(167, 100);
            this.sb_pressure_box.Multiline = true;
            this.sb_pressure_box.Name = "sb_pressure_box";
            this.sb_pressure_box.ReadOnly = true;
            this.sb_pressure_box.Size = new System.Drawing.Size(75, 25);
            this.sb_pressure_box.TabIndex = 3;
            this.sb_pressure_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Brake pressure:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label2.Location = new System.Drawing.Point(33, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "EBS pressure:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label3.Location = new System.Drawing.Point(44, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "SB pressure:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("3ds Light", 12F);
            this.label4.Location = new System.Drawing.Point(248, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "bar";
            // 
            // ams_tabpage
            // 
            this.ams_tabpage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ams_tabpage.Controls.Add(this.clear_ams);
            this.ams_tabpage.Controls.Add(this.richTextBox_master);
            this.ams_tabpage.Controls.Add(this.richTextBox_slave1);
            this.ams_tabpage.Controls.Add(this.richTextBox_slave2);
            this.ams_tabpage.Controls.Add(this.richTextBox_slave3);
            this.ams_tabpage.Controls.Add(this.richTextBox_slave4);
            this.ams_tabpage.Controls.Add(this.richTextBox_slave5);
            this.ams_tabpage.Controls.Add(this.richTextBox_slave6);
            this.ams_tabpage.Controls.Add(this.richTextBox_slave7);
            this.ams_tabpage.Controls.Add(this.richTextBox_slave8);
            this.ams_tabpage.Controls.Add(this.flowLayoutPanel4);
            this.ams_tabpage.Location = new System.Drawing.Point(4, 39);
            this.ams_tabpage.Name = "ams_tabpage";
            this.ams_tabpage.Size = new System.Drawing.Size(1442, 910);
            this.ams_tabpage.TabIndex = 11;
            this.ams_tabpage.Text = "AMS";
            // 
            // clear_ams
            // 
            this.clear_ams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.clear_ams.Location = new System.Drawing.Point(289, 9);
            this.clear_ams.Name = "clear_ams";
            this.clear_ams.Size = new System.Drawing.Size(150, 60);
            this.clear_ams.TabIndex = 253;
            this.clear_ams.Text = "Clear";
            this.clear_ams.UseVisualStyleBackColor = false;
            this.clear_ams.Click += new System.EventHandler(this.clear_ams_Click);
            // 
            // richTextBox_master
            // 
            this.richTextBox_master.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox_master.Font = new System.Drawing.Font("Adobe Heiti Std R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox_master.Location = new System.Drawing.Point(3, 3);
            this.richTextBox_master.Name = "richTextBox_master";
            this.richTextBox_master.Size = new System.Drawing.Size(280, 250);
            this.richTextBox_master.TabIndex = 250;
            this.richTextBox_master.Text = "";
            // 
            // richTextBox_slave1
            // 
            this.richTextBox_slave1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox_slave1.Font = new System.Drawing.Font("Adobe Heiti Std R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox_slave1.Location = new System.Drawing.Point(3, 254);
            this.richTextBox_slave1.Name = "richTextBox_slave1";
            this.richTextBox_slave1.Size = new System.Drawing.Size(280, 325);
            this.richTextBox_slave1.TabIndex = 242;
            this.richTextBox_slave1.Text = "";
            // 
            // richTextBox_slave2
            // 
            this.richTextBox_slave2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox_slave2.Font = new System.Drawing.Font("Adobe Heiti Std R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox_slave2.Location = new System.Drawing.Point(289, 254);
            this.richTextBox_slave2.Name = "richTextBox_slave2";
            this.richTextBox_slave2.Size = new System.Drawing.Size(280, 325);
            this.richTextBox_slave2.TabIndex = 245;
            this.richTextBox_slave2.Text = "";
            // 
            // richTextBox_slave3
            // 
            this.richTextBox_slave3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox_slave3.Font = new System.Drawing.Font("Adobe Heiti Std R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox_slave3.Location = new System.Drawing.Point(575, 254);
            this.richTextBox_slave3.Name = "richTextBox_slave3";
            this.richTextBox_slave3.Size = new System.Drawing.Size(280, 325);
            this.richTextBox_slave3.TabIndex = 243;
            this.richTextBox_slave3.Text = "";
            // 
            // richTextBox_slave4
            // 
            this.richTextBox_slave4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox_slave4.Font = new System.Drawing.Font("Adobe Heiti Std R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox_slave4.Location = new System.Drawing.Point(861, 254);
            this.richTextBox_slave4.Name = "richTextBox_slave4";
            this.richTextBox_slave4.Size = new System.Drawing.Size(280, 325);
            this.richTextBox_slave4.TabIndex = 244;
            this.richTextBox_slave4.Text = "";
            // 
            // richTextBox_slave5
            // 
            this.richTextBox_slave5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox_slave5.Font = new System.Drawing.Font("Adobe Heiti Std R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox_slave5.Location = new System.Drawing.Point(3, 582);
            this.richTextBox_slave5.Name = "richTextBox_slave5";
            this.richTextBox_slave5.Size = new System.Drawing.Size(280, 325);
            this.richTextBox_slave5.TabIndex = 247;
            this.richTextBox_slave5.Text = "";
            // 
            // richTextBox_slave6
            // 
            this.richTextBox_slave6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox_slave6.Font = new System.Drawing.Font("Adobe Heiti Std R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox_slave6.Location = new System.Drawing.Point(289, 582);
            this.richTextBox_slave6.Name = "richTextBox_slave6";
            this.richTextBox_slave6.Size = new System.Drawing.Size(280, 325);
            this.richTextBox_slave6.TabIndex = 248;
            this.richTextBox_slave6.Text = "";
            // 
            // richTextBox_slave7
            // 
            this.richTextBox_slave7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox_slave7.Font = new System.Drawing.Font("Adobe Heiti Std R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox_slave7.Location = new System.Drawing.Point(575, 582);
            this.richTextBox_slave7.Name = "richTextBox_slave7";
            this.richTextBox_slave7.Size = new System.Drawing.Size(280, 325);
            this.richTextBox_slave7.TabIndex = 249;
            this.richTextBox_slave7.Text = "";
            // 
            // richTextBox_slave8
            // 
            this.richTextBox_slave8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox_slave8.Font = new System.Drawing.Font("Adobe Heiti Std R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox_slave8.Location = new System.Drawing.Point(861, 582);
            this.richTextBox_slave8.Name = "richTextBox_slave8";
            this.richTextBox_slave8.Size = new System.Drawing.Size(280, 325);
            this.richTextBox_slave8.TabIndex = 246;
            this.richTextBox_slave8.Text = "";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.MaximumSize = new System.Drawing.Size(1200, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1200, 0);
            this.flowLayoutPanel4.TabIndex = 0;
            this.flowLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel4_Paint);
            // 
            // stack1
            // 
            this.stack1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.stack1.Controls.Add(this.stack_1u);
            this.stack1.Controls.Add(this.clear_1);
            this.stack1.Controls.Add(this.label61);
            this.stack1.Controls.Add(this.label62);
            this.stack1.Controls.Add(this.label59);
            this.stack1.Controls.Add(this.label60);
            this.stack1.Controls.Add(this.label57);
            this.stack1.Controls.Add(this.label58);
            this.stack1.Controls.Add(this.label55);
            this.stack1.Controls.Add(this.label56);
            this.stack1.Controls.Add(this.label53);
            this.stack1.Controls.Add(this.label54);
            this.stack1.Controls.Add(this.label51);
            this.stack1.Controls.Add(this.label52);
            this.stack1.Controls.Add(this.label49);
            this.stack1.Controls.Add(this.label50);
            this.stack1.Controls.Add(this.label47);
            this.stack1.Controls.Add(this.label48);
            this.stack1.Controls.Add(this.label45);
            this.stack1.Controls.Add(this.label46);
            this.stack1.Controls.Add(this.label43);
            this.stack1.Controls.Add(this.label44);
            this.stack1.Controls.Add(this.label41);
            this.stack1.Controls.Add(this.label42);
            this.stack1.Controls.Add(this.label39);
            this.stack1.Controls.Add(this.label40);
            this.stack1.Controls.Add(this.label37);
            this.stack1.Controls.Add(this.label38);
            this.stack1.Controls.Add(this.label35);
            this.stack1.Controls.Add(this.label36);
            this.stack1.Controls.Add(this.label33);
            this.stack1.Controls.Add(this.label34);
            this.stack1.Controls.Add(this.label31);
            this.stack1.Controls.Add(this.label32);
            this.stack1.Controls.Add(this.label29);
            this.stack1.Controls.Add(this.label30);
            this.stack1.Controls.Add(this.label28);
            this.stack1.Controls.Add(this.label27);
            this.stack1.Controls.Add(this.label26);
            this.stack1.Controls.Add(this.label20);
            this.stack1.Controls.Add(this.textBox_34);
            this.stack1.Controls.Add(this.textBox_33);
            this.stack1.Controls.Add(this.label21);
            this.stack1.Controls.Add(this.textBox_36);
            this.stack1.Controls.Add(this.textBox_35);
            this.stack1.Controls.Add(this.label22);
            this.stack1.Controls.Add(this.textBox_30);
            this.stack1.Controls.Add(this.textBox_29);
            this.stack1.Controls.Add(this.label23);
            this.stack1.Controls.Add(this.textBox_28);
            this.stack1.Controls.Add(this.textBox_27);
            this.stack1.Controls.Add(this.label24);
            this.stack1.Controls.Add(this.textBox_26);
            this.stack1.Controls.Add(this.textBox_25);
            this.stack1.Controls.Add(this.label25);
            this.stack1.Controls.Add(this.textBox_32);
            this.stack1.Controls.Add(this.textBox_31);
            this.stack1.Controls.Add(this.label14);
            this.stack1.Controls.Add(this.textBox_22);
            this.stack1.Controls.Add(this.textBox_21);
            this.stack1.Controls.Add(this.label15);
            this.stack1.Controls.Add(this.textBox_24);
            this.stack1.Controls.Add(this.textBox_23);
            this.stack1.Controls.Add(this.label16);
            this.stack1.Controls.Add(this.textBox_18);
            this.stack1.Controls.Add(this.textBox_17);
            this.stack1.Controls.Add(this.label17);
            this.stack1.Controls.Add(this.textBox_16);
            this.stack1.Controls.Add(this.textBox_15);
            this.stack1.Controls.Add(this.label18);
            this.stack1.Controls.Add(this.textBox_14);
            this.stack1.Controls.Add(this.textBox_13);
            this.stack1.Controls.Add(this.label19);
            this.stack1.Controls.Add(this.textBox_20);
            this.stack1.Controls.Add(this.textBox_19);
            this.stack1.Controls.Add(this.label12);
            this.stack1.Controls.Add(this.textBox_10);
            this.stack1.Controls.Add(this.textBox_9);
            this.stack1.Controls.Add(this.label13);
            this.stack1.Controls.Add(this.textBox_12);
            this.stack1.Controls.Add(this.textBox_11);
            this.stack1.Controls.Add(this.label10);
            this.stack1.Controls.Add(this.textBox_6);
            this.stack1.Controls.Add(this.textBox_5);
            this.stack1.Controls.Add(this.label11);
            this.stack1.Controls.Add(this.textBox_4);
            this.stack1.Controls.Add(this.textBox_3);
            this.stack1.Controls.Add(this.stack1_2);
            this.stack1.Controls.Add(this.textBox_2);
            this.stack1.Controls.Add(this.textBox_1);
            this.stack1.Controls.Add(this.stack1_1);
            this.stack1.Controls.Add(this.textBox_8);
            this.stack1.Controls.Add(this.textBox_7);
            this.stack1.Location = new System.Drawing.Point(4, 39);
            this.stack1.Name = "stack1";
            this.stack1.Size = new System.Drawing.Size(1442, 910);
            this.stack1.TabIndex = 3;
            this.stack1.Text = "Stack 1";
            // 
            // stack_1u
            // 
            this.stack_1u.AutoSize = true;
            this.stack_1u.Font = new System.Drawing.Font("3ds Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stack_1u.Location = new System.Drawing.Point(460, 52);
            this.stack_1u.Name = "stack_1u";
            this.stack_1u.Size = new System.Drawing.Size(204, 36);
            this.stack_1u.TabIndex = 186;
            this.stack_1u.Text = "Stack voltage: -";
            // 
            // clear_1
            // 
            this.clear_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.clear_1.Location = new System.Drawing.Point(15, 52);
            this.clear_1.Name = "clear_1";
            this.clear_1.Size = new System.Drawing.Size(150, 60);
            this.clear_1.TabIndex = 185;
            this.clear_1.Text = "Clear";
            this.clear_1.UseVisualStyleBackColor = false;
            this.clear_1.Click += new System.EventHandler(this.clear_1_Click_1);
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(982, 687);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(35, 30);
            this.label61.TabIndex = 92;
            this.label61.Text = "°C";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(989, 659);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(26, 30);
            this.label62.TabIndex = 91;
            this.label62.Text = "V";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(982, 587);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(35, 30);
            this.label59.TabIndex = 90;
            this.label59.Text = "°C";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(989, 559);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(26, 30);
            this.label60.TabIndex = 89;
            this.label60.Text = "V";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(982, 487);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(35, 30);
            this.label57.TabIndex = 88;
            this.label57.Text = "°C";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(989, 459);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(26, 30);
            this.label58.TabIndex = 87;
            this.label58.Text = "V";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(982, 387);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(35, 30);
            this.label55.TabIndex = 86;
            this.label55.Text = "°C";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(989, 359);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(26, 30);
            this.label56.TabIndex = 85;
            this.label56.Text = "V";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(982, 287);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(35, 30);
            this.label53.TabIndex = 84;
            this.label53.Text = "°C";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(989, 259);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(26, 30);
            this.label54.TabIndex = 83;
            this.label54.Text = "V";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(982, 191);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(35, 30);
            this.label51.TabIndex = 82;
            this.label51.Text = "°C";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(989, 163);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(26, 30);
            this.label52.TabIndex = 81;
            this.label52.Text = "V";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(632, 687);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(35, 30);
            this.label49.TabIndex = 80;
            this.label49.Text = "°C";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(639, 659);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(26, 30);
            this.label50.TabIndex = 79;
            this.label50.Text = "V";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(632, 587);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(35, 30);
            this.label47.TabIndex = 78;
            this.label47.Text = "°C";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(639, 559);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(26, 30);
            this.label48.TabIndex = 77;
            this.label48.Text = "V";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(632, 487);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(35, 30);
            this.label45.TabIndex = 76;
            this.label45.Text = "°C";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(639, 459);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(26, 30);
            this.label46.TabIndex = 75;
            this.label46.Text = "V";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(632, 387);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(35, 30);
            this.label43.TabIndex = 74;
            this.label43.Text = "°C";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(639, 359);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(26, 30);
            this.label44.TabIndex = 73;
            this.label44.Text = "V";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(632, 287);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(35, 30);
            this.label41.TabIndex = 72;
            this.label41.Text = "°C";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(639, 259);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(26, 30);
            this.label42.TabIndex = 71;
            this.label42.Text = "V";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(632, 187);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(35, 30);
            this.label39.TabIndex = 70;
            this.label39.Text = "°C";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(639, 159);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(26, 30);
            this.label40.TabIndex = 69;
            this.label40.Text = "V";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(282, 687);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(35, 30);
            this.label37.TabIndex = 68;
            this.label37.Text = "°C";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(289, 659);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(26, 30);
            this.label38.TabIndex = 67;
            this.label38.Text = "V";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(282, 587);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(35, 30);
            this.label35.TabIndex = 66;
            this.label35.Text = "°C";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(289, 559);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(26, 30);
            this.label36.TabIndex = 65;
            this.label36.Text = "V";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(282, 487);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(35, 30);
            this.label33.TabIndex = 64;
            this.label33.Text = "°C";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(289, 459);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(26, 30);
            this.label34.TabIndex = 63;
            this.label34.Text = "V";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(282, 387);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(35, 30);
            this.label31.TabIndex = 62;
            this.label31.Text = "°C";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(289, 359);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(26, 30);
            this.label32.TabIndex = 61;
            this.label32.Text = "V";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(282, 287);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(35, 30);
            this.label29.TabIndex = 60;
            this.label29.Text = "°C";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(289, 259);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(26, 30);
            this.label30.TabIndex = 59;
            this.label30.Text = "V";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(282, 187);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(35, 30);
            this.label28.TabIndex = 58;
            this.label28.Text = "°C";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(289, 159);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(26, 30);
            this.label27.TabIndex = 57;
            this.label27.Text = "V";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label26.Location = new System.Drawing.Point(10, 20);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(86, 29);
            this.label26.TabIndex = 56;
            this.label26.Text = "Stack 1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(798, 575);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 30);
            this.label20.TabIndex = 55;
            this.label20.Text = "Cell 17";
            // 
            // textBox_34
            // 
            this.textBox_34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_34.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_34.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_34.Location = new System.Drawing.Point(901, 592);
            this.textBox_34.Multiline = true;
            this.textBox_34.Name = "textBox_34";
            this.textBox_34.ReadOnly = true;
            this.textBox_34.Size = new System.Drawing.Size(75, 25);
            this.textBox_34.TabIndex = 54;
            this.textBox_34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_33
            // 
            this.textBox_33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_33.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_33.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_33.Location = new System.Drawing.Point(901, 561);
            this.textBox_33.Multiline = true;
            this.textBox_33.Name = "textBox_33";
            this.textBox_33.ReadOnly = true;
            this.textBox_33.Size = new System.Drawing.Size(75, 25);
            this.textBox_33.TabIndex = 53;
            this.textBox_33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(798, 671);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 30);
            this.label21.TabIndex = 52;
            this.label21.Text = "Cell 18";
            // 
            // textBox_36
            // 
            this.textBox_36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_36.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_36.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_36.Location = new System.Drawing.Point(901, 692);
            this.textBox_36.Multiline = true;
            this.textBox_36.Name = "textBox_36";
            this.textBox_36.ReadOnly = true;
            this.textBox_36.Size = new System.Drawing.Size(75, 25);
            this.textBox_36.TabIndex = 51;
            this.textBox_36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_35
            // 
            this.textBox_35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_35.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_35.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_35.Location = new System.Drawing.Point(901, 661);
            this.textBox_35.Multiline = true;
            this.textBox_35.Name = "textBox_35";
            this.textBox_35.ReadOnly = true;
            this.textBox_35.Size = new System.Drawing.Size(75, 25);
            this.textBox_35.TabIndex = 50;
            this.textBox_35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(798, 375);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 30);
            this.label22.TabIndex = 49;
            this.label22.Text = "Cell 15";
            // 
            // textBox_30
            // 
            this.textBox_30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_30.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_30.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_30.Location = new System.Drawing.Point(901, 392);
            this.textBox_30.Multiline = true;
            this.textBox_30.Name = "textBox_30";
            this.textBox_30.ReadOnly = true;
            this.textBox_30.Size = new System.Drawing.Size(75, 25);
            this.textBox_30.TabIndex = 48;
            this.textBox_30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_29
            // 
            this.textBox_29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_29.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_29.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_29.Location = new System.Drawing.Point(901, 361);
            this.textBox_29.Multiline = true;
            this.textBox_29.Name = "textBox_29";
            this.textBox_29.ReadOnly = true;
            this.textBox_29.Size = new System.Drawing.Size(75, 25);
            this.textBox_29.TabIndex = 47;
            this.textBox_29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(798, 275);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(84, 30);
            this.label23.TabIndex = 46;
            this.label23.Text = "Cell 14";
            // 
            // textBox_28
            // 
            this.textBox_28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_28.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_28.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_28.Location = new System.Drawing.Point(901, 292);
            this.textBox_28.Multiline = true;
            this.textBox_28.Name = "textBox_28";
            this.textBox_28.ReadOnly = true;
            this.textBox_28.Size = new System.Drawing.Size(75, 25);
            this.textBox_28.TabIndex = 45;
            this.textBox_28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_27
            // 
            this.textBox_27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_27.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_27.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_27.Location = new System.Drawing.Point(901, 261);
            this.textBox_27.Multiline = true;
            this.textBox_27.Name = "textBox_27";
            this.textBox_27.ReadOnly = true;
            this.textBox_27.Size = new System.Drawing.Size(75, 25);
            this.textBox_27.TabIndex = 44;
            this.textBox_27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(798, 174);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(84, 30);
            this.label24.TabIndex = 43;
            this.label24.Text = "Cell 13";
            // 
            // textBox_26
            // 
            this.textBox_26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_26.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_26.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_26.Location = new System.Drawing.Point(901, 192);
            this.textBox_26.Multiline = true;
            this.textBox_26.Name = "textBox_26";
            this.textBox_26.ReadOnly = true;
            this.textBox_26.Size = new System.Drawing.Size(75, 25);
            this.textBox_26.TabIndex = 42;
            this.textBox_26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_25
            // 
            this.textBox_25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_25.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_25.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_25.Location = new System.Drawing.Point(901, 161);
            this.textBox_25.Multiline = true;
            this.textBox_25.Name = "textBox_25";
            this.textBox_25.ReadOnly = true;
            this.textBox_25.Size = new System.Drawing.Size(75, 25);
            this.textBox_25.TabIndex = 41;
            this.textBox_25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(798, 474);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 30);
            this.label25.TabIndex = 40;
            this.label25.Text = "Cell 16";
            // 
            // textBox_32
            // 
            this.textBox_32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_32.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_32.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_32.Location = new System.Drawing.Point(901, 492);
            this.textBox_32.Multiline = true;
            this.textBox_32.Name = "textBox_32";
            this.textBox_32.ReadOnly = true;
            this.textBox_32.Size = new System.Drawing.Size(75, 25);
            this.textBox_32.TabIndex = 39;
            this.textBox_32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_31
            // 
            this.textBox_31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_31.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_31.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_31.Location = new System.Drawing.Point(901, 461);
            this.textBox_31.Multiline = true;
            this.textBox_31.Name = "textBox_31";
            this.textBox_31.ReadOnly = true;
            this.textBox_31.Size = new System.Drawing.Size(75, 25);
            this.textBox_31.TabIndex = 38;
            this.textBox_31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(461, 575);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 30);
            this.label14.TabIndex = 37;
            this.label14.Text = "Cell 11";
            // 
            // textBox_22
            // 
            this.textBox_22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_22.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_22.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_22.Location = new System.Drawing.Point(551, 592);
            this.textBox_22.Multiline = true;
            this.textBox_22.Name = "textBox_22";
            this.textBox_22.ReadOnly = true;
            this.textBox_22.Size = new System.Drawing.Size(75, 25);
            this.textBox_22.TabIndex = 36;
            this.textBox_22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_21
            // 
            this.textBox_21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_21.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_21.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_21.Location = new System.Drawing.Point(551, 561);
            this.textBox_21.Multiline = true;
            this.textBox_21.Name = "textBox_21";
            this.textBox_21.ReadOnly = true;
            this.textBox_21.Size = new System.Drawing.Size(75, 25);
            this.textBox_21.TabIndex = 35;
            this.textBox_21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(461, 671);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 30);
            this.label15.TabIndex = 34;
            this.label15.Text = "Cell 12";
            // 
            // textBox_24
            // 
            this.textBox_24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_24.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_24.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_24.Location = new System.Drawing.Point(551, 692);
            this.textBox_24.Multiline = true;
            this.textBox_24.Name = "textBox_24";
            this.textBox_24.ReadOnly = true;
            this.textBox_24.Size = new System.Drawing.Size(75, 25);
            this.textBox_24.TabIndex = 33;
            this.textBox_24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_23
            // 
            this.textBox_23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_23.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_23.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_23.Location = new System.Drawing.Point(551, 661);
            this.textBox_23.Multiline = true;
            this.textBox_23.Name = "textBox_23";
            this.textBox_23.ReadOnly = true;
            this.textBox_23.Size = new System.Drawing.Size(75, 25);
            this.textBox_23.TabIndex = 32;
            this.textBox_23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(461, 375);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 30);
            this.label16.TabIndex = 31;
            this.label16.Text = "Cell 9";
            // 
            // textBox_18
            // 
            this.textBox_18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_18.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_18.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_18.Location = new System.Drawing.Point(551, 392);
            this.textBox_18.Multiline = true;
            this.textBox_18.Name = "textBox_18";
            this.textBox_18.ReadOnly = true;
            this.textBox_18.Size = new System.Drawing.Size(75, 25);
            this.textBox_18.TabIndex = 30;
            this.textBox_18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_17
            // 
            this.textBox_17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_17.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_17.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_17.Location = new System.Drawing.Point(551, 361);
            this.textBox_17.Multiline = true;
            this.textBox_17.Name = "textBox_17";
            this.textBox_17.ReadOnly = true;
            this.textBox_17.Size = new System.Drawing.Size(75, 25);
            this.textBox_17.TabIndex = 29;
            this.textBox_17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(461, 275);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 30);
            this.label17.TabIndex = 28;
            this.label17.Text = "Cell 8";
            // 
            // textBox_16
            // 
            this.textBox_16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_16.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_16.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_16.Location = new System.Drawing.Point(551, 292);
            this.textBox_16.Multiline = true;
            this.textBox_16.Name = "textBox_16";
            this.textBox_16.ReadOnly = true;
            this.textBox_16.Size = new System.Drawing.Size(75, 25);
            this.textBox_16.TabIndex = 27;
            this.textBox_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_15
            // 
            this.textBox_15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_15.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_15.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_15.Location = new System.Drawing.Point(551, 261);
            this.textBox_15.Multiline = true;
            this.textBox_15.Name = "textBox_15";
            this.textBox_15.ReadOnly = true;
            this.textBox_15.Size = new System.Drawing.Size(75, 25);
            this.textBox_15.TabIndex = 26;
            this.textBox_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(461, 174);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 30);
            this.label18.TabIndex = 25;
            this.label18.Text = "Cell 7";
            // 
            // textBox_14
            // 
            this.textBox_14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_14.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_14.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_14.Location = new System.Drawing.Point(551, 192);
            this.textBox_14.Multiline = true;
            this.textBox_14.Name = "textBox_14";
            this.textBox_14.ReadOnly = true;
            this.textBox_14.Size = new System.Drawing.Size(75, 25);
            this.textBox_14.TabIndex = 24;
            this.textBox_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_13
            // 
            this.textBox_13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_13.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_13.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_13.Location = new System.Drawing.Point(551, 161);
            this.textBox_13.Multiline = true;
            this.textBox_13.Name = "textBox_13";
            this.textBox_13.ReadOnly = true;
            this.textBox_13.Size = new System.Drawing.Size(75, 25);
            this.textBox_13.TabIndex = 23;
            this.textBox_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(461, 474);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 30);
            this.label19.TabIndex = 22;
            this.label19.Text = "Cell 10";
            // 
            // textBox_20
            // 
            this.textBox_20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_20.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_20.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_20.Location = new System.Drawing.Point(551, 492);
            this.textBox_20.Multiline = true;
            this.textBox_20.Name = "textBox_20";
            this.textBox_20.ReadOnly = true;
            this.textBox_20.Size = new System.Drawing.Size(75, 25);
            this.textBox_20.TabIndex = 21;
            this.textBox_20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_19
            // 
            this.textBox_19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_19.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_19.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_19.Location = new System.Drawing.Point(551, 461);
            this.textBox_19.Multiline = true;
            this.textBox_19.Name = "textBox_19";
            this.textBox_19.ReadOnly = true;
            this.textBox_19.Size = new System.Drawing.Size(75, 25);
            this.textBox_19.TabIndex = 20;
            this.textBox_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(125, 575);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 30);
            this.label12.TabIndex = 19;
            this.label12.Text = "Cell 5";
            // 
            // textBox_10
            // 
            this.textBox_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_10.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_10.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_10.Location = new System.Drawing.Point(201, 592);
            this.textBox_10.Multiline = true;
            this.textBox_10.Name = "textBox_10";
            this.textBox_10.ReadOnly = true;
            this.textBox_10.Size = new System.Drawing.Size(75, 25);
            this.textBox_10.TabIndex = 18;
            this.textBox_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_9
            // 
            this.textBox_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_9.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_9.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_9.Location = new System.Drawing.Point(201, 561);
            this.textBox_9.Multiline = true;
            this.textBox_9.Name = "textBox_9";
            this.textBox_9.ReadOnly = true;
            this.textBox_9.Size = new System.Drawing.Size(75, 25);
            this.textBox_9.TabIndex = 17;
            this.textBox_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(125, 671);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 30);
            this.label13.TabIndex = 16;
            this.label13.Text = "Cell 6";
            // 
            // textBox_12
            // 
            this.textBox_12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_12.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_12.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_12.Location = new System.Drawing.Point(201, 692);
            this.textBox_12.Multiline = true;
            this.textBox_12.Name = "textBox_12";
            this.textBox_12.ReadOnly = true;
            this.textBox_12.Size = new System.Drawing.Size(75, 25);
            this.textBox_12.TabIndex = 15;
            this.textBox_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_11
            // 
            this.textBox_11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_11.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_11.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_11.Location = new System.Drawing.Point(201, 661);
            this.textBox_11.Multiline = true;
            this.textBox_11.Name = "textBox_11";
            this.textBox_11.ReadOnly = true;
            this.textBox_11.Size = new System.Drawing.Size(75, 25);
            this.textBox_11.TabIndex = 14;
            this.textBox_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(125, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 30);
            this.label10.TabIndex = 13;
            this.label10.Text = "Cell 3";
            // 
            // textBox_6
            // 
            this.textBox_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_6.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_6.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_6.Location = new System.Drawing.Point(201, 392);
            this.textBox_6.Multiline = true;
            this.textBox_6.Name = "textBox_6";
            this.textBox_6.ReadOnly = true;
            this.textBox_6.Size = new System.Drawing.Size(75, 25);
            this.textBox_6.TabIndex = 12;
            this.textBox_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_5
            // 
            this.textBox_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_5.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_5.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_5.Location = new System.Drawing.Point(201, 361);
            this.textBox_5.Multiline = true;
            this.textBox_5.Name = "textBox_5";
            this.textBox_5.ReadOnly = true;
            this.textBox_5.Size = new System.Drawing.Size(75, 25);
            this.textBox_5.TabIndex = 11;
            this.textBox_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(125, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 30);
            this.label11.TabIndex = 10;
            this.label11.Text = "Cell 2";
            // 
            // textBox_4
            // 
            this.textBox_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_4.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_4.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_4.Location = new System.Drawing.Point(201, 292);
            this.textBox_4.Multiline = true;
            this.textBox_4.Name = "textBox_4";
            this.textBox_4.ReadOnly = true;
            this.textBox_4.Size = new System.Drawing.Size(75, 25);
            this.textBox_4.TabIndex = 9;
            this.textBox_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_3
            // 
            this.textBox_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_3.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_3.Location = new System.Drawing.Point(201, 261);
            this.textBox_3.Multiline = true;
            this.textBox_3.Name = "textBox_3";
            this.textBox_3.ReadOnly = true;
            this.textBox_3.Size = new System.Drawing.Size(75, 25);
            this.textBox_3.TabIndex = 8;
            this.textBox_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stack1_2
            // 
            this.stack1_2.AutoSize = true;
            this.stack1_2.Location = new System.Drawing.Point(125, 174);
            this.stack1_2.Name = "stack1_2";
            this.stack1_2.Size = new System.Drawing.Size(70, 30);
            this.stack1_2.TabIndex = 7;
            this.stack1_2.Text = "Cell 1";
            // 
            // textBox_2
            // 
            this.textBox_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_2.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_2.Location = new System.Drawing.Point(201, 192);
            this.textBox_2.Multiline = true;
            this.textBox_2.Name = "textBox_2";
            this.textBox_2.ReadOnly = true;
            this.textBox_2.Size = new System.Drawing.Size(75, 25);
            this.textBox_2.TabIndex = 6;
            this.textBox_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_1
            // 
            this.textBox_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_1.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_1.Location = new System.Drawing.Point(201, 161);
            this.textBox_1.Multiline = true;
            this.textBox_1.Name = "textBox_1";
            this.textBox_1.ReadOnly = true;
            this.textBox_1.Size = new System.Drawing.Size(75, 25);
            this.textBox_1.TabIndex = 5;
            this.textBox_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stack1_1
            // 
            this.stack1_1.AutoSize = true;
            this.stack1_1.Location = new System.Drawing.Point(125, 474);
            this.stack1_1.Name = "stack1_1";
            this.stack1_1.Size = new System.Drawing.Size(70, 30);
            this.stack1_1.TabIndex = 4;
            this.stack1_1.Text = "Cell 4";
            // 
            // textBox_8
            // 
            this.textBox_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_8.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_8.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_8.Location = new System.Drawing.Point(201, 492);
            this.textBox_8.Multiline = true;
            this.textBox_8.Name = "textBox_8";
            this.textBox_8.ReadOnly = true;
            this.textBox_8.Size = new System.Drawing.Size(75, 25);
            this.textBox_8.TabIndex = 3;
            this.textBox_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_7
            // 
            this.textBox_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_7.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_7.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_7.Location = new System.Drawing.Point(201, 461);
            this.textBox_7.Multiline = true;
            this.textBox_7.Name = "textBox_7";
            this.textBox_7.ReadOnly = true;
            this.textBox_7.Size = new System.Drawing.Size(75, 25);
            this.textBox_7.TabIndex = 2;
            this.textBox_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stack2
            // 
            this.stack2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.stack2.Controls.Add(this.stack_2u);
            this.stack2.Controls.Add(this.clear_2);
            this.stack2.Controls.Add(this.label441);
            this.stack2.Controls.Add(this.label63);
            this.stack2.Controls.Add(this.label64);
            this.stack2.Controls.Add(this.label65);
            this.stack2.Controls.Add(this.label66);
            this.stack2.Controls.Add(this.label67);
            this.stack2.Controls.Add(this.label68);
            this.stack2.Controls.Add(this.label69);
            this.stack2.Controls.Add(this.label70);
            this.stack2.Controls.Add(this.label71);
            this.stack2.Controls.Add(this.label72);
            this.stack2.Controls.Add(this.label73);
            this.stack2.Controls.Add(this.label74);
            this.stack2.Controls.Add(this.label75);
            this.stack2.Controls.Add(this.label76);
            this.stack2.Controls.Add(this.label77);
            this.stack2.Controls.Add(this.label78);
            this.stack2.Controls.Add(this.label79);
            this.stack2.Controls.Add(this.label80);
            this.stack2.Controls.Add(this.label81);
            this.stack2.Controls.Add(this.label82);
            this.stack2.Controls.Add(this.label83);
            this.stack2.Controls.Add(this.label84);
            this.stack2.Controls.Add(this.label85);
            this.stack2.Controls.Add(this.label86);
            this.stack2.Controls.Add(this.label87);
            this.stack2.Controls.Add(this.label88);
            this.stack2.Controls.Add(this.label89);
            this.stack2.Controls.Add(this.label90);
            this.stack2.Controls.Add(this.label91);
            this.stack2.Controls.Add(this.label92);
            this.stack2.Controls.Add(this.label93);
            this.stack2.Controls.Add(this.label94);
            this.stack2.Controls.Add(this.label95);
            this.stack2.Controls.Add(this.label96);
            this.stack2.Controls.Add(this.label97);
            this.stack2.Controls.Add(this.label98);
            this.stack2.Controls.Add(this.label99);
            this.stack2.Controls.Add(this.textBox_70);
            this.stack2.Controls.Add(this.textBox_69);
            this.stack2.Controls.Add(this.label100);
            this.stack2.Controls.Add(this.textBox_72);
            this.stack2.Controls.Add(this.textBox_71);
            this.stack2.Controls.Add(this.label101);
            this.stack2.Controls.Add(this.textBox_66);
            this.stack2.Controls.Add(this.textBox_65);
            this.stack2.Controls.Add(this.label102);
            this.stack2.Controls.Add(this.textBox_64);
            this.stack2.Controls.Add(this.textBox_63);
            this.stack2.Controls.Add(this.label103);
            this.stack2.Controls.Add(this.textBox_62);
            this.stack2.Controls.Add(this.textBox_61);
            this.stack2.Controls.Add(this.label104);
            this.stack2.Controls.Add(this.textBox_68);
            this.stack2.Controls.Add(this.textBox_67);
            this.stack2.Controls.Add(this.label105);
            this.stack2.Controls.Add(this.textBox_58);
            this.stack2.Controls.Add(this.textBox_57);
            this.stack2.Controls.Add(this.label106);
            this.stack2.Controls.Add(this.textBox_60);
            this.stack2.Controls.Add(this.textBox_59);
            this.stack2.Controls.Add(this.label107);
            this.stack2.Controls.Add(this.textBox_54);
            this.stack2.Controls.Add(this.textBox_53);
            this.stack2.Controls.Add(this.label108);
            this.stack2.Controls.Add(this.textBox_52);
            this.stack2.Controls.Add(this.textBox_51);
            this.stack2.Controls.Add(this.label109);
            this.stack2.Controls.Add(this.textBox_50);
            this.stack2.Controls.Add(this.textBox_49);
            this.stack2.Controls.Add(this.label110);
            this.stack2.Controls.Add(this.textBox_56);
            this.stack2.Controls.Add(this.textBox_55);
            this.stack2.Controls.Add(this.label111);
            this.stack2.Controls.Add(this.textBox_46);
            this.stack2.Controls.Add(this.textBox_45);
            this.stack2.Controls.Add(this.label112);
            this.stack2.Controls.Add(this.textBox_48);
            this.stack2.Controls.Add(this.textBox_47);
            this.stack2.Controls.Add(this.label113);
            this.stack2.Controls.Add(this.textBox_42);
            this.stack2.Controls.Add(this.textBox_41);
            this.stack2.Controls.Add(this.label114);
            this.stack2.Controls.Add(this.textBox_40);
            this.stack2.Controls.Add(this.textBox_39);
            this.stack2.Controls.Add(this.label115);
            this.stack2.Controls.Add(this.textBox_38);
            this.stack2.Controls.Add(this.textBox_37);
            this.stack2.Controls.Add(this.label116);
            this.stack2.Controls.Add(this.textBox_44);
            this.stack2.Controls.Add(this.textBox_43);
            this.stack2.Location = new System.Drawing.Point(4, 39);
            this.stack2.Name = "stack2";
            this.stack2.Size = new System.Drawing.Size(1442, 910);
            this.stack2.TabIndex = 4;
            this.stack2.Text = "Stack 2";
            // 
            // stack_2u
            // 
            this.stack_2u.AutoSize = true;
            this.stack_2u.Font = new System.Drawing.Font("3ds Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stack_2u.Location = new System.Drawing.Point(460, 52);
            this.stack_2u.Name = "stack_2u";
            this.stack_2u.Size = new System.Drawing.Size(204, 36);
            this.stack_2u.TabIndex = 187;
            this.stack_2u.Text = "Stack voltage: -";
            // 
            // clear_2
            // 
            this.clear_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.clear_2.Location = new System.Drawing.Point(15, 52);
            this.clear_2.Name = "clear_2";
            this.clear_2.Size = new System.Drawing.Size(150, 60);
            this.clear_2.TabIndex = 185;
            this.clear_2.Text = "Clear";
            this.clear_2.UseVisualStyleBackColor = false;
            this.clear_2.Click += new System.EventHandler(this.clear_2_Click_1);
            // 
            // label441
            // 
            this.label441.AutoSize = true;
            this.label441.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label441.Location = new System.Drawing.Point(10, 20);
            this.label441.Name = "label441";
            this.label441.Size = new System.Drawing.Size(86, 29);
            this.label441.TabIndex = 183;
            this.label441.Text = "Stack 2";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(982, 687);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(35, 30);
            this.label63.TabIndex = 182;
            this.label63.Text = "°C";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(989, 659);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(26, 30);
            this.label64.TabIndex = 181;
            this.label64.Text = "V";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(982, 587);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(35, 30);
            this.label65.TabIndex = 180;
            this.label65.Text = "°C";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(989, 559);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(26, 30);
            this.label66.TabIndex = 179;
            this.label66.Text = "V";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(982, 487);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(35, 30);
            this.label67.TabIndex = 178;
            this.label67.Text = "°C";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(989, 459);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(26, 30);
            this.label68.TabIndex = 177;
            this.label68.Text = "V";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(982, 387);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(35, 30);
            this.label69.TabIndex = 176;
            this.label69.Text = "°C";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(989, 359);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(26, 30);
            this.label70.TabIndex = 175;
            this.label70.Text = "V";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(982, 287);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(35, 30);
            this.label71.TabIndex = 174;
            this.label71.Text = "°C";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(989, 259);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(26, 30);
            this.label72.TabIndex = 173;
            this.label72.Text = "V";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(982, 191);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(35, 30);
            this.label73.TabIndex = 172;
            this.label73.Text = "°C";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(989, 163);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(26, 30);
            this.label74.TabIndex = 171;
            this.label74.Text = "V";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(632, 687);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(35, 30);
            this.label75.TabIndex = 170;
            this.label75.Text = "°C";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(639, 659);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(26, 30);
            this.label76.TabIndex = 169;
            this.label76.Text = "V";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(632, 587);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(35, 30);
            this.label77.TabIndex = 168;
            this.label77.Text = "°C";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(639, 559);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(26, 30);
            this.label78.TabIndex = 167;
            this.label78.Text = "V";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(632, 487);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(35, 30);
            this.label79.TabIndex = 166;
            this.label79.Text = "°C";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(639, 459);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(26, 30);
            this.label80.TabIndex = 165;
            this.label80.Text = "V";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(632, 387);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(35, 30);
            this.label81.TabIndex = 164;
            this.label81.Text = "°C";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(639, 359);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(26, 30);
            this.label82.TabIndex = 163;
            this.label82.Text = "V";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(632, 287);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(35, 30);
            this.label83.TabIndex = 162;
            this.label83.Text = "°C";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(639, 259);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(26, 30);
            this.label84.TabIndex = 161;
            this.label84.Text = "V";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(632, 187);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(35, 30);
            this.label85.TabIndex = 160;
            this.label85.Text = "°C";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(639, 159);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(26, 30);
            this.label86.TabIndex = 159;
            this.label86.Text = "V";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(282, 687);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(35, 30);
            this.label87.TabIndex = 158;
            this.label87.Text = "°C";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(289, 659);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(26, 30);
            this.label88.TabIndex = 157;
            this.label88.Text = "V";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(282, 587);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(35, 30);
            this.label89.TabIndex = 156;
            this.label89.Text = "°C";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(289, 559);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(26, 30);
            this.label90.TabIndex = 155;
            this.label90.Text = "V";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(282, 487);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(35, 30);
            this.label91.TabIndex = 154;
            this.label91.Text = "°C";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(289, 459);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(26, 30);
            this.label92.TabIndex = 153;
            this.label92.Text = "V";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(282, 387);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(35, 30);
            this.label93.TabIndex = 152;
            this.label93.Text = "°C";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(289, 359);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(26, 30);
            this.label94.TabIndex = 151;
            this.label94.Text = "V";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(282, 287);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(35, 30);
            this.label95.TabIndex = 150;
            this.label95.Text = "°C";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(289, 259);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(26, 30);
            this.label96.TabIndex = 149;
            this.label96.Text = "V";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(282, 187);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(35, 30);
            this.label97.TabIndex = 148;
            this.label97.Text = "°C";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(289, 159);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(26, 30);
            this.label98.TabIndex = 147;
            this.label98.Text = "V";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(798, 575);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(84, 30);
            this.label99.TabIndex = 146;
            this.label99.Text = "Cell 17";
            // 
            // textBox_70
            // 
            this.textBox_70.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_70.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_70.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_70.Location = new System.Drawing.Point(901, 592);
            this.textBox_70.Multiline = true;
            this.textBox_70.Name = "textBox_70";
            this.textBox_70.ReadOnly = true;
            this.textBox_70.Size = new System.Drawing.Size(75, 25);
            this.textBox_70.TabIndex = 145;
            this.textBox_70.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_69
            // 
            this.textBox_69.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_69.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_69.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_69.Location = new System.Drawing.Point(901, 561);
            this.textBox_69.Multiline = true;
            this.textBox_69.Name = "textBox_69";
            this.textBox_69.ReadOnly = true;
            this.textBox_69.Size = new System.Drawing.Size(75, 25);
            this.textBox_69.TabIndex = 144;
            this.textBox_69.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(798, 671);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(84, 30);
            this.label100.TabIndex = 143;
            this.label100.Text = "Cell 18";
            // 
            // textBox_72
            // 
            this.textBox_72.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_72.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_72.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_72.Location = new System.Drawing.Point(901, 692);
            this.textBox_72.Multiline = true;
            this.textBox_72.Name = "textBox_72";
            this.textBox_72.ReadOnly = true;
            this.textBox_72.Size = new System.Drawing.Size(75, 25);
            this.textBox_72.TabIndex = 142;
            this.textBox_72.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_71
            // 
            this.textBox_71.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_71.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_71.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_71.Location = new System.Drawing.Point(901, 661);
            this.textBox_71.Multiline = true;
            this.textBox_71.Name = "textBox_71";
            this.textBox_71.ReadOnly = true;
            this.textBox_71.Size = new System.Drawing.Size(75, 25);
            this.textBox_71.TabIndex = 141;
            this.textBox_71.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(798, 375);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(84, 30);
            this.label101.TabIndex = 140;
            this.label101.Text = "Cell 15";
            // 
            // textBox_66
            // 
            this.textBox_66.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_66.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_66.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_66.Location = new System.Drawing.Point(901, 392);
            this.textBox_66.Multiline = true;
            this.textBox_66.Name = "textBox_66";
            this.textBox_66.ReadOnly = true;
            this.textBox_66.Size = new System.Drawing.Size(75, 25);
            this.textBox_66.TabIndex = 139;
            this.textBox_66.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_65
            // 
            this.textBox_65.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_65.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_65.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_65.Location = new System.Drawing.Point(901, 361);
            this.textBox_65.Multiline = true;
            this.textBox_65.Name = "textBox_65";
            this.textBox_65.ReadOnly = true;
            this.textBox_65.Size = new System.Drawing.Size(75, 25);
            this.textBox_65.TabIndex = 138;
            this.textBox_65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(798, 275);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(84, 30);
            this.label102.TabIndex = 137;
            this.label102.Text = "Cell 14";
            // 
            // textBox_64
            // 
            this.textBox_64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_64.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_64.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_64.Location = new System.Drawing.Point(901, 292);
            this.textBox_64.Multiline = true;
            this.textBox_64.Name = "textBox_64";
            this.textBox_64.ReadOnly = true;
            this.textBox_64.Size = new System.Drawing.Size(75, 25);
            this.textBox_64.TabIndex = 136;
            this.textBox_64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_63
            // 
            this.textBox_63.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_63.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_63.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_63.Location = new System.Drawing.Point(901, 261);
            this.textBox_63.Multiline = true;
            this.textBox_63.Name = "textBox_63";
            this.textBox_63.ReadOnly = true;
            this.textBox_63.Size = new System.Drawing.Size(75, 25);
            this.textBox_63.TabIndex = 135;
            this.textBox_63.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(798, 174);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(84, 30);
            this.label103.TabIndex = 134;
            this.label103.Text = "Cell 13";
            // 
            // textBox_62
            // 
            this.textBox_62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_62.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_62.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_62.Location = new System.Drawing.Point(901, 192);
            this.textBox_62.Multiline = true;
            this.textBox_62.Name = "textBox_62";
            this.textBox_62.ReadOnly = true;
            this.textBox_62.Size = new System.Drawing.Size(75, 25);
            this.textBox_62.TabIndex = 133;
            this.textBox_62.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_61
            // 
            this.textBox_61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_61.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_61.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_61.Location = new System.Drawing.Point(901, 161);
            this.textBox_61.Multiline = true;
            this.textBox_61.Name = "textBox_61";
            this.textBox_61.ReadOnly = true;
            this.textBox_61.Size = new System.Drawing.Size(75, 25);
            this.textBox_61.TabIndex = 132;
            this.textBox_61.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(798, 474);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(84, 30);
            this.label104.TabIndex = 131;
            this.label104.Text = "Cell 16";
            // 
            // textBox_68
            // 
            this.textBox_68.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_68.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_68.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_68.Location = new System.Drawing.Point(901, 492);
            this.textBox_68.Multiline = true;
            this.textBox_68.Name = "textBox_68";
            this.textBox_68.ReadOnly = true;
            this.textBox_68.Size = new System.Drawing.Size(75, 25);
            this.textBox_68.TabIndex = 130;
            this.textBox_68.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_67
            // 
            this.textBox_67.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_67.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_67.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_67.Location = new System.Drawing.Point(901, 461);
            this.textBox_67.Multiline = true;
            this.textBox_67.Name = "textBox_67";
            this.textBox_67.ReadOnly = true;
            this.textBox_67.Size = new System.Drawing.Size(75, 25);
            this.textBox_67.TabIndex = 129;
            this.textBox_67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(461, 575);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(84, 30);
            this.label105.TabIndex = 128;
            this.label105.Text = "Cell 11";
            // 
            // textBox_58
            // 
            this.textBox_58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_58.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_58.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_58.Location = new System.Drawing.Point(551, 592);
            this.textBox_58.Multiline = true;
            this.textBox_58.Name = "textBox_58";
            this.textBox_58.ReadOnly = true;
            this.textBox_58.Size = new System.Drawing.Size(75, 25);
            this.textBox_58.TabIndex = 127;
            this.textBox_58.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_57
            // 
            this.textBox_57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_57.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_57.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_57.Location = new System.Drawing.Point(551, 561);
            this.textBox_57.Multiline = true;
            this.textBox_57.Name = "textBox_57";
            this.textBox_57.ReadOnly = true;
            this.textBox_57.Size = new System.Drawing.Size(75, 25);
            this.textBox_57.TabIndex = 126;
            this.textBox_57.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(461, 671);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(84, 30);
            this.label106.TabIndex = 125;
            this.label106.Text = "Cell 12";
            // 
            // textBox_60
            // 
            this.textBox_60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_60.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_60.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_60.Location = new System.Drawing.Point(551, 692);
            this.textBox_60.Multiline = true;
            this.textBox_60.Name = "textBox_60";
            this.textBox_60.ReadOnly = true;
            this.textBox_60.Size = new System.Drawing.Size(75, 25);
            this.textBox_60.TabIndex = 124;
            this.textBox_60.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_59
            // 
            this.textBox_59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_59.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_59.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_59.Location = new System.Drawing.Point(551, 661);
            this.textBox_59.Multiline = true;
            this.textBox_59.Name = "textBox_59";
            this.textBox_59.ReadOnly = true;
            this.textBox_59.Size = new System.Drawing.Size(75, 25);
            this.textBox_59.TabIndex = 123;
            this.textBox_59.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(461, 375);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(70, 30);
            this.label107.TabIndex = 122;
            this.label107.Text = "Cell 9";
            // 
            // textBox_54
            // 
            this.textBox_54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_54.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_54.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_54.Location = new System.Drawing.Point(551, 392);
            this.textBox_54.Multiline = true;
            this.textBox_54.Name = "textBox_54";
            this.textBox_54.ReadOnly = true;
            this.textBox_54.Size = new System.Drawing.Size(75, 25);
            this.textBox_54.TabIndex = 121;
            this.textBox_54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_53
            // 
            this.textBox_53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_53.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_53.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_53.Location = new System.Drawing.Point(551, 361);
            this.textBox_53.Multiline = true;
            this.textBox_53.Name = "textBox_53";
            this.textBox_53.ReadOnly = true;
            this.textBox_53.Size = new System.Drawing.Size(75, 25);
            this.textBox_53.TabIndex = 120;
            this.textBox_53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(461, 275);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(70, 30);
            this.label108.TabIndex = 119;
            this.label108.Text = "Cell 8";
            // 
            // textBox_52
            // 
            this.textBox_52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_52.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_52.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_52.Location = new System.Drawing.Point(551, 292);
            this.textBox_52.Multiline = true;
            this.textBox_52.Name = "textBox_52";
            this.textBox_52.ReadOnly = true;
            this.textBox_52.Size = new System.Drawing.Size(75, 25);
            this.textBox_52.TabIndex = 118;
            this.textBox_52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_51
            // 
            this.textBox_51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_51.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_51.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_51.Location = new System.Drawing.Point(551, 261);
            this.textBox_51.Multiline = true;
            this.textBox_51.Name = "textBox_51";
            this.textBox_51.ReadOnly = true;
            this.textBox_51.Size = new System.Drawing.Size(75, 25);
            this.textBox_51.TabIndex = 117;
            this.textBox_51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(461, 174);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(70, 30);
            this.label109.TabIndex = 116;
            this.label109.Text = "Cell 7";
            // 
            // textBox_50
            // 
            this.textBox_50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_50.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_50.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_50.Location = new System.Drawing.Point(551, 192);
            this.textBox_50.Multiline = true;
            this.textBox_50.Name = "textBox_50";
            this.textBox_50.ReadOnly = true;
            this.textBox_50.Size = new System.Drawing.Size(75, 25);
            this.textBox_50.TabIndex = 115;
            this.textBox_50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_49
            // 
            this.textBox_49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_49.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_49.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_49.Location = new System.Drawing.Point(551, 161);
            this.textBox_49.Multiline = true;
            this.textBox_49.Name = "textBox_49";
            this.textBox_49.ReadOnly = true;
            this.textBox_49.Size = new System.Drawing.Size(75, 25);
            this.textBox_49.TabIndex = 114;
            this.textBox_49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(461, 474);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(84, 30);
            this.label110.TabIndex = 113;
            this.label110.Text = "Cell 10";
            // 
            // textBox_56
            // 
            this.textBox_56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_56.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_56.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_56.Location = new System.Drawing.Point(551, 492);
            this.textBox_56.Multiline = true;
            this.textBox_56.Name = "textBox_56";
            this.textBox_56.ReadOnly = true;
            this.textBox_56.Size = new System.Drawing.Size(75, 25);
            this.textBox_56.TabIndex = 112;
            this.textBox_56.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_55
            // 
            this.textBox_55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_55.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_55.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_55.Location = new System.Drawing.Point(551, 461);
            this.textBox_55.Multiline = true;
            this.textBox_55.Name = "textBox_55";
            this.textBox_55.ReadOnly = true;
            this.textBox_55.Size = new System.Drawing.Size(75, 25);
            this.textBox_55.TabIndex = 111;
            this.textBox_55.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(125, 575);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(70, 30);
            this.label111.TabIndex = 110;
            this.label111.Text = "Cell 5";
            // 
            // textBox_46
            // 
            this.textBox_46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_46.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_46.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_46.Location = new System.Drawing.Point(201, 592);
            this.textBox_46.Multiline = true;
            this.textBox_46.Name = "textBox_46";
            this.textBox_46.ReadOnly = true;
            this.textBox_46.Size = new System.Drawing.Size(75, 25);
            this.textBox_46.TabIndex = 109;
            this.textBox_46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_45
            // 
            this.textBox_45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_45.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_45.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_45.Location = new System.Drawing.Point(201, 561);
            this.textBox_45.Multiline = true;
            this.textBox_45.Name = "textBox_45";
            this.textBox_45.ReadOnly = true;
            this.textBox_45.Size = new System.Drawing.Size(75, 25);
            this.textBox_45.TabIndex = 108;
            this.textBox_45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(125, 671);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(70, 30);
            this.label112.TabIndex = 107;
            this.label112.Text = "Cell 6";
            // 
            // textBox_48
            // 
            this.textBox_48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_48.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_48.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_48.Location = new System.Drawing.Point(201, 692);
            this.textBox_48.Multiline = true;
            this.textBox_48.Name = "textBox_48";
            this.textBox_48.ReadOnly = true;
            this.textBox_48.Size = new System.Drawing.Size(75, 25);
            this.textBox_48.TabIndex = 106;
            this.textBox_48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_47
            // 
            this.textBox_47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_47.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_47.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_47.Location = new System.Drawing.Point(201, 661);
            this.textBox_47.Multiline = true;
            this.textBox_47.Name = "textBox_47";
            this.textBox_47.ReadOnly = true;
            this.textBox_47.Size = new System.Drawing.Size(75, 25);
            this.textBox_47.TabIndex = 105;
            this.textBox_47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(125, 375);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(70, 30);
            this.label113.TabIndex = 104;
            this.label113.Text = "Cell 3";
            // 
            // textBox_42
            // 
            this.textBox_42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_42.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_42.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_42.Location = new System.Drawing.Point(201, 392);
            this.textBox_42.Multiline = true;
            this.textBox_42.Name = "textBox_42";
            this.textBox_42.ReadOnly = true;
            this.textBox_42.Size = new System.Drawing.Size(75, 25);
            this.textBox_42.TabIndex = 103;
            this.textBox_42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_41
            // 
            this.textBox_41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_41.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_41.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_41.Location = new System.Drawing.Point(201, 361);
            this.textBox_41.Multiline = true;
            this.textBox_41.Name = "textBox_41";
            this.textBox_41.ReadOnly = true;
            this.textBox_41.Size = new System.Drawing.Size(75, 25);
            this.textBox_41.TabIndex = 102;
            this.textBox_41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(125, 275);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(70, 30);
            this.label114.TabIndex = 101;
            this.label114.Text = "Cell 2";
            // 
            // textBox_40
            // 
            this.textBox_40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_40.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_40.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_40.Location = new System.Drawing.Point(201, 292);
            this.textBox_40.Multiline = true;
            this.textBox_40.Name = "textBox_40";
            this.textBox_40.ReadOnly = true;
            this.textBox_40.Size = new System.Drawing.Size(75, 25);
            this.textBox_40.TabIndex = 100;
            this.textBox_40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_39
            // 
            this.textBox_39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_39.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_39.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_39.Location = new System.Drawing.Point(201, 261);
            this.textBox_39.Multiline = true;
            this.textBox_39.Name = "textBox_39";
            this.textBox_39.ReadOnly = true;
            this.textBox_39.Size = new System.Drawing.Size(75, 25);
            this.textBox_39.TabIndex = 99;
            this.textBox_39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(125, 174);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(70, 30);
            this.label115.TabIndex = 98;
            this.label115.Text = "Cell 1";
            // 
            // textBox_38
            // 
            this.textBox_38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_38.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_38.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_38.Location = new System.Drawing.Point(201, 192);
            this.textBox_38.Multiline = true;
            this.textBox_38.Name = "textBox_38";
            this.textBox_38.ReadOnly = true;
            this.textBox_38.Size = new System.Drawing.Size(75, 25);
            this.textBox_38.TabIndex = 97;
            this.textBox_38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_37
            // 
            this.textBox_37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_37.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_37.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_37.Location = new System.Drawing.Point(201, 161);
            this.textBox_37.Multiline = true;
            this.textBox_37.Name = "textBox_37";
            this.textBox_37.ReadOnly = true;
            this.textBox_37.Size = new System.Drawing.Size(75, 25);
            this.textBox_37.TabIndex = 96;
            this.textBox_37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(125, 474);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(70, 30);
            this.label116.TabIndex = 95;
            this.label116.Text = "Cell 4";
            // 
            // textBox_44
            // 
            this.textBox_44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_44.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_44.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_44.Location = new System.Drawing.Point(201, 492);
            this.textBox_44.Multiline = true;
            this.textBox_44.Name = "textBox_44";
            this.textBox_44.ReadOnly = true;
            this.textBox_44.Size = new System.Drawing.Size(75, 25);
            this.textBox_44.TabIndex = 94;
            this.textBox_44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_43
            // 
            this.textBox_43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_43.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_43.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_43.Location = new System.Drawing.Point(201, 461);
            this.textBox_43.Multiline = true;
            this.textBox_43.Name = "textBox_43";
            this.textBox_43.ReadOnly = true;
            this.textBox_43.Size = new System.Drawing.Size(75, 25);
            this.textBox_43.TabIndex = 93;
            this.textBox_43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stack3
            // 
            this.stack3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.stack3.Controls.Add(this.stack_3u);
            this.stack3.Controls.Add(this.clear_3);
            this.stack3.Controls.Add(this.label442);
            this.stack3.Controls.Add(this.label117);
            this.stack3.Controls.Add(this.label118);
            this.stack3.Controls.Add(this.label119);
            this.stack3.Controls.Add(this.label120);
            this.stack3.Controls.Add(this.label121);
            this.stack3.Controls.Add(this.label122);
            this.stack3.Controls.Add(this.label123);
            this.stack3.Controls.Add(this.label124);
            this.stack3.Controls.Add(this.label125);
            this.stack3.Controls.Add(this.label126);
            this.stack3.Controls.Add(this.label127);
            this.stack3.Controls.Add(this.label128);
            this.stack3.Controls.Add(this.label129);
            this.stack3.Controls.Add(this.label130);
            this.stack3.Controls.Add(this.label131);
            this.stack3.Controls.Add(this.label132);
            this.stack3.Controls.Add(this.label133);
            this.stack3.Controls.Add(this.label134);
            this.stack3.Controls.Add(this.label135);
            this.stack3.Controls.Add(this.label136);
            this.stack3.Controls.Add(this.label137);
            this.stack3.Controls.Add(this.label138);
            this.stack3.Controls.Add(this.label139);
            this.stack3.Controls.Add(this.label140);
            this.stack3.Controls.Add(this.label141);
            this.stack3.Controls.Add(this.label142);
            this.stack3.Controls.Add(this.label143);
            this.stack3.Controls.Add(this.label144);
            this.stack3.Controls.Add(this.label145);
            this.stack3.Controls.Add(this.label146);
            this.stack3.Controls.Add(this.label147);
            this.stack3.Controls.Add(this.label148);
            this.stack3.Controls.Add(this.label149);
            this.stack3.Controls.Add(this.label150);
            this.stack3.Controls.Add(this.label151);
            this.stack3.Controls.Add(this.label152);
            this.stack3.Controls.Add(this.label153);
            this.stack3.Controls.Add(this.textBox_106);
            this.stack3.Controls.Add(this.textBox_105);
            this.stack3.Controls.Add(this.label154);
            this.stack3.Controls.Add(this.textBox_108);
            this.stack3.Controls.Add(this.textBox_107);
            this.stack3.Controls.Add(this.label155);
            this.stack3.Controls.Add(this.textBox_102);
            this.stack3.Controls.Add(this.textBox_101);
            this.stack3.Controls.Add(this.label156);
            this.stack3.Controls.Add(this.textBox_100);
            this.stack3.Controls.Add(this.textBox_99);
            this.stack3.Controls.Add(this.label157);
            this.stack3.Controls.Add(this.textBox_98);
            this.stack3.Controls.Add(this.textBox_97);
            this.stack3.Controls.Add(this.label158);
            this.stack3.Controls.Add(this.textBox_104);
            this.stack3.Controls.Add(this.textBox_103);
            this.stack3.Controls.Add(this.label159);
            this.stack3.Controls.Add(this.textBox_94);
            this.stack3.Controls.Add(this.textBox_93);
            this.stack3.Controls.Add(this.label160);
            this.stack3.Controls.Add(this.textBox_96);
            this.stack3.Controls.Add(this.textBox_95);
            this.stack3.Controls.Add(this.label161);
            this.stack3.Controls.Add(this.textBox_90);
            this.stack3.Controls.Add(this.textBox_89);
            this.stack3.Controls.Add(this.label162);
            this.stack3.Controls.Add(this.textBox_88);
            this.stack3.Controls.Add(this.textBox_87);
            this.stack3.Controls.Add(this.label163);
            this.stack3.Controls.Add(this.textBox_86);
            this.stack3.Controls.Add(this.textBox_85);
            this.stack3.Controls.Add(this.label164);
            this.stack3.Controls.Add(this.textBox_92);
            this.stack3.Controls.Add(this.textBox_91);
            this.stack3.Controls.Add(this.label165);
            this.stack3.Controls.Add(this.textBox_82);
            this.stack3.Controls.Add(this.textBox_81);
            this.stack3.Controls.Add(this.label166);
            this.stack3.Controls.Add(this.textBox_84);
            this.stack3.Controls.Add(this.textBox_83);
            this.stack3.Controls.Add(this.label167);
            this.stack3.Controls.Add(this.textBox_78);
            this.stack3.Controls.Add(this.textBox_77);
            this.stack3.Controls.Add(this.label168);
            this.stack3.Controls.Add(this.textBox_76);
            this.stack3.Controls.Add(this.textBox_75);
            this.stack3.Controls.Add(this.label169);
            this.stack3.Controls.Add(this.textBox_74);
            this.stack3.Controls.Add(this.textBox_73);
            this.stack3.Controls.Add(this.label170);
            this.stack3.Controls.Add(this.textBox_80);
            this.stack3.Controls.Add(this.textBox_79);
            this.stack3.Location = new System.Drawing.Point(4, 39);
            this.stack3.Name = "stack3";
            this.stack3.Size = new System.Drawing.Size(1442, 910);
            this.stack3.TabIndex = 5;
            this.stack3.Text = "Stack 3";
            // 
            // stack_3u
            // 
            this.stack_3u.AutoSize = true;
            this.stack_3u.Font = new System.Drawing.Font("3ds Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stack_3u.Location = new System.Drawing.Point(460, 52);
            this.stack_3u.Name = "stack_3u";
            this.stack_3u.Size = new System.Drawing.Size(204, 36);
            this.stack_3u.TabIndex = 187;
            this.stack_3u.Text = "Stack voltage: -";
            // 
            // clear_3
            // 
            this.clear_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.clear_3.Location = new System.Drawing.Point(15, 52);
            this.clear_3.Name = "clear_3";
            this.clear_3.Size = new System.Drawing.Size(150, 60);
            this.clear_3.TabIndex = 185;
            this.clear_3.Text = "Clear";
            this.clear_3.UseVisualStyleBackColor = false;
            // 
            // label442
            // 
            this.label442.AutoSize = true;
            this.label442.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label442.Location = new System.Drawing.Point(10, 20);
            this.label442.Name = "label442";
            this.label442.Size = new System.Drawing.Size(86, 29);
            this.label442.TabIndex = 183;
            this.label442.Text = "Stack 3";
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(982, 687);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(35, 30);
            this.label117.TabIndex = 182;
            this.label117.Text = "°C";
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(989, 659);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(26, 30);
            this.label118.TabIndex = 181;
            this.label118.Text = "V";
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(982, 587);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(35, 30);
            this.label119.TabIndex = 180;
            this.label119.Text = "°C";
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(989, 559);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(26, 30);
            this.label120.TabIndex = 179;
            this.label120.Text = "V";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(982, 487);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(35, 30);
            this.label121.TabIndex = 178;
            this.label121.Text = "°C";
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(989, 459);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(26, 30);
            this.label122.TabIndex = 177;
            this.label122.Text = "V";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(982, 387);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(35, 30);
            this.label123.TabIndex = 176;
            this.label123.Text = "°C";
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(989, 359);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(26, 30);
            this.label124.TabIndex = 175;
            this.label124.Text = "V";
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(982, 287);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(35, 30);
            this.label125.TabIndex = 174;
            this.label125.Text = "°C";
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Location = new System.Drawing.Point(989, 259);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(26, 30);
            this.label126.TabIndex = 173;
            this.label126.Text = "V";
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.Location = new System.Drawing.Point(982, 191);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(35, 30);
            this.label127.TabIndex = 172;
            this.label127.Text = "°C";
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.Location = new System.Drawing.Point(989, 163);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(26, 30);
            this.label128.TabIndex = 171;
            this.label128.Text = "V";
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Location = new System.Drawing.Point(632, 687);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(35, 30);
            this.label129.TabIndex = 170;
            this.label129.Text = "°C";
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Location = new System.Drawing.Point(639, 659);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(26, 30);
            this.label130.TabIndex = 169;
            this.label130.Text = "V";
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.Location = new System.Drawing.Point(632, 587);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(35, 30);
            this.label131.TabIndex = 168;
            this.label131.Text = "°C";
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.Location = new System.Drawing.Point(639, 559);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(26, 30);
            this.label132.TabIndex = 167;
            this.label132.Text = "V";
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.Location = new System.Drawing.Point(632, 487);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(35, 30);
            this.label133.TabIndex = 166;
            this.label133.Text = "°C";
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Location = new System.Drawing.Point(639, 459);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(26, 30);
            this.label134.TabIndex = 165;
            this.label134.Text = "V";
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Location = new System.Drawing.Point(632, 387);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(35, 30);
            this.label135.TabIndex = 164;
            this.label135.Text = "°C";
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.Location = new System.Drawing.Point(639, 359);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(26, 30);
            this.label136.TabIndex = 163;
            this.label136.Text = "V";
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.Location = new System.Drawing.Point(632, 287);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(35, 30);
            this.label137.TabIndex = 162;
            this.label137.Text = "°C";
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.Location = new System.Drawing.Point(639, 259);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(26, 30);
            this.label138.TabIndex = 161;
            this.label138.Text = "V";
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.Location = new System.Drawing.Point(632, 187);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(35, 30);
            this.label139.TabIndex = 160;
            this.label139.Text = "°C";
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Location = new System.Drawing.Point(639, 159);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(26, 30);
            this.label140.TabIndex = 159;
            this.label140.Text = "V";
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.Location = new System.Drawing.Point(282, 687);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(35, 30);
            this.label141.TabIndex = 158;
            this.label141.Text = "°C";
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.Location = new System.Drawing.Point(289, 659);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(26, 30);
            this.label142.TabIndex = 157;
            this.label142.Text = "V";
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.Location = new System.Drawing.Point(282, 587);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(35, 30);
            this.label143.TabIndex = 156;
            this.label143.Text = "°C";
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.Location = new System.Drawing.Point(289, 559);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(26, 30);
            this.label144.TabIndex = 155;
            this.label144.Text = "V";
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.Location = new System.Drawing.Point(282, 487);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(35, 30);
            this.label145.TabIndex = 154;
            this.label145.Text = "°C";
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.label146.Location = new System.Drawing.Point(289, 459);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(26, 30);
            this.label146.TabIndex = 153;
            this.label146.Text = "V";
            // 
            // label147
            // 
            this.label147.AutoSize = true;
            this.label147.Location = new System.Drawing.Point(282, 387);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(35, 30);
            this.label147.TabIndex = 152;
            this.label147.Text = "°C";
            // 
            // label148
            // 
            this.label148.AutoSize = true;
            this.label148.Location = new System.Drawing.Point(289, 359);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(26, 30);
            this.label148.TabIndex = 151;
            this.label148.Text = "V";
            // 
            // label149
            // 
            this.label149.AutoSize = true;
            this.label149.Location = new System.Drawing.Point(282, 287);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(35, 30);
            this.label149.TabIndex = 150;
            this.label149.Text = "°C";
            // 
            // label150
            // 
            this.label150.AutoSize = true;
            this.label150.Location = new System.Drawing.Point(289, 259);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(26, 30);
            this.label150.TabIndex = 149;
            this.label150.Text = "V";
            // 
            // label151
            // 
            this.label151.AutoSize = true;
            this.label151.Location = new System.Drawing.Point(282, 187);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(35, 30);
            this.label151.TabIndex = 148;
            this.label151.Text = "°C";
            // 
            // label152
            // 
            this.label152.AutoSize = true;
            this.label152.Location = new System.Drawing.Point(289, 159);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(26, 30);
            this.label152.TabIndex = 147;
            this.label152.Text = "V";
            // 
            // label153
            // 
            this.label153.AutoSize = true;
            this.label153.Location = new System.Drawing.Point(798, 575);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(84, 30);
            this.label153.TabIndex = 146;
            this.label153.Text = "Cell 17";
            // 
            // textBox_106
            // 
            this.textBox_106.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_106.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_106.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_106.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_106.Location = new System.Drawing.Point(901, 592);
            this.textBox_106.Multiline = true;
            this.textBox_106.Name = "textBox_106";
            this.textBox_106.ReadOnly = true;
            this.textBox_106.Size = new System.Drawing.Size(75, 25);
            this.textBox_106.TabIndex = 145;
            this.textBox_106.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_105
            // 
            this.textBox_105.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_105.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_105.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_105.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_105.Location = new System.Drawing.Point(901, 561);
            this.textBox_105.Multiline = true;
            this.textBox_105.Name = "textBox_105";
            this.textBox_105.ReadOnly = true;
            this.textBox_105.Size = new System.Drawing.Size(75, 25);
            this.textBox_105.TabIndex = 144;
            this.textBox_105.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label154
            // 
            this.label154.AutoSize = true;
            this.label154.Location = new System.Drawing.Point(798, 671);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(84, 30);
            this.label154.TabIndex = 143;
            this.label154.Text = "Cell 18";
            // 
            // textBox_108
            // 
            this.textBox_108.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_108.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_108.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_108.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_108.Location = new System.Drawing.Point(901, 692);
            this.textBox_108.Multiline = true;
            this.textBox_108.Name = "textBox_108";
            this.textBox_108.ReadOnly = true;
            this.textBox_108.Size = new System.Drawing.Size(75, 25);
            this.textBox_108.TabIndex = 142;
            this.textBox_108.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_107
            // 
            this.textBox_107.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_107.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_107.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_107.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_107.Location = new System.Drawing.Point(901, 661);
            this.textBox_107.Multiline = true;
            this.textBox_107.Name = "textBox_107";
            this.textBox_107.ReadOnly = true;
            this.textBox_107.Size = new System.Drawing.Size(75, 25);
            this.textBox_107.TabIndex = 141;
            this.textBox_107.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label155
            // 
            this.label155.AutoSize = true;
            this.label155.Location = new System.Drawing.Point(798, 375);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(84, 30);
            this.label155.TabIndex = 140;
            this.label155.Text = "Cell 15";
            // 
            // textBox_102
            // 
            this.textBox_102.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_102.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_102.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_102.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_102.Location = new System.Drawing.Point(901, 392);
            this.textBox_102.Multiline = true;
            this.textBox_102.Name = "textBox_102";
            this.textBox_102.ReadOnly = true;
            this.textBox_102.Size = new System.Drawing.Size(75, 25);
            this.textBox_102.TabIndex = 139;
            this.textBox_102.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_101
            // 
            this.textBox_101.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_101.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_101.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_101.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_101.Location = new System.Drawing.Point(901, 361);
            this.textBox_101.Multiline = true;
            this.textBox_101.Name = "textBox_101";
            this.textBox_101.ReadOnly = true;
            this.textBox_101.Size = new System.Drawing.Size(75, 25);
            this.textBox_101.TabIndex = 138;
            this.textBox_101.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.Location = new System.Drawing.Point(798, 275);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(84, 30);
            this.label156.TabIndex = 137;
            this.label156.Text = "Cell 14";
            // 
            // textBox_100
            // 
            this.textBox_100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_100.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_100.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_100.Location = new System.Drawing.Point(901, 292);
            this.textBox_100.Multiline = true;
            this.textBox_100.Name = "textBox_100";
            this.textBox_100.ReadOnly = true;
            this.textBox_100.Size = new System.Drawing.Size(75, 25);
            this.textBox_100.TabIndex = 136;
            this.textBox_100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_99
            // 
            this.textBox_99.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_99.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_99.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_99.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_99.Location = new System.Drawing.Point(901, 261);
            this.textBox_99.Multiline = true;
            this.textBox_99.Name = "textBox_99";
            this.textBox_99.ReadOnly = true;
            this.textBox_99.Size = new System.Drawing.Size(75, 25);
            this.textBox_99.TabIndex = 135;
            this.textBox_99.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label157
            // 
            this.label157.AutoSize = true;
            this.label157.Location = new System.Drawing.Point(798, 174);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(84, 30);
            this.label157.TabIndex = 134;
            this.label157.Text = "Cell 13";
            // 
            // textBox_98
            // 
            this.textBox_98.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_98.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_98.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_98.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_98.Location = new System.Drawing.Point(901, 192);
            this.textBox_98.Multiline = true;
            this.textBox_98.Name = "textBox_98";
            this.textBox_98.ReadOnly = true;
            this.textBox_98.Size = new System.Drawing.Size(75, 25);
            this.textBox_98.TabIndex = 133;
            this.textBox_98.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_97
            // 
            this.textBox_97.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_97.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_97.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_97.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_97.Location = new System.Drawing.Point(901, 161);
            this.textBox_97.Multiline = true;
            this.textBox_97.Name = "textBox_97";
            this.textBox_97.ReadOnly = true;
            this.textBox_97.Size = new System.Drawing.Size(75, 25);
            this.textBox_97.TabIndex = 132;
            this.textBox_97.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.Location = new System.Drawing.Point(798, 474);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(84, 30);
            this.label158.TabIndex = 131;
            this.label158.Text = "Cell 16";
            // 
            // textBox_104
            // 
            this.textBox_104.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_104.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_104.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_104.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_104.Location = new System.Drawing.Point(901, 492);
            this.textBox_104.Multiline = true;
            this.textBox_104.Name = "textBox_104";
            this.textBox_104.ReadOnly = true;
            this.textBox_104.Size = new System.Drawing.Size(75, 25);
            this.textBox_104.TabIndex = 130;
            this.textBox_104.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_103
            // 
            this.textBox_103.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_103.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_103.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_103.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_103.Location = new System.Drawing.Point(901, 461);
            this.textBox_103.Multiline = true;
            this.textBox_103.Name = "textBox_103";
            this.textBox_103.ReadOnly = true;
            this.textBox_103.Size = new System.Drawing.Size(75, 25);
            this.textBox_103.TabIndex = 129;
            this.textBox_103.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label159
            // 
            this.label159.AutoSize = true;
            this.label159.Location = new System.Drawing.Point(461, 575);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(84, 30);
            this.label159.TabIndex = 128;
            this.label159.Text = "Cell 11";
            // 
            // textBox_94
            // 
            this.textBox_94.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_94.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_94.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_94.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_94.Location = new System.Drawing.Point(551, 592);
            this.textBox_94.Multiline = true;
            this.textBox_94.Name = "textBox_94";
            this.textBox_94.ReadOnly = true;
            this.textBox_94.Size = new System.Drawing.Size(75, 25);
            this.textBox_94.TabIndex = 127;
            this.textBox_94.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_93
            // 
            this.textBox_93.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_93.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_93.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_93.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_93.Location = new System.Drawing.Point(551, 561);
            this.textBox_93.Multiline = true;
            this.textBox_93.Name = "textBox_93";
            this.textBox_93.ReadOnly = true;
            this.textBox_93.Size = new System.Drawing.Size(75, 25);
            this.textBox_93.TabIndex = 126;
            this.textBox_93.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label160
            // 
            this.label160.AutoSize = true;
            this.label160.Location = new System.Drawing.Point(461, 671);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(84, 30);
            this.label160.TabIndex = 125;
            this.label160.Text = "Cell 12";
            // 
            // textBox_96
            // 
            this.textBox_96.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_96.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_96.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_96.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_96.Location = new System.Drawing.Point(551, 692);
            this.textBox_96.Multiline = true;
            this.textBox_96.Name = "textBox_96";
            this.textBox_96.ReadOnly = true;
            this.textBox_96.Size = new System.Drawing.Size(75, 25);
            this.textBox_96.TabIndex = 124;
            this.textBox_96.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_95
            // 
            this.textBox_95.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_95.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_95.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_95.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_95.Location = new System.Drawing.Point(551, 661);
            this.textBox_95.Multiline = true;
            this.textBox_95.Name = "textBox_95";
            this.textBox_95.ReadOnly = true;
            this.textBox_95.Size = new System.Drawing.Size(75, 25);
            this.textBox_95.TabIndex = 123;
            this.textBox_95.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label161
            // 
            this.label161.AutoSize = true;
            this.label161.Location = new System.Drawing.Point(461, 375);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(70, 30);
            this.label161.TabIndex = 122;
            this.label161.Text = "Cell 9";
            // 
            // textBox_90
            // 
            this.textBox_90.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_90.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_90.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_90.Location = new System.Drawing.Point(551, 392);
            this.textBox_90.Multiline = true;
            this.textBox_90.Name = "textBox_90";
            this.textBox_90.ReadOnly = true;
            this.textBox_90.Size = new System.Drawing.Size(75, 25);
            this.textBox_90.TabIndex = 121;
            this.textBox_90.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_89
            // 
            this.textBox_89.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_89.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_89.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_89.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_89.Location = new System.Drawing.Point(551, 361);
            this.textBox_89.Multiline = true;
            this.textBox_89.Name = "textBox_89";
            this.textBox_89.ReadOnly = true;
            this.textBox_89.Size = new System.Drawing.Size(75, 25);
            this.textBox_89.TabIndex = 120;
            this.textBox_89.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label162
            // 
            this.label162.AutoSize = true;
            this.label162.Location = new System.Drawing.Point(461, 275);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(70, 30);
            this.label162.TabIndex = 119;
            this.label162.Text = "Cell 8";
            // 
            // textBox_88
            // 
            this.textBox_88.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_88.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_88.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_88.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_88.Location = new System.Drawing.Point(551, 292);
            this.textBox_88.Multiline = true;
            this.textBox_88.Name = "textBox_88";
            this.textBox_88.ReadOnly = true;
            this.textBox_88.Size = new System.Drawing.Size(75, 25);
            this.textBox_88.TabIndex = 118;
            this.textBox_88.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_87
            // 
            this.textBox_87.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_87.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_87.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_87.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_87.Location = new System.Drawing.Point(551, 261);
            this.textBox_87.Multiline = true;
            this.textBox_87.Name = "textBox_87";
            this.textBox_87.ReadOnly = true;
            this.textBox_87.Size = new System.Drawing.Size(75, 25);
            this.textBox_87.TabIndex = 117;
            this.textBox_87.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label163
            // 
            this.label163.AutoSize = true;
            this.label163.Location = new System.Drawing.Point(461, 174);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(70, 30);
            this.label163.TabIndex = 116;
            this.label163.Text = "Cell 7";
            // 
            // textBox_86
            // 
            this.textBox_86.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_86.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_86.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_86.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_86.Location = new System.Drawing.Point(551, 192);
            this.textBox_86.Multiline = true;
            this.textBox_86.Name = "textBox_86";
            this.textBox_86.ReadOnly = true;
            this.textBox_86.Size = new System.Drawing.Size(75, 25);
            this.textBox_86.TabIndex = 115;
            this.textBox_86.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_85
            // 
            this.textBox_85.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_85.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_85.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_85.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_85.Location = new System.Drawing.Point(551, 161);
            this.textBox_85.Multiline = true;
            this.textBox_85.Name = "textBox_85";
            this.textBox_85.ReadOnly = true;
            this.textBox_85.Size = new System.Drawing.Size(75, 25);
            this.textBox_85.TabIndex = 114;
            this.textBox_85.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label164
            // 
            this.label164.AutoSize = true;
            this.label164.Location = new System.Drawing.Point(461, 474);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(84, 30);
            this.label164.TabIndex = 113;
            this.label164.Text = "Cell 10";
            // 
            // textBox_92
            // 
            this.textBox_92.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_92.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_92.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_92.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_92.Location = new System.Drawing.Point(551, 492);
            this.textBox_92.Multiline = true;
            this.textBox_92.Name = "textBox_92";
            this.textBox_92.ReadOnly = true;
            this.textBox_92.Size = new System.Drawing.Size(75, 25);
            this.textBox_92.TabIndex = 112;
            this.textBox_92.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_91
            // 
            this.textBox_91.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_91.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_91.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_91.Location = new System.Drawing.Point(551, 461);
            this.textBox_91.Multiline = true;
            this.textBox_91.Name = "textBox_91";
            this.textBox_91.ReadOnly = true;
            this.textBox_91.Size = new System.Drawing.Size(75, 25);
            this.textBox_91.TabIndex = 111;
            this.textBox_91.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label165
            // 
            this.label165.AutoSize = true;
            this.label165.Location = new System.Drawing.Point(125, 575);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(70, 30);
            this.label165.TabIndex = 110;
            this.label165.Text = "Cell 5";
            // 
            // textBox_82
            // 
            this.textBox_82.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_82.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_82.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_82.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_82.Location = new System.Drawing.Point(201, 592);
            this.textBox_82.Multiline = true;
            this.textBox_82.Name = "textBox_82";
            this.textBox_82.ReadOnly = true;
            this.textBox_82.Size = new System.Drawing.Size(75, 25);
            this.textBox_82.TabIndex = 109;
            this.textBox_82.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_81
            // 
            this.textBox_81.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_81.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_81.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_81.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_81.Location = new System.Drawing.Point(201, 561);
            this.textBox_81.Multiline = true;
            this.textBox_81.Name = "textBox_81";
            this.textBox_81.ReadOnly = true;
            this.textBox_81.Size = new System.Drawing.Size(75, 25);
            this.textBox_81.TabIndex = 108;
            this.textBox_81.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label166
            // 
            this.label166.AutoSize = true;
            this.label166.Location = new System.Drawing.Point(125, 671);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(70, 30);
            this.label166.TabIndex = 107;
            this.label166.Text = "Cell 6";
            // 
            // textBox_84
            // 
            this.textBox_84.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_84.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_84.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_84.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_84.Location = new System.Drawing.Point(201, 692);
            this.textBox_84.Multiline = true;
            this.textBox_84.Name = "textBox_84";
            this.textBox_84.ReadOnly = true;
            this.textBox_84.Size = new System.Drawing.Size(75, 25);
            this.textBox_84.TabIndex = 106;
            this.textBox_84.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_83
            // 
            this.textBox_83.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_83.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_83.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_83.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_83.Location = new System.Drawing.Point(201, 661);
            this.textBox_83.Multiline = true;
            this.textBox_83.Name = "textBox_83";
            this.textBox_83.ReadOnly = true;
            this.textBox_83.Size = new System.Drawing.Size(75, 25);
            this.textBox_83.TabIndex = 105;
            this.textBox_83.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label167
            // 
            this.label167.AutoSize = true;
            this.label167.Location = new System.Drawing.Point(125, 375);
            this.label167.Name = "label167";
            this.label167.Size = new System.Drawing.Size(70, 30);
            this.label167.TabIndex = 104;
            this.label167.Text = "Cell 3";
            // 
            // textBox_78
            // 
            this.textBox_78.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_78.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_78.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_78.Location = new System.Drawing.Point(201, 392);
            this.textBox_78.Multiline = true;
            this.textBox_78.Name = "textBox_78";
            this.textBox_78.ReadOnly = true;
            this.textBox_78.Size = new System.Drawing.Size(75, 25);
            this.textBox_78.TabIndex = 103;
            this.textBox_78.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_77
            // 
            this.textBox_77.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_77.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_77.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_77.Location = new System.Drawing.Point(201, 361);
            this.textBox_77.Multiline = true;
            this.textBox_77.Name = "textBox_77";
            this.textBox_77.ReadOnly = true;
            this.textBox_77.Size = new System.Drawing.Size(75, 25);
            this.textBox_77.TabIndex = 102;
            this.textBox_77.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label168
            // 
            this.label168.AutoSize = true;
            this.label168.Location = new System.Drawing.Point(125, 275);
            this.label168.Name = "label168";
            this.label168.Size = new System.Drawing.Size(70, 30);
            this.label168.TabIndex = 101;
            this.label168.Text = "Cell 2";
            // 
            // textBox_76
            // 
            this.textBox_76.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_76.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_76.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_76.Location = new System.Drawing.Point(201, 292);
            this.textBox_76.Multiline = true;
            this.textBox_76.Name = "textBox_76";
            this.textBox_76.ReadOnly = true;
            this.textBox_76.Size = new System.Drawing.Size(75, 25);
            this.textBox_76.TabIndex = 100;
            this.textBox_76.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_75
            // 
            this.textBox_75.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_75.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_75.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_75.Location = new System.Drawing.Point(201, 261);
            this.textBox_75.Multiline = true;
            this.textBox_75.Name = "textBox_75";
            this.textBox_75.ReadOnly = true;
            this.textBox_75.Size = new System.Drawing.Size(75, 25);
            this.textBox_75.TabIndex = 99;
            this.textBox_75.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label169
            // 
            this.label169.AutoSize = true;
            this.label169.Location = new System.Drawing.Point(125, 174);
            this.label169.Name = "label169";
            this.label169.Size = new System.Drawing.Size(70, 30);
            this.label169.TabIndex = 98;
            this.label169.Text = "Cell 1";
            // 
            // textBox_74
            // 
            this.textBox_74.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_74.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_74.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_74.Location = new System.Drawing.Point(201, 192);
            this.textBox_74.Multiline = true;
            this.textBox_74.Name = "textBox_74";
            this.textBox_74.ReadOnly = true;
            this.textBox_74.Size = new System.Drawing.Size(75, 25);
            this.textBox_74.TabIndex = 97;
            this.textBox_74.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_73
            // 
            this.textBox_73.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_73.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_73.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_73.Location = new System.Drawing.Point(201, 161);
            this.textBox_73.Multiline = true;
            this.textBox_73.Name = "textBox_73";
            this.textBox_73.ReadOnly = true;
            this.textBox_73.Size = new System.Drawing.Size(75, 25);
            this.textBox_73.TabIndex = 96;
            this.textBox_73.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label170
            // 
            this.label170.AutoSize = true;
            this.label170.Location = new System.Drawing.Point(125, 474);
            this.label170.Name = "label170";
            this.label170.Size = new System.Drawing.Size(70, 30);
            this.label170.TabIndex = 95;
            this.label170.Text = "Cell 4";
            // 
            // textBox_80
            // 
            this.textBox_80.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_80.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_80.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_80.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_80.Location = new System.Drawing.Point(201, 492);
            this.textBox_80.Multiline = true;
            this.textBox_80.Name = "textBox_80";
            this.textBox_80.ReadOnly = true;
            this.textBox_80.Size = new System.Drawing.Size(75, 25);
            this.textBox_80.TabIndex = 94;
            this.textBox_80.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_79
            // 
            this.textBox_79.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_79.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_79.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_79.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_79.Location = new System.Drawing.Point(201, 461);
            this.textBox_79.Multiline = true;
            this.textBox_79.Name = "textBox_79";
            this.textBox_79.ReadOnly = true;
            this.textBox_79.Size = new System.Drawing.Size(75, 25);
            this.textBox_79.TabIndex = 93;
            this.textBox_79.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stack4
            // 
            this.stack4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.stack4.Controls.Add(this.stack_4u);
            this.stack4.Controls.Add(this.clear_4);
            this.stack4.Controls.Add(this.label443);
            this.stack4.Controls.Add(this.label171);
            this.stack4.Controls.Add(this.label172);
            this.stack4.Controls.Add(this.label173);
            this.stack4.Controls.Add(this.label174);
            this.stack4.Controls.Add(this.label175);
            this.stack4.Controls.Add(this.label176);
            this.stack4.Controls.Add(this.label177);
            this.stack4.Controls.Add(this.label178);
            this.stack4.Controls.Add(this.label179);
            this.stack4.Controls.Add(this.label180);
            this.stack4.Controls.Add(this.label181);
            this.stack4.Controls.Add(this.label182);
            this.stack4.Controls.Add(this.label183);
            this.stack4.Controls.Add(this.label184);
            this.stack4.Controls.Add(this.label185);
            this.stack4.Controls.Add(this.label186);
            this.stack4.Controls.Add(this.label187);
            this.stack4.Controls.Add(this.label188);
            this.stack4.Controls.Add(this.label189);
            this.stack4.Controls.Add(this.label190);
            this.stack4.Controls.Add(this.label191);
            this.stack4.Controls.Add(this.label192);
            this.stack4.Controls.Add(this.label193);
            this.stack4.Controls.Add(this.label194);
            this.stack4.Controls.Add(this.label195);
            this.stack4.Controls.Add(this.label196);
            this.stack4.Controls.Add(this.label197);
            this.stack4.Controls.Add(this.label198);
            this.stack4.Controls.Add(this.label199);
            this.stack4.Controls.Add(this.label200);
            this.stack4.Controls.Add(this.label201);
            this.stack4.Controls.Add(this.label202);
            this.stack4.Controls.Add(this.label203);
            this.stack4.Controls.Add(this.label204);
            this.stack4.Controls.Add(this.label205);
            this.stack4.Controls.Add(this.label206);
            this.stack4.Controls.Add(this.label207);
            this.stack4.Controls.Add(this.textBox_142);
            this.stack4.Controls.Add(this.textBox_141);
            this.stack4.Controls.Add(this.label208);
            this.stack4.Controls.Add(this.textBox_144);
            this.stack4.Controls.Add(this.textBox_143);
            this.stack4.Controls.Add(this.label209);
            this.stack4.Controls.Add(this.textBox_138);
            this.stack4.Controls.Add(this.textBox_137);
            this.stack4.Controls.Add(this.label210);
            this.stack4.Controls.Add(this.textBox_136);
            this.stack4.Controls.Add(this.textBox_135);
            this.stack4.Controls.Add(this.label211);
            this.stack4.Controls.Add(this.textBox_134);
            this.stack4.Controls.Add(this.textBox_133);
            this.stack4.Controls.Add(this.label212);
            this.stack4.Controls.Add(this.textBox_140);
            this.stack4.Controls.Add(this.textBox_139);
            this.stack4.Controls.Add(this.label213);
            this.stack4.Controls.Add(this.textBox_130);
            this.stack4.Controls.Add(this.textBox_129);
            this.stack4.Controls.Add(this.label214);
            this.stack4.Controls.Add(this.textBox_132);
            this.stack4.Controls.Add(this.textBox_131);
            this.stack4.Controls.Add(this.label215);
            this.stack4.Controls.Add(this.textBox_126);
            this.stack4.Controls.Add(this.textBox_125);
            this.stack4.Controls.Add(this.label216);
            this.stack4.Controls.Add(this.textBox_124);
            this.stack4.Controls.Add(this.textBox_123);
            this.stack4.Controls.Add(this.label217);
            this.stack4.Controls.Add(this.textBox_122);
            this.stack4.Controls.Add(this.textBox_121);
            this.stack4.Controls.Add(this.label218);
            this.stack4.Controls.Add(this.textBox_128);
            this.stack4.Controls.Add(this.textBox_127);
            this.stack4.Controls.Add(this.label219);
            this.stack4.Controls.Add(this.textBox_118);
            this.stack4.Controls.Add(this.textBox_117);
            this.stack4.Controls.Add(this.label220);
            this.stack4.Controls.Add(this.textBox_120);
            this.stack4.Controls.Add(this.textBox_119);
            this.stack4.Controls.Add(this.label221);
            this.stack4.Controls.Add(this.textBox_114);
            this.stack4.Controls.Add(this.textBox_113);
            this.stack4.Controls.Add(this.label222);
            this.stack4.Controls.Add(this.textBox_112);
            this.stack4.Controls.Add(this.textBox_111);
            this.stack4.Controls.Add(this.label223);
            this.stack4.Controls.Add(this.textBox_110);
            this.stack4.Controls.Add(this.textBox_109);
            this.stack4.Controls.Add(this.label224);
            this.stack4.Controls.Add(this.textBox_116);
            this.stack4.Controls.Add(this.textBox_115);
            this.stack4.Location = new System.Drawing.Point(4, 39);
            this.stack4.Name = "stack4";
            this.stack4.Size = new System.Drawing.Size(1442, 910);
            this.stack4.TabIndex = 6;
            this.stack4.Text = "Stack 4";
            // 
            // stack_4u
            // 
            this.stack_4u.AutoSize = true;
            this.stack_4u.Font = new System.Drawing.Font("3ds Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stack_4u.Location = new System.Drawing.Point(460, 52);
            this.stack_4u.Name = "stack_4u";
            this.stack_4u.Size = new System.Drawing.Size(204, 36);
            this.stack_4u.TabIndex = 187;
            this.stack_4u.Text = "Stack voltage: -";
            // 
            // clear_4
            // 
            this.clear_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.clear_4.Location = new System.Drawing.Point(15, 52);
            this.clear_4.Name = "clear_4";
            this.clear_4.Size = new System.Drawing.Size(150, 60);
            this.clear_4.TabIndex = 184;
            this.clear_4.Text = "Clear";
            this.clear_4.UseVisualStyleBackColor = false;
            // 
            // label443
            // 
            this.label443.AutoSize = true;
            this.label443.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label443.Location = new System.Drawing.Point(10, 20);
            this.label443.Name = "label443";
            this.label443.Size = new System.Drawing.Size(86, 29);
            this.label443.TabIndex = 183;
            this.label443.Text = "Stack 4";
            // 
            // label171
            // 
            this.label171.AutoSize = true;
            this.label171.Location = new System.Drawing.Point(982, 687);
            this.label171.Name = "label171";
            this.label171.Size = new System.Drawing.Size(35, 30);
            this.label171.TabIndex = 182;
            this.label171.Text = "°C";
            // 
            // label172
            // 
            this.label172.AutoSize = true;
            this.label172.Location = new System.Drawing.Point(989, 659);
            this.label172.Name = "label172";
            this.label172.Size = new System.Drawing.Size(26, 30);
            this.label172.TabIndex = 181;
            this.label172.Text = "V";
            // 
            // label173
            // 
            this.label173.AutoSize = true;
            this.label173.Location = new System.Drawing.Point(982, 587);
            this.label173.Name = "label173";
            this.label173.Size = new System.Drawing.Size(35, 30);
            this.label173.TabIndex = 180;
            this.label173.Text = "°C";
            // 
            // label174
            // 
            this.label174.AutoSize = true;
            this.label174.Location = new System.Drawing.Point(989, 559);
            this.label174.Name = "label174";
            this.label174.Size = new System.Drawing.Size(26, 30);
            this.label174.TabIndex = 179;
            this.label174.Text = "V";
            // 
            // label175
            // 
            this.label175.AutoSize = true;
            this.label175.Location = new System.Drawing.Point(982, 487);
            this.label175.Name = "label175";
            this.label175.Size = new System.Drawing.Size(35, 30);
            this.label175.TabIndex = 178;
            this.label175.Text = "°C";
            // 
            // label176
            // 
            this.label176.AutoSize = true;
            this.label176.Location = new System.Drawing.Point(989, 459);
            this.label176.Name = "label176";
            this.label176.Size = new System.Drawing.Size(26, 30);
            this.label176.TabIndex = 177;
            this.label176.Text = "V";
            // 
            // label177
            // 
            this.label177.AutoSize = true;
            this.label177.Location = new System.Drawing.Point(982, 387);
            this.label177.Name = "label177";
            this.label177.Size = new System.Drawing.Size(35, 30);
            this.label177.TabIndex = 176;
            this.label177.Text = "°C";
            // 
            // label178
            // 
            this.label178.AutoSize = true;
            this.label178.Location = new System.Drawing.Point(989, 359);
            this.label178.Name = "label178";
            this.label178.Size = new System.Drawing.Size(26, 30);
            this.label178.TabIndex = 175;
            this.label178.Text = "V";
            // 
            // label179
            // 
            this.label179.AutoSize = true;
            this.label179.Location = new System.Drawing.Point(982, 287);
            this.label179.Name = "label179";
            this.label179.Size = new System.Drawing.Size(35, 30);
            this.label179.TabIndex = 174;
            this.label179.Text = "°C";
            // 
            // label180
            // 
            this.label180.AutoSize = true;
            this.label180.Location = new System.Drawing.Point(989, 259);
            this.label180.Name = "label180";
            this.label180.Size = new System.Drawing.Size(26, 30);
            this.label180.TabIndex = 173;
            this.label180.Text = "V";
            // 
            // label181
            // 
            this.label181.AutoSize = true;
            this.label181.Location = new System.Drawing.Point(982, 191);
            this.label181.Name = "label181";
            this.label181.Size = new System.Drawing.Size(35, 30);
            this.label181.TabIndex = 172;
            this.label181.Text = "°C";
            // 
            // label182
            // 
            this.label182.AutoSize = true;
            this.label182.Location = new System.Drawing.Point(989, 163);
            this.label182.Name = "label182";
            this.label182.Size = new System.Drawing.Size(26, 30);
            this.label182.TabIndex = 171;
            this.label182.Text = "V";
            // 
            // label183
            // 
            this.label183.AutoSize = true;
            this.label183.Location = new System.Drawing.Point(632, 687);
            this.label183.Name = "label183";
            this.label183.Size = new System.Drawing.Size(35, 30);
            this.label183.TabIndex = 170;
            this.label183.Text = "°C";
            // 
            // label184
            // 
            this.label184.AutoSize = true;
            this.label184.Location = new System.Drawing.Point(639, 659);
            this.label184.Name = "label184";
            this.label184.Size = new System.Drawing.Size(26, 30);
            this.label184.TabIndex = 169;
            this.label184.Text = "V";
            // 
            // label185
            // 
            this.label185.AutoSize = true;
            this.label185.Location = new System.Drawing.Point(632, 587);
            this.label185.Name = "label185";
            this.label185.Size = new System.Drawing.Size(35, 30);
            this.label185.TabIndex = 168;
            this.label185.Text = "°C";
            // 
            // label186
            // 
            this.label186.AutoSize = true;
            this.label186.Location = new System.Drawing.Point(639, 559);
            this.label186.Name = "label186";
            this.label186.Size = new System.Drawing.Size(26, 30);
            this.label186.TabIndex = 167;
            this.label186.Text = "V";
            // 
            // label187
            // 
            this.label187.AutoSize = true;
            this.label187.Location = new System.Drawing.Point(632, 487);
            this.label187.Name = "label187";
            this.label187.Size = new System.Drawing.Size(35, 30);
            this.label187.TabIndex = 166;
            this.label187.Text = "°C";
            // 
            // label188
            // 
            this.label188.AutoSize = true;
            this.label188.Location = new System.Drawing.Point(639, 459);
            this.label188.Name = "label188";
            this.label188.Size = new System.Drawing.Size(26, 30);
            this.label188.TabIndex = 165;
            this.label188.Text = "V";
            // 
            // label189
            // 
            this.label189.AutoSize = true;
            this.label189.Location = new System.Drawing.Point(632, 387);
            this.label189.Name = "label189";
            this.label189.Size = new System.Drawing.Size(35, 30);
            this.label189.TabIndex = 164;
            this.label189.Text = "°C";
            // 
            // label190
            // 
            this.label190.AutoSize = true;
            this.label190.Location = new System.Drawing.Point(639, 359);
            this.label190.Name = "label190";
            this.label190.Size = new System.Drawing.Size(26, 30);
            this.label190.TabIndex = 163;
            this.label190.Text = "V";
            // 
            // label191
            // 
            this.label191.AutoSize = true;
            this.label191.Location = new System.Drawing.Point(632, 287);
            this.label191.Name = "label191";
            this.label191.Size = new System.Drawing.Size(35, 30);
            this.label191.TabIndex = 162;
            this.label191.Text = "°C";
            // 
            // label192
            // 
            this.label192.AutoSize = true;
            this.label192.Location = new System.Drawing.Point(639, 259);
            this.label192.Name = "label192";
            this.label192.Size = new System.Drawing.Size(26, 30);
            this.label192.TabIndex = 161;
            this.label192.Text = "V";
            // 
            // label193
            // 
            this.label193.AutoSize = true;
            this.label193.Location = new System.Drawing.Point(632, 187);
            this.label193.Name = "label193";
            this.label193.Size = new System.Drawing.Size(35, 30);
            this.label193.TabIndex = 160;
            this.label193.Text = "°C";
            // 
            // label194
            // 
            this.label194.AutoSize = true;
            this.label194.Location = new System.Drawing.Point(639, 159);
            this.label194.Name = "label194";
            this.label194.Size = new System.Drawing.Size(26, 30);
            this.label194.TabIndex = 159;
            this.label194.Text = "V";
            // 
            // label195
            // 
            this.label195.AutoSize = true;
            this.label195.Location = new System.Drawing.Point(282, 687);
            this.label195.Name = "label195";
            this.label195.Size = new System.Drawing.Size(35, 30);
            this.label195.TabIndex = 158;
            this.label195.Text = "°C";
            // 
            // label196
            // 
            this.label196.AutoSize = true;
            this.label196.Location = new System.Drawing.Point(289, 659);
            this.label196.Name = "label196";
            this.label196.Size = new System.Drawing.Size(26, 30);
            this.label196.TabIndex = 157;
            this.label196.Text = "V";
            // 
            // label197
            // 
            this.label197.AutoSize = true;
            this.label197.Location = new System.Drawing.Point(282, 587);
            this.label197.Name = "label197";
            this.label197.Size = new System.Drawing.Size(35, 30);
            this.label197.TabIndex = 156;
            this.label197.Text = "°C";
            // 
            // label198
            // 
            this.label198.AutoSize = true;
            this.label198.Location = new System.Drawing.Point(289, 559);
            this.label198.Name = "label198";
            this.label198.Size = new System.Drawing.Size(26, 30);
            this.label198.TabIndex = 155;
            this.label198.Text = "V";
            // 
            // label199
            // 
            this.label199.AutoSize = true;
            this.label199.Location = new System.Drawing.Point(282, 487);
            this.label199.Name = "label199";
            this.label199.Size = new System.Drawing.Size(35, 30);
            this.label199.TabIndex = 154;
            this.label199.Text = "°C";
            // 
            // label200
            // 
            this.label200.AutoSize = true;
            this.label200.Location = new System.Drawing.Point(289, 459);
            this.label200.Name = "label200";
            this.label200.Size = new System.Drawing.Size(26, 30);
            this.label200.TabIndex = 153;
            this.label200.Text = "V";
            // 
            // label201
            // 
            this.label201.AutoSize = true;
            this.label201.Location = new System.Drawing.Point(282, 387);
            this.label201.Name = "label201";
            this.label201.Size = new System.Drawing.Size(35, 30);
            this.label201.TabIndex = 152;
            this.label201.Text = "°C";
            // 
            // label202
            // 
            this.label202.AutoSize = true;
            this.label202.Location = new System.Drawing.Point(289, 359);
            this.label202.Name = "label202";
            this.label202.Size = new System.Drawing.Size(26, 30);
            this.label202.TabIndex = 151;
            this.label202.Text = "V";
            // 
            // label203
            // 
            this.label203.AutoSize = true;
            this.label203.Location = new System.Drawing.Point(282, 287);
            this.label203.Name = "label203";
            this.label203.Size = new System.Drawing.Size(35, 30);
            this.label203.TabIndex = 150;
            this.label203.Text = "°C";
            // 
            // label204
            // 
            this.label204.AutoSize = true;
            this.label204.Location = new System.Drawing.Point(289, 259);
            this.label204.Name = "label204";
            this.label204.Size = new System.Drawing.Size(26, 30);
            this.label204.TabIndex = 149;
            this.label204.Text = "V";
            // 
            // label205
            // 
            this.label205.AutoSize = true;
            this.label205.Location = new System.Drawing.Point(282, 187);
            this.label205.Name = "label205";
            this.label205.Size = new System.Drawing.Size(35, 30);
            this.label205.TabIndex = 148;
            this.label205.Text = "°C";
            // 
            // label206
            // 
            this.label206.AutoSize = true;
            this.label206.Location = new System.Drawing.Point(289, 159);
            this.label206.Name = "label206";
            this.label206.Size = new System.Drawing.Size(26, 30);
            this.label206.TabIndex = 147;
            this.label206.Text = "V";
            // 
            // label207
            // 
            this.label207.AutoSize = true;
            this.label207.Location = new System.Drawing.Point(798, 575);
            this.label207.Name = "label207";
            this.label207.Size = new System.Drawing.Size(84, 30);
            this.label207.TabIndex = 146;
            this.label207.Text = "Cell 17";
            // 
            // textBox_142
            // 
            this.textBox_142.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_142.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_142.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_142.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_142.Location = new System.Drawing.Point(901, 592);
            this.textBox_142.Multiline = true;
            this.textBox_142.Name = "textBox_142";
            this.textBox_142.ReadOnly = true;
            this.textBox_142.Size = new System.Drawing.Size(75, 25);
            this.textBox_142.TabIndex = 145;
            this.textBox_142.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_141
            // 
            this.textBox_141.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_141.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_141.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_141.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_141.Location = new System.Drawing.Point(901, 561);
            this.textBox_141.Multiline = true;
            this.textBox_141.Name = "textBox_141";
            this.textBox_141.ReadOnly = true;
            this.textBox_141.Size = new System.Drawing.Size(75, 25);
            this.textBox_141.TabIndex = 144;
            this.textBox_141.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label208
            // 
            this.label208.AutoSize = true;
            this.label208.Location = new System.Drawing.Point(798, 671);
            this.label208.Name = "label208";
            this.label208.Size = new System.Drawing.Size(84, 30);
            this.label208.TabIndex = 143;
            this.label208.Text = "Cell 18";
            // 
            // textBox_144
            // 
            this.textBox_144.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_144.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_144.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_144.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_144.Location = new System.Drawing.Point(901, 692);
            this.textBox_144.Multiline = true;
            this.textBox_144.Name = "textBox_144";
            this.textBox_144.ReadOnly = true;
            this.textBox_144.Size = new System.Drawing.Size(75, 25);
            this.textBox_144.TabIndex = 142;
            this.textBox_144.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_143
            // 
            this.textBox_143.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_143.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_143.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_143.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_143.Location = new System.Drawing.Point(901, 661);
            this.textBox_143.Multiline = true;
            this.textBox_143.Name = "textBox_143";
            this.textBox_143.ReadOnly = true;
            this.textBox_143.Size = new System.Drawing.Size(75, 25);
            this.textBox_143.TabIndex = 141;
            this.textBox_143.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label209
            // 
            this.label209.AutoSize = true;
            this.label209.Location = new System.Drawing.Point(798, 375);
            this.label209.Name = "label209";
            this.label209.Size = new System.Drawing.Size(84, 30);
            this.label209.TabIndex = 140;
            this.label209.Text = "Cell 15";
            // 
            // textBox_138
            // 
            this.textBox_138.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_138.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_138.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_138.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_138.Location = new System.Drawing.Point(901, 392);
            this.textBox_138.Multiline = true;
            this.textBox_138.Name = "textBox_138";
            this.textBox_138.ReadOnly = true;
            this.textBox_138.Size = new System.Drawing.Size(75, 25);
            this.textBox_138.TabIndex = 139;
            this.textBox_138.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_137
            // 
            this.textBox_137.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_137.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_137.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_137.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_137.Location = new System.Drawing.Point(901, 361);
            this.textBox_137.Multiline = true;
            this.textBox_137.Name = "textBox_137";
            this.textBox_137.ReadOnly = true;
            this.textBox_137.Size = new System.Drawing.Size(75, 25);
            this.textBox_137.TabIndex = 138;
            this.textBox_137.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label210
            // 
            this.label210.AutoSize = true;
            this.label210.Location = new System.Drawing.Point(798, 275);
            this.label210.Name = "label210";
            this.label210.Size = new System.Drawing.Size(84, 30);
            this.label210.TabIndex = 137;
            this.label210.Text = "Cell 14";
            // 
            // textBox_136
            // 
            this.textBox_136.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_136.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_136.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_136.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_136.Location = new System.Drawing.Point(901, 292);
            this.textBox_136.Multiline = true;
            this.textBox_136.Name = "textBox_136";
            this.textBox_136.ReadOnly = true;
            this.textBox_136.Size = new System.Drawing.Size(75, 25);
            this.textBox_136.TabIndex = 136;
            this.textBox_136.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_135
            // 
            this.textBox_135.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_135.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_135.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_135.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_135.Location = new System.Drawing.Point(901, 261);
            this.textBox_135.Multiline = true;
            this.textBox_135.Name = "textBox_135";
            this.textBox_135.ReadOnly = true;
            this.textBox_135.Size = new System.Drawing.Size(75, 25);
            this.textBox_135.TabIndex = 135;
            this.textBox_135.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label211
            // 
            this.label211.AutoSize = true;
            this.label211.Location = new System.Drawing.Point(798, 174);
            this.label211.Name = "label211";
            this.label211.Size = new System.Drawing.Size(84, 30);
            this.label211.TabIndex = 134;
            this.label211.Text = "Cell 13";
            // 
            // textBox_134
            // 
            this.textBox_134.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_134.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_134.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_134.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_134.Location = new System.Drawing.Point(901, 192);
            this.textBox_134.Multiline = true;
            this.textBox_134.Name = "textBox_134";
            this.textBox_134.ReadOnly = true;
            this.textBox_134.Size = new System.Drawing.Size(75, 25);
            this.textBox_134.TabIndex = 133;
            this.textBox_134.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_133
            // 
            this.textBox_133.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_133.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_133.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_133.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_133.Location = new System.Drawing.Point(901, 161);
            this.textBox_133.Multiline = true;
            this.textBox_133.Name = "textBox_133";
            this.textBox_133.ReadOnly = true;
            this.textBox_133.Size = new System.Drawing.Size(75, 25);
            this.textBox_133.TabIndex = 132;
            this.textBox_133.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label212
            // 
            this.label212.AutoSize = true;
            this.label212.Location = new System.Drawing.Point(798, 474);
            this.label212.Name = "label212";
            this.label212.Size = new System.Drawing.Size(84, 30);
            this.label212.TabIndex = 131;
            this.label212.Text = "Cell 16";
            // 
            // textBox_140
            // 
            this.textBox_140.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_140.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_140.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_140.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_140.Location = new System.Drawing.Point(901, 492);
            this.textBox_140.Multiline = true;
            this.textBox_140.Name = "textBox_140";
            this.textBox_140.ReadOnly = true;
            this.textBox_140.Size = new System.Drawing.Size(75, 25);
            this.textBox_140.TabIndex = 130;
            this.textBox_140.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_139
            // 
            this.textBox_139.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_139.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_139.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_139.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_139.Location = new System.Drawing.Point(901, 461);
            this.textBox_139.Multiline = true;
            this.textBox_139.Name = "textBox_139";
            this.textBox_139.ReadOnly = true;
            this.textBox_139.Size = new System.Drawing.Size(75, 25);
            this.textBox_139.TabIndex = 129;
            this.textBox_139.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label213
            // 
            this.label213.AutoSize = true;
            this.label213.Location = new System.Drawing.Point(461, 575);
            this.label213.Name = "label213";
            this.label213.Size = new System.Drawing.Size(84, 30);
            this.label213.TabIndex = 128;
            this.label213.Text = "Cell 11";
            // 
            // textBox_130
            // 
            this.textBox_130.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_130.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_130.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_130.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_130.Location = new System.Drawing.Point(551, 592);
            this.textBox_130.Multiline = true;
            this.textBox_130.Name = "textBox_130";
            this.textBox_130.ReadOnly = true;
            this.textBox_130.Size = new System.Drawing.Size(75, 25);
            this.textBox_130.TabIndex = 127;
            this.textBox_130.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_129
            // 
            this.textBox_129.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_129.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_129.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_129.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_129.Location = new System.Drawing.Point(551, 561);
            this.textBox_129.Multiline = true;
            this.textBox_129.Name = "textBox_129";
            this.textBox_129.ReadOnly = true;
            this.textBox_129.Size = new System.Drawing.Size(75, 25);
            this.textBox_129.TabIndex = 126;
            this.textBox_129.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label214
            // 
            this.label214.AutoSize = true;
            this.label214.Location = new System.Drawing.Point(461, 671);
            this.label214.Name = "label214";
            this.label214.Size = new System.Drawing.Size(84, 30);
            this.label214.TabIndex = 125;
            this.label214.Text = "Cell 12";
            // 
            // textBox_132
            // 
            this.textBox_132.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_132.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_132.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_132.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_132.Location = new System.Drawing.Point(551, 692);
            this.textBox_132.Multiline = true;
            this.textBox_132.Name = "textBox_132";
            this.textBox_132.ReadOnly = true;
            this.textBox_132.Size = new System.Drawing.Size(75, 25);
            this.textBox_132.TabIndex = 124;
            this.textBox_132.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_131
            // 
            this.textBox_131.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_131.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_131.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_131.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_131.Location = new System.Drawing.Point(551, 661);
            this.textBox_131.Multiline = true;
            this.textBox_131.Name = "textBox_131";
            this.textBox_131.ReadOnly = true;
            this.textBox_131.Size = new System.Drawing.Size(75, 25);
            this.textBox_131.TabIndex = 123;
            this.textBox_131.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label215
            // 
            this.label215.AutoSize = true;
            this.label215.Location = new System.Drawing.Point(461, 375);
            this.label215.Name = "label215";
            this.label215.Size = new System.Drawing.Size(70, 30);
            this.label215.TabIndex = 122;
            this.label215.Text = "Cell 9";
            // 
            // textBox_126
            // 
            this.textBox_126.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_126.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_126.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_126.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_126.Location = new System.Drawing.Point(551, 392);
            this.textBox_126.Multiline = true;
            this.textBox_126.Name = "textBox_126";
            this.textBox_126.ReadOnly = true;
            this.textBox_126.Size = new System.Drawing.Size(75, 25);
            this.textBox_126.TabIndex = 121;
            this.textBox_126.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_125
            // 
            this.textBox_125.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_125.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_125.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_125.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_125.Location = new System.Drawing.Point(551, 361);
            this.textBox_125.Multiline = true;
            this.textBox_125.Name = "textBox_125";
            this.textBox_125.ReadOnly = true;
            this.textBox_125.Size = new System.Drawing.Size(75, 25);
            this.textBox_125.TabIndex = 120;
            this.textBox_125.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label216
            // 
            this.label216.AutoSize = true;
            this.label216.Location = new System.Drawing.Point(461, 275);
            this.label216.Name = "label216";
            this.label216.Size = new System.Drawing.Size(70, 30);
            this.label216.TabIndex = 119;
            this.label216.Text = "Cell 8";
            // 
            // textBox_124
            // 
            this.textBox_124.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_124.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_124.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_124.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_124.Location = new System.Drawing.Point(551, 292);
            this.textBox_124.Multiline = true;
            this.textBox_124.Name = "textBox_124";
            this.textBox_124.ReadOnly = true;
            this.textBox_124.Size = new System.Drawing.Size(75, 25);
            this.textBox_124.TabIndex = 118;
            this.textBox_124.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_123
            // 
            this.textBox_123.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_123.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_123.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_123.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_123.Location = new System.Drawing.Point(551, 261);
            this.textBox_123.Multiline = true;
            this.textBox_123.Name = "textBox_123";
            this.textBox_123.ReadOnly = true;
            this.textBox_123.Size = new System.Drawing.Size(75, 25);
            this.textBox_123.TabIndex = 117;
            this.textBox_123.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label217
            // 
            this.label217.AutoSize = true;
            this.label217.Location = new System.Drawing.Point(461, 174);
            this.label217.Name = "label217";
            this.label217.Size = new System.Drawing.Size(70, 30);
            this.label217.TabIndex = 116;
            this.label217.Text = "Cell 7";
            // 
            // textBox_122
            // 
            this.textBox_122.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_122.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_122.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_122.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_122.Location = new System.Drawing.Point(551, 192);
            this.textBox_122.Multiline = true;
            this.textBox_122.Name = "textBox_122";
            this.textBox_122.ReadOnly = true;
            this.textBox_122.Size = new System.Drawing.Size(75, 25);
            this.textBox_122.TabIndex = 115;
            this.textBox_122.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_121
            // 
            this.textBox_121.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_121.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_121.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_121.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_121.Location = new System.Drawing.Point(551, 161);
            this.textBox_121.Multiline = true;
            this.textBox_121.Name = "textBox_121";
            this.textBox_121.ReadOnly = true;
            this.textBox_121.Size = new System.Drawing.Size(75, 25);
            this.textBox_121.TabIndex = 114;
            this.textBox_121.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label218
            // 
            this.label218.AutoSize = true;
            this.label218.Location = new System.Drawing.Point(461, 474);
            this.label218.Name = "label218";
            this.label218.Size = new System.Drawing.Size(84, 30);
            this.label218.TabIndex = 113;
            this.label218.Text = "Cell 10";
            // 
            // textBox_128
            // 
            this.textBox_128.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_128.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_128.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_128.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_128.Location = new System.Drawing.Point(551, 492);
            this.textBox_128.Multiline = true;
            this.textBox_128.Name = "textBox_128";
            this.textBox_128.ReadOnly = true;
            this.textBox_128.Size = new System.Drawing.Size(75, 25);
            this.textBox_128.TabIndex = 112;
            this.textBox_128.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_127
            // 
            this.textBox_127.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_127.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_127.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_127.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_127.Location = new System.Drawing.Point(551, 461);
            this.textBox_127.Multiline = true;
            this.textBox_127.Name = "textBox_127";
            this.textBox_127.ReadOnly = true;
            this.textBox_127.Size = new System.Drawing.Size(75, 25);
            this.textBox_127.TabIndex = 111;
            this.textBox_127.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label219
            // 
            this.label219.AutoSize = true;
            this.label219.Location = new System.Drawing.Point(125, 575);
            this.label219.Name = "label219";
            this.label219.Size = new System.Drawing.Size(70, 30);
            this.label219.TabIndex = 110;
            this.label219.Text = "Cell 5";
            // 
            // textBox_118
            // 
            this.textBox_118.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_118.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_118.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_118.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_118.Location = new System.Drawing.Point(201, 592);
            this.textBox_118.Multiline = true;
            this.textBox_118.Name = "textBox_118";
            this.textBox_118.ReadOnly = true;
            this.textBox_118.Size = new System.Drawing.Size(75, 25);
            this.textBox_118.TabIndex = 109;
            this.textBox_118.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_117
            // 
            this.textBox_117.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_117.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_117.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_117.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_117.Location = new System.Drawing.Point(201, 561);
            this.textBox_117.Multiline = true;
            this.textBox_117.Name = "textBox_117";
            this.textBox_117.ReadOnly = true;
            this.textBox_117.Size = new System.Drawing.Size(75, 25);
            this.textBox_117.TabIndex = 108;
            this.textBox_117.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label220
            // 
            this.label220.AutoSize = true;
            this.label220.Location = new System.Drawing.Point(125, 671);
            this.label220.Name = "label220";
            this.label220.Size = new System.Drawing.Size(70, 30);
            this.label220.TabIndex = 107;
            this.label220.Text = "Cell 6";
            // 
            // textBox_120
            // 
            this.textBox_120.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_120.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_120.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_120.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_120.Location = new System.Drawing.Point(201, 692);
            this.textBox_120.Multiline = true;
            this.textBox_120.Name = "textBox_120";
            this.textBox_120.ReadOnly = true;
            this.textBox_120.Size = new System.Drawing.Size(75, 25);
            this.textBox_120.TabIndex = 106;
            this.textBox_120.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_119
            // 
            this.textBox_119.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_119.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_119.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_119.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_119.Location = new System.Drawing.Point(201, 661);
            this.textBox_119.Multiline = true;
            this.textBox_119.Name = "textBox_119";
            this.textBox_119.ReadOnly = true;
            this.textBox_119.Size = new System.Drawing.Size(75, 25);
            this.textBox_119.TabIndex = 105;
            this.textBox_119.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label221
            // 
            this.label221.AutoSize = true;
            this.label221.Location = new System.Drawing.Point(125, 375);
            this.label221.Name = "label221";
            this.label221.Size = new System.Drawing.Size(70, 30);
            this.label221.TabIndex = 104;
            this.label221.Text = "Cell 3";
            // 
            // textBox_114
            // 
            this.textBox_114.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_114.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_114.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_114.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_114.Location = new System.Drawing.Point(201, 392);
            this.textBox_114.Multiline = true;
            this.textBox_114.Name = "textBox_114";
            this.textBox_114.ReadOnly = true;
            this.textBox_114.Size = new System.Drawing.Size(75, 25);
            this.textBox_114.TabIndex = 103;
            this.textBox_114.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_113
            // 
            this.textBox_113.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_113.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_113.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_113.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_113.Location = new System.Drawing.Point(201, 361);
            this.textBox_113.Multiline = true;
            this.textBox_113.Name = "textBox_113";
            this.textBox_113.ReadOnly = true;
            this.textBox_113.Size = new System.Drawing.Size(75, 25);
            this.textBox_113.TabIndex = 102;
            this.textBox_113.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label222
            // 
            this.label222.AutoSize = true;
            this.label222.Location = new System.Drawing.Point(125, 275);
            this.label222.Name = "label222";
            this.label222.Size = new System.Drawing.Size(70, 30);
            this.label222.TabIndex = 101;
            this.label222.Text = "Cell 2";
            // 
            // textBox_112
            // 
            this.textBox_112.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_112.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_112.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_112.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_112.Location = new System.Drawing.Point(201, 292);
            this.textBox_112.Multiline = true;
            this.textBox_112.Name = "textBox_112";
            this.textBox_112.ReadOnly = true;
            this.textBox_112.Size = new System.Drawing.Size(75, 25);
            this.textBox_112.TabIndex = 100;
            this.textBox_112.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_111
            // 
            this.textBox_111.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_111.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_111.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_111.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_111.Location = new System.Drawing.Point(201, 261);
            this.textBox_111.Multiline = true;
            this.textBox_111.Name = "textBox_111";
            this.textBox_111.ReadOnly = true;
            this.textBox_111.Size = new System.Drawing.Size(75, 25);
            this.textBox_111.TabIndex = 99;
            this.textBox_111.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label223
            // 
            this.label223.AutoSize = true;
            this.label223.Location = new System.Drawing.Point(125, 174);
            this.label223.Name = "label223";
            this.label223.Size = new System.Drawing.Size(70, 30);
            this.label223.TabIndex = 98;
            this.label223.Text = "Cell 1";
            // 
            // textBox_110
            // 
            this.textBox_110.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_110.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_110.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_110.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_110.Location = new System.Drawing.Point(201, 192);
            this.textBox_110.Multiline = true;
            this.textBox_110.Name = "textBox_110";
            this.textBox_110.ReadOnly = true;
            this.textBox_110.Size = new System.Drawing.Size(75, 25);
            this.textBox_110.TabIndex = 97;
            this.textBox_110.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_109
            // 
            this.textBox_109.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_109.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_109.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_109.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_109.Location = new System.Drawing.Point(201, 161);
            this.textBox_109.Multiline = true;
            this.textBox_109.Name = "textBox_109";
            this.textBox_109.ReadOnly = true;
            this.textBox_109.Size = new System.Drawing.Size(75, 25);
            this.textBox_109.TabIndex = 96;
            this.textBox_109.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label224
            // 
            this.label224.AutoSize = true;
            this.label224.Location = new System.Drawing.Point(125, 474);
            this.label224.Name = "label224";
            this.label224.Size = new System.Drawing.Size(70, 30);
            this.label224.TabIndex = 95;
            this.label224.Text = "Cell 4";
            // 
            // textBox_116
            // 
            this.textBox_116.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_116.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_116.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_116.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_116.Location = new System.Drawing.Point(201, 492);
            this.textBox_116.Multiline = true;
            this.textBox_116.Name = "textBox_116";
            this.textBox_116.ReadOnly = true;
            this.textBox_116.Size = new System.Drawing.Size(75, 25);
            this.textBox_116.TabIndex = 94;
            this.textBox_116.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_115
            // 
            this.textBox_115.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_115.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_115.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_115.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_115.Location = new System.Drawing.Point(201, 461);
            this.textBox_115.Multiline = true;
            this.textBox_115.Name = "textBox_115";
            this.textBox_115.ReadOnly = true;
            this.textBox_115.Size = new System.Drawing.Size(75, 25);
            this.textBox_115.TabIndex = 93;
            this.textBox_115.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stack5
            // 
            this.stack5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.stack5.Controls.Add(this.stack_5u);
            this.stack5.Controls.Add(this.clear_5);
            this.stack5.Controls.Add(this.label444);
            this.stack5.Controls.Add(this.label225);
            this.stack5.Controls.Add(this.label226);
            this.stack5.Controls.Add(this.label227);
            this.stack5.Controls.Add(this.label228);
            this.stack5.Controls.Add(this.label229);
            this.stack5.Controls.Add(this.label230);
            this.stack5.Controls.Add(this.label231);
            this.stack5.Controls.Add(this.label232);
            this.stack5.Controls.Add(this.label233);
            this.stack5.Controls.Add(this.label234);
            this.stack5.Controls.Add(this.label235);
            this.stack5.Controls.Add(this.label236);
            this.stack5.Controls.Add(this.label237);
            this.stack5.Controls.Add(this.label238);
            this.stack5.Controls.Add(this.label239);
            this.stack5.Controls.Add(this.label240);
            this.stack5.Controls.Add(this.label241);
            this.stack5.Controls.Add(this.label242);
            this.stack5.Controls.Add(this.label243);
            this.stack5.Controls.Add(this.label244);
            this.stack5.Controls.Add(this.label245);
            this.stack5.Controls.Add(this.label246);
            this.stack5.Controls.Add(this.label247);
            this.stack5.Controls.Add(this.label248);
            this.stack5.Controls.Add(this.label249);
            this.stack5.Controls.Add(this.label250);
            this.stack5.Controls.Add(this.label251);
            this.stack5.Controls.Add(this.label252);
            this.stack5.Controls.Add(this.label253);
            this.stack5.Controls.Add(this.label254);
            this.stack5.Controls.Add(this.label255);
            this.stack5.Controls.Add(this.label256);
            this.stack5.Controls.Add(this.label257);
            this.stack5.Controls.Add(this.label258);
            this.stack5.Controls.Add(this.label259);
            this.stack5.Controls.Add(this.label260);
            this.stack5.Controls.Add(this.label261);
            this.stack5.Controls.Add(this.textBox_178);
            this.stack5.Controls.Add(this.textBox_177);
            this.stack5.Controls.Add(this.label262);
            this.stack5.Controls.Add(this.textBox_180);
            this.stack5.Controls.Add(this.textBox_179);
            this.stack5.Controls.Add(this.label263);
            this.stack5.Controls.Add(this.textBox_174);
            this.stack5.Controls.Add(this.textBox_173);
            this.stack5.Controls.Add(this.label264);
            this.stack5.Controls.Add(this.textBox_172);
            this.stack5.Controls.Add(this.textBox_171);
            this.stack5.Controls.Add(this.label265);
            this.stack5.Controls.Add(this.textBox_170);
            this.stack5.Controls.Add(this.textBox_169);
            this.stack5.Controls.Add(this.label266);
            this.stack5.Controls.Add(this.textBox_176);
            this.stack5.Controls.Add(this.textBox_175);
            this.stack5.Controls.Add(this.label267);
            this.stack5.Controls.Add(this.textBox_166);
            this.stack5.Controls.Add(this.textBox_165);
            this.stack5.Controls.Add(this.label268);
            this.stack5.Controls.Add(this.textBox_168);
            this.stack5.Controls.Add(this.textBox_167);
            this.stack5.Controls.Add(this.label269);
            this.stack5.Controls.Add(this.textBox_162);
            this.stack5.Controls.Add(this.textBox_161);
            this.stack5.Controls.Add(this.label270);
            this.stack5.Controls.Add(this.textBox_160);
            this.stack5.Controls.Add(this.textBox_159);
            this.stack5.Controls.Add(this.label271);
            this.stack5.Controls.Add(this.textBox_158);
            this.stack5.Controls.Add(this.textBox_157);
            this.stack5.Controls.Add(this.label272);
            this.stack5.Controls.Add(this.textBox_164);
            this.stack5.Controls.Add(this.textBox_163);
            this.stack5.Controls.Add(this.label273);
            this.stack5.Controls.Add(this.textBox_154);
            this.stack5.Controls.Add(this.textBox_153);
            this.stack5.Controls.Add(this.label274);
            this.stack5.Controls.Add(this.textBox_156);
            this.stack5.Controls.Add(this.textBox_155);
            this.stack5.Controls.Add(this.label275);
            this.stack5.Controls.Add(this.textBox_150);
            this.stack5.Controls.Add(this.textBox_149);
            this.stack5.Controls.Add(this.label276);
            this.stack5.Controls.Add(this.textBox_148);
            this.stack5.Controls.Add(this.textBox_147);
            this.stack5.Controls.Add(this.label277);
            this.stack5.Controls.Add(this.textBox_146);
            this.stack5.Controls.Add(this.textBox_145);
            this.stack5.Controls.Add(this.label278);
            this.stack5.Controls.Add(this.textBox_152);
            this.stack5.Controls.Add(this.textBox_151);
            this.stack5.Location = new System.Drawing.Point(4, 39);
            this.stack5.Name = "stack5";
            this.stack5.Size = new System.Drawing.Size(1442, 910);
            this.stack5.TabIndex = 7;
            this.stack5.Text = "Stack 5";
            // 
            // stack_5u
            // 
            this.stack_5u.AutoSize = true;
            this.stack_5u.Font = new System.Drawing.Font("3ds Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stack_5u.Location = new System.Drawing.Point(460, 52);
            this.stack_5u.Name = "stack_5u";
            this.stack_5u.Size = new System.Drawing.Size(204, 36);
            this.stack_5u.TabIndex = 187;
            this.stack_5u.Text = "Stack voltage: -";
            // 
            // clear_5
            // 
            this.clear_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.clear_5.Location = new System.Drawing.Point(15, 52);
            this.clear_5.Name = "clear_5";
            this.clear_5.Size = new System.Drawing.Size(150, 60);
            this.clear_5.TabIndex = 185;
            this.clear_5.Text = "Clear";
            this.clear_5.UseVisualStyleBackColor = false;
            // 
            // label444
            // 
            this.label444.AutoSize = true;
            this.label444.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label444.Location = new System.Drawing.Point(10, 20);
            this.label444.Name = "label444";
            this.label444.Size = new System.Drawing.Size(86, 29);
            this.label444.TabIndex = 183;
            this.label444.Text = "Stack 5";
            // 
            // label225
            // 
            this.label225.AutoSize = true;
            this.label225.Location = new System.Drawing.Point(982, 687);
            this.label225.Name = "label225";
            this.label225.Size = new System.Drawing.Size(35, 30);
            this.label225.TabIndex = 182;
            this.label225.Text = "°C";
            // 
            // label226
            // 
            this.label226.AutoSize = true;
            this.label226.Location = new System.Drawing.Point(989, 659);
            this.label226.Name = "label226";
            this.label226.Size = new System.Drawing.Size(26, 30);
            this.label226.TabIndex = 181;
            this.label226.Text = "V";
            // 
            // label227
            // 
            this.label227.AutoSize = true;
            this.label227.Location = new System.Drawing.Point(982, 587);
            this.label227.Name = "label227";
            this.label227.Size = new System.Drawing.Size(35, 30);
            this.label227.TabIndex = 180;
            this.label227.Text = "°C";
            // 
            // label228
            // 
            this.label228.AutoSize = true;
            this.label228.Location = new System.Drawing.Point(989, 559);
            this.label228.Name = "label228";
            this.label228.Size = new System.Drawing.Size(26, 30);
            this.label228.TabIndex = 179;
            this.label228.Text = "V";
            // 
            // label229
            // 
            this.label229.AutoSize = true;
            this.label229.Location = new System.Drawing.Point(982, 487);
            this.label229.Name = "label229";
            this.label229.Size = new System.Drawing.Size(35, 30);
            this.label229.TabIndex = 178;
            this.label229.Text = "°C";
            // 
            // label230
            // 
            this.label230.AutoSize = true;
            this.label230.Location = new System.Drawing.Point(989, 459);
            this.label230.Name = "label230";
            this.label230.Size = new System.Drawing.Size(26, 30);
            this.label230.TabIndex = 177;
            this.label230.Text = "V";
            // 
            // label231
            // 
            this.label231.AutoSize = true;
            this.label231.Location = new System.Drawing.Point(982, 387);
            this.label231.Name = "label231";
            this.label231.Size = new System.Drawing.Size(35, 30);
            this.label231.TabIndex = 176;
            this.label231.Text = "°C";
            // 
            // label232
            // 
            this.label232.AutoSize = true;
            this.label232.Location = new System.Drawing.Point(989, 359);
            this.label232.Name = "label232";
            this.label232.Size = new System.Drawing.Size(26, 30);
            this.label232.TabIndex = 175;
            this.label232.Text = "V";
            // 
            // label233
            // 
            this.label233.AutoSize = true;
            this.label233.Location = new System.Drawing.Point(982, 287);
            this.label233.Name = "label233";
            this.label233.Size = new System.Drawing.Size(35, 30);
            this.label233.TabIndex = 174;
            this.label233.Text = "°C";
            // 
            // label234
            // 
            this.label234.AutoSize = true;
            this.label234.Location = new System.Drawing.Point(989, 259);
            this.label234.Name = "label234";
            this.label234.Size = new System.Drawing.Size(26, 30);
            this.label234.TabIndex = 173;
            this.label234.Text = "V";
            // 
            // label235
            // 
            this.label235.AutoSize = true;
            this.label235.Location = new System.Drawing.Point(982, 191);
            this.label235.Name = "label235";
            this.label235.Size = new System.Drawing.Size(35, 30);
            this.label235.TabIndex = 172;
            this.label235.Text = "°C";
            // 
            // label236
            // 
            this.label236.AutoSize = true;
            this.label236.Location = new System.Drawing.Point(989, 163);
            this.label236.Name = "label236";
            this.label236.Size = new System.Drawing.Size(26, 30);
            this.label236.TabIndex = 171;
            this.label236.Text = "V";
            // 
            // label237
            // 
            this.label237.AutoSize = true;
            this.label237.Location = new System.Drawing.Point(632, 687);
            this.label237.Name = "label237";
            this.label237.Size = new System.Drawing.Size(35, 30);
            this.label237.TabIndex = 170;
            this.label237.Text = "°C";
            // 
            // label238
            // 
            this.label238.AutoSize = true;
            this.label238.Location = new System.Drawing.Point(639, 659);
            this.label238.Name = "label238";
            this.label238.Size = new System.Drawing.Size(26, 30);
            this.label238.TabIndex = 169;
            this.label238.Text = "V";
            // 
            // label239
            // 
            this.label239.AutoSize = true;
            this.label239.Location = new System.Drawing.Point(632, 587);
            this.label239.Name = "label239";
            this.label239.Size = new System.Drawing.Size(35, 30);
            this.label239.TabIndex = 168;
            this.label239.Text = "°C";
            // 
            // label240
            // 
            this.label240.AutoSize = true;
            this.label240.Location = new System.Drawing.Point(639, 559);
            this.label240.Name = "label240";
            this.label240.Size = new System.Drawing.Size(26, 30);
            this.label240.TabIndex = 167;
            this.label240.Text = "V";
            // 
            // label241
            // 
            this.label241.AutoSize = true;
            this.label241.Location = new System.Drawing.Point(632, 487);
            this.label241.Name = "label241";
            this.label241.Size = new System.Drawing.Size(35, 30);
            this.label241.TabIndex = 166;
            this.label241.Text = "°C";
            // 
            // label242
            // 
            this.label242.AutoSize = true;
            this.label242.Location = new System.Drawing.Point(639, 459);
            this.label242.Name = "label242";
            this.label242.Size = new System.Drawing.Size(26, 30);
            this.label242.TabIndex = 165;
            this.label242.Text = "V";
            // 
            // label243
            // 
            this.label243.AutoSize = true;
            this.label243.Location = new System.Drawing.Point(632, 387);
            this.label243.Name = "label243";
            this.label243.Size = new System.Drawing.Size(35, 30);
            this.label243.TabIndex = 164;
            this.label243.Text = "°C";
            // 
            // label244
            // 
            this.label244.AutoSize = true;
            this.label244.Location = new System.Drawing.Point(639, 359);
            this.label244.Name = "label244";
            this.label244.Size = new System.Drawing.Size(26, 30);
            this.label244.TabIndex = 163;
            this.label244.Text = "V";
            // 
            // label245
            // 
            this.label245.AutoSize = true;
            this.label245.Location = new System.Drawing.Point(632, 287);
            this.label245.Name = "label245";
            this.label245.Size = new System.Drawing.Size(35, 30);
            this.label245.TabIndex = 162;
            this.label245.Text = "°C";
            // 
            // label246
            // 
            this.label246.AutoSize = true;
            this.label246.Location = new System.Drawing.Point(639, 259);
            this.label246.Name = "label246";
            this.label246.Size = new System.Drawing.Size(26, 30);
            this.label246.TabIndex = 161;
            this.label246.Text = "V";
            // 
            // label247
            // 
            this.label247.AutoSize = true;
            this.label247.Location = new System.Drawing.Point(632, 187);
            this.label247.Name = "label247";
            this.label247.Size = new System.Drawing.Size(35, 30);
            this.label247.TabIndex = 160;
            this.label247.Text = "°C";
            // 
            // label248
            // 
            this.label248.AutoSize = true;
            this.label248.Location = new System.Drawing.Point(639, 159);
            this.label248.Name = "label248";
            this.label248.Size = new System.Drawing.Size(26, 30);
            this.label248.TabIndex = 159;
            this.label248.Text = "V";
            // 
            // label249
            // 
            this.label249.AutoSize = true;
            this.label249.Location = new System.Drawing.Point(282, 687);
            this.label249.Name = "label249";
            this.label249.Size = new System.Drawing.Size(35, 30);
            this.label249.TabIndex = 158;
            this.label249.Text = "°C";
            // 
            // label250
            // 
            this.label250.AutoSize = true;
            this.label250.Location = new System.Drawing.Point(289, 659);
            this.label250.Name = "label250";
            this.label250.Size = new System.Drawing.Size(26, 30);
            this.label250.TabIndex = 157;
            this.label250.Text = "V";
            // 
            // label251
            // 
            this.label251.AutoSize = true;
            this.label251.Location = new System.Drawing.Point(282, 587);
            this.label251.Name = "label251";
            this.label251.Size = new System.Drawing.Size(35, 30);
            this.label251.TabIndex = 156;
            this.label251.Text = "°C";
            // 
            // label252
            // 
            this.label252.AutoSize = true;
            this.label252.Location = new System.Drawing.Point(289, 559);
            this.label252.Name = "label252";
            this.label252.Size = new System.Drawing.Size(26, 30);
            this.label252.TabIndex = 155;
            this.label252.Text = "V";
            // 
            // label253
            // 
            this.label253.AutoSize = true;
            this.label253.Location = new System.Drawing.Point(282, 487);
            this.label253.Name = "label253";
            this.label253.Size = new System.Drawing.Size(35, 30);
            this.label253.TabIndex = 154;
            this.label253.Text = "°C";
            // 
            // label254
            // 
            this.label254.AutoSize = true;
            this.label254.Location = new System.Drawing.Point(289, 459);
            this.label254.Name = "label254";
            this.label254.Size = new System.Drawing.Size(26, 30);
            this.label254.TabIndex = 153;
            this.label254.Text = "V";
            // 
            // label255
            // 
            this.label255.AutoSize = true;
            this.label255.Location = new System.Drawing.Point(282, 387);
            this.label255.Name = "label255";
            this.label255.Size = new System.Drawing.Size(35, 30);
            this.label255.TabIndex = 152;
            this.label255.Text = "°C";
            // 
            // label256
            // 
            this.label256.AutoSize = true;
            this.label256.Location = new System.Drawing.Point(289, 359);
            this.label256.Name = "label256";
            this.label256.Size = new System.Drawing.Size(26, 30);
            this.label256.TabIndex = 151;
            this.label256.Text = "V";
            // 
            // label257
            // 
            this.label257.AutoSize = true;
            this.label257.Location = new System.Drawing.Point(282, 287);
            this.label257.Name = "label257";
            this.label257.Size = new System.Drawing.Size(35, 30);
            this.label257.TabIndex = 150;
            this.label257.Text = "°C";
            // 
            // label258
            // 
            this.label258.AutoSize = true;
            this.label258.Location = new System.Drawing.Point(289, 259);
            this.label258.Name = "label258";
            this.label258.Size = new System.Drawing.Size(26, 30);
            this.label258.TabIndex = 149;
            this.label258.Text = "V";
            // 
            // label259
            // 
            this.label259.AutoSize = true;
            this.label259.Location = new System.Drawing.Point(282, 187);
            this.label259.Name = "label259";
            this.label259.Size = new System.Drawing.Size(35, 30);
            this.label259.TabIndex = 148;
            this.label259.Text = "°C";
            // 
            // label260
            // 
            this.label260.AutoSize = true;
            this.label260.Location = new System.Drawing.Point(289, 159);
            this.label260.Name = "label260";
            this.label260.Size = new System.Drawing.Size(26, 30);
            this.label260.TabIndex = 147;
            this.label260.Text = "V";
            // 
            // label261
            // 
            this.label261.AutoSize = true;
            this.label261.Location = new System.Drawing.Point(798, 575);
            this.label261.Name = "label261";
            this.label261.Size = new System.Drawing.Size(84, 30);
            this.label261.TabIndex = 146;
            this.label261.Text = "Cell 17";
            // 
            // textBox_178
            // 
            this.textBox_178.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_178.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_178.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_178.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_178.Location = new System.Drawing.Point(901, 592);
            this.textBox_178.Multiline = true;
            this.textBox_178.Name = "textBox_178";
            this.textBox_178.ReadOnly = true;
            this.textBox_178.Size = new System.Drawing.Size(75, 25);
            this.textBox_178.TabIndex = 145;
            this.textBox_178.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_177
            // 
            this.textBox_177.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_177.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_177.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_177.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_177.Location = new System.Drawing.Point(901, 561);
            this.textBox_177.Multiline = true;
            this.textBox_177.Name = "textBox_177";
            this.textBox_177.ReadOnly = true;
            this.textBox_177.Size = new System.Drawing.Size(75, 25);
            this.textBox_177.TabIndex = 144;
            this.textBox_177.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label262
            // 
            this.label262.AutoSize = true;
            this.label262.Location = new System.Drawing.Point(798, 671);
            this.label262.Name = "label262";
            this.label262.Size = new System.Drawing.Size(84, 30);
            this.label262.TabIndex = 143;
            this.label262.Text = "Cell 18";
            // 
            // textBox_180
            // 
            this.textBox_180.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_180.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_180.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_180.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_180.Location = new System.Drawing.Point(901, 692);
            this.textBox_180.Multiline = true;
            this.textBox_180.Name = "textBox_180";
            this.textBox_180.ReadOnly = true;
            this.textBox_180.Size = new System.Drawing.Size(75, 25);
            this.textBox_180.TabIndex = 142;
            this.textBox_180.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_179
            // 
            this.textBox_179.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_179.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_179.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_179.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_179.Location = new System.Drawing.Point(901, 661);
            this.textBox_179.Multiline = true;
            this.textBox_179.Name = "textBox_179";
            this.textBox_179.ReadOnly = true;
            this.textBox_179.Size = new System.Drawing.Size(75, 25);
            this.textBox_179.TabIndex = 141;
            this.textBox_179.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label263
            // 
            this.label263.AutoSize = true;
            this.label263.Location = new System.Drawing.Point(798, 375);
            this.label263.Name = "label263";
            this.label263.Size = new System.Drawing.Size(84, 30);
            this.label263.TabIndex = 140;
            this.label263.Text = "Cell 15";
            // 
            // textBox_174
            // 
            this.textBox_174.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_174.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_174.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_174.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_174.Location = new System.Drawing.Point(901, 392);
            this.textBox_174.Multiline = true;
            this.textBox_174.Name = "textBox_174";
            this.textBox_174.ReadOnly = true;
            this.textBox_174.Size = new System.Drawing.Size(75, 25);
            this.textBox_174.TabIndex = 139;
            this.textBox_174.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_173
            // 
            this.textBox_173.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_173.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_173.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_173.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_173.Location = new System.Drawing.Point(901, 361);
            this.textBox_173.Multiline = true;
            this.textBox_173.Name = "textBox_173";
            this.textBox_173.ReadOnly = true;
            this.textBox_173.Size = new System.Drawing.Size(75, 25);
            this.textBox_173.TabIndex = 138;
            this.textBox_173.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label264
            // 
            this.label264.AutoSize = true;
            this.label264.Location = new System.Drawing.Point(798, 275);
            this.label264.Name = "label264";
            this.label264.Size = new System.Drawing.Size(84, 30);
            this.label264.TabIndex = 137;
            this.label264.Text = "Cell 14";
            // 
            // textBox_172
            // 
            this.textBox_172.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_172.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_172.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_172.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_172.Location = new System.Drawing.Point(901, 292);
            this.textBox_172.Multiline = true;
            this.textBox_172.Name = "textBox_172";
            this.textBox_172.ReadOnly = true;
            this.textBox_172.Size = new System.Drawing.Size(75, 25);
            this.textBox_172.TabIndex = 136;
            this.textBox_172.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_171
            // 
            this.textBox_171.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_171.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_171.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_171.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_171.Location = new System.Drawing.Point(901, 261);
            this.textBox_171.Multiline = true;
            this.textBox_171.Name = "textBox_171";
            this.textBox_171.ReadOnly = true;
            this.textBox_171.Size = new System.Drawing.Size(75, 25);
            this.textBox_171.TabIndex = 135;
            this.textBox_171.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label265
            // 
            this.label265.AutoSize = true;
            this.label265.Location = new System.Drawing.Point(798, 174);
            this.label265.Name = "label265";
            this.label265.Size = new System.Drawing.Size(84, 30);
            this.label265.TabIndex = 134;
            this.label265.Text = "Cell 13";
            // 
            // textBox_170
            // 
            this.textBox_170.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_170.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_170.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_170.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_170.Location = new System.Drawing.Point(901, 192);
            this.textBox_170.Multiline = true;
            this.textBox_170.Name = "textBox_170";
            this.textBox_170.ReadOnly = true;
            this.textBox_170.Size = new System.Drawing.Size(75, 25);
            this.textBox_170.TabIndex = 133;
            this.textBox_170.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_169
            // 
            this.textBox_169.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_169.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_169.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_169.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_169.Location = new System.Drawing.Point(901, 161);
            this.textBox_169.Multiline = true;
            this.textBox_169.Name = "textBox_169";
            this.textBox_169.ReadOnly = true;
            this.textBox_169.Size = new System.Drawing.Size(75, 25);
            this.textBox_169.TabIndex = 132;
            this.textBox_169.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label266
            // 
            this.label266.AutoSize = true;
            this.label266.Location = new System.Drawing.Point(798, 474);
            this.label266.Name = "label266";
            this.label266.Size = new System.Drawing.Size(84, 30);
            this.label266.TabIndex = 131;
            this.label266.Text = "Cell 16";
            // 
            // textBox_176
            // 
            this.textBox_176.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_176.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_176.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_176.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_176.Location = new System.Drawing.Point(901, 492);
            this.textBox_176.Multiline = true;
            this.textBox_176.Name = "textBox_176";
            this.textBox_176.ReadOnly = true;
            this.textBox_176.Size = new System.Drawing.Size(75, 25);
            this.textBox_176.TabIndex = 130;
            this.textBox_176.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_175
            // 
            this.textBox_175.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_175.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_175.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_175.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_175.Location = new System.Drawing.Point(901, 461);
            this.textBox_175.Multiline = true;
            this.textBox_175.Name = "textBox_175";
            this.textBox_175.ReadOnly = true;
            this.textBox_175.Size = new System.Drawing.Size(75, 25);
            this.textBox_175.TabIndex = 129;
            this.textBox_175.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label267
            // 
            this.label267.AutoSize = true;
            this.label267.Location = new System.Drawing.Point(461, 575);
            this.label267.Name = "label267";
            this.label267.Size = new System.Drawing.Size(84, 30);
            this.label267.TabIndex = 128;
            this.label267.Text = "Cell 11";
            // 
            // textBox_166
            // 
            this.textBox_166.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_166.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_166.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_166.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_166.Location = new System.Drawing.Point(551, 592);
            this.textBox_166.Multiline = true;
            this.textBox_166.Name = "textBox_166";
            this.textBox_166.ReadOnly = true;
            this.textBox_166.Size = new System.Drawing.Size(75, 25);
            this.textBox_166.TabIndex = 127;
            this.textBox_166.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_165
            // 
            this.textBox_165.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_165.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_165.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_165.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_165.Location = new System.Drawing.Point(551, 561);
            this.textBox_165.Multiline = true;
            this.textBox_165.Name = "textBox_165";
            this.textBox_165.ReadOnly = true;
            this.textBox_165.Size = new System.Drawing.Size(75, 25);
            this.textBox_165.TabIndex = 126;
            this.textBox_165.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label268
            // 
            this.label268.AutoSize = true;
            this.label268.Location = new System.Drawing.Point(461, 671);
            this.label268.Name = "label268";
            this.label268.Size = new System.Drawing.Size(84, 30);
            this.label268.TabIndex = 125;
            this.label268.Text = "Cell 12";
            // 
            // textBox_168
            // 
            this.textBox_168.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_168.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_168.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_168.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_168.Location = new System.Drawing.Point(551, 692);
            this.textBox_168.Multiline = true;
            this.textBox_168.Name = "textBox_168";
            this.textBox_168.ReadOnly = true;
            this.textBox_168.Size = new System.Drawing.Size(75, 25);
            this.textBox_168.TabIndex = 124;
            this.textBox_168.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_167
            // 
            this.textBox_167.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_167.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_167.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_167.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_167.Location = new System.Drawing.Point(551, 661);
            this.textBox_167.Multiline = true;
            this.textBox_167.Name = "textBox_167";
            this.textBox_167.ReadOnly = true;
            this.textBox_167.Size = new System.Drawing.Size(75, 25);
            this.textBox_167.TabIndex = 123;
            this.textBox_167.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label269
            // 
            this.label269.AutoSize = true;
            this.label269.Location = new System.Drawing.Point(461, 375);
            this.label269.Name = "label269";
            this.label269.Size = new System.Drawing.Size(70, 30);
            this.label269.TabIndex = 122;
            this.label269.Text = "Cell 9";
            // 
            // textBox_162
            // 
            this.textBox_162.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_162.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_162.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_162.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_162.Location = new System.Drawing.Point(551, 392);
            this.textBox_162.Multiline = true;
            this.textBox_162.Name = "textBox_162";
            this.textBox_162.ReadOnly = true;
            this.textBox_162.Size = new System.Drawing.Size(75, 25);
            this.textBox_162.TabIndex = 121;
            this.textBox_162.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_161
            // 
            this.textBox_161.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_161.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_161.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_161.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_161.Location = new System.Drawing.Point(551, 361);
            this.textBox_161.Multiline = true;
            this.textBox_161.Name = "textBox_161";
            this.textBox_161.ReadOnly = true;
            this.textBox_161.Size = new System.Drawing.Size(75, 25);
            this.textBox_161.TabIndex = 120;
            this.textBox_161.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label270
            // 
            this.label270.AutoSize = true;
            this.label270.Location = new System.Drawing.Point(461, 275);
            this.label270.Name = "label270";
            this.label270.Size = new System.Drawing.Size(70, 30);
            this.label270.TabIndex = 119;
            this.label270.Text = "Cell 8";
            // 
            // textBox_160
            // 
            this.textBox_160.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_160.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_160.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_160.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_160.Location = new System.Drawing.Point(551, 292);
            this.textBox_160.Multiline = true;
            this.textBox_160.Name = "textBox_160";
            this.textBox_160.ReadOnly = true;
            this.textBox_160.Size = new System.Drawing.Size(75, 25);
            this.textBox_160.TabIndex = 118;
            this.textBox_160.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_159
            // 
            this.textBox_159.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_159.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_159.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_159.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_159.Location = new System.Drawing.Point(551, 261);
            this.textBox_159.Multiline = true;
            this.textBox_159.Name = "textBox_159";
            this.textBox_159.ReadOnly = true;
            this.textBox_159.Size = new System.Drawing.Size(75, 25);
            this.textBox_159.TabIndex = 117;
            this.textBox_159.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label271
            // 
            this.label271.AutoSize = true;
            this.label271.Location = new System.Drawing.Point(461, 174);
            this.label271.Name = "label271";
            this.label271.Size = new System.Drawing.Size(70, 30);
            this.label271.TabIndex = 116;
            this.label271.Text = "Cell 7";
            // 
            // textBox_158
            // 
            this.textBox_158.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_158.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_158.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_158.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_158.Location = new System.Drawing.Point(551, 192);
            this.textBox_158.Multiline = true;
            this.textBox_158.Name = "textBox_158";
            this.textBox_158.ReadOnly = true;
            this.textBox_158.Size = new System.Drawing.Size(75, 25);
            this.textBox_158.TabIndex = 115;
            this.textBox_158.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_157
            // 
            this.textBox_157.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_157.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_157.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_157.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_157.Location = new System.Drawing.Point(551, 161);
            this.textBox_157.Multiline = true;
            this.textBox_157.Name = "textBox_157";
            this.textBox_157.ReadOnly = true;
            this.textBox_157.Size = new System.Drawing.Size(75, 25);
            this.textBox_157.TabIndex = 114;
            this.textBox_157.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label272
            // 
            this.label272.AutoSize = true;
            this.label272.Location = new System.Drawing.Point(461, 474);
            this.label272.Name = "label272";
            this.label272.Size = new System.Drawing.Size(84, 30);
            this.label272.TabIndex = 113;
            this.label272.Text = "Cell 10";
            // 
            // textBox_164
            // 
            this.textBox_164.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_164.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_164.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_164.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_164.Location = new System.Drawing.Point(551, 492);
            this.textBox_164.Multiline = true;
            this.textBox_164.Name = "textBox_164";
            this.textBox_164.ReadOnly = true;
            this.textBox_164.Size = new System.Drawing.Size(75, 25);
            this.textBox_164.TabIndex = 112;
            this.textBox_164.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_163
            // 
            this.textBox_163.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_163.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_163.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_163.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_163.Location = new System.Drawing.Point(551, 461);
            this.textBox_163.Multiline = true;
            this.textBox_163.Name = "textBox_163";
            this.textBox_163.ReadOnly = true;
            this.textBox_163.Size = new System.Drawing.Size(75, 25);
            this.textBox_163.TabIndex = 111;
            this.textBox_163.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label273
            // 
            this.label273.AutoSize = true;
            this.label273.Location = new System.Drawing.Point(125, 575);
            this.label273.Name = "label273";
            this.label273.Size = new System.Drawing.Size(70, 30);
            this.label273.TabIndex = 110;
            this.label273.Text = "Cell 5";
            // 
            // textBox_154
            // 
            this.textBox_154.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_154.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_154.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_154.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_154.Location = new System.Drawing.Point(201, 592);
            this.textBox_154.Multiline = true;
            this.textBox_154.Name = "textBox_154";
            this.textBox_154.ReadOnly = true;
            this.textBox_154.Size = new System.Drawing.Size(75, 25);
            this.textBox_154.TabIndex = 109;
            this.textBox_154.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_153
            // 
            this.textBox_153.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_153.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_153.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_153.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_153.Location = new System.Drawing.Point(201, 561);
            this.textBox_153.Multiline = true;
            this.textBox_153.Name = "textBox_153";
            this.textBox_153.ReadOnly = true;
            this.textBox_153.Size = new System.Drawing.Size(75, 25);
            this.textBox_153.TabIndex = 108;
            this.textBox_153.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label274
            // 
            this.label274.AutoSize = true;
            this.label274.Location = new System.Drawing.Point(125, 671);
            this.label274.Name = "label274";
            this.label274.Size = new System.Drawing.Size(70, 30);
            this.label274.TabIndex = 107;
            this.label274.Text = "Cell 6";
            // 
            // textBox_156
            // 
            this.textBox_156.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_156.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_156.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_156.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_156.Location = new System.Drawing.Point(201, 692);
            this.textBox_156.Multiline = true;
            this.textBox_156.Name = "textBox_156";
            this.textBox_156.ReadOnly = true;
            this.textBox_156.Size = new System.Drawing.Size(75, 25);
            this.textBox_156.TabIndex = 106;
            this.textBox_156.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_155
            // 
            this.textBox_155.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_155.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_155.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_155.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_155.Location = new System.Drawing.Point(201, 661);
            this.textBox_155.Multiline = true;
            this.textBox_155.Name = "textBox_155";
            this.textBox_155.ReadOnly = true;
            this.textBox_155.Size = new System.Drawing.Size(75, 25);
            this.textBox_155.TabIndex = 105;
            this.textBox_155.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label275
            // 
            this.label275.AutoSize = true;
            this.label275.Location = new System.Drawing.Point(125, 375);
            this.label275.Name = "label275";
            this.label275.Size = new System.Drawing.Size(70, 30);
            this.label275.TabIndex = 104;
            this.label275.Text = "Cell 3";
            // 
            // textBox_150
            // 
            this.textBox_150.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_150.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_150.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_150.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_150.Location = new System.Drawing.Point(201, 392);
            this.textBox_150.Multiline = true;
            this.textBox_150.Name = "textBox_150";
            this.textBox_150.ReadOnly = true;
            this.textBox_150.Size = new System.Drawing.Size(75, 25);
            this.textBox_150.TabIndex = 103;
            this.textBox_150.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_149
            // 
            this.textBox_149.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_149.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_149.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_149.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_149.Location = new System.Drawing.Point(201, 361);
            this.textBox_149.Multiline = true;
            this.textBox_149.Name = "textBox_149";
            this.textBox_149.ReadOnly = true;
            this.textBox_149.Size = new System.Drawing.Size(75, 25);
            this.textBox_149.TabIndex = 102;
            this.textBox_149.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label276
            // 
            this.label276.AutoSize = true;
            this.label276.Location = new System.Drawing.Point(125, 275);
            this.label276.Name = "label276";
            this.label276.Size = new System.Drawing.Size(70, 30);
            this.label276.TabIndex = 101;
            this.label276.Text = "Cell 2";
            // 
            // textBox_148
            // 
            this.textBox_148.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_148.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_148.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_148.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_148.Location = new System.Drawing.Point(201, 292);
            this.textBox_148.Multiline = true;
            this.textBox_148.Name = "textBox_148";
            this.textBox_148.ReadOnly = true;
            this.textBox_148.Size = new System.Drawing.Size(75, 25);
            this.textBox_148.TabIndex = 100;
            this.textBox_148.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_147
            // 
            this.textBox_147.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_147.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_147.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_147.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_147.Location = new System.Drawing.Point(201, 261);
            this.textBox_147.Multiline = true;
            this.textBox_147.Name = "textBox_147";
            this.textBox_147.ReadOnly = true;
            this.textBox_147.Size = new System.Drawing.Size(75, 25);
            this.textBox_147.TabIndex = 99;
            this.textBox_147.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label277
            // 
            this.label277.AutoSize = true;
            this.label277.Location = new System.Drawing.Point(125, 174);
            this.label277.Name = "label277";
            this.label277.Size = new System.Drawing.Size(70, 30);
            this.label277.TabIndex = 98;
            this.label277.Text = "Cell 1";
            // 
            // textBox_146
            // 
            this.textBox_146.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_146.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_146.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_146.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_146.Location = new System.Drawing.Point(201, 192);
            this.textBox_146.Multiline = true;
            this.textBox_146.Name = "textBox_146";
            this.textBox_146.ReadOnly = true;
            this.textBox_146.Size = new System.Drawing.Size(75, 25);
            this.textBox_146.TabIndex = 97;
            this.textBox_146.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_145
            // 
            this.textBox_145.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_145.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_145.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_145.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_145.Location = new System.Drawing.Point(201, 161);
            this.textBox_145.Multiline = true;
            this.textBox_145.Name = "textBox_145";
            this.textBox_145.ReadOnly = true;
            this.textBox_145.Size = new System.Drawing.Size(75, 25);
            this.textBox_145.TabIndex = 96;
            this.textBox_145.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label278
            // 
            this.label278.AutoSize = true;
            this.label278.Location = new System.Drawing.Point(125, 474);
            this.label278.Name = "label278";
            this.label278.Size = new System.Drawing.Size(70, 30);
            this.label278.TabIndex = 95;
            this.label278.Text = "Cell 4";
            // 
            // textBox_152
            // 
            this.textBox_152.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_152.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_152.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_152.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_152.Location = new System.Drawing.Point(201, 492);
            this.textBox_152.Multiline = true;
            this.textBox_152.Name = "textBox_152";
            this.textBox_152.ReadOnly = true;
            this.textBox_152.Size = new System.Drawing.Size(75, 25);
            this.textBox_152.TabIndex = 94;
            this.textBox_152.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_151
            // 
            this.textBox_151.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_151.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_151.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_151.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_151.Location = new System.Drawing.Point(201, 461);
            this.textBox_151.Multiline = true;
            this.textBox_151.Name = "textBox_151";
            this.textBox_151.ReadOnly = true;
            this.textBox_151.Size = new System.Drawing.Size(75, 25);
            this.textBox_151.TabIndex = 93;
            this.textBox_151.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stack6
            // 
            this.stack6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.stack6.Controls.Add(this.stack_6u);
            this.stack6.Controls.Add(this.clear_6);
            this.stack6.Controls.Add(this.label445);
            this.stack6.Controls.Add(this.label279);
            this.stack6.Controls.Add(this.label280);
            this.stack6.Controls.Add(this.label281);
            this.stack6.Controls.Add(this.label282);
            this.stack6.Controls.Add(this.label283);
            this.stack6.Controls.Add(this.label284);
            this.stack6.Controls.Add(this.label285);
            this.stack6.Controls.Add(this.label286);
            this.stack6.Controls.Add(this.label287);
            this.stack6.Controls.Add(this.label288);
            this.stack6.Controls.Add(this.label289);
            this.stack6.Controls.Add(this.label290);
            this.stack6.Controls.Add(this.label291);
            this.stack6.Controls.Add(this.label292);
            this.stack6.Controls.Add(this.label293);
            this.stack6.Controls.Add(this.label294);
            this.stack6.Controls.Add(this.label295);
            this.stack6.Controls.Add(this.label296);
            this.stack6.Controls.Add(this.label297);
            this.stack6.Controls.Add(this.label298);
            this.stack6.Controls.Add(this.label299);
            this.stack6.Controls.Add(this.label300);
            this.stack6.Controls.Add(this.label301);
            this.stack6.Controls.Add(this.label302);
            this.stack6.Controls.Add(this.label303);
            this.stack6.Controls.Add(this.label304);
            this.stack6.Controls.Add(this.label305);
            this.stack6.Controls.Add(this.label306);
            this.stack6.Controls.Add(this.label307);
            this.stack6.Controls.Add(this.label308);
            this.stack6.Controls.Add(this.label309);
            this.stack6.Controls.Add(this.label310);
            this.stack6.Controls.Add(this.label311);
            this.stack6.Controls.Add(this.label312);
            this.stack6.Controls.Add(this.label313);
            this.stack6.Controls.Add(this.label314);
            this.stack6.Controls.Add(this.label315);
            this.stack6.Controls.Add(this.textBox_214);
            this.stack6.Controls.Add(this.textBox_213);
            this.stack6.Controls.Add(this.label316);
            this.stack6.Controls.Add(this.textBox_216);
            this.stack6.Controls.Add(this.textBox_215);
            this.stack6.Controls.Add(this.label317);
            this.stack6.Controls.Add(this.textBox_210);
            this.stack6.Controls.Add(this.textBox_209);
            this.stack6.Controls.Add(this.label318);
            this.stack6.Controls.Add(this.textBox_208);
            this.stack6.Controls.Add(this.textBox_207);
            this.stack6.Controls.Add(this.label319);
            this.stack6.Controls.Add(this.textBox_206);
            this.stack6.Controls.Add(this.textBox_205);
            this.stack6.Controls.Add(this.label320);
            this.stack6.Controls.Add(this.textBox_212);
            this.stack6.Controls.Add(this.textBox_211);
            this.stack6.Controls.Add(this.label321);
            this.stack6.Controls.Add(this.textBox_202);
            this.stack6.Controls.Add(this.textBox_201);
            this.stack6.Controls.Add(this.label322);
            this.stack6.Controls.Add(this.textBox_204);
            this.stack6.Controls.Add(this.textBox_203);
            this.stack6.Controls.Add(this.label323);
            this.stack6.Controls.Add(this.textBox_198);
            this.stack6.Controls.Add(this.textBox_197);
            this.stack6.Controls.Add(this.label324);
            this.stack6.Controls.Add(this.textBox_196);
            this.stack6.Controls.Add(this.textBox_195);
            this.stack6.Controls.Add(this.label325);
            this.stack6.Controls.Add(this.textBox_194);
            this.stack6.Controls.Add(this.textBox_193);
            this.stack6.Controls.Add(this.label326);
            this.stack6.Controls.Add(this.textBox_200);
            this.stack6.Controls.Add(this.textBox_199);
            this.stack6.Controls.Add(this.label327);
            this.stack6.Controls.Add(this.textBox_190);
            this.stack6.Controls.Add(this.textBox_189);
            this.stack6.Controls.Add(this.label328);
            this.stack6.Controls.Add(this.textBox_192);
            this.stack6.Controls.Add(this.textBox_191);
            this.stack6.Controls.Add(this.label329);
            this.stack6.Controls.Add(this.textBox_186);
            this.stack6.Controls.Add(this.textBox_185);
            this.stack6.Controls.Add(this.label330);
            this.stack6.Controls.Add(this.textBox_184);
            this.stack6.Controls.Add(this.textBox_183);
            this.stack6.Controls.Add(this.label331);
            this.stack6.Controls.Add(this.textBox_182);
            this.stack6.Controls.Add(this.textBox_181);
            this.stack6.Controls.Add(this.label332);
            this.stack6.Controls.Add(this.textBox_188);
            this.stack6.Controls.Add(this.textBox_187);
            this.stack6.Location = new System.Drawing.Point(4, 39);
            this.stack6.Name = "stack6";
            this.stack6.Size = new System.Drawing.Size(1442, 910);
            this.stack6.TabIndex = 8;
            this.stack6.Text = "Stack 6";
            // 
            // stack_6u
            // 
            this.stack_6u.AutoSize = true;
            this.stack_6u.Font = new System.Drawing.Font("3ds Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stack_6u.Location = new System.Drawing.Point(460, 52);
            this.stack_6u.Name = "stack_6u";
            this.stack_6u.Size = new System.Drawing.Size(204, 36);
            this.stack_6u.TabIndex = 187;
            this.stack_6u.Text = "Stack voltage: -";
            // 
            // clear_6
            // 
            this.clear_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.clear_6.Location = new System.Drawing.Point(15, 52);
            this.clear_6.Name = "clear_6";
            this.clear_6.Size = new System.Drawing.Size(150, 60);
            this.clear_6.TabIndex = 185;
            this.clear_6.Text = "Clear";
            this.clear_6.UseVisualStyleBackColor = false;
            // 
            // label445
            // 
            this.label445.AutoSize = true;
            this.label445.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label445.Location = new System.Drawing.Point(10, 20);
            this.label445.Name = "label445";
            this.label445.Size = new System.Drawing.Size(86, 29);
            this.label445.TabIndex = 183;
            this.label445.Text = "Stack 6";
            // 
            // label279
            // 
            this.label279.AutoSize = true;
            this.label279.Location = new System.Drawing.Point(982, 687);
            this.label279.Name = "label279";
            this.label279.Size = new System.Drawing.Size(35, 30);
            this.label279.TabIndex = 182;
            this.label279.Text = "°C";
            // 
            // label280
            // 
            this.label280.AutoSize = true;
            this.label280.Location = new System.Drawing.Point(989, 659);
            this.label280.Name = "label280";
            this.label280.Size = new System.Drawing.Size(26, 30);
            this.label280.TabIndex = 181;
            this.label280.Text = "V";
            // 
            // label281
            // 
            this.label281.AutoSize = true;
            this.label281.Location = new System.Drawing.Point(982, 587);
            this.label281.Name = "label281";
            this.label281.Size = new System.Drawing.Size(35, 30);
            this.label281.TabIndex = 180;
            this.label281.Text = "°C";
            // 
            // label282
            // 
            this.label282.AutoSize = true;
            this.label282.Location = new System.Drawing.Point(989, 559);
            this.label282.Name = "label282";
            this.label282.Size = new System.Drawing.Size(26, 30);
            this.label282.TabIndex = 179;
            this.label282.Text = "V";
            // 
            // label283
            // 
            this.label283.AutoSize = true;
            this.label283.Location = new System.Drawing.Point(982, 487);
            this.label283.Name = "label283";
            this.label283.Size = new System.Drawing.Size(35, 30);
            this.label283.TabIndex = 178;
            this.label283.Text = "°C";
            // 
            // label284
            // 
            this.label284.AutoSize = true;
            this.label284.Location = new System.Drawing.Point(989, 459);
            this.label284.Name = "label284";
            this.label284.Size = new System.Drawing.Size(26, 30);
            this.label284.TabIndex = 177;
            this.label284.Text = "V";
            // 
            // label285
            // 
            this.label285.AutoSize = true;
            this.label285.Location = new System.Drawing.Point(982, 387);
            this.label285.Name = "label285";
            this.label285.Size = new System.Drawing.Size(35, 30);
            this.label285.TabIndex = 176;
            this.label285.Text = "°C";
            // 
            // label286
            // 
            this.label286.AutoSize = true;
            this.label286.Location = new System.Drawing.Point(989, 359);
            this.label286.Name = "label286";
            this.label286.Size = new System.Drawing.Size(26, 30);
            this.label286.TabIndex = 175;
            this.label286.Text = "V";
            // 
            // label287
            // 
            this.label287.AutoSize = true;
            this.label287.Location = new System.Drawing.Point(982, 287);
            this.label287.Name = "label287";
            this.label287.Size = new System.Drawing.Size(35, 30);
            this.label287.TabIndex = 174;
            this.label287.Text = "°C";
            // 
            // label288
            // 
            this.label288.AutoSize = true;
            this.label288.Location = new System.Drawing.Point(989, 259);
            this.label288.Name = "label288";
            this.label288.Size = new System.Drawing.Size(26, 30);
            this.label288.TabIndex = 173;
            this.label288.Text = "V";
            // 
            // label289
            // 
            this.label289.AutoSize = true;
            this.label289.Location = new System.Drawing.Point(982, 191);
            this.label289.Name = "label289";
            this.label289.Size = new System.Drawing.Size(35, 30);
            this.label289.TabIndex = 172;
            this.label289.Text = "°C";
            // 
            // label290
            // 
            this.label290.AutoSize = true;
            this.label290.Location = new System.Drawing.Point(989, 163);
            this.label290.Name = "label290";
            this.label290.Size = new System.Drawing.Size(26, 30);
            this.label290.TabIndex = 171;
            this.label290.Text = "V";
            // 
            // label291
            // 
            this.label291.AutoSize = true;
            this.label291.Location = new System.Drawing.Point(632, 687);
            this.label291.Name = "label291";
            this.label291.Size = new System.Drawing.Size(35, 30);
            this.label291.TabIndex = 170;
            this.label291.Text = "°C";
            // 
            // label292
            // 
            this.label292.AutoSize = true;
            this.label292.Location = new System.Drawing.Point(639, 659);
            this.label292.Name = "label292";
            this.label292.Size = new System.Drawing.Size(26, 30);
            this.label292.TabIndex = 169;
            this.label292.Text = "V";
            // 
            // label293
            // 
            this.label293.AutoSize = true;
            this.label293.Location = new System.Drawing.Point(632, 587);
            this.label293.Name = "label293";
            this.label293.Size = new System.Drawing.Size(35, 30);
            this.label293.TabIndex = 168;
            this.label293.Text = "°C";
            // 
            // label294
            // 
            this.label294.AutoSize = true;
            this.label294.Location = new System.Drawing.Point(639, 559);
            this.label294.Name = "label294";
            this.label294.Size = new System.Drawing.Size(26, 30);
            this.label294.TabIndex = 167;
            this.label294.Text = "V";
            // 
            // label295
            // 
            this.label295.AutoSize = true;
            this.label295.Location = new System.Drawing.Point(632, 487);
            this.label295.Name = "label295";
            this.label295.Size = new System.Drawing.Size(35, 30);
            this.label295.TabIndex = 166;
            this.label295.Text = "°C";
            // 
            // label296
            // 
            this.label296.AutoSize = true;
            this.label296.Location = new System.Drawing.Point(639, 459);
            this.label296.Name = "label296";
            this.label296.Size = new System.Drawing.Size(26, 30);
            this.label296.TabIndex = 165;
            this.label296.Text = "V";
            // 
            // label297
            // 
            this.label297.AutoSize = true;
            this.label297.Location = new System.Drawing.Point(632, 387);
            this.label297.Name = "label297";
            this.label297.Size = new System.Drawing.Size(35, 30);
            this.label297.TabIndex = 164;
            this.label297.Text = "°C";
            // 
            // label298
            // 
            this.label298.AutoSize = true;
            this.label298.Location = new System.Drawing.Point(639, 359);
            this.label298.Name = "label298";
            this.label298.Size = new System.Drawing.Size(26, 30);
            this.label298.TabIndex = 163;
            this.label298.Text = "V";
            // 
            // label299
            // 
            this.label299.AutoSize = true;
            this.label299.Location = new System.Drawing.Point(632, 287);
            this.label299.Name = "label299";
            this.label299.Size = new System.Drawing.Size(35, 30);
            this.label299.TabIndex = 162;
            this.label299.Text = "°C";
            // 
            // label300
            // 
            this.label300.AutoSize = true;
            this.label300.Location = new System.Drawing.Point(639, 259);
            this.label300.Name = "label300";
            this.label300.Size = new System.Drawing.Size(26, 30);
            this.label300.TabIndex = 161;
            this.label300.Text = "V";
            // 
            // label301
            // 
            this.label301.AutoSize = true;
            this.label301.Location = new System.Drawing.Point(632, 187);
            this.label301.Name = "label301";
            this.label301.Size = new System.Drawing.Size(35, 30);
            this.label301.TabIndex = 160;
            this.label301.Text = "°C";
            // 
            // label302
            // 
            this.label302.AutoSize = true;
            this.label302.Location = new System.Drawing.Point(639, 159);
            this.label302.Name = "label302";
            this.label302.Size = new System.Drawing.Size(26, 30);
            this.label302.TabIndex = 159;
            this.label302.Text = "V";
            // 
            // label303
            // 
            this.label303.AutoSize = true;
            this.label303.Location = new System.Drawing.Point(282, 687);
            this.label303.Name = "label303";
            this.label303.Size = new System.Drawing.Size(35, 30);
            this.label303.TabIndex = 158;
            this.label303.Text = "°C";
            // 
            // label304
            // 
            this.label304.AutoSize = true;
            this.label304.Location = new System.Drawing.Point(289, 659);
            this.label304.Name = "label304";
            this.label304.Size = new System.Drawing.Size(26, 30);
            this.label304.TabIndex = 157;
            this.label304.Text = "V";
            // 
            // label305
            // 
            this.label305.AutoSize = true;
            this.label305.Location = new System.Drawing.Point(282, 587);
            this.label305.Name = "label305";
            this.label305.Size = new System.Drawing.Size(35, 30);
            this.label305.TabIndex = 156;
            this.label305.Text = "°C";
            // 
            // label306
            // 
            this.label306.AutoSize = true;
            this.label306.Location = new System.Drawing.Point(289, 559);
            this.label306.Name = "label306";
            this.label306.Size = new System.Drawing.Size(26, 30);
            this.label306.TabIndex = 155;
            this.label306.Text = "V";
            // 
            // label307
            // 
            this.label307.AutoSize = true;
            this.label307.Location = new System.Drawing.Point(282, 487);
            this.label307.Name = "label307";
            this.label307.Size = new System.Drawing.Size(35, 30);
            this.label307.TabIndex = 154;
            this.label307.Text = "°C";
            // 
            // label308
            // 
            this.label308.AutoSize = true;
            this.label308.Location = new System.Drawing.Point(289, 459);
            this.label308.Name = "label308";
            this.label308.Size = new System.Drawing.Size(26, 30);
            this.label308.TabIndex = 153;
            this.label308.Text = "V";
            // 
            // label309
            // 
            this.label309.AutoSize = true;
            this.label309.Location = new System.Drawing.Point(282, 387);
            this.label309.Name = "label309";
            this.label309.Size = new System.Drawing.Size(35, 30);
            this.label309.TabIndex = 152;
            this.label309.Text = "°C";
            // 
            // label310
            // 
            this.label310.AutoSize = true;
            this.label310.Location = new System.Drawing.Point(289, 359);
            this.label310.Name = "label310";
            this.label310.Size = new System.Drawing.Size(26, 30);
            this.label310.TabIndex = 151;
            this.label310.Text = "V";
            // 
            // label311
            // 
            this.label311.AutoSize = true;
            this.label311.Location = new System.Drawing.Point(282, 287);
            this.label311.Name = "label311";
            this.label311.Size = new System.Drawing.Size(35, 30);
            this.label311.TabIndex = 150;
            this.label311.Text = "°C";
            // 
            // label312
            // 
            this.label312.AutoSize = true;
            this.label312.Location = new System.Drawing.Point(289, 259);
            this.label312.Name = "label312";
            this.label312.Size = new System.Drawing.Size(26, 30);
            this.label312.TabIndex = 149;
            this.label312.Text = "V";
            // 
            // label313
            // 
            this.label313.AutoSize = true;
            this.label313.Location = new System.Drawing.Point(282, 187);
            this.label313.Name = "label313";
            this.label313.Size = new System.Drawing.Size(35, 30);
            this.label313.TabIndex = 148;
            this.label313.Text = "°C";
            // 
            // label314
            // 
            this.label314.AutoSize = true;
            this.label314.Location = new System.Drawing.Point(289, 159);
            this.label314.Name = "label314";
            this.label314.Size = new System.Drawing.Size(26, 30);
            this.label314.TabIndex = 147;
            this.label314.Text = "V";
            // 
            // label315
            // 
            this.label315.AutoSize = true;
            this.label315.Location = new System.Drawing.Point(798, 575);
            this.label315.Name = "label315";
            this.label315.Size = new System.Drawing.Size(84, 30);
            this.label315.TabIndex = 146;
            this.label315.Text = "Cell 17";
            // 
            // textBox_214
            // 
            this.textBox_214.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_214.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_214.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_214.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_214.Location = new System.Drawing.Point(901, 592);
            this.textBox_214.Multiline = true;
            this.textBox_214.Name = "textBox_214";
            this.textBox_214.ReadOnly = true;
            this.textBox_214.Size = new System.Drawing.Size(75, 25);
            this.textBox_214.TabIndex = 145;
            this.textBox_214.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_213
            // 
            this.textBox_213.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_213.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_213.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_213.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_213.Location = new System.Drawing.Point(901, 561);
            this.textBox_213.Multiline = true;
            this.textBox_213.Name = "textBox_213";
            this.textBox_213.ReadOnly = true;
            this.textBox_213.Size = new System.Drawing.Size(75, 25);
            this.textBox_213.TabIndex = 144;
            this.textBox_213.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label316
            // 
            this.label316.AutoSize = true;
            this.label316.Location = new System.Drawing.Point(798, 671);
            this.label316.Name = "label316";
            this.label316.Size = new System.Drawing.Size(84, 30);
            this.label316.TabIndex = 143;
            this.label316.Text = "Cell 18";
            // 
            // textBox_216
            // 
            this.textBox_216.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_216.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_216.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_216.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_216.Location = new System.Drawing.Point(901, 692);
            this.textBox_216.Multiline = true;
            this.textBox_216.Name = "textBox_216";
            this.textBox_216.ReadOnly = true;
            this.textBox_216.Size = new System.Drawing.Size(75, 25);
            this.textBox_216.TabIndex = 142;
            this.textBox_216.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_215
            // 
            this.textBox_215.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_215.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_215.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_215.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_215.Location = new System.Drawing.Point(901, 661);
            this.textBox_215.Multiline = true;
            this.textBox_215.Name = "textBox_215";
            this.textBox_215.ReadOnly = true;
            this.textBox_215.Size = new System.Drawing.Size(75, 25);
            this.textBox_215.TabIndex = 141;
            this.textBox_215.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label317
            // 
            this.label317.AutoSize = true;
            this.label317.Location = new System.Drawing.Point(798, 375);
            this.label317.Name = "label317";
            this.label317.Size = new System.Drawing.Size(84, 30);
            this.label317.TabIndex = 140;
            this.label317.Text = "Cell 15";
            // 
            // textBox_210
            // 
            this.textBox_210.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_210.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_210.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_210.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_210.Location = new System.Drawing.Point(901, 392);
            this.textBox_210.Multiline = true;
            this.textBox_210.Name = "textBox_210";
            this.textBox_210.ReadOnly = true;
            this.textBox_210.Size = new System.Drawing.Size(75, 25);
            this.textBox_210.TabIndex = 139;
            this.textBox_210.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_209
            // 
            this.textBox_209.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_209.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_209.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_209.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_209.Location = new System.Drawing.Point(901, 361);
            this.textBox_209.Multiline = true;
            this.textBox_209.Name = "textBox_209";
            this.textBox_209.ReadOnly = true;
            this.textBox_209.Size = new System.Drawing.Size(75, 25);
            this.textBox_209.TabIndex = 138;
            this.textBox_209.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label318
            // 
            this.label318.AutoSize = true;
            this.label318.Location = new System.Drawing.Point(798, 275);
            this.label318.Name = "label318";
            this.label318.Size = new System.Drawing.Size(84, 30);
            this.label318.TabIndex = 137;
            this.label318.Text = "Cell 14";
            // 
            // textBox_208
            // 
            this.textBox_208.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_208.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_208.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_208.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_208.Location = new System.Drawing.Point(901, 292);
            this.textBox_208.Multiline = true;
            this.textBox_208.Name = "textBox_208";
            this.textBox_208.ReadOnly = true;
            this.textBox_208.Size = new System.Drawing.Size(75, 25);
            this.textBox_208.TabIndex = 136;
            this.textBox_208.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_207
            // 
            this.textBox_207.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_207.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_207.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_207.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_207.Location = new System.Drawing.Point(901, 261);
            this.textBox_207.Multiline = true;
            this.textBox_207.Name = "textBox_207";
            this.textBox_207.ReadOnly = true;
            this.textBox_207.Size = new System.Drawing.Size(75, 25);
            this.textBox_207.TabIndex = 135;
            this.textBox_207.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label319
            // 
            this.label319.AutoSize = true;
            this.label319.Location = new System.Drawing.Point(798, 174);
            this.label319.Name = "label319";
            this.label319.Size = new System.Drawing.Size(84, 30);
            this.label319.TabIndex = 134;
            this.label319.Text = "Cell 13";
            // 
            // textBox_206
            // 
            this.textBox_206.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_206.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_206.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_206.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_206.Location = new System.Drawing.Point(901, 192);
            this.textBox_206.Multiline = true;
            this.textBox_206.Name = "textBox_206";
            this.textBox_206.ReadOnly = true;
            this.textBox_206.Size = new System.Drawing.Size(75, 25);
            this.textBox_206.TabIndex = 133;
            this.textBox_206.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_205
            // 
            this.textBox_205.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_205.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_205.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_205.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_205.Location = new System.Drawing.Point(901, 161);
            this.textBox_205.Multiline = true;
            this.textBox_205.Name = "textBox_205";
            this.textBox_205.ReadOnly = true;
            this.textBox_205.Size = new System.Drawing.Size(75, 25);
            this.textBox_205.TabIndex = 132;
            this.textBox_205.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label320
            // 
            this.label320.AutoSize = true;
            this.label320.Location = new System.Drawing.Point(798, 474);
            this.label320.Name = "label320";
            this.label320.Size = new System.Drawing.Size(84, 30);
            this.label320.TabIndex = 131;
            this.label320.Text = "Cell 16";
            // 
            // textBox_212
            // 
            this.textBox_212.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_212.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_212.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_212.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_212.Location = new System.Drawing.Point(901, 492);
            this.textBox_212.Multiline = true;
            this.textBox_212.Name = "textBox_212";
            this.textBox_212.ReadOnly = true;
            this.textBox_212.Size = new System.Drawing.Size(75, 25);
            this.textBox_212.TabIndex = 130;
            this.textBox_212.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_211
            // 
            this.textBox_211.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_211.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_211.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_211.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_211.Location = new System.Drawing.Point(901, 461);
            this.textBox_211.Multiline = true;
            this.textBox_211.Name = "textBox_211";
            this.textBox_211.ReadOnly = true;
            this.textBox_211.Size = new System.Drawing.Size(75, 25);
            this.textBox_211.TabIndex = 129;
            this.textBox_211.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label321
            // 
            this.label321.AutoSize = true;
            this.label321.Location = new System.Drawing.Point(461, 575);
            this.label321.Name = "label321";
            this.label321.Size = new System.Drawing.Size(84, 30);
            this.label321.TabIndex = 128;
            this.label321.Text = "Cell 11";
            // 
            // textBox_202
            // 
            this.textBox_202.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_202.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_202.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_202.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_202.Location = new System.Drawing.Point(551, 592);
            this.textBox_202.Multiline = true;
            this.textBox_202.Name = "textBox_202";
            this.textBox_202.ReadOnly = true;
            this.textBox_202.Size = new System.Drawing.Size(75, 25);
            this.textBox_202.TabIndex = 127;
            this.textBox_202.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_201
            // 
            this.textBox_201.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_201.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_201.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_201.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_201.Location = new System.Drawing.Point(551, 561);
            this.textBox_201.Multiline = true;
            this.textBox_201.Name = "textBox_201";
            this.textBox_201.ReadOnly = true;
            this.textBox_201.Size = new System.Drawing.Size(75, 25);
            this.textBox_201.TabIndex = 126;
            this.textBox_201.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label322
            // 
            this.label322.AutoSize = true;
            this.label322.Location = new System.Drawing.Point(461, 671);
            this.label322.Name = "label322";
            this.label322.Size = new System.Drawing.Size(84, 30);
            this.label322.TabIndex = 125;
            this.label322.Text = "Cell 12";
            // 
            // textBox_204
            // 
            this.textBox_204.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_204.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_204.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_204.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_204.Location = new System.Drawing.Point(551, 692);
            this.textBox_204.Multiline = true;
            this.textBox_204.Name = "textBox_204";
            this.textBox_204.ReadOnly = true;
            this.textBox_204.Size = new System.Drawing.Size(75, 25);
            this.textBox_204.TabIndex = 124;
            this.textBox_204.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_203
            // 
            this.textBox_203.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_203.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_203.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_203.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_203.Location = new System.Drawing.Point(551, 661);
            this.textBox_203.Multiline = true;
            this.textBox_203.Name = "textBox_203";
            this.textBox_203.ReadOnly = true;
            this.textBox_203.Size = new System.Drawing.Size(75, 25);
            this.textBox_203.TabIndex = 123;
            this.textBox_203.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label323
            // 
            this.label323.AutoSize = true;
            this.label323.Location = new System.Drawing.Point(461, 375);
            this.label323.Name = "label323";
            this.label323.Size = new System.Drawing.Size(70, 30);
            this.label323.TabIndex = 122;
            this.label323.Text = "Cell 9";
            // 
            // textBox_198
            // 
            this.textBox_198.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_198.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_198.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_198.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_198.Location = new System.Drawing.Point(551, 392);
            this.textBox_198.Multiline = true;
            this.textBox_198.Name = "textBox_198";
            this.textBox_198.ReadOnly = true;
            this.textBox_198.Size = new System.Drawing.Size(75, 25);
            this.textBox_198.TabIndex = 121;
            this.textBox_198.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_197
            // 
            this.textBox_197.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_197.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_197.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_197.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_197.Location = new System.Drawing.Point(551, 361);
            this.textBox_197.Multiline = true;
            this.textBox_197.Name = "textBox_197";
            this.textBox_197.ReadOnly = true;
            this.textBox_197.Size = new System.Drawing.Size(75, 25);
            this.textBox_197.TabIndex = 120;
            this.textBox_197.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label324
            // 
            this.label324.AutoSize = true;
            this.label324.Location = new System.Drawing.Point(461, 275);
            this.label324.Name = "label324";
            this.label324.Size = new System.Drawing.Size(70, 30);
            this.label324.TabIndex = 119;
            this.label324.Text = "Cell 8";
            // 
            // textBox_196
            // 
            this.textBox_196.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_196.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_196.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_196.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_196.Location = new System.Drawing.Point(551, 292);
            this.textBox_196.Multiline = true;
            this.textBox_196.Name = "textBox_196";
            this.textBox_196.ReadOnly = true;
            this.textBox_196.Size = new System.Drawing.Size(75, 25);
            this.textBox_196.TabIndex = 118;
            this.textBox_196.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_195
            // 
            this.textBox_195.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_195.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_195.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_195.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_195.Location = new System.Drawing.Point(551, 261);
            this.textBox_195.Multiline = true;
            this.textBox_195.Name = "textBox_195";
            this.textBox_195.ReadOnly = true;
            this.textBox_195.Size = new System.Drawing.Size(75, 25);
            this.textBox_195.TabIndex = 117;
            this.textBox_195.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label325
            // 
            this.label325.AutoSize = true;
            this.label325.Location = new System.Drawing.Point(461, 174);
            this.label325.Name = "label325";
            this.label325.Size = new System.Drawing.Size(70, 30);
            this.label325.TabIndex = 116;
            this.label325.Text = "Cell 7";
            // 
            // textBox_194
            // 
            this.textBox_194.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_194.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_194.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_194.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_194.Location = new System.Drawing.Point(551, 192);
            this.textBox_194.Multiline = true;
            this.textBox_194.Name = "textBox_194";
            this.textBox_194.ReadOnly = true;
            this.textBox_194.Size = new System.Drawing.Size(75, 25);
            this.textBox_194.TabIndex = 115;
            this.textBox_194.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_193
            // 
            this.textBox_193.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_193.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_193.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_193.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_193.Location = new System.Drawing.Point(551, 161);
            this.textBox_193.Multiline = true;
            this.textBox_193.Name = "textBox_193";
            this.textBox_193.ReadOnly = true;
            this.textBox_193.Size = new System.Drawing.Size(75, 25);
            this.textBox_193.TabIndex = 114;
            this.textBox_193.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label326
            // 
            this.label326.AutoSize = true;
            this.label326.Location = new System.Drawing.Point(461, 474);
            this.label326.Name = "label326";
            this.label326.Size = new System.Drawing.Size(84, 30);
            this.label326.TabIndex = 113;
            this.label326.Text = "Cell 10";
            // 
            // textBox_200
            // 
            this.textBox_200.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_200.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_200.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_200.Location = new System.Drawing.Point(551, 492);
            this.textBox_200.Multiline = true;
            this.textBox_200.Name = "textBox_200";
            this.textBox_200.ReadOnly = true;
            this.textBox_200.Size = new System.Drawing.Size(75, 25);
            this.textBox_200.TabIndex = 112;
            this.textBox_200.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_199
            // 
            this.textBox_199.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_199.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_199.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_199.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_199.Location = new System.Drawing.Point(551, 461);
            this.textBox_199.Multiline = true;
            this.textBox_199.Name = "textBox_199";
            this.textBox_199.ReadOnly = true;
            this.textBox_199.Size = new System.Drawing.Size(75, 25);
            this.textBox_199.TabIndex = 111;
            this.textBox_199.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label327
            // 
            this.label327.AutoSize = true;
            this.label327.Location = new System.Drawing.Point(125, 575);
            this.label327.Name = "label327";
            this.label327.Size = new System.Drawing.Size(70, 30);
            this.label327.TabIndex = 110;
            this.label327.Text = "Cell 5";
            // 
            // textBox_190
            // 
            this.textBox_190.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_190.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_190.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_190.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_190.Location = new System.Drawing.Point(201, 592);
            this.textBox_190.Multiline = true;
            this.textBox_190.Name = "textBox_190";
            this.textBox_190.ReadOnly = true;
            this.textBox_190.Size = new System.Drawing.Size(75, 25);
            this.textBox_190.TabIndex = 109;
            this.textBox_190.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_189
            // 
            this.textBox_189.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_189.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_189.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_189.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_189.Location = new System.Drawing.Point(201, 561);
            this.textBox_189.Multiline = true;
            this.textBox_189.Name = "textBox_189";
            this.textBox_189.ReadOnly = true;
            this.textBox_189.Size = new System.Drawing.Size(75, 25);
            this.textBox_189.TabIndex = 108;
            this.textBox_189.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label328
            // 
            this.label328.AutoSize = true;
            this.label328.Location = new System.Drawing.Point(125, 671);
            this.label328.Name = "label328";
            this.label328.Size = new System.Drawing.Size(70, 30);
            this.label328.TabIndex = 107;
            this.label328.Text = "Cell 6";
            // 
            // textBox_192
            // 
            this.textBox_192.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_192.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_192.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_192.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_192.Location = new System.Drawing.Point(201, 692);
            this.textBox_192.Multiline = true;
            this.textBox_192.Name = "textBox_192";
            this.textBox_192.ReadOnly = true;
            this.textBox_192.Size = new System.Drawing.Size(75, 25);
            this.textBox_192.TabIndex = 106;
            this.textBox_192.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_191
            // 
            this.textBox_191.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_191.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_191.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_191.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_191.Location = new System.Drawing.Point(201, 661);
            this.textBox_191.Multiline = true;
            this.textBox_191.Name = "textBox_191";
            this.textBox_191.ReadOnly = true;
            this.textBox_191.Size = new System.Drawing.Size(75, 25);
            this.textBox_191.TabIndex = 105;
            this.textBox_191.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label329
            // 
            this.label329.AutoSize = true;
            this.label329.Location = new System.Drawing.Point(125, 375);
            this.label329.Name = "label329";
            this.label329.Size = new System.Drawing.Size(70, 30);
            this.label329.TabIndex = 104;
            this.label329.Text = "Cell 3";
            // 
            // textBox_186
            // 
            this.textBox_186.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_186.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_186.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_186.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_186.Location = new System.Drawing.Point(201, 392);
            this.textBox_186.Multiline = true;
            this.textBox_186.Name = "textBox_186";
            this.textBox_186.ReadOnly = true;
            this.textBox_186.Size = new System.Drawing.Size(75, 25);
            this.textBox_186.TabIndex = 103;
            this.textBox_186.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_185
            // 
            this.textBox_185.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_185.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_185.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_185.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_185.Location = new System.Drawing.Point(201, 361);
            this.textBox_185.Multiline = true;
            this.textBox_185.Name = "textBox_185";
            this.textBox_185.ReadOnly = true;
            this.textBox_185.Size = new System.Drawing.Size(75, 25);
            this.textBox_185.TabIndex = 102;
            this.textBox_185.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label330
            // 
            this.label330.AutoSize = true;
            this.label330.Location = new System.Drawing.Point(125, 275);
            this.label330.Name = "label330";
            this.label330.Size = new System.Drawing.Size(70, 30);
            this.label330.TabIndex = 101;
            this.label330.Text = "Cell 2";
            // 
            // textBox_184
            // 
            this.textBox_184.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_184.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_184.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_184.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_184.Location = new System.Drawing.Point(201, 292);
            this.textBox_184.Multiline = true;
            this.textBox_184.Name = "textBox_184";
            this.textBox_184.ReadOnly = true;
            this.textBox_184.Size = new System.Drawing.Size(75, 25);
            this.textBox_184.TabIndex = 100;
            this.textBox_184.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_183
            // 
            this.textBox_183.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_183.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_183.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_183.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_183.Location = new System.Drawing.Point(201, 261);
            this.textBox_183.Multiline = true;
            this.textBox_183.Name = "textBox_183";
            this.textBox_183.ReadOnly = true;
            this.textBox_183.Size = new System.Drawing.Size(75, 25);
            this.textBox_183.TabIndex = 99;
            this.textBox_183.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label331
            // 
            this.label331.AutoSize = true;
            this.label331.Location = new System.Drawing.Point(125, 174);
            this.label331.Name = "label331";
            this.label331.Size = new System.Drawing.Size(70, 30);
            this.label331.TabIndex = 98;
            this.label331.Text = "Cell 1";
            // 
            // textBox_182
            // 
            this.textBox_182.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_182.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_182.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_182.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_182.Location = new System.Drawing.Point(201, 192);
            this.textBox_182.Multiline = true;
            this.textBox_182.Name = "textBox_182";
            this.textBox_182.ReadOnly = true;
            this.textBox_182.Size = new System.Drawing.Size(75, 25);
            this.textBox_182.TabIndex = 97;
            this.textBox_182.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_181
            // 
            this.textBox_181.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_181.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_181.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_181.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_181.Location = new System.Drawing.Point(201, 161);
            this.textBox_181.Multiline = true;
            this.textBox_181.Name = "textBox_181";
            this.textBox_181.ReadOnly = true;
            this.textBox_181.Size = new System.Drawing.Size(75, 25);
            this.textBox_181.TabIndex = 96;
            this.textBox_181.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label332
            // 
            this.label332.AutoSize = true;
            this.label332.Location = new System.Drawing.Point(125, 474);
            this.label332.Name = "label332";
            this.label332.Size = new System.Drawing.Size(70, 30);
            this.label332.TabIndex = 95;
            this.label332.Text = "Cell 4";
            // 
            // textBox_188
            // 
            this.textBox_188.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_188.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_188.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_188.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_188.Location = new System.Drawing.Point(201, 492);
            this.textBox_188.Multiline = true;
            this.textBox_188.Name = "textBox_188";
            this.textBox_188.ReadOnly = true;
            this.textBox_188.Size = new System.Drawing.Size(75, 25);
            this.textBox_188.TabIndex = 94;
            this.textBox_188.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_187
            // 
            this.textBox_187.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_187.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_187.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_187.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_187.Location = new System.Drawing.Point(201, 461);
            this.textBox_187.Multiline = true;
            this.textBox_187.Name = "textBox_187";
            this.textBox_187.ReadOnly = true;
            this.textBox_187.Size = new System.Drawing.Size(75, 25);
            this.textBox_187.TabIndex = 93;
            this.textBox_187.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stack7
            // 
            this.stack7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.stack7.Controls.Add(this.stack_7u);
            this.stack7.Controls.Add(this.clear_7);
            this.stack7.Controls.Add(this.label446);
            this.stack7.Controls.Add(this.label333);
            this.stack7.Controls.Add(this.label334);
            this.stack7.Controls.Add(this.label335);
            this.stack7.Controls.Add(this.label336);
            this.stack7.Controls.Add(this.label337);
            this.stack7.Controls.Add(this.label338);
            this.stack7.Controls.Add(this.label339);
            this.stack7.Controls.Add(this.label340);
            this.stack7.Controls.Add(this.label341);
            this.stack7.Controls.Add(this.label342);
            this.stack7.Controls.Add(this.label343);
            this.stack7.Controls.Add(this.label344);
            this.stack7.Controls.Add(this.label345);
            this.stack7.Controls.Add(this.label346);
            this.stack7.Controls.Add(this.label347);
            this.stack7.Controls.Add(this.label348);
            this.stack7.Controls.Add(this.label349);
            this.stack7.Controls.Add(this.label350);
            this.stack7.Controls.Add(this.label351);
            this.stack7.Controls.Add(this.label352);
            this.stack7.Controls.Add(this.label353);
            this.stack7.Controls.Add(this.label354);
            this.stack7.Controls.Add(this.label355);
            this.stack7.Controls.Add(this.label356);
            this.stack7.Controls.Add(this.label357);
            this.stack7.Controls.Add(this.label358);
            this.stack7.Controls.Add(this.label359);
            this.stack7.Controls.Add(this.label360);
            this.stack7.Controls.Add(this.label361);
            this.stack7.Controls.Add(this.label362);
            this.stack7.Controls.Add(this.label363);
            this.stack7.Controls.Add(this.label364);
            this.stack7.Controls.Add(this.label365);
            this.stack7.Controls.Add(this.label366);
            this.stack7.Controls.Add(this.label367);
            this.stack7.Controls.Add(this.label368);
            this.stack7.Controls.Add(this.label369);
            this.stack7.Controls.Add(this.textBox_250);
            this.stack7.Controls.Add(this.textBox_249);
            this.stack7.Controls.Add(this.label370);
            this.stack7.Controls.Add(this.textBox_252);
            this.stack7.Controls.Add(this.textBox_251);
            this.stack7.Controls.Add(this.label371);
            this.stack7.Controls.Add(this.textBox_246);
            this.stack7.Controls.Add(this.textBox_245);
            this.stack7.Controls.Add(this.label372);
            this.stack7.Controls.Add(this.textBox_244);
            this.stack7.Controls.Add(this.textBox_243);
            this.stack7.Controls.Add(this.label373);
            this.stack7.Controls.Add(this.textBox_242);
            this.stack7.Controls.Add(this.textBox_241);
            this.stack7.Controls.Add(this.label374);
            this.stack7.Controls.Add(this.textBox_248);
            this.stack7.Controls.Add(this.textBox_247);
            this.stack7.Controls.Add(this.label375);
            this.stack7.Controls.Add(this.textBox_238);
            this.stack7.Controls.Add(this.textBox_237);
            this.stack7.Controls.Add(this.label376);
            this.stack7.Controls.Add(this.textBox_240);
            this.stack7.Controls.Add(this.textBox_239);
            this.stack7.Controls.Add(this.label377);
            this.stack7.Controls.Add(this.textBox_234);
            this.stack7.Controls.Add(this.textBox_233);
            this.stack7.Controls.Add(this.label378);
            this.stack7.Controls.Add(this.textBox_232);
            this.stack7.Controls.Add(this.textBox_231);
            this.stack7.Controls.Add(this.label379);
            this.stack7.Controls.Add(this.textBox_230);
            this.stack7.Controls.Add(this.textBox_229);
            this.stack7.Controls.Add(this.label380);
            this.stack7.Controls.Add(this.textBox_236);
            this.stack7.Controls.Add(this.textBox_235);
            this.stack7.Controls.Add(this.label381);
            this.stack7.Controls.Add(this.textBox_226);
            this.stack7.Controls.Add(this.textBox_225);
            this.stack7.Controls.Add(this.label382);
            this.stack7.Controls.Add(this.textBox_228);
            this.stack7.Controls.Add(this.textBox_227);
            this.stack7.Controls.Add(this.label383);
            this.stack7.Controls.Add(this.textBox_222);
            this.stack7.Controls.Add(this.textBox_221);
            this.stack7.Controls.Add(this.label384);
            this.stack7.Controls.Add(this.textBox_220);
            this.stack7.Controls.Add(this.textBox_219);
            this.stack7.Controls.Add(this.label385);
            this.stack7.Controls.Add(this.textBox_218);
            this.stack7.Controls.Add(this.textBox_217);
            this.stack7.Controls.Add(this.label386);
            this.stack7.Controls.Add(this.textBox_224);
            this.stack7.Controls.Add(this.textBox_223);
            this.stack7.Location = new System.Drawing.Point(4, 39);
            this.stack7.Name = "stack7";
            this.stack7.Size = new System.Drawing.Size(1442, 910);
            this.stack7.TabIndex = 9;
            this.stack7.Text = "Stack 7";
            // 
            // stack_7u
            // 
            this.stack_7u.AutoSize = true;
            this.stack_7u.Font = new System.Drawing.Font("3ds Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stack_7u.Location = new System.Drawing.Point(460, 52);
            this.stack_7u.Name = "stack_7u";
            this.stack_7u.Size = new System.Drawing.Size(204, 36);
            this.stack_7u.TabIndex = 187;
            this.stack_7u.Text = "Stack voltage: -";
            // 
            // clear_7
            // 
            this.clear_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.clear_7.Location = new System.Drawing.Point(15, 52);
            this.clear_7.Name = "clear_7";
            this.clear_7.Size = new System.Drawing.Size(150, 60);
            this.clear_7.TabIndex = 185;
            this.clear_7.Text = "Clear";
            this.clear_7.UseVisualStyleBackColor = false;
            // 
            // label446
            // 
            this.label446.AutoSize = true;
            this.label446.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label446.Location = new System.Drawing.Point(10, 20);
            this.label446.Name = "label446";
            this.label446.Size = new System.Drawing.Size(86, 29);
            this.label446.TabIndex = 183;
            this.label446.Text = "Stack 7";
            // 
            // label333
            // 
            this.label333.AutoSize = true;
            this.label333.Location = new System.Drawing.Point(982, 687);
            this.label333.Name = "label333";
            this.label333.Size = new System.Drawing.Size(35, 30);
            this.label333.TabIndex = 182;
            this.label333.Text = "°C";
            // 
            // label334
            // 
            this.label334.AutoSize = true;
            this.label334.Location = new System.Drawing.Point(989, 659);
            this.label334.Name = "label334";
            this.label334.Size = new System.Drawing.Size(26, 30);
            this.label334.TabIndex = 181;
            this.label334.Text = "V";
            // 
            // label335
            // 
            this.label335.AutoSize = true;
            this.label335.Location = new System.Drawing.Point(982, 587);
            this.label335.Name = "label335";
            this.label335.Size = new System.Drawing.Size(35, 30);
            this.label335.TabIndex = 180;
            this.label335.Text = "°C";
            // 
            // label336
            // 
            this.label336.AutoSize = true;
            this.label336.Location = new System.Drawing.Point(989, 559);
            this.label336.Name = "label336";
            this.label336.Size = new System.Drawing.Size(26, 30);
            this.label336.TabIndex = 179;
            this.label336.Text = "V";
            // 
            // label337
            // 
            this.label337.AutoSize = true;
            this.label337.Location = new System.Drawing.Point(982, 487);
            this.label337.Name = "label337";
            this.label337.Size = new System.Drawing.Size(35, 30);
            this.label337.TabIndex = 178;
            this.label337.Text = "°C";
            // 
            // label338
            // 
            this.label338.AutoSize = true;
            this.label338.Location = new System.Drawing.Point(989, 459);
            this.label338.Name = "label338";
            this.label338.Size = new System.Drawing.Size(26, 30);
            this.label338.TabIndex = 177;
            this.label338.Text = "V";
            // 
            // label339
            // 
            this.label339.AutoSize = true;
            this.label339.Location = new System.Drawing.Point(982, 387);
            this.label339.Name = "label339";
            this.label339.Size = new System.Drawing.Size(35, 30);
            this.label339.TabIndex = 176;
            this.label339.Text = "°C";
            // 
            // label340
            // 
            this.label340.AutoSize = true;
            this.label340.Location = new System.Drawing.Point(989, 359);
            this.label340.Name = "label340";
            this.label340.Size = new System.Drawing.Size(26, 30);
            this.label340.TabIndex = 175;
            this.label340.Text = "V";
            // 
            // label341
            // 
            this.label341.AutoSize = true;
            this.label341.Location = new System.Drawing.Point(982, 287);
            this.label341.Name = "label341";
            this.label341.Size = new System.Drawing.Size(35, 30);
            this.label341.TabIndex = 174;
            this.label341.Text = "°C";
            // 
            // label342
            // 
            this.label342.AutoSize = true;
            this.label342.Location = new System.Drawing.Point(989, 259);
            this.label342.Name = "label342";
            this.label342.Size = new System.Drawing.Size(26, 30);
            this.label342.TabIndex = 173;
            this.label342.Text = "V";
            // 
            // label343
            // 
            this.label343.AutoSize = true;
            this.label343.Location = new System.Drawing.Point(982, 191);
            this.label343.Name = "label343";
            this.label343.Size = new System.Drawing.Size(35, 30);
            this.label343.TabIndex = 172;
            this.label343.Text = "°C";
            // 
            // label344
            // 
            this.label344.AutoSize = true;
            this.label344.Location = new System.Drawing.Point(989, 163);
            this.label344.Name = "label344";
            this.label344.Size = new System.Drawing.Size(26, 30);
            this.label344.TabIndex = 171;
            this.label344.Text = "V";
            // 
            // label345
            // 
            this.label345.AutoSize = true;
            this.label345.Location = new System.Drawing.Point(632, 687);
            this.label345.Name = "label345";
            this.label345.Size = new System.Drawing.Size(35, 30);
            this.label345.TabIndex = 170;
            this.label345.Text = "°C";
            // 
            // label346
            // 
            this.label346.AutoSize = true;
            this.label346.Location = new System.Drawing.Point(639, 659);
            this.label346.Name = "label346";
            this.label346.Size = new System.Drawing.Size(26, 30);
            this.label346.TabIndex = 169;
            this.label346.Text = "V";
            // 
            // label347
            // 
            this.label347.AutoSize = true;
            this.label347.Location = new System.Drawing.Point(632, 587);
            this.label347.Name = "label347";
            this.label347.Size = new System.Drawing.Size(35, 30);
            this.label347.TabIndex = 168;
            this.label347.Text = "°C";
            // 
            // label348
            // 
            this.label348.AutoSize = true;
            this.label348.Location = new System.Drawing.Point(639, 559);
            this.label348.Name = "label348";
            this.label348.Size = new System.Drawing.Size(26, 30);
            this.label348.TabIndex = 167;
            this.label348.Text = "V";
            // 
            // label349
            // 
            this.label349.AutoSize = true;
            this.label349.Location = new System.Drawing.Point(632, 487);
            this.label349.Name = "label349";
            this.label349.Size = new System.Drawing.Size(35, 30);
            this.label349.TabIndex = 166;
            this.label349.Text = "°C";
            // 
            // label350
            // 
            this.label350.AutoSize = true;
            this.label350.Location = new System.Drawing.Point(639, 459);
            this.label350.Name = "label350";
            this.label350.Size = new System.Drawing.Size(26, 30);
            this.label350.TabIndex = 165;
            this.label350.Text = "V";
            // 
            // label351
            // 
            this.label351.AutoSize = true;
            this.label351.Location = new System.Drawing.Point(632, 387);
            this.label351.Name = "label351";
            this.label351.Size = new System.Drawing.Size(35, 30);
            this.label351.TabIndex = 164;
            this.label351.Text = "°C";
            // 
            // label352
            // 
            this.label352.AutoSize = true;
            this.label352.Location = new System.Drawing.Point(639, 359);
            this.label352.Name = "label352";
            this.label352.Size = new System.Drawing.Size(26, 30);
            this.label352.TabIndex = 163;
            this.label352.Text = "V";
            // 
            // label353
            // 
            this.label353.AutoSize = true;
            this.label353.Location = new System.Drawing.Point(632, 287);
            this.label353.Name = "label353";
            this.label353.Size = new System.Drawing.Size(35, 30);
            this.label353.TabIndex = 162;
            this.label353.Text = "°C";
            // 
            // label354
            // 
            this.label354.AutoSize = true;
            this.label354.Location = new System.Drawing.Point(639, 259);
            this.label354.Name = "label354";
            this.label354.Size = new System.Drawing.Size(26, 30);
            this.label354.TabIndex = 161;
            this.label354.Text = "V";
            // 
            // label355
            // 
            this.label355.AutoSize = true;
            this.label355.Location = new System.Drawing.Point(632, 187);
            this.label355.Name = "label355";
            this.label355.Size = new System.Drawing.Size(35, 30);
            this.label355.TabIndex = 160;
            this.label355.Text = "°C";
            // 
            // label356
            // 
            this.label356.AutoSize = true;
            this.label356.Location = new System.Drawing.Point(639, 159);
            this.label356.Name = "label356";
            this.label356.Size = new System.Drawing.Size(26, 30);
            this.label356.TabIndex = 159;
            this.label356.Text = "V";
            // 
            // label357
            // 
            this.label357.AutoSize = true;
            this.label357.Location = new System.Drawing.Point(282, 687);
            this.label357.Name = "label357";
            this.label357.Size = new System.Drawing.Size(35, 30);
            this.label357.TabIndex = 158;
            this.label357.Text = "°C";
            // 
            // label358
            // 
            this.label358.AutoSize = true;
            this.label358.Location = new System.Drawing.Point(289, 659);
            this.label358.Name = "label358";
            this.label358.Size = new System.Drawing.Size(26, 30);
            this.label358.TabIndex = 157;
            this.label358.Text = "V";
            // 
            // label359
            // 
            this.label359.AutoSize = true;
            this.label359.Location = new System.Drawing.Point(282, 587);
            this.label359.Name = "label359";
            this.label359.Size = new System.Drawing.Size(35, 30);
            this.label359.TabIndex = 156;
            this.label359.Text = "°C";
            // 
            // label360
            // 
            this.label360.AutoSize = true;
            this.label360.Location = new System.Drawing.Point(289, 559);
            this.label360.Name = "label360";
            this.label360.Size = new System.Drawing.Size(26, 30);
            this.label360.TabIndex = 155;
            this.label360.Text = "V";
            // 
            // label361
            // 
            this.label361.AutoSize = true;
            this.label361.Location = new System.Drawing.Point(282, 487);
            this.label361.Name = "label361";
            this.label361.Size = new System.Drawing.Size(35, 30);
            this.label361.TabIndex = 154;
            this.label361.Text = "°C";
            // 
            // label362
            // 
            this.label362.AutoSize = true;
            this.label362.Location = new System.Drawing.Point(289, 459);
            this.label362.Name = "label362";
            this.label362.Size = new System.Drawing.Size(26, 30);
            this.label362.TabIndex = 153;
            this.label362.Text = "V";
            // 
            // label363
            // 
            this.label363.AutoSize = true;
            this.label363.Location = new System.Drawing.Point(282, 387);
            this.label363.Name = "label363";
            this.label363.Size = new System.Drawing.Size(35, 30);
            this.label363.TabIndex = 152;
            this.label363.Text = "°C";
            // 
            // label364
            // 
            this.label364.AutoSize = true;
            this.label364.Location = new System.Drawing.Point(289, 359);
            this.label364.Name = "label364";
            this.label364.Size = new System.Drawing.Size(26, 30);
            this.label364.TabIndex = 151;
            this.label364.Text = "V";
            // 
            // label365
            // 
            this.label365.AutoSize = true;
            this.label365.Location = new System.Drawing.Point(282, 287);
            this.label365.Name = "label365";
            this.label365.Size = new System.Drawing.Size(35, 30);
            this.label365.TabIndex = 150;
            this.label365.Text = "°C";
            // 
            // label366
            // 
            this.label366.AutoSize = true;
            this.label366.Location = new System.Drawing.Point(289, 259);
            this.label366.Name = "label366";
            this.label366.Size = new System.Drawing.Size(26, 30);
            this.label366.TabIndex = 149;
            this.label366.Text = "V";
            // 
            // label367
            // 
            this.label367.AutoSize = true;
            this.label367.Location = new System.Drawing.Point(282, 187);
            this.label367.Name = "label367";
            this.label367.Size = new System.Drawing.Size(35, 30);
            this.label367.TabIndex = 148;
            this.label367.Text = "°C";
            // 
            // label368
            // 
            this.label368.AutoSize = true;
            this.label368.Location = new System.Drawing.Point(289, 159);
            this.label368.Name = "label368";
            this.label368.Size = new System.Drawing.Size(26, 30);
            this.label368.TabIndex = 147;
            this.label368.Text = "V";
            // 
            // label369
            // 
            this.label369.AutoSize = true;
            this.label369.Location = new System.Drawing.Point(798, 575);
            this.label369.Name = "label369";
            this.label369.Size = new System.Drawing.Size(84, 30);
            this.label369.TabIndex = 146;
            this.label369.Text = "Cell 17";
            // 
            // textBox_250
            // 
            this.textBox_250.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_250.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_250.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_250.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_250.Location = new System.Drawing.Point(901, 592);
            this.textBox_250.Multiline = true;
            this.textBox_250.Name = "textBox_250";
            this.textBox_250.ReadOnly = true;
            this.textBox_250.Size = new System.Drawing.Size(75, 25);
            this.textBox_250.TabIndex = 145;
            this.textBox_250.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_249
            // 
            this.textBox_249.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_249.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_249.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_249.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_249.Location = new System.Drawing.Point(901, 561);
            this.textBox_249.Multiline = true;
            this.textBox_249.Name = "textBox_249";
            this.textBox_249.ReadOnly = true;
            this.textBox_249.Size = new System.Drawing.Size(75, 25);
            this.textBox_249.TabIndex = 144;
            this.textBox_249.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label370
            // 
            this.label370.AutoSize = true;
            this.label370.Location = new System.Drawing.Point(798, 671);
            this.label370.Name = "label370";
            this.label370.Size = new System.Drawing.Size(84, 30);
            this.label370.TabIndex = 143;
            this.label370.Text = "Cell 18";
            // 
            // textBox_252
            // 
            this.textBox_252.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_252.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_252.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_252.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_252.Location = new System.Drawing.Point(901, 692);
            this.textBox_252.Multiline = true;
            this.textBox_252.Name = "textBox_252";
            this.textBox_252.ReadOnly = true;
            this.textBox_252.Size = new System.Drawing.Size(75, 25);
            this.textBox_252.TabIndex = 142;
            this.textBox_252.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_251
            // 
            this.textBox_251.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_251.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_251.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_251.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_251.Location = new System.Drawing.Point(901, 661);
            this.textBox_251.Multiline = true;
            this.textBox_251.Name = "textBox_251";
            this.textBox_251.ReadOnly = true;
            this.textBox_251.Size = new System.Drawing.Size(75, 25);
            this.textBox_251.TabIndex = 141;
            this.textBox_251.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label371
            // 
            this.label371.AutoSize = true;
            this.label371.Location = new System.Drawing.Point(798, 375);
            this.label371.Name = "label371";
            this.label371.Size = new System.Drawing.Size(84, 30);
            this.label371.TabIndex = 140;
            this.label371.Text = "Cell 15";
            // 
            // textBox_246
            // 
            this.textBox_246.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_246.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_246.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_246.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_246.Location = new System.Drawing.Point(901, 392);
            this.textBox_246.Multiline = true;
            this.textBox_246.Name = "textBox_246";
            this.textBox_246.ReadOnly = true;
            this.textBox_246.Size = new System.Drawing.Size(75, 25);
            this.textBox_246.TabIndex = 139;
            this.textBox_246.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_245
            // 
            this.textBox_245.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_245.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_245.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_245.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_245.Location = new System.Drawing.Point(901, 361);
            this.textBox_245.Multiline = true;
            this.textBox_245.Name = "textBox_245";
            this.textBox_245.ReadOnly = true;
            this.textBox_245.Size = new System.Drawing.Size(75, 25);
            this.textBox_245.TabIndex = 138;
            this.textBox_245.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label372
            // 
            this.label372.AutoSize = true;
            this.label372.Location = new System.Drawing.Point(798, 275);
            this.label372.Name = "label372";
            this.label372.Size = new System.Drawing.Size(84, 30);
            this.label372.TabIndex = 137;
            this.label372.Text = "Cell 14";
            // 
            // textBox_244
            // 
            this.textBox_244.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_244.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_244.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_244.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_244.Location = new System.Drawing.Point(901, 292);
            this.textBox_244.Multiline = true;
            this.textBox_244.Name = "textBox_244";
            this.textBox_244.ReadOnly = true;
            this.textBox_244.Size = new System.Drawing.Size(75, 25);
            this.textBox_244.TabIndex = 136;
            this.textBox_244.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_243
            // 
            this.textBox_243.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_243.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_243.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_243.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_243.Location = new System.Drawing.Point(901, 261);
            this.textBox_243.Multiline = true;
            this.textBox_243.Name = "textBox_243";
            this.textBox_243.ReadOnly = true;
            this.textBox_243.Size = new System.Drawing.Size(75, 25);
            this.textBox_243.TabIndex = 135;
            this.textBox_243.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label373
            // 
            this.label373.AutoSize = true;
            this.label373.Location = new System.Drawing.Point(798, 174);
            this.label373.Name = "label373";
            this.label373.Size = new System.Drawing.Size(84, 30);
            this.label373.TabIndex = 134;
            this.label373.Text = "Cell 13";
            // 
            // textBox_242
            // 
            this.textBox_242.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_242.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_242.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_242.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_242.Location = new System.Drawing.Point(901, 192);
            this.textBox_242.Multiline = true;
            this.textBox_242.Name = "textBox_242";
            this.textBox_242.ReadOnly = true;
            this.textBox_242.Size = new System.Drawing.Size(75, 25);
            this.textBox_242.TabIndex = 133;
            this.textBox_242.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_241
            // 
            this.textBox_241.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_241.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_241.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_241.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_241.Location = new System.Drawing.Point(901, 161);
            this.textBox_241.Multiline = true;
            this.textBox_241.Name = "textBox_241";
            this.textBox_241.ReadOnly = true;
            this.textBox_241.Size = new System.Drawing.Size(75, 25);
            this.textBox_241.TabIndex = 132;
            this.textBox_241.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label374
            // 
            this.label374.AutoSize = true;
            this.label374.Location = new System.Drawing.Point(798, 474);
            this.label374.Name = "label374";
            this.label374.Size = new System.Drawing.Size(84, 30);
            this.label374.TabIndex = 131;
            this.label374.Text = "Cell 16";
            // 
            // textBox_248
            // 
            this.textBox_248.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_248.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_248.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_248.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_248.Location = new System.Drawing.Point(901, 492);
            this.textBox_248.Multiline = true;
            this.textBox_248.Name = "textBox_248";
            this.textBox_248.ReadOnly = true;
            this.textBox_248.Size = new System.Drawing.Size(75, 25);
            this.textBox_248.TabIndex = 130;
            this.textBox_248.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_247
            // 
            this.textBox_247.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_247.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_247.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_247.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_247.Location = new System.Drawing.Point(901, 461);
            this.textBox_247.Multiline = true;
            this.textBox_247.Name = "textBox_247";
            this.textBox_247.ReadOnly = true;
            this.textBox_247.Size = new System.Drawing.Size(75, 25);
            this.textBox_247.TabIndex = 129;
            this.textBox_247.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label375
            // 
            this.label375.AutoSize = true;
            this.label375.Location = new System.Drawing.Point(461, 575);
            this.label375.Name = "label375";
            this.label375.Size = new System.Drawing.Size(84, 30);
            this.label375.TabIndex = 128;
            this.label375.Text = "Cell 11";
            // 
            // textBox_238
            // 
            this.textBox_238.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_238.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_238.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_238.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_238.Location = new System.Drawing.Point(551, 592);
            this.textBox_238.Multiline = true;
            this.textBox_238.Name = "textBox_238";
            this.textBox_238.ReadOnly = true;
            this.textBox_238.Size = new System.Drawing.Size(75, 25);
            this.textBox_238.TabIndex = 127;
            this.textBox_238.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_237
            // 
            this.textBox_237.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_237.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_237.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_237.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_237.Location = new System.Drawing.Point(551, 561);
            this.textBox_237.Multiline = true;
            this.textBox_237.Name = "textBox_237";
            this.textBox_237.ReadOnly = true;
            this.textBox_237.Size = new System.Drawing.Size(75, 25);
            this.textBox_237.TabIndex = 126;
            this.textBox_237.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label376
            // 
            this.label376.AutoSize = true;
            this.label376.Location = new System.Drawing.Point(461, 671);
            this.label376.Name = "label376";
            this.label376.Size = new System.Drawing.Size(84, 30);
            this.label376.TabIndex = 125;
            this.label376.Text = "Cell 12";
            // 
            // textBox_240
            // 
            this.textBox_240.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_240.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_240.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_240.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_240.Location = new System.Drawing.Point(551, 692);
            this.textBox_240.Multiline = true;
            this.textBox_240.Name = "textBox_240";
            this.textBox_240.ReadOnly = true;
            this.textBox_240.Size = new System.Drawing.Size(75, 25);
            this.textBox_240.TabIndex = 124;
            this.textBox_240.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_239
            // 
            this.textBox_239.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_239.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_239.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_239.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_239.Location = new System.Drawing.Point(551, 661);
            this.textBox_239.Multiline = true;
            this.textBox_239.Name = "textBox_239";
            this.textBox_239.ReadOnly = true;
            this.textBox_239.Size = new System.Drawing.Size(75, 25);
            this.textBox_239.TabIndex = 123;
            this.textBox_239.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label377
            // 
            this.label377.AutoSize = true;
            this.label377.Location = new System.Drawing.Point(461, 375);
            this.label377.Name = "label377";
            this.label377.Size = new System.Drawing.Size(70, 30);
            this.label377.TabIndex = 122;
            this.label377.Text = "Cell 9";
            // 
            // textBox_234
            // 
            this.textBox_234.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_234.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_234.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_234.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_234.Location = new System.Drawing.Point(551, 392);
            this.textBox_234.Multiline = true;
            this.textBox_234.Name = "textBox_234";
            this.textBox_234.ReadOnly = true;
            this.textBox_234.Size = new System.Drawing.Size(75, 25);
            this.textBox_234.TabIndex = 121;
            this.textBox_234.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_233
            // 
            this.textBox_233.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_233.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_233.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_233.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_233.Location = new System.Drawing.Point(551, 361);
            this.textBox_233.Multiline = true;
            this.textBox_233.Name = "textBox_233";
            this.textBox_233.ReadOnly = true;
            this.textBox_233.Size = new System.Drawing.Size(75, 25);
            this.textBox_233.TabIndex = 120;
            this.textBox_233.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label378
            // 
            this.label378.AutoSize = true;
            this.label378.Location = new System.Drawing.Point(461, 275);
            this.label378.Name = "label378";
            this.label378.Size = new System.Drawing.Size(70, 30);
            this.label378.TabIndex = 119;
            this.label378.Text = "Cell 8";
            // 
            // textBox_232
            // 
            this.textBox_232.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_232.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_232.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_232.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_232.Location = new System.Drawing.Point(551, 292);
            this.textBox_232.Multiline = true;
            this.textBox_232.Name = "textBox_232";
            this.textBox_232.ReadOnly = true;
            this.textBox_232.Size = new System.Drawing.Size(75, 25);
            this.textBox_232.TabIndex = 118;
            this.textBox_232.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_231
            // 
            this.textBox_231.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_231.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_231.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_231.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_231.Location = new System.Drawing.Point(551, 261);
            this.textBox_231.Multiline = true;
            this.textBox_231.Name = "textBox_231";
            this.textBox_231.ReadOnly = true;
            this.textBox_231.Size = new System.Drawing.Size(75, 25);
            this.textBox_231.TabIndex = 117;
            this.textBox_231.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label379
            // 
            this.label379.AutoSize = true;
            this.label379.Location = new System.Drawing.Point(461, 174);
            this.label379.Name = "label379";
            this.label379.Size = new System.Drawing.Size(70, 30);
            this.label379.TabIndex = 116;
            this.label379.Text = "Cell 7";
            // 
            // textBox_230
            // 
            this.textBox_230.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_230.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_230.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_230.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_230.Location = new System.Drawing.Point(551, 192);
            this.textBox_230.Multiline = true;
            this.textBox_230.Name = "textBox_230";
            this.textBox_230.ReadOnly = true;
            this.textBox_230.Size = new System.Drawing.Size(75, 25);
            this.textBox_230.TabIndex = 115;
            this.textBox_230.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_229
            // 
            this.textBox_229.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_229.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_229.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_229.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_229.Location = new System.Drawing.Point(551, 161);
            this.textBox_229.Multiline = true;
            this.textBox_229.Name = "textBox_229";
            this.textBox_229.ReadOnly = true;
            this.textBox_229.Size = new System.Drawing.Size(75, 25);
            this.textBox_229.TabIndex = 114;
            this.textBox_229.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label380
            // 
            this.label380.AutoSize = true;
            this.label380.Location = new System.Drawing.Point(461, 474);
            this.label380.Name = "label380";
            this.label380.Size = new System.Drawing.Size(84, 30);
            this.label380.TabIndex = 113;
            this.label380.Text = "Cell 10";
            // 
            // textBox_236
            // 
            this.textBox_236.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_236.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_236.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_236.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_236.Location = new System.Drawing.Point(551, 492);
            this.textBox_236.Multiline = true;
            this.textBox_236.Name = "textBox_236";
            this.textBox_236.ReadOnly = true;
            this.textBox_236.Size = new System.Drawing.Size(75, 25);
            this.textBox_236.TabIndex = 112;
            this.textBox_236.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_235
            // 
            this.textBox_235.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_235.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_235.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_235.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_235.Location = new System.Drawing.Point(551, 461);
            this.textBox_235.Multiline = true;
            this.textBox_235.Name = "textBox_235";
            this.textBox_235.ReadOnly = true;
            this.textBox_235.Size = new System.Drawing.Size(75, 25);
            this.textBox_235.TabIndex = 111;
            this.textBox_235.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label381
            // 
            this.label381.AutoSize = true;
            this.label381.Location = new System.Drawing.Point(125, 575);
            this.label381.Name = "label381";
            this.label381.Size = new System.Drawing.Size(70, 30);
            this.label381.TabIndex = 110;
            this.label381.Text = "Cell 5";
            // 
            // textBox_226
            // 
            this.textBox_226.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_226.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_226.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_226.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_226.Location = new System.Drawing.Point(201, 592);
            this.textBox_226.Multiline = true;
            this.textBox_226.Name = "textBox_226";
            this.textBox_226.ReadOnly = true;
            this.textBox_226.Size = new System.Drawing.Size(75, 25);
            this.textBox_226.TabIndex = 109;
            this.textBox_226.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_225
            // 
            this.textBox_225.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_225.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_225.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_225.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_225.Location = new System.Drawing.Point(201, 561);
            this.textBox_225.Multiline = true;
            this.textBox_225.Name = "textBox_225";
            this.textBox_225.ReadOnly = true;
            this.textBox_225.Size = new System.Drawing.Size(75, 25);
            this.textBox_225.TabIndex = 108;
            this.textBox_225.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label382
            // 
            this.label382.AutoSize = true;
            this.label382.Location = new System.Drawing.Point(125, 671);
            this.label382.Name = "label382";
            this.label382.Size = new System.Drawing.Size(70, 30);
            this.label382.TabIndex = 107;
            this.label382.Text = "Cell 6";
            // 
            // textBox_228
            // 
            this.textBox_228.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_228.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_228.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_228.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_228.Location = new System.Drawing.Point(201, 692);
            this.textBox_228.Multiline = true;
            this.textBox_228.Name = "textBox_228";
            this.textBox_228.ReadOnly = true;
            this.textBox_228.Size = new System.Drawing.Size(75, 25);
            this.textBox_228.TabIndex = 106;
            this.textBox_228.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_227
            // 
            this.textBox_227.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_227.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_227.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_227.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_227.Location = new System.Drawing.Point(201, 661);
            this.textBox_227.Multiline = true;
            this.textBox_227.Name = "textBox_227";
            this.textBox_227.ReadOnly = true;
            this.textBox_227.Size = new System.Drawing.Size(75, 25);
            this.textBox_227.TabIndex = 105;
            this.textBox_227.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label383
            // 
            this.label383.AutoSize = true;
            this.label383.Location = new System.Drawing.Point(125, 375);
            this.label383.Name = "label383";
            this.label383.Size = new System.Drawing.Size(70, 30);
            this.label383.TabIndex = 104;
            this.label383.Text = "Cell 3";
            // 
            // textBox_222
            // 
            this.textBox_222.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_222.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_222.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_222.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_222.Location = new System.Drawing.Point(201, 392);
            this.textBox_222.Multiline = true;
            this.textBox_222.Name = "textBox_222";
            this.textBox_222.ReadOnly = true;
            this.textBox_222.Size = new System.Drawing.Size(75, 25);
            this.textBox_222.TabIndex = 103;
            this.textBox_222.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_221
            // 
            this.textBox_221.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_221.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_221.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_221.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_221.Location = new System.Drawing.Point(201, 361);
            this.textBox_221.Multiline = true;
            this.textBox_221.Name = "textBox_221";
            this.textBox_221.ReadOnly = true;
            this.textBox_221.Size = new System.Drawing.Size(75, 25);
            this.textBox_221.TabIndex = 102;
            this.textBox_221.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label384
            // 
            this.label384.AutoSize = true;
            this.label384.Location = new System.Drawing.Point(125, 275);
            this.label384.Name = "label384";
            this.label384.Size = new System.Drawing.Size(70, 30);
            this.label384.TabIndex = 101;
            this.label384.Text = "Cell 2";
            // 
            // textBox_220
            // 
            this.textBox_220.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_220.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_220.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_220.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_220.Location = new System.Drawing.Point(201, 292);
            this.textBox_220.Multiline = true;
            this.textBox_220.Name = "textBox_220";
            this.textBox_220.ReadOnly = true;
            this.textBox_220.Size = new System.Drawing.Size(75, 25);
            this.textBox_220.TabIndex = 100;
            this.textBox_220.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_219
            // 
            this.textBox_219.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_219.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_219.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_219.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_219.Location = new System.Drawing.Point(201, 261);
            this.textBox_219.Multiline = true;
            this.textBox_219.Name = "textBox_219";
            this.textBox_219.ReadOnly = true;
            this.textBox_219.Size = new System.Drawing.Size(75, 25);
            this.textBox_219.TabIndex = 99;
            this.textBox_219.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label385
            // 
            this.label385.AutoSize = true;
            this.label385.Location = new System.Drawing.Point(125, 174);
            this.label385.Name = "label385";
            this.label385.Size = new System.Drawing.Size(70, 30);
            this.label385.TabIndex = 98;
            this.label385.Text = "Cell 1";
            // 
            // textBox_218
            // 
            this.textBox_218.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_218.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_218.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_218.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_218.Location = new System.Drawing.Point(201, 192);
            this.textBox_218.Multiline = true;
            this.textBox_218.Name = "textBox_218";
            this.textBox_218.ReadOnly = true;
            this.textBox_218.Size = new System.Drawing.Size(75, 25);
            this.textBox_218.TabIndex = 97;
            this.textBox_218.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_217
            // 
            this.textBox_217.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_217.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_217.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_217.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_217.Location = new System.Drawing.Point(201, 161);
            this.textBox_217.Multiline = true;
            this.textBox_217.Name = "textBox_217";
            this.textBox_217.ReadOnly = true;
            this.textBox_217.Size = new System.Drawing.Size(75, 25);
            this.textBox_217.TabIndex = 96;
            this.textBox_217.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label386
            // 
            this.label386.AutoSize = true;
            this.label386.Location = new System.Drawing.Point(125, 474);
            this.label386.Name = "label386";
            this.label386.Size = new System.Drawing.Size(70, 30);
            this.label386.TabIndex = 95;
            this.label386.Text = "Cell 4";
            // 
            // textBox_224
            // 
            this.textBox_224.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_224.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_224.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_224.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_224.Location = new System.Drawing.Point(201, 492);
            this.textBox_224.Multiline = true;
            this.textBox_224.Name = "textBox_224";
            this.textBox_224.ReadOnly = true;
            this.textBox_224.Size = new System.Drawing.Size(75, 25);
            this.textBox_224.TabIndex = 94;
            this.textBox_224.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_223
            // 
            this.textBox_223.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_223.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_223.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_223.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_223.Location = new System.Drawing.Point(201, 461);
            this.textBox_223.Multiline = true;
            this.textBox_223.Name = "textBox_223";
            this.textBox_223.ReadOnly = true;
            this.textBox_223.Size = new System.Drawing.Size(75, 25);
            this.textBox_223.TabIndex = 93;
            this.textBox_223.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stack8
            // 
            this.stack8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.stack8.Controls.Add(this.stack_8u);
            this.stack8.Controls.Add(this.clear_8);
            this.stack8.Controls.Add(this.label447);
            this.stack8.Controls.Add(this.label387);
            this.stack8.Controls.Add(this.label388);
            this.stack8.Controls.Add(this.label389);
            this.stack8.Controls.Add(this.label390);
            this.stack8.Controls.Add(this.label391);
            this.stack8.Controls.Add(this.label392);
            this.stack8.Controls.Add(this.label393);
            this.stack8.Controls.Add(this.label394);
            this.stack8.Controls.Add(this.label395);
            this.stack8.Controls.Add(this.label396);
            this.stack8.Controls.Add(this.label397);
            this.stack8.Controls.Add(this.label398);
            this.stack8.Controls.Add(this.label399);
            this.stack8.Controls.Add(this.label400);
            this.stack8.Controls.Add(this.label401);
            this.stack8.Controls.Add(this.label402);
            this.stack8.Controls.Add(this.label403);
            this.stack8.Controls.Add(this.label404);
            this.stack8.Controls.Add(this.label405);
            this.stack8.Controls.Add(this.label406);
            this.stack8.Controls.Add(this.label407);
            this.stack8.Controls.Add(this.label408);
            this.stack8.Controls.Add(this.label409);
            this.stack8.Controls.Add(this.label410);
            this.stack8.Controls.Add(this.label411);
            this.stack8.Controls.Add(this.label412);
            this.stack8.Controls.Add(this.label413);
            this.stack8.Controls.Add(this.label414);
            this.stack8.Controls.Add(this.label415);
            this.stack8.Controls.Add(this.label416);
            this.stack8.Controls.Add(this.label417);
            this.stack8.Controls.Add(this.label418);
            this.stack8.Controls.Add(this.label419);
            this.stack8.Controls.Add(this.label420);
            this.stack8.Controls.Add(this.label421);
            this.stack8.Controls.Add(this.label422);
            this.stack8.Controls.Add(this.label423);
            this.stack8.Controls.Add(this.textBox_286);
            this.stack8.Controls.Add(this.textBox_285);
            this.stack8.Controls.Add(this.label424);
            this.stack8.Controls.Add(this.textBox_288);
            this.stack8.Controls.Add(this.textBox_287);
            this.stack8.Controls.Add(this.label425);
            this.stack8.Controls.Add(this.textBox_282);
            this.stack8.Controls.Add(this.textBox_281);
            this.stack8.Controls.Add(this.label426);
            this.stack8.Controls.Add(this.textBox_280);
            this.stack8.Controls.Add(this.textBox_279);
            this.stack8.Controls.Add(this.label427);
            this.stack8.Controls.Add(this.textBox_278);
            this.stack8.Controls.Add(this.textBox_277);
            this.stack8.Controls.Add(this.label428);
            this.stack8.Controls.Add(this.textBox_284);
            this.stack8.Controls.Add(this.textBox_283);
            this.stack8.Controls.Add(this.label429);
            this.stack8.Controls.Add(this.textBox_274);
            this.stack8.Controls.Add(this.textBox_273);
            this.stack8.Controls.Add(this.label430);
            this.stack8.Controls.Add(this.textBox_276);
            this.stack8.Controls.Add(this.textBox_275);
            this.stack8.Controls.Add(this.label431);
            this.stack8.Controls.Add(this.textBox_270);
            this.stack8.Controls.Add(this.textBox_269);
            this.stack8.Controls.Add(this.label432);
            this.stack8.Controls.Add(this.textBox_268);
            this.stack8.Controls.Add(this.textBox_267);
            this.stack8.Controls.Add(this.label433);
            this.stack8.Controls.Add(this.textBox_266);
            this.stack8.Controls.Add(this.textBox_265);
            this.stack8.Controls.Add(this.label434);
            this.stack8.Controls.Add(this.textBox_272);
            this.stack8.Controls.Add(this.textBox_271);
            this.stack8.Controls.Add(this.label435);
            this.stack8.Controls.Add(this.textBox_262);
            this.stack8.Controls.Add(this.textBox_261);
            this.stack8.Controls.Add(this.label436);
            this.stack8.Controls.Add(this.textBox_264);
            this.stack8.Controls.Add(this.textBox_263);
            this.stack8.Controls.Add(this.label437);
            this.stack8.Controls.Add(this.textBox_258);
            this.stack8.Controls.Add(this.textBox_257);
            this.stack8.Controls.Add(this.label438);
            this.stack8.Controls.Add(this.textBox_256);
            this.stack8.Controls.Add(this.textBox_255);
            this.stack8.Controls.Add(this.label439);
            this.stack8.Controls.Add(this.textBox_254);
            this.stack8.Controls.Add(this.textBox_253);
            this.stack8.Controls.Add(this.label440);
            this.stack8.Controls.Add(this.textBox_260);
            this.stack8.Controls.Add(this.textBox_259);
            this.stack8.Location = new System.Drawing.Point(4, 39);
            this.stack8.Name = "stack8";
            this.stack8.Size = new System.Drawing.Size(1442, 910);
            this.stack8.TabIndex = 10;
            this.stack8.Text = "Stack 8";
            // 
            // stack_8u
            // 
            this.stack_8u.AutoSize = true;
            this.stack_8u.Font = new System.Drawing.Font("3ds Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stack_8u.Location = new System.Drawing.Point(460, 52);
            this.stack_8u.Name = "stack_8u";
            this.stack_8u.Size = new System.Drawing.Size(204, 36);
            this.stack_8u.TabIndex = 187;
            this.stack_8u.Text = "Stack voltage: -";
            // 
            // clear_8
            // 
            this.clear_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.clear_8.Location = new System.Drawing.Point(15, 52);
            this.clear_8.Name = "clear_8";
            this.clear_8.Size = new System.Drawing.Size(150, 60);
            this.clear_8.TabIndex = 185;
            this.clear_8.Text = "Clear";
            this.clear_8.UseVisualStyleBackColor = false;
            // 
            // label447
            // 
            this.label447.AutoSize = true;
            this.label447.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label447.Location = new System.Drawing.Point(10, 20);
            this.label447.Name = "label447";
            this.label447.Size = new System.Drawing.Size(86, 29);
            this.label447.TabIndex = 183;
            this.label447.Text = "Stack 8";
            // 
            // label387
            // 
            this.label387.AutoSize = true;
            this.label387.Location = new System.Drawing.Point(982, 687);
            this.label387.Name = "label387";
            this.label387.Size = new System.Drawing.Size(35, 30);
            this.label387.TabIndex = 182;
            this.label387.Text = "°C";
            // 
            // label388
            // 
            this.label388.AutoSize = true;
            this.label388.Location = new System.Drawing.Point(989, 659);
            this.label388.Name = "label388";
            this.label388.Size = new System.Drawing.Size(26, 30);
            this.label388.TabIndex = 181;
            this.label388.Text = "V";
            // 
            // label389
            // 
            this.label389.AutoSize = true;
            this.label389.Location = new System.Drawing.Point(982, 587);
            this.label389.Name = "label389";
            this.label389.Size = new System.Drawing.Size(35, 30);
            this.label389.TabIndex = 180;
            this.label389.Text = "°C";
            // 
            // label390
            // 
            this.label390.AutoSize = true;
            this.label390.Location = new System.Drawing.Point(989, 559);
            this.label390.Name = "label390";
            this.label390.Size = new System.Drawing.Size(26, 30);
            this.label390.TabIndex = 179;
            this.label390.Text = "V";
            // 
            // label391
            // 
            this.label391.AutoSize = true;
            this.label391.Location = new System.Drawing.Point(982, 487);
            this.label391.Name = "label391";
            this.label391.Size = new System.Drawing.Size(35, 30);
            this.label391.TabIndex = 178;
            this.label391.Text = "°C";
            // 
            // label392
            // 
            this.label392.AutoSize = true;
            this.label392.Location = new System.Drawing.Point(989, 459);
            this.label392.Name = "label392";
            this.label392.Size = new System.Drawing.Size(26, 30);
            this.label392.TabIndex = 177;
            this.label392.Text = "V";
            // 
            // label393
            // 
            this.label393.AutoSize = true;
            this.label393.Location = new System.Drawing.Point(982, 387);
            this.label393.Name = "label393";
            this.label393.Size = new System.Drawing.Size(35, 30);
            this.label393.TabIndex = 176;
            this.label393.Text = "°C";
            // 
            // label394
            // 
            this.label394.AutoSize = true;
            this.label394.Location = new System.Drawing.Point(989, 359);
            this.label394.Name = "label394";
            this.label394.Size = new System.Drawing.Size(26, 30);
            this.label394.TabIndex = 175;
            this.label394.Text = "V";
            // 
            // label395
            // 
            this.label395.AutoSize = true;
            this.label395.Location = new System.Drawing.Point(982, 287);
            this.label395.Name = "label395";
            this.label395.Size = new System.Drawing.Size(35, 30);
            this.label395.TabIndex = 174;
            this.label395.Text = "°C";
            // 
            // label396
            // 
            this.label396.AutoSize = true;
            this.label396.Location = new System.Drawing.Point(989, 259);
            this.label396.Name = "label396";
            this.label396.Size = new System.Drawing.Size(26, 30);
            this.label396.TabIndex = 173;
            this.label396.Text = "V";
            // 
            // label397
            // 
            this.label397.AutoSize = true;
            this.label397.Location = new System.Drawing.Point(982, 191);
            this.label397.Name = "label397";
            this.label397.Size = new System.Drawing.Size(35, 30);
            this.label397.TabIndex = 172;
            this.label397.Text = "°C";
            // 
            // label398
            // 
            this.label398.AutoSize = true;
            this.label398.Location = new System.Drawing.Point(989, 163);
            this.label398.Name = "label398";
            this.label398.Size = new System.Drawing.Size(26, 30);
            this.label398.TabIndex = 171;
            this.label398.Text = "V";
            // 
            // label399
            // 
            this.label399.AutoSize = true;
            this.label399.Location = new System.Drawing.Point(632, 687);
            this.label399.Name = "label399";
            this.label399.Size = new System.Drawing.Size(35, 30);
            this.label399.TabIndex = 170;
            this.label399.Text = "°C";
            // 
            // label400
            // 
            this.label400.AutoSize = true;
            this.label400.Location = new System.Drawing.Point(639, 659);
            this.label400.Name = "label400";
            this.label400.Size = new System.Drawing.Size(26, 30);
            this.label400.TabIndex = 169;
            this.label400.Text = "V";
            // 
            // label401
            // 
            this.label401.AutoSize = true;
            this.label401.Location = new System.Drawing.Point(632, 587);
            this.label401.Name = "label401";
            this.label401.Size = new System.Drawing.Size(35, 30);
            this.label401.TabIndex = 168;
            this.label401.Text = "°C";
            // 
            // label402
            // 
            this.label402.AutoSize = true;
            this.label402.Location = new System.Drawing.Point(639, 559);
            this.label402.Name = "label402";
            this.label402.Size = new System.Drawing.Size(26, 30);
            this.label402.TabIndex = 167;
            this.label402.Text = "V";
            // 
            // label403
            // 
            this.label403.AutoSize = true;
            this.label403.Location = new System.Drawing.Point(632, 487);
            this.label403.Name = "label403";
            this.label403.Size = new System.Drawing.Size(35, 30);
            this.label403.TabIndex = 166;
            this.label403.Text = "°C";
            // 
            // label404
            // 
            this.label404.AutoSize = true;
            this.label404.Location = new System.Drawing.Point(639, 459);
            this.label404.Name = "label404";
            this.label404.Size = new System.Drawing.Size(26, 30);
            this.label404.TabIndex = 165;
            this.label404.Text = "V";
            // 
            // label405
            // 
            this.label405.AutoSize = true;
            this.label405.Location = new System.Drawing.Point(632, 387);
            this.label405.Name = "label405";
            this.label405.Size = new System.Drawing.Size(35, 30);
            this.label405.TabIndex = 164;
            this.label405.Text = "°C";
            // 
            // label406
            // 
            this.label406.AutoSize = true;
            this.label406.Location = new System.Drawing.Point(639, 359);
            this.label406.Name = "label406";
            this.label406.Size = new System.Drawing.Size(26, 30);
            this.label406.TabIndex = 163;
            this.label406.Text = "V";
            // 
            // label407
            // 
            this.label407.AutoSize = true;
            this.label407.Location = new System.Drawing.Point(632, 287);
            this.label407.Name = "label407";
            this.label407.Size = new System.Drawing.Size(35, 30);
            this.label407.TabIndex = 162;
            this.label407.Text = "°C";
            // 
            // label408
            // 
            this.label408.AutoSize = true;
            this.label408.Location = new System.Drawing.Point(639, 259);
            this.label408.Name = "label408";
            this.label408.Size = new System.Drawing.Size(26, 30);
            this.label408.TabIndex = 161;
            this.label408.Text = "V";
            // 
            // label409
            // 
            this.label409.AutoSize = true;
            this.label409.Location = new System.Drawing.Point(632, 187);
            this.label409.Name = "label409";
            this.label409.Size = new System.Drawing.Size(35, 30);
            this.label409.TabIndex = 160;
            this.label409.Text = "°C";
            // 
            // label410
            // 
            this.label410.AutoSize = true;
            this.label410.Location = new System.Drawing.Point(639, 159);
            this.label410.Name = "label410";
            this.label410.Size = new System.Drawing.Size(26, 30);
            this.label410.TabIndex = 159;
            this.label410.Text = "V";
            // 
            // label411
            // 
            this.label411.AutoSize = true;
            this.label411.Location = new System.Drawing.Point(282, 687);
            this.label411.Name = "label411";
            this.label411.Size = new System.Drawing.Size(35, 30);
            this.label411.TabIndex = 158;
            this.label411.Text = "°C";
            // 
            // label412
            // 
            this.label412.AutoSize = true;
            this.label412.Location = new System.Drawing.Point(289, 659);
            this.label412.Name = "label412";
            this.label412.Size = new System.Drawing.Size(26, 30);
            this.label412.TabIndex = 157;
            this.label412.Text = "V";
            // 
            // label413
            // 
            this.label413.AutoSize = true;
            this.label413.Location = new System.Drawing.Point(282, 587);
            this.label413.Name = "label413";
            this.label413.Size = new System.Drawing.Size(35, 30);
            this.label413.TabIndex = 156;
            this.label413.Text = "°C";
            // 
            // label414
            // 
            this.label414.AutoSize = true;
            this.label414.Location = new System.Drawing.Point(289, 559);
            this.label414.Name = "label414";
            this.label414.Size = new System.Drawing.Size(26, 30);
            this.label414.TabIndex = 155;
            this.label414.Text = "V";
            // 
            // label415
            // 
            this.label415.AutoSize = true;
            this.label415.Location = new System.Drawing.Point(282, 487);
            this.label415.Name = "label415";
            this.label415.Size = new System.Drawing.Size(35, 30);
            this.label415.TabIndex = 154;
            this.label415.Text = "°C";
            // 
            // label416
            // 
            this.label416.AutoSize = true;
            this.label416.Location = new System.Drawing.Point(289, 459);
            this.label416.Name = "label416";
            this.label416.Size = new System.Drawing.Size(26, 30);
            this.label416.TabIndex = 153;
            this.label416.Text = "V";
            // 
            // label417
            // 
            this.label417.AutoSize = true;
            this.label417.Location = new System.Drawing.Point(282, 387);
            this.label417.Name = "label417";
            this.label417.Size = new System.Drawing.Size(35, 30);
            this.label417.TabIndex = 152;
            this.label417.Text = "°C";
            // 
            // label418
            // 
            this.label418.AutoSize = true;
            this.label418.Location = new System.Drawing.Point(289, 359);
            this.label418.Name = "label418";
            this.label418.Size = new System.Drawing.Size(26, 30);
            this.label418.TabIndex = 151;
            this.label418.Text = "V";
            // 
            // label419
            // 
            this.label419.AutoSize = true;
            this.label419.Location = new System.Drawing.Point(282, 287);
            this.label419.Name = "label419";
            this.label419.Size = new System.Drawing.Size(35, 30);
            this.label419.TabIndex = 150;
            this.label419.Text = "°C";
            // 
            // label420
            // 
            this.label420.AutoSize = true;
            this.label420.Location = new System.Drawing.Point(289, 259);
            this.label420.Name = "label420";
            this.label420.Size = new System.Drawing.Size(26, 30);
            this.label420.TabIndex = 149;
            this.label420.Text = "V";
            // 
            // label421
            // 
            this.label421.AutoSize = true;
            this.label421.Location = new System.Drawing.Point(282, 187);
            this.label421.Name = "label421";
            this.label421.Size = new System.Drawing.Size(35, 30);
            this.label421.TabIndex = 148;
            this.label421.Text = "°C";
            // 
            // label422
            // 
            this.label422.AutoSize = true;
            this.label422.Location = new System.Drawing.Point(289, 159);
            this.label422.Name = "label422";
            this.label422.Size = new System.Drawing.Size(26, 30);
            this.label422.TabIndex = 147;
            this.label422.Text = "V";
            // 
            // label423
            // 
            this.label423.AutoSize = true;
            this.label423.Location = new System.Drawing.Point(798, 575);
            this.label423.Name = "label423";
            this.label423.Size = new System.Drawing.Size(84, 30);
            this.label423.TabIndex = 146;
            this.label423.Text = "Cell 17";
            // 
            // textBox_286
            // 
            this.textBox_286.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_286.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_286.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_286.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_286.Location = new System.Drawing.Point(901, 592);
            this.textBox_286.Multiline = true;
            this.textBox_286.Name = "textBox_286";
            this.textBox_286.ReadOnly = true;
            this.textBox_286.Size = new System.Drawing.Size(75, 25);
            this.textBox_286.TabIndex = 145;
            this.textBox_286.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_285
            // 
            this.textBox_285.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_285.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_285.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_285.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_285.Location = new System.Drawing.Point(901, 561);
            this.textBox_285.Multiline = true;
            this.textBox_285.Name = "textBox_285";
            this.textBox_285.ReadOnly = true;
            this.textBox_285.Size = new System.Drawing.Size(75, 25);
            this.textBox_285.TabIndex = 144;
            this.textBox_285.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label424
            // 
            this.label424.AutoSize = true;
            this.label424.Location = new System.Drawing.Point(798, 671);
            this.label424.Name = "label424";
            this.label424.Size = new System.Drawing.Size(84, 30);
            this.label424.TabIndex = 143;
            this.label424.Text = "Cell 18";
            // 
            // textBox_288
            // 
            this.textBox_288.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_288.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_288.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_288.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_288.Location = new System.Drawing.Point(901, 692);
            this.textBox_288.Multiline = true;
            this.textBox_288.Name = "textBox_288";
            this.textBox_288.ReadOnly = true;
            this.textBox_288.Size = new System.Drawing.Size(75, 25);
            this.textBox_288.TabIndex = 142;
            this.textBox_288.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_287
            // 
            this.textBox_287.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_287.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_287.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_287.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_287.Location = new System.Drawing.Point(901, 661);
            this.textBox_287.Multiline = true;
            this.textBox_287.Name = "textBox_287";
            this.textBox_287.ReadOnly = true;
            this.textBox_287.Size = new System.Drawing.Size(75, 25);
            this.textBox_287.TabIndex = 141;
            this.textBox_287.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label425
            // 
            this.label425.AutoSize = true;
            this.label425.Location = new System.Drawing.Point(798, 375);
            this.label425.Name = "label425";
            this.label425.Size = new System.Drawing.Size(84, 30);
            this.label425.TabIndex = 140;
            this.label425.Text = "Cell 15";
            // 
            // textBox_282
            // 
            this.textBox_282.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_282.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_282.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_282.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_282.Location = new System.Drawing.Point(901, 392);
            this.textBox_282.Multiline = true;
            this.textBox_282.Name = "textBox_282";
            this.textBox_282.ReadOnly = true;
            this.textBox_282.Size = new System.Drawing.Size(75, 25);
            this.textBox_282.TabIndex = 139;
            this.textBox_282.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_281
            // 
            this.textBox_281.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_281.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_281.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_281.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_281.Location = new System.Drawing.Point(901, 361);
            this.textBox_281.Multiline = true;
            this.textBox_281.Name = "textBox_281";
            this.textBox_281.ReadOnly = true;
            this.textBox_281.Size = new System.Drawing.Size(75, 25);
            this.textBox_281.TabIndex = 138;
            this.textBox_281.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label426
            // 
            this.label426.AutoSize = true;
            this.label426.Location = new System.Drawing.Point(798, 275);
            this.label426.Name = "label426";
            this.label426.Size = new System.Drawing.Size(84, 30);
            this.label426.TabIndex = 137;
            this.label426.Text = "Cell 14";
            // 
            // textBox_280
            // 
            this.textBox_280.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_280.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_280.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_280.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_280.Location = new System.Drawing.Point(901, 292);
            this.textBox_280.Multiline = true;
            this.textBox_280.Name = "textBox_280";
            this.textBox_280.ReadOnly = true;
            this.textBox_280.Size = new System.Drawing.Size(75, 25);
            this.textBox_280.TabIndex = 136;
            this.textBox_280.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_279
            // 
            this.textBox_279.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_279.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_279.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_279.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_279.Location = new System.Drawing.Point(901, 261);
            this.textBox_279.Multiline = true;
            this.textBox_279.Name = "textBox_279";
            this.textBox_279.ReadOnly = true;
            this.textBox_279.Size = new System.Drawing.Size(75, 25);
            this.textBox_279.TabIndex = 135;
            this.textBox_279.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label427
            // 
            this.label427.AutoSize = true;
            this.label427.Location = new System.Drawing.Point(798, 174);
            this.label427.Name = "label427";
            this.label427.Size = new System.Drawing.Size(84, 30);
            this.label427.TabIndex = 134;
            this.label427.Text = "Cell 13";
            // 
            // textBox_278
            // 
            this.textBox_278.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_278.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_278.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_278.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_278.Location = new System.Drawing.Point(901, 192);
            this.textBox_278.Multiline = true;
            this.textBox_278.Name = "textBox_278";
            this.textBox_278.ReadOnly = true;
            this.textBox_278.Size = new System.Drawing.Size(75, 25);
            this.textBox_278.TabIndex = 133;
            this.textBox_278.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_277
            // 
            this.textBox_277.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_277.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_277.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_277.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_277.Location = new System.Drawing.Point(901, 161);
            this.textBox_277.Multiline = true;
            this.textBox_277.Name = "textBox_277";
            this.textBox_277.ReadOnly = true;
            this.textBox_277.Size = new System.Drawing.Size(75, 25);
            this.textBox_277.TabIndex = 132;
            this.textBox_277.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label428
            // 
            this.label428.AutoSize = true;
            this.label428.Location = new System.Drawing.Point(798, 474);
            this.label428.Name = "label428";
            this.label428.Size = new System.Drawing.Size(84, 30);
            this.label428.TabIndex = 131;
            this.label428.Text = "Cell 16";
            // 
            // textBox_284
            // 
            this.textBox_284.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_284.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_284.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_284.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_284.Location = new System.Drawing.Point(901, 492);
            this.textBox_284.Multiline = true;
            this.textBox_284.Name = "textBox_284";
            this.textBox_284.ReadOnly = true;
            this.textBox_284.Size = new System.Drawing.Size(75, 25);
            this.textBox_284.TabIndex = 130;
            this.textBox_284.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_283
            // 
            this.textBox_283.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_283.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_283.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_283.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_283.Location = new System.Drawing.Point(901, 461);
            this.textBox_283.Multiline = true;
            this.textBox_283.Name = "textBox_283";
            this.textBox_283.ReadOnly = true;
            this.textBox_283.Size = new System.Drawing.Size(75, 25);
            this.textBox_283.TabIndex = 129;
            this.textBox_283.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label429
            // 
            this.label429.AutoSize = true;
            this.label429.Location = new System.Drawing.Point(461, 575);
            this.label429.Name = "label429";
            this.label429.Size = new System.Drawing.Size(84, 30);
            this.label429.TabIndex = 128;
            this.label429.Text = "Cell 11";
            // 
            // textBox_274
            // 
            this.textBox_274.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_274.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_274.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_274.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_274.Location = new System.Drawing.Point(551, 592);
            this.textBox_274.Multiline = true;
            this.textBox_274.Name = "textBox_274";
            this.textBox_274.ReadOnly = true;
            this.textBox_274.Size = new System.Drawing.Size(75, 25);
            this.textBox_274.TabIndex = 127;
            this.textBox_274.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_273
            // 
            this.textBox_273.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_273.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_273.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_273.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_273.Location = new System.Drawing.Point(551, 561);
            this.textBox_273.Multiline = true;
            this.textBox_273.Name = "textBox_273";
            this.textBox_273.ReadOnly = true;
            this.textBox_273.Size = new System.Drawing.Size(75, 25);
            this.textBox_273.TabIndex = 126;
            this.textBox_273.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label430
            // 
            this.label430.AutoSize = true;
            this.label430.Location = new System.Drawing.Point(461, 671);
            this.label430.Name = "label430";
            this.label430.Size = new System.Drawing.Size(84, 30);
            this.label430.TabIndex = 125;
            this.label430.Text = "Cell 12";
            // 
            // textBox_276
            // 
            this.textBox_276.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_276.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_276.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_276.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_276.Location = new System.Drawing.Point(551, 692);
            this.textBox_276.Multiline = true;
            this.textBox_276.Name = "textBox_276";
            this.textBox_276.ReadOnly = true;
            this.textBox_276.Size = new System.Drawing.Size(75, 25);
            this.textBox_276.TabIndex = 124;
            this.textBox_276.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_275
            // 
            this.textBox_275.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_275.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_275.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_275.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_275.Location = new System.Drawing.Point(551, 661);
            this.textBox_275.Multiline = true;
            this.textBox_275.Name = "textBox_275";
            this.textBox_275.ReadOnly = true;
            this.textBox_275.Size = new System.Drawing.Size(75, 25);
            this.textBox_275.TabIndex = 123;
            this.textBox_275.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label431
            // 
            this.label431.AutoSize = true;
            this.label431.Location = new System.Drawing.Point(461, 375);
            this.label431.Name = "label431";
            this.label431.Size = new System.Drawing.Size(70, 30);
            this.label431.TabIndex = 122;
            this.label431.Text = "Cell 9";
            // 
            // textBox_270
            // 
            this.textBox_270.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_270.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_270.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_270.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_270.Location = new System.Drawing.Point(551, 392);
            this.textBox_270.Multiline = true;
            this.textBox_270.Name = "textBox_270";
            this.textBox_270.ReadOnly = true;
            this.textBox_270.Size = new System.Drawing.Size(75, 25);
            this.textBox_270.TabIndex = 121;
            this.textBox_270.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_269
            // 
            this.textBox_269.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_269.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_269.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_269.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_269.Location = new System.Drawing.Point(551, 361);
            this.textBox_269.Multiline = true;
            this.textBox_269.Name = "textBox_269";
            this.textBox_269.ReadOnly = true;
            this.textBox_269.Size = new System.Drawing.Size(75, 25);
            this.textBox_269.TabIndex = 120;
            this.textBox_269.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label432
            // 
            this.label432.AutoSize = true;
            this.label432.Location = new System.Drawing.Point(461, 275);
            this.label432.Name = "label432";
            this.label432.Size = new System.Drawing.Size(70, 30);
            this.label432.TabIndex = 119;
            this.label432.Text = "Cell 8";
            // 
            // textBox_268
            // 
            this.textBox_268.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_268.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_268.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_268.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_268.Location = new System.Drawing.Point(551, 292);
            this.textBox_268.Multiline = true;
            this.textBox_268.Name = "textBox_268";
            this.textBox_268.ReadOnly = true;
            this.textBox_268.Size = new System.Drawing.Size(75, 25);
            this.textBox_268.TabIndex = 118;
            this.textBox_268.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_267
            // 
            this.textBox_267.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_267.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_267.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_267.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_267.Location = new System.Drawing.Point(551, 261);
            this.textBox_267.Multiline = true;
            this.textBox_267.Name = "textBox_267";
            this.textBox_267.ReadOnly = true;
            this.textBox_267.Size = new System.Drawing.Size(75, 25);
            this.textBox_267.TabIndex = 117;
            this.textBox_267.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label433
            // 
            this.label433.AutoSize = true;
            this.label433.Location = new System.Drawing.Point(461, 174);
            this.label433.Name = "label433";
            this.label433.Size = new System.Drawing.Size(70, 30);
            this.label433.TabIndex = 116;
            this.label433.Text = "Cell 7";
            // 
            // textBox_266
            // 
            this.textBox_266.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_266.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_266.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_266.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_266.Location = new System.Drawing.Point(551, 192);
            this.textBox_266.Multiline = true;
            this.textBox_266.Name = "textBox_266";
            this.textBox_266.ReadOnly = true;
            this.textBox_266.Size = new System.Drawing.Size(75, 25);
            this.textBox_266.TabIndex = 115;
            this.textBox_266.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_265
            // 
            this.textBox_265.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_265.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_265.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_265.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_265.Location = new System.Drawing.Point(551, 161);
            this.textBox_265.Multiline = true;
            this.textBox_265.Name = "textBox_265";
            this.textBox_265.ReadOnly = true;
            this.textBox_265.Size = new System.Drawing.Size(75, 25);
            this.textBox_265.TabIndex = 114;
            this.textBox_265.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label434
            // 
            this.label434.AutoSize = true;
            this.label434.Location = new System.Drawing.Point(461, 474);
            this.label434.Name = "label434";
            this.label434.Size = new System.Drawing.Size(84, 30);
            this.label434.TabIndex = 113;
            this.label434.Text = "Cell 10";
            // 
            // textBox_272
            // 
            this.textBox_272.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_272.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_272.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_272.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_272.Location = new System.Drawing.Point(551, 492);
            this.textBox_272.Multiline = true;
            this.textBox_272.Name = "textBox_272";
            this.textBox_272.ReadOnly = true;
            this.textBox_272.Size = new System.Drawing.Size(75, 25);
            this.textBox_272.TabIndex = 112;
            this.textBox_272.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_271
            // 
            this.textBox_271.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_271.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_271.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_271.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_271.Location = new System.Drawing.Point(551, 461);
            this.textBox_271.Multiline = true;
            this.textBox_271.Name = "textBox_271";
            this.textBox_271.ReadOnly = true;
            this.textBox_271.Size = new System.Drawing.Size(75, 25);
            this.textBox_271.TabIndex = 111;
            this.textBox_271.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label435
            // 
            this.label435.AutoSize = true;
            this.label435.Location = new System.Drawing.Point(125, 575);
            this.label435.Name = "label435";
            this.label435.Size = new System.Drawing.Size(70, 30);
            this.label435.TabIndex = 110;
            this.label435.Text = "Cell 5";
            // 
            // textBox_262
            // 
            this.textBox_262.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_262.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_262.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_262.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_262.Location = new System.Drawing.Point(201, 592);
            this.textBox_262.Multiline = true;
            this.textBox_262.Name = "textBox_262";
            this.textBox_262.ReadOnly = true;
            this.textBox_262.Size = new System.Drawing.Size(75, 25);
            this.textBox_262.TabIndex = 109;
            this.textBox_262.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_261
            // 
            this.textBox_261.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_261.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_261.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_261.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_261.Location = new System.Drawing.Point(201, 561);
            this.textBox_261.Multiline = true;
            this.textBox_261.Name = "textBox_261";
            this.textBox_261.ReadOnly = true;
            this.textBox_261.Size = new System.Drawing.Size(75, 25);
            this.textBox_261.TabIndex = 108;
            this.textBox_261.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label436
            // 
            this.label436.AutoSize = true;
            this.label436.Location = new System.Drawing.Point(125, 671);
            this.label436.Name = "label436";
            this.label436.Size = new System.Drawing.Size(70, 30);
            this.label436.TabIndex = 107;
            this.label436.Text = "Cell 6";
            // 
            // textBox_264
            // 
            this.textBox_264.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_264.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_264.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_264.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_264.Location = new System.Drawing.Point(201, 692);
            this.textBox_264.Multiline = true;
            this.textBox_264.Name = "textBox_264";
            this.textBox_264.ReadOnly = true;
            this.textBox_264.Size = new System.Drawing.Size(75, 25);
            this.textBox_264.TabIndex = 106;
            this.textBox_264.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_263
            // 
            this.textBox_263.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_263.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_263.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_263.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_263.Location = new System.Drawing.Point(201, 661);
            this.textBox_263.Multiline = true;
            this.textBox_263.Name = "textBox_263";
            this.textBox_263.ReadOnly = true;
            this.textBox_263.Size = new System.Drawing.Size(75, 25);
            this.textBox_263.TabIndex = 105;
            this.textBox_263.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label437
            // 
            this.label437.AutoSize = true;
            this.label437.Location = new System.Drawing.Point(125, 375);
            this.label437.Name = "label437";
            this.label437.Size = new System.Drawing.Size(70, 30);
            this.label437.TabIndex = 104;
            this.label437.Text = "Cell 3";
            // 
            // textBox_258
            // 
            this.textBox_258.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_258.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_258.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_258.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_258.Location = new System.Drawing.Point(201, 392);
            this.textBox_258.Multiline = true;
            this.textBox_258.Name = "textBox_258";
            this.textBox_258.ReadOnly = true;
            this.textBox_258.Size = new System.Drawing.Size(75, 25);
            this.textBox_258.TabIndex = 103;
            this.textBox_258.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_257
            // 
            this.textBox_257.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_257.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_257.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_257.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_257.Location = new System.Drawing.Point(201, 361);
            this.textBox_257.Multiline = true;
            this.textBox_257.Name = "textBox_257";
            this.textBox_257.ReadOnly = true;
            this.textBox_257.Size = new System.Drawing.Size(75, 25);
            this.textBox_257.TabIndex = 102;
            this.textBox_257.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label438
            // 
            this.label438.AutoSize = true;
            this.label438.Location = new System.Drawing.Point(125, 275);
            this.label438.Name = "label438";
            this.label438.Size = new System.Drawing.Size(70, 30);
            this.label438.TabIndex = 101;
            this.label438.Text = "Cell 2";
            // 
            // textBox_256
            // 
            this.textBox_256.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_256.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_256.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_256.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_256.Location = new System.Drawing.Point(201, 292);
            this.textBox_256.Multiline = true;
            this.textBox_256.Name = "textBox_256";
            this.textBox_256.ReadOnly = true;
            this.textBox_256.Size = new System.Drawing.Size(75, 25);
            this.textBox_256.TabIndex = 100;
            this.textBox_256.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_255
            // 
            this.textBox_255.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_255.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_255.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_255.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_255.Location = new System.Drawing.Point(201, 261);
            this.textBox_255.Multiline = true;
            this.textBox_255.Name = "textBox_255";
            this.textBox_255.ReadOnly = true;
            this.textBox_255.Size = new System.Drawing.Size(75, 25);
            this.textBox_255.TabIndex = 99;
            this.textBox_255.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label439
            // 
            this.label439.AutoSize = true;
            this.label439.Location = new System.Drawing.Point(125, 174);
            this.label439.Name = "label439";
            this.label439.Size = new System.Drawing.Size(70, 30);
            this.label439.TabIndex = 98;
            this.label439.Text = "Cell 1";
            // 
            // textBox_254
            // 
            this.textBox_254.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_254.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_254.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_254.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_254.Location = new System.Drawing.Point(201, 192);
            this.textBox_254.Multiline = true;
            this.textBox_254.Name = "textBox_254";
            this.textBox_254.ReadOnly = true;
            this.textBox_254.Size = new System.Drawing.Size(75, 25);
            this.textBox_254.TabIndex = 97;
            this.textBox_254.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_253
            // 
            this.textBox_253.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_253.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_253.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_253.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_253.Location = new System.Drawing.Point(201, 161);
            this.textBox_253.Multiline = true;
            this.textBox_253.Name = "textBox_253";
            this.textBox_253.ReadOnly = true;
            this.textBox_253.Size = new System.Drawing.Size(75, 25);
            this.textBox_253.TabIndex = 96;
            this.textBox_253.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label440
            // 
            this.label440.AutoSize = true;
            this.label440.Location = new System.Drawing.Point(125, 474);
            this.label440.Name = "label440";
            this.label440.Size = new System.Drawing.Size(70, 30);
            this.label440.TabIndex = 95;
            this.label440.Text = "Cell 4";
            // 
            // textBox_260
            // 
            this.textBox_260.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_260.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_260.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_260.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_260.Location = new System.Drawing.Point(201, 492);
            this.textBox_260.Multiline = true;
            this.textBox_260.Name = "textBox_260";
            this.textBox_260.ReadOnly = true;
            this.textBox_260.Size = new System.Drawing.Size(75, 25);
            this.textBox_260.TabIndex = 94;
            this.textBox_260.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_259
            // 
            this.textBox_259.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_259.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_259.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_259.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_259.Location = new System.Drawing.Point(201, 461);
            this.textBox_259.Multiline = true;
            this.textBox_259.Name = "textBox_259";
            this.textBox_259.ReadOnly = true;
            this.textBox_259.Size = new System.Drawing.Size(75, 25);
            this.textBox_259.TabIndex = 93;
            this.textBox_259.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1882, 1003);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Font = new System.Drawing.Font("3ds Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTC 2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tabcontrol1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.nodes_groupBox.ResumeLayout(false);
            this.nodes_groupBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.group_vcu.ResumeLayout(false);
            this.group_vcu.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ams_tabpage.ResumeLayout(false);
            this.ams_tabpage.PerformLayout();
            this.stack1.ResumeLayout(false);
            this.stack1.PerformLayout();
            this.stack2.ResumeLayout(false);
            this.stack2.PerformLayout();
            this.stack3.ResumeLayout(false);
            this.stack3.PerformLayout();
            this.stack4.ResumeLayout(false);
            this.stack4.PerformLayout();
            this.stack5.ResumeLayout(false);
            this.stack5.PerformLayout();
            this.stack6.ResumeLayout(false);
            this.stack6.PerformLayout();
            this.stack7.ResumeLayout(false);
            this.stack7.PerformLayout();
            this.stack8.ResumeLayout(false);
            this.stack8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox filter_id_high_box;
        private System.Windows.Forms.TextBox filter_id_low_box;
        private System.Windows.Forms.Label label554;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label can_bus_load;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button query_button;
        private System.Windows.Forms.GroupBox nodes_groupBox;
        private System.Windows.Forms.RadioButton steering_wheel_radio;
        private System.Windows.Forms.RadioButton brake_light_radio;
        private System.Windows.Forms.RadioButton fan_radio;
        private System.Windows.Forms.RadioButton ams_lv_radio;
        private System.Windows.Forms.RadioButton can_multiplexer_front_radio;
        private System.Windows.Forms.RadioButton bcu_radio;
        private System.Windows.Forms.RadioButton empty_radio;
        private System.Windows.Forms.RadioButton can_multiplexer_rear_radio;
        private System.Windows.Forms.RadioButton vcu_radio;
        private System.Windows.Forms.RadioButton vcdu_radio;
        private System.Windows.Forms.RadioButton ami_radio;
        private System.Windows.Forms.RadioButton discharge_radio;
        private System.Windows.Forms.RadioButton assi_radio;
        private System.Windows.Forms.RadioButton precharge_radio;
        private System.Windows.Forms.RadioButton ebs_radio;
        private System.Windows.Forms.RadioButton ams_master_radio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button open_file;
        private System.Windows.Forms.Button close_file;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label492;
        private System.Windows.Forms.Label label540;
        private System.Windows.Forms.Label label541;
        private System.Windows.Forms.Label label491;
        private System.Windows.Forms.Label label486;
        private System.Windows.Forms.Label label482;
        private System.Windows.Forms.Label label525;
        private System.Windows.Forms.Label label524;
        private System.Windows.Forms.Label label523;
        private System.Windows.Forms.Label label522;
        private System.Windows.Forms.TextBox ams_lv_status_box;
        private System.Windows.Forms.Label label521;
        private System.Windows.Forms.Label label501;
        private System.Windows.Forms.Label label520;
        private System.Windows.Forms.Label label517;
        private System.Windows.Forms.Label label518;
        private System.Windows.Forms.Label label519;
        private System.Windows.Forms.TextBox lv_voltage_cell_6_box;
        private System.Windows.Forms.TextBox lv_temp_cell_6_box;
        private System.Windows.Forms.Label label510;
        private System.Windows.Forms.Label label509;
        private System.Windows.Forms.TextBox lv_temp_cell_5_box;
        private System.Windows.Forms.TextBox lv_voltage_cell_5_box;
        private System.Windows.Forms.Label label511;
        private System.Windows.Forms.Label label508;
        private System.Windows.Forms.TextBox lv_temp_cell_4_box;
        private System.Windows.Forms.Label label512;
        private System.Windows.Forms.Label label507;
        private System.Windows.Forms.Label label506;
        private System.Windows.Forms.Label label505;
        private System.Windows.Forms.TextBox lv_voltage_cell_4_box;
        private System.Windows.Forms.Label label504;
        private System.Windows.Forms.TextBox lv_voltage_cell_2_box;
        private System.Windows.Forms.TextBox lv_voltage_cell_3_box;
        private System.Windows.Forms.TextBox lv_voltage_cell_1_box;
        private System.Windows.Forms.TextBox lv_hottest_cell_box;
        private System.Windows.Forms.Label label502;
        private System.Windows.Forms.Label label503;
        private System.Windows.Forms.TextBox lv_temp_cell_1_box;
        private System.Windows.Forms.TextBox lv_temp_cell_3_box;
        private System.Windows.Forms.TextBox lv_temp_cell_2_box;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox actuator_status_box;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox rpm2_box;
        private System.Windows.Forms.TextBox rpm1_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label499;
        private System.Windows.Forms.TextBox airminus_box;
        private System.Windows.Forms.Label label473;
        private System.Windows.Forms.Label label474;
        private System.Windows.Forms.Label label475;
        private System.Windows.Forms.TextBox airplus_box;
        private System.Windows.Forms.TextBox prechrelay_box;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox vcdu_status_box;
        private System.Windows.Forms.TextBox motor_temp_box;
        private System.Windows.Forms.TextBox inverter_temp_box;
        private System.Windows.Forms.Label label451;
        private System.Windows.Forms.Label label450;
        private System.Windows.Forms.Label label452;
        private System.Windows.Forms.Label label453;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label cell_max_number;
        private System.Windows.Forms.Label stack_max_number;
        private System.Windows.Forms.Label label556;
        private System.Windows.Forms.TextBox voltage_max_box;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label558;
        private System.Windows.Forms.Label cell_min_number;
        private System.Windows.Forms.Label stack_min_number;
        private System.Windows.Forms.TextBox voltage_min_box;
        private System.Windows.Forms.TextBox total_voltage_box;
        private System.Windows.Forms.Label label498;
        private System.Windows.Forms.Label label495;
        private System.Windows.Forms.TextBox stack5_box;
        private System.Windows.Forms.TextBox stack1_box;
        private System.Windows.Forms.Label label455;
        private System.Windows.Forms.TextBox stack2_box;
        private System.Windows.Forms.Label label456;
        private System.Windows.Forms.TextBox stack3_box;
        private System.Windows.Forms.Label label457;
        private System.Windows.Forms.TextBox stack4_box;
        private System.Windows.Forms.Label label458;
        private System.Windows.Forms.Label label459;
        private System.Windows.Forms.TextBox stack6_box;
        private System.Windows.Forms.Label label460;
        private System.Windows.Forms.TextBox stack7_box;
        private System.Windows.Forms.Label label461;
        private System.Windows.Forms.TextBox stack8_box;
        private System.Windows.Forms.Label label470;
        private System.Windows.Forms.Label label462;
        private System.Windows.Forms.Label label469;
        private System.Windows.Forms.Label label463;
        private System.Windows.Forms.Label label468;
        private System.Windows.Forms.Label label464;
        private System.Windows.Forms.Label label467;
        private System.Windows.Forms.Label label465;
        private System.Windows.Forms.Label label466;
        private System.Windows.Forms.GroupBox group_vcu;
        private System.Windows.Forms.Label label550;
        private System.Windows.Forms.Label label549;
        private System.Windows.Forms.Label label526;
        private System.Windows.Forms.Label label528;
        private System.Windows.Forms.Label label530;
        private System.Windows.Forms.Label label531;
        private System.Windows.Forms.Label label532;
        private System.Windows.Forms.Label label533;
        private System.Windows.Forms.Label label534;
        private System.Windows.Forms.Label label535;
        private System.Windows.Forms.Label label536;
        private System.Windows.Forms.Label label537;
        private System.Windows.Forms.Label label538;
        private System.Windows.Forms.Label label539;
        private System.Windows.Forms.TextBox assi_current_box;
        private System.Windows.Forms.TextBox gps_current_box;
        private System.Windows.Forms.TextBox as_current_box;
        private System.Windows.Forms.TextBox cameras_current_box;
        private System.Windows.Forms.TextBox res_current_box;
        private System.Windows.Forms.TextBox lidar_current_box;
        private System.Windows.Forms.Label label527;
        private System.Windows.Forms.Label label529;
        private System.Windows.Forms.TextBox brake_light_current_box;
        private System.Windows.Forms.TextBox vcdu_current_box;
        private System.Windows.Forms.Label label513;
        private System.Windows.Forms.Label label514;
        private System.Windows.Forms.Label label515;
        private System.Windows.Forms.Label label516;
        private System.Windows.Forms.TextBox ebs_current_box;
        private System.Windows.Forms.TextBox actuator_current_box;
        private System.Windows.Forms.Label label449;
        private System.Windows.Forms.Label label487;
        private System.Windows.Forms.Label label488;
        private System.Windows.Forms.Label label485;
        private System.Windows.Forms.Label label489;
        private System.Windows.Forms.Label label484;
        private System.Windows.Forms.Label label490;
        private System.Windows.Forms.Label label483;
        private System.Windows.Forms.Label label493;
        private System.Windows.Forms.Label label480;
        private System.Windows.Forms.Label label494;
        private System.Windows.Forms.Label label479;
        private System.Windows.Forms.Label label478;
        private System.Windows.Forms.TextBox fan2_current_box;
        private System.Windows.Forms.TextBox fan1_current_box;
        private System.Windows.Forms.TextBox lcs_current_box;
        private System.Windows.Forms.TextBox cooling_pump_current_box;
        private System.Windows.Forms.TextBox inverter_current_box;
        private System.Windows.Forms.TextBox tsal_current_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox brake_system_status_box;
        private System.Windows.Forms.TextBox brake_pressure_box;
        private System.Windows.Forms.Label label496;
        private System.Windows.Forms.TextBox ebs_pressure_box;
        private System.Windows.Forms.Label label454;
        private System.Windows.Forms.TextBox sb_pressure_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage stack1;
        private System.Windows.Forms.Label stack_1u;
        private System.Windows.Forms.Button clear_1;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_34;
        private System.Windows.Forms.TextBox textBox_33;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox_36;
        private System.Windows.Forms.TextBox textBox_35;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox_30;
        private System.Windows.Forms.TextBox textBox_29;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox_28;
        private System.Windows.Forms.TextBox textBox_27;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox_26;
        private System.Windows.Forms.TextBox textBox_25;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox_32;
        private System.Windows.Forms.TextBox textBox_31;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_22;
        private System.Windows.Forms.TextBox textBox_21;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_24;
        private System.Windows.Forms.TextBox textBox_23;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_18;
        private System.Windows.Forms.TextBox textBox_17;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_16;
        private System.Windows.Forms.TextBox textBox_15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_14;
        private System.Windows.Forms.TextBox textBox_13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_20;
        private System.Windows.Forms.TextBox textBox_19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_10;
        private System.Windows.Forms.TextBox textBox_9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_12;
        private System.Windows.Forms.TextBox textBox_11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_6;
        private System.Windows.Forms.TextBox textBox_5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_4;
        private System.Windows.Forms.TextBox textBox_3;
        private System.Windows.Forms.Label stack1_2;
        private System.Windows.Forms.TextBox textBox_2;
        private System.Windows.Forms.TextBox textBox_1;
        private System.Windows.Forms.Label stack1_1;
        private System.Windows.Forms.TextBox textBox_8;
        private System.Windows.Forms.TextBox textBox_7;
        private System.Windows.Forms.TabPage stack2;
        private System.Windows.Forms.Label stack_2u;
        private System.Windows.Forms.Button clear_2;
        private System.Windows.Forms.Label label441;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.TextBox textBox_70;
        private System.Windows.Forms.TextBox textBox_69;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.TextBox textBox_72;
        private System.Windows.Forms.TextBox textBox_71;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.TextBox textBox_66;
        private System.Windows.Forms.TextBox textBox_65;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.TextBox textBox_64;
        private System.Windows.Forms.TextBox textBox_63;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.TextBox textBox_62;
        private System.Windows.Forms.TextBox textBox_61;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.TextBox textBox_68;
        private System.Windows.Forms.TextBox textBox_67;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.TextBox textBox_58;
        private System.Windows.Forms.TextBox textBox_57;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.TextBox textBox_60;
        private System.Windows.Forms.TextBox textBox_59;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.TextBox textBox_54;
        private System.Windows.Forms.TextBox textBox_53;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.TextBox textBox_52;
        private System.Windows.Forms.TextBox textBox_51;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.TextBox textBox_50;
        private System.Windows.Forms.TextBox textBox_49;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.TextBox textBox_56;
        private System.Windows.Forms.TextBox textBox_55;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.TextBox textBox_46;
        private System.Windows.Forms.TextBox textBox_45;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.TextBox textBox_48;
        private System.Windows.Forms.TextBox textBox_47;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.TextBox textBox_42;
        private System.Windows.Forms.TextBox textBox_41;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.TextBox textBox_40;
        private System.Windows.Forms.TextBox textBox_39;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.TextBox textBox_38;
        private System.Windows.Forms.TextBox textBox_37;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.TextBox textBox_44;
        private System.Windows.Forms.TextBox textBox_43;
        private System.Windows.Forms.TabPage stack3;
        private System.Windows.Forms.Label stack_3u;
        private System.Windows.Forms.Button clear_3;
        private System.Windows.Forms.Label label442;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.Label label127;
        private System.Windows.Forms.Label label128;
        private System.Windows.Forms.Label label129;
        private System.Windows.Forms.Label label130;
        private System.Windows.Forms.Label label131;
        private System.Windows.Forms.Label label132;
        private System.Windows.Forms.Label label133;
        private System.Windows.Forms.Label label134;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.Label label136;
        private System.Windows.Forms.Label label137;
        private System.Windows.Forms.Label label138;
        private System.Windows.Forms.Label label139;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.Label label142;
        private System.Windows.Forms.Label label143;
        private System.Windows.Forms.Label label144;
        private System.Windows.Forms.Label label145;
        private System.Windows.Forms.Label label146;
        private System.Windows.Forms.Label label147;
        private System.Windows.Forms.Label label148;
        private System.Windows.Forms.Label label149;
        private System.Windows.Forms.Label label150;
        private System.Windows.Forms.Label label151;
        private System.Windows.Forms.Label label152;
        private System.Windows.Forms.Label label153;
        private System.Windows.Forms.TextBox textBox_106;
        private System.Windows.Forms.TextBox textBox_105;
        private System.Windows.Forms.Label label154;
        private System.Windows.Forms.TextBox textBox_108;
        private System.Windows.Forms.TextBox textBox_107;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.TextBox textBox_102;
        private System.Windows.Forms.TextBox textBox_101;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.TextBox textBox_100;
        private System.Windows.Forms.TextBox textBox_99;
        private System.Windows.Forms.Label label157;
        private System.Windows.Forms.TextBox textBox_98;
        private System.Windows.Forms.TextBox textBox_97;
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.TextBox textBox_104;
        private System.Windows.Forms.TextBox textBox_103;
        private System.Windows.Forms.Label label159;
        private System.Windows.Forms.TextBox textBox_94;
        private System.Windows.Forms.TextBox textBox_93;
        private System.Windows.Forms.Label label160;
        private System.Windows.Forms.TextBox textBox_96;
        private System.Windows.Forms.TextBox textBox_95;
        private System.Windows.Forms.Label label161;
        private System.Windows.Forms.TextBox textBox_90;
        private System.Windows.Forms.TextBox textBox_89;
        private System.Windows.Forms.Label label162;
        private System.Windows.Forms.TextBox textBox_88;
        private System.Windows.Forms.TextBox textBox_87;
        private System.Windows.Forms.Label label163;
        private System.Windows.Forms.TextBox textBox_86;
        private System.Windows.Forms.TextBox textBox_85;
        private System.Windows.Forms.Label label164;
        private System.Windows.Forms.TextBox textBox_92;
        private System.Windows.Forms.TextBox textBox_91;
        private System.Windows.Forms.Label label165;
        private System.Windows.Forms.TextBox textBox_82;
        private System.Windows.Forms.TextBox textBox_81;
        private System.Windows.Forms.Label label166;
        private System.Windows.Forms.TextBox textBox_84;
        private System.Windows.Forms.TextBox textBox_83;
        private System.Windows.Forms.Label label167;
        private System.Windows.Forms.TextBox textBox_78;
        private System.Windows.Forms.TextBox textBox_77;
        private System.Windows.Forms.Label label168;
        private System.Windows.Forms.TextBox textBox_76;
        private System.Windows.Forms.TextBox textBox_75;
        private System.Windows.Forms.Label label169;
        private System.Windows.Forms.TextBox textBox_74;
        private System.Windows.Forms.TextBox textBox_73;
        private System.Windows.Forms.Label label170;
        private System.Windows.Forms.TextBox textBox_80;
        private System.Windows.Forms.TextBox textBox_79;
        private System.Windows.Forms.TabPage stack4;
        private System.Windows.Forms.Label stack_4u;
        private System.Windows.Forms.Button clear_4;
        private System.Windows.Forms.Label label443;
        private System.Windows.Forms.Label label171;
        private System.Windows.Forms.Label label172;
        private System.Windows.Forms.Label label173;
        private System.Windows.Forms.Label label174;
        private System.Windows.Forms.Label label175;
        private System.Windows.Forms.Label label176;
        private System.Windows.Forms.Label label177;
        private System.Windows.Forms.Label label178;
        private System.Windows.Forms.Label label179;
        private System.Windows.Forms.Label label180;
        private System.Windows.Forms.Label label181;
        private System.Windows.Forms.Label label182;
        private System.Windows.Forms.Label label183;
        private System.Windows.Forms.Label label184;
        private System.Windows.Forms.Label label185;
        private System.Windows.Forms.Label label186;
        private System.Windows.Forms.Label label187;
        private System.Windows.Forms.Label label188;
        private System.Windows.Forms.Label label189;
        private System.Windows.Forms.Label label190;
        private System.Windows.Forms.Label label191;
        private System.Windows.Forms.Label label192;
        private System.Windows.Forms.Label label193;
        private System.Windows.Forms.Label label194;
        private System.Windows.Forms.Label label195;
        private System.Windows.Forms.Label label196;
        private System.Windows.Forms.Label label197;
        private System.Windows.Forms.Label label198;
        private System.Windows.Forms.Label label199;
        private System.Windows.Forms.Label label200;
        private System.Windows.Forms.Label label201;
        private System.Windows.Forms.Label label202;
        private System.Windows.Forms.Label label203;
        private System.Windows.Forms.Label label204;
        private System.Windows.Forms.Label label205;
        private System.Windows.Forms.Label label206;
        private System.Windows.Forms.Label label207;
        private System.Windows.Forms.TextBox textBox_142;
        private System.Windows.Forms.TextBox textBox_141;
        private System.Windows.Forms.Label label208;
        private System.Windows.Forms.TextBox textBox_144;
        private System.Windows.Forms.TextBox textBox_143;
        private System.Windows.Forms.Label label209;
        private System.Windows.Forms.TextBox textBox_138;
        private System.Windows.Forms.TextBox textBox_137;
        private System.Windows.Forms.Label label210;
        private System.Windows.Forms.TextBox textBox_136;
        private System.Windows.Forms.TextBox textBox_135;
        private System.Windows.Forms.Label label211;
        private System.Windows.Forms.TextBox textBox_134;
        private System.Windows.Forms.TextBox textBox_133;
        private System.Windows.Forms.Label label212;
        private System.Windows.Forms.TextBox textBox_140;
        private System.Windows.Forms.TextBox textBox_139;
        private System.Windows.Forms.Label label213;
        private System.Windows.Forms.TextBox textBox_130;
        private System.Windows.Forms.TextBox textBox_129;
        private System.Windows.Forms.Label label214;
        private System.Windows.Forms.TextBox textBox_132;
        private System.Windows.Forms.TextBox textBox_131;
        private System.Windows.Forms.Label label215;
        private System.Windows.Forms.TextBox textBox_126;
        private System.Windows.Forms.TextBox textBox_125;
        private System.Windows.Forms.Label label216;
        private System.Windows.Forms.TextBox textBox_124;
        private System.Windows.Forms.TextBox textBox_123;
        private System.Windows.Forms.Label label217;
        private System.Windows.Forms.TextBox textBox_122;
        private System.Windows.Forms.TextBox textBox_121;
        private System.Windows.Forms.Label label218;
        private System.Windows.Forms.TextBox textBox_128;
        private System.Windows.Forms.TextBox textBox_127;
        private System.Windows.Forms.Label label219;
        private System.Windows.Forms.TextBox textBox_118;
        private System.Windows.Forms.TextBox textBox_117;
        private System.Windows.Forms.Label label220;
        private System.Windows.Forms.TextBox textBox_120;
        private System.Windows.Forms.TextBox textBox_119;
        private System.Windows.Forms.Label label221;
        private System.Windows.Forms.TextBox textBox_114;
        private System.Windows.Forms.TextBox textBox_113;
        private System.Windows.Forms.Label label222;
        private System.Windows.Forms.TextBox textBox_112;
        private System.Windows.Forms.TextBox textBox_111;
        private System.Windows.Forms.Label label223;
        private System.Windows.Forms.TextBox textBox_110;
        private System.Windows.Forms.TextBox textBox_109;
        private System.Windows.Forms.Label label224;
        private System.Windows.Forms.TextBox textBox_116;
        private System.Windows.Forms.TextBox textBox_115;
        private System.Windows.Forms.TabPage stack5;
        private System.Windows.Forms.Label stack_5u;
        private System.Windows.Forms.Button clear_5;
        private System.Windows.Forms.Label label444;
        private System.Windows.Forms.Label label225;
        private System.Windows.Forms.Label label226;
        private System.Windows.Forms.Label label227;
        private System.Windows.Forms.Label label228;
        private System.Windows.Forms.Label label229;
        private System.Windows.Forms.Label label230;
        private System.Windows.Forms.Label label231;
        private System.Windows.Forms.Label label232;
        private System.Windows.Forms.Label label233;
        private System.Windows.Forms.Label label234;
        private System.Windows.Forms.Label label235;
        private System.Windows.Forms.Label label236;
        private System.Windows.Forms.Label label237;
        private System.Windows.Forms.Label label238;
        private System.Windows.Forms.Label label239;
        private System.Windows.Forms.Label label240;
        private System.Windows.Forms.Label label241;
        private System.Windows.Forms.Label label242;
        private System.Windows.Forms.Label label243;
        private System.Windows.Forms.Label label244;
        private System.Windows.Forms.Label label245;
        private System.Windows.Forms.Label label246;
        private System.Windows.Forms.Label label247;
        private System.Windows.Forms.Label label248;
        private System.Windows.Forms.Label label249;
        private System.Windows.Forms.Label label250;
        private System.Windows.Forms.Label label251;
        private System.Windows.Forms.Label label252;
        private System.Windows.Forms.Label label253;
        private System.Windows.Forms.Label label254;
        private System.Windows.Forms.Label label255;
        private System.Windows.Forms.Label label256;
        private System.Windows.Forms.Label label257;
        private System.Windows.Forms.Label label258;
        private System.Windows.Forms.Label label259;
        private System.Windows.Forms.Label label260;
        private System.Windows.Forms.Label label261;
        private System.Windows.Forms.TextBox textBox_178;
        private System.Windows.Forms.TextBox textBox_177;
        private System.Windows.Forms.Label label262;
        private System.Windows.Forms.TextBox textBox_180;
        private System.Windows.Forms.TextBox textBox_179;
        private System.Windows.Forms.Label label263;
        private System.Windows.Forms.TextBox textBox_174;
        private System.Windows.Forms.TextBox textBox_173;
        private System.Windows.Forms.Label label264;
        private System.Windows.Forms.TextBox textBox_172;
        private System.Windows.Forms.TextBox textBox_171;
        private System.Windows.Forms.Label label265;
        private System.Windows.Forms.TextBox textBox_170;
        private System.Windows.Forms.TextBox textBox_169;
        private System.Windows.Forms.Label label266;
        private System.Windows.Forms.TextBox textBox_176;
        private System.Windows.Forms.TextBox textBox_175;
        private System.Windows.Forms.Label label267;
        private System.Windows.Forms.TextBox textBox_166;
        private System.Windows.Forms.TextBox textBox_165;
        private System.Windows.Forms.Label label268;
        private System.Windows.Forms.TextBox textBox_168;
        private System.Windows.Forms.TextBox textBox_167;
        private System.Windows.Forms.Label label269;
        private System.Windows.Forms.TextBox textBox_162;
        private System.Windows.Forms.TextBox textBox_161;
        private System.Windows.Forms.Label label270;
        private System.Windows.Forms.TextBox textBox_160;
        private System.Windows.Forms.TextBox textBox_159;
        private System.Windows.Forms.Label label271;
        private System.Windows.Forms.TextBox textBox_158;
        private System.Windows.Forms.TextBox textBox_157;
        private System.Windows.Forms.Label label272;
        private System.Windows.Forms.TextBox textBox_164;
        private System.Windows.Forms.TextBox textBox_163;
        private System.Windows.Forms.Label label273;
        private System.Windows.Forms.TextBox textBox_154;
        private System.Windows.Forms.TextBox textBox_153;
        private System.Windows.Forms.Label label274;
        private System.Windows.Forms.TextBox textBox_156;
        private System.Windows.Forms.TextBox textBox_155;
        private System.Windows.Forms.Label label275;
        private System.Windows.Forms.TextBox textBox_150;
        private System.Windows.Forms.TextBox textBox_149;
        private System.Windows.Forms.Label label276;
        private System.Windows.Forms.TextBox textBox_148;
        private System.Windows.Forms.TextBox textBox_147;
        private System.Windows.Forms.Label label277;
        private System.Windows.Forms.TextBox textBox_146;
        private System.Windows.Forms.TextBox textBox_145;
        private System.Windows.Forms.Label label278;
        private System.Windows.Forms.TextBox textBox_152;
        private System.Windows.Forms.TextBox textBox_151;
        private System.Windows.Forms.TabPage stack6;
        private System.Windows.Forms.Label stack_6u;
        private System.Windows.Forms.Button clear_6;
        private System.Windows.Forms.Label label445;
        private System.Windows.Forms.Label label279;
        private System.Windows.Forms.Label label280;
        private System.Windows.Forms.Label label281;
        private System.Windows.Forms.Label label282;
        private System.Windows.Forms.Label label283;
        private System.Windows.Forms.Label label284;
        private System.Windows.Forms.Label label285;
        private System.Windows.Forms.Label label286;
        private System.Windows.Forms.Label label287;
        private System.Windows.Forms.Label label288;
        private System.Windows.Forms.Label label289;
        private System.Windows.Forms.Label label290;
        private System.Windows.Forms.Label label291;
        private System.Windows.Forms.Label label292;
        private System.Windows.Forms.Label label293;
        private System.Windows.Forms.Label label294;
        private System.Windows.Forms.Label label295;
        private System.Windows.Forms.Label label296;
        private System.Windows.Forms.Label label297;
        private System.Windows.Forms.Label label298;
        private System.Windows.Forms.Label label299;
        private System.Windows.Forms.Label label300;
        private System.Windows.Forms.Label label301;
        private System.Windows.Forms.Label label302;
        private System.Windows.Forms.Label label303;
        private System.Windows.Forms.Label label304;
        private System.Windows.Forms.Label label305;
        private System.Windows.Forms.Label label306;
        private System.Windows.Forms.Label label307;
        private System.Windows.Forms.Label label308;
        private System.Windows.Forms.Label label309;
        private System.Windows.Forms.Label label310;
        private System.Windows.Forms.Label label311;
        private System.Windows.Forms.Label label312;
        private System.Windows.Forms.Label label313;
        private System.Windows.Forms.Label label314;
        private System.Windows.Forms.Label label315;
        private System.Windows.Forms.TextBox textBox_214;
        private System.Windows.Forms.TextBox textBox_213;
        private System.Windows.Forms.Label label316;
        private System.Windows.Forms.TextBox textBox_216;
        private System.Windows.Forms.TextBox textBox_215;
        private System.Windows.Forms.Label label317;
        private System.Windows.Forms.TextBox textBox_210;
        private System.Windows.Forms.TextBox textBox_209;
        private System.Windows.Forms.Label label318;
        private System.Windows.Forms.TextBox textBox_208;
        private System.Windows.Forms.TextBox textBox_207;
        private System.Windows.Forms.Label label319;
        private System.Windows.Forms.TextBox textBox_206;
        private System.Windows.Forms.TextBox textBox_205;
        private System.Windows.Forms.Label label320;
        private System.Windows.Forms.TextBox textBox_212;
        private System.Windows.Forms.TextBox textBox_211;
        private System.Windows.Forms.Label label321;
        private System.Windows.Forms.TextBox textBox_202;
        private System.Windows.Forms.TextBox textBox_201;
        private System.Windows.Forms.Label label322;
        private System.Windows.Forms.TextBox textBox_204;
        private System.Windows.Forms.TextBox textBox_203;
        private System.Windows.Forms.Label label323;
        private System.Windows.Forms.TextBox textBox_198;
        private System.Windows.Forms.TextBox textBox_197;
        private System.Windows.Forms.Label label324;
        private System.Windows.Forms.TextBox textBox_196;
        private System.Windows.Forms.TextBox textBox_195;
        private System.Windows.Forms.Label label325;
        private System.Windows.Forms.TextBox textBox_194;
        private System.Windows.Forms.TextBox textBox_193;
        private System.Windows.Forms.Label label326;
        private System.Windows.Forms.TextBox textBox_200;
        private System.Windows.Forms.TextBox textBox_199;
        private System.Windows.Forms.Label label327;
        private System.Windows.Forms.TextBox textBox_190;
        private System.Windows.Forms.TextBox textBox_189;
        private System.Windows.Forms.Label label328;
        private System.Windows.Forms.TextBox textBox_192;
        private System.Windows.Forms.TextBox textBox_191;
        private System.Windows.Forms.Label label329;
        private System.Windows.Forms.TextBox textBox_186;
        private System.Windows.Forms.TextBox textBox_185;
        private System.Windows.Forms.Label label330;
        private System.Windows.Forms.TextBox textBox_184;
        private System.Windows.Forms.TextBox textBox_183;
        private System.Windows.Forms.Label label331;
        private System.Windows.Forms.TextBox textBox_182;
        private System.Windows.Forms.TextBox textBox_181;
        private System.Windows.Forms.Label label332;
        private System.Windows.Forms.TextBox textBox_188;
        private System.Windows.Forms.TextBox textBox_187;
        private System.Windows.Forms.TabPage stack7;
        private System.Windows.Forms.Label stack_7u;
        private System.Windows.Forms.Button clear_7;
        private System.Windows.Forms.Label label446;
        private System.Windows.Forms.Label label333;
        private System.Windows.Forms.Label label334;
        private System.Windows.Forms.Label label335;
        private System.Windows.Forms.Label label336;
        private System.Windows.Forms.Label label337;
        private System.Windows.Forms.Label label338;
        private System.Windows.Forms.Label label339;
        private System.Windows.Forms.Label label340;
        private System.Windows.Forms.Label label341;
        private System.Windows.Forms.Label label342;
        private System.Windows.Forms.Label label343;
        private System.Windows.Forms.Label label344;
        private System.Windows.Forms.Label label345;
        private System.Windows.Forms.Label label346;
        private System.Windows.Forms.Label label347;
        private System.Windows.Forms.Label label348;
        private System.Windows.Forms.Label label349;
        private System.Windows.Forms.Label label350;
        private System.Windows.Forms.Label label351;
        private System.Windows.Forms.Label label352;
        private System.Windows.Forms.Label label353;
        private System.Windows.Forms.Label label354;
        private System.Windows.Forms.Label label355;
        private System.Windows.Forms.Label label356;
        private System.Windows.Forms.Label label357;
        private System.Windows.Forms.Label label358;
        private System.Windows.Forms.Label label359;
        private System.Windows.Forms.Label label360;
        private System.Windows.Forms.Label label361;
        private System.Windows.Forms.Label label362;
        private System.Windows.Forms.Label label363;
        private System.Windows.Forms.Label label364;
        private System.Windows.Forms.Label label365;
        private System.Windows.Forms.Label label366;
        private System.Windows.Forms.Label label367;
        private System.Windows.Forms.Label label368;
        private System.Windows.Forms.Label label369;
        private System.Windows.Forms.TextBox textBox_250;
        private System.Windows.Forms.TextBox textBox_249;
        private System.Windows.Forms.Label label370;
        private System.Windows.Forms.TextBox textBox_252;
        private System.Windows.Forms.TextBox textBox_251;
        private System.Windows.Forms.Label label371;
        private System.Windows.Forms.TextBox textBox_246;
        private System.Windows.Forms.TextBox textBox_245;
        private System.Windows.Forms.Label label372;
        private System.Windows.Forms.TextBox textBox_244;
        private System.Windows.Forms.TextBox textBox_243;
        private System.Windows.Forms.Label label373;
        private System.Windows.Forms.TextBox textBox_242;
        private System.Windows.Forms.TextBox textBox_241;
        private System.Windows.Forms.Label label374;
        private System.Windows.Forms.TextBox textBox_248;
        private System.Windows.Forms.TextBox textBox_247;
        private System.Windows.Forms.Label label375;
        private System.Windows.Forms.TextBox textBox_238;
        private System.Windows.Forms.TextBox textBox_237;
        private System.Windows.Forms.Label label376;
        private System.Windows.Forms.TextBox textBox_240;
        private System.Windows.Forms.TextBox textBox_239;
        private System.Windows.Forms.Label label377;
        private System.Windows.Forms.TextBox textBox_234;
        private System.Windows.Forms.TextBox textBox_233;
        private System.Windows.Forms.Label label378;
        private System.Windows.Forms.TextBox textBox_232;
        private System.Windows.Forms.TextBox textBox_231;
        private System.Windows.Forms.Label label379;
        private System.Windows.Forms.TextBox textBox_230;
        private System.Windows.Forms.TextBox textBox_229;
        private System.Windows.Forms.Label label380;
        private System.Windows.Forms.TextBox textBox_236;
        private System.Windows.Forms.TextBox textBox_235;
        private System.Windows.Forms.Label label381;
        private System.Windows.Forms.TextBox textBox_226;
        private System.Windows.Forms.TextBox textBox_225;
        private System.Windows.Forms.Label label382;
        private System.Windows.Forms.TextBox textBox_228;
        private System.Windows.Forms.TextBox textBox_227;
        private System.Windows.Forms.Label label383;
        private System.Windows.Forms.TextBox textBox_222;
        private System.Windows.Forms.TextBox textBox_221;
        private System.Windows.Forms.Label label384;
        private System.Windows.Forms.TextBox textBox_220;
        private System.Windows.Forms.TextBox textBox_219;
        private System.Windows.Forms.Label label385;
        private System.Windows.Forms.TextBox textBox_218;
        private System.Windows.Forms.TextBox textBox_217;
        private System.Windows.Forms.Label label386;
        private System.Windows.Forms.TextBox textBox_224;
        private System.Windows.Forms.TextBox textBox_223;
        private System.Windows.Forms.TabPage stack8;
        private System.Windows.Forms.Label stack_8u;
        private System.Windows.Forms.Button clear_8;
        private System.Windows.Forms.Label label447;
        private System.Windows.Forms.Label label387;
        private System.Windows.Forms.Label label388;
        private System.Windows.Forms.Label label389;
        private System.Windows.Forms.Label label390;
        private System.Windows.Forms.Label label391;
        private System.Windows.Forms.Label label392;
        private System.Windows.Forms.Label label393;
        private System.Windows.Forms.Label label394;
        private System.Windows.Forms.Label label395;
        private System.Windows.Forms.Label label396;
        private System.Windows.Forms.Label label397;
        private System.Windows.Forms.Label label398;
        private System.Windows.Forms.Label label399;
        private System.Windows.Forms.Label label400;
        private System.Windows.Forms.Label label401;
        private System.Windows.Forms.Label label402;
        private System.Windows.Forms.Label label403;
        private System.Windows.Forms.Label label404;
        private System.Windows.Forms.Label label405;
        private System.Windows.Forms.Label label406;
        private System.Windows.Forms.Label label407;
        private System.Windows.Forms.Label label408;
        private System.Windows.Forms.Label label409;
        private System.Windows.Forms.Label label410;
        private System.Windows.Forms.Label label411;
        private System.Windows.Forms.Label label412;
        private System.Windows.Forms.Label label413;
        private System.Windows.Forms.Label label414;
        private System.Windows.Forms.Label label415;
        private System.Windows.Forms.Label label416;
        private System.Windows.Forms.Label label417;
        private System.Windows.Forms.Label label418;
        private System.Windows.Forms.Label label419;
        private System.Windows.Forms.Label label420;
        private System.Windows.Forms.Label label421;
        private System.Windows.Forms.Label label422;
        private System.Windows.Forms.Label label423;
        private System.Windows.Forms.TextBox textBox_286;
        private System.Windows.Forms.TextBox textBox_285;
        private System.Windows.Forms.Label label424;
        private System.Windows.Forms.TextBox textBox_288;
        private System.Windows.Forms.TextBox textBox_287;
        private System.Windows.Forms.Label label425;
        private System.Windows.Forms.TextBox textBox_282;
        private System.Windows.Forms.TextBox textBox_281;
        private System.Windows.Forms.Label label426;
        private System.Windows.Forms.TextBox textBox_280;
        private System.Windows.Forms.TextBox textBox_279;
        private System.Windows.Forms.Label label427;
        private System.Windows.Forms.TextBox textBox_278;
        private System.Windows.Forms.TextBox textBox_277;
        private System.Windows.Forms.Label label428;
        private System.Windows.Forms.TextBox textBox_284;
        private System.Windows.Forms.TextBox textBox_283;
        private System.Windows.Forms.Label label429;
        private System.Windows.Forms.TextBox textBox_274;
        private System.Windows.Forms.TextBox textBox_273;
        private System.Windows.Forms.Label label430;
        private System.Windows.Forms.TextBox textBox_276;
        private System.Windows.Forms.TextBox textBox_275;
        private System.Windows.Forms.Label label431;
        private System.Windows.Forms.TextBox textBox_270;
        private System.Windows.Forms.TextBox textBox_269;
        private System.Windows.Forms.Label label432;
        private System.Windows.Forms.TextBox textBox_268;
        private System.Windows.Forms.TextBox textBox_267;
        private System.Windows.Forms.Label label433;
        private System.Windows.Forms.TextBox textBox_266;
        private System.Windows.Forms.TextBox textBox_265;
        private System.Windows.Forms.Label label434;
        private System.Windows.Forms.TextBox textBox_272;
        private System.Windows.Forms.TextBox textBox_271;
        private System.Windows.Forms.Label label435;
        private System.Windows.Forms.TextBox textBox_262;
        private System.Windows.Forms.TextBox textBox_261;
        private System.Windows.Forms.Label label436;
        private System.Windows.Forms.TextBox textBox_264;
        private System.Windows.Forms.TextBox textBox_263;
        private System.Windows.Forms.Label label437;
        private System.Windows.Forms.TextBox textBox_258;
        private System.Windows.Forms.TextBox textBox_257;
        private System.Windows.Forms.Label label438;
        private System.Windows.Forms.TextBox textBox_256;
        private System.Windows.Forms.TextBox textBox_255;
        private System.Windows.Forms.Label label439;
        private System.Windows.Forms.TextBox textBox_254;
        private System.Windows.Forms.TextBox textBox_253;
        private System.Windows.Forms.Label label440;
        private System.Windows.Forms.TextBox textBox_260;
        private System.Windows.Forms.TextBox textBox_259;
        private System.Windows.Forms.TabPage ams_tabpage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.RichTextBox richTextBox_master;
        private System.Windows.Forms.RichTextBox richTextBox_slave1;
        private System.Windows.Forms.RichTextBox richTextBox_slave2;
        private System.Windows.Forms.RichTextBox richTextBox_slave3;
        private System.Windows.Forms.RichTextBox richTextBox_slave4;
        private System.Windows.Forms.RichTextBox richTextBox_slave5;
        private System.Windows.Forms.RichTextBox richTextBox_slave6;
        private System.Windows.Forms.RichTextBox richTextBox_slave7;
        private System.Windows.Forms.RichTextBox richTextBox_slave8;
        private System.Windows.Forms.Button clear_ams;
        private System.Windows.Forms.RichTextBox richTextBox_vcu;
        private System.Windows.Forms.RichTextBox richTextBox_precharge_status;
        private System.Windows.Forms.Label label500;
        private System.Windows.Forms.RichTextBox richTextBox_precharge_errors;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox hotcell;
        private System.Windows.Forms.Label label472;
        private System.Windows.Forms.Label label471;
        private System.Windows.Forms.TextBox current_box;
        private System.Windows.Forms.Label label477;
        private System.Windows.Forms.Label label476;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox charging_current_box;
        private System.Windows.Forms.Label label553;
        private System.Windows.Forms.Label label552;
        private System.Windows.Forms.TextBox charging_status_box;
        private System.Windows.Forms.Label label551;
    }
}

