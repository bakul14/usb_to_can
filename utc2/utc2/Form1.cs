
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;



namespace utc2
{

    public partial class Form1 : Form
    {

        Queue<string> serial_messages = new Queue<string>();

        int filter_id_low = 0x0;
        int filter_id_high = 0x7ff;

        char[] circle_buffer = new char[4096];

        string myfile = string.Empty;
        string readfile = string.Empty;

        string[] data = new string[8];
        string input_message = "";
        string[] slave_statuses_messages = new string[14]
        {
            "SLAVE_ERROR", "SLAVE_OK",
            "STM_HEAP_OVERFLOW", "LTC_WRONG_PEC",
            "LTC_OPEN_WIRE", "LTC_ONDERVOLTAGE",
            "LTC_OVERVOLTAGE", "LTC_SPI_ERROR",
            "TEMP_RECEIVE_ERROR", "TEMP_OVERHEAT",
            "TEMP_THREAD_ERROR", "ADC_THREAD_ERROR",
            "BALANCING_THREAD_ERROR", "SLAVE_NOT_RESPONDING"
        };
        string[] master_statuses = new string[10]
{
            "MASTER_ERROR", "MASTER_OK",
            "MASTER_MAIN_CAN_ERROR", "MASTER_SLAVE_CAN_ERROR",
            "MASTER_OVERCURRENT", "CURRENT_SENS_ERROR",
            "CHARGER_CAN_ERROR", "MAIN_CAN_THREAD_ERROR",
            "SLAVE_CAN_THREAD_ERROR", "CHG_ADC_THREAD_ERROR"
};
        string[] actuator_statuses = new string[4]
        {
            "EPS_UNKNOWN_ERROR", "EPS_OK",
            "EPS_INPUT_ERROR", "EPS_CONTROL_UNIT_ERROR"
        };
        string[] vcu_statuses = new string[12]
        {
            "VCU_UNKNOWN_ERROR", "VCU_OK", "VCU_FAN1_OVERCURRENT",
            "VCU_FAN2_OVERCURRENT", "VCU_PUMP_OVERCURRENT", "VCU_STEER_ACT_OVERCURRENT",
            "VCU_LCS_OVERCURRENT", "VCU_INVERTOR_OVERCURRENT", "VCU_TSAL_OVERCURRENT",
            "VCU_VCDU_OVERCURRENT", "VCU_EBS_OVERCURRENT", "VCU_BRAKE_LIGHT_OVERCURRENT"
        };

        string[] charging_statuses = new string[5]
        {
            "CHARGER_ERROR", "CHARGER_DISCONNECTED", "CHARGER_CONNECTED",
            "CHARGING_ON", "BATTERY_CHARGED"
        };


        char start_symbol;
        int message_counter = 0;
        bool download_process_flag = false;
        bool feedback_usb_flag = false;
        bool feedback_boot_flag = false;
        bool start_flag = true;
        bool download_button_flag = false;

        float[] stack_voltages = new float[8];
        float summary_voltage = 0;

        float min_cell_voltage = 1000, max_cell_voltage = 0;
        int stack_number = 0, cell_number = 0,
            min_cell_number_last = 0, min_stack_number_last = 0,
            max_cell_number_last = 0, max_stack_number_last = 0;

        int node_id = 0;

        Control[] tb = new Control[288];
        Control[] stackboxes = new Control[8];
        Control[] stackboxes_u = new Control[8];
        Control[] ams_lv_voltage = new Control[6];
        Control[] ams_lv_temp = new Control[6];
        Control[] fan_rpm = new Control[2];
        Control[] vcu_currents = new Control[16];
        Control[] slave_number = new Control[8];


        Dictionary<int, string> precharge_dict =
            new Dictionary<int, string>();

        static Semaphore semaphore_thread1 = new Semaphore(2, 2);


        public Form1()
        {
            InitializeComponent();
            tb[0] = textBox_1; tb[1] = textBox_2; tb[2] = textBox_3; tb[3] = textBox_4; tb[4] = textBox_5; tb[5] = textBox_6; tb[6] = textBox_7; tb[7] = textBox_8;
            tb[8] = textBox_9; tb[9] = textBox_10; tb[10] = textBox_11; tb[11] = textBox_12; tb[12] = textBox_13; tb[13] = textBox_14; tb[14] = textBox_15; tb[15] = textBox_16;
            tb[16] = textBox_17; tb[17] = textBox_18; tb[18] = textBox_19; tb[19] = textBox_20; tb[20] = textBox_21; tb[21] = textBox_22; tb[22] = textBox_23; tb[23] = textBox_24;
            tb[24] = textBox_25; tb[25] = textBox_26; tb[26] = textBox_27; tb[27] = textBox_28; tb[28] = textBox_29; tb[29] = textBox_30; tb[30] = textBox_31; tb[31] = textBox_32;
            tb[32] = textBox_33; tb[33] = textBox_34; tb[34] = textBox_35; tb[35] = textBox_36; tb[36] = textBox_37; tb[37] = textBox_38; tb[38] = textBox_39; tb[39] = textBox_40;
            tb[40] = textBox_41; tb[41] = textBox_42; tb[42] = textBox_43; tb[43] = textBox_44; tb[44] = textBox_45; tb[45] = textBox_46; tb[46] = textBox_47; tb[47] = textBox_48;
            tb[48] = textBox_49; tb[49] = textBox_50; tb[50] = textBox_51; tb[51] = textBox_52; tb[52] = textBox_53; tb[53] = textBox_54; tb[54] = textBox_55; tb[55] = textBox_56;
            tb[56] = textBox_57; tb[57] = textBox_58; tb[58] = textBox_59; tb[59] = textBox_60; tb[60] = textBox_61; tb[61] = textBox_62; tb[62] = textBox_63; tb[63] = textBox_64;
            tb[64] = textBox_65; tb[65] = textBox_66; tb[66] = textBox_67; tb[67] = textBox_68; tb[68] = textBox_69; tb[69] = textBox_70; tb[70] = textBox_71; tb[71] = textBox_72;
            tb[72] = textBox_73; tb[73] = textBox_74; tb[74] = textBox_75; tb[75] = textBox_76; tb[76] = textBox_77; tb[77] = textBox_78; tb[78] = textBox_79; tb[79] = textBox_80;
            tb[80] = textBox_81; tb[81] = textBox_82; tb[82] = textBox_83; tb[83] = textBox_84; tb[84] = textBox_85; tb[85] = textBox_86; tb[86] = textBox_87; tb[87] = textBox_88;
            tb[88] = textBox_89; tb[89] = textBox_90; tb[90] = textBox_91; tb[91] = textBox_92; tb[92] = textBox_93; tb[93] = textBox_94; tb[94] = textBox_95; tb[95] = textBox_96;
            tb[96] = textBox_97; tb[97] = textBox_98; tb[98] = textBox_99; tb[99] = textBox_100; tb[100] = textBox_101; tb[101] = textBox_102; tb[102] = textBox_103; tb[103] = textBox_104;
            tb[104] = textBox_105; tb[105] = textBox_106; tb[106] = textBox_107; tb[107] = textBox_108; tb[108] = textBox_109; tb[109] = textBox_110; tb[110] = textBox_111; tb[111] = textBox_112;
            tb[112] = textBox_113; tb[113] = textBox_114; tb[114] = textBox_115; tb[115] = textBox_116; tb[116] = textBox_117; tb[117] = textBox_118; tb[118] = textBox_119; tb[119] = textBox_120;
            tb[120] = textBox_121; tb[121] = textBox_122; tb[122] = textBox_123; tb[123] = textBox_124; tb[124] = textBox_125; tb[125] = textBox_126; tb[126] = textBox_127; tb[127] = textBox_128;
            tb[128] = textBox_129; tb[129] = textBox_130; tb[130] = textBox_131; tb[131] = textBox_132; tb[132] = textBox_133; tb[133] = textBox_134; tb[134] = textBox_135; tb[135] = textBox_136;
            tb[136] = textBox_137; tb[137] = textBox_138; tb[138] = textBox_139; tb[139] = textBox_140; tb[140] = textBox_141; tb[141] = textBox_142; tb[142] = textBox_143; tb[143] = textBox_144;
            tb[144] = textBox_145; tb[145] = textBox_146; tb[146] = textBox_147; tb[147] = textBox_148; tb[148] = textBox_149; tb[149] = textBox_150; tb[150] = textBox_151; tb[151] = textBox_152;
            tb[152] = textBox_153; tb[153] = textBox_154; tb[154] = textBox_155; tb[155] = textBox_156; tb[156] = textBox_157; tb[157] = textBox_158; tb[158] = textBox_159; tb[159] = textBox_160;
            tb[160] = textBox_161; tb[161] = textBox_162; tb[162] = textBox_163; tb[163] = textBox_164; tb[164] = textBox_165; tb[165] = textBox_166; tb[166] = textBox_167; tb[167] = textBox_168;
            tb[168] = textBox_169; tb[169] = textBox_170; tb[170] = textBox_171; tb[171] = textBox_172; tb[172] = textBox_173; tb[173] = textBox_174; tb[174] = textBox_175; tb[175] = textBox_176;
            tb[176] = textBox_177; tb[177] = textBox_178; tb[178] = textBox_179; tb[179] = textBox_180; tb[180] = textBox_181; tb[181] = textBox_182; tb[182] = textBox_183; tb[183] = textBox_184;
            tb[184] = textBox_185; tb[185] = textBox_186; tb[186] = textBox_187; tb[187] = textBox_188; tb[188] = textBox_189; tb[189] = textBox_190; tb[190] = textBox_191; tb[191] = textBox_192;
            tb[192] = textBox_193; tb[193] = textBox_194; tb[194] = textBox_195; tb[195] = textBox_196; tb[196] = textBox_197; tb[197] = textBox_198; tb[198] = textBox_199; tb[199] = textBox_200;
            tb[200] = textBox_201; tb[201] = textBox_202; tb[202] = textBox_203; tb[203] = textBox_204; tb[204] = textBox_205; tb[205] = textBox_206; tb[206] = textBox_207; tb[207] = textBox_208;
            tb[208] = textBox_209; tb[209] = textBox_210; tb[210] = textBox_211; tb[211] = textBox_212; tb[212] = textBox_213; tb[213] = textBox_214; tb[214] = textBox_215; tb[215] = textBox_216;
            tb[216] = textBox_217; tb[217] = textBox_218; tb[218] = textBox_219; tb[219] = textBox_220; tb[220] = textBox_221; tb[221] = textBox_222; tb[222] = textBox_223; tb[223] = textBox_224;
            tb[224] = textBox_225; tb[225] = textBox_226; tb[226] = textBox_227; tb[227] = textBox_228; tb[228] = textBox_229; tb[229] = textBox_230; tb[230] = textBox_231; tb[231] = textBox_232;
            tb[232] = textBox_233; tb[233] = textBox_234; tb[234] = textBox_235; tb[235] = textBox_236; tb[236] = textBox_237; tb[237] = textBox_238; tb[238] = textBox_239; tb[239] = textBox_240;
            tb[240] = textBox_241; tb[241] = textBox_242; tb[242] = textBox_243; tb[243] = textBox_244; tb[244] = textBox_245; tb[245] = textBox_246; tb[246] = textBox_247; tb[247] = textBox_248;
            tb[248] = textBox_249; tb[249] = textBox_250; tb[250] = textBox_251; tb[251] = textBox_252; tb[252] = textBox_253; tb[253] = textBox_254; tb[254] = textBox_255; tb[255] = textBox_256;
            tb[256] = textBox_257; tb[257] = textBox_258; tb[258] = textBox_259; tb[259] = textBox_260; tb[260] = textBox_261; tb[261] = textBox_262; tb[262] = textBox_263; tb[263] = textBox_264;
            tb[264] = textBox_265; tb[265] = textBox_266; tb[266] = textBox_267; tb[267] = textBox_268; tb[268] = textBox_269; tb[269] = textBox_270; tb[270] = textBox_271; tb[271] = textBox_272;
            tb[272] = textBox_273; tb[273] = textBox_274; tb[274] = textBox_275; tb[275] = textBox_276; tb[276] = textBox_277; tb[277] = textBox_278; tb[278] = textBox_279; tb[279] = textBox_280;
            tb[280] = textBox_281; tb[281] = textBox_282; tb[282] = textBox_283; tb[283] = textBox_284; tb[284] = textBox_285; tb[285] = textBox_286; tb[286] = textBox_287; tb[287] = textBox_288;

            stackboxes[0] = stack1_box; stackboxes[1] = stack2_box; stackboxes[2] = stack3_box; stackboxes[3] = stack4_box;
            stackboxes[4] = stack5_box; stackboxes[5] = stack6_box; stackboxes[6] = stack7_box; stackboxes[7] = stack8_box;

            stackboxes_u[0] = stack_1u; stackboxes_u[1] = stack_2u; stackboxes_u[2] = stack_3u; stackboxes_u[3] = stack_4u;
            stackboxes_u[4] = stack_5u; stackboxes_u[5] = stack_6u; stackboxes_u[6] = stack_7u; stackboxes_u[7] = stack_8u;

            ams_lv_voltage[0] = lv_voltage_cell_1_box; ams_lv_voltage[1] = lv_voltage_cell_2_box; ams_lv_voltage[2] = lv_voltage_cell_3_box;
            ams_lv_voltage[3] = lv_voltage_cell_4_box; ams_lv_voltage[4] = lv_voltage_cell_5_box; ams_lv_voltage[5] = lv_voltage_cell_6_box;

            ams_lv_temp[0] = lv_temp_cell_1_box; ams_lv_temp[1] = lv_temp_cell_2_box; ams_lv_temp[2] = lv_temp_cell_3_box;
            ams_lv_temp[3] = lv_temp_cell_4_box; ams_lv_temp[4] = lv_temp_cell_5_box; ams_lv_temp[5] = lv_temp_cell_6_box;

            fan_rpm[0] = rpm1_box; fan_rpm[1] = rpm2_box;

            vcu_currents[0] = lcs_current_box; vcu_currents[1] = inverter_current_box; vcu_currents[2] = tsal_current_box; vcu_currents[3] = cooling_pump_current_box;
            vcu_currents[4] = vcdu_current_box; vcu_currents[5] = brake_light_current_box; vcu_currents[6] = fan1_current_box; vcu_currents[7] = fan2_current_box;
            vcu_currents[8] = actuator_current_box; vcu_currents[9] = ebs_current_box; vcu_currents[10] = gps_current_box; vcu_currents[11] = cameras_current_box;
            vcu_currents[12] = lidar_current_box; vcu_currents[13] = assi_current_box; vcu_currents[14] = res_current_box; vcu_currents[15] = as_current_box;

            slave_number[0] = slave_status_box_1; slave_number[1] = slave_status_box_2; slave_number[2] = slave_status_box_3; slave_number[3] = slave_status_box_4;
            slave_number[4] = slave_status_box_5; slave_number[5] = slave_status_box_6; slave_number[6] = slave_status_box_7; slave_number[7] = slave_status_box_8;

            filter_id_low_box.Text = filter_id_low.ToString("X");
            filter_id_high_box.Text = filter_id_high.ToString("X");

            precharge_dict.Add(1, "Error: LOW Voltage");
            precharge_dict.Add(2, "Error: HIGH Voltage");
            precharge_dict.Add(3, "Idle: Shutdown Wait");
            precharge_dict.Add(5, "Timeout");
            precharge_dict.Add(7, "Precharge Finished");
            precharge_dict.Add(11, "Shutdown is Open");
            precharge_dict.Add(13, "Charging Mode");
            precharge_dict.Add(17, "Precharge Process");
            precharge_dict.Add(19, "AMS_NOT_RESPONDING");

            this.WindowState = FormWindowState.Maximized;
            Thread myThread1 = new Thread(new ThreadStart(my_thread_1));
            myThread1.IsBackground = true;
            myThread1.Start();
        }
        private int row_count(string readfile)
        {
            int notEmptyCount = readfile
                .Split('\n')
                .Count(x => !string.IsNullOrEmpty(x));

            return notEmptyCount;
        }

        private void serial_reconnect()
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Text = null;
            comboBox1.Items.Clear();
            if (ports.Length != 0)
            {
                comboBox1.Items.AddRange(ports);
                comboBox1.SelectedIndex = 0;
            }
        }

        private int get_id_from_str(string str)
        {
            int a = 0, b = 0, c = 0, result = 0;

            a = hexascii_to_halfbyte(str[1]);
            b = hexascii_to_halfbyte(str[2]);
            c = hexascii_to_halfbyte(str[3]);

            result = ((a * 256) + (b * 16) + (c));
            return result;
        }

        int hexascii_to_halfbyte(int _ascii)
        {
            if ((_ascii >= '0') && (_ascii <= '9')) return (_ascii - '0');
            else if ((_ascii >= 'a') && (_ascii <= 'f')) return (_ascii - 'a' + 10);
            else if ((_ascii >= 'A') && (_ascii <= 'F')) return (_ascii - 'A' + 10);
            else return 0;
        }

        private void brake_pressure_box_show(string str, int copy_of_dlc)
        {
            brake_pressure_box.BeginInvoke(new Action(() => brake_pressure_box.Text = str));
        }

        private void ebs_pressure_box_show(string str, int copy_of_dlc)
        {
            ebs_pressure_box.BeginInvoke(new Action(() => ebs_pressure_box.Text = str));
        }

        private void sb_pressure_box_show(string str, int copy_of_dlc)
        {
            sb_pressure_box.BeginInvoke(new Action(() => sb_pressure_box.Text = str));
        }


        private void max_cell_show(float voltage)
        {
            max_cell_voltage = voltage;
            max_cell_number_last = cell_number;
            max_stack_number_last = stack_number;

            voltage_max_box.Text = max_cell_voltage.ToString("F2");

            stack_max_number.Text = "Stack: " +
                stack_number.ToString();
            cell_max_number.Text = "Cell: " +
                cell_number.ToString();
        }

        private void min_cell_show(float voltage)
        {
            min_cell_voltage = voltage;
            min_cell_number_last = cell_number;
            min_stack_number_last = stack_number;

            voltage_min_box.Text = min_cell_voltage.ToString("F2");

            stack_min_number.Text = "Stack: " +
                stack_number.ToString(); ;
            cell_min_number.Text = "Cell: " +
                cell_number.ToString();
        }

        private void ams_show(string str, int copy_of_dlc, int id)
        {
            if (copy_of_dlc >= 8) { }
            else return;
            int symbol1, symbol2, symbol3, symbol4, temp;
            int aim = (id - 0x100) % 8;
            int byte1, byte2;
            float voltage;

            if (aim <= 4) // напряжение
            {
                if (aim < 4) // напряжения, первые 16 ячеек
                {
                    for (int i = 0; i < 4; i++)
                    {
                        symbol1 = str[i * 4 + 5]; symbol2 = str[i * 4 + 6]; symbol3 = str[i * 4 + 7]; symbol4 = str[i * 4 + 8];
                        byte1 = hexascii_to_halfbyte(symbol1) * 16 + hexascii_to_halfbyte(symbol2);
                        byte2 = hexascii_to_halfbyte(symbol3) * 16 + hexascii_to_halfbyte(symbol4);
                        voltage = (byte1 + byte2 * 0x100) / 10000f;

                        if (voltage > 0.1)
                        {
                            stack_number = ((id - 0x100) / 8 + 1);
                            cell_number = (aim * 4 + i + 1);

                            if (voltage < min_cell_voltage)
                                min_cell_show(voltage);
                            else if (voltage > max_cell_voltage)
                                max_cell_show(voltage);
                            else if ((stack_number == min_stack_number_last) && (cell_number == min_cell_number_last))
                                min_cell_show(voltage);
                            else if ((stack_number == max_stack_number_last) && (cell_number == max_cell_number_last))
                                max_cell_show(voltage);
                        }

                        tb[(id - 0x100) / 8 * 36 + (id - 0x100) % 8 * 8 + i * 2].Text = voltage.ToString("F2");
                    }
                }
                else // напряжения ячеек 17, 18; напряжение всего слейва
                {
                    for (int i = 0; i < 3; i++)
                    {
                        symbol1 = str[i * 4 + 5]; symbol2 = str[i * 4 + 6]; symbol3 = str[i * 4 + 7]; symbol4 = str[i * 4 + 8];
                        byte1 = hexascii_to_halfbyte(symbol1) * 16 + hexascii_to_halfbyte(symbol2);
                        byte2 = hexascii_to_halfbyte(symbol3) * 16 + hexascii_to_halfbyte(symbol4);
                        voltage = (byte1 + byte2 * 0x100) / 10000f;
                        if (i < 2)
                        {
                            if (voltage > 0.1)
                            {
                                if (voltage > max_cell_voltage)
                                {
                                    max_cell_voltage = voltage;
                                    voltage_max_box.Text = max_cell_voltage.ToString("F2");
                                    stack_max_number.Text = "Stack: " +
                                        ((id - 0x100) / 8 + 1).ToString();
                                    cell_max_number.Text = "Cell: " +
                                        (aim * 4 + i + 1).ToString();
                                }
                                else if (voltage < min_cell_voltage)
                                {
                                    min_cell_voltage = voltage;
                                    voltage_min_box.Text = min_cell_voltage.ToString("F2");
                                    stack_min_number.Text = "Stack: " +
                                        ((id - 0x100) / 8 + 1).ToString(); ;
                                    cell_min_number.Text = "Cell: " +
                                        (aim * 4 + i + 1).ToString();
                                }
                            }
                            tb[(id - 0x100) / 8 * 36 + (id - 0x100) % 8 * 8 + i * 2].Text = voltage.ToString("F2");
                        }
                        else if (i < 3)
                        {
                            stack_voltages[(id - 0x100) / 8] = voltage * 100;
                            summary_voltage = 0;
                            for (int j = 0; j < 8; j++)
                                summary_voltage += stack_voltages[j];
                            total_voltage_box.Text = (summary_voltage).ToString("F2");
                            stackboxes[(id - 0x100) / 8].Text = Convert.ToString(voltage * 100);
                            stackboxes_u[(id - 0x100) / 8].Text = "Stack voltage: " + (voltage * 100).ToString("F2") + " V";
                        }
                    }
                }
            }
            else  // температура
            {
                if ((id - 0x100 + 1) % 8 == 0) copy_of_dlc = 2;
                else copy_of_dlc = 8;
                for (int i = 0; i < copy_of_dlc; i++)
                {
                    symbol1 = str[5 + (i * 2)];
                    symbol2 = str[5 + (i * 2) + 1];
                    temp = hexascii_to_halfbyte(symbol1) * 16 + hexascii_to_halfbyte(symbol2);
                    tb[(id - 0x100) / 8 * 36 + ((id - 0x100) % 8 - 5) * 16 + i * 2 + 1].Text = Convert.ToString(temp);
                }
            }
        }

        private void tractive_system_temp_show(string str, int copy_of_dlc)
        {
            if (copy_of_dlc >= 2) { }
            else return;
            int a = 0, b = 0;
            a = hexascii_to_halfbyte(str[5]);
            b = hexascii_to_halfbyte(str[6]);
            motor_temp_box.Text = Convert.ToString(a * 16 + b);
            a = hexascii_to_halfbyte(str[7]);
            b = hexascii_to_halfbyte(str[8]);
            inverter_temp_box.Text = Convert.ToString(a * 16 + b);
        }

        private void hotcell_show(string str, int copy_of_dlc)
        {
            if (copy_of_dlc >= 1) { }
            else return;
            hotcell.Text = Convert.ToString(hexascii_to_halfbyte(str[5]) * 16 + hexascii_to_halfbyte(str[6]));
        }

        private void current_show(string str, int copy_of_dlc)
        {
            if (copy_of_dlc >= 1) { }
            else return;
            current_box.Text = Convert.ToString(hexascii_to_halfbyte(str[5]) * 16 + hexascii_to_halfbyte(str[6]));
        }

        private void vcu_show(string str, int copy_of_dlc, int id)
        {
            if (copy_of_dlc >= 2) { }
            else return;
            float current;
            int byte1, byte2;
            byte1 = hexascii_to_halfbyte(str[5]) * 16 + hexascii_to_halfbyte(str[6]);
            byte2 = hexascii_to_halfbyte(str[7]) * 16 + hexascii_to_halfbyte(str[8]);
            current = ((byte1 * 256) + byte2) / 1000f;
            vcu_currents[id - 0x500].Text = (current).ToString("F2");
        }

        private void slave_status_show(string str, int copy_of_dlc)
        {
            if (copy_of_dlc >= 8) { }
            else return;
            int status;
            for (int i = 0; i < 8; i++)
            {
                status = hexascii_to_halfbyte(str[i * 2 + 5]) * 16 + hexascii_to_halfbyte(str[i * 2 + 6]);
                if (status < 14)
                {
                    slave_number[i].Text = slave_statuses_messages[status].ToString();
                }
                else
                    continue;
            }
        }

        private void ams_master_status_show(string str, int copy_of_dlc)
        {
            int byte_1 = 0, byte_2 = 0;
            int mask = 0;
            if (copy_of_dlc >= 2) { }
            else return;
            byte_1 = (hexascii_to_halfbyte(str[5]) * 16 + hexascii_to_halfbyte(str[6]));
            byte_2 = (hexascii_to_halfbyte(str[7]) * 16 + hexascii_to_halfbyte(str[8]));
            richTextBox_master.Clear();
            if (byte_2 > 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    mask = 1 << i;
                    if ((byte_2 & (mask)) == (1 << i))
                        richTextBox_master.AppendText(master_statuses[i] + "\n");
                    //richTextBox_master.BeginInvoke(new Action(() => richTextBox_master.AppendText(master_statuses[i] + "\n")));
                }
            }
            if (byte_1 > 0)
            {
                for (int i = 0; i < 2; i++)
                {
                    mask = 1 << i;
                    if ((byte_1 & (mask)) == (1 << i))
                        richTextBox_master.AppendText(master_statuses[i + 8] + "\n");
                }
            }
        }

        private void actuator_show(string str, int copy_of_dlc)
        {
            if (copy_of_dlc >= 1) { }
            else return;
            int status;
            status = hexascii_to_halfbyte(str[5]) * 16 + hexascii_to_halfbyte(str[6]);
            if (status < 4)
                actuator_status_box.Text = actuator_statuses[status].ToString();
            else
                return;
        }

        private void precharge_show(string str, int copy_of_dlc)
        {
            if (copy_of_dlc >= 2) { }
            else return;
            string[] state = new string[2] { "Opened", "Closed" };
            int status = 0;
            string value = "";

            status = hexascii_to_halfbyte(str[5]) * 16 + hexascii_to_halfbyte(str[6]);
            if (precharge_dict.TryGetValue(status, out value))
            {
                precharge_status_box.Text = value;
            }

            status = hexascii_to_halfbyte(str[7]) * 16 + hexascii_to_halfbyte(str[8]);

            switch (status)
            {
                case 1: airminus_box.Text = state[0]; airplus_box.Text = state[0]; prechrelay_box.Text = state[0]; break;
                case 2: airminus_box.Text = state[1]; airplus_box.Text = state[0]; prechrelay_box.Text = state[0]; break;
                case 3: airminus_box.Text = state[1]; airplus_box.Text = state[0]; prechrelay_box.Text = state[1]; break;
                case 4: airminus_box.Text = state[1]; airplus_box.Text = state[1]; prechrelay_box.Text = state[0]; break;
            }


        }

        private void ams_lv_show(string str, int copy_of_dlc, int id)
        {
            int byte1, byte2, temp, status, symbol1, symbol2, symbol3, symbol4;
            float voltage;
            switch (id)
            {
                case 0x700:
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            symbol1 = str[i * 4 + 5]; symbol2 = str[i * 4 + 6]; symbol3 = str[i * 4 + 7]; symbol4 = str[i * 4 + 8];
                            byte1 = hexascii_to_halfbyte(symbol1) * 16 + hexascii_to_halfbyte(symbol2);
                            byte2 = hexascii_to_halfbyte(symbol3) * 16 + hexascii_to_halfbyte(symbol4);
                            voltage = (byte1 + byte2 * 0x100) / 10000f;
                            ams_lv_voltage[i].Text = voltage.ToString("F2");
                        }
                    }
                    break;

                case 0x701:
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            symbol1 = str[i * 4 + 5]; symbol2 = str[i * 4 + 6]; symbol3 = str[i * 4 + 7]; symbol4 = str[i * 4 + 8];
                            byte1 = hexascii_to_halfbyte(symbol1) * 16 + hexascii_to_halfbyte(symbol2);
                            byte2 = hexascii_to_halfbyte(symbol3) * 16 + hexascii_to_halfbyte(symbol4);
                            voltage = (byte1 + byte2 * 0x100) / 10000f;
                            ams_lv_voltage[i + 3].Text = voltage.ToString("F2");
                        }
                    }
                    break;

                case 0x702: // temp
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            temp = hexascii_to_halfbyte(str[i * 2 + 5]) * 16 + hexascii_to_halfbyte(str[i * 2 + 6]);
                            ams_lv_temp[i].Text = temp.ToString();
                        }
                    }
                    break;

                case 0x703: // status
                    {
                        status = hexascii_to_halfbyte(str[5]) * 16 + hexascii_to_halfbyte(str[6]);
                        ams_lv_status_box.Text = status.ToString();
                    }
                    break;

                case 0x704: // max temp
                    {
                        temp = hexascii_to_halfbyte(str[5]) * 16 + hexascii_to_halfbyte(str[6]);
                        lv_hottest_cell_box.Text = temp.ToString();
                    }
                    break;
            }
        }

        private void fan_regulator_show(string str, int copy_of_dlc)
        {
            int byte1, byte2, symbol1, symbol2, symbol3, symbol4, rpm;
            for (int i = 0; i < 2; i++)
            {
                symbol1 = str[i * 4 + 5]; symbol2 = str[i * 4 + 6]; symbol3 = str[i * 4 + 7]; symbol4 = str[i * 4 + 8];
                byte1 = hexascii_to_halfbyte(symbol1) * 16 + hexascii_to_halfbyte(symbol2);
                byte2 = hexascii_to_halfbyte(symbol3) * 16 + hexascii_to_halfbyte(symbol4);
                rpm = (byte1 << 8) + byte2;
                fan_rpm[i].Text = rpm.ToString();
            }
        }

        private void vcu_status_show(string str, int copy_of_dlc)
        {
            if (copy_of_dlc >= 2) { }
            else return;
            int byte1, byte2;
            int status;
            byte1 = hexascii_to_halfbyte(str[5]) * 16 + hexascii_to_halfbyte(str[6]);
            byte2 = hexascii_to_halfbyte(str[7]) * 16 + hexascii_to_halfbyte(str[8]);
            status = (byte)((byte1 * 256) + byte2);


            for (int i = 0; i <= 15; i++)
            {
                /*if (status & (1 << i))
                {

                }*/
            }

            if (status < 12)
            {
                vcu_status_box.Text = vcu_statuses[status];
            }
        }

        private int getfilter(string str)
        {
            int id = 0, delta = 0, length = 0;
            length = str.Length;
            for (int i = 0; i < length; i++)
            {
                delta = hexascii_to_halfbyte(str[i]);
                for (int j = 0; j < (length - i - 1); j++)
                    delta *= 16;
                id += delta;
            }
            return id;
        }

        private void charging_status_show(string str, int copy_of_dlc)
        {
            int status = 0;
            float current = 0;
            if (copy_of_dlc >= 2)
            {
                status = hexascii_to_halfbyte(str[5]) * 16 + hexascii_to_halfbyte(str[6]);
                if (status < 5)
                    charging_status_box.Text = charging_statuses[status];
                else return;

                current = (hexascii_to_halfbyte(str[7]) * 16 + hexascii_to_halfbyte(str[8])) / 10f;
                charging_current_box.Text = current.ToString("F1");
            }
            else return;
        }

        private void show_data(string message, int id)
        {
            int dlc;

            //if (message.Length >= 5) id = get_id_from_str(message);
            //else return;
            dlc = message[4] - '0';

            if ((id >= 0x100) && (id <= 0x13F))
                ams_show(message, dlc, id); // delta 288
            else if ((id >= 0x500) && (id <= 0x515))
                vcu_show(message, dlc, id);
            else if ((id >= 0x700) && (id <= 0x704))
                ams_lv_show(message, dlc, id);
            else
            {

                switch (id) //in hex formate
                {
                    case 0x140: slave_status_show(message, dlc); break;
                    case 0x141: ams_master_status_show(message, dlc); break;
                    case 0x142: hotcell_show(message, dlc); break;
                    case 0x143: charging_status_show(message, dlc); break;
                    case 0x150: current_show(message, dlc); break;
                    case 0x200: precharge_show(message, dlc); break;
                    //case 0x300: brake_pressure_box_show(message, dlc); break;
                    //case 0x301: ebs_pressure_box_show(message, dlc); break;
                    //case 0x302: sb_pressure_box_show(message, dlc); break;
                    case 0x300: fan_regulator_show(message, dlc); break;
                    case 0x519: vcu_status_show(message, dlc); break;
                    case 0x520: tractive_system_temp_show(message, dlc); break;
                    case 0x620: actuator_show(message, dlc); break;
                    default: return;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Text = null;
            comboBox1.Items.Clear();
            if (ports.Length != 0)
            {
                comboBox1.Items.AddRange(ports);
                comboBox1.SelectedIndex = 0;
            }
        }


        public void open_file_Click(object sender, EventArgs e)
        {
            int row_quantity = 0;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                myfile = openFileDialog1.FileName;
                textBox1.Text = myfile;
                readfile = File.ReadAllText(myfile);
                label9.Text = "Strings: ";
                progressBar1.BeginInvoke(new Action(() => progressBar1.Value = 0));
                row_quantity = row_count(readfile);
                richTextBox1.BeginInvoke(new Action(() => richTextBox1.Text = readfile));
                label9.BeginInvoke(new Action(() => label9.Text = "Strings: " + Convert.ToString(row_quantity)));
            }
        }

        private void close_file_Click(object sender, EventArgs e)
        {
            download_button_flag = false;
            download_process_flag = false;
            myfile = string.Empty;
            readfile = string.Empty;
            textBox1.Clear();
            richTextBox1.Clear();
            progressBar1.BeginInvoke(new Action(() => progressBar1.Value = 0));
        }

        private void download_Click(object sender, EventArgs e)
        {

            node_id = -1;
            foreach (Control control in nodes_groupBox.Controls)
            {
                // Проверка на принадлежность элемента управления к классу RadioButton:
                if (control.GetType() == typeof(System.Windows.Forms.RadioButton))
                {
                    // Создание отдельного (именованного) объекта класса RadioButton:
                    RadioButton rbControl = (RadioButton)control;
                    // Вывод сообщения, содержащего текст выбранного элемента:
                    if (rbControl.Checked)
                    {
                        node_id = rbControl.TabIndex;
                    }
                }
            }

            if (node_id != -1) { }  //  continue
            else
            {
                MessageBox.Show(this,
                    "Node not selected",
                    "Firmware Update",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,  // specify "Yes" as the default
                    (MessageBoxOptions)0x40000);
                return;
            }

            if (serialPort1.IsOpen)
                download_button_flag = true;
            else
            {
                MessageBox.Show(this,
                                    "Serial port is not open",
                                    "Firmware Update",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning,
                                    MessageBoxDefaultButton.Button1,  // specify "Yes" as the default
                                    (MessageBoxOptions)0x40000);
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            serial_reconnect();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            if (download_process_flag == false)
            {
                if (serialPort1.IsOpen)
                    serialPort1.Close();

                if (comboBox1.Text != "")
                    serialPort1.PortName = comboBox1.Text;
                else return;

                serialPort1.NewLine = "\r";

                try
                {
                    serialPort1.Open();
                    connect.BackColor = Color.LightGreen;
                }
                catch
                {
                    connect.BackColor = Color.LightPink;
                    serial_reconnect();
                    MessageBox.Show("Serial port opening error");
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ams_master_radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.ScrollToCaret();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            input_message = "";
            input_message = serialPort1.ReadLine();
            int id = 0;
            int load = 0;

            if (input_message.Length > 1) start_symbol = input_message[0];
            else return;


            if (start_symbol == 't')
            {
                id = get_id_from_str(input_message);
                if ((id >= filter_id_low) && (id <= filter_id_high)) //filter_id_low filter_id_high
                {
                    if ((message_counter++) > 1000)
                    {
                        message_counter = 0;
                        richTextBox2.BeginInvoke(new Action(() => richTextBox2.Clear()));
                    }
                    richTextBox2.BeginInvoke(new Action(() => richTextBox2.AppendText(input_message)));
                    show_data(input_message, id);               // вывести полученную информацию в соответствующую ячейку
                }
            }
            else if (start_symbol == 'w')   //  загруженность CAN шины
            {
                load = hexascii_to_halfbyte(input_message[1]) * 16 + hexascii_to_halfbyte(input_message[2]);
                can_bus_load.BeginInvoke(new Action(() => can_bus_load.Text = load.ToString() + "%"));
            }
            else if (start_symbol == 'b')
            {
                richTextBox2.BeginInvoke(new Action(() => richTextBox2.AppendText("Sent to CAN bootloader\n")));
                feedback_boot_flag = true;
            }
            else if (start_symbol == 'f')
            {
                richTextBox2.BeginInvoke(new Action(() => richTextBox2.AppendText("Received from usb\n")));
                feedback_usb_flag = true;
            }
        }

        void my_thread_1() // thread
        {
            int mem_transmit = 0, goal = 0;
            int row_counter = 0, row_quantity = 0;
            string line = string.Empty;
            StreamReader sr;
            string data_tx = string.Empty;
            var watch = new System.Diagnostics.Stopwatch();
            while (true)
            {
                if (download_button_flag == true)
                {
                    download_process_flag = true;
                    try
                    {
                        //Pass the file path and file name to the StreamReader constructor
                        sr = new StreamReader(myfile);
                        //Read the first line of text
                        row_quantity = 0;
                        row_counter = 0;
                        row_quantity = row_count(readfile);
                        richTextBox1.BeginInvoke(new Action(() => richTextBox1.Text = readfile));
                        label9.BeginInvoke(new Action(() => label9.Text = "Strings: " + Convert.ToString(row_quantity)));

                        watch.Reset();
                        watch.Start();
                        serialPort1.WriteLine("START" + Convert.ToChar('A' + node_id)); //  send a message to start downloading
                        line = sr.ReadLine();
                        //Continue to read until you reach end of file
                        while (line != null)
                        {
                            int counter_sent_lines = 64;
                            while (counter_sent_lines > 0) // send 64 lines
                            {
                                if (line != null)
                                {
                                    if (line[0] == ':')
                                    {
                                        mem_transmit = line[1] * 16 + line[2];
                                        if (mem_transmit > 0)
                                        {
                                            if ((hexascii_to_halfbyte(line[7]) * 16 + hexascii_to_halfbyte(line[8])) == 0)
                                            {
                                                serialPort1.WriteLine(line);
                                                row_counter++;
                                                counter_sent_lines--;
                                            }
                                        }
                                    }
                                    //Read the next line
                                    line = sr.ReadLine();
                                }
                                else
                                {
                                    serialPort1.WriteLine("END");
                                    break;
                                }
                            }
                            while ((feedback_usb_flag == false) || (feedback_boot_flag == false))  // waiting for a successful write of 1024 bytes (64 lines)
                                Thread.Sleep(1);
                            feedback_usb_flag = false; // allow sending the following 1024 bytes
                            feedback_boot_flag = false;

                            progressBar1.BeginInvoke(new Action(() => progressBar1.Value = row_counter * 100 / row_quantity));
                        }
                        //serialPort1.WriteLine("END");
                        download_button_flag = false;
                        download_process_flag = false;
                        progressBar1.BeginInvoke(new Action(() => progressBar1.Value = 100));
                        //close the file
                        sr.Close();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Exception: " + e.Message);
                    }
                    finally
                    {
                        watch.Stop();
                        MessageBox.Show(this,
                            row_counter.ToString() + " lines sent\n\rTime: " + watch.ElapsedMilliseconds.ToString() + " ms",
                            "Firmware Update",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1,  // specify "Yes" as the default
                            (MessageBoxOptions)0x40000);
                    }
                }
                else
                    Thread.Sleep(100);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //richTextBox2.AppendText(input_message);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void query_button_Click(object sender, EventArgs e)
        {
            if (download_process_flag == false && serialPort1.IsOpen)
            {
                precharge_radio.ForeColor = Color.DarkRed;
                discharge_radio.ForeColor = Color.DarkRed;
                vcu_radio.ForeColor = Color.DarkRed;
                bcu_radio.ForeColor = Color.DarkRed;
                ams_lv_radio.ForeColor = Color.DarkRed;
                brake_light_radio.ForeColor = Color.DarkRed;
                can_multiplexer_front_radio.ForeColor = Color.DarkRed;
                can_multiplexer_rear_radio.ForeColor = Color.DarkRed;
                ami_radio.ForeColor = Color.DarkRed;
                assi_radio.ForeColor = Color.DarkRed;
                fan_radio.ForeColor = Color.DarkRed;
                ams_master_radio.ForeColor = Color.DarkRed;
                ebs_radio.ForeColor = Color.DarkRed;
                steering_wheel_radio.ForeColor = Color.DarkRed;
                vcdu_radio.ForeColor = Color.DarkRed;
                serialPort1.Write("query");
            }
            else return;
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            connect.BackColor = Color.LightPink;
        }

        private void stack1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox104_TextChanged(object sender, EventArgs e)
        {

        }

        private void label448_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_1_Click(object sender, EventArgs e)
        {
            int list = 36 * 0;
            for (int i = 0; i < 36; i++)
            {
                tb[i + list].Text = "";
            }
            stackboxes_u[0].Text = "Stack voltage: -";
        }

        private void clear_2_Click(object sender, EventArgs e)
        {
            int list = 36 * 1;
            for (int i = 0; i < 36; i++)
            {
                tb[i + list].Text = "";
            }
            stackboxes_u[1].Text = "Stack voltage: -";
        }

        private void clear_3_Click(object sender, EventArgs e)
        {
            int list = 36 * 2;
            for (int i = 0; i < 36; i++)
            {
                tb[i + list].Text = "";
            }
            stackboxes_u[2].Text = "Stack voltage: -";
        }

        private void clear_4_Click(object sender, EventArgs e)
        {
            int list = 36 * 3;
            for (int i = 0; i < 36; i++)
            {
                tb[i + list].Text = "";
            }
            stackboxes_u[3].Text = "Stack voltage: -";
        }

        private void clear_5_Click(object sender, EventArgs e)
        {
            int list = 36 * 4;
            for (int i = 0; i < 36; i++)
            {
                tb[i + list].Text = "";
            }
            stackboxes_u[4].Text = "Stack voltage: -";
        }

        private void clear_6_Click(object sender, EventArgs e)
        {
            int list = 36 * 5;
            for (int i = 0; i < 36; i++)
            {
                tb[i + list].Text = "";
            }
            stackboxes_u[5].Text = "Stack voltage: -";
        }

        private void clear_7_Click(object sender, EventArgs e)
        {
            int list = 36 * 6;
            for (int i = 0; i < 36; i++)
            {
                tb[i + list].Text = "";
            }
            stackboxes_u[6].Text = "Stack voltage: -";
        }

        private void clear_8_Click(object sender, EventArgs e)
        {
            int list = 36 * 7;
            for (int i = 0; i < 36; i++)
            {
                tb[i + list].Text = "";
            }
            stackboxes_u[7].Text = "Stack voltage: -";
        }

        private void label454_Click(object sender, EventArgs e)
        {

        }

        private void label463_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label476_Click(object sender, EventArgs e)
        {

        }

        private void stack_7u_Click(object sender, EventArgs e)
        {

        }

        private void label475_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label478_Click(object sender, EventArgs e)
        {

        }

        private void label487_Click(object sender, EventArgs e)
        {

        }

        private void label488_Click(object sender, EventArgs e)
        {

        }

        private void label489_Click(object sender, EventArgs e)
        {

        }

        private void label490_Click(object sender, EventArgs e)
        {

        }

        private void label491_Click(object sender, EventArgs e)
        {

        }

        private void label492_Click(object sender, EventArgs e)
        {

        }

        private void label493_Click(object sender, EventArgs e)
        {

        }

        private void label494_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
        private void rpm1_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            filter_id_low = getfilter(filter_id_low_box.Text);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            filter_id_low = 0;
            filter_id_high = 0x7FF;
            filter_id_low_box.Text = filter_id_low.ToString("X");
            filter_id_high_box.Text = filter_id_high.ToString("X");
        }

        private void filter_id_low_box_TextChanged(object sender, EventArgs e)
        {

        }
        private void filter_id_high_box_TextChanged(object sender, EventArgs e)
        {
            filter_id_high = getfilter(filter_id_high_box.Text);
        }

        private void label501_Click(object sender, EventArgs e)
        {

        }

        private void ams_lv_status_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label497_Click(object sender, EventArgs e)
        {

        }

        private void label482_Click(object sender, EventArgs e)
        {

        }

        private void label503_Click(object sender, EventArgs e)
        {

        }

        private void actuator_current_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label528_Click(object sender, EventArgs e)
        {

        }

        private void label530_Click(object sender, EventArgs e)
        {

        }

        private void label531_Click(object sender, EventArgs e)
        {

        }

        private void label532_Click(object sender, EventArgs e)
        {

        }

        private void label533_Click(object sender, EventArgs e)
        {

        }

        private void label534_Click(object sender, EventArgs e)
        {

        }

        private void label535_Click(object sender, EventArgs e)
        {

        }

        private void label536_Click(object sender, EventArgs e)
        {

        }

        private void label537_Click(object sender, EventArgs e)
        {

        }

        private void label538_Click(object sender, EventArgs e)
        {

        }

        private void label539_Click(object sender, EventArgs e)
        {

        }

        private void assi_current_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void gps_current_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void as_current_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void cameras_current_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void res_current_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void lidar_current_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label513_Click(object sender, EventArgs e)
        {

        }

        private void label514_Click(object sender, EventArgs e)
        {

        }

        private void label515_Click(object sender, EventArgs e)
        {

        }

        private void label516_Click(object sender, EventArgs e)
        {

        }

        private void ebs_current_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void steering_wheel_radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void precharge_radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void label526_Click(object sender, EventArgs e)
        {

        }

        private void label554_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitontainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            stack1_box.Clear();
            stack2_box.Clear();
            stack3_box.Clear();
            stack4_box.Clear();
            stack5_box.Clear();
            stack6_box.Clear();
            stack7_box.Clear();
            stack8_box.Clear();
            brake_pressure_box.Clear();
            sb_pressure_box.Clear();
            ebs_pressure_box.Clear();
            rpm1_box.Clear();
            rpm2_box.Clear();
            motor_temp_box.Clear();
            inverter_temp_box.Clear();
            hotcell.Clear();
            current_box.Clear();
            slave_status_box_1.Clear();
            slave_status_box_2.Clear();
            slave_status_box_3.Clear();
            slave_status_box_4.Clear();
            slave_status_box_5.Clear();
            slave_status_box_6.Clear();
            slave_status_box_7.Clear();
            slave_status_box_8.Clear();
            vcdu_status_box.Clear();
            brake_system_status_box.Clear();
            airminus_box.Clear();
            airplus_box.Clear();
            prechrelay_box.Clear();
            precharge_status_box.Clear();
            total_voltage_box.Clear();
            lcs_current_box.Clear();
            inverter_current_box.Clear();
            tsal_current_box.Clear();
            cooling_pump_current_box.Clear();
            vcdu_current_box.Clear();
            brake_light_current_box.Clear();
            fan1_current_box.Clear();
            fan2_current_box.Clear();
            vcu_status_box.Clear();
            master_status_box.Clear();
            actuator_status_box.Clear();
            lv_hottest_cell_box.Clear();
            lv_temp_cell_1_box.Clear();
            lv_temp_cell_2_box.Clear();
            lv_temp_cell_3_box.Clear();
            lv_temp_cell_4_box.Clear();
            lv_temp_cell_5_box.Clear();
            lv_temp_cell_6_box.Clear();
            lv_voltage_cell_1_box.Clear();
            lv_voltage_cell_2_box.Clear();
            lv_voltage_cell_3_box.Clear();
            lv_voltage_cell_4_box.Clear();
            lv_voltage_cell_5_box.Clear();
            lv_voltage_cell_6_box.Clear();
            ams_lv_status_box.Clear();
            actuator_current_box.Clear();
            ebs_current_box.Clear();
            gps_current_box.Clear();
            cameras_current_box.Clear();
            lidar_current_box.Clear();
            assi_current_box.Clear();
            res_current_box.Clear();
            assi_current_box.Clear();
            vcdu_current_box.Clear();
            brake_light_current_box.Clear();
            charging_current_box.Clear();
            charging_status_box.Clear();
            voltage_min_box.Clear();
            voltage_max_box.Clear();
            cell_min_number.Text = "Cell: -";
            cell_max_number.Text = "Cell: -";
            stack_min_number.Text = "Stack: -";
            stack_max_number.Text = "Stack: -";
            max_cell_voltage = 0;
            min_cell_voltage = 1000;
            richTextBox_master.Clear();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            max_cell_voltage = 0.2F;
            min_cell_voltage = 10;
        }

        private void label449_Click(object sender, EventArgs e)
        {

        }

        private void label553_Click(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void label558_Click(object sender, EventArgs e)
        {

        }

        private void stack_min_box_Click(object sender, EventArgs e)
        {

        }
    }
}
