    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using Args;
using wnd;
using Logger;
using MathParserNet;

namespace thing_2._1
{
    class BodyOfForm : Form
    {
        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar ProgressBar;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem створитиToolStripMenuItem;
        private ToolStripMenuItem відкритиToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private ToolStripMenuItem вийтиToolStripMenuItem;
        private ToolStripMenuItem експоненціальнийРозподілToolStripMenuItem;
        private ToolStripMenuItem нормальнийРозподілToolStripMenuItem;
        private ToolStripMenuItem рівномірнийРозподілToolStripMenuItem;
        private ToolStripMenuItem розподілРелеяToolStripMenuItem;
        private ToolStripMenuItem відмінитиToolStripMenuItem;
        private ToolStripMenuItem крокНазадToolStripMenuItem;
        private ToolStripMenuItem доПочатковихЗначеньToolStripMenuItem;
        private ToolStripMenuItem довідкаToolStripMenuItem;
        private ToolStripMenuItem розподілЛапласаToolStripMenuItem;
        private ToolStripMenuItem розподілВуйбуллаToolStripMenuItem;
        private TabControl tabControl2;
        private TabPage PageData;
        private Panel panel1;
        private TextBox LogOutputTextBox;
        private TabPage tabPage7;
        private ToolStripStatusLabel StatusLabelFile;
        private ToolStripStatusLabel StatusLabelNameOfFile;
        private ToolStripStatusLabel StatusLabelForFreeSpace;
        private CheckBox LogCheckBox;
        private Label LogOutputLabel;
        private DataGridView DataGridForData;
        private Button button1;
        private DataOfForm Data;
        private DataOfHist HistData;
        private ToolStripMenuItem вибіркиToolStripMenuItem;
        private ToolStripMenuItem вибратиВибіркуToolStripMenuItem;
        private ToolStripMenuItem порівнятиВибіркиToolStripMenuItem;
        private ToolStripMenuItem розподілАрксинусаToolStripMenuItem;
        private TabPage PageEval;
        private DataGridView DataGridForEval;
        private TabPage PageFunc;
        private Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart DistrFun;
        private TabPage PageHist;
        private Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Histogramme;
        private TabControl tabControl1;
        private GroupBox groupBox3;
        private TabPage PafeChange;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button button4;
        private Button button5;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button6;
        private TextBox TextBoxForDelete;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Label label1;
        private TextBox TextBoxForPos;
        private Button button12;
        private Button button11;
        private TextBox textBox3;
        private Button button15;
        private ToolStripMenuItem додатковоToolStripMenuItem;
        private ToolStripMenuItem включитивиключитиМаштабуванняToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripforNumber;
        private Button button16;
        private Button button17;
        private Label label4;
        private Label label3;
        private GroupBox groupBox6;
        private Button button13;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private CheckBox checkBox1;
        private ToolStripMenuItem видалитиВибіркуToolStripMenuItem;
        private ToolStripMenuItem включитивиключитиПобудовуВаріаційногоРядуToolStripMenuItem;
        private ToolStripMenuItem включитивиключитиОбрахуавнняМедіаниСередніхToolStripMenuItem;
        private DataGridViewTextBoxColumn ColumnOfNames;
        private DataGridViewTextBoxColumn ColumnLeftBor;
        private DataGridViewTextBoxColumn ColumnOfValues;
        private DataGridViewTextBoxColumn ColumnRightBor;
        private DataGridViewTextBoxColumn ColumnPosib;
        private Button button18;
        private GroupBox groupBox7;
        private Button button19;
        private ToolStripMenuItem задатиКількістьЗнаківПісляКомиДляІнтерфейсівToolStripMenuItem;
        private Button button14;
        private ToolStripMenuItem відкритиповекторноToolStripMenuItem;
        private ToolStripMenuItem відкритиДвовиміруВибіркуToolStripMenuItem;
        private TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Column1;
        private ToolStripMenuItem видалитиДвовимірнуВибіркуToolStripMenuItem;
        private ToolStripMenuItem вибратиДвомірнуВибіркуToolStripMenuItem;
        private ToolStripMenuItem двовимірнийНормальнийToolStripMenuItem;
        private ToolStripMenuItem двовимірнуВибіркуПоРегресииToolStripMenuItem;
        private ToolStripMenuItem обєднатиУДвовимірнуToolStripMenuItem;
        private Button button20;
        private TextBox textBox4;
        private Label label2;
        private ToolStripMenuItem зберегтиДвовимірнуВибіркуToolStripMenuItem;
        private TabPage tabPage4;
        private Button button21;
        private DataGridView dataGridView2;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label6;
        private Label label5;
        private TabPage tabPage5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridView dataGridView4;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label7;
        private Label label8;
        private Button button23;
        private TextBox textBox9;
        private Label label9;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private TabPage tabPage6;
        private GroupBox groupBox8;
        private Label label10;
        private Button button22;
        private TextBox textBox10;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private Button button25;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button24;
        private TextBox textBox11;
        private Label label11;
        private TabControl tabControl3;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private TextBox textBox12;
        private Label label12;
        private TextBox textBox14;
        private TextBox textBox13;
        private Label label14;
        private Label label13;
        private TabPage tabPage10;
        private TextBox textBox15;
        private TextBox textBox16;
        private Label label15;
        private Label label16;
        private RadioButton radioButton3;
        private Button button26;
        private RadioButton radioButton4;
        private Label label17;
        private CheckBox checkBox2;
        private TextBox textBox19;
        private Label label20;
        private TextBox textBox17;
        private TextBox textBox18;
        private Button button27;
        private Label label18;
        private Label label19;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private ToolStripMenuItem відкритиБагатовимірнуВибіркуToolStripMenuItem;
        private Button button28;
        private Button button29;
        private ToolStripMenuItem багатовимірнийНормальнийРозподілToolStripMenuItem;
        private TabPage tabPage11;
        private DataGridView dataGridView5;
        private TabPage tabPage12;
        private DataGridView dataGridView6;
        private TabPage tabPage13;
        private DataGridView dataGridView7;
        private TabPage tabPage15;
        private Label label21;
        private Button button30;
        private TextBox textBox20;
        private DataGridView dataGridView8;
        private TabPage tabPage14;
        private TabControl tabControl4;
        private TabPage tabPage16;
        private TableLayoutPanel tableLayoutPanel1;
        private TabPage tabPage17;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private TabPage tabPage18;
        private TabPage tabPage19;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private TabPage tabPage20;
        private GroupBox groupBox10;
        private GroupBox groupBox9;
        private ComboBox comboBox4;
        private ToolStripMenuItem вибратиБагатовимірнуВибіркуToolStripMenuItem;
        private ToolStripMenuItem видалитиБагатовимірнуВибіркуToolStripMenuItem;
        private ToolStripMenuItem обєднатиУБагатовимірнуToolStripMenuItem;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private Button button31;
        private DataGridView dataGridView10;
        private TextBox textBox23;
        private Label label28;
        private TextBox textBox22;
        private Label label27;
        private TextBox textBox21;
        private Label label26;
        private TextBox textBox26;
        private TextBox textBox25;
        private TextBox textBox24;
        private DataOfDsitrFun DistrFuncData;
        private TextBox textBox27;
        private Label label29;
        private DataGridViewTextBoxColumn Column14;
        private ToolStripMenuItem перевіркаГіпотезПроЗбігПараметрівБагатовимірнихВибірокToolStripMenuItem;
        private Button button32;
        private TabPage tabPage21;
        private DataGridView dataGridView11;
        private DataGridView dataGridView9;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column15;
        private ToolStripMenuItem зберегтиБагатовимірнуВибіркуToolStripMenuItem;
        private ToolStripMenuItem оновитиToolStripMenuItem;
        private ToolStripMenuItem крокНазаддвовимірніToolStripMenuItem;
        private ToolStripMenuItem крокНазадбагатовимірніToolStripMenuItem;
        private Button button33;
        private ToolStripMenuItem доПочатковихЗначеньДвовимірніToolStripMenuItem;
        private ToolStripMenuItem доПочатковихЗначеньБагатовимірніToolStripMenuItem;
        private CheckBox checkBox7;
        private Button button34;
        private TabPage tabPage22;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart5;
        private PictureBox pictureBox1;
        private CheckBox checkBox9;
        private CheckBox checkBox8;
        private Panel panel2;
        private CheckBox checkBox10;
        private GroupBox groupBox11;
        private Button button35;
        private RadioButton radioButton10;
        private RadioButton radioButton9;
        private RadioButton radioButton11;
        private TextBox textBox28;
        private Label label30;
        private TextBox textBox29;
        private Label label31;
        private TabControl tabControl6;
        private TabPage tabPage25;
        private DataGridView dataGridView12;
        private TabPage tabPage26;
        private DataGridView dataGridView13;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column19;
        private DataGridViewTextBoxColumn Column20;
        private DataGridViewTextBoxColumn Column21;
        private DataGridViewTextBoxColumn Column22;
        private CheckBox checkBox11;
        private ToolStripMenuItem застосуватиМГКдвовимірніToolStripMenuItem;
        private TabPage tabPage23;
        private Button button36;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart6;
        private Button button37;
		private RadioButton radioButton13;
		private RadioButton radioButton12;
		private DataGridView[] DataGridForChkk;
    
        public BodyOfForm()
        {
            Data = new DataOfForm();
            HistData = new DataOfHist();
            DistrFuncData = new DataOfDsitrFun();
            InitializeComponent();
            {
                DataGridForEval.Rows.Add("Мат. сподівання","","","","");
                DataGridForEval.Rows.Add("Вибіркова медіана", " --- ", "", " --- ", " --- ");
                DataGridForEval.Rows.Add("Усічене середнє", " --- ", "", " --- ", "");
                DataGridForEval.Rows.Add("Медіана середніх Уолша", " --- ", "", " --- ", " --- ");
                DataGridForEval.Rows.Add("Стандартне відхилення", "", "", "", "");
                DataGridForEval.Rows.Add("МАД", " --- ", "", " --- ", " --- ");
                DataGridForEval.Rows.Add("Коефіцієнт асиметрії", "", "", "", "");
                DataGridForEval.Rows.Add("Коефіцієнт ексцессу", "", "", "", "");
                DataGridForEval.Rows.Add("Коеф. контрексцессу", " --- ", "", " --- ", " --- ");
                DataGridForEval.Rows.Add("КВП", "", "", "", ""); 
                DataGridForEval.Rows.Add("Інтервал передбачення", "", " --- ", "", "");
                DataGridForEval.Rows[0].Cells[4].ReadOnly =  false;
                DataGridForEval.Rows[2].Cells[4].ReadOnly = false;
                DataGridForEval.Rows[4].Cells[4].ReadOnly = false;
                DataGridForEval.Rows[6].Cells[4].ReadOnly = false;
                DataGridForEval.Rows[7].Cells[4].ReadOnly = false;
                DataGridForEval.Rows[9].Cells[4].ReadOnly = false;
                DataGridForEval.Rows[10].Cells[4].ReadOnly = false;
                LogOutputTextBox.Text += "Theres nothing to do" + Environment.NewLine;
                dataGridView1.Rows.Add("Мат. сподівання X", "", "", "", "", "---");
                dataGridView1.Rows.Add("Мат. сподівання Y", "", "", "", "", "---");
                dataGridView1.Rows.Add("Стандартне відхилення X", "", "", "", "", "");
                dataGridView1.Rows.Add("Стандартне відхилення Y", "", "", "", "", "");
                dataGridView1.Rows.Add("Оцінка адекватності відтворення нормального розподілу", "---", "", "---", "", "");
                dataGridView1.Rows.Add("Коефіціент кореляції", "", "", "", "","");
                dataGridView1.Rows.Add("Кореляційне відношення по Х", "", "", "", "", "---");
                dataGridView1.Rows.Add("Кореляційне відношення по Y", "", "", "", "", "---");
                dataGridView1.Rows.Add("Р.к.к. Спірмена", "", "", "", "", "---");
                dataGridView1.Rows.Add("Р.к.к. Кендалла", "", "", "", "", "---");
                dataGridView2.Rows.Add("Індекс Фехнера", "", "---", "---");
                dataGridView2.Rows.Add("Коефіціент сполучень Φ", "", "", "");
                dataGridView2.Rows.Add("Коефіціент зв'язку Юла Q", "", "", "");
                dataGridView2.Rows.Add("Коефіціент зв'язку Юла Y", "", "", "");
                dataGridView4.Rows.Add("Коефіціент сполучень Пірсона", "");
                dataGridView4.Rows.Add("Мір звяззку Кендалла", "");
                dataGridView4.Rows.Add("Статистика Стюарда", "");
                //DataGridForEval.Rows[2].Cells[4].

            }
        }

        private void InitializeComponent()
        {
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series31 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.створитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.експоненціальнийРозподілToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.нормальнийРозподілToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.рівномірнийРозподілToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.розподілРелеяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.розподілЛапласаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.розподілВуйбуллаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.розподілАрксинусаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.двовимірнийНормальнийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.двовимірнуВибіркуПоРегресииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.багатовимірнийНормальнийРозподілToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.відкритиповекторноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.відкритиДвовиміруВибіркуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.відкритиБагатовимірнуВибіркуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.обєднатиУДвовимірнуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.обєднатиУБагатовимірнуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.зберегтиДвовимірнуВибіркуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.зберегтиБагатовимірнуВибіркуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.вийтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.вибіркиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.вибратиВибіркуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.порівнятиВибіркиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.видалитиВибіркуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.вибратиДвомірнуВибіркуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.видалитиДвовимірнуВибіркуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.вибратиБагатовимірнуВибіркуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.видалитиБагатовимірнуВибіркуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.перевіркаГіпотезПроЗбігПараметрівБагатовимірнихВибірокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.відмінитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.крокНазадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.доПочатковихЗначеньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.крокНазаддвовимірніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.доПочатковихЗначеньДвовимірніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.крокНазадбагатовимірніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.доПочатковихЗначеньБагатовимірніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.додатковоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.включитивиключитиМаштабуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.включитивиключитиПобудовуВаріаційногоРядуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.включитивиключитиОбрахуавнняМедіаниСередніхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.задатиКількістьЗнаківПісляКомиДляІнтерфейсівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оновитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.застосуватиМГКдвовимірніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.StatusLabelForFreeSpace = new System.Windows.Forms.ToolStripStatusLabel();
			this.StatusLabelFile = new System.Windows.Forms.ToolStripStatusLabel();
			this.StatusLabelNameOfFile = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripforNumber = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.PageData = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button10 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.TextBoxForPos = new System.Windows.Forms.TextBox();
			this.DataGridForData = new System.Windows.Forms.DataGridView();
			this.PafeChange = new System.Windows.Forms.TabPage();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.button19 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TextBoxForDelete = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button6 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.button18 = new System.Windows.Forms.Button();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.button14 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.button12 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.button11 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.button22 = new System.Windows.Forms.Button();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage15 = new System.Windows.Forms.TabPage();
			this.button34 = new System.Windows.Forms.Button();
			this.button33 = new System.Windows.Forms.Button();
			this.button32 = new System.Windows.Forms.Button();
			this.label21 = new System.Windows.Forms.Label();
			this.button30 = new System.Windows.Forms.Button();
			this.textBox20 = new System.Windows.Forms.TextBox();
			this.dataGridView8 = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button16 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.LogCheckBox = new System.Windows.Forms.CheckBox();
			this.LogOutputLabel = new System.Windows.Forms.Label();
			this.LogOutputTextBox = new System.Windows.Forms.TextBox();
			this.PageEval = new System.Windows.Forms.TabPage();
			this.button17 = new System.Windows.Forms.Button();
			this.DataGridForEval = new System.Windows.Forms.DataGridView();
			this.ColumnOfNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnLeftBor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnOfValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnRightBor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPosib = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PageFunc = new System.Windows.Forms.TabPage();
			this.button3 = new System.Windows.Forms.Button();
			this.DistrFun = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.PageHist = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.Histogramme = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tabControl3 = new System.Windows.Forms.TabControl();
			this.tabPage8 = new System.Windows.Forms.TabPage();
			this.button29 = new System.Windows.Forms.Button();
			this.button28 = new System.Windows.Forms.Button();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.button25 = new System.Windows.Forms.Button();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.tabPage9 = new System.Windows.Forms.TabPage();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.textBox19 = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.textBox17 = new System.Windows.Forms.TextBox();
			this.textBox18 = new System.Windows.Forms.TextBox();
			this.button27 = new System.Windows.Forms.Button();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.tabPage10 = new System.Windows.Forms.TabPage();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.label17 = new System.Windows.Forms.Label();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.textBox16 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.button26 = new System.Windows.Forms.Button();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.button24 = new System.Windows.Forms.Button();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.checkBox11 = new System.Windows.Forms.CheckBox();
			this.checkBox10 = new System.Windows.Forms.CheckBox();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button20 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.button21 = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.button23 = new System.Windows.Forms.Button();
			this.dataGridView4 = new System.Windows.Forms.DataGridView();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tabPage11 = new System.Windows.Forms.TabPage();
			this.dataGridView5 = new System.Windows.Forms.DataGridView();
			this.tabPage12 = new System.Windows.Forms.TabPage();
			this.dataGridView6 = new System.Windows.Forms.DataGridView();
			this.tabPage13 = new System.Windows.Forms.TabPage();
			this.dataGridView7 = new System.Windows.Forms.DataGridView();
			this.tabPage14 = new System.Windows.Forms.TabPage();
			this.tabControl4 = new System.Windows.Forms.TabControl();
			this.tabPage16 = new System.Windows.Forms.TabPage();
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tabPage17 = new System.Windows.Forms.TabPage();
			this.checkBox9 = new System.Windows.Forms.CheckBox();
			this.textBox26 = new System.Windows.Forms.TextBox();
			this.textBox25 = new System.Windows.Forms.TextBox();
			this.textBox24 = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tabPage18 = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.checkBox8 = new System.Windows.Forms.CheckBox();
			this.tabPage19 = new System.Windows.Forms.TabPage();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tabPage20 = new System.Windows.Forms.TabPage();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.textBox27 = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.button31 = new System.Windows.Forms.Button();
			this.dataGridView10 = new System.Windows.Forms.DataGridView();
			this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBox23 = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.textBox22 = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.textBox21 = new System.Windows.Forms.TextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.radioButton8 = new System.Windows.Forms.RadioButton();
			this.radioButton7 = new System.Windows.Forms.RadioButton();
			this.dataGridView9 = new System.Windows.Forms.DataGridView();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.tabPage21 = new System.Windows.Forms.TabPage();
			this.dataGridView11 = new System.Windows.Forms.DataGridView();
			this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage22 = new System.Windows.Forms.TabPage();
			this.tabControl6 = new System.Windows.Forms.TabControl();
			this.tabPage25 = new System.Windows.Forms.TabPage();
			this.dataGridView12 = new System.Windows.Forms.DataGridView();
			this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage26 = new System.Windows.Forms.TabPage();
			this.dataGridView13 = new System.Windows.Forms.DataGridView();
			this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox11 = new System.Windows.Forms.GroupBox();
			this.textBox29 = new System.Windows.Forms.TextBox();
			this.label31 = new System.Windows.Forms.Label();
			this.textBox28 = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.radioButton11 = new System.Windows.Forms.RadioButton();
			this.button35 = new System.Windows.Forms.Button();
			this.radioButton10 = new System.Windows.Forms.RadioButton();
			this.radioButton9 = new System.Windows.Forms.RadioButton();
			this.chart5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tabPage23 = new System.Windows.Forms.TabPage();
			this.button37 = new System.Windows.Forms.Button();
			this.button36 = new System.Windows.Forms.Button();
			this.chart6 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.radioButton12 = new System.Windows.Forms.RadioButton();
			this.radioButton13 = new System.Windows.Forms.RadioButton();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.PageData.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridForData)).BeginInit();
			this.PafeChange.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage7.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.groupBox8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.tabPage15.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
			this.panel1.SuspendLayout();
			this.PageEval.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridForEval)).BeginInit();
			this.PageFunc.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DistrFun)).BeginInit();
			this.PageHist.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Histogramme)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabControl3.SuspendLayout();
			this.tabPage8.SuspendLayout();
			this.tabPage9.SuspendLayout();
			this.tabPage10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.tabPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
			this.tabPage11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
			this.tabPage12.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
			this.tabPage13.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
			this.tabPage14.SuspendLayout();
			this.tabControl4.SuspendLayout();
			this.tabPage16.SuspendLayout();
			this.tabPage17.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
			this.tabPage18.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabPage19.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
			this.tabPage20.SuspendLayout();
			this.groupBox10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).BeginInit();
			this.groupBox9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).BeginInit();
			this.tabPage21.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).BeginInit();
			this.tabPage22.SuspendLayout();
			this.tabControl6.SuspendLayout();
			this.tabPage25.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView12)).BeginInit();
			this.tabPage26.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView13)).BeginInit();
			this.groupBox11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart5)).BeginInit();
			this.tabPage23.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart6)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.вибіркиToolStripMenuItem,
            this.відмінитиToolStripMenuItem,
            this.додатковоToolStripMenuItem,
            this.довідкаToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1301, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.створитиToolStripMenuItem,
            this.відкритиToolStripMenuItem,
            this.відкритиповекторноToolStripMenuItem,
            this.відкритиДвовиміруВибіркуToolStripMenuItem,
            this.відкритиБагатовимірнуВибіркуToolStripMenuItem,
            this.обєднатиУДвовимірнуToolStripMenuItem,
            this.зберегтиToolStripMenuItem,
            this.обєднатиУБагатовимірнуToolStripMenuItem,
            this.зберегтиДвовимірнуВибіркуToolStripMenuItem,
            this.зберегтиБагатовимірнуВибіркуToolStripMenuItem,
            this.вийтиToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// створитиToolStripMenuItem
			// 
			this.створитиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.експоненціальнийРозподілToolStripMenuItem,
            this.нормальнийРозподілToolStripMenuItem,
            this.рівномірнийРозподілToolStripMenuItem,
            this.розподілРелеяToolStripMenuItem,
            this.розподілЛапласаToolStripMenuItem,
            this.розподілВуйбуллаToolStripMenuItem,
            this.розподілАрксинусаToolStripMenuItem,
            this.двовимірнийНормальнийToolStripMenuItem,
            this.двовимірнуВибіркуПоРегресииToolStripMenuItem,
            this.багатовимірнийНормальнийРозподілToolStripMenuItem});
			this.створитиToolStripMenuItem.Name = "створитиToolStripMenuItem";
			this.створитиToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
			this.створитиToolStripMenuItem.Text = "Створити";
			// 
			// експоненціальнийРозподілToolStripMenuItem
			// 
			this.експоненціальнийРозподілToolStripMenuItem.Name = "експоненціальнийРозподілToolStripMenuItem";
			this.експоненціальнийРозподілToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
			this.експоненціальнийРозподілToolStripMenuItem.Text = "Експоненціальний розподіл";
			this.експоненціальнийРозподілToolStripMenuItem.Click += new System.EventHandler(this.експоненціальнийРозподілToolStripMenuItem_Click);
			// 
			// нормальнийРозподілToolStripMenuItem
			// 
			this.нормальнийРозподілToolStripMenuItem.Name = "нормальнийРозподілToolStripMenuItem";
			this.нормальнийРозподілToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
			this.нормальнийРозподілToolStripMenuItem.Text = "Нормальний розподіл";
			this.нормальнийРозподілToolStripMenuItem.Click += new System.EventHandler(this.нормальнийРозподілToolStripMenuItem_Click);
			// 
			// рівномірнийРозподілToolStripMenuItem
			// 
			this.рівномірнийРозподілToolStripMenuItem.Name = "рівномірнийРозподілToolStripMenuItem";
			this.рівномірнийРозподілToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
			this.рівномірнийРозподілToolStripMenuItem.Text = "Рівномірний розподіл";
			this.рівномірнийРозподілToolStripMenuItem.Click += new System.EventHandler(this.рівномірнийРозподілToolStripMenuItem_Click);
			// 
			// розподілРелеяToolStripMenuItem
			// 
			this.розподілРелеяToolStripMenuItem.Name = "розподілРелеяToolStripMenuItem";
			this.розподілРелеяToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
			this.розподілРелеяToolStripMenuItem.Text = "Розподіл Релея";
			this.розподілРелеяToolStripMenuItem.Click += new System.EventHandler(this.розподілРелеяToolStripMenuItem_Click);
			// 
			// розподілЛапласаToolStripMenuItem
			// 
			this.розподілЛапласаToolStripMenuItem.Name = "розподілЛапласаToolStripMenuItem";
			this.розподілЛапласаToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
			this.розподілЛапласаToolStripMenuItem.Text = "Розподіл Лапласа";
			this.розподілЛапласаToolStripMenuItem.Click += new System.EventHandler(this.розподілЛапласаToolStripMenuItem_Click);
			// 
			// розподілВуйбуллаToolStripMenuItem
			// 
			this.розподілВуйбуллаToolStripMenuItem.Name = "розподілВуйбуллаToolStripMenuItem";
			this.розподілВуйбуллаToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
			this.розподілВуйбуллаToolStripMenuItem.Text = "Розподіл Вейбулла";
			this.розподілВуйбуллаToolStripMenuItem.Click += new System.EventHandler(this.розподілВуйбуллаToolStripMenuItem_Click);
			// 
			// розподілАрксинусаToolStripMenuItem
			// 
			this.розподілАрксинусаToolStripMenuItem.Name = "розподілАрксинусаToolStripMenuItem";
			this.розподілАрксинусаToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
			this.розподілАрксинусаToolStripMenuItem.Text = "Розподіл арксинуса";
			this.розподілАрксинусаToolStripMenuItem.Click += new System.EventHandler(this.розподілАрксинусаToolStripMenuItem_Click);
			// 
			// двовимірнийНормальнийToolStripMenuItem
			// 
			this.двовимірнийНормальнийToolStripMenuItem.Name = "двовимірнийНормальнийToolStripMenuItem";
			this.двовимірнийНормальнийToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
			this.двовимірнийНормальнийToolStripMenuItem.Text = "Двовимірний нормальний";
			this.двовимірнийНормальнийToolStripMenuItem.Click += new System.EventHandler(this.двовимірнийНормальнийToolStripMenuItem_Click);
			// 
			// двовимірнуВибіркуПоРегресииToolStripMenuItem
			// 
			this.двовимірнуВибіркуПоРегресииToolStripMenuItem.Name = "двовимірнуВибіркуПоРегресииToolStripMenuItem";
			this.двовимірнуВибіркуПоРегресииToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
			this.двовимірнуВибіркуПоРегресииToolStripMenuItem.Text = "Двовимірну вибірку по регресії";
			this.двовимірнуВибіркуПоРегресииToolStripMenuItem.Click += new System.EventHandler(this.двовимірнуВибіркуПоРегресииToolStripMenuItem_Click);
			// 
			// багатовимірнийНормальнийРозподілToolStripMenuItem
			// 
			this.багатовимірнийНормальнийРозподілToolStripMenuItem.Name = "багатовимірнийНормальнийРозподілToolStripMenuItem";
			this.багатовимірнийНормальнийРозподілToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
			this.багатовимірнийНормальнийРозподілToolStripMenuItem.Text = "Багатовимірний нормальний розподіл";
			this.багатовимірнийНормальнийРозподілToolStripMenuItem.Click += new System.EventHandler(this.багатовимірнийНормальнийРозподілToolStripMenuItem_Click);
			// 
			// відкритиToolStripMenuItem
			// 
			this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
			this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
			this.відкритиToolStripMenuItem.Text = "Відкрити";
			this.відкритиToolStripMenuItem.Click += new System.EventHandler(this.відкритиToolStripMenuItem_Click);
			// 
			// відкритиповекторноToolStripMenuItem
			// 
			this.відкритиповекторноToolStripMenuItem.Name = "відкритиповекторноToolStripMenuItem";
			this.відкритиповекторноToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
			this.відкритиповекторноToolStripMenuItem.Text = "Відкрити(повекторно)";
			this.відкритиповекторноToolStripMenuItem.Click += new System.EventHandler(this.відкритиповекторноToolStripMenuItem_Click);
			// 
			// відкритиДвовиміруВибіркуToolStripMenuItem
			// 
			this.відкритиДвовиміруВибіркуToolStripMenuItem.Name = "відкритиДвовиміруВибіркуToolStripMenuItem";
			this.відкритиДвовиміруВибіркуToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
			this.відкритиДвовиміруВибіркуToolStripMenuItem.Text = "Відкрити двовиміру вибірку";
			this.відкритиДвовиміруВибіркуToolStripMenuItem.Click += new System.EventHandler(this.відкритиДвовиміруВибіркуToolStripMenuItem_Click);
			// 
			// відкритиБагатовимірнуВибіркуToolStripMenuItem
			// 
			this.відкритиБагатовимірнуВибіркуToolStripMenuItem.Name = "відкритиБагатовимірнуВибіркуToolStripMenuItem";
			this.відкритиБагатовимірнуВибіркуToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
			this.відкритиБагатовимірнуВибіркуToolStripMenuItem.Text = "Відкрити багатовимірну вибірку";
			this.відкритиБагатовимірнуВибіркуToolStripMenuItem.Click += new System.EventHandler(this.відкритиБагатовимірнуВибіркуToolStripMenuItem_Click);
			// 
			// обєднатиУДвовимірнуToolStripMenuItem
			// 
			this.обєднатиУДвовимірнуToolStripMenuItem.Name = "обєднатиУДвовимірнуToolStripMenuItem";
			this.обєднатиУДвовимірнуToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
			this.обєднатиУДвовимірнуToolStripMenuItem.Text = "Об\'єднати у двовимірну";
			this.обєднатиУДвовимірнуToolStripMenuItem.Click += new System.EventHandler(this.обєднатиУДвовимірнуToolStripMenuItem_Click);
			// 
			// зберегтиToolStripMenuItem
			// 
			this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
			this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
			this.зберегтиToolStripMenuItem.Text = "Зберегти";
			this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.зберегтиToolStripMenuItem_Click);
			// 
			// обєднатиУБагатовимірнуToolStripMenuItem
			// 
			this.обєднатиУБагатовимірнуToolStripMenuItem.Name = "обєднатиУБагатовимірнуToolStripMenuItem";
			this.обєднатиУБагатовимірнуToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
			this.обєднатиУБагатовимірнуToolStripMenuItem.Text = "Об\'єднати у багатовимірну";
			this.обєднатиУБагатовимірнуToolStripMenuItem.Click += new System.EventHandler(this.обєднатиУБагатовимірнуToolStripMenuItem_Click);
			// 
			// зберегтиДвовимірнуВибіркуToolStripMenuItem
			// 
			this.зберегтиДвовимірнуВибіркуToolStripMenuItem.Name = "зберегтиДвовимірнуВибіркуToolStripMenuItem";
			this.зберегтиДвовимірнуВибіркуToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
			this.зберегтиДвовимірнуВибіркуToolStripMenuItem.Text = "Зберегти двовимірну вибірку";
			this.зберегтиДвовимірнуВибіркуToolStripMenuItem.Click += new System.EventHandler(this.зберегтиДвовимірнуВибіркуToolStripMenuItem_Click);
			// 
			// зберегтиБагатовимірнуВибіркуToolStripMenuItem
			// 
			this.зберегтиБагатовимірнуВибіркуToolStripMenuItem.Name = "зберегтиБагатовимірнуВибіркуToolStripMenuItem";
			this.зберегтиБагатовимірнуВибіркуToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
			this.зберегтиБагатовимірнуВибіркуToolStripMenuItem.Text = "Зберегти багатовимірну вибірку";
			this.зберегтиБагатовимірнуВибіркуToolStripMenuItem.Click += new System.EventHandler(this.зберегтиБагатовимірнуВибіркуToolStripMenuItem_Click);
			// 
			// вийтиToolStripMenuItem
			// 
			this.вийтиToolStripMenuItem.Name = "вийтиToolStripMenuItem";
			this.вийтиToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
			this.вийтиToolStripMenuItem.Text = "Вийти";
			this.вийтиToolStripMenuItem.Click += new System.EventHandler(this.вийтиToolStripMenuItem_Click);
			// 
			// вибіркиToolStripMenuItem
			// 
			this.вибіркиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вибратиВибіркуToolStripMenuItem,
            this.порівнятиВибіркиToolStripMenuItem,
            this.видалитиВибіркуToolStripMenuItem,
            this.вибратиДвомірнуВибіркуToolStripMenuItem,
            this.видалитиДвовимірнуВибіркуToolStripMenuItem,
            this.вибратиБагатовимірнуВибіркуToolStripMenuItem,
            this.видалитиБагатовимірнуВибіркуToolStripMenuItem,
            this.перевіркаГіпотезПроЗбігПараметрівБагатовимірнихВибірокToolStripMenuItem});
			this.вибіркиToolStripMenuItem.Name = "вибіркиToolStripMenuItem";
			this.вибіркиToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
			this.вибіркиToolStripMenuItem.Text = "Вибірки";
			// 
			// вибратиВибіркуToolStripMenuItem
			// 
			this.вибратиВибіркуToolStripMenuItem.Name = "вибратиВибіркуToolStripMenuItem";
			this.вибратиВибіркуToolStripMenuItem.Size = new System.Drawing.Size(419, 22);
			this.вибратиВибіркуToolStripMenuItem.Text = "Вибрати вибірку";
			this.вибратиВибіркуToolStripMenuItem.Click += new System.EventHandler(this.вибратиВибіркуToolStripMenuItem_Click);
			// 
			// порівнятиВибіркиToolStripMenuItem
			// 
			this.порівнятиВибіркиToolStripMenuItem.Name = "порівнятиВибіркиToolStripMenuItem";
			this.порівнятиВибіркиToolStripMenuItem.Size = new System.Drawing.Size(419, 22);
			this.порівнятиВибіркиToolStripMenuItem.Text = "Перевірити вибірки на однорідність";
			this.порівнятиВибіркиToolStripMenuItem.Click += new System.EventHandler(this.порівнятиВибіркиToolStripMenuItem_Click);
			// 
			// видалитиВибіркуToolStripMenuItem
			// 
			this.видалитиВибіркуToolStripMenuItem.Name = "видалитиВибіркуToolStripMenuItem";
			this.видалитиВибіркуToolStripMenuItem.Size = new System.Drawing.Size(419, 22);
			this.видалитиВибіркуToolStripMenuItem.Text = "Видалити вибірку";
			this.видалитиВибіркуToolStripMenuItem.Click += new System.EventHandler(this.видалитиВибіркуToolStripMenuItem_Click);
			// 
			// вибратиДвомірнуВибіркуToolStripMenuItem
			// 
			this.вибратиДвомірнуВибіркуToolStripMenuItem.Name = "вибратиДвомірнуВибіркуToolStripMenuItem";
			this.вибратиДвомірнуВибіркуToolStripMenuItem.Size = new System.Drawing.Size(419, 22);
			this.вибратиДвомірнуВибіркуToolStripMenuItem.Text = "Вибрати двомірну вибірку";
			this.вибратиДвомірнуВибіркуToolStripMenuItem.Click += new System.EventHandler(this.вибратиДвомірнуВибіркуToolStripMenuItem_Click);
			// 
			// видалитиДвовимірнуВибіркуToolStripMenuItem
			// 
			this.видалитиДвовимірнуВибіркуToolStripMenuItem.Name = "видалитиДвовимірнуВибіркуToolStripMenuItem";
			this.видалитиДвовимірнуВибіркуToolStripMenuItem.Size = new System.Drawing.Size(419, 22);
			this.видалитиДвовимірнуВибіркуToolStripMenuItem.Text = "Видалити двовимірну вибірку";
			this.видалитиДвовимірнуВибіркуToolStripMenuItem.Click += new System.EventHandler(this.видалитиДвовимірнуВибіркуToolStripMenuItem_Click);
			// 
			// вибратиБагатовимірнуВибіркуToolStripMenuItem
			// 
			this.вибратиБагатовимірнуВибіркуToolStripMenuItem.Name = "вибратиБагатовимірнуВибіркуToolStripMenuItem";
			this.вибратиБагатовимірнуВибіркуToolStripMenuItem.Size = new System.Drawing.Size(419, 22);
			this.вибратиБагатовимірнуВибіркуToolStripMenuItem.Text = "Вибрати багатовимірну вибірку";
			this.вибратиБагатовимірнуВибіркуToolStripMenuItem.Click += new System.EventHandler(this.вибратиБагатовимірнуВибіркуToolStripMenuItem_Click);
			// 
			// видалитиБагатовимірнуВибіркуToolStripMenuItem
			// 
			this.видалитиБагатовимірнуВибіркуToolStripMenuItem.Name = "видалитиБагатовимірнуВибіркуToolStripMenuItem";
			this.видалитиБагатовимірнуВибіркуToolStripMenuItem.Size = new System.Drawing.Size(419, 22);
			this.видалитиБагатовимірнуВибіркуToolStripMenuItem.Text = "Видалити багатовимірну вибірку";
			this.видалитиБагатовимірнуВибіркуToolStripMenuItem.Click += new System.EventHandler(this.видалитиБагатовимірнуВибіркуToolStripMenuItem_Click);
			// 
			// перевіркаГіпотезПроЗбігПараметрівБагатовимірнихВибірокToolStripMenuItem
			// 
			this.перевіркаГіпотезПроЗбігПараметрівБагатовимірнихВибірокToolStripMenuItem.Name = "перевіркаГіпотезПроЗбігПараметрівБагатовимірнихВибірокToolStripMenuItem";
			this.перевіркаГіпотезПроЗбігПараметрівБагатовимірнихВибірокToolStripMenuItem.Size = new System.Drawing.Size(419, 22);
			this.перевіркаГіпотезПроЗбігПараметрівБагатовимірнихВибірокToolStripMenuItem.Text = "Перевірка гіпотез про збіг параметрів багатовимірних вибірок";
			this.перевіркаГіпотезПроЗбігПараметрівБагатовимірнихВибірокToolStripMenuItem.Click += new System.EventHandler(this.перевіркаГіпотезПроЗбігПараметрівБагатовимірнихВибірокToolStripMenuItem_Click);
			// 
			// відмінитиToolStripMenuItem
			// 
			this.відмінитиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.крокНазадToolStripMenuItem,
            this.доПочатковихЗначеньToolStripMenuItem,
            this.крокНазаддвовимірніToolStripMenuItem,
            this.доПочатковихЗначеньДвовимірніToolStripMenuItem,
            this.крокНазадбагатовимірніToolStripMenuItem,
            this.доПочатковихЗначеньБагатовимірніToolStripMenuItem});
			this.відмінитиToolStripMenuItem.Name = "відмінитиToolStripMenuItem";
			this.відмінитиToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
			this.відмінитиToolStripMenuItem.Text = "Відмінити";
			// 
			// крокНазадToolStripMenuItem
			// 
			this.крокНазадToolStripMenuItem.Name = "крокНазадToolStripMenuItem";
			this.крокНазадToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
			this.крокНазадToolStripMenuItem.Text = "Крок назад (одновимірні)";
			this.крокНазадToolStripMenuItem.Click += new System.EventHandler(this.крокНазадToolStripMenuItem_Click);
			// 
			// доПочатковихЗначеньToolStripMenuItem
			// 
			this.доПочатковихЗначеньToolStripMenuItem.Name = "доПочатковихЗначеньToolStripMenuItem";
			this.доПочатковихЗначеньToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
			this.доПочатковихЗначеньToolStripMenuItem.Text = "До початкових значень";
			this.доПочатковихЗначеньToolStripMenuItem.Click += new System.EventHandler(this.доПочатковихЗначеньToolStripMenuItem_Click);
			// 
			// крокНазаддвовимірніToolStripMenuItem
			// 
			this.крокНазаддвовимірніToolStripMenuItem.Name = "крокНазаддвовимірніToolStripMenuItem";
			this.крокНазаддвовимірніToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
			this.крокНазаддвовимірніToolStripMenuItem.Text = "Крок назад (двовимірні)";
			this.крокНазаддвовимірніToolStripMenuItem.Click += new System.EventHandler(this.крокНазаддвовимірніToolStripMenuItem_Click);
			// 
			// доПочатковихЗначеньДвовимірніToolStripMenuItem
			// 
			this.доПочатковихЗначеньДвовимірніToolStripMenuItem.Name = "доПочатковихЗначеньДвовимірніToolStripMenuItem";
			this.доПочатковихЗначеньДвовимірніToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
			this.доПочатковихЗначеньДвовимірніToolStripMenuItem.Text = "До початкових значень (Двовимірні)";
			this.доПочатковихЗначеньДвовимірніToolStripMenuItem.Click += new System.EventHandler(this.доПочатковихЗначеньДвовимірніToolStripMenuItem_Click);
			// 
			// крокНазадбагатовимірніToolStripMenuItem
			// 
			this.крокНазадбагатовимірніToolStripMenuItem.Name = "крокНазадбагатовимірніToolStripMenuItem";
			this.крокНазадбагатовимірніToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
			this.крокНазадбагатовимірніToolStripMenuItem.Text = "Крок назад (багатовимірні)";
			this.крокНазадбагатовимірніToolStripMenuItem.Click += new System.EventHandler(this.крокНазадбагатовимірніToolStripMenuItem_Click);
			// 
			// доПочатковихЗначеньБагатовимірніToolStripMenuItem
			// 
			this.доПочатковихЗначеньБагатовимірніToolStripMenuItem.Name = "доПочатковихЗначеньБагатовимірніToolStripMenuItem";
			this.доПочатковихЗначеньБагатовимірніToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
			this.доПочатковихЗначеньБагатовимірніToolStripMenuItem.Text = "До початкових значень (Багатовимірні)";
			this.доПочатковихЗначеньБагатовимірніToolStripMenuItem.Click += new System.EventHandler(this.доПочатковихЗначеньБагатовимірніToolStripMenuItem_Click);
			// 
			// додатковоToolStripMenuItem
			// 
			this.додатковоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.включитивиключитиМаштабуванняToolStripMenuItem,
            this.включитивиключитиПобудовуВаріаційногоРядуToolStripMenuItem,
            this.включитивиключитиОбрахуавнняМедіаниСередніхToolStripMenuItem,
            this.задатиКількістьЗнаківПісляКомиДляІнтерфейсівToolStripMenuItem,
            this.оновитиToolStripMenuItem,
            this.застосуватиМГКдвовимірніToolStripMenuItem});
			this.додатковоToolStripMenuItem.Name = "додатковоToolStripMenuItem";
			this.додатковоToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.додатковоToolStripMenuItem.Text = "Додатково";
			// 
			// включитивиключитиМаштабуванняToolStripMenuItem
			// 
			this.включитивиключитиМаштабуванняToolStripMenuItem.Name = "включитивиключитиМаштабуванняToolStripMenuItem";
			this.включитивиключитиМаштабуванняToolStripMenuItem.Size = new System.Drawing.Size(366, 22);
			this.включитивиключитиМаштабуванняToolStripMenuItem.Text = "Включити\\виключити маштабування";
			this.включитивиключитиМаштабуванняToolStripMenuItem.Click += new System.EventHandler(this.включитивиключитиМаштабуванняToolStripMenuItem_Click);
			// 
			// включитивиключитиПобудовуВаріаційногоРядуToolStripMenuItem
			// 
			this.включитивиключитиПобудовуВаріаційногоРядуToolStripMenuItem.Name = "включитивиключитиПобудовуВаріаційногоРядуToolStripMenuItem";
			this.включитивиключитиПобудовуВаріаційногоРядуToolStripMenuItem.Size = new System.Drawing.Size(366, 22);
			this.включитивиключитиПобудовуВаріаційногоРядуToolStripMenuItem.Text = "Включити\\виключити побудову варіаційного ряду";
			this.включитивиключитиПобудовуВаріаційногоРядуToolStripMenuItem.Click += new System.EventHandler(this.включитивиключитиПобудовуВаріаційногоРядуToolStripMenuItem_Click);
			// 
			// включитивиключитиОбрахуавнняМедіаниСередніхToolStripMenuItem
			// 
			this.включитивиключитиОбрахуавнняМедіаниСередніхToolStripMenuItem.Name = "включитивиключитиОбрахуавнняМедіаниСередніхToolStripMenuItem";
			this.включитивиключитиОбрахуавнняМедіаниСередніхToolStripMenuItem.Size = new System.Drawing.Size(366, 22);
			this.включитивиключитиОбрахуавнняМедіаниСередніхToolStripMenuItem.Text = "Включити\\виключити обрахуавння медіани середніх";
			this.включитивиключитиОбрахуавнняМедіаниСередніхToolStripMenuItem.Click += new System.EventHandler(this.включитивиключитиОбрахуавнняМедіаниСередніхToolStripMenuItem_Click);
			// 
			// задатиКількістьЗнаківПісляКомиДляІнтерфейсівToolStripMenuItem
			// 
			this.задатиКількістьЗнаківПісляКомиДляІнтерфейсівToolStripMenuItem.Name = "задатиКількістьЗнаківПісляКомиДляІнтерфейсівToolStripMenuItem";
			this.задатиКількістьЗнаківПісляКомиДляІнтерфейсівToolStripMenuItem.Size = new System.Drawing.Size(366, 22);
			this.задатиКількістьЗнаківПісляКомиДляІнтерфейсівToolStripMenuItem.Text = "Задати кількість знаків після коми для відображення";
			this.задатиКількістьЗнаківПісляКомиДляІнтерфейсівToolStripMenuItem.Click += new System.EventHandler(this.задатиКількістьЗнаківПісляКомиДляІнтерфейсівToolStripMenuItem_Click);
			// 
			// оновитиToolStripMenuItem
			// 
			this.оновитиToolStripMenuItem.Name = "оновитиToolStripMenuItem";
			this.оновитиToolStripMenuItem.Size = new System.Drawing.Size(366, 22);
			this.оновитиToolStripMenuItem.Text = "Оновити";
			this.оновитиToolStripMenuItem.Click += new System.EventHandler(this.оновитиToolStripMenuItem_Click);
			// 
			// застосуватиМГКдвовимірніToolStripMenuItem
			// 
			this.застосуватиМГКдвовимірніToolStripMenuItem.Name = "застосуватиМГКдвовимірніToolStripMenuItem";
			this.застосуватиМГКдвовимірніToolStripMenuItem.Size = new System.Drawing.Size(366, 22);
			this.застосуватиМГКдвовимірніToolStripMenuItem.Text = "Застосувати МГК (двовимірні)";
			this.застосуватиМГКдвовимірніToolStripMenuItem.Click += new System.EventHandler(this.застосуватиМГКдвовимірніToolStripMenuItem_Click);
			// 
			// довідкаToolStripMenuItem
			// 
			this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
			this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.довідкаToolStripMenuItem.Text = "Довідка";
			this.довідкаToolStripMenuItem.Click += new System.EventHandler(this.довідкаToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar,
            this.StatusLabelForFreeSpace,
            this.StatusLabelFile,
            this.StatusLabelNameOfFile,
            this.toolStripStatusLabel2,
            this.toolStripforNumber});
			this.statusStrip1.Location = new System.Drawing.Point(0, 720);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1301, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// ProgressBar
			// 
			this.ProgressBar.BackColor = System.Drawing.SystemColors.Control;
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(100, 16);
			this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			// 
			// StatusLabelForFreeSpace
			// 
			this.StatusLabelForFreeSpace.Name = "StatusLabelForFreeSpace";
			this.StatusLabelForFreeSpace.Size = new System.Drawing.Size(94, 17);
			this.StatusLabelForFreeSpace.Text = "                             ";
			// 
			// StatusLabelFile
			// 
			this.StatusLabelFile.Name = "StatusLabelFile";
			this.StatusLabelFile.Size = new System.Drawing.Size(39, 17);
			this.StatusLabelFile.Text = "Файл:";
			// 
			// StatusLabelNameOfFile
			// 
			this.StatusLabelNameOfFile.Name = "StatusLabelNameOfFile";
			this.StatusLabelNameOfFile.Size = new System.Drawing.Size(56, 17);
			this.StatusLabelNameOfFile.Text = "відсутній";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(94, 17);
			this.toolStripStatusLabel2.Text = "                             ";
			// 
			// toolStripforNumber
			// 
			this.toolStripforNumber.Name = "toolStripforNumber";
			this.toolStripforNumber.Size = new System.Drawing.Size(0, 17);
			// 
			// tabControl2
			// 
			this.tabControl2.Controls.Add(this.PageData);
			this.tabControl2.Controls.Add(this.PafeChange);
			this.tabControl2.Controls.Add(this.tabPage7);
			this.tabControl2.Controls.Add(this.tabPage6);
			this.tabControl2.Controls.Add(this.tabPage15);
			this.tabControl2.Location = new System.Drawing.Point(12, 500);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(1277, 232);
			this.tabControl2.TabIndex = 3;
			// 
			// PageData
			// 
			this.PageData.BackColor = System.Drawing.SystemColors.ControlLight;
			this.PageData.Controls.Add(this.groupBox3);
			this.PageData.Controls.Add(this.DataGridForData);
			this.PageData.Location = new System.Drawing.Point(4, 22);
			this.PageData.Name = "PageData";
			this.PageData.Padding = new System.Windows.Forms.Padding(3);
			this.PageData.Size = new System.Drawing.Size(1269, 206);
			this.PageData.TabIndex = 0;
			this.PageData.Text = "Дані";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button10);
			this.groupBox3.Controls.Add(this.button9);
			this.groupBox3.Controls.Add(this.button8);
			this.groupBox3.Controls.Add(this.button7);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.TextBoxForPos);
			this.groupBox3.Location = new System.Drawing.Point(480, 8);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(783, 192);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Видалення аномальних данних";
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(466, 81);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(185, 35);
			this.button10.TabIndex = 5;
			this.button10.Text = "Видалення усіх відємних значень";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(60, 81);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(177, 35);
			this.button9.TabIndex = 4;
			this.button9.Text = "Видалення для експоненціального розподілу";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(466, 30);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(185, 35);
			this.button8.TabIndex = 3;
			this.button8.Text = "Універсальне видалення";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(60, 30);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(177, 35);
			this.button7.TabIndex = 2;
			this.button7.Text = "Видалення для нормального розподілу";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(66, 168);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(188, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ймовірність аномального значення";
			// 
			// TextBoxForPos
			// 
			this.TextBoxForPos.Location = new System.Drawing.Point(301, 166);
			this.TextBoxForPos.Name = "TextBoxForPos";
			this.TextBoxForPos.Size = new System.Drawing.Size(85, 20);
			this.TextBoxForPos.TabIndex = 0;
			// 
			// DataGridForData
			// 
			this.DataGridForData.AllowUserToAddRows = false;
			this.DataGridForData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridForData.Location = new System.Drawing.Point(6, 6);
			this.DataGridForData.Name = "DataGridForData";
			this.DataGridForData.Size = new System.Drawing.Size(468, 194);
			this.DataGridForData.TabIndex = 0;
			this.DataGridForData.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DataGridForData_UserDeletedRow);
			this.DataGridForData.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DataGridForData_UserDeletingRow);
			// 
			// PafeChange
			// 
			this.PafeChange.BackColor = System.Drawing.SystemColors.ControlLight;
			this.PafeChange.Controls.Add(this.groupBox7);
			this.PafeChange.Controls.Add(this.groupBox2);
			this.PafeChange.Controls.Add(this.groupBox1);
			this.PafeChange.Location = new System.Drawing.Point(4, 22);
			this.PafeChange.Name = "PafeChange";
			this.PafeChange.Padding = new System.Windows.Forms.Padding(3);
			this.PafeChange.Size = new System.Drawing.Size(1269, 206);
			this.PafeChange.TabIndex = 1;
			this.PafeChange.Text = "Перетворення і дії над даними";
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.button19);
			this.groupBox7.Location = new System.Drawing.Point(463, 6);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(310, 194);
			this.groupBox7.TabIndex = 2;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Додавання елементів";
			// 
			// button19
			// 
			this.button19.Location = new System.Drawing.Point(70, 81);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(116, 47);
			this.button19.TabIndex = 0;
			this.button19.Text = "Додати елемент";
			this.button19.UseVisualStyleBackColor = true;
			this.button19.Click += new System.EventHandler(this.button19_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.TextBoxForDelete);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.button6);
			this.groupBox2.Location = new System.Drawing.Point(779, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(484, 194);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Видалення елементів";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(298, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(19, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "до";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(74, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(21, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "від";
			// 
			// TextBoxForDelete
			// 
			this.TextBoxForDelete.Enabled = false;
			this.TextBoxForDelete.Location = new System.Drawing.Point(151, 121);
			this.TextBoxForDelete.Multiline = true;
			this.TextBoxForDelete.Name = "TextBoxForDelete";
			this.TextBoxForDelete.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TextBoxForDelete.Size = new System.Drawing.Size(219, 49);
			this.TextBoxForDelete.TabIndex = 6;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(323, 95);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(94, 20);
			this.textBox2.TabIndex = 4;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(101, 95);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(94, 20);
			this.textBox1.TabIndex = 3;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(183, 19);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(150, 47);
			this.button6.TabIndex = 2;
			this.button6.Text = "Видалити усі елементи на проміжку";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button5);
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(451, 194);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Перетворення над елементами";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(251, 81);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(116, 47);
			this.button5.TabIndex = 1;
			this.button5.Text = "Інші перетворення";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(60, 81);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(116, 47);
			this.button4.TabIndex = 0;
			this.button4.Text = "Провести стандартизацію";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// tabPage7
			// 
			this.tabPage7.BackColor = System.Drawing.SystemColors.ControlLight;
			this.tabPage7.Controls.Add(this.button18);
			this.tabPage7.Controls.Add(this.groupBox6);
			this.tabPage7.Controls.Add(this.groupBox5);
			this.tabPage7.Controls.Add(this.groupBox4);
			this.tabPage7.Controls.Add(this.checkBox1);
			this.tabPage7.Controls.Add(this.textBox3);
			this.tabPage7.Location = new System.Drawing.Point(4, 22);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Size = new System.Drawing.Size(1269, 206);
			this.tabPage7.TabIndex = 2;
			this.tabPage7.Text = "Визначення типу розподілу";
			// 
			// button18
			// 
			this.button18.Location = new System.Drawing.Point(616, 170);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(208, 29);
			this.button18.TabIndex = 5;
			this.button18.Text = "Очистити журнал відтворення";
			this.button18.UseVisualStyleBackColor = true;
			this.button18.Click += new System.EventHandler(this.button18_Click);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.button14);
			this.groupBox6.Controls.Add(this.button13);
			this.groupBox6.Location = new System.Drawing.Point(6, 139);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(604, 64);
			this.groupBox6.TabIndex = 10;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Оцінка відтворення";
			// 
			// button14
			// 
			this.button14.Location = new System.Drawing.Point(375, 18);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(129, 42);
			this.button14.TabIndex = 7;
			this.button14.Text = "t-тест для параметрів";
			this.button14.UseVisualStyleBackColor = true;
			this.button14.Click += new System.EventHandler(this.button14_Click);
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(240, 17);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(129, 43);
			this.button13.TabIndex = 6;
			this.button13.Text = "Оцінити моделювання за критерієм згоди";
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.button13_Click);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.button12);
			this.groupBox5.Controls.Add(this.button15);
			this.groupBox5.Location = new System.Drawing.Point(6, 71);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(604, 62);
			this.groupBox5.TabIndex = 9;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Відтворення розподілів";
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(240, 10);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(129, 43);
			this.button12.TabIndex = 2;
			this.button12.Text = "Змоделювати розподіл";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.button12_Click);
			// 
			// button15
			// 
			this.button15.Location = new System.Drawing.Point(375, 10);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(129, 43);
			this.button15.TabIndex = 5;
			this.button15.Text = "Припинити моделювання";
			this.button15.UseVisualStyleBackColor = true;
			this.button15.Click += new System.EventHandler(this.button15_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.button11);
			this.groupBox4.Location = new System.Drawing.Point(6, 3);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(604, 62);
			this.groupBox4.TabIndex = 8;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Ідентифікація розподілів";
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(307, 14);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(129, 34);
			this.button11.TabIndex = 1;
			this.button11.Text = "Отримати поради щодо вибірки";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.button11_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(616, 3);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(131, 17);
			this.checkBox1.TabIndex = 7;
			this.checkBox1.Text = "Дублювати у журнал";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(616, 21);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox3.Size = new System.Drawing.Size(641, 143);
			this.textBox3.TabIndex = 0;
			// 
			// tabPage6
			// 
			this.tabPage6.BackColor = System.Drawing.SystemColors.ControlLight;
			this.tabPage6.Controls.Add(this.groupBox8);
			this.tabPage6.Controls.Add(this.dataGridView3);
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new System.Drawing.Size(1269, 206);
			this.tabPage6.TabIndex = 3;
			this.tabPage6.Text = "Робота з аномаліями двовимірної вибірки";
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.label10);
			this.groupBox8.Controls.Add(this.button22);
			this.groupBox8.Controls.Add(this.textBox10);
			this.groupBox8.Location = new System.Drawing.Point(515, 3);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(751, 200);
			this.groupBox8.TabIndex = 5;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Видалити аномалії за гістограмною оцінкою";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(66, 97);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(183, 13);
			this.label10.TabIndex = 3;
			this.label10.Text = "Введіть обмеження по ймовірності";
			// 
			// button22
			// 
			this.button22.Location = new System.Drawing.Point(400, 77);
			this.button22.Name = "button22";
			this.button22.Size = new System.Drawing.Size(121, 52);
			this.button22.TabIndex = 2;
			this.button22.Text = "Видалити!";
			this.button22.UseVisualStyleBackColor = true;
			this.button22.Click += new System.EventHandler(this.button22_Click_1);
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(274, 94);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(100, 20);
			this.textBox10.TabIndex = 4;
			// 
			// dataGridView3
			// 
			this.dataGridView3.AllowUserToAddRows = false;
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
			this.dataGridView3.Location = new System.Drawing.Point(6, 3);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.Size = new System.Drawing.Size(503, 200);
			this.dataGridView3.TabIndex = 1;
			this.dataGridView3.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView3_UserDeletedRow);
			this.dataGridView3.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView3_UserDeletingRow);
			// 
			// Column8
			// 
			this.Column8.HeaderText = "X";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			// 
			// Column9
			// 
			this.Column9.HeaderText = "Y";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			// 
			// Column10
			// 
			this.Column10.HeaderText = "Xr";
			this.Column10.Name = "Column10";
			this.Column10.ReadOnly = true;
			this.Column10.Visible = false;
			this.Column10.Width = 5;
			// 
			// Column11
			// 
			this.Column11.HeaderText = "Yr";
			this.Column11.Name = "Column11";
			this.Column11.ReadOnly = true;
			this.Column11.Visible = false;
			this.Column11.Width = 5;
			// 
			// Column12
			// 
			this.Column12.HeaderText = "Num";
			this.Column12.Name = "Column12";
			this.Column12.ReadOnly = true;
			this.Column12.Visible = false;
			// 
			// tabPage15
			// 
			this.tabPage15.BackColor = System.Drawing.SystemColors.ControlLight;
			this.tabPage15.Controls.Add(this.button34);
			this.tabPage15.Controls.Add(this.button33);
			this.tabPage15.Controls.Add(this.button32);
			this.tabPage15.Controls.Add(this.label21);
			this.tabPage15.Controls.Add(this.button30);
			this.tabPage15.Controls.Add(this.textBox20);
			this.tabPage15.Controls.Add(this.dataGridView8);
			this.tabPage15.Location = new System.Drawing.Point(4, 22);
			this.tabPage15.Name = "tabPage15";
			this.tabPage15.Size = new System.Drawing.Size(1269, 206);
			this.tabPage15.TabIndex = 4;
			this.tabPage15.Text = "Робота з багатовимірними аномаліями";
			// 
			// button34
			// 
			this.button34.Location = new System.Drawing.Point(1061, 110);
			this.button34.Name = "button34";
			this.button34.Size = new System.Drawing.Size(142, 52);
			this.button34.TabIndex = 10;
			this.button34.Text = "Вивести варіаційний ряд";
			this.button34.UseVisualStyleBackColor = true;
			this.button34.Click += new System.EventHandler(this.button34_Click);
			// 
			// button33
			// 
			this.button33.Location = new System.Drawing.Point(1061, 52);
			this.button33.Name = "button33";
			this.button33.Size = new System.Drawing.Size(142, 52);
			this.button33.TabIndex = 9;
			this.button33.Text = "Стандартизувати усе";
			this.button33.UseVisualStyleBackColor = true;
			this.button33.Click += new System.EventHandler(this.button33_Click);
			// 
			// button32
			// 
			this.button32.Location = new System.Drawing.Point(825, 52);
			this.button32.Name = "button32";
			this.button32.Size = new System.Drawing.Size(121, 52);
			this.button32.TabIndex = 8;
			this.button32.Text = "Перевірити на нормалність";
			this.button32.UseVisualStyleBackColor = true;
			this.button32.Click += new System.EventHandler(this.button32_Click);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(488, 99);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(183, 13);
			this.label21.TabIndex = 6;
			this.label21.Text = "Введіть обмеження по ймовірності";
			// 
			// button30
			// 
			this.button30.Location = new System.Drawing.Point(825, 110);
			this.button30.Name = "button30";
			this.button30.Size = new System.Drawing.Size(121, 52);
			this.button30.TabIndex = 5;
			this.button30.Text = "Видалити!";
			this.button30.UseVisualStyleBackColor = true;
			this.button30.Click += new System.EventHandler(this.button30_Click);
			// 
			// textBox20
			// 
			this.textBox20.Location = new System.Drawing.Point(696, 96);
			this.textBox20.Name = "textBox20";
			this.textBox20.Size = new System.Drawing.Size(100, 20);
			this.textBox20.TabIndex = 7;
			// 
			// dataGridView8
			// 
			this.dataGridView8.AllowUserToAddRows = false;
			this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView8.Location = new System.Drawing.Point(9, 3);
			this.dataGridView8.Name = "dataGridView8";
			this.dataGridView8.Size = new System.Drawing.Size(423, 200);
			this.dataGridView8.TabIndex = 0;
			this.dataGridView8.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView8_UserDeletedRow);
			this.dataGridView8.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView8_UserDeletingRow);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.button16);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.LogCheckBox);
			this.panel1.Controls.Add(this.LogOutputLabel);
			this.panel1.Controls.Add(this.LogOutputTextBox);
			this.panel1.Location = new System.Drawing.Point(975, 27);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(314, 467);
			this.panel1.TabIndex = 4;
			// 
			// button16
			// 
			this.button16.Location = new System.Drawing.Point(177, 421);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(130, 39);
			this.button16.TabIndex = 4;
			this.button16.Text = "Експорт журналу у файл";
			this.button16.UseVisualStyleBackColor = true;
			this.button16.Click += new System.EventHandler(this.button16_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 421);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(134, 39);
			this.button1.TabIndex = 3;
			this.button1.Text = "Очистити журнал";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// LogCheckBox
			// 
			this.LogCheckBox.AutoSize = true;
			this.LogCheckBox.Location = new System.Drawing.Point(3, 20);
			this.LogCheckBox.Name = "LogCheckBox";
			this.LogCheckBox.Size = new System.Drawing.Size(60, 17);
			this.LogCheckBox.TabIndex = 2;
			this.LogCheckBox.Text = "Деталі";
			this.LogCheckBox.UseVisualStyleBackColor = true;
			// 
			// LogOutputLabel
			// 
			this.LogOutputLabel.AutoSize = true;
			this.LogOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LogOutputLabel.Location = new System.Drawing.Point(123, 0);
			this.LogOutputLabel.Name = "LogOutputLabel";
			this.LogOutputLabel.Size = new System.Drawing.Size(78, 15);
			this.LogOutputLabel.TabIndex = 1;
			this.LogOutputLabel.Text = "Журнал подій";
			// 
			// LogOutputTextBox
			// 
			this.LogOutputTextBox.Location = new System.Drawing.Point(3, 43);
			this.LogOutputTextBox.Multiline = true;
			this.LogOutputTextBox.Name = "LogOutputTextBox";
			this.LogOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.LogOutputTextBox.Size = new System.Drawing.Size(302, 372);
			this.LogOutputTextBox.TabIndex = 0;
			// 
			// PageEval
			// 
			this.PageEval.BackColor = System.Drawing.SystemColors.ControlLight;
			this.PageEval.Controls.Add(this.button17);
			this.PageEval.Controls.Add(this.DataGridForEval);
			this.PageEval.Location = new System.Drawing.Point(4, 22);
			this.PageEval.Name = "PageEval";
			this.PageEval.Size = new System.Drawing.Size(949, 441);
			this.PageEval.TabIndex = 2;
			this.PageEval.Text = "Оцінки статистик";
			// 
			// button17
			// 
			this.button17.Location = new System.Drawing.Point(756, 401);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(190, 29);
			this.button17.TabIndex = 3;
			this.button17.Text = "Записати точкові оцінки у журнал";
			this.button17.UseVisualStyleBackColor = true;
			this.button17.Click += new System.EventHandler(this.button17_Click);
			// 
			// DataGridForEval
			// 
			this.DataGridForEval.AllowUserToAddRows = false;
			this.DataGridForEval.AllowUserToDeleteRows = false;
			this.DataGridForEval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridForEval.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnOfNames,
            this.ColumnLeftBor,
            this.ColumnOfValues,
            this.ColumnRightBor,
            this.ColumnPosib});
			this.DataGridForEval.Location = new System.Drawing.Point(3, 3);
			this.DataGridForEval.Name = "DataGridForEval";
			this.DataGridForEval.Size = new System.Drawing.Size(943, 392);
			this.DataGridForEval.TabIndex = 0;
			this.DataGridForEval.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridForEval_CellEndEdit);
			// 
			// ColumnOfNames
			// 
			this.ColumnOfNames.HeaderText = "Назва статистики";
			this.ColumnOfNames.Name = "ColumnOfNames";
			this.ColumnOfNames.ReadOnly = true;
			this.ColumnOfNames.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ColumnOfNames.Width = 125;
			// 
			// ColumnLeftBor
			// 
			this.ColumnLeftBor.HeaderText = "Нижня межа";
			this.ColumnLeftBor.Name = "ColumnLeftBor";
			this.ColumnLeftBor.ReadOnly = true;
			this.ColumnLeftBor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ColumnLeftBor.Width = 115;
			// 
			// ColumnOfValues
			// 
			this.ColumnOfValues.HeaderText = "Точкова оцінка";
			this.ColumnOfValues.Name = "ColumnOfValues";
			this.ColumnOfValues.ReadOnly = true;
			this.ColumnOfValues.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ColumnOfValues.Width = 115;
			// 
			// ColumnRightBor
			// 
			this.ColumnRightBor.HeaderText = "Верхня межа";
			this.ColumnRightBor.Name = "ColumnRightBor";
			this.ColumnRightBor.ReadOnly = true;
			this.ColumnRightBor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ColumnRightBor.Width = 115;
			// 
			// ColumnPosib
			// 
			this.ColumnPosib.HeaderText = "Ймовірність/Параметр";
			this.ColumnPosib.Name = "ColumnPosib";
			this.ColumnPosib.ReadOnly = true;
			this.ColumnPosib.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ColumnPosib.Width = 130;
			// 
			// PageFunc
			// 
			this.PageFunc.BackColor = System.Drawing.SystemColors.ControlLight;
			this.PageFunc.Controls.Add(this.button3);
			this.PageFunc.Controls.Add(this.DistrFun);
			this.PageFunc.Location = new System.Drawing.Point(4, 22);
			this.PageFunc.Name = "PageFunc";
			this.PageFunc.Padding = new System.Windows.Forms.Padding(3);
			this.PageFunc.Size = new System.Drawing.Size(949, 441);
			this.PageFunc.TabIndex = 1;
			this.PageFunc.Text = "Функція розподілу";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(829, 401);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(114, 34);
			this.button3.TabIndex = 2;
			this.button3.Text = "Деталі";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// DistrFun
			// 
			chartArea1.Name = "ChartArea1";
			this.DistrFun.ChartAreas.Add(chartArea1);
			this.DistrFun.Location = new System.Drawing.Point(6, 6);
			this.DistrFun.Name = "DistrFun";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series1.Color = System.Drawing.Color.Black;
			series1.CustomProperties = "LabelStyle=Top";
			series1.Name = "EmpFuncWithClasses";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series2.Color = System.Drawing.Color.Red;
			series2.Name = "EmpFuncWithoutClasses";
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			series3.Name = "TopLimit";
			series4.ChartArea = "ChartArea1";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			series4.Name = "BotLimit";
			series5.ChartArea = "ChartArea1";
			series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series5.Name = "TheorDistrFun";
			this.DistrFun.Series.Add(series1);
			this.DistrFun.Series.Add(series2);
			this.DistrFun.Series.Add(series3);
			this.DistrFun.Series.Add(series4);
			this.DistrFun.Series.Add(series5);
			this.DistrFun.Size = new System.Drawing.Size(937, 389);
			this.DistrFun.TabIndex = 0;
			this.DistrFun.Text = "chart2";
			// 
			// PageHist
			// 
			this.PageHist.BackColor = System.Drawing.SystemColors.ControlLight;
			this.PageHist.Controls.Add(this.button2);
			this.PageHist.Controls.Add(this.Histogramme);
			this.PageHist.Location = new System.Drawing.Point(4, 22);
			this.PageHist.Name = "PageHist";
			this.PageHist.Padding = new System.Windows.Forms.Padding(3);
			this.PageHist.Size = new System.Drawing.Size(949, 441);
			this.PageHist.TabIndex = 0;
			this.PageHist.Text = "Гістограмма";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(829, 401);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(114, 33);
			this.button2.TabIndex = 1;
			this.button2.Text = "Деталі";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Histogramme
			// 
			chartArea2.AxisX.ScrollBar.Size = 10D;
			chartArea2.Name = "ChartArea1";
			this.Histogramme.ChartAreas.Add(chartArea2);
			this.Histogramme.Location = new System.Drawing.Point(9, -5);
			this.Histogramme.Name = "Histogramme";
			this.Histogramme.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
			series6.ChartArea = "ChartArea1";
			series6.Color = System.Drawing.Color.Black;
			series6.CustomProperties = "PointWidth=1";
			series6.Name = "HistogrammeIns";
			series7.ChartArea = "ChartArea1";
			series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series7.Color = System.Drawing.Color.Red;
			series7.MarkerSize = 3;
			series7.Name = "DensFunc";
			this.Histogramme.Series.Add(series6);
			this.Histogramme.Series.Add(series7);
			this.Histogramme.Size = new System.Drawing.Size(937, 400);
			this.Histogramme.TabIndex = 0;
			this.Histogramme.Text = "chart1";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.PageHist);
			this.tabControl1.Controls.Add(this.PageFunc);
			this.tabControl1.Controls.Add(this.PageEval);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage11);
			this.tabControl1.Controls.Add(this.tabPage12);
			this.tabControl1.Controls.Add(this.tabPage13);
			this.tabControl1.Controls.Add(this.tabPage14);
			this.tabControl1.Controls.Add(this.tabPage20);
			this.tabControl1.Controls.Add(this.tabPage21);
			this.tabControl1.Controls.Add(this.tabPage22);
			this.tabControl1.Controls.Add(this.tabPage23);
			this.tabControl1.Location = new System.Drawing.Point(12, 27);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(957, 467);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.radioButton13);
			this.tabPage1.Controls.Add(this.radioButton12);
			this.tabPage1.Controls.Add(this.textBox12);
			this.tabPage1.Controls.Add(this.label12);
			this.tabPage1.Controls.Add(this.textBox11);
			this.tabPage1.Controls.Add(this.label11);
			this.tabPage1.Controls.Add(this.tabControl3);
			this.tabPage1.Controls.Add(this.button24);
			this.tabPage1.Controls.Add(this.chart1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(949, 441);
			this.tabPage1.TabIndex = 3;
			this.tabPage1.Text = "Кореляційне поле";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// textBox12
			// 
			this.textBox12.Location = new System.Drawing.Point(889, 70);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(53, 20);
			this.textBox12.TabIndex = 7;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(827, 73);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 13);
			this.label12.TabIndex = 6;
			this.label12.Text = "розбиття:";
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(753, 70);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(56, 20);
			this.textBox11.TabIndex = 5;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(698, 73);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(49, 13);
			this.label11.TabIndex = 4;
			this.label11.Text = "α-рівень";
			// 
			// tabControl3
			// 
			this.tabControl3.Controls.Add(this.tabPage8);
			this.tabControl3.Controls.Add(this.tabPage9);
			this.tabControl3.Controls.Add(this.tabPage10);
			this.tabControl3.Location = new System.Drawing.Point(691, 96);
			this.tabControl3.Name = "tabControl3";
			this.tabControl3.SelectedIndex = 0;
			this.tabControl3.Size = new System.Drawing.Size(255, 342);
			this.tabControl3.TabIndex = 2;
			// 
			// tabPage8
			// 
			this.tabPage8.Controls.Add(this.button29);
			this.tabPage8.Controls.Add(this.button28);
			this.tabPage8.Controls.Add(this.textBox14);
			this.tabPage8.Controls.Add(this.textBox13);
			this.tabPage8.Controls.Add(this.radioButton1);
			this.tabPage8.Controls.Add(this.button25);
			this.tabPage8.Controls.Add(this.radioButton2);
			this.tabPage8.Controls.Add(this.label14);
			this.tabPage8.Controls.Add(this.label13);
			this.tabPage8.Location = new System.Drawing.Point(4, 22);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage8.Size = new System.Drawing.Size(247, 316);
			this.tabPage8.TabIndex = 0;
			this.tabPage8.Text = "Лінійна регресія";
			this.tabPage8.UseVisualStyleBackColor = true;
			// 
			// button29
			// 
			this.button29.Location = new System.Drawing.Point(6, 268);
			this.button29.Name = "button29";
			this.button29.Size = new System.Drawing.Size(235, 42);
			this.button29.TabIndex = 13;
			this.button29.Text = "Перевірити збіг поточної регресії з заданою користувачем";
			this.button29.UseVisualStyleBackColor = true;
			this.button29.Click += new System.EventHandler(this.button29_Click);
			// 
			// button28
			// 
			this.button28.Location = new System.Drawing.Point(6, 220);
			this.button28.Name = "button28";
			this.button28.Size = new System.Drawing.Size(235, 42);
			this.button28.TabIndex = 12;
			this.button28.Text = "Перевірити збіг регресій двох вибірок";
			this.button28.UseVisualStyleBackColor = true;
			this.button28.Click += new System.EventHandler(this.button28_Click);
			// 
			// textBox14
			// 
			this.textBox14.Location = new System.Drawing.Point(164, 133);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(56, 20);
			this.textBox14.TabIndex = 11;
			// 
			// textBox13
			// 
			this.textBox13.Location = new System.Drawing.Point(164, 107);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(56, 20);
			this.textBox13.TabIndex = 9;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(6, 10);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(49, 17);
			this.radioButton1.TabIndex = 1;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "МНК";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// button25
			// 
			this.button25.Location = new System.Drawing.Point(6, 56);
			this.button25.Name = "button25";
			this.button25.Size = new System.Drawing.Size(235, 45);
			this.button25.TabIndex = 3;
			this.button25.Text = "Побудувати регресію";
			this.button25.UseVisualStyleBackColor = true;
			this.button25.Click += new System.EventHandler(this.button25_Click);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(6, 33);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(91, 17);
			this.radioButton2.TabIndex = 2;
			this.radioButton2.Text = "Метод Тейла";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(9, 136);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(144, 13);
			this.label14.TabIndex = 10;
			this.label14.Text = "Значення b для порівняння";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(9, 110);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(144, 13);
			this.label13.TabIndex = 8;
			this.label13.Text = "Значення а для порівняння";
			// 
			// tabPage9
			// 
			this.tabPage9.Controls.Add(this.radioButton5);
			this.tabPage9.Controls.Add(this.radioButton6);
			this.tabPage9.Controls.Add(this.textBox19);
			this.tabPage9.Controls.Add(this.label20);
			this.tabPage9.Controls.Add(this.textBox17);
			this.tabPage9.Controls.Add(this.textBox18);
			this.tabPage9.Controls.Add(this.button27);
			this.tabPage9.Controls.Add(this.label18);
			this.tabPage9.Controls.Add(this.label19);
			this.tabPage9.Location = new System.Drawing.Point(4, 22);
			this.tabPage9.Name = "tabPage9";
			this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage9.Size = new System.Drawing.Size(247, 316);
			this.tabPage9.TabIndex = 1;
			this.tabPage9.Text = "Параболічна регресія";
			this.tabPage9.UseVisualStyleBackColor = true;
			// 
			// radioButton5
			// 
			this.radioButton5.AutoSize = true;
			this.radioButton5.Checked = true;
			this.radioButton5.Location = new System.Drawing.Point(6, 6);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(100, 17);
			this.radioButton5.TabIndex = 19;
			this.radioButton5.TabStop = true;
			this.radioButton5.Text = "Перший спосіб";
			this.radioButton5.UseVisualStyleBackColor = true;
			// 
			// radioButton6
			// 
			this.radioButton6.AutoSize = true;
			this.radioButton6.Location = new System.Drawing.Point(6, 29);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new System.Drawing.Size(97, 17);
			this.radioButton6.TabIndex = 20;
			this.radioButton6.Text = "Другий спосіб";
			this.radioButton6.UseVisualStyleBackColor = true;
			// 
			// textBox19
			// 
			this.textBox19.Location = new System.Drawing.Point(164, 155);
			this.textBox19.Name = "textBox19";
			this.textBox19.Size = new System.Drawing.Size(56, 20);
			this.textBox19.TabIndex = 18;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(9, 158);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(144, 13);
			this.label20.TabIndex = 17;
			this.label20.Text = "Значення c для порівняння";
			// 
			// textBox17
			// 
			this.textBox17.Location = new System.Drawing.Point(164, 103);
			this.textBox17.Name = "textBox17";
			this.textBox17.Size = new System.Drawing.Size(56, 20);
			this.textBox17.TabIndex = 16;
			// 
			// textBox18
			// 
			this.textBox18.Location = new System.Drawing.Point(164, 129);
			this.textBox18.Name = "textBox18";
			this.textBox18.Size = new System.Drawing.Size(56, 20);
			this.textBox18.TabIndex = 14;
			// 
			// button27
			// 
			this.button27.Location = new System.Drawing.Point(6, 52);
			this.button27.Name = "button27";
			this.button27.Size = new System.Drawing.Size(235, 45);
			this.button27.TabIndex = 12;
			this.button27.Text = "Побудувати регресію";
			this.button27.UseVisualStyleBackColor = true;
			this.button27.Click += new System.EventHandler(this.button27_Click);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(9, 132);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(144, 13);
			this.label18.TabIndex = 15;
			this.label18.Text = "Значення b для порівняння";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(9, 106);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(144, 13);
			this.label19.TabIndex = 13;
			this.label19.Text = "Значення а для порівняння";
			// 
			// tabPage10
			// 
			this.tabPage10.AutoScroll = true;
			this.tabPage10.Controls.Add(this.checkBox2);
			this.tabPage10.Controls.Add(this.label17);
			this.tabPage10.Controls.Add(this.textBox15);
			this.tabPage10.Controls.Add(this.textBox16);
			this.tabPage10.Controls.Add(this.label15);
			this.tabPage10.Controls.Add(this.label16);
			this.tabPage10.Controls.Add(this.radioButton3);
			this.tabPage10.Controls.Add(this.button26);
			this.tabPage10.Controls.Add(this.radioButton4);
			this.tabPage10.Location = new System.Drawing.Point(4, 22);
			this.tabPage10.Name = "tabPage10";
			this.tabPage10.Size = new System.Drawing.Size(247, 316);
			this.tabPage10.TabIndex = 2;
			this.tabPage10.Text = "Квазилінійна регресія";
			this.tabPage10.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(7, 130);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(187, 17);
			this.checkBox2.TabIndex = 20;
			this.checkBox2.Text = "Використовувати вагові функції";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(4, 104);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(259, 13);
			this.label17.TabIndex = 19;
			this.label17.Text = "Увага! Буде відтворено залежність виду y=a*(x^b)";
			// 
			// textBox15
			// 
			this.textBox15.Location = new System.Drawing.Point(154, 156);
			this.textBox15.Name = "textBox15";
			this.textBox15.Size = new System.Drawing.Size(56, 20);
			this.textBox15.TabIndex = 18;
			// 
			// textBox16
			// 
			this.textBox16.Location = new System.Drawing.Point(154, 182);
			this.textBox16.Name = "textBox16";
			this.textBox16.Size = new System.Drawing.Size(56, 20);
			this.textBox16.TabIndex = 16;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(4, 185);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(144, 13);
			this.label15.TabIndex = 17;
			this.label15.Text = "Значення b для порівняння";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(4, 159);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(144, 13);
			this.label16.TabIndex = 15;
			this.label16.Text = "Значення а для порівняння";
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Checked = true;
			this.radioButton3.Location = new System.Drawing.Point(3, 6);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(49, 17);
			this.radioButton3.TabIndex = 12;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "МНК";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// button26
			// 
			this.button26.Location = new System.Drawing.Point(3, 52);
			this.button26.Name = "button26";
			this.button26.Size = new System.Drawing.Size(241, 45);
			this.button26.TabIndex = 14;
			this.button26.Text = "Побудувати регресію";
			this.button26.UseVisualStyleBackColor = true;
			this.button26.Click += new System.EventHandler(this.button26_Click);
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Location = new System.Drawing.Point(3, 29);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(91, 17);
			this.radioButton4.TabIndex = 13;
			this.radioButton4.Text = "Метод Тейла";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// button24
			// 
			this.button24.Location = new System.Drawing.Point(691, 8);
			this.button24.Name = "button24";
			this.button24.Size = new System.Drawing.Size(251, 56);
			this.button24.TabIndex = 0;
			this.button24.Text = "Перевірити початкові умови регресійного аналізу";
			this.button24.UseVisualStyleBackColor = true;
			this.button24.Click += new System.EventHandler(this.button24_Click);
			// 
			// chart1
			// 
			chartArea3.InnerPlotPosition.Auto = false;
			chartArea3.InnerPlotPosition.Height = 87.98504F;
			chartArea3.InnerPlotPosition.Width = 87.98504F;
			chartArea3.InnerPlotPosition.X = 10.50909F;
			chartArea3.InnerPlotPosition.Y = 2.23404F;
			chartArea3.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea3);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(3, 23);
			this.chart1.Name = "chart1";
			series8.ChartArea = "ChartArea1";
			series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series8.Legend = "Legend1";
			series8.MarkerSize = 4;
			series8.Name = "Елемент вибірки";
			series9.ChartArea = "ChartArea1";
			series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series9.Color = System.Drawing.Color.Red;
			series9.Legend = "Legend1";
			series9.MarkerSize = 4;
			series9.Name = "Мат сподівання";
			series10.ChartArea = "ChartArea1";
			series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series10.Color = System.Drawing.Color.Black;
			series10.Legend = "Legend1";
			series10.Name = "Лінія регресії";
			series11.ChartArea = "ChartArea1";
			series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series11.Color = System.Drawing.Color.Lime;
			series11.Legend = "Legend1";
			series11.MarkerSize = 3;
			series11.Name = "Верхня толерантна межа";
			series12.ChartArea = "ChartArea1";
			series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series12.Color = System.Drawing.Color.Green;
			series12.Legend = "Legend1";
			series12.MarkerSize = 3;
			series12.Name = "Нижня толерантна межа";
			series13.ChartArea = "ChartArea1";
			series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series13.Color = System.Drawing.Color.Maroon;
			series13.Legend = "Legend1";
			series13.MarkerSize = 3;
			series13.Name = "НДІ для прогнозу";
			series14.ChartArea = "ChartArea1";
			series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series14.Color = System.Drawing.Color.Red;
			series14.Legend = "Legend1";
			series14.MarkerSize = 3;
			series14.Name = "ВДІ для прогнозу";
			series15.ChartArea = "ChartArea1";
			series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series15.Color = System.Drawing.Color.Blue;
			series15.Legend = "Legend1";
			series15.MarkerSize = 3;
			series15.Name = "НДІ регресії";
			series16.ChartArea = "ChartArea1";
			series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series16.Color = System.Drawing.Color.Navy;
			series16.Legend = "Legend1";
			series16.MarkerSize = 3;
			series16.Name = "ВДІ регресії";
			this.chart1.Series.Add(series8);
			this.chart1.Series.Add(series9);
			this.chart1.Series.Add(series10);
			this.chart1.Series.Add(series11);
			this.chart1.Series.Add(series12);
			this.chart1.Series.Add(series13);
			this.chart1.Series.Add(series14);
			this.chart1.Series.Add(series15);
			this.chart1.Series.Add(series16);
			this.chart1.Size = new System.Drawing.Size(682, 405);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.checkBox11);
			this.tabPage2.Controls.Add(this.checkBox10);
			this.tabPage2.Controls.Add(this.chart2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(949, 441);
			this.tabPage2.TabIndex = 4;
			this.tabPage2.Text = "Гістограма двовимірної вибірки";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// checkBox11
			// 
			this.checkBox11.AutoSize = true;
			this.checkBox11.Location = new System.Drawing.Point(146, 4);
			this.checkBox11.Name = "checkBox11";
			this.checkBox11.Size = new System.Drawing.Size(206, 17);
			this.checkBox11.TabIndex = 2;
			this.checkBox11.Text = "Формувати гліф за допомогою мгк";
			this.checkBox11.UseVisualStyleBackColor = true;
			// 
			// checkBox10
			// 
			this.checkBox10.AutoSize = true;
			this.checkBox10.Location = new System.Drawing.Point(6, 4);
			this.checkBox10.Name = "checkBox10";
			this.checkBox10.Size = new System.Drawing.Size(134, 17);
			this.checkBox10.TabIndex = 1;
			this.checkBox10.Text = "Показувати кор поле";
			this.checkBox10.UseVisualStyleBackColor = true;
			// 
			// chart2
			// 
			chartArea4.AxisX.MajorGrid.Enabled = false;
			chartArea4.AxisY.MajorGrid.Enabled = false;
			chartArea4.InnerPlotPosition.Auto = false;
			chartArea4.InnerPlotPosition.Height = 85F;
			chartArea4.InnerPlotPosition.Width = 85F;
			chartArea4.InnerPlotPosition.X = 12F;
			chartArea4.InnerPlotPosition.Y = 3F;
			chartArea4.Name = "ChartArea1";
			chartArea4.Position.Auto = false;
			chartArea4.Position.Height = 94F;
			chartArea4.Position.Width = 72.0559F;
			chartArea4.Position.X = 3F;
			chartArea4.Position.Y = 3F;
			this.chart2.ChartAreas.Add(chartArea4);
			legend2.Name = "Legend1";
			this.chart2.Legends.Add(legend2);
			this.chart2.Location = new System.Drawing.Point(6, 27);
			this.chart2.Name = "chart2";
			series17.ChartArea = "ChartArea1";
			series17.Color = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			series17.Legend = "Legend1";
			series17.MarkerSize = 1;
			series17.Name = "p(x) = 0,9...1";
			series18.ChartArea = "ChartArea1";
			series18.Color = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
			series18.Legend = "Legend1";
			series18.Name = "p(x) = 0,8...0,9";
			series19.ChartArea = "ChartArea1";
			series19.Color = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
			series19.Legend = "Legend1";
			series19.Name = "p(x) = 0,7...0,8";
			series20.ChartArea = "ChartArea1";
			series20.Color = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
			series20.Legend = "Legend1";
			series20.Name = "p(x) = 0,6...0,7";
			series21.ChartArea = "ChartArea1";
			series21.Color = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			series21.Legend = "Legend1";
			series21.Name = "p(x) = 0,5...0,6";
			series22.ChartArea = "ChartArea1";
			series22.Color = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
			series22.Legend = "Legend1";
			series22.Name = "p(x) = 0,4...0,5";
			series23.ChartArea = "ChartArea1";
			series23.Color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			series23.Legend = "Legend1";
			series23.Name = "p(x) = 0,3...0,4";
			series24.ChartArea = "ChartArea1";
			series24.Color = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			series24.Legend = "Legend1";
			series24.Name = "p(x) = 0,2...0,3";
			series25.ChartArea = "ChartArea1";
			series25.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			series25.Legend = "Legend1";
			series25.Name = "p(x) = 0,1...0,2";
			series26.ChartArea = "ChartArea1";
			series26.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			series26.Legend = "Legend1";
			series26.Name = "p(x) = 0...0,1";
			series27.ChartArea = "ChartArea1";
			series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series27.Color = System.Drawing.Color.White;
			series27.Legend = "Legend1";
			series27.MarkerSize = 3;
			series27.Name = "   ";
			this.chart2.Series.Add(series17);
			this.chart2.Series.Add(series18);
			this.chart2.Series.Add(series19);
			this.chart2.Series.Add(series20);
			this.chart2.Series.Add(series21);
			this.chart2.Series.Add(series22);
			this.chart2.Series.Add(series23);
			this.chart2.Series.Add(series24);
			this.chart2.Series.Add(series25);
			this.chart2.Series.Add(series26);
			this.chart2.Series.Add(series27);
			this.chart2.Size = new System.Drawing.Size(940, 411);
			this.chart2.TabIndex = 0;
			this.chart2.Text = "chart2";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.textBox4);
			this.tabPage3.Controls.Add(this.label2);
			this.tabPage3.Controls.Add(this.button20);
			this.tabPage3.Controls.Add(this.dataGridView1);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(949, 441);
			this.tabPage3.TabIndex = 5;
			this.tabPage3.Text = "Статистики двовимірної вибірки";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(604, 401);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(548, 404);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "для  α = ";
			// 
			// button20
			// 
			this.button20.Location = new System.Drawing.Point(332, 391);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(209, 40);
			this.button20.TabIndex = 6;
			this.button20.Text = "Перевірити гіпотези про значущість коефіціентів";
			this.button20.UseVisualStyleBackColor = true;
			this.button20.Click += new System.EventHandler(this.button20_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column1});
			this.dataGridView1.Location = new System.Drawing.Point(3, 6);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(943, 379);
			this.dataGridView1.TabIndex = 5;
			this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Назва статистики";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn1.Width = 110;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Нижня межа";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Точкова оцінка";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Верхня межа";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "Ймовірність/Параметр";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn5.Width = 120;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Додатково";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 70;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.button21);
			this.tabPage4.Controls.Add(this.dataGridView2);
			this.tabPage4.Controls.Add(this.textBox6);
			this.tabPage4.Controls.Add(this.textBox5);
			this.tabPage4.Controls.Add(this.label6);
			this.tabPage4.Controls.Add(this.label5);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(949, 441);
			this.tabPage4.TabIndex = 6;
			this.tabPage4.Text = "Таблиці сполучень 2 на 2";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// button21
			// 
			this.button21.Location = new System.Drawing.Point(9, 65);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(203, 42);
			this.button21.TabIndex = 5;
			this.button21.Text = "Обрахувати коефіціенти для таблиці 2 на 2";
			this.button21.UseVisualStyleBackColor = true;
			this.button21.Click += new System.EventHandler(this.button21_Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dataGridView2.Location = new System.Drawing.Point(218, 6);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(728, 432);
			this.dataGridView2.TabIndex = 4;
			this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Назва статистики";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Точкова оцінка";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Значущість";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "γ";
			this.Column5.Name = "Column5";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(112, 34);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 20);
			this.textBox6.TabIndex = 3;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(112, 6);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 20);
			this.textBox5.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 34);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Точка розділу по у";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Точка розділу по х";
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.textBox9);
			this.tabPage5.Controls.Add(this.label9);
			this.tabPage5.Controls.Add(this.button23);
			this.tabPage5.Controls.Add(this.dataGridView4);
			this.tabPage5.Controls.Add(this.textBox7);
			this.tabPage5.Controls.Add(this.textBox8);
			this.tabPage5.Controls.Add(this.label7);
			this.tabPage5.Controls.Add(this.label8);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(949, 441);
			this.tabPage5.TabIndex = 7;
			this.tabPage5.Text = "Таблиці сполучень n на m";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(120, 63);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(100, 20);
			this.textBox9.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 66);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(55, 13);
			this.label9.TabIndex = 12;
			this.label9.Text = "Введіть α";
			// 
			// button23
			// 
			this.button23.Location = new System.Drawing.Point(6, 91);
			this.button23.Name = "button23";
			this.button23.Size = new System.Drawing.Size(267, 34);
			this.button23.TabIndex = 11;
			this.button23.Text = "Обрахувати статистики";
			this.button23.UseVisualStyleBackColor = true;
			this.button23.Click += new System.EventHandler(this.button23_Click);
			// 
			// dataGridView4
			// 
			this.dataGridView4.AllowUserToAddRows = false;
			this.dataGridView4.AllowUserToDeleteRows = false;
			this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7});
			this.dataGridView4.Location = new System.Drawing.Point(279, 8);
			this.dataGridView4.Name = "dataGridView4";
			this.dataGridView4.Size = new System.Drawing.Size(667, 430);
			this.dataGridView4.TabIndex = 10;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Назва статистики";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 200;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Значення";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Width = 150;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(120, 8);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(100, 20);
			this.textBox7.TabIndex = 7;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(120, 37);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(100, 20);
			this.textBox8.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 37);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "Введіть m";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(54, 13);
			this.label8.TabIndex = 4;
			this.label8.Text = "Введіть n";
			// 
			// tabPage11
			// 
			this.tabPage11.Controls.Add(this.dataGridView5);
			this.tabPage11.Location = new System.Drawing.Point(4, 22);
			this.tabPage11.Name = "tabPage11";
			this.tabPage11.Size = new System.Drawing.Size(949, 441);
			this.tabPage11.TabIndex = 8;
			this.tabPage11.Text = "Дисперсійно-коваріаційна матриця";
			this.tabPage11.UseVisualStyleBackColor = true;
			// 
			// dataGridView5
			// 
			this.dataGridView5.AllowUserToAddRows = false;
			this.dataGridView5.AllowUserToDeleteRows = false;
			this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView5.Location = new System.Drawing.Point(6, 3);
			this.dataGridView5.Name = "dataGridView5";
			this.dataGridView5.ReadOnly = true;
			this.dataGridView5.Size = new System.Drawing.Size(940, 435);
			this.dataGridView5.TabIndex = 0;
			// 
			// tabPage12
			// 
			this.tabPage12.Controls.Add(this.dataGridView6);
			this.tabPage12.Location = new System.Drawing.Point(4, 22);
			this.tabPage12.Name = "tabPage12";
			this.tabPage12.Size = new System.Drawing.Size(949, 441);
			this.tabPage12.TabIndex = 9;
			this.tabPage12.Text = "Кореляційна матриця";
			this.tabPage12.UseVisualStyleBackColor = true;
			// 
			// dataGridView6
			// 
			this.dataGridView6.AllowUserToAddRows = false;
			this.dataGridView6.AllowUserToDeleteRows = false;
			this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView6.Location = new System.Drawing.Point(6, 3);
			this.dataGridView6.Name = "dataGridView6";
			this.dataGridView6.ReadOnly = true;
			this.dataGridView6.Size = new System.Drawing.Size(940, 435);
			this.dataGridView6.TabIndex = 0;
			// 
			// tabPage13
			// 
			this.tabPage13.Controls.Add(this.dataGridView7);
			this.tabPage13.Location = new System.Drawing.Point(4, 22);
			this.tabPage13.Name = "tabPage13";
			this.tabPage13.Size = new System.Drawing.Size(949, 441);
			this.tabPage13.TabIndex = 10;
			this.tabPage13.Text = "Статистики багатовимірної вибірки";
			this.tabPage13.UseVisualStyleBackColor = true;
			// 
			// dataGridView7
			// 
			this.dataGridView7.AllowUserToAddRows = false;
			this.dataGridView7.AllowUserToDeleteRows = false;
			this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView7.Location = new System.Drawing.Point(6, 4);
			this.dataGridView7.Name = "dataGridView7";
			this.dataGridView7.ReadOnly = true;
			this.dataGridView7.Size = new System.Drawing.Size(940, 434);
			this.dataGridView7.TabIndex = 0;
			// 
			// tabPage14
			// 
			this.tabPage14.BackColor = System.Drawing.Color.Silver;
			this.tabPage14.Controls.Add(this.tabControl4);
			this.tabPage14.Location = new System.Drawing.Point(4, 22);
			this.tabPage14.Name = "tabPage14";
			this.tabPage14.Size = new System.Drawing.Size(949, 441);
			this.tabPage14.TabIndex = 11;
			this.tabPage14.Text = "Візуалізація";
			// 
			// tabControl4
			// 
			this.tabControl4.Controls.Add(this.tabPage16);
			this.tabControl4.Controls.Add(this.tabPage17);
			this.tabControl4.Controls.Add(this.tabPage18);
			this.tabControl4.Controls.Add(this.tabPage19);
			this.tabControl4.Location = new System.Drawing.Point(3, 6);
			this.tabControl4.Name = "tabControl4";
			this.tabControl4.SelectedIndex = 0;
			this.tabControl4.Size = new System.Drawing.Size(940, 432);
			this.tabControl4.TabIndex = 0;
			// 
			// tabPage16
			// 
			this.tabPage16.Controls.Add(this.checkBox7);
			this.tabPage16.Controls.Add(this.checkBox4);
			this.tabPage16.Controls.Add(this.checkBox3);
			this.tabPage16.Controls.Add(this.tableLayoutPanel1);
			this.tabPage16.Location = new System.Drawing.Point(4, 22);
			this.tabPage16.Name = "tabPage16";
			this.tabPage16.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage16.Size = new System.Drawing.Size(932, 406);
			this.tabPage16.TabIndex = 0;
			this.tabPage16.Text = "Матриця діаграм розкиду";
			this.tabPage16.UseVisualStyleBackColor = true;
			// 
			// checkBox7
			// 
			this.checkBox7.AutoSize = true;
			this.checkBox7.Checked = true;
			this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox7.Location = new System.Drawing.Point(462, 3);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(177, 17);
			this.checkBox7.TabIndex = 3;
			this.checkBox7.Text = "Показувати значення на осях";
			this.checkBox7.UseVisualStyleBackColor = true;
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new System.Drawing.Point(238, 3);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(218, 17);
			this.checkBox4.TabIndex = 2;
			this.checkBox4.Text = "... навіть при великій кількості вимірів";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.Location = new System.Drawing.Point(7, 3);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(224, 17);
			this.checkBox3.TabIndex = 1;
			this.checkBox3.Text = "Створювати матрицю діаграм розкиду ";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 26);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(919, 374);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tabPage17
			// 
			this.tabPage17.Controls.Add(this.checkBox9);
			this.tabPage17.Controls.Add(this.textBox26);
			this.tabPage17.Controls.Add(this.textBox25);
			this.tabPage17.Controls.Add(this.textBox24);
			this.tabPage17.Controls.Add(this.label25);
			this.tabPage17.Controls.Add(this.label24);
			this.tabPage17.Controls.Add(this.label23);
			this.tabPage17.Controls.Add(this.label22);
			this.tabPage17.Controls.Add(this.chart3);
			this.tabPage17.Location = new System.Drawing.Point(4, 22);
			this.tabPage17.Name = "tabPage17";
			this.tabPage17.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage17.Size = new System.Drawing.Size(932, 406);
			this.tabPage17.TabIndex = 1;
			this.tabPage17.Text = "Бульбашкова діаграма ";
			this.tabPage17.UseVisualStyleBackColor = true;
			// 
			// checkBox9
			// 
			this.checkBox9.AutoSize = true;
			this.checkBox9.Checked = true;
			this.checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox9.Location = new System.Drawing.Point(6, 6);
			this.checkBox9.Name = "checkBox9";
			this.checkBox9.Size = new System.Drawing.Size(190, 17);
			this.checkBox9.TabIndex = 11;
			this.checkBox9.Text = "Виводити бульбашкову діаграму";
			this.checkBox9.UseVisualStyleBackColor = true;
			// 
			// textBox26
			// 
			this.textBox26.Location = new System.Drawing.Point(806, 124);
			this.textBox26.Name = "textBox26";
			this.textBox26.Size = new System.Drawing.Size(100, 20);
			this.textBox26.TabIndex = 10;
			this.textBox26.TextChanged += new System.EventHandler(this.textBox26_TextChanged);
			// 
			// textBox25
			// 
			this.textBox25.Location = new System.Drawing.Point(806, 97);
			this.textBox25.Name = "textBox25";
			this.textBox25.Size = new System.Drawing.Size(100, 20);
			this.textBox25.TabIndex = 9;
			this.textBox25.TextChanged += new System.EventHandler(this.textBox25_TextChanged);
			// 
			// textBox24
			// 
			this.textBox24.Location = new System.Drawing.Point(806, 70);
			this.textBox24.Name = "textBox24";
			this.textBox24.Size = new System.Drawing.Size(100, 20);
			this.textBox24.TabIndex = 8;
			this.textBox24.TextChanged += new System.EventHandler(this.textBox24_TextChanged);
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(763, 127);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(36, 13);
			this.label25.TabIndex = 7;
			this.label25.Text = "Вісь z";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(763, 100);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(36, 13);
			this.label24.TabIndex = 5;
			this.label24.Text = "Вісь у";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(763, 73);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(36, 13);
			this.label23.TabIndex = 3;
			this.label23.Text = "Вісь х";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(783, 43);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(143, 13);
			this.label22.TabIndex = 2;
			this.label22.Text = "Вибірки для відображення:";
			// 
			// chart3
			// 
			chartArea5.Name = "ChartArea1";
			this.chart3.ChartAreas.Add(chartArea5);
			this.chart3.Location = new System.Drawing.Point(7, 29);
			this.chart3.Name = "chart3";
			series28.BorderColor = System.Drawing.Color.Black;
			series28.BorderWidth = 3;
			series28.ChartArea = "ChartArea1";
			series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
			series28.MarkerColor = System.Drawing.Color.Red;
			series28.MarkerSize = 25;
			series28.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
			series28.Name = "Series1";
			series28.YValuesPerPoint = 2;
			this.chart3.Series.Add(series28);
			this.chart3.Size = new System.Drawing.Size(750, 356);
			this.chart3.TabIndex = 0;
			this.chart3.Text = "chart3";
			// 
			// tabPage18
			// 
			this.tabPage18.Controls.Add(this.panel2);
			this.tabPage18.Controls.Add(this.checkBox8);
			this.tabPage18.Location = new System.Drawing.Point(4, 22);
			this.tabPage18.Name = "tabPage18";
			this.tabPage18.Size = new System.Drawing.Size(932, 406);
			this.tabPage18.TabIndex = 2;
			this.tabPage18.Text = "Теплова карта";
			this.tabPage18.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Location = new System.Drawing.Point(4, 27);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(925, 363);
			this.panel2.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(3, 15);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(919, 333);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// checkBox8
			// 
			this.checkBox8.AutoSize = true;
			this.checkBox8.Checked = true;
			this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox8.Location = new System.Drawing.Point(3, 3);
			this.checkBox8.Name = "checkBox8";
			this.checkBox8.Size = new System.Drawing.Size(148, 17);
			this.checkBox8.TabIndex = 2;
			this.checkBox8.Text = "Виводити теплову карту";
			this.checkBox8.UseVisualStyleBackColor = true;
			// 
			// tabPage19
			// 
			this.tabPage19.Controls.Add(this.checkBox6);
			this.tabPage19.Controls.Add(this.checkBox5);
			this.tabPage19.Controls.Add(this.chart4);
			this.tabPage19.Location = new System.Drawing.Point(4, 22);
			this.tabPage19.Name = "tabPage19";
			this.tabPage19.Size = new System.Drawing.Size(932, 406);
			this.tabPage19.TabIndex = 3;
			this.tabPage19.Text = "Паралельні координати";
			this.tabPage19.UseVisualStyleBackColor = true;
			// 
			// checkBox6
			// 
			this.checkBox6.AutoSize = true;
			this.checkBox6.Location = new System.Drawing.Point(217, 3);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(203, 17);
			this.checkBox6.TabIndex = 3;
			this.checkBox6.Text = "Навіть при великіій кількості даних";
			this.checkBox6.UseVisualStyleBackColor = true;
			// 
			// checkBox5
			// 
			this.checkBox5.AutoSize = true;
			this.checkBox5.Checked = true;
			this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox5.Location = new System.Drawing.Point(4, 4);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(207, 17);
			this.checkBox5.TabIndex = 1;
			this.checkBox5.Text = "Виводити паралельні координати ...";
			this.checkBox5.UseVisualStyleBackColor = true;
			// 
			// chart4
			// 
			chartArea6.Name = "ChartArea1";
			this.chart4.ChartAreas.Add(chartArea6);
			this.chart4.Location = new System.Drawing.Point(3, 30);
			this.chart4.Name = "chart4";
			series29.ChartArea = "ChartArea1";
			series29.Name = "Series1";
			this.chart4.Series.Add(series29);
			this.chart4.Size = new System.Drawing.Size(926, 373);
			this.chart4.TabIndex = 0;
			this.chart4.Text = "chart4";
			// 
			// tabPage20
			// 
			this.tabPage20.BackColor = System.Drawing.Color.DarkGray;
			this.tabPage20.Controls.Add(this.groupBox10);
			this.tabPage20.Controls.Add(this.groupBox9);
			this.tabPage20.Location = new System.Drawing.Point(4, 22);
			this.tabPage20.Name = "tabPage20";
			this.tabPage20.Size = new System.Drawing.Size(949, 441);
			this.tabPage20.TabIndex = 12;
			this.tabPage20.Text = "Частинні коефіціенти корреляції";
			// 
			// groupBox10
			// 
			this.groupBox10.Controls.Add(this.textBox27);
			this.groupBox10.Controls.Add(this.label29);
			this.groupBox10.Controls.Add(this.button31);
			this.groupBox10.Controls.Add(this.dataGridView10);
			this.groupBox10.Controls.Add(this.textBox23);
			this.groupBox10.Controls.Add(this.label28);
			this.groupBox10.Controls.Add(this.textBox22);
			this.groupBox10.Controls.Add(this.label27);
			this.groupBox10.Controls.Add(this.textBox21);
			this.groupBox10.Controls.Add(this.label26);
			this.groupBox10.Location = new System.Drawing.Point(723, 3);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(223, 435);
			this.groupBox10.TabIndex = 1;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "Вищих порядків";
			// 
			// textBox27
			// 
			this.textBox27.Location = new System.Drawing.Point(10, 154);
			this.textBox27.Name = "textBox27";
			this.textBox27.Size = new System.Drawing.Size(100, 20);
			this.textBox27.TabIndex = 9;
			this.textBox27.Text = "0,05";
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(7, 138);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(49, 13);
			this.label29.TabIndex = 8;
			this.label29.Text = "α-рівень";
			// 
			// button31
			// 
			this.button31.Location = new System.Drawing.Point(10, 397);
			this.button31.Name = "button31";
			this.button31.Size = new System.Drawing.Size(207, 32);
			this.button31.TabIndex = 7;
			this.button31.Text = "Обрахувати";
			this.button31.UseVisualStyleBackColor = true;
			this.button31.Click += new System.EventHandler(this.button31_Click);
			// 
			// dataGridView10
			// 
			this.dataGridView10.AllowUserToAddRows = false;
			this.dataGridView10.AllowUserToDeleteRows = false;
			this.dataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView10.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column14});
			this.dataGridView10.Location = new System.Drawing.Point(10, 180);
			this.dataGridView10.Name = "dataGridView10";
			this.dataGridView10.Size = new System.Drawing.Size(207, 211);
			this.dataGridView10.TabIndex = 6;
			// 
			// Column14
			// 
			this.Column14.HeaderText = "Номера змінних";
			this.Column14.Name = "Column14";
			// 
			// textBox23
			// 
			this.textBox23.Location = new System.Drawing.Point(10, 115);
			this.textBox23.Name = "textBox23";
			this.textBox23.Size = new System.Drawing.Size(100, 20);
			this.textBox23.TabIndex = 5;
			this.textBox23.TextChanged += new System.EventHandler(this.textBox23_TextChanged);
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(7, 99);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(250, 13);
			this.label28.TabIndex = 4;
			this.label28.Text = "кількість змінних, від яких не має залежати чкк";
			// 
			// textBox22
			// 
			this.textBox22.Location = new System.Drawing.Point(10, 76);
			this.textBox22.Name = "textBox22";
			this.textBox22.Size = new System.Drawing.Size(100, 20);
			this.textBox22.TabIndex = 3;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(7, 60);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(52, 13);
			this.label27.TabIndex = 2;
			this.label27.Text = "та другої";
			// 
			// textBox21
			// 
			this.textBox21.Location = new System.Drawing.Point(10, 37);
			this.textBox21.Name = "textBox21";
			this.textBox21.Size = new System.Drawing.Size(100, 20);
			this.textBox21.TabIndex = 1;
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(7, 21);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(163, 13);
			this.label26.TabIndex = 0;
			this.label26.Text = "Введіть номер першох вібиріки";
			// 
			// groupBox9
			// 
			this.groupBox9.Controls.Add(this.radioButton8);
			this.groupBox9.Controls.Add(this.radioButton7);
			this.groupBox9.Controls.Add(this.dataGridView9);
			this.groupBox9.Controls.Add(this.comboBox4);
			this.groupBox9.Location = new System.Drawing.Point(4, 4);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(713, 434);
			this.groupBox9.TabIndex = 0;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Першого порядку";
			// 
			// radioButton8
			// 
			this.radioButton8.AutoSize = true;
			this.radioButton8.Location = new System.Drawing.Point(587, 78);
			this.radioButton8.Name = "radioButton8";
			this.radioButton8.Size = new System.Drawing.Size(110, 17);
			this.radioButton8.TabIndex = 4;
			this.radioButton8.Text = "Порівнювати з R";
			this.radioButton8.UseVisualStyleBackColor = true;
			this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
			// 
			// radioButton7
			// 
			this.radioButton7.AutoSize = true;
			this.radioButton7.Checked = true;
			this.radioButton7.Location = new System.Drawing.Point(587, 54);
			this.radioButton7.Name = "radioButton7";
			this.radioButton7.Size = new System.Drawing.Size(108, 17);
			this.radioButton7.TabIndex = 3;
			this.radioButton7.TabStop = true;
			this.radioButton7.Text = "Порівнювати з 0";
			this.radioButton7.UseVisualStyleBackColor = true;
			this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
			// 
			// dataGridView9
			// 
			this.dataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView9.Location = new System.Drawing.Point(6, 20);
			this.dataGridView9.Name = "dataGridView9";
			this.dataGridView9.Size = new System.Drawing.Size(574, 389);
			this.dataGridView9.TabIndex = 2;
			// 
			// comboBox4
			// 
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(586, 20);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(121, 21);
			this.comboBox4.TabIndex = 1;
			this.comboBox4.SelectedValueChanged += new System.EventHandler(this.comboBox4_SelectedValueChanged);
			// 
			// tabPage21
			// 
			this.tabPage21.Controls.Add(this.dataGridView11);
			this.tabPage21.Location = new System.Drawing.Point(4, 22);
			this.tabPage21.Name = "tabPage21";
			this.tabPage21.Size = new System.Drawing.Size(949, 441);
			this.tabPage21.TabIndex = 13;
			this.tabPage21.Text = "Множинні коефіціенти кореляції";
			this.tabPage21.UseVisualStyleBackColor = true;
			// 
			// dataGridView11
			// 
			this.dataGridView11.AllowUserToAddRows = false;
			this.dataGridView11.AllowUserToDeleteRows = false;
			this.dataGridView11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView11.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column13,
            this.Column15});
			this.dataGridView11.Location = new System.Drawing.Point(6, 4);
			this.dataGridView11.Name = "dataGridView11";
			this.dataGridView11.Size = new System.Drawing.Size(940, 434);
			this.dataGridView11.TabIndex = 0;
			// 
			// Column13
			// 
			this.Column13.HeaderText = "Значення мкк";
			this.Column13.Name = "Column13";
			this.Column13.ReadOnly = true;
			this.Column13.Width = 150;
			// 
			// Column15
			// 
			this.Column15.HeaderText = "Чи було пройдено тест на значущість?";
			this.Column15.Name = "Column15";
			this.Column15.ReadOnly = true;
			this.Column15.Width = 150;
			// 
			// tabPage22
			// 
			this.tabPage22.Controls.Add(this.tabControl6);
			this.tabPage22.Controls.Add(this.groupBox11);
			this.tabPage22.Controls.Add(this.chart5);
			this.tabPage22.Location = new System.Drawing.Point(4, 22);
			this.tabPage22.Name = "tabPage22";
			this.tabPage22.Size = new System.Drawing.Size(949, 441);
			this.tabPage22.TabIndex = 14;
			this.tabPage22.Text = "Багатовимірна регрессія";
			this.tabPage22.UseVisualStyleBackColor = true;
			// 
			// tabControl6
			// 
			this.tabControl6.Controls.Add(this.tabPage25);
			this.tabControl6.Controls.Add(this.tabPage26);
			this.tabControl6.Location = new System.Drawing.Point(571, 243);
			this.tabControl6.Name = "tabControl6";
			this.tabControl6.SelectedIndex = 0;
			this.tabControl6.Size = new System.Drawing.Size(375, 195);
			this.tabControl6.TabIndex = 2;
			// 
			// tabPage25
			// 
			this.tabPage25.Controls.Add(this.dataGridView12);
			this.tabPage25.Location = new System.Drawing.Point(4, 22);
			this.tabPage25.Name = "tabPage25";
			this.tabPage25.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage25.Size = new System.Drawing.Size(367, 169);
			this.tabPage25.TabIndex = 0;
			this.tabPage25.Text = "Звірка параметрів а";
			this.tabPage25.UseVisualStyleBackColor = true;
			// 
			// dataGridView12
			// 
			this.dataGridView12.AllowUserToAddRows = false;
			this.dataGridView12.AllowUserToDeleteRows = false;
			this.dataGridView12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView12.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column16,
            this.Column17});
			this.dataGridView12.Location = new System.Drawing.Point(7, 7);
			this.dataGridView12.Name = "dataGridView12";
			this.dataGridView12.Size = new System.Drawing.Size(354, 156);
			this.dataGridView12.TabIndex = 0;
			// 
			// Column16
			// 
			this.Column16.HeaderText = "Номер параметру";
			this.Column16.Name = "Column16";
			this.Column16.ReadOnly = true;
			// 
			// Column17
			// 
			this.Column17.HeaderText = "Значення";
			this.Column17.Name = "Column17";
			// 
			// tabPage26
			// 
			this.tabPage26.Controls.Add(this.dataGridView13);
			this.tabPage26.Location = new System.Drawing.Point(4, 22);
			this.tabPage26.Name = "tabPage26";
			this.tabPage26.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage26.Size = new System.Drawing.Size(367, 169);
			this.tabPage26.TabIndex = 1;
			this.tabPage26.Text = "Довірчі інтервали";
			this.tabPage26.UseVisualStyleBackColor = true;
			// 
			// dataGridView13
			// 
			this.dataGridView13.AllowUserToAddRows = false;
			this.dataGridView13.AllowUserToDeleteRows = false;
			this.dataGridView13.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView13.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22});
			this.dataGridView13.Location = new System.Drawing.Point(7, 7);
			this.dataGridView13.Name = "dataGridView13";
			this.dataGridView13.Size = new System.Drawing.Size(357, 156);
			this.dataGridView13.TabIndex = 0;
			// 
			// Column18
			// 
			this.Column18.HeaderText = "Номер";
			this.Column18.Name = "Column18";
			this.Column18.ReadOnly = true;
			this.Column18.Width = 40;
			// 
			// Column19
			// 
			this.Column19.HeaderText = "Нижня ДІ";
			this.Column19.Name = "Column19";
			this.Column19.ReadOnly = true;
			this.Column19.Width = 75;
			// 
			// Column20
			// 
			this.Column20.HeaderText = "Значення у";
			this.Column20.Name = "Column20";
			this.Column20.ReadOnly = true;
			this.Column20.Width = 75;
			// 
			// Column21
			// 
			this.Column21.HeaderText = "Верхній ДІ";
			this.Column21.Name = "Column21";
			this.Column21.ReadOnly = true;
			this.Column21.Width = 75;
			// 
			// Column22
			// 
			this.Column22.HeaderText = "Перевірка збігу";
			this.Column22.Name = "Column22";
			this.Column22.ReadOnly = true;
			this.Column22.Width = 40;
			// 
			// groupBox11
			// 
			this.groupBox11.Controls.Add(this.textBox29);
			this.groupBox11.Controls.Add(this.label31);
			this.groupBox11.Controls.Add(this.textBox28);
			this.groupBox11.Controls.Add(this.label30);
			this.groupBox11.Controls.Add(this.radioButton11);
			this.groupBox11.Controls.Add(this.button35);
			this.groupBox11.Controls.Add(this.radioButton10);
			this.groupBox11.Controls.Add(this.radioButton9);
			this.groupBox11.Location = new System.Drawing.Point(575, 3);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Size = new System.Drawing.Size(371, 234);
			this.groupBox11.TabIndex = 1;
			this.groupBox11.TabStop = false;
			this.groupBox11.Text = "Параметри регресії";
			// 
			// textBox29
			// 
			this.textBox29.Location = new System.Drawing.Point(9, 141);
			this.textBox29.Name = "textBox29";
			this.textBox29.Size = new System.Drawing.Size(114, 20);
			this.textBox29.TabIndex = 7;
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(6, 125);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(154, 13);
			this.label31.TabIndex = 6;
			this.label31.Text = "Критичний рівень значущості";
			// 
			// textBox28
			// 
			this.textBox28.Location = new System.Drawing.Point(9, 102);
			this.textBox28.Name = "textBox28";
			this.textBox28.Size = new System.Drawing.Size(114, 20);
			this.textBox28.TabIndex = 5;
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(6, 86);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(180, 13);
			this.label30.TabIndex = 4;
			this.label30.Text = "Виберіть номер залежного виміру";
			// 
			// radioButton11
			// 
			this.radioButton11.AutoSize = true;
			this.radioButton11.Location = new System.Drawing.Point(7, 66);
			this.radioButton11.Name = "radioButton11";
			this.radioButton11.Size = new System.Drawing.Size(238, 17);
			this.radioButton11.TabIndex = 3;
			this.radioButton11.TabStop = true;
			this.radioButton11.Text = "Багатовимірна регресія з вільним членом";
			this.radioButton11.UseVisualStyleBackColor = true;
			// 
			// button35
			// 
			this.button35.Location = new System.Drawing.Point(83, 167);
			this.button35.Name = "button35";
			this.button35.Size = new System.Drawing.Size(198, 39);
			this.button35.TabIndex = 2;
			this.button35.Text = "Відтворити регресію";
			this.button35.UseVisualStyleBackColor = true;
			this.button35.Click += new System.EventHandler(this.button35_Click);
			// 
			// radioButton10
			// 
			this.radioButton10.AutoSize = true;
			this.radioButton10.Location = new System.Drawing.Point(7, 43);
			this.radioButton10.Name = "radioButton10";
			this.radioButton10.Size = new System.Drawing.Size(245, 17);
			this.radioButton10.TabIndex = 1;
			this.radioButton10.TabStop = true;
			this.radioButton10.Text = "Багатовимірна регресія без вільного члена";
			this.radioButton10.UseVisualStyleBackColor = true;
			// 
			// radioButton9
			// 
			this.radioButton9.AutoSize = true;
			this.radioButton9.Location = new System.Drawing.Point(7, 20);
			this.radioButton9.Name = "radioButton9";
			this.radioButton9.Size = new System.Drawing.Size(130, 17);
			this.radioButton9.TabIndex = 0;
			this.radioButton9.TabStop = true;
			this.radioButton9.Text = "Тривимірна регресія";
			this.radioButton9.UseVisualStyleBackColor = true;
			// 
			// chart5
			// 
			chartArea7.Name = "ChartArea1";
			this.chart5.ChartAreas.Add(chartArea7);
			this.chart5.Location = new System.Drawing.Point(6, 3);
			this.chart5.Name = "chart5";
			series30.ChartArea = "ChartArea1";
			series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series30.Name = "Відхилення";
			this.chart5.Series.Add(series30);
			this.chart5.Size = new System.Drawing.Size(559, 431);
			this.chart5.TabIndex = 0;
			this.chart5.Text = "chart5";
			// 
			// tabPage23
			// 
			this.tabPage23.Controls.Add(this.button37);
			this.tabPage23.Controls.Add(this.button36);
			this.tabPage23.Controls.Add(this.chart6);
			this.tabPage23.Location = new System.Drawing.Point(4, 22);
			this.tabPage23.Name = "tabPage23";
			this.tabPage23.Size = new System.Drawing.Size(949, 441);
			this.tabPage23.TabIndex = 15;
			this.tabPage23.Text = "TestPage";
			this.tabPage23.UseVisualStyleBackColor = true;
			// 
			// button37
			// 
			this.button37.Location = new System.Drawing.Point(517, 180);
			this.button37.Name = "button37";
			this.button37.Size = new System.Drawing.Size(75, 23);
			this.button37.TabIndex = 2;
			this.button37.Text = "button37";
			this.button37.UseVisualStyleBackColor = true;
			// 
			// button36
			// 
			this.button36.Location = new System.Drawing.Point(517, 34);
			this.button36.Name = "button36";
			this.button36.Size = new System.Drawing.Size(260, 139);
			this.button36.TabIndex = 1;
			this.button36.Text = "button36";
			this.button36.UseVisualStyleBackColor = true;
			// 
			// chart6
			// 
			chartArea8.BackImage = "H:\\photo_2018-09-21_09-26-16.jpg";
			chartArea8.Name = "ChartArea1";
			this.chart6.ChartAreas.Add(chartArea8);
			legend3.Name = "Legend1";
			this.chart6.Legends.Add(legend3);
			this.chart6.Location = new System.Drawing.Point(6, 3);
			this.chart6.Name = "chart6";
			series31.ChartArea = "ChartArea1";
			series31.Legend = "Legend1";
			series31.Name = "Series1";
			this.chart6.Series.Add(series31);
			this.chart6.Size = new System.Drawing.Size(493, 402);
			this.chart6.TabIndex = 0;
			this.chart6.Text = "chart6";
			// 
			// radioButton12
			// 
			this.radioButton12.AutoSize = true;
			this.radioButton12.Checked = true;
			this.radioButton12.Location = new System.Drawing.Point(6, 8);
			this.radioButton12.Name = "radioButton12";
			this.radioButton12.Size = new System.Drawing.Size(73, 17);
			this.radioButton12.TabIndex = 8;
			this.radioButton12.TabStop = true;
			this.radioButton12.Text = "Звичайна";
			this.radioButton12.UseVisualStyleBackColor = true;
			// 
			// radioButton13
			// 
			this.radioButton13.AutoSize = true;
			this.radioButton13.Location = new System.Drawing.Point(85, 8);
			this.radioButton13.Name = "radioButton13";
			this.radioButton13.Size = new System.Drawing.Size(82, 17);
			this.radioButton13.TabIndex = 9;
			this.radioButton13.Text = "Через МГК";
			this.radioButton13.UseVisualStyleBackColor = true;
			// 
			// BodyOfForm
			// 
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1301, 742);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tabControl2);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "BodyOfForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tabControl2.ResumeLayout(false);
			this.PageData.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridForData)).EndInit();
			this.PafeChange.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.tabPage7.ResumeLayout(false);
			this.tabPage7.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.tabPage6.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.tabPage15.ResumeLayout(false);
			this.tabPage15.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.PageEval.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridForEval)).EndInit();
			this.PageFunc.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DistrFun)).EndInit();
			this.PageHist.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Histogramme)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabControl3.ResumeLayout(false);
			this.tabPage8.ResumeLayout(false);
			this.tabPage8.PerformLayout();
			this.tabPage9.ResumeLayout(false);
			this.tabPage9.PerformLayout();
			this.tabPage10.ResumeLayout(false);
			this.tabPage10.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.tabPage5.ResumeLayout(false);
			this.tabPage5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
			this.tabPage11.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
			this.tabPage12.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
			this.tabPage13.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
			this.tabPage14.ResumeLayout(false);
			this.tabControl4.ResumeLayout(false);
			this.tabPage16.ResumeLayout(false);
			this.tabPage16.PerformLayout();
			this.tabPage17.ResumeLayout(false);
			this.tabPage17.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
			this.tabPage18.ResumeLayout(false);
			this.tabPage18.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabPage19.ResumeLayout(false);
			this.tabPage19.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
			this.tabPage20.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			this.groupBox10.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).EndInit();
			this.groupBox9.ResumeLayout(false);
			this.groupBox9.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).EndInit();
			this.tabPage21.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).EndInit();
			this.tabPage22.ResumeLayout(false);
			this.tabControl6.ResumeLayout(false);
			this.tabPage25.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView12)).EndInit();
			this.tabPage26.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView13)).EndInit();
			this.groupBox11.ResumeLayout(false);
			this.groupBox11.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart5)).EndInit();
			this.tabPage23.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart6)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpeningDialog = new OpenFileDialog();

            OpeningDialog.InitialDirectory = Application.StartupPath.ToString();
            OpeningDialog.Filter = "txt files (*.txt)|*.txt| dat files (*.dat)|*.dat";
            OpeningDialog.FilterIndex = 1;
            OpeningDialog.RestoreDirectory = true;

            if (OpeningDialog.ShowDialog() == DialogResult.OK)
            {
                //this.ProgressBar.Step = 100;
                //this.ProgressBar.PerformStep();
                //this.ProgressBar.Value = 50;
                Data.DataForWork.Add(new List<double>());
                Data.CurrentSample.set(Data.DataForWork.Count-1);
                try
                {
                    string[] FileLikeStrings = File.ReadAllLines(OpeningDialog.FileName);
                    char[] separators = new char[] { ' ', '\t', '\n' };
                    for (int i = 0; i < FileLikeStrings.Length; i++)
                    {
                        ToolsForWork.RemoveComments(ref FileLikeStrings[i]);
                        string[] valuesInLine = FileLikeStrings[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                        for (int j = 0; j < valuesInLine.Length; j++)
                        {
                            double x;
                            try
                            {
                                x = Convert.ToDouble(valuesInLine[j]);
                            }
                            catch
                            {
                                try
                                {
                                    valuesInLine[j] = valuesInLine[j].Replace(".", ",");
                                    x = Convert.ToDouble(valuesInLine[j]);
                                }
                                catch
                                {
                                    if (LogCheckBox.Checked == true)
                                        LogOutputTextBox.Text += "Theres mistake in string #" + i + Environment.NewLine;
                                    continue;
                                }
                            }
                            Data.DataForWork[Data.CurrentSample].Add(x);
                        }
                    }

                    if (Data.DataForWork[Data.CurrentSample].Count == 0)
                    {
                        LogOutputTextBox.Text += "File is empty" + Environment.NewLine;
                        Data.DataForWork.RemoveAt(Data.CurrentSample);
                        return;
                    }
                    //Data.DataForWork[Data.CurrentSample].Sort();
                    Data.NamesOfFiles.Add(OpeningDialog.FileName);
                    Data.StepBack.Add(new List<ToolsForWork.Changing>());
                    StatusLabelNameOfFile.Text = Data.NamesOfFiles[Data.CurrentSample];
                    HistData.NumberOfClassesChangedByUser = false;
                    DistrFuncData.NumberOfClassesChangedByUser = false;
                    Data.DistrCreated = false;
                    Build();
                }
                catch (Exception ExThatOccured)
                {
                    LogOutputTextBox.Text += ("Error happened while reading the file. Original error: " + ExThatOccured.Message + Environment.NewLine);
                }
            }
            //this.ProgressBar.Value = 1;

        }

        private void BuildDataTable()
        {
            this.DataGridForData.Columns.Clear();
            if (!Data.VarNeeded)
            {
                return;
            }
            this.DataGridForData.Columns.Add(new DataGridViewTextBoxColumn());
            this.DataGridForData.Columns.Add(new DataGridViewTextBoxColumn());
            this.DataGridForData.Columns.Add(new DataGridViewTextBoxColumn());
            this.DataGridForData.Columns.Add(new DataGridViewTextBoxColumn());
            this.DataGridForData.Columns[0].HeaderText = "Значення ";
            this.DataGridForData.Columns[0].Name = "Column" + 1;
            this.DataGridForData.Columns[0].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DataGridForData.Columns[0].ReadOnly = true;
            this.DataGridForData.Columns[1].HeaderText = "Ймовірність";
            this.DataGridForData.Columns[1].Name = "Column" + 2;
            this.DataGridForData.Columns[1].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DataGridForData.Columns[1].ReadOnly = true;
            this.DataGridForData.Columns[2].HeaderText = "Кількість значень";
            this.DataGridForData.Columns[2].Name = "Column" + 3;
            this.DataGridForData.Columns[2].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DataGridForData.Columns[2].ReadOnly = true;
            this.DataGridForData.Columns[3].Visible = false;
            this.DataGridForData.Columns[3].HeaderText = "u cant see me";
            this.DataGridForData.Columns[3].Width = 1;
            this.DataGridForData.Columns[3].Name = "Column" + 3;
            this.DataGridForData.Columns[3].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DataGridForData.Columns[3].ReadOnly = true;
            int CountOFSame = 0;
            for (int i = 0; i < Data.DataForWork[Data.CurrentSample].Count; i += CountOFSame)
            {
                CountOFSame = 1;
                for (int j = i + 1; j < Data.DataForWork[Data.CurrentSample].Count; j++)
                {
                    if (Convert.ToDouble(Data.DataForWork[Data.CurrentSample][i]) == Convert.ToDouble(Data.DataForWork[Data.CurrentSample][j]))
                    {
                        CountOFSame++;
                    }
                    else
                    {
                        break;
                    }
                }
                this.DataGridForData.Rows.Add(Math.Round(Data.DataForWork[Data.CurrentSample][i], Data.NumberOfNum), Math.Round(((double)CountOFSame) / Data.DataForWork[Data.CurrentSample].Count, Data.NumberOfNum), CountOFSame, Data.DataForWork[Data.CurrentSample][i]);
            }

        }

        private void BuildEval()
        {
            {
                double Summ = 0;
                for (int i = 0; i < Data.DataForWork[Data.CurrentSample].Count; i++)
                {
                    Summ += Data.DataForWork[Data.CurrentSample][i];
                }
                Data.EvalData.ExpValues = Summ / Data.DataForWork[Data.CurrentSample].Count;
                DataGridForEval.Rows[0].Cells[2].Value = "" + Math.Round(Data.EvalData.ExpValues, Data.NumberOfNum);
                if (Math.Abs(Data.EvalData.ExpValues) < 0.00000000001)
                {
                    Data.EvalData.ExpValues = 0;
                }
            }
            {
                Data.EvalData.SampleMed = ToolsForWork.ComputeMediana(Data.DataForWork[Data.CurrentSample]);
                {
                    DataGridForEval.Rows[1].Cells[2].Value = "" + Math.Round(Data.EvalData.SampleMed, Data.NumberOfNum);
                }
            }
            {
                BuildTrunMean();
            }
            {
                    if (Data.MEDNeeded)
                    {
                        if (Data.DataForWork[Data.CurrentSample].Count == 1)
                        {
                            DataGridForEval.Rows[3].Cells[2].Value = "Не обраховувалося";
                            if (LogCheckBox.Checked)
                                LogOutputTextBox.Text += "Знаходження медіани середніх Уолша при одному елементі неможливо " + Environment.NewLine;
                        }
                        else
                        {
                            List<double> MedWalList = new List<double>();
                            for (int j = 0; j < Data.DataForWork[Data.CurrentSample].Count; j++)
                            {
                                for (int i = 0; i < j; i++)
                                {
                                    MedWalList.Add((Data.DataForWork[Data.CurrentSample][j] + Data.DataForWork[Data.CurrentSample][i]) / 2);
                                }
                            }
                            Data.EvalData.WallshMed = ToolsForWork.ComputeMediana(MedWalList);
                            DataGridForEval.Rows[3].Cells[2].Value = "" + Math.Round(Data.EvalData.WallshMed, Data.NumberOfNum);
                        }
                    }
                    else
                        DataGridForEval.Rows[3].Cells[2].Value = "Не обраховувалося";
            }
            {
                Data.EvalData.StandDevNeZ = 0;
                Data.EvalData.StandDevZ = 0;
                if (Data.DataForWork[Data.CurrentSample].Count < 11)
                {
                    switch (Data.DataForWork[Data.CurrentSample].Count)
                    {
                        case 1: 
                            {
                                break;
                            };
                        case 2:
                            {
                                Data.EvalData.StandDevZ = 0.8862 * (Data.DataForWork[Data.CurrentSample][1] - Data.DataForWork[Data.CurrentSample][0]);
                                Data.EvalData.StandDevNeZ = Data.EvalData.StandDevZ;
                                break;
                            };
                        case 3:
                            {
                                Data.EvalData.StandDevZ = 0.5908 * (Data.DataForWork[Data.CurrentSample][2] - Data.DataForWork[Data.CurrentSample][0]);
                                Data.EvalData.StandDevNeZ = Data.EvalData.StandDevZ;
                                break;
                            };
                        case 4:
                            {
                                Data.EvalData.StandDevZ = 0.4539 * (Data.DataForWork[Data.CurrentSample][3] - Data.DataForWork[Data.CurrentSample][0]) + 0.1102 * (Data.DataForWork[Data.CurrentSample][2] - Data.DataForWork[Data.CurrentSample][1]);
                                Data.EvalData.StandDevNeZ = Data.EvalData.StandDevZ;
                                break;
                            };
                        case 5:
                            {
                                Data.EvalData.StandDevZ = 0.3724 * (Data.DataForWork[Data.CurrentSample][4] - Data.DataForWork[Data.CurrentSample][0]) + 0.1352 * (Data.DataForWork[Data.CurrentSample][3] - Data.DataForWork[Data.CurrentSample][1]);
                                Data.EvalData.StandDevNeZ = Data.EvalData.StandDevZ;
                                break;
                            };
                        case 6:
                            {
                                Data.EvalData.StandDevZ = 0.3175 * (Data.DataForWork[Data.CurrentSample][5] - Data.DataForWork[Data.CurrentSample][0]) + 0.1386 * (Data.DataForWork[Data.CurrentSample][4] - Data.DataForWork[Data.CurrentSample][1]) + 0.0432 * (Data.DataForWork[Data.CurrentSample][3] - Data.DataForWork[Data.CurrentSample][2]);
                                Data.EvalData.StandDevNeZ = Data.EvalData.StandDevZ;
                                break;
                            };
                        case 7:
                            {
                                Data.EvalData.StandDevZ = 0.2778 * (Data.DataForWork[Data.CurrentSample][6] - Data.DataForWork[Data.CurrentSample][0]) + 0.1351 * (Data.DataForWork[Data.CurrentSample][5] - Data.DataForWork[Data.CurrentSample][1]) + 0.0625 * (Data.DataForWork[Data.CurrentSample][4] - Data.DataForWork[Data.CurrentSample][2]);
                                Data.EvalData.StandDevNeZ = Data.EvalData.StandDevZ;
                                break;
                            };
                        case 8:
                            {
                                Data.EvalData.StandDevZ = 0.2476*(Data.DataForWork[Data.CurrentSample][7]-Data.DataForWork[Data.CurrentSample][0]) + 0.1294*(Data.DataForWork[Data.CurrentSample][6]-Data.DataForWork[Data.CurrentSample][1]) + 0.0713*(Data.DataForWork[Data.CurrentSample][5]-Data.DataForWork[Data.CurrentSample][2]) + 0.0230*(Data.DataForWork[Data.CurrentSample][4]-Data.DataForWork[Data.CurrentSample][3]);
                                Data.EvalData.StandDevNeZ = Data.EvalData.StandDevZ;
                                break;
                            };
                        case 9:
                            {
                                Data.EvalData.StandDevZ = 0.2237*(Data.DataForWork[Data.CurrentSample][8]-Data.DataForWork[Data.CurrentSample][0]) + 0.1233 * (Data.DataForWork[Data.CurrentSample][7]-Data.DataForWork[Data.CurrentSample][1]) + 0.0750*(Data.DataForWork[Data.CurrentSample][6]-Data.DataForWork[Data.CurrentSample][2]) + 0.0360*(Data.DataForWork[Data.CurrentSample][5]-Data.DataForWork[Data.CurrentSample][3]);
                                Data.EvalData.StandDevNeZ = Data.EvalData.StandDevZ;
                                break;
                            };
                        case 10:
                            {
                                Data.EvalData.StandDevZ = 0.2044 * (Data.DataForWork[Data.CurrentSample][9]-Data.DataForWork[Data.CurrentSample][0]) + 0.1172 * (Data.DataForWork[Data.CurrentSample][8]-Data.DataForWork[Data.CurrentSample][1]) + 0.0763 * (Data.DataForWork[Data.CurrentSample][7]-Data.DataForWork[Data.CurrentSample][2]) + 0.0436 * (Data.DataForWork[Data.CurrentSample][6]-Data.DataForWork[Data.CurrentSample][3]) + 0.0142*(Data.DataForWork[Data.CurrentSample][5]-Data.DataForWork[Data.CurrentSample][4]);
                                Data.EvalData.StandDevNeZ = Data.EvalData.StandDevZ;
                                break;
                            };
                    }
                    DataGridForEval.Rows[4].Cells[2].Value = "" + Math.Round(Data.EvalData.StandDevNeZ, Data.NumberOfNum);
                }
                else
                {
                    for (int i = 0; i < Data.DataForWork[Data.CurrentSample].Count; i++)
                    {
                        Data.EvalData.StandDevZ += Data.DataForWork[Data.CurrentSample][i] * Data.DataForWork[Data.CurrentSample][i] - Data.EvalData.ExpValues * Data.EvalData.ExpValues;
                        Data.EvalData.StandDevNeZ += Math.Pow((Data.DataForWork[Data.CurrentSample][i] - Data.EvalData.ExpValues), 2);
                    }
                    Data.EvalData.StandDevZ *= (1.0) / Data.DataForWork[Data.CurrentSample].Count;
                    Data.EvalData.StandDevNeZ *= (1.0) / (Data.DataForWork[Data.CurrentSample].Count - 1);
                    Data.EvalData.StandDevZ = (Math.Sqrt(Data.EvalData.StandDevZ));
                    Data.EvalData.StandDevNeZ = (Math.Sqrt(Data.EvalData.StandDevNeZ));
                    DataGridForEval.Rows[4].Cells[2].Value = "" + Math.Round(Data.EvalData.StandDevNeZ, Data.NumberOfNum);
                }
            }
            {
                Data.EvalData.MAD = 0;
                List<double> MadList = new List<double>();
                for (int i = 0; i < Data.DataForWork[Data.CurrentSample].Count; i++)
                {
                    MadList.Add(Math.Abs(Data.DataForWork[Data.CurrentSample][i] - Data.EvalData.SampleMed));
                }
                Data.EvalData.MAD = 1.483 * (ToolsForWork.ComputeMediana(MadList));
                DataGridForEval.Rows[5].Cells[2].Value = "" + Math.Round(Data.EvalData.MAD, Data.NumberOfNum);//Math.Round(MAD, Data.NumberOfNum);
            }
            {
                Data.EvalData.Skewness = 0;
                if ((Data.DataForWork[Data.CurrentSample].Count > 2 )&&(!(Data.EvalData.StandDevZ == 0)))
                {
                    for (int i = 0; i < Data.DataForWork[Data.CurrentSample].Count; i++)
                    {
                        Data.EvalData.Skewness += Math.Pow((Data.DataForWork[Data.CurrentSample][i] - Data.EvalData.ExpValues), 3);
                    }
                    Data.EvalData.Skewness *= (1.0) / (Data.DataForWork[Data.CurrentSample].Count * Data.EvalData.StandDevZ * Data.EvalData.StandDevZ * Data.EvalData.StandDevZ);
                    Data.EvalData.Skewness *= (Math.Sqrt((Data.DataForWork[Data.CurrentSample].Count)) * (Math.Sqrt((Data.DataForWork[Data.CurrentSample].Count - 1)))) / (Data.DataForWork[Data.CurrentSample].Count - 2);
                    DataGridForEval.Rows[6].Cells[2].Value = "" + Math.Round(Data.EvalData.Skewness, Data.NumberOfNum);
                }
                else
                    DataGridForEval.Rows[6].Cells[2].Value = "Не обраховувалося";
            }
            {
                Data.EvalData.KurtosisZ = 0;
                Data.EvalData.KurtosisNeZ = 0;
                if ((Data.DataForWork[Data.CurrentSample].Count > 3) && (!(Data.EvalData.StandDevZ == 0)))
                {
                    for (int i = 0; i < Data.DataForWork[Data.CurrentSample].Count; i++)
                    {
                        Data.EvalData.KurtosisZ += Math.Pow((Data.DataForWork[Data.CurrentSample][i] - Data.EvalData.ExpValues), 4);
                    }
                    Data.EvalData.KurtosisZ *= (1.0) / (Data.DataForWork[Data.CurrentSample].Count * Data.EvalData.StandDevZ * Data.EvalData.StandDevZ * Data.EvalData.StandDevZ * Data.EvalData.StandDevZ);
                    Data.EvalData.KurtosisNeZ = ((double)(Data.DataForWork[Data.CurrentSample].Count * Data.DataForWork[Data.CurrentSample].Count - 1) / ((Data.DataForWork[Data.CurrentSample].Count - 2) * (Data.DataForWork[Data.CurrentSample].Count - 3))) * ((Data.EvalData.KurtosisZ - 3) + (6.0 / (Data.DataForWork[Data.CurrentSample].Count + 1)));
                    DataGridForEval.Rows[7].Cells[2].Value = "" + Math.Round(Data.EvalData.KurtosisNeZ, Data.NumberOfNum);
                    ///////////////////
                    Data.EvalData.ContrKurtosis = 0;
                    if (Data.EvalData.KurtosisNeZ != 0)
                    {
                        Data.EvalData.ContrKurtosis = 1.0 / (Math.Sqrt(Math.Abs(Data.EvalData.KurtosisNeZ)));
                        DataGridForEval.Rows[8].Cells[2].Value = "" + Math.Round(Data.EvalData.ContrKurtosis, Data.NumberOfNum);
                    }
                    else
                        DataGridForEval.Rows[8].Cells[2].Value = "Не обраховувалося";

                }
                else
                {
                    DataGridForEval.Rows[7].Cells[2].Value = "Не обраховувалося";
                    DataGridForEval.Rows[8].Cells[2].Value = "Не обраховувалося";
                }
            }
            {
                Data.EvalData.CoV= 0;
                //Console.WriteLine("lil " + MatSp + "  " + NezStandart);
                if (Data.EvalData.ExpValues != 0)
                {
                    Data.EvalData.CoV = Data.EvalData.StandDevNeZ / Data.EvalData.ExpValues;
                    DataGridForEval.Rows[9].Cells[2].Value = "" + Math.Round(Data.EvalData.CoV, Data.NumberOfNum);
                }
                else
                {
                    if (LogCheckBox.Checked)
                    {
                        LogOutputTextBox.Text += "Неможливо обрахувати коефіціент варіації Пірсона при матсподіванні, близькому до нуля. Спробуйте провести зсув " + Environment.NewLine;
                    }
                    DataGridForEval.Rows[9].Cells[2].Value = "Не обраховувалося";
                }
            }
            if (Data.EvalData.StandDevNeZ == 0)
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Деякі довірчі інтервали неможливо знайти з нульовою дисперсією " + Environment.NewLine;
            }
            ComputeBordersForExpVal();
            ComputeBordersForStandDev();
            ComputeBordersForCoV();
            ComputeForeseenBorders();
            ComputeSkewnessBorders();
            ComputeKurtosisBorders();
        }

        private void ComputeBordersForExpVal()
        {
            if (Data.DataForWork[Data.CurrentSample].Count == 1)
            {
                DataGridForEval.Rows[0].Cells[1].Value = "Не обраховувалося";
                DataGridForEval.Rows[0].Cells[3].Value = "Не обраховувалося";
                return;
            }
            double alfa = 0.1;
            double gamma = 0.9;
            try
            {
                gamma = Convert.ToDouble(DataGridForEval.Rows[0].Cells[4].EditedFormattedValue);
                alfa = 1-gamma;
            }
            catch (Exception)
            {
                DataGridForEval.Rows[0].Cells[4].Value = "0,9";
                alfa = 0.1;
            }
            if ((alfa <= 0) || (alfa >= 1))
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Хибне значення γ для математичного сподівання " + Environment.NewLine;
                DataGridForEval.Rows[0].Cells[4].Value = "0,9";
                alfa = 0.1;
            }
            Data.EvalData.ExpValDev = Data.EvalData.StandDevNeZ / Math.Sqrt(Data.DataForWork[Data.CurrentSample].Count);
            DataGridForEval.Rows[0].Cells[1].Value = Math.Round(Data.EvalData.ExpValues - Data.EvalData.ExpValDev * Quantile.StudQuan(1 - alfa / 2, Data.DataForWork[Data.CurrentSample].Count - 1), Data.NumberOfNum);
            DataGridForEval.Rows[0].Cells[3].Value = Math.Round(Data.EvalData.ExpValues + Data.EvalData.ExpValDev * Quantile.StudQuan(1 - alfa / 2, Data.DataForWork[Data.CurrentSample].Count - 1), Data.NumberOfNum);
        }

        private void ComputeBordersForStandDev()
        {
            if (Data.DataForWork[Data.CurrentSample].Count == 1)
            {
                DataGridForEval.Rows[0].Cells[1].Value = "Не обраховувалося";
                DataGridForEval.Rows[0].Cells[3].Value = "Не обраховувалося";
                return;
            }
            double alfa = 0.1;
            double gamma = 0.9;
            try
            {
                gamma = Convert.ToDouble(DataGridForEval.Rows[4].Cells[4].EditedFormattedValue);
                alfa = 1 - gamma;
            }
            catch (Exception)
            {
                DataGridForEval.Rows[4].Cells[4].Value = "0,9";
                alfa = 0.1;
            }
            if ((alfa <= 0) || (alfa >= 1))
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Хибне значення γ для стандартного відхилення" + Environment.NewLine;
                DataGridForEval.Rows[4].Cells[4].Value = "0,9";
                alfa = 0.1;
            }
            Data.EvalData.StandDevDev = Data.EvalData.StandDevNeZ / Math.Sqrt(2*Data.DataForWork[Data.CurrentSample].Count);
            DataGridForEval.Rows[4].Cells[1].Value = Math.Round(Data.EvalData.StandDevNeZ - Data.EvalData.StandDevDev * Quantile.StudQuan(1 - alfa / 2, Data.DataForWork[Data.CurrentSample].Count - 1), Data.NumberOfNum);
            DataGridForEval.Rows[4].Cells[3].Value = Math.Round(Data.EvalData.StandDevNeZ + Data.EvalData.StandDevDev * Quantile.StudQuan(1 - alfa / 2, Data.DataForWork[Data.CurrentSample].Count - 1), Data.NumberOfNum);
        }

        private void ComputeSkewnessBorders()
        {
            if ((Data.DataForWork[Data.CurrentSample].Count == 1) || ((string)DataGridForEval.Rows[6].Cells[2].Value == "Не обраховувалося"))
            {
                DataGridForEval.Rows[6].Cells[1].Value = "Не обраховувалося";
                DataGridForEval.Rows[6].Cells[3].Value = "Не обраховувалося";
                return;
            }
            double alfa = 0.1;
            double gamma = 0.9;
            try
            {
                gamma = Convert.ToDouble(DataGridForEval.Rows[6].Cells[4].EditedFormattedValue);
                alfa = 1 - gamma;
            }
            catch (Exception)
            {
                DataGridForEval.Rows[6].Cells[4].Value = "0,9";
                alfa = 0.1;
            }
            if ((alfa <= 0) || (alfa >= 1))
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Хибне значення γ для коефіціента асиметрії" + Environment.NewLine;
                DataGridForEval.Rows[6].Cells[4].Value = "0,9";
                alfa = 0.1;
            }
            double Mu2 = ToolsForWork.ComputeCentralMoment(Data.DataForWork[Data.CurrentSample],2);
            double Mu3 = ToolsForWork.ComputeCentralMoment(Data.DataForWork[Data.CurrentSample],3);
            double Mu4 = ToolsForWork.ComputeCentralMoment(Data.DataForWork[Data.CurrentSample],4);
            double Mu5 = ToolsForWork.ComputeCentralMoment(Data.DataForWork[Data.CurrentSample],5);
            double Mu6 = ToolsForWork.ComputeCentralMoment(Data.DataForWork[Data.CurrentSample],6);
            double beta1 = (Mu3*Mu3)/(Mu2*Mu2*Mu2);
            double beta2 = (Mu4)/(Mu2*Mu2);
            double beta3 = (Mu3*Mu5)/(Mu2*Mu2*Mu2*Mu2);
            double beta4 = (Mu6)/(Mu2*Mu2*Mu2);
            Data.EvalData.SkewnessDev = Math.Sqrt((1.0 / (4 * Data.DataForWork[Data.CurrentSample].Count)) * Math.Abs((4 * beta4 - 12 * beta3 - 24 * beta2 + 9 * beta2 * beta1 + 35 * beta1 - 36)));
            DataGridForEval.Rows[6].Cells[1].Value = Math.Round(Data.EvalData.Skewness - Data.EvalData.SkewnessDev * Quantile.StudQuan(1 - alfa / 2, Data.DataForWork[Data.CurrentSample].Count - 1), Data.NumberOfNum);
            DataGridForEval.Rows[6].Cells[3].Value = Math.Round(Data.EvalData.Skewness + Data.EvalData.SkewnessDev * Quantile.StudQuan(1 - alfa / 2, Data.DataForWork[Data.CurrentSample].Count - 1), Data.NumberOfNum);
        }

        private void ComputeKurtosisBorders()
        {
            if ((Data.DataForWork[Data.CurrentSample].Count == 1) || ((string)DataGridForEval.Rows[7].Cells[2].Value == "Не обраховувалося"))
            {
                DataGridForEval.Rows[7].Cells[1].Value = "Не обраховувалося";
                DataGridForEval.Rows[7].Cells[3].Value = "Не обраховувалося";
                return;
            }
            double alfa = 0.1;
            double gamma = 0.9;
            try
            {
                gamma = Convert.ToDouble(DataGridForEval.Rows[7].Cells[4].EditedFormattedValue);
                alfa = 1 - gamma;
            }
            catch (Exception)
            {
                DataGridForEval.Rows[7].Cells[4].Value = "0,9";
                alfa = 0.1;
            }
            if ((alfa <= 0) || (alfa >= 1))
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Хибне значення γ для коефіціента ексцесу" + Environment.NewLine;
                DataGridForEval.Rows[7].Cells[4].Value = "0,9";
                alfa = 0.1;
            }
            double Mu2 = ToolsForWork.ComputeCentralMoment(Data.DataForWork[Data.CurrentSample], 2);
            double Mu3 = ToolsForWork.ComputeCentralMoment(Data.DataForWork[Data.CurrentSample], 3);
            double Mu4 = ToolsForWork.ComputeCentralMoment(Data.DataForWork[Data.CurrentSample], 4);
            double Mu5 = ToolsForWork.ComputeCentralMoment(Data.DataForWork[Data.CurrentSample], 5);
            double Mu6 = ToolsForWork.ComputeCentralMoment(Data.DataForWork[Data.CurrentSample], 6);
            double Mu8 = ToolsForWork.ComputeCentralMoment(Data.DataForWork[Data.CurrentSample], 8);
            double beta1 = (Mu3 * Mu3) / (Mu2 * Mu2 * Mu2);
            double beta2 = (Mu4) / (Mu2 * Mu2);
            double beta3 = (Mu3 * Mu5) / (Mu2 * Mu2 * Mu2 * Mu2);
            double beta4 = (Mu6) / (Mu2 * Mu2 * Mu2);
            double beta6 = (Mu8) / (Mu2 * Mu2 * Mu2* Mu2);
            Data.EvalData.KurtosisDev = Math.Sqrt((1.0 / (Data.DataForWork[Data.CurrentSample].Count)) * Math.Abs((beta6 - 4 * beta4 * beta2 - 8 * beta3 + 4 * beta2 * beta2 * beta2 - beta2 * beta2 + 16 * beta2 * beta1 + 16 * beta1)));
            DataGridForEval.Rows[7].Cells[1].Value = Math.Round(Data.EvalData.KurtosisNeZ - Data.EvalData.KurtosisDev * Quantile.StudQuan(1 - alfa / 2, Data.DataForWork[Data.CurrentSample].Count - 1), Data.NumberOfNum);
            DataGridForEval.Rows[7].Cells[3].Value = Math.Round(Data.EvalData.KurtosisNeZ + Data.EvalData.KurtosisDev * Quantile.StudQuan(1 - alfa / 2, Data.DataForWork[Data.CurrentSample].Count - 1), Data.NumberOfNum); 
        }

        private void ComputeBordersForCoV()
        {
            if ((Data.DataForWork[Data.CurrentSample].Count == 1) || (Data.EvalData.ExpValues == 0) || ((string)DataGridForEval.Rows[9].Cells[2].Value == "Не обраховувалося"))
            {
                DataGridForEval.Rows[9].Cells[1].Value = "Не обраховувалося";
                DataGridForEval.Rows[9].Cells[3].Value = "Не обраховувалося";
                return;
            }
            double alfa = 0.1;
            double gamma = 0.9;
            try
            {
                gamma = Convert.ToDouble(DataGridForEval.Rows[9].Cells[4].EditedFormattedValue);
                alfa = 1 - gamma;
            }
            catch (Exception)
            {
                DataGridForEval.Rows[9].Cells[4].Value = "0,9";
                alfa = 0.1;
            }
            if ((alfa <= 0) || (alfa >= 1))
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Хибне значення γ для коефіціенту варіації Пірсона" + Environment.NewLine;
                DataGridForEval.Rows[9].Cells[4].Value = "0,9";
                alfa = 0.1;
            }
            double Nu = Quantile.StanQuanOdn(1 - alfa / 2) / Math.Sqrt(2 * (Data.DataForWork[Data.CurrentSample].Count - 1));
            DataGridForEval.Rows[9].Cells[1].Value = Math.Round(Data.EvalData.CoV / (1 + Nu * Math.Sqrt(1 + 2 * Data.EvalData.CoV * Data.EvalData.CoV)), Data.NumberOfNum);
            DataGridForEval.Rows[9].Cells[3].Value = Math.Round(Data.EvalData.CoV / (1 - Nu * Math.Sqrt(1 + 2 * Data.EvalData.CoV * Data.EvalData.CoV)), Data.NumberOfNum);
        }

        private void ComputeForeseenBorders()
        {
            if (Data.DataForWork[Data.CurrentSample].Count == 1)
            {
                DataGridForEval.Rows[0].Cells[1].Value = "Не обраховувалося";
                DataGridForEval.Rows[0].Cells[3].Value = "Не обраховувалося";
                return;
            }
            double alfa = 0.1;
            double gamma = 0.9;
            try
            {
                gamma = Convert.ToDouble(DataGridForEval.Rows[10].Cells[4].EditedFormattedValue);
                alfa = 1 - gamma;
            }
            catch (Exception)
            {
                DataGridForEval.Rows[10].Cells[4].Value = "0,9";
                alfa = 0.1;
            }
            if ((alfa <= 0) || (alfa >= 1))
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Хибне значення γ для інтервалу передбачення" + Environment.NewLine;
                DataGridForEval.Rows[10].Cells[4].Value = "0,9";
                alfa = 0.1;
            }
            double Dev = Data.EvalData.StandDevZ * Math.Sqrt(1 + 1.0 / Data.DataForWork[Data.CurrentSample].Count);
            DataGridForEval.Rows[10].Cells[1].Value = Math.Round(Data.EvalData.ExpValues - Dev * Quantile.StudQuan(1 - alfa / 2, Data.DataForWork[Data.CurrentSample].Count - 1), Data.NumberOfNum);
            DataGridForEval.Rows[10].Cells[3].Value = Math.Round(Data.EvalData.ExpValues + Dev * Quantile.StudQuan(1 - alfa / 2, Data.DataForWork[Data.CurrentSample].Count - 1), Data.NumberOfNum);
        }

        private void BuildTrunMean()
        {
            double alfa = 0;
            try
            {
                alfa = Convert.ToDouble(DataGridForEval.Rows[2].Cells[4].EditedFormattedValue);
            }
            catch (Exception)
            {
                DataGridForEval.Rows[2].Cells[4].Value = "0,1";
                alfa = 0.1;
            }
            if ((alfa < 0) || (alfa >= 0.5))
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Хибне значення α для усіченого середнього " + Environment.NewLine;
                DataGridForEval.Rows[2].Cells[4].Value = "0,1";
                alfa = 0.1;
            }
            Data.EvalData.TrunMean = ToolsForWork.ComputeTrunMean(Data.DataForWork[Data.CurrentSample], alfa);
            DataGridForEval.Rows[2].Cells[2].Value = "" + Math.Round(Data.EvalData.TrunMean, Data.NumberOfNum);
        }

        private void BuildHistAndDistFunc()
        {
            List<double> Temp = new List<double>();
            for (int i = 0; i < Data.DataForWork[Data.CurrentSample].Count; i++)
            {
                Temp.Add(Data.DataForWork[Data.CurrentSample][i]);
            }
            Temp.Sort();
            if ((Data.DataForWork.Count ==0) ||Temp.Count <= 0)
            {
                LogOutputTextBox.Text += "Theres nothing to do" + Environment.NewLine;
                return;
            }
            HistData.MinLimit =Temp[0] - 0.00001;
            HistData.MaxLimit =Temp[Temp.Count - 1] + 0.00001;
            if(!HistData.NumberOfClassesChangedByUser)
                HistData.NumberOfClasses.set(ToolsForWork.CompNumOfClasses(Temp.Count));
            ////// 
            int[] DataByClasses = new int[(int)HistData.NumberOfClasses];
            for (int i = 0; i < DataByClasses.Length; i++)
            {
                DataByClasses[i] = 0;
            }
            int IndOfRang = 0;
            for (int i = 0; i < Temp.Count; i++)
            {
                while (Temp[i] > (HistData.MinLimit + (IndOfRang + 1) * ((HistData.MaxLimit - HistData.MinLimit) / HistData.NumberOfClasses)))
                {
                    IndOfRang++;
                }
                if (IndOfRang == (int)HistData.NumberOfClasses)
                {
                    DataByClasses[IndOfRang - 1]++;
                }
                else
                {
                    DataByClasses[IndOfRang]++;
                }
            }
            /////
            this.Histogramme.Series[0].CustomProperties = "PointWidth=1";
            HistData.Step = (HistData.MaxLimit - HistData.MinLimit) / (int)HistData.NumberOfClasses;
            this.Histogramme.ChartAreas[0].AxisX.Interval = HistData.Step;
            this.Histogramme.ChartAreas[0].AxisX.Minimum = HistData.MinLimit;
            this.Histogramme.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0.0000}";
            if (Data.Scaled == true)
            {
                this.Histogramme.ChartAreas[0].CursorX.IsUserEnabled = true;
                this.Histogramme.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
                this.Histogramme.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                this.Histogramme.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
                this.Histogramme.ChartAreas[0].CursorY.IsUserEnabled = true;
                this.Histogramme.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
                this.Histogramme.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
                this.Histogramme.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
                this.Histogramme.ChartAreas[0].CursorX.Interval = Math.Abs(Temp[0] - Temp[Temp.Count-1])/200; 
                this.Histogramme.ChartAreas[0].CursorY.Interval = 0.005D; 
            }
            else
            {
                this.Histogramme.ChartAreas[0].CursorX.IsUserEnabled = false;
                this.Histogramme.ChartAreas[0].CursorX.IsUserSelectionEnabled = false;
                this.Histogramme.ChartAreas[0].AxisX.ScaleView.Zoomable = false;
                this.Histogramme.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;
                this.Histogramme.ChartAreas[0].CursorY.IsUserEnabled = false;
                this.Histogramme.ChartAreas[0].CursorY.IsUserSelectionEnabled = false;
                this.Histogramme.ChartAreas[0].AxisY.ScaleView.Zoomable = false;
                this.Histogramme.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = false;
            }
            this.Histogramme.Series[0].Color = Color.FromName((string)HistData.ColorOfHist);
            this.Histogramme.Series[1].Color = Color.FromName((string)HistData.ColorOfTheor);
            //////
            //this.FirstChart.ChartAreas[0].AxisY.Maximum= 1.1;
            this.Histogramme.ChartAreas[0].AxisY.Title = "P(x)";
            this.Histogramme.ChartAreas[0].AxisX.Title = "X";
            //////
            this.Histogramme.Series[1].Points.Clear();
            this.Histogramme.Series[0].Points.Clear();
            this.Histogramme.Series[0].MarkerSize = ToolsForWork.ComputeSizeOfPoint(HistData.NumberOfClasses);/////<----change it 
            this.Histogramme.Series[1].MarkerSize = ToolsForWork.ComputeSizeOfPoint(HistData.NumberOfClasses);
            double LocalCenter;
            double yVal;
            double LocalMin = 0;
            double LocalMax = 0;
            for (int i = 0; i < (int)HistData.NumberOfClasses; i++)
            {
                yVal = (double)DataByClasses[i] / (double)Temp.Count;
                LocalMin = (HistData.MinLimit + HistData.Step * i);
                LocalMax = (HistData.MinLimit + HistData.Step * (i + 1));
                LocalCenter = ((LocalMin + LocalMax) / 2);
                this.Histogramme.Series[0].Points.AddXY(LocalCenter, yVal);
            }
            /////
            if (!DistrFuncData.NumberOfClassesChangedByUser)
                DistrFuncData.NumberOfClasses.set(ToolsForWork.CompNumOfClasses(Temp.Count));
            DistrFuncData.MinLimit = Convert.ToDouble(Temp[0]) - 0.001;
            DistrFuncData.MaxLimit = Convert.ToDouble(Temp[Temp.Count - 1]) + 0.001;
            DistrFuncData.Step = (DistrFuncData.MaxLimit - DistrFuncData.MinLimit) / (int)DistrFuncData.NumberOfClasses;
            this.DistrFun.ChartAreas[0].AxisX.Interval = DistrFuncData.Step;
            this.DistrFun.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(DistrFuncData.MinLimit);
            this.DistrFun.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0.0000}";
            this.DistrFun.Series[0].Color = Color.FromName((string)DistrFuncData.ColorOfClassFunc);
            this.DistrFun.Series[1].Color = Color.FromName((string)DistrFuncData.ColorOfEmpFunc);
            this.DistrFun.Series[0].Points.Clear();
            this.DistrFun.Series[1].Points.Clear();
            this.DistrFun.Series[2].Points.Clear();
            this.DistrFun.Series[3].Points.Clear();
            this.DistrFun.Series[4].Points.Clear();
            if (Data.Scaled == true)
            {
                this.DistrFun.ChartAreas[0].CursorX.IsUserEnabled = true;
                this.DistrFun.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
                this.DistrFun.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                this.DistrFun.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
                this.DistrFun.ChartAreas[0].CursorY.IsUserEnabled = true;
                this.DistrFun.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
                this.DistrFun.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
                this.DistrFun.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
            }
            else
            {
                this.DistrFun.ChartAreas[0].CursorX.IsUserEnabled = false;
                this.DistrFun.ChartAreas[0].CursorX.IsUserSelectionEnabled = false;
                this.DistrFun.ChartAreas[0].AxisX.ScaleView.Zoomable = false;
                this.DistrFun.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;
                this.DistrFun.ChartAreas[0].CursorY.IsUserEnabled = false;
                this.DistrFun.ChartAreas[0].CursorY.IsUserSelectionEnabled = false;
                this.DistrFun.ChartAreas[0].AxisY.ScaleView.Zoomable = false;
                this.DistrFun.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = false;
                this.DistrFun.ChartAreas[0].CursorX.Interval = Math.Abs(Temp[0] - Temp[Temp.Count - 1]) / 200;
                this.DistrFun.ChartAreas[0].CursorY.Interval = 0.005D; 
            }
            this.DistrFun.Series[0].MarkerSize = ToolsForWork.ComputeSizeOfPoint(DistrFuncData.NumberOfClasses)+1;
            this.DistrFun.Series[1].MarkerSize = ToolsForWork.ComputeSizeOfPoint(DistrFuncData.NumberOfClasses);
            this.DistrFun.Series[2].MarkerSize = ToolsForWork.ComputeSizeOfPoint(DistrFuncData.NumberOfClasses);
            this.DistrFun.Series[3].MarkerSize = ToolsForWork.ComputeSizeOfPoint(DistrFuncData.NumberOfClasses);
            this.DistrFun.Series[4].MarkerSize = ToolsForWork.ComputeSizeOfPoint(DistrFuncData.NumberOfClasses);
            double AlreadyCounted = 0;
            DataByClasses = new int[(int)DistrFuncData.NumberOfClasses];
            for (int i = 0; i < DataByClasses.Length; i++)
            {
                DataByClasses[i] = 0;
            }
            IndOfRang = 0;
            for (int i = 0; i < Temp.Count; i++)
            {
                while (Convert.ToDouble(Temp[i]) > (DistrFuncData.MinLimit + (IndOfRang + 1) * ((DistrFuncData.MaxLimit - DistrFuncData.MinLimit) / DistrFuncData.NumberOfClasses)))
                {
                    IndOfRang++;
                }
                if (IndOfRang == (int)DistrFuncData.NumberOfClasses)
                {
                    DataByClasses[IndOfRang - 1]++;
                }
                else
                {
                    DataByClasses[IndOfRang]++;
                }
            }
            for (int i = 0; i < DistrFuncData.NumberOfClasses; i++)
            {
                yVal = (double)DataByClasses[i] / (double)Temp.Count;
                //LogOutputTextBox.Text += "loh " + yVal + Environment.NewLine;
                LocalMin = (DistrFuncData.MinLimit + DistrFuncData.Step * i);
                LocalMax = (DistrFuncData.MinLimit + DistrFuncData.Step * (i + 1));
                AlreadyCounted += yVal;
                for (LocalCenter = LocalMin; LocalCenter < LocalMax; LocalCenter += (LocalMax - LocalMin) / 100)
                {
                    this.DistrFun.Series[0].Points.AddXY(LocalCenter, AlreadyCounted);
                }
            }
            AlreadyCounted = 0;
            DistrFuncData.DistrFunction = new double[Temp.Count];
            int CountOFSame = 0;
            for (int i = 0; i < Temp.Count; i += CountOFSame)
            {
                CountOFSame = 1;
                for (int j = i + 1; j < Temp.Count; j++)
                {
                    if (Convert.ToDouble(Temp[i]) == Convert.ToDouble(Temp[j]))
                    {
                        CountOFSame++;
                    }
                    else
                    {
                        break;
                    }
                }
                yVal = ((double)CountOFSame) / Temp.Count;
                AlreadyCounted += yVal;
                for (int j = i; j < i + CountOFSame; j++)
                {
                    DistrFuncData.DistrFunction[j] = AlreadyCounted;
                }
                this.DistrFun.Series[1].Points.AddXY(Convert.ToDouble(Temp[i]), AlreadyCounted);
            }
            Histogramme.Invalidate();
            DistrFun.Invalidate();
        }

        private void BuildMultiDem()
        {
            if (Data.MultiDemSamples.Count <= 0)
            {
                chart5.Series[0].Points.Clear();
                dataGridView13.Rows.Clear();
                dataGridView12.Rows.Clear();
                dataGridView5.Rows.Clear();
                dataGridView6.Rows.Clear();
                dataGridView5.Columns.Clear();
                dataGridView6.Columns.Clear();
                dataGridView7.Columns.Clear();
                dataGridView7.Rows.Clear();
                dataGridView8.Rows.Clear();
                dataGridView8.Columns.Clear();
                dataGridView9.Rows.Clear();
                dataGridView9.Columns.Clear();
                tableLayoutPanel1.ColumnStyles.Clear();
                tableLayoutPanel1.RowStyles.Clear();
                tableLayoutPanel1.Controls.Clear();
                comboBox4.Items.Clear();
                pictureBox1.Image = null;
                DataGridForChkk = null;
                return;
            }
            dataGridView8.Rows.Clear();
            dataGridView8.Columns.Clear();
            dataGridView9.Rows.Clear();
            dataGridView9.Columns.Clear();
            comboBox4.Items.Clear();
            DataGridForChkk = null;
            pictureBox1.Image = null;
            dataGridView7.Rows.Clear();
            chart5.Series[0].Points.Clear();
            dataGridView13.Rows.Clear();
            dataGridView12.Rows.Clear();
            dataGridView7.Columns.Clear();
            int i, j, k;
            dataGridView7.Columns.Add(new DataGridViewTextBoxColumn());
            dataGridView7.Columns.Add(new DataGridViewTextBoxColumn());
            dataGridView7.Columns[0].ReadOnly = true;
            dataGridView7.Columns[1].ReadOnly = true;
            dataGridView7.Columns[0].HeaderText = "Math expectation";
            dataGridView7.Columns[1].HeaderText = "Standart deviation";
            dataGridView7.Columns.Add(new DataGridViewTextBoxColumn());
            dataGridView7.Columns.Add(new DataGridViewTextBoxColumn());
            dataGridView7.Columns[2].ReadOnly = true;
            dataGridView7.Columns[3].ReadOnly = true;
            dataGridView7.Columns[2].HeaderText = "Standart deviation of math expectation";
            dataGridView7.Columns[3].HeaderText = "Standart deviation of standart deviation";
            double Summ;
            double[] tempExp = new double[Data.MultiDemSamples[Data.MultiDemCurrentSample].Length];
            double[] Temps = new double[Data.MultiDemSamples[Data.MultiDemCurrentSample].Length];
            double[,] Tempkk = new double[Data.MultiDemSamples[Data.MultiDemCurrentSample].Length, Data.MultiDemSamples[Data.MultiDemCurrentSample].Length];
            int NumOfPoints = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count;//Number of points in each sample
            for (i = 0; i < Data.MultiDemSamples[Data.MultiDemCurrentSample].Length; i++)
            {
                dataGridView7.Rows.Add();
                Summ = 0;
                for (j = 0; j < NumOfPoints; j++)
                {
                    Summ += Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][i]][j];
                }
                dataGridView7.Rows[i].Cells[0].Value = Math.Round((tempExp[i] = Summ / NumOfPoints), Data.NumberOfNum);
                Temps[i] = 0;
                for (j = 0; j < NumOfPoints; j++)
                {
                    Temps[i] += Math.Pow((Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][i]][j] - tempExp[i]), 2);
                }
                Temps[i] *= (1.0) / (NumOfPoints - 1);
                Temps[i] = (Math.Sqrt(Temps[i]));
                dataGridView7.Rows[i].Cells[1].Value = Math.Round(Temps[i], Data.NumberOfNum);
                dataGridView7.Rows[i].Cells[2].Value = Math.Round(Temps[i] / Math.Sqrt(NumOfPoints), Data.NumberOfNum);
                dataGridView7.Rows[i].Cells[3].Value = Math.Round(Temps[i] / Math.Sqrt(2 * NumOfPoints), Data.NumberOfNum);
            }
            /*
             * double CrosSum = 0;
                for (i = 0; i < Temp1.Count; i++)
                {
                    CrosSum += Temp1[i] * Temp2[i];
                }
                CrosSum /= Temp1.Count;
                KK = ((double)Temp1.Count / (Temp1.Count - 1)) * ((CrosSum - Xexp * Yexp) / (StX * StY));
                dataGridView1.Rows[5].Cells[2].Value = "" + Math.Round(KK, Data.NumberOfNum);
             * */

            dataGridView5.Columns.Clear();
            dataGridView6.Columns.Clear();
            dataGridView5.Rows.Clear();
            dataGridView6.Rows.Clear();
            int DimNumber = Data.MultiDemSamples[Data.MultiDemCurrentSample].Length;
            for (i = 0; i < DimNumber; i++)
            {
                dataGridView12.Rows.Add(""+(i+1),"");
            }
                for (i = 0; i < DimNumber; i++)
                {
                    dataGridView5.Columns.Add(new DataGridViewTextBoxColumn());
                    dataGridView6.Columns.Add(new DataGridViewTextBoxColumn());
                }
            for (j = 0; j < DimNumber; j++)
            {
                dataGridView5.Rows.Add();
                dataGridView6.Rows.Add();
            }
            double TempSum = 0;
            for (i = 0; i < DimNumber; i++)
            {
                for (j = 0; j < DimNumber; j++)
                {
                    if (i == j)
                    {
                        Tempkk[i, j] = 1;
                        continue;
                    }
                    TempSum = 0;
                    for (k = 0; k < NumOfPoints; k++)
                    {
                        TempSum += Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][i]][k] * Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][j]][k];
                    }
                    TempSum /= NumOfPoints;
                    Tempkk[i, j] = (NumOfPoints * (TempSum - tempExp[i] * tempExp[j])) / ((NumOfPoints - 1) * (Temps[i] * Temps[j]));
                }
            }

            for (i = 0; i < DimNumber; i++)
            {
                for (j = 0; j < DimNumber; j++)
                {
                    dataGridView6.Rows[i].Cells[j].Value = Math.Round(Tempkk[i, j], Data.NumberOfNum);
                    dataGridView5.Rows[i].Cells[j].Value = Math.Round(Tempkk[i, j] * Temps[i] * Temps[j], Data.NumberOfNum);
                }
            }

            ///////Visualization chart matrix
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.Controls.Clear();
            // tableLayoutPanel1.RowCount = 0;
            //tableLayoutPanel1.ColumnCount = 0;
            if (checkBox3.Checked)
            {
                if ((DimNumber < 15) && (checkBox4.Checked || DimNumber < 7))
                {
                    tableLayoutPanel1.RowCount = DimNumber;
                    tableLayoutPanel1.ColumnCount = DimNumber;
                    for (i = 0; i < DimNumber; i++)
                    {
                        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / (DimNumber)));
                        tableLayoutPanel1.RowStyles.Add(new ColumnStyle(SizeType.Percent, 100f / (DimNumber)));
                    }
                    for (i = 0; i < DimNumber; i++)
                    {
                        for (j = 0; j < DimNumber; j++)
                        {
                            System.Windows.Forms.DataVisualization.Charting.Chart TempChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
                            if (i == j)
                            {
                                System.Windows.Forms.DataVisualization.Charting.Series TempSer = new System.Windows.Forms.DataVisualization.Charting.Series();
                                TempSer.ChartArea = "ChartArea1";
                                TempSer.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                                TempSer.MarkerSize = 4;
                                System.Windows.Forms.DataVisualization.Charting.ChartArea TempCA = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
                                if (checkBox7.Checked == false)
                                {
                                    TempCA.Axes[0].LabelStyle.Enabled = false;
                                    TempCA.Axes[1].LabelStyle.Enabled = false;
                                }
                                else
                                {
                                    TempCA.Axes[0].LabelStyle.Enabled = true;
                                    TempCA.Axes[1].LabelStyle.Enabled = true;
                                }
                                TempChart.Series.Add(TempSer);
                                TempChart.ChartAreas.Add(TempCA);
                                /////
                                TempChart.Series[0].CustomProperties = "PointWidth=1";
                                //this.chart1.ChartAreas[0].AxisX.Interval = Tem;
                                //this.chart1.ChartAreas[0].AxisX.Minimum = HistData.MinLimit;
                                //this.chart1.ChartAreas[0].AxisY.Interval = HistData.Step;
                                //this.chart1.ChartAreas[0].AxisY.Minimum = HistData.MinLimit;
                                if (DimNumber >= 4)
                                {
                                    TempChart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
                                    TempChart.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
                                }
                                else
                                {
                                    TempChart.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0.0000}";
                                    TempChart.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0.0000}";
                                }
                                List<double> Temp = new List<double>();
                                double MaxL = double.MinValue, MinL = double.MaxValue;
                                for (k = 0; k < Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][i]].Count; k++)
                                {
                                    Temp.Add(Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][i]][k]);
                                    if (Temp[k] < MinL)
                                    {
                                        MinL = Temp[k];
                                    }
                                    if (Temp[k] > MaxL)
                                    {
                                        MaxL = Temp[k];
                                    }
                                }
                                Temp.Sort();
                                if ((Data.DataForWork.Count == 0) || Temp.Count <= 0)
                                {
                                    LogOutputTextBox.Text += "Theres nothing to do" + Environment.NewLine;
                                    return;
                                }
                                if (!HistData.NumberOfClassesChangedByUser)
                                    HistData.NumberOfClasses.set(ToolsForWork.CompNumOfClasses(Temp.Count));
                                ////// 
                                int[] DataByClasses = new int[(int)HistData.NumberOfClasses];
                                for (k = 0; k < DataByClasses.Length; k++)
                                {
                                    DataByClasses[k] = 0;
                                }
                                int IndOfRang = 0;
                                for (k = 0; k < Temp.Count; k++)
                                {
                                    while (Temp[k] > (MinL + (IndOfRang + 1) * ((MaxL - MinL) / HistData.NumberOfClasses)))
                                    {
                                        IndOfRang++;
                                    }
                                    if (IndOfRang == (int)HistData.NumberOfClasses)
                                    {
                                        DataByClasses[IndOfRang - 1]++;
                                    }
                                    else
                                    {
                                        DataByClasses[IndOfRang]++;
                                    }
                                }
                                /////
                                TempSer.CustomProperties = "PointWidth=1";
                                double Lstep = (MaxL - MinL) / (int)HistData.NumberOfClasses;

                                TempSer.Color = Color.FromName((string)HistData.ColorOfHist);
                                //////
                                //this.FirstChart.ChartAreas[0].AxisY.Maximum= 1.1;
                                //////
                                TempSer.Points.Clear();
                                double LocalCenter;
                                double yVal;
                                double LocalMin = 0;
                                double LocalMax = 0;
                                for (k = 0; k < (int)HistData.NumberOfClasses; k++)
                                {
                                    yVal = (double)DataByClasses[k] / (double)Temp.Count;
                                    LocalMin = (MinL + Lstep * k);
                                    LocalMax = (MinL + Lstep * (k + 1));
                                    LocalCenter = ((LocalMin + LocalMax) / 2);
                                    TempSer.Points.AddXY(LocalCenter, yVal);
                                }
                            }
                            else
                            {
                                double MaxLX = double.MinValue, MinLX = double.MaxValue;
                                double MaxLY = double.MinValue, MinLY = double.MaxValue;
                                System.Windows.Forms.DataVisualization.Charting.Series TempSer = new System.Windows.Forms.DataVisualization.Charting.Series();
                                TempSer.ChartArea = "ChartArea1";
                                TempSer.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                                TempSer.BorderColor = Color.Black;
                                TempSer.MarkerSize = 4;
                                System.Windows.Forms.DataVisualization.Charting.ChartArea TempCA = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
                                if (checkBox7.Checked == false)
                                {
                                    TempCA.Axes[0].LabelStyle.Enabled = false;
                                    TempCA.Axes[1].LabelStyle.Enabled = false;
                                }
                                else
                                {
                                    TempCA.Axes[0].LabelStyle.Enabled = true;
                                    TempCA.Axes[1].LabelStyle.Enabled = true;
                                }
                                TempChart.Series.Add(TempSer);
                                TempChart.ChartAreas.Add(TempCA);
                                /////
                                TempChart.Series[0].CustomProperties = "PointWidth=1";
                                //this.chart1.ChartAreas[0].AxisX.Interval = Tem;
                                //this.chart1.ChartAreas[0].AxisX.Minimum = HistData.MinLimit;
                                //this.chart1.ChartAreas[0].AxisY.Interval = HistData.Step;
                                //this.chart1.ChartAreas[0].AxisY.Minimum = HistData.MinLimit;
                                if (DimNumber >= 4)
                                {
                                    TempChart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
                                    TempChart.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
                                }
                                else
                                {
                                    TempChart.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0.0000}";
                                    TempChart.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0.0000}";
                                }
                                // TempChart.ChartAreas[0].AxisY.Title = "Y";
                                // TempChart.ChartAreas[0].AxisX.Title = "X";   
                                //////
                                ////
                                // TempChart.ChartAreas[0].AxisX.Interval = (int)((MaxX - MinX) / CountX);
                                //TempChart.ChartAreas[0].AxisX.Minimum = MinX;
                                //TempChart.ChartAreas[0].AxisY.Interval = (int)((MaxY - MinY) / CountY);
                                //TempChart.ChartAreas[0].AxisY.Minimum = MinY;
                                //double maxP = 0;
                                for (k = 0; k < NumOfPoints; k++)
                                {
                                    if (Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][i]][k] < MinLX)
                                    {
                                        MinLX = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][i]][k];
                                    }
                                    if (Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][i]][k] > MaxLX)
                                    {
                                        MaxLX = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][i]][k];
                                    }
                                    if (Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][j]][k] < MinLY)
                                    {
                                        MinLY = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][j]][k];
                                    }
                                    if (Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][j]][k] > MaxLY)
                                    {
                                        MaxLY = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][j]][k];
                                    }
                                    TempChart.Series[0].Points.AddXY(Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][i]][k], Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][j]][k]);
                                }
                                TempChart.ChartAreas[0].AxisX.Maximum = MaxLX;
                                TempChart.ChartAreas[0].AxisX.Minimum = MinLX;
                                TempChart.ChartAreas[0].AxisY.Maximum = MaxLY;
                                TempChart.ChartAreas[0].AxisY.Minimum = MinLY;

                            }
                            tableLayoutPanel1.Controls.Add(TempChart, i, j);
                        }
                    }
                }
            }  
            ////////working with table for deliting data
            dataGridView8.Columns.Clear();
            dataGridView8.Rows.Clear();
            if (Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count <= 9999)
            {
                for (i = 0; i <= DimNumber; i++)
                {
                    dataGridView8.Columns.Add(new DataGridViewTextBoxColumn());

                }
                dataGridView8.Columns[DimNumber].Visible = false;
                dataGridView8.Columns[DimNumber].ReadOnly = true;
                for (i = 0; i < Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count; i++)
                {
                    dataGridView8.Rows.Add();
                    for (j = 0; j < DimNumber; j++)
                    {
                        dataGridView8.Rows[i].Cells[j].Value = Math.Round(Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][j]][i], Data.NumberOfNum);
                    }
                    dataGridView8.Rows[i].Cells[DimNumber].Value = i;
                }
            }

            ///////was working with kk

            double[, ,] Chkk = new double[DimNumber, DimNumber, DimNumber];
            DataGridForChkk = new DataGridView[DimNumber];
            double Hip;
            double result, quan;
            comboBox4.Items.Clear();
            for (i = 0; i < DimNumber; i++)
            {
                DataGridForChkk[i] = new DataGridView();
                DataGridForChkk[i].AllowUserToAddRows = false;
                DataGridForChkk[i].AllowUserToDeleteRows = false;
                DataGridForChkk[i].AllowUserToOrderColumns = false;
                for (j = 0; j < DimNumber; j++)
                {
                    DataGridForChkk[i].Columns.Add(new DataGridViewTextBoxColumn());
                    DataGridForChkk[i].Columns[j].HeaderCell.Value = "" + j;
                    DataGridForChkk[i].Columns[j].ReadOnly = true;
                }
                for (j = 0; j < DimNumber; j++)
                {
                    DataGridForChkk[i].Rows.Add();
                }
                for (k = 0; k < DimNumber; k++)
                {
                    for (j = 0; j < DimNumber; j++)
                    {
                        if (k == i || j == i)
                        {
                            DataGridForChkk[i].Rows[k].Cells[j].Value = "-";
                            continue;
                        }
                        if (k == j)
                        {
                            DataGridForChkk[i].Rows[k].Cells[k].Value = "1";
                            continue;
                        }
                        else
                        {
                            List<int> Temp = new List<int>();
                            Temp.Add(i);
                            result = FindChkk(j, k, Temp);
                            DataGridForChkk[i].Rows[k].Cells[j].Value = "" + Math.Round(result, Data.NumberOfNum);
                            quan = Quantile.StudQuan(0.95, Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count - Temp.Count - 2);
                            if (radioButton7.Checked)
                            {
                                Hip = (result * Math.Sqrt(Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count - Temp.Count - 2)) / (1 - result * result);
                                if (Math.Abs(Hip) < quan)
                                {
                                    DataGridForChkk[i].Rows[k].Cells[j].Style.BackColor = Color.DarkGray;
                                }
                                else
                                {
                                    DataGridForChkk[i].Rows[k].Cells[j].Style.BackColor = Color.White;
                                }
                            }
                            else
                            {
                                Hip = ((result - Convert.ToDouble(dataGridView6.Rows[k].Cells[j].Value)) * Math.Sqrt(Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count - Temp.Count - 2)) / (1 - result * result);
                                if (Math.Abs(Hip) < quan)
                                {
                                    DataGridForChkk[i].Rows[k].Cells[j].Style.BackColor = Color.DarkGray;
                                }
                                else
                                {
                                    DataGridForChkk[i].Rows[k].Cells[j].Style.BackColor = Color.White;
                                }
                            }

                        }
                    }
                }
                comboBox4.Items.Add("" + (i + 1));

            }
            ToolsForWork.FillDGVText(dataGridView9, DataGridForChkk[0]);
            this.Invalidate();
            /////// MKK
            dataGridView11.Rows.Clear();
            double[][] TempR = new double[DimNumber][];
            for (i = 0; i < DimNumber; i++)
            {
                TempR[i] = new double[DimNumber];
            }
            for (i = 0; i < DimNumber; i++)
            {
                for (j = 0; j < DimNumber; j++)
                {
                    TempR[i][j] = Tempkk[i, j];
                }
            }
            for (i = 0; i < DimNumber; i++)
            {
                result = Math.Sqrt(1 - Matrixes.GetDet(TempR) / Matrixes.GetDet(Matrixes.GetMinor(TempR, i, i)));
                dataGridView11.Rows.Add();
                dataGridView11.Rows[i].Cells[0].Value = "" + Math.Round(result, Data.NumberOfNum);
                Hip = ((Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count - DimNumber - 1d) / (DimNumber)) * ((result * result) / (1 - result * result));
                if (Hip <= Quantile.FishQuan(0.95, DimNumber, Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count - DimNumber - 1))
                {
                    dataGridView11.Rows[i].Cells[1].Style.BackColor = Color.DarkGray;
                    dataGridView11.Rows[i].Cells[1].Value = "ні";
                }
                else
                {
                    dataGridView11.Rows[i].Cells[1].Style.BackColor = Color.LightGreen;
                    dataGridView11.Rows[i].Cells[1].Value = "так";
                }

            }
            ///////
            //dataGridView9.Rows.Add();
            //  dataGridView9.Rows[0].Cells[0];

            ////////Parallel coor
            chart4.Series.Clear();
            if (checkBox5.Checked)
            {
                if (Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count > 4000)
                {
                    return;

                }
                if (DimNumber > 2000 && !checkBox6.Checked)
                {
                    return;
                }
                chart4.ChartAreas[0].AxisX.Maximum = DimNumber;
                chart4.ChartAreas[0].AxisX.Minimum = 1;
                chart4.ChartAreas[0].AxisY.Maximum = 1;
                chart4.ChartAreas[0].AxisY.Minimum = -1;
                List<double>[] TempLists = new List<double>[DimNumber];
                int[,] Lims = new int[DimNumber, 2];
                for (i = 0; i < DimNumber; i++)
                {
                    TempLists[i] = new List<double>();
                }
                for (i = 0; i < Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count; i++)
                {
                    for (j = 0; j < DimNumber; j++)
                    {
                        TempLists[j].Add(Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][j]][i]);
                    }
                }
                double[,] MinMaxVals = new double[DimNumber, 2];
                for (i = 0; i < DimNumber; i++)
                {
                    MinMaxVals[i, 0] = double.MaxValue;
                    MinMaxVals[i, 1] = double.MinValue;
                }
                for (i = 0; i < Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count; i++)
                {
                    for (j = 0; j < DimNumber; j++)
                    {
                        if (TempLists[j][i] < MinMaxVals[j, 0])
                        {
                            MinMaxVals[j, 0] = TempLists[j][i];
                        }
                        if (TempLists[j][i] > MinMaxVals[j, 1])
                        {
                            MinMaxVals[j, 1] = TempLists[j][i];
                        }
                    }
                }
                for (i = 0; i < Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count; i++)
                {
                    for (j = 0; j < DimNumber; j++)
                    {
                        TempLists[j][i] -= (MinMaxVals[j, 0] + MinMaxVals[j, 1]) / 2;
                        TempLists[j][i] /= (MinMaxVals[j, 0] - MinMaxVals[j, 1]) / (-2);
                    }
                }
                for (i = 0; i < Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count; i++)
                {
                    System.Windows.Forms.DataVisualization.Charting.Series temp = new System.Windows.Forms.DataVisualization.Charting.Series();
                    temp.ChartArea = "ChartArea1";
                    temp.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    temp.Color = System.Drawing.Color.Black;
                    temp.CustomProperties = "LabelStyle=Top";
                    for (j = 0; j < DimNumber; j++)
                    {
                        temp.Points.Add(TempLists[j][i]);
                    }
                    chart4.Series.Add(temp);
                }
            }
            /////bubble
            if (checkBox9.Checked)
            {
                BuildBubble();
            }
            ////heatmap
            if (checkBox8.Checked)
            {
                List<double>[] TempLists = new List<double>[DimNumber];
                int[,] Lims = new int[DimNumber, 2];
                for (i = 0; i < DimNumber; i++)
                {
                    TempLists[i] = new List<double>();
                }
                for (i = 0; i < Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count; i++)
                {
                    for (j = 0; j < DimNumber; j++)
                    {
                        TempLists[j].Add(Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][j]][i]);
                    }
                }
                double[,] MinMaxVals = new double[DimNumber, 2];
                for (i = 0; i < DimNumber; i++)
                {
                    MinMaxVals[i, 0] = double.MaxValue;
                    MinMaxVals[i, 1] = double.MinValue;
                }
                for (i = 0; i < Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count; i++)
                {
                    for (j = 0; j < DimNumber; j++)
                    {
                        if (TempLists[j][i] < MinMaxVals[j, 0])
                        {
                            MinMaxVals[j, 0] = TempLists[j][i];
                        }
                        if (TempLists[j][i] > MinMaxVals[j, 1])
                        {
                            MinMaxVals[j, 1] = TempLists[j][i];
                        }
                    }
                }
                for (i = 0; i < Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count; i++)
                {
                    for (j = 0; j < DimNumber; j++)
                    {
                        TempLists[j][i] -= (MinMaxVals[j, 0] + MinMaxVals[j, 1]) / 2;
                        TempLists[j][i] /= (MinMaxVals[j, 0] - MinMaxVals[j, 1]) / (-2);
                    }
                }
                //////
                Bitmap MyMap = new Bitmap(NumOfPoints * 32, DimNumber * 64, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                Bitmap TempIm = new Bitmap(32, 64, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                Graphics G = Graphics.FromImage(MyMap);
                Graphics TempG = Graphics.FromImage(TempIm);
                Pen BlackPen = new Pen(Color.Black, 1);
                int TempRead = 0;
                for (i = 0; i < DimNumber; i++)
                {
                    for (j = 0; j < NumOfPoints; j++)
                    {
                        TempRead = (int)(((TempLists[i][j] + 1) * 255d) / 2);
                        TempG.Clear(Color.FromArgb(TempRead, TempRead, 0));
                        TempG.DrawRectangle(BlackPen, 0, 0, TempIm.Width, TempIm.Height);
                        G.DrawImage(TempIm, j * 32, i * 64);
                    }
                }
                if (NumOfPoints > 150)
                {
                    pictureBox1.Width = (int)(919 * (1 + 0.01 * Math.Pow(NumOfPoints - 150, 2d / 3)));
                }
                else
                {
                    pictureBox1.Width = 919;
                }
                pictureBox1.Image = MyMap;

            }
            double[,] TempDC = new double[Tempkk.GetLength(0), Tempkk.GetLength(0)];
            for (i = 0; i < Tempkk.GetLength(0); i++ )
            {
                for (j = 0; j < Tempkk.GetLength(0);j++)
                {
                    TempDC[i, j] = Tempkk[i, j] * Temps[i] * Temps[j];
                }
            }
            double[, ,] lil = ToolsForWork.GetEileganValues(TempDC, 0.001);
            Console.WriteLine();
        }

        double FindChkk(int r1, int r2, List<int> Vals)
        {
            if (Vals.Count == 1)
            {
                return (Convert.ToDouble(dataGridView6.Rows[r1].Cells[r2].Value) - Convert.ToDouble(dataGridView6.Rows[r1].Cells[Vals[0]].Value) * Convert.ToDouble(dataGridView6.Rows[Vals[0]].Cells[r2].Value)) / (Math.Sqrt((1 - Convert.ToDouble(dataGridView6.Rows[Vals[0]].Cells[r2].Value) * Convert.ToDouble(dataGridView6.Rows[Vals[0]].Cells[r2].Value)) * (1 - Convert.ToDouble(dataGridView6.Rows[r1].Cells[Vals[0]].Value) * Convert.ToDouble(dataGridView6.Rows[r1].Cells[Vals[0]].Value))));
            }
            else
            {
                List<int> Temp1 = new List<int>();
                for (int i = 1; i < Vals.Count; i++)
                {
                    Temp1.Add(Vals[i]);
                }
                return (FindChkk(r1, r2, Temp1) - FindChkk(r1, Vals[0], Temp1) * FindChkk(r2, Vals[0], Temp1)) / (Math.Sqrt((1 - FindChkk(r1, Vals[0], Temp1) * FindChkk(r1, Vals[0], Temp1)) * (1 - FindChkk(r2, Vals[0], Temp1) * FindChkk(r2, Vals[0], Temp1))));
            }
        }

		private void BuildTwoDem()
		{
			this.chart1.Series[0].Points.Clear();
			this.chart2.Series[10].Points.Clear();
			this.chart1.Series[1].Points.Clear();
			this.chart1.Series[2].Points.Clear();
			this.chart1.Series[3].Points.Clear();
			this.chart1.Series[4].Points.Clear();
			this.chart1.Series[5].Points.Clear();
			this.chart1.Series[6].Points.Clear();
			this.chart1.Series[7].Points.Clear();
			this.chart1.Series[8].Points.Clear();
			this.dataGridView1.Rows.Clear();
			this.dataGridView2.Rows.Clear();
			this.dataGridView4.Rows.Clear();
			this.dataGridView3.Rows.Clear();
			chart2.ChartAreas[0].BackImage = "";
			/*   if (File.Exists(Application.StartupPath + "\\" + "TempFileDontTouch.png"))
			   {
				   FileStream MFS = File.OpenRead(Application.StartupPath + "\\" + "TempFileDontTouch.png");
				   MFS.Dispose();
				   MFS.Close();
				   //File.Delete(Application.StartupPath + "\\" + "TempFileDontTouch.png");
			   }*/
			LogOutputTextBox.Text += "Theres nothing to do" + Environment.NewLine;
			dataGridView1.Rows.Add("Мат. сподівання X", "", "", "", "", "---");
			dataGridView1.Rows.Add("Мат. сподівання Y", "", "", "", "", "---");
			dataGridView1.Rows.Add("Стандартне відхилення X", "", "", "", "", "");
			dataGridView1.Rows.Add("Стандартне відхилення Y", "", "", "", "", "");
			dataGridView1.Rows.Add("Оцінка адекватності відтворення нормального розподілу", "---", "", "---", "", "");
			dataGridView1.Rows.Add("Коефіціент кореляції", "", "", "", "", "");
			dataGridView1.Rows.Add("Кореляційне відношення по X", "", "", "", "", "---");
			dataGridView1.Rows.Add("Кореляційне відношення по Y", "", "", "", "", "---");
			dataGridView1.Rows.Add("Р.к.к. Спірмена", "", "", "", "", "---");
			dataGridView1.Rows.Add("Р.к.к. Кендалла", "", "", "", "", "---");
			dataGridView2.Rows.Add("Індекс Фехнера", "", "---", "---");
			dataGridView2.Rows.Add("Коефіціент сполучень Φ", "", "", "");
			dataGridView2.Rows.Add("Коефіціент зв'язку Юла Q", "", "", "");
			dataGridView2.Rows.Add("Коефіціент зв'язку Юла Y", "", "", "");
			dataGridView4.Rows.Add("Коефіціент сполучень Пірсона", "");
			dataGridView4.Rows.Add("Мір звяззку Кендалла", "");
			dataGridView4.Rows.Add("Статистика Стюарда", "");
			if (Data.TwoDemSamples.Count <= 0)
			{
				return;
			}
			chart2.ChartAreas[0].BackImage = "";
			/*if (File.Exists(Application.StartupPath + "\\" + "TempFileDontTouch.png"))
            {
              FileStream MFS = File.OpenRead(Application.StartupPath + "\\" + "TempFileDontTouch.png");
              MFS.Dispose();
              MFS.Close();
             // File.Delete(Application.StartupPath + "\\" + "TempFileDontTouch.png");
            }*/
			int i, j, k;
			List<double> Temp1 = new List<double>(), Temp2 = new List<double>();
			dataGridView3.Rows.Clear();
			for (i = 0; i < Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].Count; i++)
			{
				Temp1.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]][i]);
				Temp2.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][1]][i]);
			}
			if (Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].Count < 10000)
			{
				for (i = 0; i < Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].Count; i++)
				{
					dataGridView3.Rows.Add(Math.Round(Temp1[i], Data.NumberOfNum), Math.Round(Temp2[i], Data.NumberOfNum), Temp1[i], Temp2[i], i);
				}
			}
			int CountX = ToolsForWork.CompNumOfClasses(Temp1.Count), CountY = ToolsForWork.CompNumOfClasses(Temp2.Count);
			double MaxX = double.MinValue, MaxY = double.MinValue, MinX = double.MaxValue, MinY = double.MaxValue;
			PictureBox[,] Hist = new PictureBox[CountX, CountY];
			for (i = 0; i < Temp1.Count; i++)
			{
				if (Temp1[i] < MinX)
				{
					MinX = Temp1[i];
				}
				if (Temp2[i] < MinY)
				{
					MinY = Temp2[i];
				}
				if (Temp1[i] > MaxX)
				{
					MaxX = Temp1[i];
				}
				if (Temp2[i] > MaxY)
				{
					MaxY = Temp2[i];
				}
			}
			//////////////
			double Xexp, Yexp, StX, StY, KK, Kvx, Kvy, Ts, Tk;
			{
				double Sum1 = 0;
				double Sum2 = 0;
				for (i = 0; i < Temp1.Count; i++)
				{
					Sum1 += Temp1[i];
					Sum2 += Temp2[i];
				}
				Xexp = Sum1 / Temp1.Count;
				Yexp = Sum2 / Temp1.Count;
				dataGridView1.Rows[0].Cells[2].Value = "" + Math.Round(Xexp, Data.NumberOfNum);
				dataGridView1.Rows[1].Cells[2].Value = "" + Math.Round(Yexp, Data.NumberOfNum);
				if (Math.Abs(Data.EvalData.ExpValues) < 0.00000000001)
				{
					Data.EvalData.ExpValues = 0;
				}
			}
			{
				{
					StX = 0; StY = 0;
					for (i = 0; i < Temp1.Count; i++)
					{
						// Data.EvalData.StandDevZ += Data.DataForWork[Data.CurrentSample][i] * Data.DataForWork[Data.CurrentSample][i] - Data.EvalData.ExpValues * Data.EvalData.ExpValues;
						StX += Math.Pow((Temp1[i] - Xexp), 2);
						StY += Math.Pow((Temp2[i] - Yexp), 2);
					}
					// Data.EvalData.StandDevZ *= (1.0) / Data.DataForWork[Data.CurrentSample].Count;
					StX *= (1.0) / (Temp1.Count - 1);
					StY *= (1.0) / (Temp2.Count - 1);
					//Data.EvalData.StandDevZ = (Math.Sqrt(Data.EvalData.StandDevZ));
					StX = (Math.Sqrt(StX));
					StY = (Math.Sqrt(StY));
					dataGridView1.Rows[2].Cells[2].Value = "" + Math.Round(StX, Data.NumberOfNum);
					dataGridView1.Rows[3].Cells[2].Value = "" + Math.Round(StY, Data.NumberOfNum);
				}
			}
			double CrosSum;
			{
				CrosSum = 0;
				for (i = 0; i < Temp1.Count; i++)
				{
					CrosSum += Temp1[i] * Temp2[i];
				}
				CrosSum /= Temp1.Count;
				KK = ((double)Temp1.Count / (Temp1.Count - 1)) * ((CrosSum - Xexp * Yexp) / (StX * StY));
				dataGridView1.Rows[5].Cells[2].Value = "" + Math.Round(KK, Data.NumberOfNum);
			}
			do
			{
				int Count1 = 1;
				int Count2 = 1;
				try
				{
					Count1 = Convert.ToInt32(dataGridView1.Rows[6].Cells[4].EditedFormattedValue);
				}
				catch (Exception)
				{
					dataGridView1.Rows[6].Cells[4].Value = ToolsForWork.CompNumOfClasses(Temp2.Count);
					Count1 = ToolsForWork.CompNumOfClasses(Temp2.Count);
				}
				try
				{
					Count2 = Convert.ToInt32(dataGridView1.Rows[7].Cells[4].EditedFormattedValue);
				}
				catch (Exception)
				{
					dataGridView1.Rows[7].Cells[4].Value = ToolsForWork.CompNumOfClasses(Temp2.Count);
					Count2 = ToolsForWork.CompNumOfClasses(Temp2.Count);
				}
				if ((Count2 <= 1) || (Count2 >= 50))
				{
					if (LogCheckBox.Checked)
						LogOutputTextBox.Text += "Хибна кількість розбиттів для кореляційного відношення" + Environment.NewLine;
					dataGridView1.Rows[7].Cells[4].Value = ToolsForWork.CompNumOfClasses(Temp2.Count);
					Count2 = ToolsForWork.CompNumOfClasses(Temp2.Count);
				}
				if ((Count1 <= 1) || (Count1 >= 50))
				{
					if (LogCheckBox.Checked)
						LogOutputTextBox.Text += "Хибна кількість розбиттів для кореляційного відношення" + Environment.NewLine;
					dataGridView1.Rows[6].Cells[4].Value = ToolsForWork.CompNumOfClasses(Temp2.Count);
					Count1 = ToolsForWork.CompNumOfClasses(Temp2.Count);
				}
				if ((Count2 <= 1))
				{
					Count2 += 2;
				}
				if ((Count1 <= 1))
				{
					Count1 += 2;
				}
				double sum = 0;
				List<List<double>> Tx = new List<List<double>>(), Ty = new List<List<double>>();
				List<double> expxs = new List<double>(), expys = new List<double>();
				for (i = 0; i < Count1; i++)
				{
					Tx.Add(new List<double>());
					sum = 0;
					for (j = 0; j < Temp1.Count; j++)
					{
						if ((Temp1[j] >= MinX + i * ((MaxX - MinX) / Count1)) && (Temp1[j] < MinX + (i + 1) * ((MaxX - MinX) / Count1)))
						{
							Tx[i].Add(Temp2[j]);
							sum += Temp2[j];
						}
					}
					if (i == Count1 - 1)
					{
						for (j = 0; j < Temp1.Count; j++)
						{
							if ((Temp1[j] >= MinX + i * ((MaxX - MinX) / Count1)) && (Temp1[j] <= MinX + (i + 1) * ((MaxX - MinX) / Count1)))
							{
								Tx[i].Add(Temp2[j]);
								sum += Temp2[j];
							}
						}
					}
					expys.Add(sum / Tx[i].Count);
				}
				double temp1 = 0, temp2 = 0;
				for (i = 0; i < Count1; i++)
				{
					if (double.IsNaN(expys[i]))
						continue;
					temp1 += Tx[i].Count * Math.Pow(Yexp - expys[i], 2);
					for (j = 0; j < Tx[i].Count; j++)
					{
						temp2 += Math.Pow(Yexp - Tx[i][j], 2);
					}
				}
				Kvx = Math.Sqrt(temp1 / temp2);
				dataGridView1.Rows[6].Cells[2].Value = "" + Math.Round(Kvx, Data.NumberOfNum);

				//////
				for (i = 0; i < Count2; i++)
				{
					Ty.Add(new List<double>());
					sum = 0;
					for (j = 0; j < Temp1.Count; j++)
					{
						if ((Temp2[j] >= MinY + i * ((MaxY - MinY) / Count2)) && (Temp2[j] < MinY + (i + 1) * ((MaxY - MinY) / Count2)))
						{
							Ty[i].Add(Temp1[j]);
							sum += Temp1[j];
						}
					}
					if (i == Count2 - 1)
					{
						for (j = 0; j < Temp1.Count; j++)
						{
							if ((Temp2[j] >= MinY + i * ((MaxY - MinY) / Count2)) && (Temp2[j] <= MinY + (i + 1) * ((MaxY - MinY) / Count2)))
							{
								Ty[i].Add(Temp1[j]);
								sum += Temp1[j];
							}
						}
					}
					expxs.Add(sum / Ty[i].Count);
				}
				temp1 = 0; temp2 = 0;
				for (i = 0; i < Count2; i++)
				{
					if (double.IsNaN(expxs[i]))
						continue;
					temp1 += Ty[i].Count * Math.Pow(Xexp - expxs[i], 2);
					for (j = 0; j < Ty[i].Count; j++)
					{
						temp2 += Math.Pow(Xexp - Ty[i][j], 2);
					}
				}
				Kvy = Math.Sqrt(temp1 / temp2);
				dataGridView1.Rows[7].Cells[2].Value = "" + Math.Round(Kvy, Data.NumberOfNum);


				////
				/*  double alfa1 = 0.1;
                  double gamma1 = 0.9;
                  double alfa2 = 0.1;
                  double gamma2 = 0.9;
                  double nu1, nu2;
                  nu2 = Temp1.Count - Count1;
                  nu1 = (Math.Pow(Count1 - 1.0     + Temp1.Count * Kvx * Kvx, 2) / (Count1 - 1 + 2 * Temp1.Count * Kvx * Kvx));
                  temp1 = Quantile.FishQuan(alfa1,nu1,nu2);
                  temp2 = (((Temp1.Count - Count1) * Kvx * Kvx) / (Temp1.Count * (1 - Kvx * Kvx) * temp1));
                  dataGridView1.Rows[6].Cells[1].Value = Math.Round(Math.Sqrt(temp2 - ((Count1 - 1.0)/(Temp1.Count))), Data.NumberOfNum);
                  temp1 = Quantile.FishQuan(1-alfa1, nu1, nu2);
                  temp2 = (((Temp1.Count - Count1) * Kvx * Kvx) / (Temp1.Count * (1 - Kvx * Kvx) * temp1));
                  dataGridView1.Rows[6].Cells[3].Value = Math.Round(Math.Sqrt(temp2 - ((Count1 - 1.0)/(Temp1.Count))), Data.NumberOfNum);
                  ///
                  nu2 = Temp1.Count - Count2;
                  nu1 = (Math.Pow(Count2 - 1.0     + Temp1.Count * Kvy * Kvy, 2) / (Count2 - 1 + 2 * Temp1.Count * Kvy * Kvy));
                  temp1 = Quantile.FishQuan(alfa2,nu1,nu2);
                  temp2 = (((Temp1.Count - Count2) * Kvy * Kvy) / (Temp1.Count * (1 - Kvy * Kvy) * temp1));
                  dataGridView1.Rows[7].Cells[1].Value = Math.Round(Math.Sqrt(temp2 - ((Count2 - 1.0)/(Temp1.Count))), Data.NumberOfNum);
                  temp1 = Quantile.FishQuan(1-alfa2, nu1, nu2);
                  temp2 = (((Temp1.Count - Count2) * Kvy * Kvy) / (Temp1.Count * (1 - Kvy * Kvy) * temp1));
                  dataGridView1.Rows[7].Cells[3].Value = Math.Round(Math.Sqrt(temp2 - ((Count2 - 1.0)/(Temp1.Count))), Data.NumberOfNum);*/
			}
			while (false);
			do
			{
				if (Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].Count == 1)
				{
					dataGridView1.Rows[0].Cells[1].Value = "Не обраховувалося";
					dataGridView1.Rows[0].Cells[3].Value = "Не обраховувалося";
					dataGridView1.Rows[1].Cells[1].Value = "Не обраховувалося";
					dataGridView1.Rows[1].Cells[3].Value = "Не обраховувалося";
					break;
				}
				double alfa1 = 0.1;
				double gamma1 = 0.9;
				double alfa2 = 0.1;
				double gamma2 = 0.9;
				try
				{
					gamma1 = Convert.ToDouble(dataGridView1.Rows[0].Cells[4].EditedFormattedValue);
					alfa1 = 1 - gamma1;
				}
				catch (Exception)
				{
					dataGridView1.Rows[0].Cells[4].Value = "0,9";
					alfa1 = 0.1;
				}
				try
				{
					gamma2 = Convert.ToDouble(dataGridView1.Rows[1].Cells[4].EditedFormattedValue);
					alfa2 = 1 - gamma2;
				}
				catch (Exception)
				{
					dataGridView1.Rows[1].Cells[4].Value = "0,9";
					alfa2 = 0.1;
				}
				if ((alfa1 <= 0) || (alfa1 >= 1))
				{
					if (LogCheckBox.Checked)
						LogOutputTextBox.Text += "Хибне значення γ для математичного сподівання " + Environment.NewLine;
					dataGridView1.Rows[0].Cells[4].Value = "0,9";
					alfa1 = 0.1;
				}
				if ((alfa2 <= 0) || (alfa2 >= 1))
				{
					if (LogCheckBox.Checked)
						LogOutputTextBox.Text += "Хибне значення γ для математичного сподівання " + Environment.NewLine;
					dataGridView1.Rows[1].Cells[4].Value = "0,9";
					alfa1 = 0.1;
				}
				double XExpSt = StX / Math.Sqrt(Temp1.Count);
				double YExpSt = StX / Math.Sqrt(Temp1.Count);
				dataGridView1.Rows[0].Cells[1].Value = Math.Round(Xexp - XExpSt * Quantile.StudQuan(1 - alfa1 / 2, Temp1.Count - 1), Data.NumberOfNum);
				dataGridView1.Rows[0].Cells[3].Value = Math.Round(Xexp + XExpSt * Quantile.StudQuan(1 - alfa1 / 2, Temp1.Count - 1), Data.NumberOfNum);
				dataGridView1.Rows[1].Cells[1].Value = Math.Round(Yexp - YExpSt * Quantile.StudQuan(1 - alfa2 / 2, Temp1.Count - 1), Data.NumberOfNum);
				dataGridView1.Rows[1].Cells[3].Value = Math.Round(Yexp + YExpSt * Quantile.StudQuan(1 - alfa2 / 2, Temp1.Count - 1), Data.NumberOfNum);
			} while (false);
			do
			{
				if (Data.DataForWork[Data.CurrentSample].Count == 1)
				{
					dataGridView1.Rows[2].Cells[1].Value = "Не обраховувалося";
					dataGridView1.Rows[2].Cells[3].Value = "Не обраховувалося";
					dataGridView1.Rows[3].Cells[1].Value = "Не обраховувалося";
					dataGridView1.Rows[3].Cells[3].Value = "Не обраховувалося";
					break;
				}
				double alfa1 = 0.1;
				double gamma1 = 0.9;
				double alfa2 = 0.1;
				double gamma2 = 0.9;
				try
				{
					gamma1 = Convert.ToDouble(dataGridView1.Rows[2].Cells[4].EditedFormattedValue);
					alfa1 = 1 - gamma1;
				}
				catch (Exception)
				{
					dataGridView1.Rows[2].Cells[4].Value = "0,9";
					alfa1 = 0.1;
				}
				try
				{
					gamma2 = Convert.ToDouble(dataGridView1.Rows[3].Cells[4].EditedFormattedValue);
					alfa2 = 1 - gamma2;
				}
				catch (Exception)
				{
					dataGridView1.Rows[3].Cells[4].Value = "0,9";
					alfa2 = 0.1;
				}
				if ((alfa1 <= 0) || (alfa1 >= 1))
				{
					if (LogCheckBox.Checked)
						LogOutputTextBox.Text += "Хибне значення γ для стандартного відхилення" + Environment.NewLine;
					dataGridView1.Rows[2].Cells[4].Value = "0,9";
					alfa1 = 0.1;
				}
				if ((alfa2 <= 0) || (alfa2 >= 1))
				{
					if (LogCheckBox.Checked)
						LogOutputTextBox.Text += "Хибне значення γ для стандартного відхилення" + Environment.NewLine;
					dataGridView1.Rows[2].Cells[4].Value = "0,9";
					alfa2 = 0.1;
				}
				double XDevDev = StX / Math.Sqrt(2 * Temp1.Count);
				double YDevDev = StY / Math.Sqrt(2 * Temp1.Count);
				dataGridView1.Rows[2].Cells[1].Value = Math.Round(StX - XDevDev * Quantile.StudQuan(1 - alfa1 / 2, Temp1.Count - 1), Data.NumberOfNum);
				dataGridView1.Rows[2].Cells[3].Value = Math.Round(StX + XDevDev * Quantile.StudQuan(1 - alfa1 / 2, Temp1.Count - 1), Data.NumberOfNum);
				dataGridView1.Rows[3].Cells[1].Value = Math.Round(StY - YDevDev * Quantile.StudQuan(1 - alfa2 / 2, Temp1.Count - 1), Data.NumberOfNum);
				dataGridView1.Rows[3].Cells[3].Value = Math.Round(StY + YDevDev * Quantile.StudQuan(1 - alfa2 / 2, Temp1.Count - 1), Data.NumberOfNum);
				dataGridView1.Rows[2].Cells[5].Value = Math.Round(StX * StX, Data.NumberOfNum);
				dataGridView1.Rows[3].Cells[5].Value = Math.Round(StY * StY, Data.NumberOfNum);
			}
			while (false);
			do
			{
				if (Data.DataForWork[Data.CurrentSample].Count == 1)
				{
					dataGridView1.Rows[2].Cells[1].Value = "Не обраховувалося";
					dataGridView1.Rows[2].Cells[3].Value = "Не обраховувалося";
					dataGridView1.Rows[3].Cells[1].Value = "Не обраховувалося";
					dataGridView1.Rows[3].Cells[3].Value = "Не обраховувалося";
					break;
				}
				double alfa1 = 0.1;
				double gamma1 = 0.9;
				try
				{
					gamma1 = Convert.ToDouble(dataGridView1.Rows[5].Cells[4].EditedFormattedValue);
					alfa1 = 1 - gamma1;
				}
				catch (Exception)
				{
					dataGridView1.Rows[5].Cells[4].Value = "0,9";
					alfa1 = 0.1;
				}
				if ((alfa1 <= 0) || (alfa1 >= 1))
				{
					if (LogCheckBox.Checked)
						LogOutputTextBox.Text += "Хибне значення γ для стандартного відхилення" + Environment.NewLine;
					dataGridView1.Rows[5].Cells[4].Value = "0,9";
					alfa1 = 0.1;
				}
				dataGridView1.Rows[5].Cells[1].Value = Math.Round(KK + ((KK * (1 - KK * KK)) / (2 * Temp1.Count)) - ((1 - KK * KK) / Math.Sqrt(Temp1.Count - 1)) * Quantile.StanQuanOdn(1 - alfa1 / 2), Data.NumberOfNum);
				dataGridView1.Rows[5].Cells[3].Value = Math.Round(KK + ((KK * (1 - KK * KK)) / (2 * Temp1.Count)) + ((1 - KK * KK) / Math.Sqrt(Temp1.Count - 1)) * Quantile.StanQuanOdn(1 - alfa1 / 2), Data.NumberOfNum);
				dataGridView1.Rows[5].Cells[5].Value = Math.Round(StX * StY * KK, Data.NumberOfNum);
			}
			while (false);

			/////
			////Var ryad
			this.chart1.Series[0].CustomProperties = "PointWidth=1";
			//this.chart1.ChartAreas[0].AxisX.Interval = Tem;
			//this.chart1.ChartAreas[0].AxisX.Minimum = HistData.MinLimit;
			//this.chart1.ChartAreas[0].AxisY.Interval = HistData.Step;
			//this.chart1.ChartAreas[0].AxisY.Minimum = HistData.MinLimit;
			this.chart1.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0.0000}";
			this.chart1.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0.0000}";
			this.chart1.ChartAreas[0].AxisY.Title = "Y";
			this.chart1.ChartAreas[0].AxisX.Title = "X";

			this.chart2.Series[0].CustomProperties = "PointWidth=1";
			this.chart2.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0.0000}";
			this.chart2.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0.0000}";
			this.chart2.ChartAreas[0].AxisY.Title = "Y";
			this.chart2.ChartAreas[0].AxisX.Title = "X";
			//////
			this.chart1.Series[0].Points.Clear();
			this.chart2.Series[0].Points.Clear();
			this.chart1.Series[1].Points.Clear();
			this.chart1.Series[2].Points.Clear();
			this.chart1.Series[3].Points.Clear();
			this.chart1.Series[4].Points.Clear();
			this.chart1.Series[5].Points.Clear();
			this.chart1.Series[6].Points.Clear();
			this.chart1.Series[7].Points.Clear();
			this.chart1.Series[8].Points.Clear();
			////
			this.chart1.ChartAreas[0].AxisX.Interval = (int)((MaxX - MinX) / CountX);
			this.chart1.ChartAreas[0].AxisX.Minimum = MinX;
			this.chart1.ChartAreas[0].AxisY.Interval = (int)((MaxY - MinY) / CountY);
			this.chart1.ChartAreas[0].AxisY.Minimum = MinY;
			this.chart2.ChartAreas[0].AxisX.Interval = (int)((MaxX - MinX) / CountX);
			this.chart2.ChartAreas[0].AxisX.Minimum = MinX;
			this.chart2.ChartAreas[0].AxisY.Interval = (int)((MaxY - MinY) / CountY);
			this.chart2.ChartAreas[0].AxisY.Minimum = MinY;
			double maxP = 0;
			int[,] Ns = new int[CountX, CountY];
			double[,] Ps = new double[CountX, CountY];
			chart1.Series[1].Points.AddXY(Xexp, Yexp);
			for (i = 0; i < Temp1.Count; i++)
			{
				chart1.Series[0].Points.AddXY(Temp1[i], Temp2[i]);
			}
			if (checkBox10.Checked)
			{
				for (i = 0; i < Temp1.Count; i++)
				{
					chart2.Series[10].Points.AddXY(Temp1[i], Temp2[i]);
				}
			}
			for (i = 0; i < CountX; i++)
			{
				for (j = 0; j < CountY; j++)
				{
					Ns[i, j] = 0;
					for (k = 0; k < Temp1.Count; k++)
					{
						if ((Temp1[k] >= MinX + i * ((MaxX - MinX) / CountX)) && (Temp1[k] < MinX + (i + 1) * ((MaxX - MinX) / CountX)) && (Temp2[k] >= MinY + (j) * ((MaxY - MinY) / CountY)) && (Temp2[k] < MinY + (j + 1) * ((MaxY - MinY) / CountY)))
						{
							Ns[i, j]++;
						}
					}
					Ps[i, j] = ((double)Ns[i, j]) / Temp1.Count;
					//Hist[i, j] = new PictureBox();
					//  Hist[i, j].Left = (int)chart2.ChartAreas[0].InnerPlotPosition.X + (int)(i * ((chart2.ChartAreas[0].InnerPlotPosition.Width) / CountX));
					//Hist[i, j].Top = (int)chart2.ChartAreas[0].InnerPlotPosition.Y + (int)(j * ((chart2.ChartAreas[0].InnerPlotPosition.Height) / CountY));
					if (Ps[i, j] > maxP)
					{
						maxP = Ps[i, j];
					}
				}
			}
			/////TwoDemShit
			Bitmap OuTwoDemGliph = new Bitmap(64 * CountX, 64 * CountY, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
			Bitmap Temp = new Bitmap(64, 64, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
			Graphics G = Graphics.FromImage(OuTwoDemGliph);
			Graphics TempG = Graphics.FromImage(Temp);
			Pen BlackPen = new Pen(Color.Black, 1);
			int TempRead = 0;
			if (radioButton12.Checked)
			{
				for (i = 0; i < CountX; i++)
				{
					for (j = 0; j < CountY; j++)
					{
						TempRead = 255 - (int)((Ps[i, CountY - j - 1] * 255) / maxP);
						TempG.Clear(Color.FromArgb(TempRead, TempRead, TempRead));
						TempG.DrawRectangle(BlackPen, 0, 0, Temp.Width, Temp.Height);

						G.DrawImage(Temp, i * 64, j * 64);
						// Hist[i, j].Left = 81 + (int)chart2.ChartAreas[0].InnerPlotPosition.X + (int)(i * ((chart2.Width - 300) / CountX));
						// Hist[i, j].Top = 22 + (int)chart2.ChartAreas[0].InnerPlotPosition.Y + (int)((CountY - 1 - j) * ((chart2.Height - 76) / CountY));
						// Hist[i, j].BackColor = Color.FromArgb((Ps[i, j] == 0) ? 0 : 255, 255 - (int)((Ps[i, j] * 255) / maxP), 255 - (int)((Ps[i, j] * 255) / maxP), 255 - (int)((Ps[i, j] * 255) / maxP));//(Ps[i, j] == 0) ? 0 : 255
						//Hist[i, j].Height = ((chart2.Height - 76) / CountY) - 2;
						//Hist[i, j].Width = ((chart2.Width - 300) / CountX) - 2;
						// chart2.Controls.Add(Hist[i, j]);
					}
				}
			}
			else
			{
				List<double> Temp11 = new List<double>(), Temp12 = new List<double>();
				for (i = 0; i < Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].Count; i++)
				{
					Temp11.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]][i]);
					Temp12.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][1]][i]);
				}
				for (i = 0; i < Temp1.Count; i++)
				{
					Temp11[i] -= Xexp;
					Temp12[i] -= Yexp;
				}
				double tg2fi = 2 * ((CrosSum) / (StX * StX - StY * StY));
				double fi = Math.Atan(tg2fi) / 2;
				double t1, t2;
				double alfaxx, alfaxy, alfayx, alfayy;
				alfaxx = Math.Cos(fi);
				alfaxy = -1 * Math.Sin(fi);
				alfayx = Math.Sin(fi);
				alfayy = Math.Cos(fi);
                double RMaxy = double.MinValue, RMaxx = double.MinValue, RMiny = double.MaxValue, RMinx = double.MaxValue;
				double Maxy = double.MinValue, Maxx = double.MinValue, Miny = double.MaxValue, Minx = double.MaxValue;
				for (i = 0; i < Temp11.Count; i++)
				{
					t1 = alfaxx * Temp11[i] + alfayx * Temp12[i];
					t2 = alfaxy * Temp11[i] + alfayy * Temp12[i];
                    /////
                    if (Temp11[i] < RMinx)
                    {
                        RMinx = Temp11[i];
                    }
                    if (Temp12[i] < RMiny)
                    {
                        RMiny = Temp12[i];
                    }
                    if (Temp11[i] > RMaxx)
                    {
                        RMaxx = Temp11[i];
                    }
                    if (Temp12[i] > RMaxy)
                    {
                        RMaxy = Temp12[i];
                    }
                    ////
					if (t1 < Minx)
					{
						Minx = t1;
					}
					if (t2 < Miny)
					{
						Miny = t2;
					}
					if (t1 > Maxx)
					{
						Maxx = t1;
					}
					if (t2 > Maxy)
					{
						Maxy = t2;
					}
					Temp11[i] = t1;
					Temp12[i] = t2;
				}
				Maxx += 0.00001;
				Maxy += 0.00001;
				maxP = 0;
				for (i = 0; i < CountX; i++)
				{
					for (j = 0; j < CountY; j++)
					{
						Ns[i, j] = 0;
						for (k = 0; k < Temp11.Count; k++)
						{
							if ((Temp11[k] >= Minx + i * ((Maxx - Minx) / CountX)) && (Temp11[k] < Minx + (i + 1) * ((Maxx - Minx) / CountX)) && (Temp12[k] >= Miny + (j) * ((Maxy - Miny) / CountY)) && (Temp12[k] < Miny + (j + 1) * ((Maxy - Miny) / CountY)))
							{
								Ns[i, j]++;
							}
						}
						Ps[i, j] = ((double)Ns[i, j]) / Temp1.Count;
						if (Ps[i, j] > maxP)
						{
							maxP = Ps[i, j];
						}

					}
				}
                Point[] TempArr;
                BlackPen.Width = 3;
                G.Clear(Color.White);
				for (i = 0; i < CountX-1; i++)
				{
					for (j = 0; j < CountY-1; j++)
					{
						TempRead = 255 - (int)((Ps[i, CountY - j - 1] * 255) / maxP);
                        TempArr = new Point[] 
                            {                                                                                                                                 
                                new Point(-1*(int)(((( alfaxx * (Minx + i * ((Maxx - Minx) / CountX)) - alfayx * (Miny + (j) * ((Maxy - Miny) / CountY)))           - RMinx) * OuTwoDemGliph.Width)/ (RMaxx - RMinx)), 
                                          (int)((((-alfaxy * (Minx + i * ((Maxx - Minx) / CountX)) + alfayy * (Miny + (j) * ((Maxy - Miny) / CountY)))           - RMiny) * OuTwoDemGliph.Height)/ (RMaxy - RMiny))), 
                                new Point(-1*(int)(((( alfaxx * (Minx + (i + 1) * ((Maxx - Minx) / CountX)) - alfayx * (Miny + (j) * ((Maxy - Miny) / CountY)))     - RMinx) * OuTwoDemGliph.Width)/ (RMaxx - RMinx)), 
                                          (int)((((-alfaxy * (Minx + (i + 1) * ((Maxx - Minx) / CountX)) + alfayy * (Miny + (j) * ((Maxy - Miny) / CountY)))     - RMiny) * OuTwoDemGliph.Height)/ (RMaxy - RMiny))), 
                                new Point(-1*(int)(((( alfaxx * (Minx + (i + 1) * ((Maxx - Minx) / CountX)) - alfayx * (Miny + (j + 1) * ((Maxy - Miny) / CountY))) - RMinx) * OuTwoDemGliph.Width)/ (RMaxx - RMinx)), 
                                          (int)((((-alfaxy * (Minx + (i + 1) * ((Maxx - Minx) / CountX)) + alfayy * (Miny + (j + 1) * ((Maxy - Miny) / CountY))) - RMiny) * OuTwoDemGliph.Height)/ (RMaxy - RMiny))), 
                                new Point(-1*(int)(((( alfaxx * (Minx + i * ((Maxx - Minx) / CountX)) - alfayx * (Miny + (j + 1) * ((Maxy - Miny) / CountY)))       - RMinx) * OuTwoDemGliph.Width)/ (RMaxx - RMinx)), 
                                          (int)((((-alfaxy * (Minx + i * ((Maxx - Minx) / CountX)) + alfayy * (Miny + (j + 1) * ((Maxy - Miny) / CountY)))       - RMiny) * OuTwoDemGliph.Height)/ (RMaxy - RMiny))), 

                            };
                         G.DrawPolygon(BlackPen, 
                            TempArr);
					}
				}

			}
			//chart2  = OuTwoDemGliph;
			//////ask lol
			chart2.ChartAreas[0].BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chart2.ChartAreas[0].BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
           // using (
            {
               // File.WriteAllText(Application.StartupPath + "\\" + "TempFileDontTouch.png",
                //    OuTwoDemGliph.ToString(),
                //    Encoding.Default);
                FileStream MFS = File.Create(Application.StartupPath + "\\PersonalOnly\\TempFileDontTouch"+Data.PictureNumber+".png");
                OuTwoDemGliph.Save(MFS,System.Drawing.Imaging.ImageFormat.Bmp);
                chart2.ChartAreas[0].BackImage = (Application.StartupPath + "\\PersonalOnly\\TempFileDontTouch" + Data.PictureNumber + ".png");
                Data.PictureNumber++;
                MFS.Dispose();
                MFS.Close();
                //File.Delete(Application.StartupPath + "\\" + "TempFileDontTouch.png");
            }
            /////
            for (i = 0; i < 10; i++)
            {
                chart2.Series[i].Name = "" + i;
            }
            for (i = 0; i < 10; i++)
            {
                chart2.Series[i].Name = "p(x)=" + Math.Round((i * maxP) / 10, 3) + "..." + Math.Round(((i + 1) * maxP) / 10, 3);
            }
            ////
            {
                double sum, temp;
                sum = 0;
                for (i = 0; i < CountX; i++)
                {
                    for (j = 0; j < CountY; j++)
                    {
                        temp = (1.0 / (2 * Math.PI * StX * StY * Math.Sqrt(1 - KK * KK))) * Math.Exp(((-1.0) / (2 * (1 - KK * KK))) * (Math.Pow((MinX + (i + 0.5) * ((MaxX - MinX) / CountX) - Xexp) / (StX), 2) - (2 * KK * ((MinX + (i + 0.5) * ((MaxX - MinX) / CountX) - Xexp) / (StX)) * ((MinY + (j + 0.5) * ((MaxY - MinY) / CountY) - Yexp) / (StY))) + Math.Pow((MinY + (j + 0.5) * ((MaxY - MinY) / CountY) - Yexp) / (StY), 2)));
                        temp *= ((MaxX - MinX) / CountX) * ((MaxY - MinY) / CountY);
                        if (temp != 0)
                        {
                            sum += Math.Pow(Ps[i, j] - temp, 2) / temp;
                        }
                    }
                }
                dataGridView1.Rows[4].Cells[5].Value = Math.Round(sum, Data.NumberOfNum);
                double alfa1 = 0.1;
                double gamma1 = 0.9;
                try
                {
                    gamma1 = Convert.ToDouble(dataGridView1.Rows[4].Cells[4].EditedFormattedValue);
                    alfa1 = 1 - gamma1;
                }
                catch (Exception)
                {
                    dataGridView1.Rows[4].Cells[4].Value = "0,9";
                    alfa1 = 0.1;
                }
                if ((alfa1 <= 0) || (alfa1 >= 1))
                {
                    if (LogCheckBox.Checked)
                        LogOutputTextBox.Text += "Хибне значення γ для критерія Пірсона" + Environment.NewLine;
                    dataGridView1.Rows[4].Cells[4].Value = "0,9";
                    alfa1 = 0.1;
                }
                if (sum <= Quantile.HirsQuan(1 - alfa1, CountX * CountY - 2))
                {
                    dataGridView1.Rows[4].Cells[2].Value = "Збіг";
                }
                else
                {
                    dataGridView1.Rows[4].Cells[2].Value = "Збіг відсутній";
                    LogOutputTextBox.Text += "Увага! Через хибність гіпотези про нормальність розподілу більшість обрахованих коефіціентів можуть бути незначущими!" + Environment.NewLine;
                }
            }
            if (Temp1.Count <= 10000)
            {
                double alfa1 = 0.1;
                double gamma1 = 0.9;
                try
                {
                    gamma1 = Convert.ToDouble(dataGridView1.Rows[8].Cells[4].EditedFormattedValue);
                    alfa1 = 1 - gamma1;
                }
                catch (Exception)
                {
                    dataGridView1.Rows[8].Cells[4].Value = "0,9";
                    alfa1 = 0.1;
                }
                if ((alfa1 <= 0) || (alfa1 >= 1))
                {
                    if (LogCheckBox.Checked)
                        LogOutputTextBox.Text += "Хибне значення γ для стандартного відхилення" + Environment.NewLine;
                    dataGridView1.Rows[8].Cells[4].Value = "0,9";
                    alfa1 = 0.1;
                }
                List<double[]> Rx = new List<double[]>();
                List<double[]> Ry = new List<double[]>();
                int LclC = 0;
                double A = 0, B = 0;
                double[] temp = new double[3];
                for (i = 0; i < Temp1.Count; i++)
                {
                    Rx.Add(new double[] { Temp1[i], i, 0 });
                    Ry.Add(new double[] { Temp2[i], i, 0 });
                }
                for (i = 0; i < Temp1.Count; i++)
                {
                    for (j = 0; j < Temp1.Count - 1 - i; j++)
                    {
                        if (Rx[j][0] > Rx[j + 1][0])
                        {
                            temp[0] = Rx[j][0];
                            temp[1] = Rx[j][1];
                            Rx[j][0] = Rx[j + 1][0];
                            Rx[j][1] = Rx[j + 1][1];
                            Rx[j + 1][0] = temp[0];
                            Rx[j + 1][1] = temp[1];
                        }
                        if (Ry[j][0] > Ry[j + 1][0])
                        {
                            temp[0] = Ry[j][0];
                            temp[1] = Ry[j][1];
                            Ry[j][0] = Ry[j + 1][0];
                            Ry[j][1] = Ry[j + 1][1];
                            Ry[j + 1][0] = temp[0];
                            Ry[j + 1][1] = temp[1];
                        }
                    }
                }
                for (i = 0; i < Temp1.Count; i++)
                {
                    Rx[i][2] = i;
                    Ry[i][2] = i;
                }
                for (i = 0; i < Temp1.Count - 1; i++)
                {
                    LclC++;
                    if (Rx[i][0] == Rx[i + 1][0])
                    {

                    }
                    else
                    {
                        A += Math.Pow(LclC, 3) - LclC;
                        for (j = i - LclC + 1; j <= i; j++)
                        {
                            Rx[j][2] = Rx[i][2] - (LclC - 1.0) / 2;
                        }
                        LclC = 0;
                    }
                }
                A += Math.Pow(LclC, 3) - LclC;
                LclC = 0;
                A *= 1.0 / 12;

                for (i = 0; i < Temp1.Count - 1; i++)
                {
                    LclC++;
                    if (Ry[i][0] == Ry[i + 1][0])
                    {
                    }
                    else
                    {
                        B += Math.Pow(LclC, 3) - LclC;
                        for (j = i - LclC + 1; j <= i; j++)
                        {
                            Ry[j][2] = Ry[i][2] - (LclC - 1.0) / 2;
                        }
                        LclC = 0;
                    }
                }
                B += Math.Pow(LclC, 3) - LclC;
                LclC = 0;
                B *= 1.0 / 12;

                for (i = 0; i < Temp1.Count; i++)
                {
                    for (j = 0; j < Temp1.Count - 1 - i; j++)
                    {
                        if (Rx[j][1] > Rx[j + 1][1])
                        {
                            temp[0] = Rx[j][0];
                            temp[1] = Rx[j][1];
                            temp[2] = Rx[j][2];
                            Rx[j][0] = Rx[j + 1][0];
                            Rx[j][1] = Rx[j + 1][1];
                            Rx[j][2] = Rx[j + 1][2];
                            Rx[j + 1][0] = temp[0];
                            Rx[j + 1][1] = temp[1];
                            Rx[j + 1][2] = temp[2];
                        }
                        if (Ry[j][1] > Ry[j + 1][1])
                        {
                            temp[0] = Ry[j][0];
                            temp[1] = Ry[j][1];
                            temp[2] = Ry[j][2];
                            temp[1] = Ry[j][1];
                            Ry[j][0] = Ry[j + 1][0];
                            Ry[j][1] = Ry[j + 1][1];
                            Ry[j][2] = Ry[j + 1][2];
                            Ry[j + 1][0] = temp[0];
                            Ry[j + 1][1] = temp[1];
                            Ry[j + 1][2] = temp[2];
                        }
                    }
                }
                double sum = 0;
                for (i = 0; i < Temp1.Count; i++)
                {
                    sum += Math.Pow(Rx[i][2] - Ry[i][2], 2);
                }
                Ts = ((1.0 / 6) * Temp1.Count * (Temp1.Count * Temp1.Count - 1) - sum - A - B) / (Math.Sqrt(((1.0 / 6) * Temp1.Count * (Temp1.Count * Temp1.Count - 1) - 2 * A) * ((1.0 / 6) * Temp1.Count * (Temp1.Count * Temp1.Count - 1) - 2 * B)));
                dataGridView1.Rows[8].Cells[2].Value = "" + Math.Round(Ts, Data.NumberOfNum);
                double TsDev = Math.Sqrt((1 - Ts * Ts) / (Temp1.Count - 2));
                dataGridView1.Rows[8].Cells[1].Value = "" + Math.Round(Ts - Quantile.StudQuan(1 - alfa1 / 2, Temp1.Count - 2) * TsDev, Data.NumberOfNum);
                dataGridView1.Rows[8].Cells[3].Value = "" + Math.Round(Ts + Quantile.StudQuan(1 - alfa1 / 2, Temp1.Count - 2) * TsDev, Data.NumberOfNum);

                double alfa2 = 0.1;
                double gamma2 = 0.9;
                try
                {
                    gamma2 = Convert.ToDouble(dataGridView1.Rows[9].Cells[4].EditedFormattedValue);
                    alfa2 = 1 - gamma2;
                }
                catch (Exception)
                {
                    dataGridView1.Rows[9].Cells[4].Value = "0,9";
                    alfa2 = 0.1;
                }
                if ((alfa2 <= 0) || (alfa2 >= 1))
                {
                    if (LogCheckBox.Checked)
                        LogOutputTextBox.Text += "Хибне значення γ для стандартного відхилення" + Environment.NewLine;
                    dataGridView1.Rows[9].Cells[4].Value = "0,9";
                    alfa2 = 0.1;
                }
                for (i = 0; i < Temp1.Count; i++)
                {
                    for (j = 0; j < Temp1.Count - 1 - i; j++)
                    {
                        if (Rx[j][2] > Rx[j + 1][2])
                        {
                            temp[0] = Rx[j][0];
                            temp[1] = Rx[j][1];
                            temp[2] = Rx[j][2];
                            Rx[j][0] = Rx[j + 1][0];
                            Rx[j][1] = Rx[j + 1][1];
                            Rx[j][2] = Rx[j + 1][2];
                            Rx[j + 1][0] = temp[0];
                            Rx[j + 1][1] = temp[1];
                            Rx[j + 1][2] = temp[2];
                        }
                    }
                }
                for (i = 0; i < Temp1.Count; i++)
                {
                    for (j = i; j < Temp1.Count; j++)
                    {
                        if (Rx[i][1] == Ry[j][1])
                        {
                            temp[0] = Ry[i][0];
                            temp[1] = Ry[i][1];
                            temp[2] = Ry[i][2];
                            Ry[i][0] = Ry[j][0];
                            Ry[i][1] = Ry[j][1];
                            Ry[i][2] = Ry[j][2];
                            Ry[j][0] = temp[0];
                            Ry[j][1] = temp[1];
                            Ry[j][2] = temp[2];
                        }
                    }
                }
                sum = 0;
                for (i = 0; i < Temp1.Count - 1; i++)
                {
                    for (j = i + 1; j < Temp1.Count; j++)
                    {
                        if (Ry[i][2] < Ry[j][2])
                        {
                            sum++;
                        }
                        else
                        {
                            if (Ry[i][2] > Ry[j][2])
                            {
                                sum--;
                            }
                        }
                    }
                }
                Tk = (2 * sum) / (Temp1.Count * (Temp1.Count - 1));
                dataGridView1.Rows[9].Cells[2].Value = "" + Math.Round(Tk, Data.NumberOfNum);
                double TkDev = Math.Sqrt((4.0 * Temp1.Count + 10) / (9 * (Temp1.Count * Temp1.Count - Temp1.Count)));
                dataGridView1.Rows[9].Cells[1].Value = "" + Math.Round(Tk - Quantile.StudQuan(1 - alfa2 / 2, Temp1.Count - 2) * TkDev, Data.NumberOfNum);
                dataGridView1.Rows[9].Cells[3].Value = "" + Math.Round(Tk + Quantile.StudQuan(1 - alfa2 / 2, Temp1.Count - 2) * TkDev, Data.NumberOfNum);
            }
            else 
            {
                dataGridView1.Rows[9].Cells[2].Value = "Не обраховувалося - забагато елементів!";
            }
            
        }

        private void Build()
        {
            if (Data.DataForWork[Data.CurrentSample].Count <= 0)
            {
                this.DataGridForEval.Rows.Clear();
                LogOutputTextBox.Text += "Theres nothing to do" + Environment.NewLine;
                DataGridForEval.Rows.Add("Мат. сподівання","","","","");
                DataGridForEval.Rows.Add("Вибіркова медіана", " --- ", "", " --- ", " --- ");
                DataGridForEval.Rows.Add("Усічене середнє", " --- ", "", " --- ", "");
                DataGridForEval.Rows.Add("Медіана середніх Уолша", " --- ", "", " --- ", " --- ");
                DataGridForEval.Rows.Add("Стандартне відхилення", "", "", "", "");
                DataGridForEval.Rows.Add("МАД", " --- ", "", " --- ", " --- ");
                DataGridForEval.Rows.Add("Коефіцієнт асиметрії", "", "", "", "");
                DataGridForEval.Rows.Add("Коефіцієнт ексцессу", "", "", "", "");
                DataGridForEval.Rows.Add("Коеф. контрексцессу", " --- ", "", " --- ", " --- ");
                DataGridForEval.Rows.Add("КВП", "", "", "", ""); 
                DataGridForEval.Rows.Add("Інтервал передбачення", "", " --- ", "", "");
                DataGridForEval.Rows[0].Cells[4].ReadOnly =  false;
                DataGridForEval.Rows[2].Cells[4].ReadOnly = false;
                DataGridForEval.Rows[4].Cells[4].ReadOnly = false;
                DataGridForEval.Rows[6].Cells[4].ReadOnly = false;
                DataGridForEval.Rows[7].Cells[4].ReadOnly = false;
                DataGridForEval.Rows[9].Cells[4].ReadOnly = false;
                DataGridForEval.Rows[10].Cells[4].ReadOnly = false;
                this.Histogramme.Series[1].Points.Clear();
                this.Histogramme.Series[0].Points.Clear();
                this.DistrFun.Series[0].Points.Clear();
                this.DistrFun.Series[1].Points.Clear();
                this.DistrFun.Series[2].Points.Clear();
                this.DistrFun.Series[3].Points.Clear();
                this.DistrFun.Series[4].Points.Clear();
                toolStripforNumber.Text = "";
                this.DataGridForData.Columns.Clear();
                textBox2_TextChanged(new TextBox(), new EventArgs());
                textBox2_TextChanged(new TextBox(), new EventArgs());
                return;
            }
            if (Data.DataForWork[Data.CurrentSample].Count > 3000)
            {
                if (LogCheckBox.Checked)
                {
                    LogOutputTextBox.Text += "Знаходження медіани середніх Уолша при такій кількості елементів займає занадто багато ресурсів і тому не було проведено " + Environment.NewLine;
                    LogOutputTextBox.Text += "При такії кількості елементів варіаційний ряд не будується " + Environment.NewLine;
                }
                Data.MEDNeeded = false;
                Data.VarNeeded = false;
            }
            toolStripforNumber.Text = "" + Data.DataForWork[Data.CurrentSample].Count + " елементів";
            ProgressBar.Value = 0;
            BuildHistAndDistFunc();
            ProgressBar.Value = 27;
            BuildEval();
            ProgressBar.Value = 54;
            BuildDataTable();
            ProgressBar.Value = 85;
            textBox2_TextChanged(new TextBox(), new EventArgs());
            textBox2_TextChanged(new TextBox(), new EventArgs());
            ProgressBar.Value = 90;
            BuildDistr(Data.TypeOfDistr, Data.Gamma, false);
            ProgressBar.Value = 100;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogOutputTextBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OkCancelDlg it = new OkCancelDlg("Параметри Гістограми", null
                                 ,HistData.NumberOfClasses
                                 ,HistData.ColorOfHist
                                 ,HistData.ColorOfTheor
                                 );
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                if (Data.DataForWork.Count <= 0)
                {
                    LogOutputTextBox.Text += "Theres nothing to do" + Environment.NewLine;
                    return;
                }
                HistData.NumberOfClassesChangedByUser = true; 
                BuildHistAndDistFunc();
                BuildDistr(Data.TypeOfDistr, Data.Gamma, false);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OkCancelDlg it = new OkCancelDlg("Параметри функції розподілу", null 
                                ,DistrFuncData.NumberOfClasses
                                , DistrFuncData.ColorOfClassFunc
                                , DistrFuncData.ColorOfEmpFunc
                                , DistrFuncData.ColorOfLimits
                                , DistrFuncData.ColorOfTheorFunc
                                );
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                if (Data.DataForWork.Count <= 0)
                {
                    LogOutputTextBox.Text += "Theres nothing to do" + Environment.NewLine;
                    return;
                }
                this.DistrFun.Series[0].BorderColor = Color.FromName((string)DistrFuncData.ColorOfClassFunc);
                this.DistrFun.Series[1].BorderColor = Color.FromName((string)DistrFuncData.ColorOfEmpFunc);
                this.DistrFun.Series[2].BorderColor = Color.FromName((string)DistrFuncData.ColorOfLimits);
                this.DistrFun.Series[3].BorderColor = Color.FromName((string)DistrFuncData.ColorOfLimits);
                this.DistrFun.Series[4].BorderColor = Color.FromName((string)DistrFuncData.ColorOfTheorFunc);
                DistrFuncData.NumberOfClassesChangedByUser = true;
                BuildHistAndDistFunc();
                BuildDistr(Data.TypeOfDistr, Data.Gamma, false);
            }
        }

        private void вибратиДвомірнуВибіркуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int temp = Data.TwoDemCurrentSample;
            Data.TwoDemCurrentSample.set(Data.TwoDemCurrentSample + 1);
            OkCancelDlg it = new OkCancelDlg("Виберіть вибірку", null, Data.TwoDemCurrentSample);
            DialogResult rc = it.ShowDialog();
            Data.TwoDemCurrentSample.set(Data.TwoDemCurrentSample - 1);
            if (rc == DialogResult.OK)
            {
                if ((Data.TwoDemCurrentSample < 0) || (Data.TwoDemCurrentSample >= Data.TwoDemSamples.Count))
                {
                    LogOutputTextBox.Text += "Вибірки з таким номером не існує " + Environment.NewLine;
                    Data.TwoDemCurrentSample.set(temp);
                    return;
                }
               // StatusLabelNameOfFile.Text = Data.NamesOfFiles[Data.CurrentSample];
             //   HistData.NumberOfClassesChangedByUser = false;
              //  DistrFuncData.NumberOfClassesChangedByUser = false;
             //   Data.DistrCreated = false;
                BuildTwoDem();
            }
        }

        private void вибратиВибіркуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int temp = Data.CurrentSample;
            Data.CurrentSample.set(Data.CurrentSample + 1);
            OkCancelDlg it = new OkCancelDlg("Виберіть вибірку", null, Data.CurrentSample);
            DialogResult rc = it.ShowDialog();
            Data.CurrentSample.set(Data.CurrentSample - 1);
            if (rc == DialogResult.OK)
            {
                if ((Data.CurrentSample < 0) || (Data.CurrentSample >= Data.DataForWork.Count))
                {
                    LogOutputTextBox.Text += "Вибірки з таким номером не існує " + Environment.NewLine;
                    Data.CurrentSample.set(temp);
                    return;
                }
                StatusLabelNameOfFile.Text = Data.NamesOfFiles[Data.CurrentSample];
                HistData.NumberOfClassesChangedByUser = false;
                DistrFuncData.NumberOfClassesChangedByUser = false;
                Data.DistrCreated = false;
                Build();
            }
        }

        private void експоненціальнийРозподілToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArgIntMM NumberOfElements = new ArgIntMM(100, "", "Кількість елементів", "Кількість елементів", "<>");
            ArgFloatMM lambda = new ArgFloatMM(1, "", "Параметр λ", "Параметр λ", "<>");
            NumberOfElements.setMin(1);
            OkCancelDlg it = new OkCancelDlg("Відтворення експоненціального розподілу", null
                                , NumberOfElements
                                , lambda
                                );
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                if (lambda <= 0)
                {
                    LogOutputTextBox.Text += "Невірне значення λ " + Environment.NewLine;
                    return;
                }
                Data.DataForWork.Add(new List<double>());
                Data.CurrentSample.set(Data.DataForWork.Count - 1);
                Random a = new Random();
                for (int i = 0; i < (int)NumberOfElements; i++)
                {
                    double alfa = (Convert.ToDouble(a.Next(0, 10000) + a.Next(0, 10000) + a.Next(0, 10000)) % 10000) / 10000;
                    Data.DataForWork[Data.CurrentSample].Add(((1 / (float)lambda) * Math.Log(1 / (1 - alfa))));
                }
                //Data.DataForWork[Data.CurrentSample].Sort();
                Data.NamesOfFiles.Add("Автоматично сгенерований експоненціальний розподіл, " + (int)NumberOfElements + " елементів, λ = " + (float)lambda);
                Data.StepBack.Add(new List<ToolsForWork.Changing>());
                StatusLabelNameOfFile.Text = Data.NamesOfFiles[Data.CurrentSample];
                Data.DistrCreated = false;
                Build();
            }
        }

        private void нормальнийРозподілToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArgIntMM NumberOfElements = new ArgIntMM(100, "", "Кількість елементів", "Кількість елементів", "<>");
            ArgFloatMM Sigma = new ArgFloatMM(1, "", "Параметр σ", "Параметр σ", "<>");
            ArgFloatMM ExpVal = new ArgFloatMM(0, "", "Мат. сподівання", "Мат. сподівання", "<>");
            NumberOfElements.setMin(1);
            OkCancelDlg it = new OkCancelDlg("Відтворення нормального розподілу", null
                                , NumberOfElements
                                , Sigma
                                , ExpVal
                                );
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                if (Sigma <= 0)
                {
                    LogOutputTextBox.Text += "Невірне значення σ " + Environment.NewLine;
                    return;
                }
                Data.DataForWork.Add(new List<double>());
                Data.CurrentSample.set(Data.DataForWork.Count - 1);
                Random a = new Random();
                Random b = new Random();
                Random c = new Random();
                for (int i = 0; i < (int)NumberOfElements; i++)
                {
                    double x = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
                    double y = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
                    double s = x * x + y * y;
                    if ((s == 0) || (s > 1))
                    {
                        i--;
                        continue;
                    }
                    double result = y * Math.Pow(((-2*Math.Log(s))/s),0.5);
                    Data.DataForWork[Data.CurrentSample].Add(((float)ExpVal + result * (float)Sigma));
                }
                //Data.DataForWork[Data.CurrentSample].Sort();
                Data.NamesOfFiles.Add("Автоматично сгенерований нормальний розподіл, " + (int)NumberOfElements + " елементів, σ = " + (float)Sigma + ", μ = " + (float)ExpVal);
                Data.StepBack.Add(new List<ToolsForWork.Changing>());
                StatusLabelNameOfFile.Text = Data.NamesOfFiles[Data.CurrentSample];
                Data.DistrCreated = false;
                Build();
            }
        }

        private void рівномірнийРозподілToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArgIntMM NumberOfElements = new ArgIntMM(100, "", "Кількість елементів", "Кількість елементів", "<>");
            ArgFloatMM LeftBorder = new ArgFloatMM(0, "", "Ліва границя", "Ліва границя", "<>");
            ArgFloatMM RightBorder = new ArgFloatMM(1, "", "Права границя", "Права границя", "<>");
            NumberOfElements.setMin(1);
            OkCancelDlg it = new OkCancelDlg("Відтворення рівномірного розподілу", null
                                , NumberOfElements
                                , LeftBorder
                                , RightBorder
                                );
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                if(LeftBorder>=RightBorder)
                {
                    LogOutputTextBox.Text += "Неможливо створити таку вибірку " + Environment.NewLine;
                    return;
                }
                Data.DataForWork.Add(new List<double>());
                Data.CurrentSample.set(Data.DataForWork.Count - 1);
                Random a = new Random();
                Random b = new Random();
                Random c = new Random();
                for (int i = 0; i < (int)NumberOfElements; i++)
                {
                    double x = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 2000);
                    double result = LeftBorder + (RightBorder-LeftBorder)*x;
                    Data.DataForWork[Data.CurrentSample].Add(result);
                }
                //Data.DataForWork[Data.CurrentSample].Sort();
                Data.NamesOfFiles.Add("Автоматично сгенерований рівномірний розподіл, " + (int)NumberOfElements + " елементів, ліва межа = " + (float)LeftBorder + ", права межа =  " + (float)RightBorder);
                Data.StepBack.Add(new List<ToolsForWork.Changing>());
                StatusLabelNameOfFile.Text = Data.NamesOfFiles[Data.CurrentSample];
                Data.DistrCreated = false;
                Build();
            }
        }

        private void розподілАрксинусаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArgIntMM NumberOfElements = new ArgIntMM(100, "", "Кількість елементів", "Кількість елементів", "<>");
            ArgFloatMM Alef = new ArgFloatMM(1, "", "Параметр а", "Параметр а", "<>");
            NumberOfElements.setMin(1);
            OkCancelDlg it = new OkCancelDlg("Відтворення розподілу арксинуса", null
                                , NumberOfElements
                                , Alef
                                );
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                if ( Alef<= 0)
                {
                    LogOutputTextBox.Text += "Невірне значення A " + Environment.NewLine;
                    return;
                }
                Data.DataForWork.Add(new List<double>());
                Data.CurrentSample.set(Data.DataForWork.Count - 1);
                Random a = new Random();
                Random b = new Random();
                Random c = new Random();
                for (int i = 0; i < (int)NumberOfElements; i++)
                {
                    double x = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 2000);
                    double result = Alef*Math.Sin(Math.PI*(x-0.5));
                    Data.DataForWork[Data.CurrentSample].Add(result);
                }
                //Data.DataForWork[Data.CurrentSample].Sort();
                Data.NamesOfFiles.Add("Автоматично сгенерований розподіл арксинуса, " + (int)NumberOfElements + " елементів, параметр а = " + (float)Alef);
                Data.StepBack.Add(new List<ToolsForWork.Changing>());
                StatusLabelNameOfFile.Text = Data.NamesOfFiles[Data.CurrentSample];
                Data.DistrCreated = false;
                Build();
            }
        }

        private void розподілРелеяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArgIntMM NumberOfElements = new ArgIntMM(100, "", "Кількість елементів", "Кількість елементів", "<>");
            ArgFloatMM Sigma = new ArgFloatMM(1, "", "Параметр σ", "Параметр σ", "<>");
            NumberOfElements.setMin(1);
            OkCancelDlg it = new OkCancelDlg("Відтворення розподілу Релея", null
                                , NumberOfElements
                                , Sigma
                                );
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                if (Sigma <= 0)
                {
                    LogOutputTextBox.Text += "Невірне значення σ " + Environment.NewLine;
                    return;
                }
                Data.DataForWork.Add(new List<double>());
                Data.CurrentSample.set(Data.DataForWork.Count - 1);
                Random a = new Random();
                Random b = new Random();
                Random c = new Random();
                for (int i = 0; i < (int)NumberOfElements; i++)
                {
                    double x = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 2000);
                    double result = Math.Sqrt(-2 * (float)Sigma * (float)Sigma * Math.Log(1 - x));
                    Data.DataForWork[Data.CurrentSample].Add(result);
                }
               // Data.DataForWork[Data.CurrentSample].Sort();
                Data.NamesOfFiles.Add("Автоматично сгенерований розподіл Релея, " + (int)NumberOfElements + " елементів, параметр σ = " + (float)Sigma);
                Data.StepBack.Add(new List<ToolsForWork.Changing>());
                StatusLabelNameOfFile.Text = Data.NamesOfFiles[Data.CurrentSample];
                Data.DistrCreated = false;
                Build();
            }
        }

        private void розподілЛапласаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArgIntMM NumberOfElements = new ArgIntMM(100, "", "Кількість елементів", "Кількість елементів", "<>");
            ArgFloatMM Lambda = new ArgFloatMM(1, "", "Параметр λ", "Параметр λ", "<>");
            ArgFloatMM Mu = new ArgFloatMM(0, "", "Параметр μ", "Параметр μ", "<>");
            NumberOfElements.setMin(1);
            OkCancelDlg it = new OkCancelDlg("Відтворення розподілу Лапласа", null
                                , NumberOfElements
                                , Lambda
                                , Mu
                                );
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                if (Lambda <= 0)
                {
                    LogOutputTextBox.Text += "Невірне значення λ " + Environment.NewLine;
                    return;
                }
                Data.DataForWork.Add(new List<double>());
                Data.CurrentSample.set(Data.DataForWork.Count - 1);
                Random a = new Random();
                Random b = new Random();
                Random c = new Random();
                for (int i = 0; i < (int)NumberOfElements/2; i++)
                {
                    double y = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 2000);
                    double result = (Math.Log(2 * y) / (float)Lambda + Mu);
                    if (double.IsInfinity(result))
                    {
                        i--;
                        continue;
                    }
                    Data.DataForWork[Data.CurrentSample].Add(result);
                }
                for (int i = (int)NumberOfElements / 2; i < (int)NumberOfElements ; i++)
                {
                    double y = ((Convert.ToDouble(a.Next(0, 1000) + b.Next(0, 1000) + c.Next(0, 1000)) % 1000) / 1000);
                    double result = (Mu - Math.Log(2 * (1 - y)) / (float)Lambda);
                    if (double.IsInfinity(result))
                    {
                        i--;
                        continue;
                    }
                    Data.DataForWork[Data.CurrentSample].Add(result);
                }
                /*for (int i = 0; i < (int)NumberOfElements; i++)
                {
                    double x = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 2000);
                    double y = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 2000);
                    double result=(x<=0.5)?(Math.Log(2*y)/Lambda+Mu):(Mu-Math.Log(2*(1-y))/Lambda);
                    if (double.IsInfinity(result))
                    {
                        LogOutputTextBox.Text += "Shit happened"  + Environment.NewLine;
                        result = Mu;
                    }
                    Data.DataForWork[Data.CurrentSample].Add(result);
                }*/
                //Data.DataForWork[Data.CurrentSample].Sort();
                Data.NamesOfFiles.Add("Автоматично сгенерований розподіл Лапласа, " + (int)NumberOfElements + " елементів, Параметр λ = " + (float)Lambda + ", Параметр μ =  " + (float)Mu);
                Data.StepBack.Add(new List<ToolsForWork.Changing>());
                StatusLabelNameOfFile.Text = Data.NamesOfFiles[Data.CurrentSample];
                Data.DistrCreated = false;
                Build();
            }
        }

        private void розподілВуйбуллаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArgIntMM NumberOfElements = new ArgIntMM(100, "", "Кількість елементів", "Кількість елементів", "<>");
            ArgFloatMM Alfa = new ArgFloatMM(1, "", "Параметр α", "Параметр α", "<>");
            ArgFloatMM Beta = new ArgFloatMM(1, "", "Параметр β", "Параметр β", "<>");
            NumberOfElements.setMin(1);
            OkCancelDlg it = new OkCancelDlg("Відтворення розподілу Вейбулла", null
                                , NumberOfElements
                                , Alfa
                                , Beta 
                                );
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                if (Alfa<= 0 || Beta <=0)
                {
                    LogOutputTextBox.Text += "Невірне значення α або β " + Environment.NewLine;
                    return;
                }
                Data.DataForWork.Add(new List<double>());
                Data.CurrentSample.set(Data.DataForWork.Count - 1);
                Random a = new Random();
                Random b = new Random();
                Random c = new Random();
                for (int i = 0; i < (int)NumberOfElements; i++)
                {
                    double x = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 2000);
                    double result = Math.Pow(-1*(float)Alfa*Math.Log(1-x),1.0/(float)Beta);
                    Data.DataForWork[Data.CurrentSample].Add(result);
                }
                //Data.DataForWork[Data.CurrentSample].Sort();
                Data.NamesOfFiles.Add("Автоматично сгенерований розподіл Вейбулла, " + (int)NumberOfElements + " елементів, α = " + (float)Alfa + ", β = " + (float)Beta);
                Data.StepBack.Add(new List<ToolsForWork.Changing>());
                StatusLabelNameOfFile.Text = Data.NamesOfFiles[Data.CurrentSample];
                Data.DistrCreated = false;
                Build();
            }
        }

        private void DataGridForEval_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Data.CurrentSample < 0 || Data.CurrentSample >= Data.DataForWork.Count || Data.DataForWork[Data.CurrentSample].Count == 0)
            {
                LogOutputTextBox.Text += "Theres nothing to do" + Environment.NewLine;
                return;
            }
            BuildTrunMean();
            ComputeBordersForExpVal();
            ComputeBordersForStandDev();
            ComputeKurtosisBorders();
            ComputeSkewnessBorders();
            ComputeBordersForCoV();
            ComputeForeseenBorders();
        }

        private void DataGridForData_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            for (int i = 0; i < Data.TwoDemSamples.Count; i++)
            {
                if (Data.CurrentSample == Data.TwoDemSamples[i][0] || Data.CurrentSample == Data.TwoDemSamples[i][1])
                {
                    LogOutputTextBox.Text += "U cant delete what is part of two dimentional world!" + Environment.NewLine;
                    e.Cancel = true;
                }
            }
            int j;
            for (int i = 0; i < Data.MultiDemSamples.Count; i++)
            {
                for (j = 0; j < Data.MultiDemSamples[i].Length; j++)
                {
                    if (Data.CurrentSample == Data.MultiDemSamples[i][j])
                    {
                        LogOutputTextBox.Text += "U cant delete what is part of multi dimentional world!" + Environment.NewLine;
                        e.Cancel = true;
                    }
                }
            }
        }

        private void DataGridForData_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            double delVal = Convert.ToDouble(e.Row.Cells[3].Value);
            double[] FW = new double[2];
            FW[0] = delVal;
            FW[1] = 0;
            while (Data.DataForWork[Data.CurrentSample].Contains(delVal))
            {
                FW[1]++;
                Data.DataForWork[Data.CurrentSample].Remove(delVal);
            }
            Data.StepBack[Data.CurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.deleted, FW));
            Data.DistrCreated = false;
            UpdateForm(Data.CurrentSample);
        }

        private void MakeStepBack()
        {
            if (Data.StepBack[Data.CurrentSample].Count == 0)
            {
                return;
            }
            ToolsForWork.Changing FW = Data.StepBack[Data.CurrentSample][Data.StepBack[Data.CurrentSample].Count - 1];
            Data.StepBack[Data.CurrentSample].RemoveAt(Data.StepBack[Data.CurrentSample].Count - 1);
            switch (FW.ChangeStyle)
            {
                case (ToolsForWork.TypeOfCHange.standardized):
                    {
                        for (int i = 0; i < Data.DataForWork[Data.CurrentSample].Count; i++)
                        {
                            Data.DataForWork[Data.CurrentSample][i] = Convert.ToDouble(Data.DataForWork[Data.CurrentSample][i]) * FW.paramsOfChange[1] + FW.paramsOfChange[0];
                        }
                        break;
                    }
                case (ToolsForWork.TypeOfCHange.logarithm):
                    {
                        for (int i = 0; i < Data.DataForWork[Data.CurrentSample].Count; i++)
                        {
                            Data.DataForWork[Data.CurrentSample][i] = Math.Pow(FW.paramsOfChange[0], Convert.ToDouble(Data.DataForWork[Data.CurrentSample][i]));
                        }
                        //Data.DataForWork[Data.CurrentSample].Sort();
                        break;
                    }
                case (ToolsForWork.TypeOfCHange.sliped):
                    {
                        for (int i = 0; i < Data.DataForWork[Data.CurrentSample].Count; i++)
                        {
                            Data.DataForWork[Data.CurrentSample][i] = Convert.ToDouble(Data.DataForWork[Data.CurrentSample][i]) - FW.paramsOfChange[0];
                        }
                        break;
                    }
                case (ToolsForWork.TypeOfCHange.powered):
                    {
                        for (int i = 0; i < Data.DataForWork[Data.CurrentSample].Count; i++)
                        {
                            Data.DataForWork[Data.CurrentSample][i] = Math.Pow(Data.DataForWork[Data.CurrentSample][i], 1.0 / FW.paramsOfChange[0]);
                        }
                        break;
                    }
                case (ToolsForWork.TypeOfCHange.deleted):
                    {
                        for (int i = 0; i < Data.TwoDemSamples.Count; i++)
                        {
                            if (Data.CurrentSample == Data.TwoDemSamples[i][0] || Data.CurrentSample == Data.TwoDemSamples[i][1])
                            {
                                LogOutputTextBox.Text += "Returning values to two-dim sample currently isnt supported" + Environment.NewLine;
                                return;
                            }
                        }
                        int j;
                        for (int i = 0; i < Data.MultiDemSamples.Count; i++)
                        {
                            for (j = 0; j < Data.MultiDemSamples[i].Length; j++)
                            {
                                if (Data.CurrentSample == Data.MultiDemSamples[i][j])
                                {
                                    LogOutputTextBox.Text += "Returning values to multidim samples shall be done by specialised button" + Environment.NewLine;
                                    return;
                                }
                            }
                        }
                        for (int i = 0; i < FW.paramsOfChange[1]; i++)
                        {
                            //Console.WriteLine("" + FW.paramsOfChange[0] );
                            Data.DataForWork[Data.CurrentSample].Add(FW.paramsOfChange[0]);
                        }
                        //Data.DataForWork[Data.CurrentSample].Sort();
                        break;
                    }
                case (ToolsForWork.TypeOfCHange.multiplyed):
                    {
                        for (int i = 0; i < Data.DataForWork[Data.CurrentSample].Count; i++)
                        {
                            Data.DataForWork[Data.CurrentSample][i] = Data.DataForWork[Data.CurrentSample][i] * (1.0 / FW.paramsOfChange[0]);
                        }
                        //Data.DataForWork[Data.CurrentSample].Sort();
                        break;
                    }
                case (ToolsForWork.TypeOfCHange.massivedelete):
                    {
                        for (int i = 0; i < FW.paramsOfChange[0]; i++)
                        {
                            MakeStepBack();
                        }
                        //Data.DataForWork[Data.CurrentSample].Sort();
                        break;
                    }
                case (ToolsForWork.TypeOfCHange.added):
                    {
                        Data.DataForWork[Data.CurrentSample].Remove(FW.paramsOfChange[0]);
                        //Data.DataForWork[Data.CurrentSample].Sort();
                        break;
                    }
            }
        }

        private void крокНазадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Data.DataForWork.Count <= 0)
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Нема з чим працювати " + Environment.NewLine;
                return;
            }
            MakeStepBack();
            Data.DistrCreated = false;
            UpdateForm(Data.CurrentSample);
        }

        private void доПочатковихЗначеньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Data.DataForWork.Count <= 0)
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Нема з чим працювати " + Environment.NewLine;
                return;
            }
            while (Data.StepBack[Data.CurrentSample].Count != 0)
            {
                MakeStepBack();
            }
            Data.DistrCreated = false;
            UpdateForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Data.DataForWork.Count <= 0)
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Нема з чим працювати " + Environment.NewLine;
                return;
            }
            if (Data.EvalData.StandDevNeZ == 0)
            {
                LogOutputTextBox.Text += "Неможливо провести стандартизацію для таких даних" + Environment.NewLine;
                return;
            }
            {
                double[] FW = new double[2];
                FW[0] = Data.EvalData.ExpValues;
                FW[1] = Data.EvalData.StandDevNeZ;
                Data.StepBack[Data.CurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.standardized, FW));
            }
            for (int i = 0; i < Data.DataForWork[Data.CurrentSample].Count; i++)
            {
                Data.DataForWork[Data.CurrentSample][i] = (Data.DataForWork[Data.CurrentSample][i] - Data.EvalData.ExpValues) / Data.EvalData.StandDevNeZ;
            }
            if(LogCheckBox.Checked)
                LogOutputTextBox.Text += "Було проведено стандартизацію " + Environment.NewLine;
            Data.DistrCreated = false;
            UpdateForm(Data.CurrentSample);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((Data.DataForWork.Count <= 0) || (Data.DataForWork[Data.CurrentSample].Count <=0))
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Нема з чим працювати " + Environment.NewLine;
                return;
            }
            ArgStr TypeOfOperation = new ArgStr(PossibleOperations.operations[0], "", "Виберіть операцію", "Операція, яка буде проведена над вибіркою", "<color>", PossibleOperations.operations);
            ArgFloatMM Parameter = new ArgFloatMM(0, "", "Параметр для операції", "основа логарифму, степінь, дальність зсуву", "<Size>");
            OkCancelDlg it = new OkCancelDlg("Виберіть дію", null, TypeOfOperation, Parameter);
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                switch ((string)TypeOfOperation)
                {
                    case "Зсув":
                        {
                            {
                                double[] FW = new double[2];
                                FW[0] = (double)Parameter;
                                Data.StepBack[Data.CurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.sliped, FW));
                            }
                            for (int i = 0; i < Data.DataForWork[Data.CurrentSample].Count; i++)
                            {
                                Data.DataForWork[Data.CurrentSample][i] = Data.DataForWork[Data.CurrentSample][i] + (double)Parameter;
                            }
                            if(LogCheckBox.Checked)
                                LogOutputTextBox.Text += "Було проведено зсув" + Environment.NewLine;
                            break;
                        }
                    case "Логарифмування":
                        {
                            if (((double)Parameter <= 0) || ((double)Parameter == 1))
                            {
                                LogOutputTextBox.Text += "Неможливо прологарифмувати по такій основі" + Environment.NewLine;
                                return;
                            }
                            for (int i = 0; i < Data.DataForWork[Data.CurrentSample].Count; i++)
                            {
                                if (Data.DataForWork[Data.CurrentSample][i] < 0)
                                {
                                    LogOutputTextBox.Text += "Неможливо прологарифмувати відємні числа. Спробуйте провести зсув вправо" + Environment.NewLine;
                                    return;
                                }
                            }
                            {
                                double[] FW = new double[2];
                                FW[0] = (double)Parameter;
                                Data.StepBack[Data.CurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.logarithm, FW));
                            }
                            for (int i = 0; i < Data.DataForWork[Data.CurrentSample].Count; i++)
                            {
                                Data.DataForWork[Data.CurrentSample][i] = Math.Log(Data.DataForWork[Data.CurrentSample][i], (double)Parameter);
                            }
                            if (LogCheckBox.Checked)
                                LogOutputTextBox.Text += "Було проведено логарифмування" + Environment.NewLine;
                            //Data.DataForWork[Data.CurrentSample].Sort();
                            break;
                        }
                    case "Піднесення у степінь":
                        {
                            for (int i = 0; i < Data.DataForWork[Data.CurrentSample].Count; i++)
                            {
                                if (Data.DataForWork[Data.CurrentSample][i] < 0)
                                {
                                    LogOutputTextBox.Text += "Неможливо прологарифмувати відємні числа. Спробуйте провести зсув вправо" + Environment.NewLine;
                                    return;
                                }
                            }
                            {
                                double[] FW = new double[2];
                                FW[0] = (double)Parameter;
                                Data.StepBack[Data.CurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.powered, FW));
                            }
                            for (int i = 0; i < Data.DataForWork[Data.CurrentSample].Count; i++)
                            {
                                Data.DataForWork[Data.CurrentSample][i] = Math.Pow(Data.DataForWork[Data.CurrentSample][i], (double)Parameter);
                            }
                            if (LogCheckBox.Checked)
                                LogOutputTextBox.Text += "Було проведено підведення у степінь" + Environment.NewLine;
                           // Data.DataForWork[Data.CurrentSample].Sort();
                            break;
                        }
                    case "Множення":
                        {
                            if ((double)Parameter == 0)
                            {
                                LogOutputTextBox.Text += "Множення на 0 безсенсне" + Environment.NewLine;
                                return;
                            }
                            {
                                double[] FW = new double[2];
                                FW[0] = (double)Parameter;
                                Data.StepBack[Data.CurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.multiplyed, FW));
                            }
                            for (int i = 0; i < Data.DataForWork[Data.CurrentSample].Count; i++)
                            {
                                Data.DataForWork[Data.CurrentSample][i] =Data.DataForWork[Data.CurrentSample][i]* (double)Parameter;
                            }
                            if (LogCheckBox.Checked)
                                LogOutputTextBox.Text += "Було проведено множення на число" + Environment.NewLine;
                           // Data.DataForWork[Data.CurrentSample].Sort();
                            break;
                        }

                }
                Data.DistrCreated = false;
                UpdateForm(Data.CurrentSample);
            }
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Data.DataForWork.Count <= 0)
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Нема з чим працювати " + Environment.NewLine;
                return;
            }
           // Stream myStream;
            SaveFileDialog savingFileDialog = new SaveFileDialog();
            savingFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            savingFileDialog.FilterIndex = 2;
            savingFileDialog.RestoreDirectory = true;
            savingFileDialog.RestoreDirectory = true;
            if (savingFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter FileToWrite = new System.IO.StreamWriter(savingFileDialog.FileName, true))
                {
                    for (int i = 0; i < Data.DataForWork[Data.CurrentSample].Count; i++)
                    {
                        FileToWrite.WriteLine(Data.DataForWork[Data.CurrentSample][i]);
                    }
                }
            }
        }

        private void довідкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Колись тут буде довідка, яка вам допоможе \n Віктор Полуянов  \n Εμείς - τα παιδιά του ήλιου");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double leftvalue = 0;
            double rightvalue = 0;
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                try
                {
                    leftvalue = Convert.ToDouble(textBox1.Text);
                    rightvalue = Convert.ToDouble(textBox2.Text);
                }
                catch
                {
                    TextBoxForDelete.Text = "Одна з границь введена невірно";
                    return;
                }
                if (rightvalue < leftvalue)
                {
                    TextBoxForDelete.Text = "Права границя не може бути більше лівої";
                    return;
                }
                if (Data.DataForWork.Count <= 0)
                {
                    TextBoxForDelete.Text = "Вибірка відсутня";
                    return;
                }
                int i = 0;
                for (; (i < Data.DataForWork[Data.CurrentSample].Count) && (Data.DataForWork[Data.CurrentSample][i] < leftvalue); i++)
                { }
                if (i == Data.DataForWork[Data.CurrentSample].Count)
                {
                    TextBoxForDelete.Text = "На данному проміжку нема жодного елемента";
                    return;
                }
                if ((Data.DataForWork[Data.CurrentSample][i] < leftvalue) || (Data.DataForWork[Data.CurrentSample][i]>rightvalue))
                {
                    TextBoxForDelete.Text = "На данному проміжку нема жодного елемента";
                    return;
                }
                int j = 0;
                for (; (i < Data.DataForWork[Data.CurrentSample].Count) && (Data.DataForWork[Data.CurrentSample][i] >= leftvalue) && (Data.DataForWork[Data.CurrentSample][i] <= rightvalue);j++, i++ )
                { 
                }
                double procent = (double)j / Data.DataForWork[Data.CurrentSample].Count;
                TextBoxForDelete.Text = "На цьому проміжку " + j + " елементів, " + Math.Round(procent, Data.NumberOfNum) * 100 + "% від загальної кількіості";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double leftvalue = 0;
            double rightvalue = 0;
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                try
                {
                    leftvalue = Convert.ToDouble(textBox1.Text);
                    rightvalue = Convert.ToDouble(textBox2.Text);
                }
                catch
                {
                    TextBoxForDelete.Text = "Одна з границь введена невірно";
                    return;
                }
                if (rightvalue < leftvalue)
                {
                    TextBoxForDelete.Text = "Права границя не може бути більше лівої";
                    return;
                }
                if (Data.DataForWork.Count <= 0)
                {
                    TextBoxForDelete.Text = "Вибірка відсутня";
                    return;
                }
                int i = 0;
                for (; (i < Data.DataForWork[Data.CurrentSample].Count) && (Data.DataForWork[Data.CurrentSample][i] < leftvalue); i++)
                { }
                if (i == Data.DataForWork[Data.CurrentSample].Count)
                {
                    TextBoxForDelete.Text = "На данному проміжку нема жодного елемента";
                    return;
                }
                if ((Data.DataForWork[Data.CurrentSample][i] < leftvalue) || (Data.DataForWork[Data.CurrentSample][i] > rightvalue))
                {
                    TextBoxForDelete.Text = "На данному проміжку нема жодного елемента";
                    return;
                }
                int j = 0;
                for (; (i < Data.DataForWork[Data.CurrentSample].Count) && (Data.DataForWork[Data.CurrentSample][i] > leftvalue) && (Data.DataForWork[Data.CurrentSample][i] < rightvalue); j++, i++)
                {
                }
                double procent = (double)j / Data.DataForWork[Data.CurrentSample].Count;
                TextBoxForDelete.Text = "На цьому проміжку " + j + " елементів, " + Math.Round(procent, Data.NumberOfNum) * 100 + "% від загальної кількіості";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Data.TwoDemSamples.Count; i++)
            {
                if (Data.CurrentSample == Data.TwoDemSamples[i][0] || Data.CurrentSample == Data.TwoDemSamples[i][1])
                {
                    LogOutputTextBox.Text += "U cant delete what is part of two dimentional world!" + Environment.NewLine;
                    return;
                }
            }
            int j;
            for (int i = 0; i < Data.MultiDemSamples.Count; i++)
            {
                for (j = 0; j < Data.MultiDemSamples[i].Length; j++)
                {
                    if (Data.CurrentSample == Data.MultiDemSamples[i][j])
                    {
                        LogOutputTextBox.Text += "U cant delete what is part of multi dimentional world!" + Environment.NewLine;
                        return;
                    }
                }
            }
            double leftvalue = 0;
            double rightvalue = 0;
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                leftvalue = Convert.ToDouble(textBox1.Text);
                rightvalue = Convert.ToDouble(textBox2.Text);
                if (rightvalue < leftvalue)
                {
                    return;
                }
                if (Data.DataForWork.Count <= 0)
                {
                    return;
                }
                int i = 0;
                for (; (i < Data.DataForWork[Data.CurrentSample].Count) && (Data.DataForWork[Data.CurrentSample][i] < leftvalue); i++)
                { }
                if (i == Data.DataForWork[Data.CurrentSample].Count)
                {
                    return;
                }
                if ((Data.DataForWork[Data.CurrentSample][i] < leftvalue) || (Data.DataForWork[Data.CurrentSample][i] > rightvalue))
                {
                    return;
                }
                j = 0;
                for (; (i < Data.DataForWork[Data.CurrentSample].Count) && (Data.DataForWork[Data.CurrentSample][i] > leftvalue) && (Data.DataForWork[Data.CurrentSample][i] < rightvalue); j++)
                {
                    double[] FW = new double[2];
                    FW[0] = Data.DataForWork[Data.CurrentSample][i];
                    FW[1] = 1;
                    Data.StepBack[Data.CurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.deleted, FW));
                    Data.DataForWork[Data.CurrentSample].RemoveAt(i);
                }
                double[] ForW = new double[2];
                ForW[0] = j;
                ForW[1] = 0;
                Data.StepBack[Data.CurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.massivedelete, ForW));
                Data.DistrCreated = false;
                UpdateForm(Data.CurrentSample);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Data.TwoDemSamples.Count; i++)
            {
                if (Data.CurrentSample == Data.TwoDemSamples[i][0] || Data.CurrentSample == Data.TwoDemSamples[i][1])
                {
                    LogOutputTextBox.Text += "U shall use special two-dem button to delete anomalies from two-dem samples" + Environment.NewLine;
                    return;
                }
            }
            int j;
            for (int i = 0; i < Data.MultiDemSamples.Count; i++)
            {
                for (j = 0; j < Data.MultiDemSamples[i].Length; j++)
                {
                    if (Data.CurrentSample == Data.MultiDemSamples[i][j])
                    {
                        LogOutputTextBox.Text += "U shall use special multi-dem button to delete anomalies from two-dem samples" + Environment.NewLine;
                        return;
                    }
                }
            }
            if (Data.DataForWork.Count <= 0 || Data.DataForWork[Data.CurrentSample].Count == 0)
            {
                return;
            }
            Data.DataForWork[Data.CurrentSample].Sort();
            double gamma = 0.05;
            try
            {
                gamma = Convert.ToDouble(TextBoxForPos.Text);
            }
            catch (Exception)
            {
                TextBoxForPos.Text = "0,05";
                gamma = 0.05;
            }
            if ((gamma <= 0) || (gamma >= 1))
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Хибне значення γ для видалення аномальних значень" + Environment.NewLine;
                TextBoxForPos.Text = "0,05";
                gamma = 0.05;
            }
            double coef = Quantile.StanQuanDv(gamma / 2);
            j = 0;
            for (int i = 0;(Data.DataForWork[Data.CurrentSample].Count > 0)&&( Data.DataForWork[Data.CurrentSample][i] < Data.EvalData.ExpValues - Data.EvalData.StandDevZ*coef) ;j++)
            {
                double[] FW = new double[2];
                FW[0] = Data.DataForWork[Data.CurrentSample][i];
                FW[1] = 1;
                Data.StepBack[Data.CurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.deleted, FW));
                Data.DataForWork[Data.CurrentSample].RemoveAt(i);
            }
            if (!(Data.DataForWork[Data.CurrentSample].Count == 0))
            {
                for (int i = Data.DataForWork[Data.CurrentSample].Count - 1; (Data.DataForWork[Data.CurrentSample].Count > 0) && (Data.DataForWork[Data.CurrentSample][i] > Data.EvalData.ExpValues + Data.EvalData.StandDevZ * coef); j++, i--)
                {
                    double[] FW = new double[2];
                    FW[0] = Data.DataForWork[Data.CurrentSample][i];
                    FW[1] = 1;
                    Data.StepBack[Data.CurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.deleted, FW));
                    Data.DataForWork[Data.CurrentSample].RemoveAt(i);
                }
            }
            double[] ForW = new double[2];
            ForW[0] = j;
            ForW[1] = 0;
            Data.StepBack[Data.CurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.massivedelete, ForW));
            Data.DistrCreated = false;
            UpdateForm(Data.CurrentSample);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Data.DataForWork.Count <= 0 || Data.DataForWork[Data.CurrentSample].Count == 0 || Data.EvalData.ExpValues == 0)
            {
                return;
            }
            for (int i = 0; i < Data.TwoDemSamples.Count; i++)
            {
                if (Data.CurrentSample == Data.TwoDemSamples[i][0] || Data.CurrentSample == Data.TwoDemSamples[i][1])
                {
                    LogOutputTextBox.Text += "U shall use special two-dem button to deleta anomalies from two-dem samples" + Environment.NewLine;
                    return;
                }
            }
            int j;
            for (int i = 0; i < Data.MultiDemSamples.Count; i++)
            {
                for (j = 0; j < Data.MultiDemSamples[i].Length; j++)
                {
                    if (Data.CurrentSample == Data.MultiDemSamples[i][j])
                    {
                        LogOutputTextBox.Text += "U shall use special multi-dem button to delete anomalies from two-dem samples" + Environment.NewLine;
                        return;
                    }
                }
            }
            Data.DataForWork[Data.CurrentSample].Sort();
            double gamma = 0.05;
            try
            {
                gamma = Convert.ToDouble(TextBoxForPos.Text);
            }
            catch (Exception)
            {
                TextBoxForPos.Text = "0,05";
                gamma = 0.05;
            }
            if ((gamma <= 0) || (gamma >= 1))
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Хибне значення γ для видалення аномальних значень" + Environment.NewLine;
                TextBoxForPos.Text = "0,05";
                gamma = 0.05;
            }
            j = 0;
            for (int i = 0; Data.DataForWork[Data.CurrentSample][i] < 0; j++)
            {
                double[] FW = new double[2];
                FW[0] = Data.DataForWork[Data.CurrentSample][i];
                FW[1] = 1;
                Data.StepBack[Data.CurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.deleted, FW));
                Data.DataForWork[Data.CurrentSample].RemoveAt(i);   
            }
            double lol = (-1*Data.EvalData.ExpValues) * Math.Log(gamma);//(-1.0 / Data.EvalData.ExpValues) * Math.Log(gamma);
            if (!(Data.DataForWork[Data.CurrentSample].Count == 0))
            {
                for (int i = Data.DataForWork[Data.CurrentSample].Count - 1;(Data.DataForWork[Data.CurrentSample].Count > 0)&& Data.DataForWork[Data.CurrentSample][i] > (-1*Data.EvalData.ExpValues) * Math.Log(gamma); j++, i--)
                {
                    double[] FW = new double[2];
                    FW[0] = Data.DataForWork[Data.CurrentSample][i];
                    FW[1] = 1;
                    Data.StepBack[Data.CurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.deleted, FW));
                    Data.DataForWork[Data.CurrentSample].RemoveAt(i);
                }
            }
            double[] ForW = new double[2];
            ForW[0] = j;
            ForW[1] = 0;
            Data.StepBack[Data.CurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.massivedelete, ForW));
            Data.DistrCreated = false;
            UpdateForm(Data.CurrentSample);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Data.TwoDemSamples.Count; i++)
            {
                if (Data.CurrentSample == Data.TwoDemSamples[i][0] || Data.CurrentSample == Data.TwoDemSamples[i][1])
                {
                    LogOutputTextBox.Text += "U shall use special two-dem button to deleta anomalies from two-dem samples" + Environment.NewLine;
                    return;
                }
            }
            int j;
            for (int i = 0; i < Data.MultiDemSamples.Count; i++)
            {
                for (j = 0; j < Data.MultiDemSamples[i].Length; j++)
                {
                    if (Data.CurrentSample == Data.MultiDemSamples[i][j])
                    {
                        LogOutputTextBox.Text += "U shall use special multi-dem button to delete anomalies from two-dem samples" + Environment.NewLine;
                        return;
                    }
                }
            }
            if (Data.DataForWork.Count <= 0 || Data.DataForWork[Data.CurrentSample].Count == 0)
            {
                return;
            }
            Data.DataForWork[Data.CurrentSample].Sort();
            j = 0;
            for (int i = 0; Data.DataForWork[Data.CurrentSample].Count != 0 && Data.DataForWork[Data.CurrentSample][i] < 0; j++)
            {
                double[] FW = new double[2];
                FW[0] = Data.DataForWork[Data.CurrentSample][i];
                FW[1] = 1;
                Data.StepBack[Data.CurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.deleted, FW));
                Data.DataForWork[Data.CurrentSample].RemoveAt(i);
            }
            double[] ForW = new double[2];
            ForW[0] = j;
            ForW[1] = 0;
            Data.StepBack[Data.CurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.massivedelete, ForW));
            Data.DistrCreated = false;
            UpdateForm(Data.CurrentSample);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Data.DataForWork.Count == 0)
            {
                LogOutputTextBox.Text += "Nothing to work with" + Environment.NewLine;
                return;
            }
            for (int i = 0; i < Data.TwoDemSamples.Count; i++)
            {
                if (Data.CurrentSample == Data.TwoDemSamples[i][0] || Data.CurrentSample == Data.TwoDemSamples[i][1])
                {
                    LogOutputTextBox.Text += "U shall use special two-dem button to deleta anomalies from two-dem samples" + Environment.NewLine;
                    return;
                }
            }
            int j;
            for (int i = 0; i < Data.MultiDemSamples.Count; i++)
            {
                for (j = 0; j < Data.MultiDemSamples[i].Length; j++)
                {
                    if (Data.CurrentSample == Data.MultiDemSamples[i][j])
                    {
                        LogOutputTextBox.Text += "U shall use special multi-dem button to delete anomalies from two-dem samples" + Environment.NewLine;
                        return;
                    }
                }
            }
            Data.DataForWork[Data.CurrentSample].Sort();
            if ( Data.DataForWork[Data.CurrentSample].Count == 0)
            {
                return;
            }
            double t1 = 2 + 0.2*Math.Log(0.04*Data.DataForWork[Data.CurrentSample].Count);
            double t2 = Math.Sqrt(19*Math.Sqrt(Data.EvalData.KurtosisZ + 2) + 1);
            double FinalLeftT = t1;
            double FinalRightT = t1;
            if (Math.Abs(Data.EvalData.Skewness) <= 0.2)
            {
                 if(Data.EvalData.Skewness>0.2)
                     FinalRightT = t2;
                 else
                     FinalLeftT = t2;
            }
            j = 0;
            for (int i = 0; Data.DataForWork[Data.CurrentSample][i] < Data.EvalData.ExpValues - FinalLeftT * Data.EvalData.StandDevNeZ; j++)
            {
                double[] FW = new double[2];
                FW[0] = Data.DataForWork[Data.CurrentSample][i];
                FW[1] = 1;
                Data.StepBack[Data.CurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.deleted, FW));
                Data.DataForWork[Data.CurrentSample].RemoveAt(i);
            }
            for (int i = Data.DataForWork[Data.CurrentSample].Count - 1; Data.DataForWork[Data.CurrentSample][i] > Data.EvalData.ExpValues + FinalRightT * Data.EvalData.StandDevNeZ; j++, i--)
            {
                double[] FW = new double[2];
                FW[0] = Data.DataForWork[Data.CurrentSample][i];
                FW[1] = 1;
                Data.StepBack[Data.CurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.deleted, FW));
                Data.DataForWork[Data.CurrentSample].RemoveAt(i);
            }
            double[] ForW = new double[2];
            ForW[0] = j;
            ForW[1] = 0;
            Data.StepBack[Data.CurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.massivedelete, ForW));
            Data.DistrCreated = false;
            UpdateForm(Data.CurrentSample);

        }

        private void BuildDistr(ArgStr TypeOfDistr,ArgFloatMM Gamma, bool CalledByUser)
        {
            if (Data.DataForWork[Data.CurrentSample].Count < 2)
            {
                LogOutputTextBox.Text += "Малувато елементів. Спробуйте побільше" + Environment.NewLine;
                return;
            }
            if (!Data.DistrCreated)
            {
                return;
            }
            if (Data.EvalData.StandDevNeZ == 0)
            {
                LogOutputTextBox.Text += "Сам таку вибірку моделюй" + Environment.NewLine;
                return;
            }
            List<double> Temp = new List<double>();
            for (int i = 0; i < Data.DataForWork[Data.CurrentSample].Count; i++)
            {
                Temp.Add(Data.DataForWork[Data.CurrentSample][i]);
            }
            Temp.Sort();
                switch ((string)TypeOfDistr)
                {
                    // "Експоненціальний", "Нормальний", "Релея", "Арксинуса"  ,"Арксинуса", "Лапласа", "Рівномірний","Вейбулла"
                    case "Експоненціальний":
                        {
                            if (Temp[0] < 0)
                            {
                                LogOutputTextBox.Text += "Неможливо відтворити експоненціальний розподіл при відємних значеннях" + Environment.NewLine;
                                return;
                            }
                            this.Histogramme.Series[1].Points.Clear();
                            this.DistrFun.Series[2].Points.Clear();
                            this.DistrFun.Series[3].Points.Clear();
                            this.DistrFun.Series[4].Points.Clear();
                            double lambda = 1.0 / Data.EvalData.ExpValues;
                            double displambda = (lambda * lambda) / Temp.Count;
                            if (CalledByUser)
                            {
                                textBox3.Text += "Вибірку оцінено як експоненціальний розподіл, параметр λ =  " + Math.Round(lambda, Data.NumberOfNum) + ", його дисперсія - " + Math.Round(displambda, Data.NumberOfNum) + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "Вибірку оцінено як експоненціальний розподіл, параметр λ =  " + Math.Round(lambda, Data.NumberOfNum) + ", його дисперсія - " + Math.Round(displambda, Data.NumberOfNum) + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                            // this.FirstChart.Series[1].Points.Clear();
                            double quan = Quantile.StanQuanDv(Gamma);
                            double x;
                            Data.Parameters = new double[] { lambda, 0 };
                            double lambDisp = (lambda * lambda) / Temp.Count;
                            for (double i = 0; i < Temp[Temp.Count - 1]; i += Temp[Temp.Count - 1] / 2500)
                            {
                                double yVal = (Math.Pow(Math.E, -1 * lambda * i) * lambda) * HistData.Step;//((1000) / (HistData.NumberOfClasses * Sum));//HistData.Step;
                                this.Histogramme.Series[1].Points.AddXY(i, yVal);
                                yVal = ToolsForWork.ComputeDistrExp(i, Data.Parameters);
                                this.DistrFun.Series[4].Points.AddXY(i, yVal);
                                this.DistrFun.Series[2].Points.AddXY(i, ((x = yVal + quan * Math.Sqrt(i * i * Math.Pow(Math.E, -2 * lambda * i) * lambDisp)) > 1) ? 1 : x);
                                this.DistrFun.Series[3].Points.AddXY(i, ((x = yVal - quan * Math.Sqrt(i * i * Math.Pow(Math.E, -2 * lambda * i) * lambDisp)) < 0) ? 0 : x);
                            }
                            break;
                        }
                    case "Арксинуса":
                        {
                            this.Histogramme.Series[1].Points.Clear();
                            this.DistrFun.Series[2].Points.Clear();
                            this.DistrFun.Series[3].Points.Clear();
                            this.DistrFun.Series[4].Points.Clear();
                            double alef = Math.Sqrt(2) * Data.EvalData.StandDevZ;
                            if (Temp[0] > (1.1) * alef || Temp[Temp.Count - 1] < -1.1 * alef)
                            {
                                LogOutputTextBox.Text += "Ваша вибірка не належить до класу розподілів арксинуса" + Environment.NewLine;
                                return;
                            }
                            //double dispalef = (Math.Pow(alef,4)) / (8*Temp.Count);
                            double dispalef = (Math.Sqrt(2) / (2 * Data.EvalData.StandDevZ)) * ((ToolsForWork.ComputeCentralMoment(Temp, 4) - Math.Pow(ToolsForWork.ComputeCentralMoment(Temp, 2), 2))) / Temp.Count;
                            //(2^0.5*(Nu4-Nu2^2))/(2*S*N)
                            if (CalledByUser)
                            {
                                textBox3.Text += "Вибірку оцінено як розподіл арксинуса, параметр а =  " + Math.Round(alef, Data.NumberOfNum) + ", його дисперсія - " + Math.Round(dispalef, Data.NumberOfNum) + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "Вибірку оцінено як розподіл арксинуса, параметр а =  " + Math.Round(alef, Data.NumberOfNum) + ", його дисперсія - " + Math.Round(dispalef, Data.NumberOfNum) + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                            double quan = Quantile.StanQuanOdn(Gamma);
                            double x;
                            for (double i = (-0.99) * alef; i <= (0.99) * alef; i += Temp[Temp.Count - 1] / 1000)
                            {
                                double yVal = (1.0 / (Math.PI * Math.Sqrt(alef * alef - i * i))) * HistData.Step;//((1000) / (HistData.NumberOfClasses * Sum));//HistData.Step;
                                this.Histogramme.Series[1].Points.AddXY(i, yVal);
                            }
                            Data.Parameters = new double[] { alef, 0 };
                            //for (double i = Temp[0]; i < Temp[Temp.Count - 1]; i += Temp[Temp.Count - 1] / 1000)
                            for (double i = (-1) * alef; i < alef; i += (2 * alef) / 2500)
                            {
                                double yVal = ToolsForWork.ComputeDistrArc(i, Data.Parameters);
                                this.DistrFun.Series[4].Points.AddXY(i, yVal);
                                x = yVal + quan * Math.Sqrt(Math.Pow((-1 * (i / (Math.PI * alef * Math.Sqrt(alef * alef - i * i)))), 2) * (dispalef));
                                //x = yVal + quan * Math.Sqrt(Math.Pow(((1.0 / (Math.PI * alef)) * (1.0 / (Math.Sqrt(1 - ((i * i) / (alef * alef)))))), 2) * (dispalef));
                                if (x > 1)
                                    x = 1;
                                if (x < 0)
                                    x = 0;
                                this.DistrFun.Series[2].Points.AddXY(i, x);
                                x = yVal - quan * Math.Sqrt(Math.Pow((-1 * (i / (Math.PI * alef * Math.Sqrt(alef * alef - i * i)))), 2) * (dispalef));
                                //x = yVal - quan * Math.Sqrt(Math.Pow(((1.0 / (Math.PI * alef)) * (1.0 / (Math.Sqrt(1 - ((i * i) / (alef * alef)))))), 2) * (dispalef));
                                if (x > 1)
                                    x = 1;
                                if (x < 0)
                                    x = 0;
                                this.DistrFun.Series[3].Points.AddXY(i, x);
                            }
                            break;
                        }
                    case "Арксинуса - старий":
                        {
                            this.Histogramme.Series[1].Points.Clear();
                            this.DistrFun.Series[2].Points.Clear();
                            this.DistrFun.Series[3].Points.Clear();
                            this.DistrFun.Series[4].Points.Clear();
                            double alef = Math.Sqrt(2) * Data.EvalData.StandDevZ;
                            if (Temp[0] > (1.1) * alef || Temp[Temp.Count - 1] < -1.1 * alef)
                            {
                                LogOutputTextBox.Text += "Ваша вибірка не належить до класу розподілів арксинуса" + Environment.NewLine;
                                return;
                            }
                            double dispalef = (Math.Pow(alef, 4)) / (8 * Temp.Count);
                            //double lol =  
                            if (CalledByUser)
                            {
                                textBox3.Text += "Вибірку оцінено як розподіл арксинуса, параметр а =  " + Math.Round(alef, Data.NumberOfNum) + ", його дисперсія - " + Math.Round(dispalef, Data.NumberOfNum) + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "Вибірку оцінено як розподіл арксинуса, параметр а =  " + Math.Round(alef, Data.NumberOfNum) + ", його дисперсія - " + Math.Round(dispalef, Data.NumberOfNum) + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                            double quan = Quantile.StanQuanOdn(Gamma);
                            double x;
                            for (double i = (-0.99) * alef; i <= (0.99) * alef; i += Temp[Temp.Count - 1] / 1000)
                            {
                                double yVal = (1.0 / (Math.PI * Math.Sqrt(alef * alef - i * i))) * HistData.Step;//((1000) / (HistData.NumberOfClasses * Sum));//HistData.Step;
                                this.Histogramme.Series[1].Points.AddXY(i, yVal);
                            }
                            Data.Parameters = new double[] { alef, 0 };
                            //for (double i = Temp[0]; i < Temp[Temp.Count - 1]; i += Temp[Temp.Count - 1] / 1000)
                            for (double i = (-1) * alef; i < alef; i += (2 * alef) / 2500)
                            {
                                double yVal = ToolsForWork.ComputeDistrArc(i, Data.Parameters);
                                this.DistrFun.Series[4].Points.AddXY(i, yVal);
                                x = yVal + quan * Math.Sqrt(Math.Pow((-1 * (i / (Math.PI * alef * Math.Sqrt(alef * alef - i * i)))), 2) * (dispalef));
                                //x = yVal + quan * Math.Sqrt(Math.Pow(((1.0 / (Math.PI * alef)) * (1.0 / (Math.Sqrt(1 - ((i * i) / (alef * alef)))))), 2) * (dispalef));
                                if (x > 1)
                                    x = 1;
                                if (x < 0)
                                    x = 0;
                                this.DistrFun.Series[2].Points.AddXY(i, x);
                                x = yVal - quan * Math.Sqrt(Math.Pow((-1 * (i / (Math.PI * alef * Math.Sqrt(alef * alef - i * i)))), 2) * (dispalef));
                                //x = yVal - quan * Math.Sqrt(Math.Pow(((1.0 / (Math.PI * alef)) * (1.0 / (Math.Sqrt(1 - ((i * i) / (alef * alef)))))), 2) * (dispalef));
                                if (x > 1)
                                    x = 1;
                                if (x < 0)
                                    x = 0;
                                this.DistrFun.Series[3].Points.AddXY(i, x);
                            }
                            break;
                        }
                    case "Релея":
                        {
                            if (Temp[0] < 0)
                            {
                                LogOutputTextBox.Text += "Неможливо відтворити розподіл Релея при відємних значеннях" + Environment.NewLine;
                                return;
                            }
                            this.Histogramme.Series[1].Points.Clear();
                            this.DistrFun.Series[2].Points.Clear();
                            this.DistrFun.Series[3].Points.Clear();
                            this.DistrFun.Series[4].Points.Clear();
                            //double sigma = (2.0 / Math.Sqrt(Math.PI)) * Data.EvalData.ExpValues;
                            double sigma = 0.8 * Data.EvalData.ExpValues;//(0.344*σ^2)/N
                            //double dispsigma = (4.0/Math.PI)*((Data.EvalData.StandDevZ*Data.EvalData.StandDevZ)/Temp.Count);
                            double dispsigma = (0.2752 * sigma * sigma) / Temp.Count;
                            //double lol = 
                            if (CalledByUser)
                            {
                                textBox3.Text += "Вибірку оцінено як розподіл Релея, параметр σ =  " + Math.Round(sigma, Data.NumberOfNum) + ", його дисперсія - " + Math.Round(dispsigma, Data.NumberOfNum) + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "Вибірку оцінено як розподіл Релея, параметр σ =  " + Math.Round(sigma, Data.NumberOfNum) + ", його дисперсія - " + Math.Round(dispsigma, Data.NumberOfNum) + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                            Data.Parameters = new double[] { sigma, 0 };
                            double quan = Quantile.StanQuanOdn(Gamma);
                            double x;
                            for (double i = 0; i < Temp[Temp.Count - 1]; i += Temp[Temp.Count - 1] / 1000)
                            {
                                double yVal = ((i / (sigma * sigma)) * Math.Pow(Math.E, ((-1 * i * i) / (2 * sigma * sigma)))) * HistData.Step;//((1000) / (HistData.NumberOfClasses * Sum));//HistData.Step;
                                this.Histogramme.Series[1].Points.AddXY(i, yVal);
                                yVal = ToolsForWork.ComputeDistrRel(i, Data.Parameters);
                                this.DistrFun.Series[4].Points.AddXY(i, yVal);
                                this.DistrFun.Series[2].Points.AddXY(i, ((x = yVal + quan * ((-1 * ((i * i) / (sigma * sigma * sigma)) * Math.Pow(Math.E, ((-1 * i * i) / (2 * sigma * sigma)))) * Math.Sqrt(dispsigma))) > 1) ? 1 : x);
                                this.DistrFun.Series[3].Points.AddXY(i, ((x = yVal - quan * ((-1 * ((i * i) / (sigma * sigma * sigma)) * Math.Pow(Math.E, ((-1 * i * i) / (2 * sigma * sigma)))) * Math.Sqrt(dispsigma))) < 0) ? 0 : x);
                            }
                            break;
                        }
                    case "Релея - старий":
                        {
                            if (Temp[0] < 0)
                            {
                                LogOutputTextBox.Text += "Неможливо відтворити розподіл Релея при відємних значеннях" + Environment.NewLine;
                                return;
                            }
                            this.Histogramme.Series[1].Points.Clear();
                            this.DistrFun.Series[2].Points.Clear();
                            this.DistrFun.Series[3].Points.Clear();
                            this.DistrFun.Series[4].Points.Clear();
                            double sigma = (2.0 / Math.Sqrt(Math.PI)) * Data.EvalData.ExpValues;
                            //double sigma = 0.8 * Data.EvalData.ExpValues;//(0.344*σ^2)/N
                            double dispsigma = (4.0 / Math.PI) * ((Data.EvalData.StandDevZ * Data.EvalData.StandDevZ) / Temp.Count);
                            //double dispsigma = (0.2752 * sigma * sigma) / Temp.Count;
                            //double lol = 
                            if (CalledByUser)
                            {
                                textBox3.Text += "Вибірку оцінено як розподіл Релея, параметр σ =  " + Math.Round(sigma, Data.NumberOfNum) + ", його дисперсія - " + Math.Round(dispsigma, Data.NumberOfNum) + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "Вибірку оцінено як розподіл Релея, параметр σ =  " + Math.Round(sigma, Data.NumberOfNum) + ", його дисперсія - " + Math.Round(dispsigma, Data.NumberOfNum) + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                            double quan = Quantile.StanQuanOdn(Gamma);
                            double x;
                            for (double i = 0; i < Temp[Temp.Count - 1]; i += Temp[Temp.Count - 1] / 1000)
                            {
                                double yVal = ((i / (sigma * sigma)) * Math.Pow(Math.E, ((-1 * i * i) / (2 * sigma * sigma)))) * HistData.Step;//((1000) / (HistData.NumberOfClasses * Sum));//HistData.Step;
                                this.Histogramme.Series[1].Points.AddXY(i, yVal);
                                yVal = ToolsForWork.ComputeDistrRel(i, Data.Parameters);
                                this.DistrFun.Series[4].Points.AddXY(i, yVal);
                                this.DistrFun.Series[2].Points.AddXY(i, ((x = yVal + quan * ((-1 * ((i * i) / (sigma * sigma * sigma)) * Math.Pow(Math.E, ((-1 * i * i) / (2 * sigma * sigma)))) * Math.Sqrt(dispsigma))) > 1) ? 1 : x);
                                this.DistrFun.Series[3].Points.AddXY(i, ((x = yVal - quan * ((-1 * ((i * i) / (sigma * sigma * sigma)) * Math.Pow(Math.E, ((-1 * i * i) / (2 * sigma * sigma)))) * Math.Sqrt(dispsigma))) < 0) ? 0 : x);
                            }
                            Data.Parameters = new double[] { sigma, 0 };
                            break;
                        }
                    case "Нормальний":
                        {
                            this.Histogramme.Series[1].Points.Clear();
                            this.DistrFun.Series[2].Points.Clear();
                            this.DistrFun.Series[3].Points.Clear();
                            this.DistrFun.Series[4].Points.Clear();
                            double Mu = Data.EvalData.ExpValues;
                            double dispmu = (Data.EvalData.StandDevNeZ * Data.EvalData.StandDevNeZ) / Temp.Count;
                            double sigma = ((double)Temp.Count / (Temp.Count - 1)) * Data.EvalData.StandDevZ;//(0.344*σ^2)/N
                            double dispsigma = (Data.EvalData.StandDevNeZ * Data.EvalData.StandDevNeZ) / (2 * Temp.Count);
                            //double lol = 
                            if (CalledByUser)
                            {
                                textBox3.Text += "Вибірку оцінено як нормальний розподіл, параметр μ =  " + Math.Round(Mu, Data.NumberOfNum) + ", його дисперсія - " + Math.Round(dispmu, Data.NumberOfNum) + ", параметр σ = " + Math.Round(sigma, Data.NumberOfNum) + ", його дисперсія - " + Math.Round(dispsigma, Data.NumberOfNum) + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "Вибірку оцінено як нормальний розподіл, параметр μ =  " + Math.Round(Mu, Data.NumberOfNum) + ", його дисперсія - " + Math.Round(dispmu, Data.NumberOfNum) + ", параметр σ = " + Math.Round(sigma, Data.NumberOfNum) + ", його дисперсія - " + Math.Round(dispsigma, Data.NumberOfNum) + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                            double quan = Quantile.StanQuanOdn(Gamma);
                            double x;
                            for (double i = Temp[0]; i < Temp[Temp.Count - 1]; i += (Temp[Temp.Count - 1] - Temp[0]) / 1000)
                            {
                                double yVal = ((1.0 / (sigma * Math.Sqrt(2 * Math.PI))) * Math.Pow(Math.E, (-1 * (Math.Pow(i - Mu, 2) / (2 * sigma * sigma))))) * HistData.Step;//((1000) / (HistData.NumberOfClasses * Sum));//HistData.Step;
                                this.Histogramme.Series[1].Points.AddXY(i, yVal);
                                yVal = ToolsForWork.ComputeFi((i - Mu) / sigma);
                                this.DistrFun.Series[4].Points.AddXY(i, yVal);
                                this.DistrFun.Series[2].Points.AddXY(i, ((x = yVal + quan * Math.Sqrt(Math.Pow(((1.0 / (sigma * Math.Sqrt(2 * Math.PI))) * Math.Pow(Math.E, (-1 * (Math.Pow(i - Mu, 2) / (2 * sigma * sigma))))), 2) * dispmu
                                                                                                          + Math.Pow((((i - Mu) / (sigma * sigma * Math.Sqrt(2 * Math.PI))) * Math.Pow(Math.E, (-1 * (Math.Pow(i - Mu, 2) / (2 * sigma * sigma))))), 2) * dispsigma)) > 1) ? 1 : x);
                                this.DistrFun.Series[3].Points.AddXY(i, ((x = yVal - quan * Math.Sqrt(Math.Pow(((1.0 / (sigma * Math.Sqrt(2 * Math.PI))) * Math.Pow(Math.E, (-1 * (Math.Pow(i - Mu, 2) / (2 * sigma * sigma))))), 2) * dispmu
                                                                                                          + Math.Pow((((i - Mu) / (sigma * sigma * Math.Sqrt(2 * Math.PI))) * Math.Pow(Math.E, (-1 * (Math.Pow(i - Mu, 2) / (2 * sigma * sigma))))), 2) * dispsigma)) < 0) ? 0 : x);
                            }
                            Data.Parameters = new double[] { Mu, sigma };
                            break;
                        }
                    case "Лапласа":
                        {
                            this.Histogramme.Series[1].Points.Clear();
                            this.DistrFun.Series[2].Points.Clear();
                            this.DistrFun.Series[3].Points.Clear();
                            this.DistrFun.Series[4].Points.Clear();
                            double Mu = Data.EvalData.ExpValues;
                            double lambda = Math.Sqrt(2) / (1.32 * Data.EvalData.StandDevZ);//(0.344*σ^2)/N
                            double dispmu = 2.0 / (Temp.Count * lambda * lambda);
                            double displambda = (5 * lambda * lambda) / (Temp.Count);
                            double cov = (-3d) / (2 * Temp.Count);
                            //double lol =  
                            if (CalledByUser)
                            {
                                textBox3.Text += "Вибірку оцінено як розподіл Лапласа, параметр μ =  " + Math.Round(Mu, Data.NumberOfNum) + ", його дисперсія - " + Math.Round(dispmu, Data.NumberOfNum) + ", параметр λ = " + Math.Round(lambda, Data.NumberOfNum) + ", його дисперсія - " + Math.Round(displambda, Data.NumberOfNum) + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "Вибірку оцінено як розподіл Лапласа, параметр μ =  " + Math.Round(Mu, Data.NumberOfNum) + ", його дисперсія - " + Math.Round(dispmu, Data.NumberOfNum) + ", параметр λ = " + Math.Round(lambda, Data.NumberOfNum) + ", його дисперсія - " + Math.Round(displambda, Data.NumberOfNum) + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                            Data.Parameters = new double[] { Mu, lambda };
                            double quan = Quantile.StanQuanOdn(Gamma);
                            double x;
                            if (Mu < Temp[0] || Mu > Temp[Temp.Count - 1])
                            {
                                LogOutputTextBox.Text += "Ваша вибірка не належить до класу розподілів Лапласа" + Environment.NewLine;
                                return;
                            }
                            for (double i = Temp[0]; i < Mu; i += (Temp[Temp.Count - 1] - Temp[0]) / 1000)
                            {
                                double yVal = (lambda / 2) * Math.Pow(Math.E, (-1 * lambda * Math.Abs(i - Mu))) * HistData.Step;
                                this.Histogramme.Series[1].Points.AddXY(i, yVal);
                                yVal = ToolsForWork.ComputeDistrLaps(i, Data.Parameters);
                                this.DistrFun.Series[4].Points.AddXY(i, yVal);
                                this.DistrFun.Series[2].Points.AddXY(i, ((x = yVal + quan * Math.Sqrt(Math.Pow(-1 * ((lambda / 2) * Math.Pow(Math.E, lambda * (i - Mu))), 2) * dispmu
                                                                                                            + Math.Pow(0.5 * (i - Mu) * Math.Pow(Math.E, lambda * (i - Mu)), 2) * displambda
                                                                                                            + cov * (0.5 * (i - Mu) * Math.Pow(Math.E, lambda * (i - Mu))) * (-1 * ((lambda / 2) * Math.Pow(Math.E, lambda * (i - Mu)))))) > 1) ? 1 : x);
                                this.DistrFun.Series[3].Points.AddXY(i, ((x = yVal - quan * Math.Sqrt(Math.Pow(-1 * ((lambda / 2) * Math.Pow(Math.E, lambda * (i - Mu))), 2) * dispmu
                                                                                                            + Math.Pow(0.5 * (i - Mu) * Math.Pow(Math.E, lambda * (i - Mu)), 2) * displambda
                                                                                                            + cov * (0.5 * (i - Mu) * Math.Pow(Math.E, lambda * (i - Mu))) * (-1 * ((lambda / 2) * Math.Pow(Math.E, lambda * (i - Mu)))))) < 0) ? 0 : x);

                            }
                            for (double i = Mu; i < Temp[Temp.Count - 1]; i += (Temp[Temp.Count - 1] - Temp[0]) / 1000)
                            {
                                double yVal = (lambda / 2) * Math.Pow(Math.E, (-1 * lambda * Math.Abs(i - Mu))) * HistData.Step;
                                this.Histogramme.Series[1].Points.AddXY(i, yVal);
                                yVal = ToolsForWork.ComputeDistrLaps(i, Data.Parameters);
                                this.DistrFun.Series[4].Points.AddXY(i, yVal);
                                this.DistrFun.Series[2].Points.AddXY(i, ((x = yVal + quan * Math.Sqrt(Math.Pow(-1 * ((lambda / 2) * Math.Pow(Math.E, -1 * lambda * (i - Mu))), 2) * dispmu
                                                                                                            + Math.Pow(0.5 * (i - Mu) * Math.Pow(Math.E, -1 * lambda * (i - Mu)), 2) * displambda
                                                                                                            + cov * (0.5 * (i - Mu) * Math.Pow(Math.E, -1 * lambda * (i - Mu))) * (-1 * ((lambda / 2) * Math.Pow(Math.E, -1 * lambda * (i - Mu)))))) > 1) ? 1 : x);
                                this.DistrFun.Series[3].Points.AddXY(i, ((x = yVal - quan * Math.Sqrt(Math.Pow(-1 * ((lambda / 2) * Math.Pow(Math.E, -1 * lambda * (i - Mu))), 2) * dispmu
                                                                                                            + Math.Pow(0.5 * (i - Mu) * Math.Pow(Math.E, -1 * lambda * (i - Mu)), 2) * displambda
                                                                                                            + cov * (0.5 * (i - Mu) * Math.Pow(Math.E, -1 * lambda * (i - Mu))) * (-1 * ((lambda / 2) * Math.Pow(Math.E, -1 * lambda * (i - Mu)))))) < 0) ? 0 : x);

                            }
                            break;
                        }
                    case "Рівномірний":
                        {
                            this.Histogramme.Series[1].Points.Clear();
                            this.DistrFun.Series[2].Points.Clear();
                            this.DistrFun.Series[3].Points.Clear();
                            this.DistrFun.Series[4].Points.Clear();
                            double A = Data.EvalData.ExpValues - Math.Sqrt(3) * Data.EvalData.StandDevZ;
                            double B = Data.EvalData.ExpValues + Math.Sqrt(3) * Data.EvalData.StandDevZ;
                            double dH1dx = 1 + 3 * ((A + B) / (B - A));
                            double dH2dx = 1 - 3 * ((A + B) / (B - A));
                            double dH1dx2 = -3.0 / (B - A);
                            double dH2dx2 = 3.0 / (B - A);
                            double dispx = ((B - A) * (B - A)) / (12 * Temp.Count);
                            double covxx2 = ((A + B) * (B - A) * (B - A)) / (12 * Temp.Count);
                            double dispx2 = (1.0 / (180 * Temp.Count)) * (Math.Pow(B - A, 4) + 15 * (A + B) * (A * B) * (B - A) * (B - A));
                            double dispA = Math.Abs(Math.Pow(dH1dx, 2) * dispx + Math.Pow(dH1dx2, 2) * dispx2 + 2 * dH1dx2 * dH1dx * covxx2);
                            double dispB = Math.Abs(Math.Pow(dH2dx, 2) * dispx + Math.Pow(dH2dx2, 2) * dispx2 + 2 * dH2dx2 * dH2dx * covxx2);
                            double FinCov = dH1dx * dH2dx * dispx + dH1dx2 * dH2dx2 * dispx2 + (dH1dx * dH2dx2 + dH1dx2 * dH2dx) * covxx2;
                            if (CalledByUser)
                            {
                                textBox3.Text += "Вибірку оцінено як рівномірний розподіл, параметр A =  " + Math.Round(A, Data.NumberOfNum) + ", його дисперсія - " + Math.Round(dispA, Data.NumberOfNum) + ", параметр B = " + Math.Round(B, Data.NumberOfNum) + ", його дисперсія - " + Math.Round(dispB, Data.NumberOfNum) + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "Вибірку оцінено як  рівномірний розподіл, параметр A =  " + Math.Round(A, Data.NumberOfNum) + ", його дисперсія - " + Math.Round(dispA, Data.NumberOfNum) + ", параметр B = " + Math.Round(B, Data.NumberOfNum) + ", його дисперсія - " + Math.Round(dispB, Data.NumberOfNum) + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                            Data.Parameters = new double[] { A, B };
                            double quan = Quantile.StanQuanOdn(Gamma);
                            //double x;
                            for (double i = A; i < B; i += (Temp[Temp.Count - 1] - Temp[0]) / 1000)
                            {
                                double yVal = 1.0 / (B - A) * HistData.Step;//((1000) / (HistData.NumberOfClasses * Sum));//HistData.Step;
                                this.Histogramme.Series[1].Points.AddXY(i, yVal);
                                yVal = ToolsForWork.ComputeDistrRivn(i, Data.Parameters);
                                this.DistrFun.Series[4].Points.AddXY(i, yVal);
                                /*this.DistrFun.Series[2].Points.AddXY(i, ((x = yVal + quan * Math.Sqrt((Math.Pow(i - B, 2) / Math.Pow(B - A, 4))*dispA
                                                                                            + (Math.Pow(i - A, 2) / Math.Pow(B - A, 4))*dispB
                                                                                            - 2 * (((i - A) * (i - B)) / (Math.Pow(B - A, 4)))*FinCov)) > 1) ? 1 : x);
                                this.DistrFun.Series[3].Points.AddXY(i, ((x = yVal - quan * Math.Sqrt((Math.Pow(i - B, 2) / Math.Pow(B - A, 4)) * dispA
                                                                                            + (Math.Pow(i - A, 2) / Math.Pow(B - A, 4)) * dispB
                                                                                            - 2 * (((i - A) * (i - B)) / (Math.Pow(B - A, 4))) * FinCov)) < 0) ? 0 : x);*/
                            }
                            break;
                        }
                    case "Вейбулла":
                        {
                            this.Histogramme.Series[1].Points.Clear();
                            this.DistrFun.Series[2].Points.Clear();
                            this.DistrFun.Series[3].Points.Clear();
                            this.DistrFun.Series[4].Points.Clear();
                            if (Temp[0] < 0)
                            {
                                LogOutputTextBox.Text += "Неможливо відтворити розподіл Вейбулла при відємних значеннях" + Environment.NewLine;
                                return;
                            }
                            double a11 = Temp.Count - 1;
                            double a12;
                            double a21;
                            a12 = 0;
                            for (int i = 0; i < Temp.Count - 2; i++)
                            {
                                a12 += Math.Log(Temp[i]);
                            }
                            a21 = a12;
                            double a22 = 0;
                            for (int i = 0; i < Temp.Count - 2; i++)
                            {
                                a22 += Math.Log(Temp[i]) * Math.Log(Temp[i]);
                            }
                            double b1 = 0, b2 = 0;
                            double log1, log2;
                            for (int i = 0; i < Temp.Count - 2; i++)
                            {
                                log1 = Math.Log(1.0 / (1 - DistrFuncData.DistrFunction[i]));
                                log2 = Math.Log(log1);
                                b1 += log2;
                                b2 += log2 * Math.Log(Temp[i]);
                            }
                            double delta = a11 * a22 - a12 * a21;
                            double Alef = (b1 * a22 - b2 * a12) / delta;
                            double Beta = (a11 * b2 - b1 * a21) / delta;
                            double Alfa = Math.Exp(-1 * Alef);
                            // double dispAlef = (a22*);
                            //double dispAlfa;
                            //double dispBeta;
                            //double lol = 
                            if (CalledByUser)
                            {
                                textBox3.Text += "Вибірку оцінено як нормальний розподіл, параметр α =  " + Math.Round(Alfa, Data.NumberOfNum) + ", параметр β = " + Math.Round(Beta, Data.NumberOfNum) + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "Вибірку оцінено як нормальний розподіл, параметр α =  " + Math.Round(Alfa, Data.NumberOfNum) + ", параметр β = " + Math.Round(Beta, Data.NumberOfNum) + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                            double quan = Quantile.StanQuanOdn(Gamma);
                            //double x;
                            Data.Parameters = new double[] { Alfa, Beta };
                            for (double i = Temp[0]; i < Temp[Temp.Count - 1]; i += (Temp[Temp.Count - 1] - Temp[0]) / 1000)
                            {
                                double yVal = (Beta / Alfa) * Math.Pow(i, Beta - 1) * Math.Pow(Math.E, -1 * (Math.Pow(i, Beta) / Alfa)) * HistData.Step;//((1000) / (HistData.NumberOfClasses * Sum));//HistData.Step;
                                this.Histogramme.Series[1].Points.AddXY(i, yVal);
                                yVal = ToolsForWork.ComputeDistrVieb(i, Data.Parameters);
                                this.DistrFun.Series[4].Points.AddXY(i, yVal);
                                // yVal = ToolsForWork.ComputeFi((i - Mu) / sigma);
                                // this.DistrFun.Series[4].Points.AddXY(i, yVal);
                                //this.DistrFun.Series[2].Points.AddXY(i, ((x = yVal + quan * Math.Sqrt(Math.Pow(((1.0 / (sigma * Math.Sqrt(2 * Math.PI))) * Math.Pow(Math.E, (-1 * (Math.Pow(i - Mu, 2) / (2 * sigma * sigma))))), 2) * dispmu
                                //                                                                          + Math.Pow((((i - Mu) / (sigma * sigma * Math.Sqrt(2 * Math.PI))) * Math.Pow(Math.E, (-1 * (Math.Pow(i - Mu, 2) / (2 * sigma * sigma))))), 2) * dispsigma)) > 1) ? 1 : x);
                                //this.DistrFun.Series[3].Points.AddXY(i, ((x = yVal - quan * Math.Sqrt(Math.Pow(((1.0 / (sigma * Math.Sqrt(2 * Math.PI))) * Math.Pow(Math.E, (-1 * (Math.Pow(i - Mu, 2) / (2 * sigma * sigma))))), 2) * dispmu
                                //                                                                         + Math.Pow((((i - Mu) / (sigma * sigma * Math.Sqrt(2 * Math.PI))) * Math.Pow(Math.E, (-1 * (Math.Pow(i - Mu, 2) / (2 * sigma * sigma))))), 2) * dispsigma)) < 0) ? 0 : x);
                            }
                            break;
                        }
                }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Data.DataForWork.Count <= 0 || Data.DataForWork[Data.CurrentSample].Count == 0)
            {
                if(LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Нема чого відтворювати" + Environment.NewLine;
                return;
            }
            OkCancelDlg it = new OkCancelDlg("Виберіть тип розподілу", null, Data.TypeOfDistr, Data.Gamma);
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                Data.DistrCreated = true;
                if ((Data.Gamma <= 0) || (Data.Gamma >= 0.5))
                {
                    if (LogCheckBox.Checked)
                        LogOutputTextBox.Text += "Хибне значення γ для довірчих інтервалів" + Environment.NewLine;
                    TextBoxForPos.Text = "0,05";
                    Data.Gamma.set(0.05);
                }
                BuildDistr(Data.TypeOfDistr, Data.Gamma, true);
            }
              
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Data.Parameters = new double[] {0 , 0};
            Data.DistrCreated = false;
            BuildHistAndDistFunc();
        }

        private void включитивиключитиМаштабуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Data.DataForWork.Count <= 0 || Data.DataForWork[Data.CurrentSample].Count == 0)
            {
                return;
            }
            if (Data.Scaled)
                Data.Scaled = false;
            else
                Data.Scaled = true;
            BuildHistAndDistFunc();
            BuildDistr(Data.TypeOfDistr, Data.Gamma, true);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SaveFileDialog savingFileDialog = new SaveFileDialog();
            savingFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            savingFileDialog.FilterIndex = 2;
            savingFileDialog.RestoreDirectory = true;
            savingFileDialog.RestoreDirectory = true;
            if (savingFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter FileToWrite = new System.IO.StreamWriter(savingFileDialog.FileName, true))
                {
                    FileToWrite.WriteLine(LogOutputTextBox.Text);
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (Data.DataForWork.Count <= 0)
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Нема з чим працювати " + Environment.NewLine;
                return;
            }
            {
                for (int i = 0; i < 10; i++ )
                {
                    if (!(((string)DataGridForEval.Rows[i].Cells[2].Value == "Не обраховувалося") || ((string)DataGridForEval.Rows[i].Cells[2].Value == "")))
                    {
                        LogOutputTextBox.Text += DataGridForEval.Rows[i].Cells[0].Value + " = " + DataGridForEval.Rows[i].Cells[2].Value + Environment.NewLine;
                    }
                }
            }
            LogOutputTextBox.Text += "---------------------------------------------------------------" + Environment.NewLine;
        }

        private void видалитиДвовимірнуВибіркуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Data.DataForWork.Count <= 0 || Data.TwoDemSamples.Count ==0)
            {
                this.chart1.Series[0].Points.Clear();
                this.chart2.Series[10].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                this.chart1.Series[2].Points.Clear();
                this.chart1.Series[3].Points.Clear();
                this.chart1.Series[4].Points.Clear();
                this.chart1.Series[5].Points.Clear();
                this.chart1.Series[6].Points.Clear();
                this.chart1.Series[7].Points.Clear();
                this.chart1.Series[8].Points.Clear();
                this.dataGridView1.Rows.Clear();
                this.dataGridView2.Rows.Clear();
                this.dataGridView3.Rows.Clear();
                this.dataGridView4.Rows.Clear();
                chart2.ChartAreas[0].BackImage = "";
               /* if (File.Exists(Application.StartupPath + "\\" + "TempFileDontTouch.png"))
                {
                    FileStream MFS = File.OpenRead(Application.StartupPath + "\\" + "TempFileDontTouch.png");
                    MFS.Dispose();
                    MFS.Close();
                  //  File.Delete(Application.StartupPath + "\\" + "TempFileDontTouch.png");
                }*/
                dataGridView1.Rows.Add("Мат. сподівання X", "", "", "", "", "---");
                dataGridView1.Rows.Add("Мат. сподівання Y", "", "", "", "", "---");
                dataGridView1.Rows.Add("Стандартне відхилення X", "", "", "", "", "");
                dataGridView1.Rows.Add("Стандартне відхилення Y", "", "", "", "", "");
                dataGridView1.Rows.Add("Оцінка адекватності відтворення нормального розподілу", "---", "", "---", "", "");
                dataGridView1.Rows.Add("Коефіціент кореляції", "", "", "", "", "");
                dataGridView1.Rows.Add("Кореляційне відношення по X", "", "", "", "", "---");
                dataGridView1.Rows.Add("Кореляційне відношення по Y", "", "", "", "", "---");
                dataGridView1.Rows.Add("Р.к.к. Спірмена", "", "", "", "", "---");
                dataGridView1.Rows.Add("Р.к.к. Кендалла", "", "", "", "", "---");
                dataGridView2.Rows.Add("Індекс Фехнера", "", "---", "---");
                dataGridView2.Rows.Add("Коефіціент сполучень Φ", "", "", "");
                dataGridView2.Rows.Add("Коефіціент зв'язку Юла Q", "", "", "");
                dataGridView2.Rows.Add("Коефіціент зв'язку Юла Y", "", "", "");
                dataGridView4.Rows.Add("Коефіціент сполучень Пірсона", "");
                dataGridView4.Rows.Add("Мір звяззку Кендалла", "");
                dataGridView4.Rows.Add("Статистика Стюарда", "");
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Нема з чим працювати " + Environment.NewLine;
                BuildTwoDem();
                return;
            }
            int temp = Data.TwoDemCurrentSample;
            Data.TwoDemCurrentSample.set(Data.TwoDemCurrentSample + 1); 
            OkCancelDlg it = new OkCancelDlg("Виберіть вибірку для видалення", null, Data.TwoDemCurrentSample);
            DialogResult rc = it.ShowDialog();
            Data.TwoDemCurrentSample.set(Data.TwoDemCurrentSample - 1);
            if (rc == DialogResult.OK)
            {
                if ((Data.TwoDemCurrentSample < 0) || (Data.TwoDemCurrentSample >= Data.TwoDemSamples.Count))
                {
                    LogOutputTextBox.Text += "Вибірки з таким номером не існує " + Environment.NewLine;
                    return;
                }
                //Data.TwoDemNamesOfFiles.RemoveAt(Data.TwoDemCurrentSample);
                Data.TwoDemStepBack.RemoveAt(Data.TwoDemCurrentSample);
                Data.TwoDemSamples.RemoveAt(Data.TwoDemCurrentSample);
                if (Data.TwoDemSamples.Count == 0)
                {
                    this.chart1.Series[0].Points.Clear();
                    this.chart2.Series[10].Points.Clear();
                    this.chart1.Series[1].Points.Clear();
                    this.chart1.Series[2].Points.Clear();
                    this.chart1.Series[3].Points.Clear();
                    this.chart1.Series[4].Points.Clear();
                    this.chart1.Series[5].Points.Clear();
                    this.chart1.Series[6].Points.Clear();
                    this.chart1.Series[7].Points.Clear();
                    this.chart1.Series[8].Points.Clear();
                    this.dataGridView1.Rows.Clear();
                    this.dataGridView2.Rows.Clear();
                    this.dataGridView3.Rows.Clear();
                    this.dataGridView4.Rows.Clear();
                    chart2.ChartAreas[0].BackImage = "";
                   /* if (File.Exists(Application.StartupPath + "\\" + "TempFileDontTouch.png"))
                    {
                        FileStream MFS = File.OpenRead(Application.StartupPath + "\\" + "TempFileDontTouch.png");
                        MFS.Dispose();
                        MFS.Close();
                       // File.Delete(Application.StartupPath + "\\" + "TempFileDontTouch.png");
                    }*/
                    dataGridView1.Rows.Add("Мат. сподівання X", "", "", "", "", "---");
                    dataGridView1.Rows.Add("Мат. сподівання Y", "", "", "", "", "---");
                    dataGridView1.Rows.Add("Стандартне відхилення X", "", "", "", "", "");
                    dataGridView1.Rows.Add("Стандартне відхилення Y", "", "", "", "", "");
                    dataGridView1.Rows.Add("Оцінка адекватності відтворення нормального розподілу", "---", "", "---", "", "");
                    dataGridView1.Rows.Add("Коефіціент кореляції", "", "", "", "", "");
                    dataGridView1.Rows.Add("Кореляційне відношення по X", "", "", "", "", "---");
                    dataGridView1.Rows.Add("Кореляційне відношення по Y", "", "", "", "", "---");
                    dataGridView1.Rows.Add("Р.к.к. Спірмена", "", "", "", "", "---");
                    dataGridView1.Rows.Add("Р.к.к. Кендалла", "", "", "", "", "---");
                    dataGridView2.Rows.Add("Індекс Фехнера", "", "---", "---");
                    dataGridView2.Rows.Add("Коефіціент сполучень Φ", "", "", "");
                    dataGridView2.Rows.Add("Коефіціент зв'язку Юла Q", "", "", "");
                    dataGridView2.Rows.Add("Коефіціент зв'язку Юла Y", "", "", "");
                    dataGridView4.Rows.Add("Коефіціент сполучень Пірсона", "");
                    dataGridView4.Rows.Add("Мір звяззку Кендалла", "");
                    dataGridView4.Rows.Add("Статистика Стюарда", "");
                }
                else
                {
                    if (Data.TwoDemCurrentSample == temp)
                        Data.TwoDemCurrentSample.set(0);
                    else
                    {
                        if (Data.TwoDemCurrentSample > temp)
                        {
                            Data.TwoDemCurrentSample.set(temp);
                        }
                        else
                        {
                            Data.TwoDemCurrentSample.set(temp-1);
                        }
                    }
                    BuildTwoDem();
                }
            }
        }

        private void BuildBubble()
        {
            int i,j;
            int AxiX, AxiY, AxiZ;
            try
            {
                AxiX = Convert.ToInt16(textBox24.Text);
                AxiX--;
            }
            catch
            {
                textBox24.Text = "1";
                AxiX = 0;
            }
            try
            {
                AxiY = Convert.ToInt16(textBox25.Text);
                AxiY--;
            }
            catch
            {
                textBox25.Text = "2";
                AxiY = 1;
            }
             try
            {
                AxiZ = Convert.ToInt16(textBox26.Text);
                AxiZ--;
            }
            catch
            {
                textBox26.Text = "3";
                AxiZ = 2;
            }
            if (AxiX < 0)
            {
                textBox24.Text = "1";
                AxiX = 0;
            }
            if (AxiY < 0)
            {
                textBox25.Text = "2";
                AxiY = 1;
            }
            if (AxiZ < 0)
            {
                textBox26.Text = "3";
                AxiZ = 2;
            }
            if (AxiX > Data.MultiDemSamples[Data.MultiDemCurrentSample].Length)
            {
                textBox24.Text = "1";
                AxiX = 0;
            }
            if (AxiY > Data.MultiDemSamples[Data.MultiDemCurrentSample].Length)
            {
                textBox25.Text = "2";
                AxiY = 1;
            }
             if (AxiZ > Data.MultiDemSamples[Data.MultiDemCurrentSample].Length)
            {
                textBox26.Text = "3";
                AxiZ = 2;
            }
            if (AxiX == AxiY || AxiX == AxiZ || AxiZ == AxiY)
            {
                return;
            }
            chart3.Series[0].Points.Clear();
            for (i = 0; i < Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count; i++)
            {
                chart3.Series[0].Points.AddXY(Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][AxiX]][i], Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][AxiY]][i], Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][AxiZ]][i]);
            }
        }

        private void видалитиВибіркуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //////////////
            if (Data.DataForWork.Count <= 0)
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Нема з чим працювати " + Environment.NewLine;
                return;
            }
            int ComeBack = Data.CurrentSample;
            Data.CurrentSample.set(Data.CurrentSample + 1);
            OkCancelDlg it = new OkCancelDlg("Виберіть вибірку для видалення", null, Data.CurrentSample);
            DialogResult rc = it.ShowDialog();
            Data.CurrentSample.set(Data.CurrentSample - 1);
            if (rc == DialogResult.OK)
            {
                if ((Data.CurrentSample < 0) || (Data.CurrentSample >= Data.DataForWork.Count))
                {
                    LogOutputTextBox.Text += "Вибірки з таким номером не існує " + Environment.NewLine;
                    return;
                }
                for (int i = 0; i < Data.TwoDemSamples.Count; i++)
                {
                    if (Data.CurrentSample == Data.TwoDemSamples[i][0] || Data.CurrentSample == Data.TwoDemSamples[i][1])
                    {
                        LogOutputTextBox.Text += "U shall delete the two dem sample that contains it. Its number is " + (i + 1) + Environment.NewLine;
                        return;
                    }
                }
                int j;
                for (int i = 0; i < Data.MultiDemSamples.Count; i++)
                {
                    for (j = 0; j < Data.MultiDemSamples[i].Length; j++)
                    {
                        if (Data.CurrentSample == Data.MultiDemSamples[i][j])
                        {
                            LogOutputTextBox.Text += " U cant delete this sample, cause its part of multidimentional sample. U shall delete its first" + Environment.NewLine;
                            return;
                        }
                    }
                }
                Data.NamesOfFiles.RemoveAt(Data.CurrentSample);
                Data.DataForWork.RemoveAt(Data.CurrentSample);
                Data.StepBack.RemoveAt(Data.CurrentSample);
                for (int i = 0; i < Data.TwoDemSamples.Count; i++)
                {
                    if (Data.CurrentSample < Data.TwoDemSamples[i][0] )
                    {
                        Data.TwoDemSamples[i][0]--;
                    }
                    if (Data.CurrentSample < Data.TwoDemSamples[i][1])
                    {
                        Data.TwoDemSamples[i][1]--;
                    }
                }
                if (Data.DataForWork.Count == 0)
                {
                    this.DataGridForEval.Rows.Clear();
                    LogOutputTextBox.Text += "Theres nothing to do" + Environment.NewLine;
                    DataGridForEval.Rows.Add("Мат. сподівання", "", "", "", "");
                    DataGridForEval.Rows.Add("Вибіркова медіана", " --- ", "", " --- ", " --- ");
                    DataGridForEval.Rows.Add("Усічене середнє", " --- ", "", " --- ", "");
                    DataGridForEval.Rows.Add("Медіана середніх Уолша", " --- ", "", " --- ", " --- ");
                    DataGridForEval.Rows.Add("Стандартне відхилення", "", "", "", "");
                    DataGridForEval.Rows.Add("МАД", " --- ", "", " --- ", " --- ");
                    DataGridForEval.Rows.Add("Коефіцієнт асиметрії", "", "", "", "");
                    DataGridForEval.Rows.Add("Коефіцієнт ексцессу", "", "", "", "");
                    DataGridForEval.Rows.Add("Коеф. контрексцессу", " --- ", "", " --- ", " --- ");
                    DataGridForEval.Rows.Add("КВП", "", "", "", "");
                    DataGridForEval.Rows.Add("Інтервал передбачення", "", " --- ", "", "");
                    DataGridForEval.Rows[0].Cells[4].ReadOnly = false;
                    DataGridForEval.Rows[2].Cells[4].ReadOnly = false;
                    DataGridForEval.Rows[4].Cells[4].ReadOnly = false;
                    DataGridForEval.Rows[6].Cells[4].ReadOnly = false;
                    DataGridForEval.Rows[7].Cells[4].ReadOnly = false;
                    DataGridForEval.Rows[9].Cells[4].ReadOnly = false;
                    DataGridForEval.Rows[10].Cells[4].ReadOnly = false;
                    this.Histogramme.Series[1].Points.Clear();
                    this.Histogramme.Series[0].Points.Clear();
                    this.DistrFun.Series[0].Points.Clear();
                    this.DistrFun.Series[1].Points.Clear();
                    this.DistrFun.Series[2].Points.Clear();
                    this.DistrFun.Series[3].Points.Clear();
                    this.DistrFun.Series[4].Points.Clear();
                    toolStripforNumber.Text = "";
                    this.DataGridForData.Columns.Clear();
                    StatusLabelNameOfFile.Text = "відсутній";
                    textBox2_TextChanged(new TextBox(), new EventArgs());
                    textBox2_TextChanged(new TextBox(), new EventArgs());
                    return;
                }
                else
                {
                    Data.CurrentSample.set((Data.CurrentSample > ComeBack) ? ComeBack : (ComeBack - 1));
                    if (Data.CurrentSample < 0)
                        Data.CurrentSample.set(0);
                    StatusLabelNameOfFile.Text = Data.NamesOfFiles[Data.CurrentSample];
                    HistData.NumberOfClassesChangedByUser = false;
                    DistrFuncData.NumberOfClassesChangedByUser = false;
                    Data.DistrCreated = false;
                    Build();
                }
            }
        }

        private void включитивиключитиПобудовуВаріаційногоРядуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Data.DataForWork.Count <= 0 || Data.DataForWork[Data.CurrentSample].Count == 0)
            {
                return;
            }
            if (Data.DataForWork[Data.CurrentSample].Count >= 9999)
            {
                LogOutputTextBox.Text += "При такій кількості елементів варіаційний ряд не будується навіть за бажання користувача" + Environment.NewLine;
            }
            if (Data.VarNeeded)
                Data.VarNeeded = false;
            else
            {
                Data.VarNeeded = true;
                BuildDataTable();
            }
        }

        private void включитивиключитиОбрахуавнняМедіаниСередніхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Data.DataForWork.Count <= 0 || Data.DataForWork[Data.CurrentSample].Count == 0)
            {
                return;
            }
            if (Data.DataForWork[Data.CurrentSample].Count >= 7500)
            {
                LogOutputTextBox.Text += "При такій кількості елементів медіана середніх Уолша не обраховується навіть за бажання користувача" + Environment.NewLine;
            }
            if (Data.MEDNeeded)
                Data.MEDNeeded = false;
            else
            {
                Data.MEDNeeded = true;
                BuildEval();
            }
        }

        private double CheckPirs()
        {
            List<double> Temp = new List<double>();
            for (int i = 0; i < Data.DataForWork[Data.CurrentSample].Count; i++)
            {
                Temp.Add(Data.DataForWork[Data.CurrentSample][i]);
            }
            Temp.Sort();
            int[] DataByClasses = new int[(int)HistData.NumberOfClasses];
            for (int i = 0; i < DataByClasses.Length; i++)
            {
                DataByClasses[i] = 0;
            }
            int IndOfRang = 0;
            for (int i = 0; i < Temp.Count; i++)
            {
                while (Temp[i] > (HistData.MinLimit + (IndOfRang + 1) * ((HistData.MaxLimit - HistData.MinLimit) / HistData.NumberOfClasses)))
                {
                    IndOfRang++;
                }
                if (IndOfRang == (int)HistData.NumberOfClasses)
                {
                    DataByClasses[IndOfRang - 1]++;
                }
                else
                {
                    DataByClasses[IndOfRang]++;
                }
            }
            double yVal;
            double LocalMin = 0;
            double LocalMax = 0;
            double sum = 0;
            double theorz = 0;
            for (int i = 0; i < (int)HistData.NumberOfClasses; i++)
            {
                yVal = (double)DataByClasses[i] / (double)Temp.Count;
                LocalMin = (HistData.MinLimit + HistData.Step * i);
                LocalMax = (HistData.MinLimit + HistData.Step * (i + 1));
                double lol = ToolsForWork.ComputeDistr(Data.TypeOfDistr, LocalMax, Data.Parameters);
                double lil = ToolsForWork.ComputeDistr(Data.TypeOfDistr, LocalMin, Data.Parameters);
                theorz = Temp.Count*(ToolsForWork.ComputeDistr(Data.TypeOfDistr, LocalMax, Data.Parameters) - ToolsForWork.ComputeDistr(Data.TypeOfDistr, LocalMin, Data.Parameters));
                if (theorz != 0)
                {
                    sum += Math.Pow(DataByClasses[i] - theorz, 2) / theorz;
                }
            }
            return sum;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!Data.DistrCreated)
            {
                textBox3.Text += "Необхідно спочатку відтворити розподіл" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                if (checkBox1.Checked)
                {
                    LogOutputTextBox.Text += "Необхідно спочатку відтворити розподіл" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                }
                return;
            }
            if (Data.DataForWork.Count <= 0 || Data.DataForWork[Data.CurrentSample].Count <= 0)
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Нема з чим працювати " + Environment.NewLine;
                return;
            }
            if (Data.EvalData.StandDevNeZ == 0)
            {
                LogOutputTextBox.Text += "Сам таку вибірку оцінюй" + Environment.NewLine;
                return;
            }
            ArgStr TypeOfCrit = new ArgStr("Уточнений Колмогорова", "p", "Критерій", "Виберіть критерій для перевірки гіпотези про збіг відтвореного розподілу до теоретичного  ", "<color>", PossibleCriterion.Criterions);
            ArgFloatMM Gamma = new ArgFloatMM(0.05, "", "Критичний рівень значущості", "Ймовірність помилки першого роду", "<Size>");
            OkCancelDlg it = new OkCancelDlg("Виберіть критерій", null
                                , TypeOfCrit
                                , Gamma
                                );
            DialogResult rc = it.ShowDialog();
            double answer;
            if (rc == DialogResult.OK)
            {
                if ((Gamma <= 0) || (Gamma >= 1))
                {
                    if (LogCheckBox.Checked)
                        LogOutputTextBox.Text += "Хибне значення α для критеріїв згоди" + Environment.NewLine;
                    Gamma.set(0.05);
                }
                switch (TypeOfCrit)
                {
                    case "Уточнений Колмогорова":   
                        {
                            double DNp = Math.Abs(DistrFuncData.DistrFunction[0] - ToolsForWork.ComputeDistr(Data.TypeOfDistr, Data.DataForWork[Data.CurrentSample][0], Data.Parameters));
                            double DNm = 0;

                            for (int i = 1; i < Data.DataForWork[Data.CurrentSample].Count; i++)
                            {
                                DNp = Math.Max(DNp, Math.Abs(DistrFuncData.DistrFunction[i] - ToolsForWork.ComputeDistr(Data.TypeOfDistr, Data.DataForWork[Data.CurrentSample][i], Data.Parameters)));
                                DNm = Math.Max(DNm, Math.Abs(DistrFuncData.DistrFunction[i] - ToolsForWork.ComputeDistr(Data.TypeOfDistr, Data.DataForWork[Data.CurrentSample][i-1], Data.Parameters)));
                            }
                            double z = Math.Sqrt(Data.DataForWork[Data.CurrentSample].Count) * Math.Max(DNp, DNm);
                            answer = 1 - ToolsForWork.ComputeKol(z,Data.DataForWork[Data.CurrentSample].Count);
                            textBox3.Text += "Статистика критерію - " + Math.Round(answer, Data.NumberOfNum) + ", критичне значення критерію - " + Math.Round(Gamma, Data.NumberOfNum) + Environment.NewLine; //quan + "--------------------------------------------------------------------------" + Environment.NewLine;
                            if (checkBox1.Checked)
                            {
                                LogOutputTextBox.Text += "Статистика критерію - " + Math.Round(answer, Data.NumberOfNum) + ", критичне значення критерію - " + Math.Round(Gamma, Data.NumberOfNum) + Environment.NewLine; //quan + "--------------------------------------------------------------------------" + Environment.NewLine;
                            }
                            if (answer >= Gamma)//quan)
                            {
                                textBox3.Text += "За уточненим критерієм згоди Колмогорова гіпотеза про збіг емпіричної функції розподілу з теоретичноую з критичним рівнем значущості " + Math.Round(Gamma, Data.NumberOfNum) + " є вірною " + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "За уточненим критерієм згоди Колмогорова гіпотеза про збіг емпіричної функції розподілу з теоретичноую з критичним рівнем значущості " + Math.Round(Gamma, Data.NumberOfNum) + " є вірною " + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                            else
                            {
                                textBox3.Text += "За уточненим критерієм згоди Колмогорова гіпотеза про збіг емпіричної функції розподілу з теоретичноую з критичним рівнем значущості " + Math.Round(Gamma, Data.NumberOfNum) + " є невірною " + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "За уточненим критерієм згоди Колмогорова гіпотеза про збіг емпіричної функції розподілу з теоретичноую з критичним рівнем значущості " + Math.Round(Gamma, Data.NumberOfNum) + " є невірною " + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                            break;
                        }   
                    case "χ^2 Пірсона":
                        {
                            answer = CheckPirs();
                            double quan = Quantile.HirsQuan(1-Gamma, HistData.NumberOfClasses-1);
                            textBox3.Text += "Статистика критерію - " + Math.Round(answer, Data.NumberOfNum) + ", критичне значення критерію - " + Math.Round(quan, Data.NumberOfNum) + Environment.NewLine; //+ "--------------------------------------------------------------------------" + Environment.NewLine;
                            if (checkBox1.Checked)
                            {
                                LogOutputTextBox.Text += "Статистика критерію - " + Math.Round(answer, Data.NumberOfNum) + ", критичне значення критерію - " + Math.Round(quan, Data.NumberOfNum) + Environment.NewLine; // + "--------------------------------------------------------------------------" + Environment.NewLine;
                            }
                            if (answer <= quan)
                            {
                                textBox3.Text += "За критерієм згоди χ^2 Пірсона гіпотеза про збіг емпіричної функції розподілу з теоретичноую з критичним рівнем значущості " + Math.Round(Gamma, Data.NumberOfNum) + " є вірною " + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "За критерієм згоди χ^2 Пірсона гіпотеза про збіг емпіричної функції розподілу з теоретичноую з критичним рівнем значущості " + Math.Round(Gamma, Data.NumberOfNum) + " є вірною " + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                            else
                            {
                                textBox3.Text += "За критерієм згоди χ^2 Пірсона гіпотеза про збіг емпіричної функції розподілу з теоретичноую з критичним рівнем значущості " + Math.Round(Gamma, Data.NumberOfNum) + " є невірною " + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "За критерієм згоди χ^2 Пірсона гіпотеза про збіг емпіричної функції розподілу з теоретичноую з критичним рівнем значущості " + Math.Round(Gamma, Data.NumberOfNum) + " є невірною " + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                            break;
                        }
                }
            }
            /////
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if ((Data.DataForWork.Count <= 0))
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Нема з чим працювати " + Environment.NewLine;
                return;
            }
            for (int i = 0; i < Data.TwoDemSamples.Count; i++)
            {
                if (Data.CurrentSample == Data.TwoDemSamples[i][0] || Data.CurrentSample == Data.TwoDemSamples[i][1])
                {
                    LogOutputTextBox.Text += "U cant add smthg to two-dem world! Use two-dem add" + Environment.NewLine;
                    return;
                }
            }
            int j;
            for (int i = 0; i < Data.MultiDemSamples.Count; i++)
            {
                for (j = 0; j < Data.MultiDemSamples[i].Length; j++)
                {
                    if (Data.CurrentSample == Data.MultiDemSamples[i][j])
                    {
                        LogOutputTextBox.Text += "U shall use special multi-dem button to delete anomalies from two-dem samples" + Environment.NewLine;
                        return;
                    }
                }
            }
            ArgFloatMM Parameter = new ArgFloatMM(0, "", "Нове значення", "Значення, яке буде додане до вибірки", "<Size>");
            OkCancelDlg it = new OkCancelDlg("Додайте елемент", null, Parameter);
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                {
                    double[] FW = new double[2];
                    FW[0] = (double)Parameter;
                    Data.StepBack[Data.CurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.added, FW));
                }
                Data.DataForWork[Data.CurrentSample].Add(Parameter);
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "До вибірки було додано елемент" + Environment.NewLine;
                //Data.DataForWork[Data.CurrentSample].Sort();
            }
            Data.DistrCreated = false;
            UpdateForm(Data.CurrentSample);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int i;
            {
                i = 0;
                for (; (i < Data.DataForWork[Data.CurrentSample].Count) && (Data.DataForWork[Data.CurrentSample][i] < 0); i++)
                { }
            }
            double alfa = ((double)i) / Data.DataForWork[Data.CurrentSample].Count;
            {
                {
                    textBox3.Text += "Кількість відємних значень -  " + i + ", тобто " + Math.Round(alfa, Data.NumberOfNum) + "% від загальної кількісті. ";
                    if (checkBox1.Checked)
                    {
                        LogOutputTextBox.Text += "Кількість відємних значень -  " + i + ", тобто " + Math.Round(alfa, Data.NumberOfNum) + "% від загальної кількісті. ";
                    }
                    if (alfa < 0.05)
                    {
                        textBox3.Text += "Це майже нічого не говорить про тип розподілу, окрім того факту, що це не розподіл арксинуса " + Environment.NewLine;
                        if (checkBox1.Checked)
                        {
                            LogOutputTextBox.Text += "Це майже нічого не говорить про тип розподілу, окрім того факту, що це не розподіл арксинуса " + Environment.NewLine;
                        }
                    }
                    else
                    {
                        if (alfa > 0.75)
                        {
                            textBox3.Text += "Незначна кількість розподілів може мати так багато відємних значень. Скоріш за все, це нормальний, рівномірний, або розподіл Лапласа" + Environment.NewLine;
                            if (checkBox1.Checked)
                            {
                                LogOutputTextBox.Text += "Незначна кількість розподілів може мати так багато відємних значень. Скоріш за все, це нормальний, рівномірний, або розподіл Лапласа" + Environment.NewLine;
                            }
                        }
                        else
                        {
                            textBox3.Text += "Суміш додатніх і відємних значень може вказувати на розподіли арксинуса, Лапласа, а також рівномірний та нормальний" + Environment.NewLine;
                            if (checkBox1.Checked)
                            {
                                LogOutputTextBox.Text += "Суміш додатніх і відємних значень може вказувати на розподіли арксинуса, Лапласа, а також рівномірний та нормальний" + Environment.NewLine;
                            }
                        }

                    }
                }
                {
                    textBox3.Text += "Коефіціент асиметрії = " + Math.Round(Data.EvalData.Skewness, Data.NumberOfNum) + "  ";
                    if (checkBox1.Checked)
                    {
                        LogOutputTextBox.Text += "Коефіціент асиметрії = " + Math.Round(Data.EvalData.Skewness, Data.NumberOfNum) + "  ";
                    }
                    if (Data.EvalData.Skewness < -0.4)
                    {
                        textBox3.Text += "Така значна права асиметрія зазвичай характерна лише для розподілу Вейбулла з високим значенням β." + Environment.NewLine;
                        if (checkBox1.Checked)
                        {
                            LogOutputTextBox.Text += "Така значна права асиметрія зазвичай характерна лише для розподілу Вейбула з високим значенням β." + Environment.NewLine;
                        }
                    }
                    else
                    {
                        if (Data.EvalData.Skewness > 0.5)
                        {
                            textBox3.Text += "Ліва асиметрія може вказувати на цілий ряд розподілів - експоненціальний, Вейбулла з невеликим значенням β, Релея,  лог-нормальний" + Environment.NewLine;
                            if (checkBox1.Checked)
                            {
                                LogOutputTextBox.Text += "Ліва асиметрія може вказувати на цілий ряд розподілів - експоненціальний, Вейбулла з невеликим значенням β, Релея,  лог-нормальний" + Environment.NewLine;
                            }
                        }
                        else
                        {
                            textBox3.Text += "Незначна асиметрія зазвичай характерна для розподілів арксинуса, Лапласа, нормального, рівномірного, а також Вейбулла при деяких значеннях β" + Environment.NewLine;
                            if (checkBox1.Checked)
                            {
                                LogOutputTextBox.Text += "Незначна асиметрія зазвичай характерна для розподілів арксинуса, Лапласа, нормального, рівномірного, а також Вейбулла при деяких значеннях β" + Environment.NewLine;
                            }
                        }
                    }
                }
                {
                    textBox3.Text += "Коефіціент ексцессу = " + Math.Round(Data.EvalData.KurtosisNeZ, Data.NumberOfNum) + "  ";
                    if (checkBox1.Checked)
                    {
                        LogOutputTextBox.Text += "Коефіціент ексцессу = " + Math.Round(Data.EvalData.KurtosisNeZ, Data.NumberOfNum) + "  ";
                    }
                    if (Data.EvalData.KurtosisNeZ > 1.5)
                    {
                        textBox3.Text += "Такий коефіціент ексцессу зазвичай вказує на гостроверхий розподіл - ексопненціальний, нормальний, Лапласа, можливо Вейбулла або лог-нормальний" + Environment.NewLine;
                        if (checkBox1.Checked)
                        {
                            LogOutputTextBox.Text += "Такий коефіціент ексцессу зазвичай вказує на гостроверхий розподіл - ексопненціальний, нормальний, Лапласа, можливо Вейбулла або лог-нормальний" + Environment.NewLine;
                        }
                    }
                    else
                    {
                        if (Data.EvalData.KurtosisNeZ < -0.75)
                        {
                            textBox3.Text += "Такий коефіціент ексцессу зазвичай вказує на розподіл типу шапіто або багатомодальний - рівномірний, деякі нормальні, а також арксинус або неоднорідні дані" + Environment.NewLine;
                            if (checkBox1.Checked)
                            {
                                LogOutputTextBox.Text += "Такий коефіціент ексцессу зазвичай вказує на розподіл типу шапіто або багатомодальний - рівномірний, деякі нормальні, а також арксинус або неоднорідні дані" + Environment.NewLine;
                            }
                        }
                        else
                        {
                            textBox3.Text += "Наближений до нуля коефіціент ексцессу зазвичай вказує на розподіл Релея, або деякі модифікації нормального чи Вейбулла" + Environment.NewLine;
                            if (checkBox1.Checked)
                            {
                                LogOutputTextBox.Text += "Наближений до нуля коефіціент ексцессу зазвичай вказує на розподіл Релея, або деякі модифікації нормального чи Вейбулла" + Environment.NewLine;
                            }
                        }
                    }
                }
                textBox3.Text += "--------------------------------------------------------------------------" + Environment.NewLine;
                if (checkBox1.Checked)
                {
                    LogOutputTextBox.Text += "--------------------------------------------------------------------------" + Environment.NewLine;
                }
            }
        }

        private void задатиКількістьЗнаківПісляКомиДляІнтерфейсівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OkCancelDlg it = new OkCancelDlg("Виберіть кількість знаків після коми", null, Data.NumberOfNum);
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                if (Data.NumberOfNum < 0 || Data.NumberOfNum > 10)
                {
                    LogOutputTextBox.Text += "Безсенсно" + Environment.NewLine;
                    Data.NumberOfNum.set(5);
                }
                if (!(Data.DataForWork.Count == 0 || Data.DataForWork[Data.CurrentSample].Count == 0))
                {
                    Build();
                    BuildTwoDem();
                }
            }
        }

        private void перевіритиВибіркиНаОднорідністьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArgStr depen = new ArgStr("Залежні", "p", "Залежність вибірок", "Чи є вибірки залежними?", "<color>", PossibleDepen.depen);
            ArgInt Number = new ArgInt(2, "", "Кількість вибірок", "Кількість вибірок для порівняння", "<Size>");
            ArgFloat Alfa = new ArgFloat(0.05, "", "Критичне значення", "Критичне значення", "<Size>");
            OkCancelDlg it = new OkCancelDlg("Перевірка вибірок на однорідність", null, depen, Number, Alfa);
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                if ((Number <= 1) || (Number > Data.DataForWork.Count))
                {
                    LogOutputTextBox.Text += "Безсенсно" + Environment.NewLine;
                    return;
                }
                if ((Alfa <= 0) || (Alfa >= 1))
                {
                    LogOutputTextBox.Text += "Безсенсно" + Environment.NewLine;
                    return;
                }
                if (depen == "Залежні")
                {
                    if (Number == 2)
                    { 
                        CritDepenTwo(Alfa);
                    }
                    else
                    {
                        CritDepenK(Number, Alfa);
                    }
                }
                else
                {
                    if (Number == 2)
                    {
                        CritIndepenTwo(Alfa);
                    }
                    else
                    {
                        CritIndepenK(Number, Alfa);
                    }
                }
                return;
            }
        }

        private void ZbigSeredDepen(int Number1, int Number2,double alfa)
        {
            int Num = Data.DataForWork[Number1].Count;
            List<double> zet = new List<double>();
            for (int i = 0; i < Num; i++)
            {
                zet.Add(Data.DataForWork[Number1][i] - Data.DataForWork[Number2][i]);
            }
            double zetExpV = 0;
            {
                for (int i = 0; i < Num; i++)
                {
                    zetExpV += zet[i];
                }
                zetExpV = zetExpV / Num;
            }
            double zetStD = 0;
            {
                for (int i = 0; i < Num; i++)
                {
                    zetStD += Math.Pow((zet[i] - zetExpV), 2);
                }
                zetStD *= (1.0) / (Num - 1);
                zetStD = (Math.Sqrt(zetStD));
            }
            double result = (zetExpV * Math.Sqrt(Num)) / zetStD;
            if ((zetExpV == 0) && (zetStD == 0))
            {
                LogOutputTextBox.Text += "Вибірки є абсолютно однаковими, а отже, однорідними" + Environment.NewLine;
                return;
            }
            if (Math.Abs(result) > Quantile.StudQuan(1 - alfa / 2, Num - 2))
            {
                LogOutputTextBox.Text += "Значення статистики = " + Math.Round(result,Data.NumberOfNum) + ", що по модулю перевищує значення квантилю " + Math.Round(Quantile.StudQuan(1 - alfa / 2, Num - 2),Data.NumberOfNum) + ", а отже, гіпотеза про збіг середніх має бути відхилена " + Environment.NewLine;
                return;
            }
            else
            {
                LogOutputTextBox.Text += "Значення статистики = " + Math.Round(result, Data.NumberOfNum) + ", що по модулю є меншим за значення квантилю " + Math.Round(Quantile.StudQuan(1 - alfa / 2, Num - 2), Data.NumberOfNum) + ", а отже, гіпотеза про збіг середніх має бути прийнята" + Environment.NewLine;
                return;
            }
        }


        private void ZbigSeredIndepen(int Number1, int Number2, double alfa)
        {
            int Num1 = Data.DataForWork[Number1].Count;
            int Num2 = Data.DataForWork[Number2].Count;
            double FirstExpV = 0;
            double SecondExpV = 0;
            {
                for (int i = 0; i < Num1; i++)
                {
                    FirstExpV += Data.DataForWork[Number1][i];
                }
                FirstExpV = FirstExpV / Num1;
                for (int i = 0; i < Num2; i++)
                {
                    SecondExpV += Data.DataForWork[Number2][i];
                }
                SecondExpV = SecondExpV / Num2;
            }
            double FirStD = 0;
            double SecStD = 0;
            {
                for (int i = 0; i < Num1; i++)
                {
                    FirStD += Math.Pow((Data.DataForWork[Number1][i] - FirstExpV), 2);
                }
                FirStD *= (1.0) / (Num1 - 1);
                FirStD = (Math.Sqrt(FirStD));
                for (int i = 0; i < Num2; i++)
                {
                    SecStD += Math.Pow((Data.DataForWork[Number2][i] - SecondExpV), 2);
                }
                SecStD *= (1.0) / (Num2 - 1);
                SecStD = (Math.Sqrt(SecStD));
            }
            if (Data.DataForWork[Number1].Count + Data.DataForWork[Number2].Count < 25)
            {
                double S2x = (FirStD * FirStD) / Num1;
                double S2y = (SecStD * SecStD) / Num2;
                double S2 = ((Num1 - 1) * S2x + (Num2 - 1) * S2y) / (Num1 + Num2 - 2);
                double result = ((FirstExpV - SecondExpV) / S2) * Math.Sqrt(((double)Num1 * Num2) / (Num1 + Num2));
                if (Math.Abs(result) > Quantile.StudQuan(1 - alfa / 2, Num1+Num2 - 2))
                {
                    LogOutputTextBox.Text += "Значення статистики = " + Math.Round(result, Data.NumberOfNum) + ", що по модулю перевищує значення квантилю " + Math.Round(Quantile.StudQuan(1 - alfa / 2, Num1 + Num2 - 2), Data.NumberOfNum) + ", а отже, гіпотеза про збіг середніх має бути відхилена " + Environment.NewLine;
                    return;
                }
                else
                {
                    LogOutputTextBox.Text += "Значення статистики = " + Math.Round(result,Data.NumberOfNum) + ", що по модулю є меншим за значення квантилю " + Math.Round(Quantile.StudQuan(1 - alfa / 2, Num1 + Num2 - 2),Data.NumberOfNum) + ", а отже, гіпотеза про збіг середніх має бути прийнята" + Environment.NewLine;
                    return;
                }
            }
            else
            {
                double result = (FirstExpV - SecondExpV) / Math.Sqrt((FirStD * FirStD) / Num1 + (SecStD * SecStD) / Num2);
                if (Math.Abs(result) > Quantile.StudQuan(1 - alfa / 2, Num1 + Num2 - 2))
                {
                    LogOutputTextBox.Text += "Значення статистики = " + Math.Round(result, Data.NumberOfNum) + ", що по модулю перевищує значення квантилю " + Math.Round(Quantile.StudQuan(1 - alfa / 2, Num1 + Num2 - 2), Data.NumberOfNum) + ", а отже, гіпотеза про збіг середніх має бути відхилена " + Environment.NewLine;
                    return;
                }
                else
                {
                    LogOutputTextBox.Text += "Значення статистики = " + Math.Round(result, Data.NumberOfNum) + ", що по модулю є меншим за значення квантилю " + Math.Round(Quantile.StudQuan(1 - alfa / 2, Num1 + Num2 - 2), Data.NumberOfNum) + ", а отже, гіпотеза про збіг середніх має бути прийнята" + Environment.NewLine;
                    return;
                }
            }
        }

        private void ZbigDispIndepen(int Number1, int Number2, double alfa)
        {
            int Num1 = Data.DataForWork[Number1].Count;
            int Num2 = Data.DataForWork[Number2].Count;
            double FirstExpV = 0;
            double SecondExpV = 0;
            {
                for (int i = 0; i < Num1; i++)
                {
                    FirstExpV += Data.DataForWork[Number1][i];
                }
                FirstExpV = FirstExpV / Num1;
                for (int i = 0; i < Num2; i++)
                {
                    SecondExpV += Data.DataForWork[Number2][i];
                }
                SecondExpV = SecondExpV / Num2;
            }
            double FirStD = 0;
            double SecStD = 0;
            {
                for (int i = 0; i < Num1; i++)
                {
                    FirStD += Math.Pow((Data.DataForWork[Number1][i] - FirstExpV), 2);
                }
                FirStD *= (1.0) / (Num1 - 1);
                for (int i = 0; i < Num2; i++)
                {
                    SecStD += Math.Pow((Data.DataForWork[Number2][i] - SecondExpV), 2);
                }
                SecStD *= (1.0) / (Num2 - 1);
            }
            double f = 0;
            if (FirStD > SecStD)
            {
                f = FirStD / SecStD;
            }
            else
            {
                f = SecStD/FirStD;
            }
            if (f > Quantile.FishQuan(1-alfa,Num1-1,Num2-1))
            {
                LogOutputTextBox.Text += "Значення статистики = " + Math.Round(f, Data.NumberOfNum) + ", що по модулю перевищує значення квантилю " + Math.Round(Quantile.FishQuan(1 - alfa, Num1 - 1, Num2 - 1), Data.NumberOfNum) + ", а отже, гіпотеза про збіг дисперсій має бути відхилена " + Environment.NewLine;
                return;
            }
            else
            {
                LogOutputTextBox.Text += "Значення статистики = " + Math.Round(f, Data.NumberOfNum) + ", що по модулю є меншим за значення квантилю " + Math.Round(Quantile.FishQuan(1 - alfa, Num1 - 1, Num2 - 1), Data.NumberOfNum) + ", а отже, гіпотеза про збіг дисперсій має бути прийнята" + Environment.NewLine;
                return;
            }
        }

        private void CritBart(int[] Nums, double Alfa)
        {
            int[] Numbers = new int[Nums.Length];
            double [] ExpVals = new double[Nums.Length];
            double[] StD = new double[Nums.Length];
            for (int i = 0; i < Nums.Length; i++)
            {
                Numbers[i] = Data.DataForWork[Nums[i]].Count;
                ExpVals[i] = 0;
                for (int j = 0; j < Numbers[i]; j++)
                {
                    ExpVals[i] += Data.DataForWork[Nums[i]][j];
                }
                ExpVals[i] = ExpVals[i] / Numbers[i];
                StD[i] = 0;
                for (int j = 0; j < Numbers[i]; j++)
                {
                    StD[i] += Math.Pow((Data.DataForWork[Nums[i]][j] - ExpVals[i]), 2);
                }
                StD[i] *= (1.0) / (Numbers[i] - 1);
            }
            double S2 = 0;
            double sumup = 0;
            double sumdown = 0;
            for (int i = 0; i < Nums.Length; i++)
            {
                sumdown += (Numbers[i] - 1);
                sumup += (Numbers[i] - 1) * StD[i];
            }
            S2 = sumup / sumdown;
            double B = 0;
            for (int i = 0; i < Nums.Length; i++)
            {
                B += (Numbers[i] - 1) * Math.Log(StD[i]/S2);
            }
            B *= -1;
            double C1 = 0;
            double C2 = 0;
            for (int i = 0; i < Nums.Length; i++)
            {
                C1 += (1.0 / (Numbers[i] - 1));
                C2 += (Numbers[i] - 1);
            }
            double C = 1 + (1.0 / (3 * (Nums.Length - 1))) * (C1 - (1.0 / C2));
            double result = B / C;
            if (Math.Abs(result) > Quantile.HirsQuan(1-Alfa,Nums.Length-1))
            {
                LogOutputTextBox.Text += "Значення статистики = " + Math.Round(result, Data.NumberOfNum) + ", що по модулю перевищує значення квантилю " + Math.Round(Quantile.HirsQuan(1 - Alfa, Nums.Length - 1), Data.NumberOfNum) + ", а отже, гіпотеза про збіг дисперсій к вибірок має бути відхилена " + Environment.NewLine;
                return;
            }
            else
            {
                LogOutputTextBox.Text += "Значення статистики = " + Math.Round(result, Data.NumberOfNum) + ", що по модулю є меншим за значення квантилю " + Math.Round(Quantile.HirsQuan(1 - Alfa, Nums.Length - 1), Data.NumberOfNum) + ", а отже, гіпотеза про збіг дисперсій к вибірок має бути прийнята" + Environment.NewLine;
                return;
            }

        }

        private void OdnDispAn(int[] Nums, double Alfa)
        {
            int[] Numbers = new int[Nums.Length];
            double[] ExpVals = new double[Nums.Length];
            double[] StD = new double[Nums.Length];
            double AllExp = 0;
            int AllNumb = 0;
            for (int i = 0; i < Nums.Length; i++)
            {
                Numbers[i] = Data.DataForWork[Nums[i]].Count;
                AllNumb += Numbers[i];
                ExpVals[i] = 0;
                for (int j = 0; j < Numbers[i]; j++)
                {
                    ExpVals[i] += Data.DataForWork[Nums[i]][j];
                }
                ExpVals[i] = ExpVals[i] / Numbers[i];
                StD[i] = 0;
                for (int j = 0; j < Numbers[i]; j++)
                {
                    StD[i] += Math.Pow((Data.DataForWork[Nums[i]][j] - ExpVals[i]), 2);
                }
                StD[i] *= (1.0) / (Numbers[i] - 1);
                AllExp += ExpVals[i] * Numbers[i];
            }
            AllExp = AllExp / (AllNumb);
            double S2M = 0;
            double S2B = 0;
            for (int i = 0; i < Nums.Length; i++)
            {
                S2M += Numbers[i] * Math.Pow(ExpVals[i] - AllExp, 2);
                S2B += (Numbers[i] - 1) * StD[i];
            }
            S2M = S2M / (Nums.Length - 1);
            S2B = S2B / (AllNumb - Nums.Length);
            double result = S2M / S2B;
            if (Math.Abs(result) > Quantile.FishQuan(1 - Alfa, Nums.Length - 1, AllNumb - Nums.Length))
            {
                LogOutputTextBox.Text += "Значення статистики = " + Math.Round(result, Data.NumberOfNum) + ", що по модулю перевищує значення квантилю " + Math.Round(Quantile.FishQuan(1 - Alfa, Nums.Length - 1, AllNumb - Nums.Length), Data.NumberOfNum) + ", а отже, гіпотеза про невелику різницю між середніми вибірок має бути відхилена " + Environment.NewLine;
                return;
            }
            else
            {
                LogOutputTextBox.Text += "Значення статистики = " + Math.Round(result, Data.NumberOfNum) + ", що по модулю є меншим за значення квантилю " + Math.Round(Quantile.FishQuan(1 - Alfa, Nums.Length - 1, AllNumb - Nums.Length), Data.NumberOfNum) + ", а отже, гіпотеза про невелику різницю між середніми вибірок має бути прийнята" + Environment.NewLine;
                return;
            }
        }

        private void CritAbba(int Number1, int Number2, double Alfa)
        {
            int Num = Data.DataForWork[Number1].Count;
            List<double> zet = new List<double>();
            for (int i = 0; i < Num; i++)
            {
                zet.Add(Data.DataForWork[Number1][i] - Data.DataForWork[Number2][i]);
            }
            double zetExpV = 0;
            {
                for (int i = 0; i < Num; i++)
                {
                    zetExpV += zet[i];
                }
                zetExpV = zetExpV / Num;
            }
            double zetStD = 0;
            {
                for (int i = 0; i < Num; i++)
                {
                    zetStD += Math.Pow((zet[i] - zetExpV), 2);
                }
                zetStD *= (1.0) / (Num - 1);
            }
            double d2 = 0;
            for (int i = 0; i < Num-1; i++)
            {
                d2 += Math.Pow(zet[i + 1] - zet[i], 2);
            }
            d2 = d2 / (Num - 1);
            double q = (d2) / (2 * zetStD);
            double result = (q - 1) * Math.Sqrt((Num*Num-1d)/(Num-2));
            //double result = -1 * (1 - q) * Math.Sqrt((2*Num+1)/(2-Math.Pow(1-q,2)));
            if (Math.Abs(result) > Quantile.StanQuanDv(1-Alfa/2))
            {
                LogOutputTextBox.Text += "Значення статистики = " + Math.Round(result, Data.NumberOfNum) + ", що по модулю перевищує значення квантилю " + Math.Round(Quantile.StanQuanOdn(1 - Alfa), Data.NumberOfNum) + ", а отже, гіпотеза про однорідність даних має бути відхилена " + Environment.NewLine;
                return;
            }
            else
            {
                LogOutputTextBox.Text += "Значення статистики = " + Math.Round(result, Data.NumberOfNum) + ", що по модулю є меншим за  значення квантилю " + Math.Round(Quantile.StanQuanOdn(1 - Alfa), Data.NumberOfNum) + ", а отже, гіпотеза про однорідність даних має бути прийнята" + Environment.NewLine;
                return;
            }

        }

        private void CritManU(int Number1, int Number2, double Alfa)
        {
            int Num1 = Data.DataForWork[Number1].Count;
            int Num2 = Data.DataForWork[Number2].Count;
            double Sum = 0;
            for (int i = 0; i < Num2; i++)
            {
                for (int j = 0; j < Num1; j++)
                {
                    if (Data.DataForWork[Number1][j] > Data.DataForWork[Number2][i])
                    {
                        Sum++;
                    }
                }
            }
            double ExpVal = ((double)Num1 * Num2) / 2;
            double dispU = ((double)Num1 * Num2 * (Num1 + Num2 + 1)) / 12;
            double result = (Sum - ExpVal) / Math.Sqrt(dispU);
            double lol = Quantile.StanQuanDv(1 - Alfa / 2);
            double lil = Quantile.StanQuanDv(1 - Alfa );
            double loel = Quantile.StanQuanOdn(1 - Alfa / 2);
            double lel = Quantile.StanQuanOdn(1 - Alfa );
            if (Math.Abs(result) > Quantile.StanQuanOdn(1 - Alfa / 2))
            {
                LogOutputTextBox.Text += "Значення статистики = " + Math.Round(result, Data.NumberOfNum) + ", що є більшим по модулю за значення квантилю " + Math.Round(Quantile.StanQuanOdn(1 - Alfa / 2), Data.NumberOfNum) + ", а отже, гіпотеза про збіг законів розподілу має бути відхилена " + Environment.NewLine;
                return;
            }
            else
            {
                LogOutputTextBox.Text += "Значення статистики = " + Math.Round(result, Data.NumberOfNum) + ", що є меншим по модулю заа  значення квантилю " + Math.Round(Quantile.StanQuanOdn(1 - Alfa / 2), Data.NumberOfNum) + ", а отже, гіпотеза про збіг законів розподілу має бути прийнята" + Environment.NewLine;
                return;
            }
        }

        private void CritZnak(int Number1, int Number2, double Alfa)
        {
            int Num = Data.DataForWork[Number1].Count;
            List<double> zet = new List<double>();
            double sum = 0;
            for (int i = 0; i < Num; i++)
            {
                zet.Add(Data.DataForWork[Number1][i] - Data.DataForWork[Number2][i]);
                if (zet[i] > 0)
                    sum++;
            }
            for (int i = 0; i < zet.Count; i++)
            {
                if (zet[i] == 0)
                {
                    zet.RemoveAt(i);
                    i--;
                }
            }
            double S = (2 * sum - 1 - zet.Count) / Math.Sqrt(zet.Count);
            if (Math.Abs(S) > Quantile.StanQuanOdn(1 - Alfa))
            {
                LogOutputTextBox.Text += "Значення статистики = " + Math.Round(S, Data.NumberOfNum) + ", що по модулю перевищує значення квантилю " + Math.Round(Quantile.StanQuanOdn(1 - Alfa), Data.NumberOfNum) + ", а отже, гіпотеза про збіг функцій розподілу має бути відхилена " + Environment.NewLine;
                return;
            }
            else
            {
                LogOutputTextBox.Text += "Значення статистики = " + Math.Round(S, Data.NumberOfNum) + ", що по модулю є меншим за  значення квантилю " + Math.Round(Quantile.StanQuanOdn(1 - Alfa), Data.NumberOfNum) + ", а отже, гіпотеза про збіг функцій розподілу має бути прийнята" + Environment.NewLine;
                return;
            }
        }

        private void CritVilk(int Number1, int Number2, double Alfa)
        {
            int Num1 = Data.DataForWork[Number1].Count;
            int Num2 = Data.DataForWork[Number2].Count;
            int i = 0;
            int j = 0;
            int k = 1;
            List<double> zet = new List<double>();
            List<double> zetT = new List<double>();
            List<double> zetK = new List<double>();
            for (; (i < Num1) || (j < Num2); )
            {
                if (i == Num1)
                {
                    zet.Add(Data.DataForWork[Number2][j]);
                    zetT.Add(2);
                    zetK.Add(k++);
                    j++;
                    continue;
                }
                if (j == Num2)
                {
                    zet.Add(Data.DataForWork[Number1][i]);
                    zetT.Add(1);
                    zetK.Add(k++);
                    i++;
                    continue;
                }
                if (Data.DataForWork[Number1][i] <= Data.DataForWork[Number2][j])
                {
                    zet.Add(Data.DataForWork[Number1][i]);
                    zetT.Add(1);
                    zetK.Add(k++);
                    i++;
                    continue;
                }
                else
                {
                    zet.Add(Data.DataForWork[Number2][j]);
                    zetT.Add(2);
                    zetK.Add(k++);
                    j++;
                    continue;
                }
            }
            for (i = 0, k=0; i < zet.Count; i+=k, k=0)
            {
                double perm = zet[i];
                double sum = zetK[i];
                k++;
                while ((i + k < zet.Count) && (zet[i + k] == perm))
                {
                    sum+=zetK[i+k];
                    k++;
                }
                double val = sum/k;
                for (int l = i; l < i + k; l++)
                {
                    zetK[l] = val;
                }
            }
            double crit = 0;
            for (i = 0; i < zetK.Count; i++)
            {
                if (zetT[i] == 1)
                {
                    crit += zetK[i];
                }
            }
            double expcrit = (Num1 * (zet.Count + 1d)) / 2;
            double devcrit = (Num1 * Num2 * (zet.Count + 1d)) / 12;
            double result = (crit - expcrit) /Math.Sqrt( devcrit);
            if (Math.Abs(result) > Quantile.StanQuanOdn(1 - Alfa / 2))
            {
                LogOutputTextBox.Text += "Значення статистики = " + Math.Round(result, Data.NumberOfNum) + ", що є більшим по модулю за значення квантилю " + Math.Round(Quantile.StanQuanOdn(1 - Alfa / 2), Data.NumberOfNum) + ", а отже, гіпотеза про збіг законів розподілу має бути відхилена " + Environment.NewLine;
                return;
            }
            else
            {
                LogOutputTextBox.Text += "Значення статистики = " + Math.Round(result, Data.NumberOfNum) + ", що є меншим по модулю заа  значення квантилю " + Math.Round(Quantile.StanQuanOdn(1 - Alfa / 2), Data.NumberOfNum) + ", а отже, гіпотеза про збіг законів розподілу має бути прийнята" + Environment.NewLine;
                return;
            }
        }

        private void CritRizn(int Number1, int Number2, double Alfa)
        {
            int Num1 = Data.DataForWork[Number1].Count;
            int Num2 = Data.DataForWork[Number2].Count;
            int i = 0;
            int j = 0;
            int k = 1;
            List<double> zet = new List<double>();
            List<double> zetT = new List<double>();
            List<double> zetK = new List<double>();
            for (; (i < Num1) || (j < Num2); )
            {
                if (i == Num1)
                {
                    zet.Add(Data.DataForWork[Number2][j]);
                    zetT.Add(2);
                    zetK.Add(k++);
                    j++;
                    continue;
                }
                if (j == Num2)
                {
                    zet.Add(Data.DataForWork[Number1][i]);
                    zetT.Add(1);
                    zetK.Add(k++);
                    i++;
                    continue;
                }
                if (Data.DataForWork[Number1][i] <= Data.DataForWork[Number2][j])
                {
                    zet.Add(Data.DataForWork[Number1][i]);
                    zetT.Add(1);
                    zetK.Add(k++);
                    i++;
                    continue;
                }
                else
                {
                    zet.Add(Data.DataForWork[Number2][j]);
                    zetT.Add(2);
                    zetK.Add(k++);
                    j++;
                    continue;
                }
            }
            for (i = 0, k = 0; i < zet.Count; i += k, k = 0)
            {
                double perm = zet[i];
                double sum = zetK[i];
                k++;
                while ((i + k < zet.Count) && (zet[i + k] == perm))
                {
                    sum += zetK[i + k];
                    k++;
                }
                double val = sum / k;
                for (int l = i; l < i + k; l++)
                {
                    zetK[l] = val;
                }
            }
            double crit1 = 0;
            double crit2 = 0;
            for (i = 0; i < zetK.Count; i++)
            {
                if (zetT[i] == 1)
                {
                    crit1 += zetK[i];
                }
                else
                {
                    crit2 += zetK[i];
                }
            }
            crit1 = crit1 / Num1;
            crit2 = crit2 / Num2;
            double result = (crit1 - crit2) / (zet.Count * Math.Sqrt((zet.Count + 1.0) / (12 * Num1 * Num2)));
            if (Math.Abs(result) > Quantile.StanQuanOdn(1 - Alfa / 2))
            {
                LogOutputTextBox.Text += "Значення статистики = " + Math.Round(result, Data.NumberOfNum) + ", що є більшим по модулю за значення квантилю " + Math.Round(Quantile.StanQuanOdn(1 - Alfa / 2), Data.NumberOfNum) + ", а отже, гіпотеза про збіг законів розподілу має бути відхилена " + Environment.NewLine;
                return;
            }
            else
            {
                LogOutputTextBox.Text += "Значення статистики = " + Math.Round(result, Data.NumberOfNum) + ", що є меншим по модулю заа  значення квантилю " + Math.Round(Quantile.StanQuanOdn(1 - Alfa / 2), Data.NumberOfNum) + ", а отже, гіпотеза про збіг законів розподілу має бути прийнята" + Environment.NewLine;
                return;
            }
        }

        private void CritDepenTwo(double Alfa)
        {
            ArgStr Type = new ArgStr("Перевірка збігу середніх", "p", "Критерій", "Критерій, за яким буде оцінюватися однорідність", "<color>", DepenCritTwo.crit);
            ArgInt Num1= new ArgInt(1, "", "Номер вибірки", "Вибір вибірки для перевірки на однорідність", "<Size>");
            ArgInt Num2 = new ArgInt(2, "", "Номер вибірки", "Вибір вибірки для перевірки на однорідність", "<Size>");
            OkCancelDlg it = new OkCancelDlg("Виберіть критерій та вибірки для порівняння", null,Type, Num1, Num2);
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                if ((Num1 < 1) || (Num2 < 1) || (Num1 > Data.DataForWork.Count) || (Num2 > Data.DataForWork.Count))
                {
                    LogOutputTextBox.Text += "Невірно заданий номер розподілу " + Environment.NewLine;
                    return;
                }
                Num1.set(Num1 - 1);
                Num2.set(Num2 - 1);
                if ((Data.DataForWork[Num1].Count < 3) || (Data.DataForWork[Num2].Count < 3))
                {
                    LogOutputTextBox.Text += "Одна  з вибірок пуста, порівняння безсенсне" + Environment.NewLine;
                    return;
                }
                if (Data.DataForWork[Num1].Count != Data.DataForWork[Num2].Count)
                {
                    LogOutputTextBox.Text += "Залежні вибірки мають бути однакового розміру" + Environment.NewLine;
                    return;
                }
                int[] Nums = new int[2];
                Nums[0] = Num1;
                Nums[1] = Num2;
                string TypeOfCrit = (string)Type;
                switch (TypeOfCrit)
                {
                    case "Перевірка збігу середніх":
                        {
                            ZbigSeredDepen(Num1, Num2, Alfa);
                            break;
                        }
                    case "Перевірка збігу дисперсій":
                        {
                            ZbigDispIndepen(Num1, Num2, Alfa);
                            break;
                        }
                    case "критерій Бартлетта":
                        {
                            CritBart(Nums, Alfa);
                            break;
                        }
                    case "Однофакторний дисперсійний аналіз":
                        {
                            OdnDispAn(Nums, Alfa);
                            break;
                        }
                    case "критерій Аббе":
                        {
                            CritAbba(Num1, Num2, Alfa);
                            break;
                        }
                    case "U-критерій Манна–Уїтні":
                        {
                            CritManU(Num1, Num2, Alfa);
                            break;
                        }
                    case "Критерій знаків":
                        {
                            CritZnak(Num1, Num2, Alfa);
                            break;
                        }
                    case "Критерій Вілкоксона":
                        {
                            CritVilk(Num1, Num2, Alfa);
                            break;
                        }
                    case "критерій різниці середніх рангів вибірок":
                        {
                            CritRizn(Num1, Num2, Alfa);
                            break;
                        }
                    /*case "Н-критерій":
                        {
                            Hcrit(Nums, Alfa);
                            break;
                        }*/
                }
            }
        }

        private void CritIndepenTwo(double Alfa)
        {
            ArgStr Type = new ArgStr("Перевірка збігу середніх", "p", "Критерій", "Критерій, за яким буде оцінюватися однорідність", "<color>", IndepenCritTwo.crit);
            ArgInt Num1 = new ArgInt(1, "", "Номер вибірки", "Вибір вибірки для перевірки на однорідність", "<Size>");
            ArgInt Num2 = new ArgInt(2, "", "Номер вибірки", "Вибір вибірки для перевірки на однорідність", "<Size>");
            OkCancelDlg it = new OkCancelDlg("Виберіть критерій та вибірки для порівняння", null, Type, Num1, Num2);
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                if ((Num1 < 1) || (Num2 < 1) || (Num1 > Data.DataForWork.Count) || (Num2 > Data.DataForWork.Count))
                {
                    LogOutputTextBox.Text += "Невірно заданий номер розподілу " + Environment.NewLine;
                    return;
                }
                Num1.set(Num1 - 1);
                Num2.set(Num2 - 1);
                if ((Data.DataForWork[Num1].Count < 3) || (Data.DataForWork[Num2].Count < 3))
                {
                    LogOutputTextBox.Text += "Одна  з вибірок пуста, порівняння безсенсне" + Environment.NewLine;
                    return;
                }
                int[] Nums = new int[2];
                Nums[0] = Num1;
                Nums[1] = Num2;
                string TypeOfCrit = (string)Type;
                switch (TypeOfCrit)
                {
                    case "Перевірка збігу середніх":
                        {
                            ZbigSeredIndepen(Num1, Num2, Alfa);
                            break;
                        }
                    case "Перевірка збігу дисперсій":
                        {
                            ZbigDispIndepen(Num1, Num2, Alfa);
                            break;
                        }
                    case "критерій Бартлетта":
                        {
                            CritBart(Nums, Alfa);
                            break;
                        }
                    case "Однофакторний дисперсійний аналіз":
                        {
                            OdnDispAn(Nums, Alfa);
                            break;
                        }
                    case "U-критерій Манна–Уїтні":
                        {
                            CritManU(Num1, Num2, Alfa);
                            break;
                        }
                    case "Критерій Вілкоксона":
                        {
                            CritVilk(Num1, Num2, Alfa);
                            break;
                        }
                    case "критерій різниці середніх рангів вибірок":
                        {
                            CritRizn(Num1, Num2, Alfa);
                            break;
                        }
                    /*case "Н-критерій":
                        {
                            Hcrit(Nums, Alfa);
                            break;
                        }*/
                }
            }
        }

        private void CritDepenK(int InpNumber, double Alfa)
        {
            ArgStr Type = new ArgStr("критерій Бартлетта", "p", "Критерій", "Критерій, за яким буде оцінюватися однорідність", "<color>", DepenCritK.crit);
            Arg[] ArrayOfNumbers = new Arg[InpNumber+1];
            ArrayOfNumbers[0] = Type;
            for (int i = 0; i < InpNumber; i++)
            {
                ArrayOfNumbers[i+1] = new ArgInt(i+1, "", "Номер вибірки", "Вибір вибірки для перевірки на однорідність", "<Size>");
            }
            OkCancelDlg it = new OkCancelDlg("Виберіть критерій та вибірки для порівняння", null,  ArrayOfNumbers);
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                for(int i=1; i<=InpNumber;i++)
                {
                    if(((ArrayOfNumbers[i] as ArgInt)<1)||((ArrayOfNumbers[i] as ArgInt)>Data.DataForWork.Count))
                    {
                        LogOutputTextBox.Text += "Невірно заданий номер розподілу " + Environment.NewLine;
                    return;
                    }
                }
                for (int i = 1; i <=InpNumber; i++)
                {
                    (ArrayOfNumbers[i] as ArgInt).set((ArrayOfNumbers[i] as ArgInt) - 1);
                    if (Data.DataForWork[(ArrayOfNumbers[i] as ArgInt)].Count < 3)
                    {
                        LogOutputTextBox.Text += "Одна  з вибірок пуста, порівняння безсенсне" + Environment.NewLine;
                        return;
                    }
                }
                for (int i = 1; i < InpNumber; i++)
                {
                    if (Data.DataForWork[(ArrayOfNumbers[i] as ArgInt)].Count != Data.DataForWork[(ArrayOfNumbers[i+1] as ArgInt)].Count)
                    {
                        LogOutputTextBox.Text += "Залежні вибірки мають бути однакового розміру" + Environment.NewLine;
                        return;
                    }
                }
                int[] Nums = new int[InpNumber];
                for (int i = 0; i < InpNumber; i++)
                {
                    Nums[i] = (ArrayOfNumbers[i + 1] as ArgInt);
                }
                string TypeOfCrit = (string)Type;
                switch (TypeOfCrit)
                {
                    case "критерій Бартлетта":
                        {
                            CritBart(Nums, Alfa);
                            break;
                        }
                    case "Однофакторний дисперсійний аналіз":
                        {
                            OdnDispAn(Nums, Alfa);
                            break;
                        }
                    /*case "Н-критерій":
                        {
                            Hcrit(Nums, Alfa);
                            break;
                        }*/
                }
            }
        }

        private void CritIndepenK(int InpNumber, double Alfa)
        {
            ArgStr Type = new ArgStr("критерій Бартлетта", "p", "Критерій", "Критерій, за яким буде оцінюватися однорідність", "<color>", DepenCritK.crit);
            Arg[] ArrayOfNumbers = new Arg[InpNumber + 1];
            ArrayOfNumbers[0] = Type;
            for (int i = 0; i < InpNumber; i++)
            {
                ArrayOfNumbers[i + 1] = new ArgInt(i + 1, "", "Номер вибірки", "Вибір вибірки для перевірки на однорідність", "<Size>");
            }
            OkCancelDlg it = new OkCancelDlg("Виберіть критерій та вибірки для порівняння", null, ArrayOfNumbers);
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                for(int i=1; i<=InpNumber;i++)
                {
                    if(((ArrayOfNumbers[i] as ArgInt)<1)||((ArrayOfNumbers[i] as ArgInt)>Data.DataForWork.Count))
                    {
                        LogOutputTextBox.Text += "Невірно заданий номер розподілу " + Environment.NewLine;
                        return;
                    }
                }
                for (int i = 1; i <= InpNumber; i++)
                {
                    (ArrayOfNumbers[i] as ArgInt).set((ArrayOfNumbers[i] as ArgInt) - 1);
                    if (Data.DataForWork[(ArrayOfNumbers[i] as ArgInt)].Count < 3)
                    {
                        LogOutputTextBox.Text += "Одна  з вибірок пуста, порівняння безсенсне" + Environment.NewLine;
                        return;
                    }
                }
                int[] Nums = new int[InpNumber];
                for (int i = 0; i < InpNumber; i++)
                {
                    Nums[i] = (ArrayOfNumbers[i + 1] as ArgInt);
                }
                string TypeOfCrit = (string)Type;
                switch (TypeOfCrit)
                {
                    case "критерій Бартлетта":
                        {
                            CritBart(Nums, Alfa);
                            break;
                        }
                    case "Однофакторний дисперсійний аналіз":
                        {
                            OdnDispAn(Nums, Alfa);
                            break;
                        }
                    /*case "Н-критерій":
                        {
                            Hcrit(Nums, Alfa);
                            break;
                        }*/
                }
            }
        }
        
        private void button14_Click(object sender, EventArgs e)
        {
            if (!Data.DistrCreated)
            {
                textBox3.Text += "Необхідно спочатку відтворити розподіл" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                if (checkBox1.Checked)
                {
                    LogOutputTextBox.Text += "Необхідно спочатку відтворити розподіл" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                }
                return;
            }
            if ((Data.TypeOfDistr == "Рівномірний") || (Data.TypeOfDistr == "Вейбулла"))
            {
                textBox3.Text += "Для рівномірного розподілу та розподілу Вейбулла t-тест не проводиться" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                if (checkBox1.Checked)
                {
                    LogOutputTextBox.Text += "Для рівномірного розподілу та розподілу Вейбулла t-тест не проводиться" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                }
                return;
            }
            switch (Data.TypeOfDistr)
            {
                case "Експоненціальний":
                    {
                        ArgStr parametes = new ArgStr("λ", "p", "Параметр", "Задайте параметр, який буде перевірено", "<color>", ParamsExp.parameters);
                        ArgFloat alfa = new ArgFloat(0.05, "", "Рівень значущості", "Ймовірність помилки першого роду", "<Size>");
                        ArgFloat NewValue = new ArgFloat(0, "", "Значення параметру", "Введіть значення цього параметру для порівняння зі змодельованим", "<Size>");
                        OkCancelDlg it = new OkCancelDlg("Виберіть параметр для перевірки t-тестом", null, parametes, NewValue, alfa);
                        DialogResult rc = it.ShowDialog();
                        if (rc == DialogResult.OK)
                        {
                            if ((alfa <= 0) || (alfa >= 1))
                            {
                                textBox3.Text += "Хибне значення α" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "Хибне значення α" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                                return;
                            }
                            if(NewValue <=0)
                            {
                                textBox3.Text += "Хибне значення параметру" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "Хибне значення параметру" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                                return;
                            }   
                            double lambda = 1.0 / Data.EvalData.ExpValues;
                            double displambda = (lambda * lambda) / Data.DataForWork[Data.CurrentSample].Count;
                            double quan = Quantile.StudQuan(1-alfa/2,Data.DataForWork[Data.CurrentSample].Count);
                            double result = (NewValue-lambda)/displambda;
                            textBox3.Text += "Значення статистики  t = " +  Math.Round(result, Data.NumberOfNum)  +  Environment.NewLine;
                            if (checkBox1.Checked)
                            {
                                LogOutputTextBox.Text += "Значення статистики  t = " + Math.Round(result, Data.NumberOfNum) + Environment.NewLine;
                            }
                            if (Math.Abs(result) <= quan)
                            {
                                textBox3.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum)  + ", гіпотеза про рівність параметру та його оцінки є вірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum)  + ", гіпотеза про рівність параметру та його оцінки є вірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                            else
                            {
                                textBox3.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum)  + ", гіпотеза про рівність параметру та його оцінки є невірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є невірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                        }
                        break;
                    }
                case "Арксинуса":
                    {
                        ArgStr parametes = new ArgStr("a", "p", "Параметр", "Задайте параметр, який буде перевірено", "<color>", ParamsArc.parameters);
                        ArgFloat alfa = new ArgFloat(0.05, "", "Рівень значущості", "Ймовірність помилки першого роду", "<Size>");
                        ArgFloat NewValue = new ArgFloat(0, "", "Значення параметру", "Введіть значення цього параметру для порівняння зі змодельованим", "<Size>");
                        OkCancelDlg it = new OkCancelDlg("Виберіть параметр для перевірки t-тестом", null, parametes, NewValue, alfa);
                        DialogResult rc = it.ShowDialog();
                        if (rc == DialogResult.OK)
                        {
                            if ((alfa <= 0) || (alfa >= 1))
                            {
                                textBox3.Text += "Хибне значення α" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "Хибне значення α" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                                return;
                            }
                            if (NewValue <= 0)
                            {
                                textBox3.Text += "Хибне значення параметру" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "Хибне значення параметру" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                                return;
                            }  
                            double alef = Math.Sqrt(2) * Data.EvalData.StandDevZ;
                            double dispalef = (Math.Sqrt(2) / (2 * Data.EvalData.StandDevZ)) * ((ToolsForWork.ComputeCentralMoment(Data.DataForWork[Data.CurrentSample], 4) - Math.Pow(ToolsForWork.ComputeCentralMoment(Data.DataForWork[Data.CurrentSample], 2), 2))) / Data.DataForWork[Data.CurrentSample].Count;
                            double quan = Quantile.StudQuan(1 - alfa / 2, Data.DataForWork[Data.CurrentSample].Count);
                            double result = (NewValue - alef) / dispalef;
                            textBox3.Text += "Значення статистики  t = " + Math.Round(result, Data.NumberOfNum) + Environment.NewLine;
                            if (checkBox1.Checked)
                            {
                                LogOutputTextBox.Text += "Значення статистики  t = " + Math.Round(result, Data.NumberOfNum) + Environment.NewLine;
                            }
                            if (Math.Abs(result) <= quan)
                            {
                                textBox3.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є вірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є вірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                            else
                            {
                                textBox3.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є невірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є невірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                        }
                        break;
                    }
                case "Арксинуса - старий":
                    {
                        ArgStr parametes = new ArgStr("a", "p", "Параметр", "Задайте параметр, який буде перевірено", "<color>", ParamsArc.parameters);
                        ArgFloat alfa = new ArgFloat(0.05, "", "Рівень значущості", "Ймовірність помилки першого роду", "<Size>");
                        ArgFloat NewValue = new ArgFloat(0, "", "Значення параметру", "Введіть значення цього параметру для порівняння зі змодельованим", "<Size>");
                        OkCancelDlg it = new OkCancelDlg("Виберіть параметр для перевірки t-тестом", null, parametes, NewValue, alfa);
                        DialogResult rc = it.ShowDialog();
                        if (rc == DialogResult.OK)
                        {
                            if ((alfa <= 0) || (alfa >= 1))
                            {
                                textBox3.Text += "Хибне значення α" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "Хибне значення α" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                                return;
                            }
                            if (NewValue <= 0)
                            {
                                textBox3.Text += "Хибне значення параметру" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "Хибне значення параметру" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                                return;
                            }  
                            double alef = Math.Sqrt(2) * Data.EvalData.StandDevZ;
                            double dispalef = (Math.Pow(alef, 4)) / (8 * Data.DataForWork[Data.CurrentSample].Count);
                            double quan = Quantile.StudQuan(1 - alfa / 2, Data.DataForWork[Data.CurrentSample].Count);
                            double result = (NewValue - alef) / dispalef;
                            textBox3.Text += "Значення статистики  t = " + Math.Round(result, Data.NumberOfNum) + Environment.NewLine;
                            if (checkBox1.Checked)
                            {
                                LogOutputTextBox.Text += "Значення статистики  t = " + Math.Round(result, Data.NumberOfNum) + Environment.NewLine;
                            }
                            if (Math.Abs(result) <= quan)
                            {
                                textBox3.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є вірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є вірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                            else
                            {
                                textBox3.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є невірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є невірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                        }
                        break;
                    }
                case "Релея":
                    {
                        ArgStr parametes = new ArgStr("σ", "p", "Параметр", "Задайте параметр, який буде перевірено", "<color>", ParamsRel.parameters);
                        ArgFloat alfa = new ArgFloat(0.05, "", "Рівень значущості", "Ймовірність помилки першого роду", "<Size>");
                        ArgFloat NewValue = new ArgFloat(0, "", "Значення параметру", "Введіть значення цього параметру для порівняння зі змодельованим", "<Size>");
                        OkCancelDlg it = new OkCancelDlg("Виберіть параметр для перевірки t-тестом", null, parametes, NewValue, alfa);
                        DialogResult rc = it.ShowDialog();
                        if (rc == DialogResult.OK)
                        {
                            if ((alfa <= 0) || (alfa >= 1))
                            {
                                textBox3.Text += "Хибне значення α" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "Хибне значення α" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                                return;
                            }
                            if (NewValue <= 0)
                            {
                                textBox3.Text += "Хибне значення параметру" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "Хибне значення параметру" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                                return;
                            } 
                            double sigma = 0.8 * Data.EvalData.ExpValues;
                            double dispsigma = (0.2752 * sigma * sigma) / Data.DataForWork[Data.CurrentSample].Count;
                            double quan = Quantile.StudQuan(1 - alfa / 2, Data.DataForWork[Data.CurrentSample].Count);
                            double result = (NewValue - sigma) / dispsigma;
                            textBox3.Text += "Значення статистики  t = " + Math.Round(result, Data.NumberOfNum) + Environment.NewLine;
                            if (checkBox1.Checked)
                            {
                                LogOutputTextBox.Text += "Значення статистики  t = " + Math.Round(result, Data.NumberOfNum) + Environment.NewLine;
                            }
                            if (Math.Abs(result) <= quan)
                            {
                                textBox3.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є вірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є вірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                            else
                            {
                                textBox3.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є невірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є невірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                        }
                        break;
                    }
                case "Релея - старий":
                    {
                        ArgStr parametes = new ArgStr("σ", "p", "Параметр", "Задайте параметр, який буде перевірено", "<color>", ParamsRel.parameters);
                        ArgFloat alfa = new ArgFloat(0.05, "", "Рівень значущості", "Ймовірність помилки першого роду", "<Size>");
                        ArgFloat NewValue = new ArgFloat(0, "", "Значення параметру", "Введіть значення цього параметру для порівняння зі змодельованим", "<Size>");
                        OkCancelDlg it = new OkCancelDlg("Виберіть параметр для перевірки t-тестом", null, parametes, NewValue, alfa);
                        DialogResult rc = it.ShowDialog();
                        if (rc == DialogResult.OK)
                        {
                            if ((alfa <= 0) || (alfa >= 1))
                            {
                                textBox3.Text += "Хибне значення α" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "Хибне значення α" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                                return;
                            }
                            if (NewValue <= 0)
                            {
                                textBox3.Text += "Хибне значення параметру" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "Хибне значення параметру" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                                return;
                            } 
                            double sigma = (2.0 / Math.Sqrt(Math.PI)) * Data.EvalData.ExpValues;
                            double dispsigma = (4.0 / Math.PI) * ((Data.EvalData.StandDevZ * Data.EvalData.StandDevZ) / Data.DataForWork[Data.CurrentSample].Count);
                            double quan = Quantile.StudQuan(1 - alfa / 2, Data.DataForWork[Data.CurrentSample].Count);
                            double result = (NewValue - sigma) / dispsigma;
                            textBox3.Text += "Значення статистики  t = " + Math.Round(result, Data.NumberOfNum) + Environment.NewLine;
                            if (checkBox1.Checked)
                            {
                                LogOutputTextBox.Text += "Значення статистики  t = " + Math.Round(result, Data.NumberOfNum) + Environment.NewLine;
                            }
                            if (Math.Abs(result) <= quan)
                            {
                                textBox3.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є вірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є вірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                            else
                            {
                                textBox3.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є невірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є невірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                        }
                        break;
                    }
                case "Нормальний":
                    {
                        ArgStr parametes = new ArgStr("μ", "p", "Параметр", "Задайте параметр, який буде перевірено", "<color>", ParamsNorm.parameters);
                        ArgFloat alfa = new ArgFloat(0.05, "", "Рівень значущості", "Ймовірність помилки першого роду", "<Size>");
                        ArgFloat NewValue = new ArgFloat(0, "", "Значення параметру", "Введіть значення цього параметру для порівняння зі змодельованим", "<Size>");
                        OkCancelDlg it = new OkCancelDlg("Виберіть параметр для перевірки t-тестом", null, parametes, NewValue, alfa);
                        DialogResult rc = it.ShowDialog();
                        if (rc == DialogResult.OK)
                        {
                            if ((alfa <= 0) || (alfa >= 1))
                            {
                                textBox3.Text += "Хибне значення α" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "Хибне значення α" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                                return;
                            }
                            double Mu = Data.EvalData.ExpValues;
                            double dispmu = (Data.EvalData.StandDevNeZ * Data.EvalData.StandDevNeZ) / Data.DataForWork[Data.CurrentSample].Count;
                            double sigma = ((double)Data.DataForWork[Data.CurrentSample].Count / (Data.DataForWork[Data.CurrentSample].Count - 1)) * Data.EvalData.StandDevZ;//(0.344*σ^2)/N
                            double dispsigma = (Data.EvalData.StandDevNeZ * Data.EvalData.StandDevNeZ) / (2 * Data.DataForWork[Data.CurrentSample].Count);
                            double quan = Quantile.StudQuan(1 - alfa / 2, Data.DataForWork[Data.CurrentSample].Count);
                            double result = 0;
                            switch (parametes)
                            {
                                case "σ":
                                    {
                                        result = (NewValue - sigma) / dispsigma;
                                        break;

                                    }
                                case "μ":
                                    {
                                        result = (NewValue - Mu) / dispmu;
                                        break;

                                    }
                            }
                            textBox3.Text += "Значення статистики  t = " + Math.Round(result, Data.NumberOfNum) + Environment.NewLine;
                            if (checkBox1.Checked)
                            {
                                LogOutputTextBox.Text += "Значення статистики  t = " + Math.Round(result, Data.NumberOfNum) + Environment.NewLine;
                            }
                            if (Math.Abs(result) <= quan)
                            {
                                textBox3.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є вірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є вірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                            else
                            {
                                textBox3.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є невірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є невірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                        }
                        break;
                    }
                case "Лапласа":
                    {
                        ArgStr parametes = new ArgStr("μ", "p", "Параметр", "Задайте параметр, який буде перевірено", "<color>", ParamsLaplas.parameters);
                        ArgFloat alfa = new ArgFloat(0.05, "", "Рівень значущості", "Ймовірність помилки першого роду", "<Size>");
                        ArgFloat NewValue = new ArgFloat(0, "", "Значення параметру", "Введіть значення цього параметру для порівняння зі змодельованим", "<Size>");
                        OkCancelDlg it = new OkCancelDlg("Виберіть параметр для перевірки t-тестом", null, parametes, NewValue, alfa);
                        DialogResult rc = it.ShowDialog();
                        if (rc == DialogResult.OK)
                        {
                            if ((alfa <= 0) || (alfa >= 1))
                            {
                                textBox3.Text += "Хибне значення α" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "Хибне значення α" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                                return;
                            }
                            double Mu = Data.EvalData.ExpValues;
                            double lambda = Math.Sqrt(2) / (1.32 * Data.EvalData.StandDevZ);//(0.344*σ^2)/N
                            double dispmu = 2.0 / (Data.DataForWork[Data.CurrentSample].Count * lambda * lambda);
                            double displambda = (5 * lambda * lambda) / (Data.DataForWork[Data.CurrentSample].Count);
                            double cov = (-3d) / (2 * Data.DataForWork[Data.CurrentSample].Count);
                            double quan = Quantile.StudQuan(1 - alfa / 2, Data.DataForWork[Data.CurrentSample].Count);
                            double result = 0;
                            switch (parametes)
                            {
                                case "λ":
                                    {
                                        result = (NewValue - lambda) / displambda;
                                        break;

                                    }
                                case "μ":
                                    {
                                        result = (NewValue - Mu) / dispmu;
                                        break;

                                    }
                            }
                            textBox3.Text += "Значення статистики  t = " + Math.Round(result, Data.NumberOfNum) + Environment.NewLine;
                            if (checkBox1.Checked)
                            {
                                LogOutputTextBox.Text += "Значення статистики  t = " + Math.Round(result, Data.NumberOfNum) + Environment.NewLine;
                            }
                            if (Math.Abs(result) <= quan)
                            {
                                textBox3.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є вірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є вірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                            else
                            {
                                textBox3.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є невірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                if (checkBox1.Checked)
                                {
                                    LogOutputTextBox.Text += "При рівні значущості α =" + Math.Round((double)alfa, Data.NumberOfNum) + ", який відповідає квантилю розподілу Стьюдента " + Math.Round(quan, Data.NumberOfNum) + ", гіпотеза про рівність параметру та його оцінки є невірною" + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                                }
                            }
                        }
                        break;
                    }
            }
        }

        private void відкритиповекторноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpeningDialog = new OpenFileDialog();

            OpeningDialog.InitialDirectory = Application.StartupPath.ToString();
            OpeningDialog.Filter = "txt files (*.txt)|*.txt| dat files (*.dat)|*.dat";
            OpeningDialog.FilterIndex = 1;
            OpeningDialog.RestoreDirectory = true;

            if (OpeningDialog.ShowDialog() == DialogResult.OK)
            {
                //this.ProgressBar.Step = 100;
                //this.ProgressBar.PerformStep();
                //this.ProgressBar.Value = 50;
                Data.CurrentSample.set(Data.DataForWork.Count);
                for (int i = 0; i < 50; i++)
                {
                    Data.DataForWork.Add(new List<double>());
                }
                try
                {
                    string[] FileLikeStrings = File.ReadAllLines(OpeningDialog.FileName);
                    char[] separators = new char[] { ' ', '\t', '\n' };
                    for (int i = 0; i < FileLikeStrings.Length; i++)
                    {
                        ToolsForWork.RemoveComments(ref FileLikeStrings[i]);
                        string[] valuesInLine = FileLikeStrings[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                        for (int j = 0; j < valuesInLine.Length; j++)
                        {
                            double x;
                            try
                            {
                                x = Convert.ToDouble(valuesInLine[j]);
                            }
                            catch
                            {
                                try
                                {
                                    valuesInLine[j] = valuesInLine[j].Replace(".", ",");
                                    x = Convert.ToDouble(valuesInLine[j]);
                                }
                                catch
                                {
                                    if (LogCheckBox.Checked == true)
                                        LogOutputTextBox.Text += "Theres mistake in string #" + i + Environment.NewLine;
                                    continue;
                                }
                            }
                            Data.DataForWork[Data.CurrentSample+j].Add(x);
                        }
                    }
                    for (; Data.CurrentSample < Data.DataForWork.Count; Data.CurrentSample.set(Data.CurrentSample + 1))
                    {
                        Data.NamesOfFiles.Add(OpeningDialog.FileName);
                        Data.StepBack.Add(new List<ToolsForWork.Changing>());
                        //Data.DataForWork[Data.CurrentSample].Sort();
                    }
                    for (Data.CurrentSample.set(Data.DataForWork.Count - 1); Data.CurrentSample > 0 && (Data.DataForWork.Count != 0); Data.CurrentSample.set(Data.CurrentSample - 1))
                    {
                        if (Data.DataForWork[Data.CurrentSample].Count == 0)
                        {
                           // LogOutputTextBox.Text += "File is empty" + Environment.NewLine;
                            Data.DataForWork.RemoveAt(Data.CurrentSample);
                            Data.StepBack.RemoveAt(Data.CurrentSample);
                            Data.NamesOfFiles.RemoveAt(Data.CurrentSample);
                        }
                    }
                    //Data.DataForWork[Data.CurrentSample].Sort();
                    //Data.NamesOfFiles.Add(OpeningDialog.FileName);
                    Data.StepBack.Add(new List<ToolsForWork.Changing>());
                    StatusLabelNameOfFile.Text = Data.NamesOfFiles[Data.CurrentSample];
                    HistData.NumberOfClassesChangedByUser = false;
                    DistrFuncData.NumberOfClassesChangedByUser = false;
                    Data.DistrCreated = false;
                    if (Data.DataForWork.Count != 0)
                    {
                        Data.CurrentSample.set(0);
                        Build();
                    }
                }
                catch (Exception ExThatOccured)
                {
                    LogOutputTextBox.Text += ("Error happened while reading the file. Original error: " + ExThatOccured.Message + Environment.NewLine);
                }
            }
            //this.ProgressBar.Value = 1;

        }

        private void порівнятиВибіркиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArgStr depen = new ArgStr("Залежні", "p", "Залежність вибірок", "Чи є вибірки залежними?", "<color>", PossibleDepen.depen);
            ArgInt Number = new ArgInt(2, "", "Кількість вибірок", "Кількість вибірок для порівняння", "<Size>");
            ArgFloat Alfa = new ArgFloat(0.05, "", "Критичне значення", "Критичне значення", "<Size>");
            OkCancelDlg it = new OkCancelDlg("Перевірка вибірок на однорідність", null, depen, Number, Alfa);
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                if ((Number <= 1) || (Number > Data.DataForWork.Count))
                {
                    LogOutputTextBox.Text += "Безсенсно" + Environment.NewLine;
                    return;
                }
                if ((Alfa <= 0) || (Alfa >= 1))
                {
                    LogOutputTextBox.Text += "Безсенсно" + Environment.NewLine;
                    return;
                }
                if (depen == "Залежні")
                {
                    if (Number == 2)
                    {
                        CritDepenTwo(Alfa);
                    }
                    else
                    {
                        CritDepenK(Number, Alfa);
                    }
                }
                else
                {
                    if (Number == 2)
                    {
                        CritIndepenTwo(Alfa);
                    }
                    else
                    {
                        CritIndepenK(Number, Alfa);
                    }
                }
                return;
            }
        }

        private void відкритиДвовиміруВибіркуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpeningDialog = new OpenFileDialog();
            bool Mistaken = false;
            OpeningDialog.InitialDirectory = Application.StartupPath.ToString();
            OpeningDialog.Filter = "txt files (*.txt)|*.txt| dat files (*.dat)|*.dat";
            OpeningDialog.FilterIndex = 1;
            OpeningDialog.RestoreDirectory = true;

            if (OpeningDialog.ShowDialog() == DialogResult.OK)
            {
                ///////
                //this.ProgressBar.Step = 100;
                //this.ProgressBar.PerformStep();
                //this.ProgressBar.Value = 50;
                Data.TwoDemCurrentSample.set(Data.TwoDemSamples.Count);
                Data.CurrentSample.set(Data.DataForWork.Count);
                try
                {
                    string[] FileLikeStrings = File.ReadAllLines(OpeningDialog.FileName);
                    char[] separators = new char[] { ' ', '\t', '\n' };
                    string[] valuesInLine;
                    if (ToolsForWork.FindMinLength(FileLikeStrings) <= 1)
                    {
                        LogOutputTextBox.Text += "Theres not enough columns on your file" + Environment.NewLine;
                        return;
                    }
                    for (int i = 0; i < 2; i++)
                    {
                        Data.DataForWork.Add(new List<double>());
                    }
                    int j;
                    for (int i = 0; i < FileLikeStrings.Length; i++)
                    {
                        ToolsForWork.RemoveComments(ref FileLikeStrings[i]);
                        valuesInLine = FileLikeStrings[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                        Mistaken = false;
                        for (j = 0; j < 2; j++)
                        {
                            double x;
                            try
                            {
                                x = Convert.ToDouble(valuesInLine[j]);
                            }
                            catch
                            {
                                try
                                {
                                    valuesInLine[j] = valuesInLine[j].Replace(".", ",");
                                    x = Convert.ToDouble(valuesInLine[j]);
                                }
                                catch
                                {
                                    if (LogCheckBox.Checked == true)
                                        LogOutputTextBox.Text += "Theres mistake in string #" + i + Environment.NewLine;
                                    Mistaken = true;
                                    continue;
                                }
                            }
                            Data.DataForWork[Data.CurrentSample + j].Add(x);
                        }
                        if (Mistaken)
                        {
                            j--;
                            for (int k = 0; k < j; k++)
                            {
                                Data.DataForWork[Data.CurrentSample + k].RemoveAt(Data.DataForWork[Data.CurrentSample + k].Count-1);
                            }
                        }
                    }
                    for (; Data.CurrentSample < Data.DataForWork.Count; Data.CurrentSample.set(Data.CurrentSample + 1))
                    {
                        Data.NamesOfFiles.Add(OpeningDialog.FileName + ", demention number " + Math.Abs(Data.DataForWork.Count - Data.CurrentSample - 1));
                        Data.StepBack.Add(new List<ToolsForWork.Changing>());
                        //Data.DataForWork[Data.CurrentSample].Sort();
                    }
                    for (Data.CurrentSample.set(Data.DataForWork.Count - 1); Data.CurrentSample > 0 && (Data.DataForWork.Count != 0); Data.CurrentSample.set(Data.CurrentSample - 1))
                    {
                        if (Data.DataForWork[Data.CurrentSample].Count == 0)
                        {
                            // LogOutputTextBox.Text += "File is empty" + Environment.NewLine;
                            //Data.DataForWork.RemoveAt(Data.CurrentSample);
                            //Data.StepBacTwoDemCurrentSample.RemoveAt(Data.CurrentSample);
                            //Data.NamesOfFiles.RemoveAt(Data.CurrentSample);
                        }
                    }
                    //this thing is needed but later
                    //Data.DataForWork[Data.CurrentSample].Sort();
                    //Data.NamesOfFiles.Add(OpeningDialog.FileName);
                    Data.TwoDemStepBack.Add(new List<ToolsForWork.Changing>());
                    StatusLabelNameOfFile.Text = Data.NamesOfFiles[Data.CurrentSample];
                    HistData.NumberOfClassesChangedByUser = false;
                    DistrFuncData.NumberOfClassesChangedByUser = false;
                    Data.DistrCreated = false;
                    Data.TwoDemDistrCreated = false;
                    Data.TwoDemNamesOfFiles.Add(OpeningDialog.FileName);
                    if (Data.DataForWork.Count != 0)
                    {
                        Data.TwoDemSamples.Add(new int[] { Data.DataForWork.Count - 2, Data.DataForWork.Count - 1 });
                        Data.CurrentSample.set(0);
                        Data.TwoDemCurrentSample.set(Data.TwoDemSamples.Count-1);
                        Build();
                        BuildTwoDem();
                    }
                }
                catch (Exception ExThatOccured)
                {
                    LogOutputTextBox.Text += ("Error happened while reading the file. Original error: " + ExThatOccured.Message + Environment.NewLine);
                    LogOutputTextBox.Text += "Maybe, youve tried to open not two dementional file" + Environment.NewLine;
                }
            }
            ////////////
            //this.ProgressBar.Value = 1;
        }

        private void двовимірнийНормальнийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArgIntMM NumberOfElements = new ArgIntMM(100, "", "Кількість елементів", "Кількість елементів", "<>");
            ArgFloatMM SigmaX = new ArgFloatMM(1, "", "Параметр σx", "Параметр σx", "<>");
            ArgFloatMM ExpValX = new ArgFloatMM(0, "", "Мат. сподівання x", "Мат. сподівання x", "<>");
            ArgFloatMM SigmaY = new ArgFloatMM(1, "", "Параметр σy", "Параметр σy", "<>");
            ArgFloatMM ExpValY = new ArgFloatMM(0, "", "Мат. сподівання y", "Мат. сподівання y", "<>");
            ArgFloatMM KK = new ArgFloatMM(0, "", "Коефіціент кореляції", "Коефіціент кореляції", "<>");
            NumberOfElements.setMin(1);
            OkCancelDlg it = new OkCancelDlg("Сторення двовимірного нормального розподілу", null
                                , NumberOfElements
                                , ExpValX
                                , ExpValY
                                , SigmaX
                                , SigmaY
                                , KK
                                );
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                if (SigmaX <= 0 || SigmaY <= 0)
                {
                    LogOutputTextBox.Text += "Невірне значення σ " + Environment.NewLine;
                    return;
                }
                if (KK < -1 || KK > 1)
                {
                    LogOutputTextBox.Text += "Невірне значення r " + Environment.NewLine;
                    return;
                }
                Data.DataForWork.Add(new List<double>());
                Data.DataForWork.Add(new List<double>());
                Data.CurrentSample.set(Data.DataForWork.Count - 2);
                Random a = new Random();
                Random b = new Random();
                Random c = new Random();
                double result1, result2, x, y, s;
                for (int i = 0; i < (int)NumberOfElements; i++)
                {
                    x = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
                    y = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
                    s = x * x + y * y;
                    if ((s == 0) || (s > 1))
                    {
                        i--;
                        continue;
                    }
                    result1 = y * Math.Pow(((-2 * Math.Log(s)) / s), 0.5);
                    x = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
                    y = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
                    s = x * x + y * y;
                    if ((s == 0) || (s > 1))
                    {
                        i--;
                        continue;
                    }
                    result2 = y * Math.Pow(((-2 * Math.Log(s)) / s), 0.5);
                    Data.DataForWork[Data.CurrentSample].Add(((float)ExpValX + result1 * (float)SigmaX));
                    Data.DataForWork[Data.CurrentSample + 1].Add(((float)ExpValY + (result2 * Math.Sqrt(1 - KK * KK) + result1 * KK) * (float)SigmaY));

                }
                //Data.DataForWork[Data.CurrentSample].Sort();
                Data.NamesOfFiles.Add("Автоматично сгенерований двовимірний нормальний розподіл, " + (int)NumberOfElements + " елементів, σx = " + (float)SigmaX + ", μx = " + (float)ExpValX + "1 вимір");
                Data.NamesOfFiles.Add("Автоматично сгенерований двовимірний нормальний розподіл, " + (int)NumberOfElements + " елементів, σy = " + (float)SigmaY + ", μy = " + (float)ExpValY + "2 вимір");
                Data.StepBack.Add(new List<ToolsForWork.Changing>());
                Data.StepBack.Add(new List<ToolsForWork.Changing>());
                StatusLabelNameOfFile.Text = Data.NamesOfFiles[Data.CurrentSample];
                Data.DistrCreated = false;
                Build();
                Data.TwoDemStepBack.Add(new List<ToolsForWork.Changing>());
                Data.TwoDemSamples.Add(new int[] { Data.DataForWork.Count - 2, Data.DataForWork.Count - 1 });
                Data.TwoDemCurrentSample.set(Data.TwoDemSamples.Count - 1);
                BuildTwoDem();
            }
        }

        private void двовимірнуВибіркуПоРегресииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArgIntMM NumberOfElements = new ArgIntMM(100, "", "Кількість елементів", "Кількість елементів", "<>");
            ArgFloatMM SigmaX = new ArgFloatMM(1, "", "Параметр σx", "Параметр σx", "<>");
            ArgFloatMM ExpValX = new ArgFloatMM(0, "", "Мат. сподівання x", "Мат. сподівання x", "<>");
            ArgFloatMM SigmaY = new ArgFloatMM(1, "", "Параметр σy", "Параметр σy", "<>");
            ArgStr Regres = new ArgStr("x", "p", "формула регресии", "введіть тут формулу залежності у від х. Частину \"у=\" вводити не потрібно", "<color>");
            NumberOfElements.setMin(1);
            OkCancelDlg it = new OkCancelDlg("Створення вибірки по регресії", null
                                , NumberOfElements
                                , ExpValX
                                , SigmaX
                                , SigmaY
                                , Regres
                                );
            DialogResult rc = it.ShowDialog();
            double temp;
            string function;
            if (rc == DialogResult.OK)
            {
                if (SigmaX <= 0 || SigmaY <= 0)
                {
                    LogOutputTextBox.Text += "Невірне значення σ " + Environment.NewLine;
                    return;
                }
                Parser pars = new Parser();
                function = (string)Regres;
                try
                {
                    pars.AddVariable("e", Math.E);
                    pars.AddVariable("pi", Math.PI);
                    pars.AddVariable("x", 0);
                    pars.SimplifyDouble(function);
                    pars.RemoveVariable("x");
                }
                catch 
                {
                    LogOutputTextBox.Text += "Ваша формула хибна " + Environment.NewLine;
                    return;
                }
                Data.DataForWork.Add(new List<double>());
                Data.DataForWork.Add(new List<double>());
                Data.CurrentSample.set(Data.DataForWork.Count - 2);
                Random a = new Random();
                Random b = new Random();
                Random c = new Random();
                double result1, result2, x, y, s;
                for (int i = 0; i < (int)NumberOfElements; i++)
                {
                    x = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
                    y = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
                    s = x * x + y * y;
                    if ((s == 0) || (s > 1))
                    {
                        i--;
                        continue;
                    }
                    result1 = y * Math.Pow(((-2 * Math.Log(s)) / s), 0.5);
                    x = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
                    y = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
                    s = x * x + y * y;
                    if ((s == 0) || (s > 1))
                    {
                        i--;
                        continue;
                    }
                    result2 = y * Math.Pow(((-2 * Math.Log(s)) / s), 0.5);
                    Data.DataForWork[Data.CurrentSample].Add(((float)ExpValX + result1 * (float)SigmaX));
                    pars.AddVariable("x", Data.DataForWork[Data.CurrentSample][i]);
                    temp = pars.SimplifyDouble(function);
                    Data.DataForWork[Data.CurrentSample + 1].Add((temp + result2 * (float)SigmaX));
                    pars.RemoveVariable("x");

                }
                //Data.DataForWork[Data.CurrentSample].Sort();
                Data.NamesOfFiles.Add("Автоматично сгенерований двовимірний нормальний розподіл, " + (int)NumberOfElements + " елементів, σx = " + (float)SigmaX + ", μx = " + (float)ExpValX + ", 1 вимір");
                Data.NamesOfFiles.Add("Автоматично сгенерований двовимірний нормальний розподіл, " + (int)NumberOfElements + " елементів, σe = " + (float)SigmaY + ", формула регрессії - у=" + Regres + " , 2 вимір");
                Data.StepBack.Add(new List<ToolsForWork.Changing>());
                Data.StepBack.Add(new List<ToolsForWork.Changing>());
                StatusLabelNameOfFile.Text = Data.NamesOfFiles[Data.CurrentSample];
                Data.DistrCreated = false;
                Build();
                Data.TwoDemStepBack.Add(new List<ToolsForWork.Changing>());
                Data.TwoDemSamples.Add(new int[] { Data.DataForWork.Count - 2, Data.DataForWork.Count - 1 });
                Data.TwoDemCurrentSample.set(Data.TwoDemSamples.Count - 1);
                BuildTwoDem();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Data.CurrentSample < 0 || Data.CurrentSample >= Data.DataForWork.Count || Data.DataForWork[Data.CurrentSample].Count == 0)
            {
                LogOutputTextBox.Text += "Theres nothing to do" + Environment.NewLine;
                return;
            }
            int i, j, k;
            List<double> Temp1 = new List<double>(), Temp2 = new List<double>();
            for (i = 0; i < Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].Count; i++)
            {
                Temp1.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]][i]);
                Temp2.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][1]][i]);
            }
            double Xexp, Yexp, StX, StY, KK, Kvx, Kvy,Ts,Tk;
            {
                double Sum1 = 0;
                double Sum2 = 0;
                for (i = 0; i < Temp1.Count; i++)
                {
                    Sum1 += Temp1[i];
                    Sum2 += Temp2[i];
                }
                Xexp = Sum1 / Temp1.Count;
                Yexp = Sum2 / Temp1.Count;
                dataGridView1.Rows[0].Cells[2].Value = "" + Math.Round(Xexp, Data.NumberOfNum);
                dataGridView1.Rows[1].Cells[2].Value = "" + Math.Round(Yexp, Data.NumberOfNum);
                if (Math.Abs(Data.EvalData.ExpValues) < 0.00000000001)
                {
                    Data.EvalData.ExpValues = 0;
                }
            }
            {
                {
                    StX = 0; StY = 0;
                    for (i = 0; i < Temp1.Count; i++)
                    {
                        // Data.EvalData.StandDevZ += Data.DataForWork[Data.CurrentSample][i] * Data.DataForWork[Data.CurrentSample][i] - Data.EvalData.ExpValues * Data.EvalData.ExpValues;
                        StX += Math.Pow((Temp1[i] - Xexp), 2);
                        StY += Math.Pow((Temp2[i] - Yexp), 2);
                    }
                    // Data.EvalData.StandDevZ *= (1.0) / Data.DataForWork[Data.CurrentSample].Count;
                    StX *= (1.0) / (Temp1.Count - 1);
                    StY *= (1.0) / (Temp2.Count - 1);
                    //Data.EvalData.StandDevZ = (Math.Sqrt(Data.EvalData.StandDevZ));
                    StX = (Math.Sqrt(StX));
                    StY = (Math.Sqrt(StY));
                    dataGridView1.Rows[2].Cells[2].Value = "" + Math.Round(StX, Data.NumberOfNum);
                    dataGridView1.Rows[3].Cells[2].Value = "" + Math.Round(StY, Data.NumberOfNum);
                }
            }
            {
                double CrosSum = 0;
                for (i = 0; i < Temp1.Count; i++)
                {
                    CrosSum += Temp1[i] * Temp2[i];
                }
                CrosSum /= Temp1.Count;
                KK = ((double)Temp1.Count / (Temp1.Count - 1)) * ((CrosSum - Xexp * Yexp) / (StX * StY));
                dataGridView1.Rows[5].Cells[2].Value = "" + Math.Round(KK, Data.NumberOfNum);
            }
            do
            {
                if (Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].Count == 1)
                {
                    dataGridView1.Rows[0].Cells[1].Value = "Не обраховувалося";
                    dataGridView1.Rows[0].Cells[3].Value = "Не обраховувалося";
                    dataGridView1.Rows[1].Cells[1].Value = "Не обраховувалося";
                    dataGridView1.Rows[1].Cells[3].Value = "Не обраховувалося";
                    break;
                }
                double alfa1 = 0.1;
                double gamma1 = 0.9;
                double alfa2 = 0.1;
                double gamma2 = 0.9;
                try
                {
                    gamma1 = Convert.ToDouble(dataGridView1.Rows[0].Cells[4].Value);
                    alfa1 = 1 - gamma1;
                }
                catch (Exception)
                {
                    dataGridView1.Rows[0].Cells[4].Value = "0,9";
                    alfa1 = 0.1;
                }
                try
                {
                    gamma2 = Convert.ToDouble(dataGridView1.Rows[1].Cells[4].Value);
                    alfa2 = 1 - gamma2;
                }
                catch (Exception)
                {
                    dataGridView1.Rows[1].Cells[4].Value = "0,9";
                    alfa2 = 0.1;
                }
                if ((alfa1 <= 0) || (alfa1 >= 1))
                {
                    if (LogCheckBox.Checked)
                        LogOutputTextBox.Text += "Хибне значення γ для математичного сподівання " + Environment.NewLine;
                    DataGridForEval.Rows[0].Cells[4].Value = "0,9";
                    alfa1 = 0.1;
                }
                if ((alfa2 <= 0) || (alfa2 >= 1))
                {
                    if (LogCheckBox.Checked)
                        LogOutputTextBox.Text += "Хибне значення γ для математичного сподівання " + Environment.NewLine;
                    DataGridForEval.Rows[1].Cells[4].Value = "0,9";
                    alfa1 = 0.1;
                }
                double XExpSt = StX / Math.Sqrt(Temp1.Count);
                double YExpSt = StX / Math.Sqrt(Temp1.Count);
                dataGridView1.Rows[0].Cells[1].Value = Math.Round(Xexp - XExpSt * Quantile.StudQuan(1 - alfa1 / 2, Temp1.Count - 1), Data.NumberOfNum);
                dataGridView1.Rows[0].Cells[3].Value = Math.Round(Xexp + XExpSt * Quantile.StudQuan(1 - alfa1 / 2, Temp1.Count - 1), Data.NumberOfNum);
                dataGridView1.Rows[1].Cells[1].Value = Math.Round(Yexp - YExpSt * Quantile.StudQuan(1 - alfa2 / 2, Temp1.Count - 1), Data.NumberOfNum);
                dataGridView1.Rows[1].Cells[3].Value = Math.Round(Yexp + YExpSt * Quantile.StudQuan(1 - alfa2 / 2, Temp1.Count - 1), Data.NumberOfNum);
            } while (false);
            do
            {
                if (Data.DataForWork[Data.CurrentSample].Count == 1)
                {
                    dataGridView1.Rows[2].Cells[1].Value = "Не обраховувалося";
                    dataGridView1.Rows[2].Cells[3].Value = "Не обраховувалося";
                    dataGridView1.Rows[3].Cells[1].Value = "Не обраховувалося";
                    dataGridView1.Rows[3].Cells[3].Value = "Не обраховувалося";
                    break;
                }
                double alfa1 = 0.1;
                double gamma1 = 0.9;
                double alfa2 = 0.1;
                double gamma2 = 0.9;
                try
                {
                    gamma1 = Convert.ToDouble(dataGridView1.Rows[2].Cells[4].Value);
                    alfa1 = 1 - gamma1;
                }
                catch (Exception)
                {
                    dataGridView1.Rows[2].Cells[4].Value = "0,9";
                    alfa1 = 0.1;
                }
                try
                {
                    gamma2 = Convert.ToDouble(dataGridView1.Rows[3].Cells[4].Value);
                    alfa2 = 1 - gamma2;
                }
                catch (Exception)
                {
                    dataGridView1.Rows[3].Cells[4].Value = "0,9";
                    alfa2 = 0.1;
                }
                if ((alfa1 <= 0) || (alfa1 >= 1))
                {
                    if (LogCheckBox.Checked)
                        LogOutputTextBox.Text += "Хибне значення γ для стандартного відхилення" + Environment.NewLine;
                    DataGridForEval.Rows[2].Cells[4].Value = "0,9";
                    alfa1 = 0.1;
                }
                if ((alfa2 <= 0) || (alfa2 >= 1))
                {
                    if (LogCheckBox.Checked)
                        LogOutputTextBox.Text += "Хибне значення γ для стандартного відхилення" + Environment.NewLine;
                    DataGridForEval.Rows[2].Cells[4].Value = "0,9";
                    alfa2 = 0.1;
                }
                double XDevDev = StX / Math.Sqrt(2 * Temp1.Count);
                double YDevDev = StY / Math.Sqrt(2 * Temp1.Count);
                dataGridView1.Rows[2].Cells[1].Value = Math.Round(StX - XDevDev * Quantile.StudQuan(1 - alfa1 / 2, Temp1.Count - 1), Data.NumberOfNum);
                dataGridView1.Rows[2].Cells[3].Value = Math.Round(StX + XDevDev * Quantile.StudQuan(1 - alfa1 / 2, Temp1.Count - 1), Data.NumberOfNum);
                dataGridView1.Rows[3].Cells[1].Value = Math.Round(StY - YDevDev * Quantile.StudQuan(1 - alfa2 / 2, Temp1.Count - 1), Data.NumberOfNum);
                dataGridView1.Rows[3].Cells[3].Value = Math.Round(StY + YDevDev * Quantile.StudQuan(1 - alfa2 / 2, Temp1.Count - 1), Data.NumberOfNum);
                dataGridView1.Rows[2].Cells[5].Value = Math.Round(StX * StX, Data.NumberOfNum);
                dataGridView1.Rows[3].Cells[5].Value = Math.Round(StY * StY, Data.NumberOfNum);
            }
            while (false);
            int CountX = ToolsForWork.CompNumOfClasses(Temp1.Count), CountY = ToolsForWork.CompNumOfClasses(Temp2.Count);
            double MaxX = double.MinValue, MaxY = double.MinValue, MinX = double.MaxValue, MinY = double.MaxValue;
            for (i = 0; i < Temp1.Count; i++)
            {
                if (Temp1[i] < MinX)
                {
                    MinX = Temp1[i];
                }
                if (Temp2[i] < MinY)
                {
                    MinY = Temp2[i];
                }
                if (Temp1[i] > MaxX)
                {
                    MaxX = Temp1[i];
                }
                if (Temp2[i] > MaxY)
                {
                    MaxY = Temp2[i];
                }
            }
            int[,] Ns = new int[CountX, CountY];
            double[,] Ps = new double[CountX, CountY];
            for (i = 0; i < CountX; i++)
            {
                for (j = 0; j < CountY; j++)
                {
                    Ns[i, j] = 0;
                    for (k = 0; k < Temp1.Count; k++)
                    {
                        if ((Temp1[k] >= MinX + i * ((MaxX - MinX) / CountX)) && (Temp1[k] < MinX + (i + 1) * ((MaxX - MinX) / CountX)) && (Temp2[k] >= MinY + (j) * ((MaxY - MinY) / CountY)) && (Temp2[k] < MinY + (j + 1) * ((MaxY - MinY) / CountY)))
                        {
                            Ns[i, j]++;
                        }
                    }
                    Ps[i, j] = ((double)Ns[i, j]) / Temp1.Count;
                    //  Hist[i, j].Left = (int)chart2.ChartAreas[0].InnerPlotPosition.X + (int)(i * ((chart2.ChartAreas[0].InnerPlotPosition.Width) / CountX));
                    //Hist[i, j].Top = (int)chart2.ChartAreas[0].InnerPlotPosition.Y + (int)(j * ((chart2.ChartAreas[0].InnerPlotPosition.Height) / CountY));
                }
            }
            ////
            {
                double sum, temp;
                sum = 0;
                for (i = 0; i < CountX; i++)
                {
                    for (j = 0; j < CountY; j++)
                    {
                        temp = (1.0 / (2 * Math.PI * StX * StY * Math.Sqrt(1 - KK * KK))) * Math.Exp(((-1.0) / (2 * (1 - KK * KK))) * (Math.Pow((MinX + (i + 0.5) * ((MaxX - MinX) / CountX) - Xexp) / (StX), 2) - (2 * KK * ((MinX + (i + 0.5) * ((MaxX - MinX) / CountX) - Xexp) / (StX)) * ((MinY + (j + 0.5) * ((MaxY - MinY) / CountY) - Yexp) / (StY))) + Math.Pow((MinY + (j + 0.5) * ((MaxY - MinY) / CountY) - Yexp) / (StY), 2)));
                        temp *= ((MaxX - MinX) / CountX) * ((MaxY - MinY) / CountY);
                        if (temp != 0)
                        {
                            sum += Math.Pow(Ps[i, j] - temp, 2) / temp;
                        }
                    }
                }
                dataGridView1.Rows[4].Cells[5].Value = Math.Round(sum, Data.NumberOfNum);
                double alfa1 = 0.1;
                double gamma1 = 0.9;
                try
                {
                    gamma1 = Convert.ToDouble(dataGridView1.Rows[4].Cells[4].EditedFormattedValue);
                    alfa1 = 1 - gamma1;
                }
                catch (Exception)
                {
                    dataGridView1.Rows[4].Cells[4].Value = "0,9";
                    alfa1 = 0.1;
                }
                if ((alfa1 <= 0) || (alfa1 >= 1))
                {
                    if (LogCheckBox.Checked)
                        LogOutputTextBox.Text += "Хибне значення γ для критерія Пірсона" + Environment.NewLine;
                    dataGridView1.Rows[4].Cells[4].Value = "0,9";
                    alfa1 = 0.1;
                }
                double quant = Quantile.HirsQuan(1 - alfa1, CountX * CountY - 2);
                if (sum <= Quantile.HirsQuan(1 - alfa1, CountX * CountY - 2))
                {
                    dataGridView1.Rows[4].Cells[2].Value = "Збіг";
                }
                else
                {
                    dataGridView1.Rows[4].Cells[2].Value = "Збіг відсутній";
                    LogOutputTextBox.Text += "Увага! Через хибність гіпотези про нормальність розподілу більшість обрахованих коефіціентів можуть бути незначущими!" + Environment.NewLine;
                }
            }
            do
            {
                int Count1 = 1;
                int Count2 = 1;
                try
                {
                    Count1 = Convert.ToInt32(dataGridView1.Rows[6].Cells[4].EditedFormattedValue);
                }
                catch (Exception)
                {
                    dataGridView1.Rows[6].Cells[4].Value = ToolsForWork.CompNumOfClasses(Temp2.Count);
                    Count1 = ToolsForWork.CompNumOfClasses(Temp2.Count);
                }
                try
                {
                    Count2 = Convert.ToInt32(dataGridView1.Rows[7].Cells[4].EditedFormattedValue);
                }
                catch (Exception)
                {
                    dataGridView1.Rows[7].Cells[4].Value = ToolsForWork.CompNumOfClasses(Temp2.Count);
                    Count2 = ToolsForWork.CompNumOfClasses(Temp2.Count);
                }
                if ((Count2 <= 1) || (Count2 >= 50))
                {
                    if (LogCheckBox.Checked)
                        LogOutputTextBox.Text += "Хибна кількість розбиттів для кореляційного відношення" + Environment.NewLine;
                    dataGridView1.Rows[7].Cells[4].Value = ToolsForWork.CompNumOfClasses(Temp2.Count);
                    Count2 = ToolsForWork.CompNumOfClasses(Temp2.Count);
                }
                if ((Count1 <= 1) || (Count1 >= 50))
                {
                    if (LogCheckBox.Checked)
                        LogOutputTextBox.Text += "Хибна кількість розбиттів для кореляційного відношення" + Environment.NewLine;
                    dataGridView1.Rows[6].Cells[4].Value = ToolsForWork.CompNumOfClasses(Temp2.Count);
                    Count1 = ToolsForWork.CompNumOfClasses(Temp2.Count);
                }
                if ((Count2 <= 1))
                {
                    Count2 += 2;
                }
                if ((Count1 <= 1))
                {
                    Count1 += 2;
                }
                double sum = 0;
                List<List<double>> Tx = new List<List<double>>(), Ty = new List<List<double>>();
                List<double> expxs = new List<double>(), expys = new List<double>();
                for (i = 0; i < Count1; i++)
                {
                    Tx.Add(new List<double>());
                    sum = 0;
                    for (j = 0; j < Temp1.Count; j++)
                    {
                        if ((Temp1[j] >= MinX + i * ((MaxX - MinX) / Count1)) && (Temp1[j] < MinX + (i + 1) * ((MaxX - MinX) / Count1)))
                        {
                            Tx[i].Add(Temp2[j]);
                            sum += Temp2[j];
                        }
                    }
                    if (i == Count1 - 1)
                    {
                        for (j = 0; j < Temp1.Count; j++)
                        {
                            if ((Temp1[j] >= MinX + i * ((MaxX - MinX) / Count1)) && (Temp1[j] <= MinX + (i + 1) * ((MaxX - MinX) / Count1)))
                            {
                                Tx[i].Add(Temp2[j]);
                                sum += Temp2[j];
                            }
                        }
                    }
                    expys.Add(sum / Tx[i].Count);
                }
                double temp1 = 0, temp2 = 0;
                for (i = 0; i < Count1; i++)
                {
                    if (double.IsNaN(expys[i]))
                        continue;
                    temp1 += Tx[i].Count * Math.Pow(Yexp - expys[i], 2);
                    for (j = 0; j < Tx[i].Count; j++)
                    {
                        temp2 += Math.Pow(Yexp - Tx[i][j], 2);
                    }
                }
                Kvx = Math.Sqrt(temp1 / temp2);
                dataGridView1.Rows[6].Cells[2].Value = "" + Math.Round(Kvx, Data.NumberOfNum);

                //////
                for (i = 0; i < Count2; i++)
                {
                    Ty.Add(new List<double>());
                    sum = 0;
                    for (j = 0; j < Temp1.Count; j++)
                    {
                        if ((Temp2[j] >= MinY + i * ((MaxY - MinY) / Count2)) && (Temp2[j] < MinY + (i + 1) * ((MaxY - MinY) / Count2)))
                        {
                            Ty[i].Add(Temp1[j]);
                            sum += Temp1[j];
                        }
                    }
                    if (i == Count2 - 1)
                    {
                        for (j = 0; j < Temp1.Count; j++)
                        {
                            if ((Temp2[j] >= MinY + i * ((MaxY - MinY) / Count2)) && (Temp2[j] <= MinY + (i + 1) * ((MaxY - MinY) / Count2)))
                            {
                                Ty[i].Add(Temp1[j]);
                                sum += Temp1[j];
                            }
                        }
                    }
                    expxs.Add(sum / Ty[i].Count);
                }
                temp1 = 0; temp2 = 0;
                for (i = 0; i < Count2; i++)
                {
                    if (double.IsNaN(expxs[i]))
                        continue;
                    temp1 += Ty[i].Count * Math.Pow(Xexp - expxs[i], 2);
                    for (j = 0; j < Ty[i].Count; j++)
                    {
                        temp2 += Math.Pow(Xexp - Ty[i][j], 2);
                    }
                }
                Kvy = Math.Sqrt(temp1 / temp2);
                dataGridView1.Rows[7].Cells[2].Value = "" + Math.Round(Kvy, Data.NumberOfNum);
            }
            while (false);
            do
            {
                if (Data.DataForWork[Data.CurrentSample].Count == 1)
                {
                    dataGridView1.Rows[2].Cells[1].Value = "Не обраховувалося";
                    dataGridView1.Rows[2].Cells[3].Value = "Не обраховувалося";
                    dataGridView1.Rows[3].Cells[1].Value = "Не обраховувалося";
                    dataGridView1.Rows[3].Cells[3].Value = "Не обраховувалося";
                    break;
                }
                double alfa1 = 0.1;
                double gamma1 = 0.9;
                try
                {
                    gamma1 = Convert.ToDouble(dataGridView1.Rows[5].Cells[4].EditedFormattedValue);
                    alfa1 = 1 - gamma1;
                }
                catch (Exception)
                {
                    dataGridView1.Rows[5].Cells[4].Value = "0,9";
                    alfa1 = 0.1;
                }
                if ((alfa1 <= 0) || (alfa1 >= 1))
                {
                    if (LogCheckBox.Checked)
                        LogOutputTextBox.Text += "Хибне значення γ для стандартного відхилення" + Environment.NewLine;
                    dataGridView1.Rows[5].Cells[4].Value = "0,9";
                    alfa1 = 0.1;
                }
                dataGridView1.Rows[5].Cells[1].Value = Math.Round(KK + ((KK * (1 - KK * KK)) / (2 * Temp1.Count)) - ((1 - KK * KK) / Math.Sqrt(Temp1.Count - 1)) * Quantile.StanQuanOdn(1 - alfa1 / 2), Data.NumberOfNum);
                dataGridView1.Rows[5].Cells[3].Value = Math.Round(KK + ((KK * (1 - KK * KK)) / (2 * Temp1.Count)) + ((1 - KK * KK) / Math.Sqrt(Temp1.Count - 1)) * Quantile.StanQuanOdn(1 - alfa1 / 2), Data.NumberOfNum);
                dataGridView1.Rows[5].Cells[5].Value = Math.Round(StX * StY * KK, Data.NumberOfNum);
            }
            while (false);
            do
            {
                double alfa1 = 0.1;
                double gamma1 = 0.9;
                try
                {
                    gamma1 = Convert.ToDouble(dataGridView1.Rows[8].Cells[4].EditedFormattedValue);
                    alfa1 = 1 - gamma1;
                }
                catch (Exception)
                {
                    dataGridView1.Rows[8].Cells[4].Value = "0,9";
                    alfa1 = 0.1;
                }
                if ((alfa1 <= 0) || (alfa1 >= 1))
                {
                    if (LogCheckBox.Checked)
                        LogOutputTextBox.Text += "Хибне значення γ для стандартного відхилення" + Environment.NewLine;
                    dataGridView1.Rows[8].Cells[4].Value = "0,9";
                    alfa1 = 0.1;
                }
                List<double[]> Rx = new List<double[]>();
                List<double[]> Ry = new List<double[]>();
                int LclC = 0;
                double A = 0, B = 0;
                double[] temp = new double[3];
                for (i = 0; i < Temp1.Count; i++)
                {
                    Rx.Add(new double[] { Temp1[i], i, 0 });
                    Ry.Add(new double[] { Temp2[i], i, 0 });
                }
                for (i = 0; i < Temp1.Count; i++)
                {
                    for (j = 0; j < Temp1.Count - 1 - i; j++)
                    {
                        if (Rx[j][0] > Rx[j + 1][0])
                        {
                            temp[0] = Rx[j][0];
                            temp[1] = Rx[j][1];
                            Rx[j][0] = Rx[j + 1][0];
                            Rx[j][1] = Rx[j + 1][1];
                            Rx[j + 1][0] = temp[0];
                            Rx[j + 1][1] = temp[1];
                        }
                        if (Ry[j][0] > Ry[j + 1][0])
                        {
                            temp[0] = Ry[j][0];
                            temp[1] = Ry[j][1];
                            Ry[j][0] = Ry[j + 1][0];
                            Ry[j][1] = Ry[j + 1][1];
                            Ry[j + 1][0] = temp[0];
                            Ry[j + 1][1] = temp[1];
                        }
                    }
                }
                for (i = 0; i < Temp1.Count; i++)
                {
                    Rx[i][2] = i;
                    Ry[i][2] = i;
                }
                for (i = 0; i < Temp1.Count - 1; i++)
                {
                    LclC++;
                    if (Rx[i][0] == Rx[i + 1][0])
                    {

                    }
                    else
                    {
                        A += Math.Pow(LclC, 3) - LclC;
                        for (j = i - LclC + 1; j <= i; j++)
                        {
                            Rx[j][2] = Rx[i][2] - (LclC - 1.0) / 2;
                        }
                        LclC = 0;
                    }
                }
                A += Math.Pow(LclC, 3) - LclC;
                LclC = 0;
                A *= 1.0 / 12;

                for (i = 0; i < Temp1.Count - 1; i++)
                {
                    LclC++;
                    if (Ry[i][0] == Ry[i + 1][0])
                    {
                    }
                    else
                    {
                        B += Math.Pow(LclC, 3) - LclC;
                        for (j = i - LclC + 1; j <= i; j++)
                        {
                            Ry[j][2] = Ry[i][2] - (LclC - 1.0) / 2;
                        }
                        LclC = 0;
                    }
                }
                B += Math.Pow(LclC, 3) - LclC;
                LclC = 0;
                B *= 1.0 / 12;

                for (i = 0; i < Temp1.Count; i++)
                {
                    for (j = 0; j < Temp1.Count - 1 - i; j++)
                    {
                        if (Rx[j][1] > Rx[j + 1][1])
                        {
                            temp[0] = Rx[j][0];
                            temp[1] = Rx[j][1];
                            temp[2] = Rx[j][2];
                            Rx[j][0] = Rx[j + 1][0];
                            Rx[j][1] = Rx[j + 1][1];
                            Rx[j][2] = Rx[j + 1][2];
                            Rx[j + 1][0] = temp[0];
                            Rx[j + 1][1] = temp[1];
                            Rx[j + 1][2] = temp[2];
                        }
                        if (Ry[j][1] > Ry[j + 1][1])
                        {
                            temp[0] = Ry[j][0];
                            temp[1] = Ry[j][1];
                            temp[2] = Ry[j][2];
                            temp[1] = Ry[j][1];
                            Ry[j][0] = Ry[j + 1][0];
                            Ry[j][1] = Ry[j + 1][1];
                            Ry[j][2] = Ry[j + 1][2];
                            Ry[j + 1][0] = temp[0];
                            Ry[j + 1][1] = temp[1];
                            Ry[j + 1][2] = temp[2];
                        }
                    }
                }
                double sum = 0;
                for (i = 0; i < Temp1.Count; i++)
                {
                    sum += Math.Pow(Rx[i][2] - Ry[i][2], 2);
                }
                Ts = ((1.0 / 6) * Temp1.Count * (Temp1.Count * Temp1.Count - 1) - sum - A - B) / (Math.Sqrt(((1.0 / 6) * Temp1.Count * (Temp1.Count * Temp1.Count - 1) - 2 * A) * ((1.0 / 6) * Temp1.Count * (Temp1.Count * Temp1.Count - 1) - 2 * B)));
                dataGridView1.Rows[8].Cells[2].Value = "" + Math.Round(Ts, Data.NumberOfNum);
                double TsDev = Math.Sqrt((1 - Ts * Ts) / (Temp1.Count - 2));
                dataGridView1.Rows[8].Cells[1].Value = "" + Math.Round(Ts - Quantile.StudQuan(1 - alfa1 / 2, Temp1.Count - 2) * TsDev, Data.NumberOfNum);
                dataGridView1.Rows[8].Cells[3].Value = "" + Math.Round(Ts + Quantile.StudQuan(1  - alfa1 / 2, Temp1.Count - 2) * TsDev, Data.NumberOfNum);
                double alfa2 = 0.1;
                double gamma2 = 0.9;
                try
                {
                    gamma2 = Convert.ToDouble(dataGridView1.Rows[9].Cells[4].EditedFormattedValue);
                    alfa2 = 1 - gamma2;
                }
                catch (Exception)
                {
                    dataGridView1.Rows[9].Cells[4].Value = "0,9";
                    alfa2 = 0.1;
                }
                if ((alfa2 <= 0) || (alfa2 >= 1))
                {
                    if (LogCheckBox.Checked)
                        LogOutputTextBox.Text += "Хибне значення γ для стандартного відхилення" + Environment.NewLine;
                    dataGridView1.Rows[9].Cells[4].Value = "0,9";
                    alfa2 = 0.1;
                }
                for (i = 0; i < Temp1.Count; i++)
                {
                    for (j = 0; j < Temp1.Count - 1 - i; j++)
                    {
                        if (Rx[j][2] > Rx[j + 1][2])
                        {
                            temp[0] = Rx[j][0];
                            temp[1] = Rx[j][1];
                            temp[2] = Rx[j][2];
                            Rx[j][0] = Rx[j + 1][0];
                            Rx[j][1] = Rx[j + 1][1];
                            Rx[j][2] = Rx[j + 1][2];
                            Rx[j + 1][0] = temp[0];
                            Rx[j + 1][1] = temp[1];
                            Rx[j + 1][2] = temp[2];
                        }
                    }
                }
                for (i = 0; i < Temp1.Count; i++)
                {
                    for (j = i; j < Temp1.Count; j++)
                    {
                        if (Rx[i][1] == Ry[j][1])
                        {
                            temp[0] = Ry[i][0];
                            temp[1] = Ry[i][1];
                            temp[2] = Ry[i][2];
                            Ry[i][0] = Ry[j][0];
                            Ry[i][1] = Ry[j][1];
                            Ry[i][2] = Ry[j][2];
                            Ry[j][0] = temp[0];
                            Ry[j][1] = temp[1];
                            Ry[j][2] = temp[2];
                        }
                    }
                }
                sum = 0;
                for (i = 0; i < Temp1.Count - 1; i++)
                {
                    for (j = i + 1; j < Temp1.Count; j++)
                    {
                        if (Ry[i][2] < Ry[j][2])
                        {
                            sum++;
                        }
                        else
                        {
                            if (Ry[i][2] > Ry[j][2])
                            {
                                sum--;
                            }
                        }
                    }
                }
                Tk = (2 * sum) / (Temp1.Count * (Temp1.Count - 1));
                dataGridView1.Rows[9].Cells[2].Value = "" + Math.Round(Tk, Data.NumberOfNum);
                double TkDev = Math.Sqrt((4.0 * Temp1.Count + 10) / (9 * (Temp1.Count * Temp1.Count - Temp1.Count)));
                dataGridView1.Rows[9].Cells[1].Value = "" + Math.Round(Tk - Quantile.StudQuan(1 - alfa2 / 2, Temp1.Count - 2) * TkDev, Data.NumberOfNum);
                dataGridView1.Rows[9].Cells[3].Value = "" + Math.Round(Tk + Quantile.StudQuan(1 - alfa2 / 2, Temp1.Count - 2) * TkDev, Data.NumberOfNum);
            } while (false);
        }

        private void обєднатиУДвовимірнуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArgInt Num1 = new ArgInt(1, "", "Номер вибірки", "Вибір вибірки, яка буде відповідати першому виміру", "<Size>");
            ArgInt Num2 = new ArgInt(2, "", "Номер вибірки", "Вибір вибірки, яка буде відповідати другому виміру", "<Size>");
            OkCancelDlg it = new OkCancelDlg("Виберіть вибірки для поєднання у двовимірну", null, Num1, Num2);
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                if ((Num1 < 1) || (Num2 < 1) || (Num1 > Data.DataForWork.Count) || (Num2 > Data.DataForWork.Count))
                {
                    LogOutputTextBox.Text += "Невірно заданий номер розподілу " + Environment.NewLine;
                    return;
                }
                Data.TwoDemSamples.Add(new int[] { Num1 - 1, Num2 - 1 });
                Data.TwoDemCurrentSample.set(Data.TwoDemSamples.Count - 1);
                Data.TwoDemStepBack.Add(new List<ToolsForWork.Changing>());
                BuildTwoDem();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (Data.TwoDemSamples.Count <= 0)
            {
                LogOutputTextBox.Text += "Nothing to do " + Environment.NewLine;
                return;
            }
            int i, j, k;
            List<double> Temp1 = new List<double>(), Temp2 = new List<double>();
            for (i = 0; i < Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].Count; i++)
            {
                Temp1.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]][i]);
                Temp2.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][1]][i]);
            }
            //////////////
            double Xexp, Yexp, StX, StY, KK, Kvx, Kvy, Ts,Tk;
            double MaxX = double.MinValue, MaxY = double.MinValue, MinX = double.MaxValue, MinY = double.MaxValue;
            for (i = 0; i < Temp1.Count; i++)
            {
                if (Temp1[i] < MinX)
                {
                    MinX = Temp1[i];
                }
                if (Temp2[i] < MinY)
                {
                    MinY = Temp2[i];
                }
                if (Temp1[i] > MaxX)
                {
                    MaxX = Temp1[i];
                }
                if (Temp2[i] > MaxY)
                {
                    MaxY = Temp2[i];
                }
            }
            {
                double Sum1 = 0;
                double Sum2 = 0;
                for (i = 0; i < Temp1.Count; i++)
                {
                    Sum1 += Temp1[i];
                    Sum2 += Temp2[i];
                }
                Xexp = Sum1 / Temp1.Count;
                Yexp = Sum2 / Temp1.Count;
                // dataGridView1.Rows[0].Cells[2].Value = "" + Math.Round(Xexp, Data.NumberOfNum);
                // dataGridView1.Rows[1].Cells[2].Value = "" + Math.Round(Yexp, Data.NumberOfNum);
                if (Math.Abs(Data.EvalData.ExpValues) < 0.00000000001)
                {
                    Data.EvalData.ExpValues = 0;
                }
            }
            {
                {
                    StX = 0; StY = 0;
                    for (i = 0; i < Temp1.Count; i++)
                    {
                        // Data.EvalData.StandDevZ += Data.DataForWork[Data.CurrentSample][i] * Data.DataForWork[Data.CurrentSample][i] - Data.EvalData.ExpValues * Data.EvalData.ExpValues;
                        StX += Math.Pow((Temp1[i] - Xexp), 2);
                        StY += Math.Pow((Temp2[i] - Yexp), 2);
                    }
                    // Data.EvalData.StandDevZ *= (1.0) / Data.DataForWork[Data.CurrentSample].Count;
                    StX *= (1.0) / (Temp1.Count - 1);
                    StY *= (1.0) / (Temp2.Count - 1);
                    //Data.EvalData.StandDevZ = (Math.Sqrt(Data.EvalData.StandDevZ));
                    StX = (Math.Sqrt(StX));
                    StY = (Math.Sqrt(StY));
                    //  dataGridView1.Rows[2].Cells[2].Value = "" + Math.Round(StX, Data.NumberOfNum);
                    // dataGridView1.Rows[3].Cells[2].Value = "" + Math.Round(StY, Data.NumberOfNum);
                }
            }

            {
                double CrosSum = 0;
                for (i = 0; i < Temp1.Count; i++)
                {
                    CrosSum += Temp1[i] * Temp2[i];
                }
                CrosSum /= Temp1.Count;
                KK = ((double)Temp1.Count / (Temp1.Count - 1)) * ((CrosSum - Xexp * Yexp) / (StX * StY));
                // dataGridView1.Rows[5].Cells[2].Value = "" + Math.Round(KK, Data.NumberOfNum);
            }
            /////
            int Count1 = 1;
            int Count2 = 1;
            try
            {
                Count1 = Convert.ToInt32(dataGridView1.Rows[6].Cells[4].EditedFormattedValue);
            }
            catch (Exception)
            {
                dataGridView1.Rows[6].Cells[4].Value = ToolsForWork.CompNumOfClasses(Temp2.Count);
                Count1 = ToolsForWork.CompNumOfClasses(Temp2.Count);
            }
            try
            {
                Count2 = Convert.ToInt32(dataGridView1.Rows[7].Cells[4].EditedFormattedValue);
            }
            catch (Exception)
            {
                dataGridView1.Rows[7].Cells[4].Value = ToolsForWork.CompNumOfClasses(Temp2.Count);
                Count2 = ToolsForWork.CompNumOfClasses(Temp2.Count);
            }
            if ((Count2 <= 1) || (Count2 >= 50))
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Хибна кількість розбиттів для кореляційного відношення" + Environment.NewLine;
                dataGridView1.Rows[7].Cells[4].Value = ToolsForWork.CompNumOfClasses(Temp2.Count);
                Count2 = ToolsForWork.CompNumOfClasses(Temp2.Count);
            }
            if ((Count1 <= 1) || (Count1 >= 50))
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Хибна кількість розбиттів для кореляційного відношення" + Environment.NewLine;
                dataGridView1.Rows[6].Cells[4].Value = ToolsForWork.CompNumOfClasses(Temp2.Count);
                Count1 = ToolsForWork.CompNumOfClasses(Temp2.Count);
            }
            if ((Count2 <= 1))
            {
                Count2 += 2;
            }
            if ((Count1 <= 1))
            {
                Count1 += 2;
            }
            double sum = 0;
            List<List<double>> Tx = new List<List<double>>(), Ty = new List<List<double>>();
            List<double> expxs = new List<double>(), expys = new List<double>();
            for (i = 0; i < Count1; i++)
            {
                Tx.Add(new List<double>());
                sum = 0;
                for (j = 0; j < Temp1.Count; j++)
                {
                    if ((Temp1[j] >= MinX + i * ((MaxX - MinX) / Count1)) && (Temp1[j] < MinX + (i + 1) * ((MaxX - MinX) / Count1)))
                    {
                        Tx[i].Add(Temp2[j]);
                        sum += Temp2[j];
                    }
                }
                if (i == Count1 - 1)
                {
                    for (j = 0; j < Temp1.Count; j++)
                    {
                        if ((Temp1[j] >= MinX + i * ((MaxX - MinX) / Count1)) && (Temp1[j] <= MinX + (i + 1) * ((MaxX - MinX) / Count1)))
                        {
                            Tx[i].Add(Temp2[j]);
                            sum += Temp2[j];
                        }
                    }
                }
                expys.Add(sum / Tx[i].Count);
            }
            double temp1 = 0, temp2 = 0;
            for (i = 0; i < Count1; i++)
            {
                if (double.IsNaN(expys[i]))
                    continue;
                temp1 += Tx[i].Count * Math.Pow(Yexp - expys[i], 2);
                for (j = 0; j < Tx[i].Count; j++)
                {
                    temp2 += Math.Pow(Yexp - Tx[i][j], 2);
                }
            }
            Kvx = Math.Sqrt(temp1 / temp2);
            //dataGridView1.Rows[6].Cells[2].Value = "" + Math.Round(Kvx, Data.NumberOfNum);

            for (i = 0; i < Count2; i++)
            {
                Ty.Add(new List<double>());
                sum = 0;
                for (j = 0; j < Temp1.Count; j++)
                {
                    if ((Temp2[j] >= MinY + i * ((MaxY - MinY) / Count2)) && (Temp2[j] < MinY + (i + 1) * ((MaxY - MinY) / Count2)))
                    {
                        Ty[i].Add(Temp1[j]);
                        sum += Temp1[j];
                    }
                }
                if (i == Count2 - 1)
                {
                    for (j = 0; j < Temp1.Count; j++)
                    {
                        if ((Temp2[j] >= MinY + i * ((MaxY - MinY) / Count2)) && (Temp2[j] <= MinY + (i + 1) * ((MaxY - MinY) / Count2)))
                        {
                            Ty[i].Add(Temp1[j]);
                            sum += Temp1[j];
                        }
                    }
                }
                expxs.Add(sum / Ty[i].Count);
            }
            temp1 = 0; temp2 = 0;
            for (i = 0; i < Count2; i++)
            {
                if (double.IsNaN(expxs[i]))
                    continue;
                temp1 += Ty[i].Count * Math.Pow(Xexp - expxs[i], 2);
                for (j = 0; j < Ty[i].Count; j++)
                {
                    temp2 += Math.Pow(Xexp - Ty[i][j], 2);
                }
            }
            Kvy = Math.Sqrt(temp1 / temp2);
            /////
            List<double[]> Rx = new List<double[]>();
            List<double[]> Ry = new List<double[]>();
            int LclC = 0;
            double A = 0, B = 0;
            double[] tempa = new double[3];
            for (i = 0; i < Temp1.Count; i++)
            {
                Rx.Add(new double[] { Temp1[i], i, 0 });
                Ry.Add(new double[] { Temp2[i], i, 0 });
            }
            for (i = 0; i < Temp1.Count; i++)
            {
                for (j = 0; j < Temp1.Count - 1 - i; j++)
                {
                    if (Rx[j][0] > Rx[j + 1][0])
                    {
                        tempa[0] = Rx[j][0];
                        tempa[1] = Rx[j][1];
                        Rx[j][0] = Rx[j + 1][0];
                        Rx[j][1] = Rx[j + 1][1];
                        Rx[j + 1][0] = tempa[0];
                        Rx[j + 1][1] = tempa[1];
                    }
                    if (Ry[j][0] > Ry[j + 1][0])
                    {
                        tempa[0] = Ry[j][0];
                        tempa[1] = Ry[j][1];
                        Ry[j][0] = Ry[j + 1][0];
                        Ry[j][1] = Ry[j + 1][1];
                        Ry[j + 1][0] = tempa[0];
                        Ry[j + 1][1] = tempa[1];
                    }
                }
            }
            for (i = 0; i < Temp1.Count; i++)
            {
                Rx[i][2] = i;
                Ry[i][2] = i;
            }
            for (i = 0; i < Temp1.Count - 1; i++)
            {
                LclC++;
                if (Rx[i][0] == Rx[i + 1][0])
                {

                }
                else
                {
                    A += Math.Pow(LclC, 3) - LclC;
                    for (j = i - LclC + 1; j <= i; j++)
                    {
                        Rx[j][2] = Rx[i][2] - (LclC - 1.0) / 2;
                    }
                    LclC = 0;
                }
            }
            A += Math.Pow(LclC, 3) - LclC;
            LclC = 0;
            A *= 1.0 / 12;

            for (i = 0; i < Temp1.Count - 1; i++)
            {
                LclC++;
                if (Ry[i][0] == Ry[i + 1][0])
                {
                }
                else
                {
                    B += Math.Pow(LclC, 3) - LclC;
                    for (j = i - LclC + 1; j <= i; j++)
                    {
                        Ry[j][2] = Ry[i][2] - (LclC - 1.0) / 2;
                    }
                    LclC = 0;
                }
            }
            B += Math.Pow(LclC, 3) - LclC;
            LclC = 0;
            B *= 1.0 / 12;

            for (i = 0; i < Temp1.Count; i++)
            {
                for (j = 0; j < Temp1.Count - 1 - i; j++)
                {
                    if (Rx[j][1] > Rx[j + 1][1])
                    {
                        tempa[0] = Rx[j][0];
                        tempa[1] = Rx[j][1];
                        tempa[2] = Rx[j][2];
                        Rx[j][0] = Rx[j + 1][0];
                        Rx[j][1] = Rx[j + 1][1];
                        Rx[j][2] = Rx[j + 1][2];
                        Rx[j + 1][0] = tempa[0];
                        Rx[j + 1][1] = tempa[1];
                        Rx[j + 1][2] = tempa[2];
                    }
                    if (Ry[j][1] > Ry[j + 1][1])
                    {
                        tempa[0] = Ry[j][0];
                        tempa[1] = Ry[j][1];
                        tempa[2] = Ry[j][2];
                        Ry[j][0] = Ry[j + 1][0];
                        Ry[j][1] = Ry[j + 1][1];
                        Ry[j][2] = Ry[j + 1][2];
                        Ry[j + 1][0] = tempa[0];
                        Ry[j + 1][1] = tempa[1];
                        Ry[j + 1][2] = tempa[2];
                    }
                }
            }
            sum = 0;
            for (i = 0; i < Temp1.Count; i++)
            {
                sum += Math.Pow(Rx[i][2] - Ry[i][2], 2);
            }
            Ts = ((1.0 / 6) * Temp1.Count * (Temp1.Count * Temp1.Count - 1) - sum - A - B) / (Math.Sqrt(((1.0 / 6) * Temp1.Count * (Temp1.Count * Temp1.Count - 1) - 2 * A) * ((1.0 / 6) * Temp1.Count * (Temp1.Count * Temp1.Count - 1) - 2 * B)));
            double alfa2 = 0.1;
            double gamma2 = 0.9;
            try
            {
                gamma2 = Convert.ToDouble(dataGridView1.Rows[9].Cells[4].EditedFormattedValue);
                alfa2 = 1 - gamma2;
            }
            catch (Exception)
            {
                dataGridView1.Rows[9].Cells[4].Value = "0,9";
                alfa2 = 0.1;
            }
            if ((alfa2 <= 0) || (alfa2 >= 1))
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Хибне значення γ для стандартного відхилення" + Environment.NewLine;
                dataGridView1.Rows[9].Cells[4].Value = "0,9";
                alfa2 = 0.1;
            }
            for (i = 0; i < Temp1.Count; i++)
            {
                for (j = 0; j < Temp1.Count - 1 - i; j++)
                {
                    if (Rx[j][2] > Rx[j + 1][2])
                    {
                        tempa[0] = Rx[j][0];
                        tempa[1] = Rx[j][1];
                        tempa[2] = Rx[j][2];
                        Rx[j][0] = Rx[j + 1][0];
                        Rx[j][1] = Rx[j + 1][1];
                        Rx[j][2] = Rx[j + 1][2];
                        Rx[j + 1][0] = tempa[0];
                        Rx[j + 1][1] = tempa[1];
                        Rx[j + 1][2] = tempa[2];
                    }
                }
            }
            for (i = 0; i < Temp1.Count; i++)
            {
                for (j = i; j < Temp1.Count; j++)
                {
                    if (Rx[i][1] == Ry[j][1])
                    {
                        tempa[0] = Ry[i][0];
                        tempa[1] = Ry[i][1];
                        tempa[2] = Ry[i][2];
                        Ry[i][0] = Ry[j][0];
                        Ry[i][1] = Ry[j][1];
                        Ry[i][2] = Ry[j][2];
                        Ry[j][0] = tempa[0];
                        Ry[j][1] = tempa[1];
                        Ry[j][2] = tempa[2];
                    }
                }
            }
            sum = 0;
            for (i = 0; i < Temp1.Count - 1; i++)
            {
                for (j = i + 1; j < Temp1.Count; j++)
                {
                    if (Ry[i][2] < Ry[j][2])
                    {
                        sum++;
                    }
                    else
                    {
                        if (Ry[i][2] > Ry[j][2])
                        {
                            sum--;
                        }
                    }
                }
            }
            Tk = (2 * sum) / (Temp1.Count * (Temp1.Count - 1));
            double TkDev = Math.Sqrt((4.0 * Temp1.Count + 10) / (9 * (Temp1.Count * Temp1.Count - Temp1.Count)));    
            ///
            double alfa = 0.1;
            try
            {
                alfa = Convert.ToDouble(textBox4.Text);
                if (alfa <= 0 || alfa >= 1)
                    throw new Exception();
            }
            catch
            {
                LogOutputTextBox.Text += "Wronga alfa " + Environment.NewLine;
                alfa = 0.1;
                textBox4.Text = "" + 0.1;
            }
            double temp = (KK * Math.Sqrt(Temp1.Count - 2)) / (Math.Sqrt(1 - KK * KK));
            if (Math.Abs(temp) < Quantile.StudQuan(1 - alfa / 2, Temp1.Count))
            {
                LogOutputTextBox.Text += "Гіпотеза про значущість коефіціента кореляції є невірною " + Environment.NewLine;
            }
            else
            {
                LogOutputTextBox.Text += "Гіпотеза про значущість коефіціента кореляції є вірною " + Environment.NewLine;
            }
            ////
            temp = (Kvx * Math.Sqrt(Temp1.Count - 2)) / (Math.Sqrt(1 - Kvx * Kvx));
            if (Math.Abs(temp) < Quantile.StudQuan(1 - alfa / 2, Temp1.Count))
            {
                LogOutputTextBox.Text += "Гіпотеза про значущість кореляційного відношення по х є невірною (для великої кількості даних)" + Environment.NewLine;
            }
            else
            {
                LogOutputTextBox.Text += "Гіпотеза про значущість кореляційного відношення по х є вірною (для великої кількості даних)" + Environment.NewLine;
            }
            temp = (Kvy * Math.Sqrt(Temp1.Count - 2)) / (Math.Sqrt(1 - Kvy * Kvy));
            if (Math.Abs(temp) < Quantile.StudQuan(1 - alfa / 2, Temp1.Count))
            {
                LogOutputTextBox.Text += "Гіпотеза про значущість кореляційного відношення по y є невірною (для великої кількості даних)" + Environment.NewLine;
            }
            else
            {
                LogOutputTextBox.Text += "Гіпотеза про значущість кореляційного відношення по y є вірною (для великої кількості даних)" + Environment.NewLine;
            }
            ////
            temp = ((Kvx * Kvx) / (1 - Kvx * Kvx)) * (((double)Temp1.Count - Count1) / (Count1 - 1));
            if (Math.Abs(temp) < Quantile.FishQuan(1 - alfa, Count1-1, Temp1.Count-Count1))
            {
                LogOutputTextBox.Text += "Гіпотеза про значущість кореляційного відношення по х є невірною (для довільної кількості даних)" + Environment.NewLine;
            }
            else
            {
                LogOutputTextBox.Text += "Гіпотеза про значущість кореляційного відношення по х є вірною (для довільної кількості даних)" + Environment.NewLine;
            }
            temp = ((Kvy* Kvy) / (1 - Kvy * Kvy)) * (((double)Temp1.Count - Count2) / (Count1 - 1));
            if (Math.Abs(temp) < Quantile.FishQuan(1 - alfa, Count2 - 1, Temp1.Count - Count2))
            {
                LogOutputTextBox.Text += "Гіпотеза про значущість кореляційного відношення по y є невірною (для довільної кількості даних)" + Environment.NewLine;
            }
            else
            {
                LogOutputTextBox.Text += "Гіпотеза про значущість кореляційного відношення по y є вірною (для довільної кількості даних)" + Environment.NewLine;
            }
            ////
            temp = (Ts * Math.Sqrt(Temp1.Count - 2)) / (Math.Sqrt(1 - Ts * Ts));
            if (Math.Abs(temp) < Quantile.StudQuan(1 - alfa/2, Temp1.Count-2))
            {
                LogOutputTextBox.Text += "Гіпотеза про значущість коефіціента Спірмена є невірною " + Environment.NewLine;
            }
            else
            {
                LogOutputTextBox.Text += "Гіпотеза про значущість коефіціента Спірмена є вірною " + Environment.NewLine;
            }
            ////
            temp = ((3 * Tk) / (Math.Sqrt(2 * (2 * Temp1.Count + 5)))) * (Math.Sqrt(Temp1.Count * (Temp1.Count - 1)));
            if (Math.Abs(temp) < Quantile.StanQuanOdn(1 - alfa / 2))
            {
                LogOutputTextBox.Text += "Гіпотеза про значущість коефіціента Кендалла є невірною " + Environment.NewLine;
            }
            else
            {
                LogOutputTextBox.Text += "Гіпотеза про значущість коефіціента Кендалла є вірною " + Environment.NewLine;
            }
        }

        private void зберегтиДвовимірнуВибіркуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Data.TwoDemSamples.Count <= 0)
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Нема з чим працювати " + Environment.NewLine;
                return;
            }
            // Stream myStream;
            SaveFileDialog savingFileDialog = new SaveFileDialog();
            savingFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            savingFileDialog.FilterIndex = 2;
            savingFileDialog.RestoreDirectory = true;
            savingFileDialog.RestoreDirectory = true;
            if (savingFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter FileToWrite = new System.IO.StreamWriter(savingFileDialog.FileName, true))
                {
                    for (int i = 0; i < Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].Count; i++)
                    {
                        FileToWrite.Write(""+Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]][i]);
                        FileToWrite.Write(" ");
                        FileToWrite.WriteLine("" + Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][1]][i]);
                    }
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (Data.TwoDemSamples.Count <= 0)
            {
                LogOutputTextBox.Text += "Theres nothing to do" + Environment.NewLine;
                return;
            }
            int i, j, k;
            List<double> Temp1 = new List<double>(), Temp2 = new List<double>();
            for (i = 0; i < Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].Count; i++)
            {
                Temp1.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]][i]);
                Temp2.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][1]][i]);
            }
            double MaxX = double.MinValue, MaxY = double.MinValue, MinX = double.MaxValue, MinY = double.MaxValue;
            for (i = 0; i < Temp1.Count; i++)
            {
                if (Temp1[i] < MinX)
                {
                    MinX = Temp1[i];
                }
                if (Temp2[i] < MinY)
                {
                    MinY = Temp2[i];
                }
                if (Temp1[i] > MaxX)
                {
                    MaxX = Temp1[i];
                }
                if (Temp2[i] > MaxY)
                {
                    MaxY = Temp2[i];
                }
            }
            double Limx, Limy;
            int N00 = 0, N01 = 0, N10 = 0, N11 = 0, N0 = 0, N1 = 0, M0 = 0, M1 = 0;
            try
            {
                Limx = Convert.ToDouble(textBox5.Text);
                Limy = Convert.ToDouble(textBox6.Text);
            }
            catch
            {
                LogOutputTextBox.Text += "Неможливо свторити таблицю 2 на 2 - один з параметрів не є числом" + Environment.NewLine;
                return;
            }
            for (i = 0; i < Temp1.Count; i++)
            {
                if (Temp1[i] <= Limx)
                {
                    if (Temp2[i] <= Limy)
                    {
                        N00++;
                    }
                    else
                    {
                        N01++;
                    }
                }
                else
                {
                    if (Temp2[i] <= Limy)
                    {
                        N10++;
                    }
                    else
                    {
                        N11++;
                    }
                }
            }
            double temp;
            N0 = N00 + N01;
            N1 = N10 + N11;
            M0 = N00 + N10;
            M1 = N01 + N11;
            double IF, FI, UQ, UY;
            IF = ((double)(N00 + N11 - N10 - N01)) / (N00 + N11 + N10 + N01);
            dataGridView2.Rows[0].Cells[1].Value = Math.Round(IF,Data.NumberOfNum);
            ////
            FI = ((double)(N00 * N11 - N10 * N01)) / (Math.Sqrt(N0) * Math.Sqrt(N1) * Math.Sqrt(M0) * Math.Sqrt(M1));
            dataGridView2.Rows[1].Cells[1].Value = Math.Round(FI,Data.NumberOfNum);
            double alfa1 = 0.1;
            double gamma1 = 0.9;
            try
            {
                gamma1 = Convert.ToDouble(dataGridView2.Rows[1].Cells[3].EditedFormattedValue);
                alfa1 = 1 - gamma1;
            }
            catch (Exception)
            {
                dataGridView2.Rows[1].Cells[3].Value = "0,9";
                alfa1 = 0.1;
            }
            if ((alfa1 <= 0) || (alfa1 >= 1))
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Хибне значення γ для коефіціенту сполучень Φ" + Environment.NewLine;
                dataGridView2.Rows[1].Cells[3].Value = "0,9";
                alfa1 = 0.1;
            }
            if ((Temp1.Count > 40) && (N00 > 5) && (N01 > 5) && (N10 > 5) && (N11 > 5))
            {
                temp = FI * FI * Temp1.Count;
            }
            else
            {
                temp = Temp1.Count * ((Math.Pow(N00 * N11 - N01 * N10 - 0.5, 0.5)) / (N0 * N1 * M0 * M1));
            }
            if (temp > Quantile.HirsQuan(1 - alfa1, 1))
            {
                dataGridView2.Rows[1].Cells[2].Value = "Значущий " + Environment.NewLine;
            }
            else
            {
                dataGridView2.Rows[1].Cells[2].Value = "Незначущий" + Environment.NewLine;
            }
            ////
            UQ = ((double)(N00 * N11 - N01 * N10)) / (N00 * N11 + N01 * N10);
            UY = ((double)(Math.Sqrt(N00 * N11) - Math.Sqrt(N01 * N10))) / (Math.Sqrt(N00 * N11) + Math.Sqrt(N01 * N10));
            dataGridView2.Rows[2].Cells[1].Value = Math.Round(UQ,Data.NumberOfNum);
            dataGridView2.Rows[3].Cells[1].Value = Math.Round(UY,Data.NumberOfNum);
            double Sq, Sy;
            Sq = 0.5 * (1 - UQ * UQ) * Math.Sqrt(1.0/N00+1.0/N01+1.0/N10+1.0/N11);
            Sy = 0.25 * (1 - UY * UY) * Math.Sqrt(1.0 / N00 + 1.0 / N01 + 1.0 / N10 + 1.0 / N11);
            alfa1 = 0.1;
            gamma1 = 0.9;
            try
            {
                gamma1 = Convert.ToDouble(dataGridView2.Rows[2].Cells[3].EditedFormattedValue);
                alfa1 = 1 - gamma1;
            }
            catch (Exception)
            {
                dataGridView2.Rows[2].Cells[3].Value = "0,9";
                alfa1 = 0.1;
            }
            if ((alfa1 <= 0) || (alfa1 >= 1))
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Хибне значення γ для коефіціенту Юла Q" + Environment.NewLine;
                dataGridView2.Rows[2].Cells[3].Value = "0,9";
                alfa1 = 0.1;
            }
            temp = UQ / Sq;
            if (Math.Abs(temp) > Quantile.StanQuanOdn(1 - alfa1/2))
            {
                dataGridView2.Rows[2].Cells[2].Value = "Значущий " + Environment.NewLine;
            }
            else
            {
                dataGridView2.Rows[2].Cells[2].Value = "Незначущий" + Environment.NewLine;
            }
            ///
            try
            {
                gamma1 = Convert.ToDouble(dataGridView2.Rows[3].Cells[3].EditedFormattedValue);
                alfa1 = 1 - gamma1;
            }
            catch (Exception)
            {
                dataGridView2.Rows[3].Cells[3].Value = "0,9";
                alfa1 = 0.1;
            }
            if ((alfa1 <= 0) || (alfa1 >= 1))
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Хибне значення γ для коефіціенту Юла Y" + Environment.NewLine;
                dataGridView2.Rows[3].Cells[3].Value = "0,9";
                alfa1 = 0.1;
            }
            temp = UY / Sy;
            if (Math.Abs(temp) > Quantile.StanQuanOdn(1 - alfa1 / 2))
            {
                dataGridView2.Rows[3].Cells[2].Value = "Значущий " + Environment.NewLine;
            }               
            else            
            {               
                dataGridView2.Rows[3].Cells[2].Value = "Незначущий" + Environment.NewLine;
            }
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            button21_Click(this, new EventArgs());
        }


        private void button23_Click(object sender, EventArgs e)
        {
            int i, j,k,l;
            dataGridView4.Rows[0].Cells[1].Value = "";
            dataGridView4.Rows[1].Cells[1].Value = "";
            dataGridView4.Rows[2].Cells[1].Value = "";
            if (Data.TwoDemSamples.Count <= 0)
            {
                LogOutputTextBox.Text += "Nothing to do" + Environment.NewLine;
                return;
            }
            List<double> Temp1 = new List<double>(), Temp2 = new List<double>();
            for (i = 0; i < Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].Count; i++)
            {
                Temp1.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]][i]);
                Temp2.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][1]][i]);
            }
            int CountX = ToolsForWork.CompNumOfClasses(Temp1.Count), CountY = ToolsForWork.CompNumOfClasses(Temp2.Count);
            double MaxX = double.MinValue, MaxY = double.MinValue, MinX = double.MaxValue, MinY = double.MaxValue;
            for (i = 0; i < Temp1.Count; i++)
            {
                if (Temp1[i] < MinX)
                {
                    MinX = Temp1[i];
                }
                if (Temp2[i] < MinY)
                {
                    MinY = Temp2[i];
                }
                if (Temp1[i] > MaxX)
                {
                    MaxX = Temp1[i];
                }
                if (Temp2[i] > MaxY)
                {
                    MaxY = Temp2[i];
                }
            }
            //////////////
            int n, m;
            try
            {
                n = Convert.ToInt32(textBox7.Text);
                m = Convert.ToInt32(textBox8.Text);
                if (n < 0 || m < 0 || n > 20 || m > 20)
                    throw new Exception();
            }
            catch
            {
                LogOutputTextBox.Text += "Значення n або m введено невірно" + Environment.NewLine;
                return;
            }
            double alfa;
            try
            {
                alfa = Convert.ToDouble(textBox9.Text);
            }
            catch
            {
                textBox9.Text = ""+0.1;
                alfa = 0.1;
            }
            if(alfa<=0 || alfa>=1)
            {
                textBox9.Text = ""+0.1;
                alfa = 0.1;
            }
            double[,] Nij = new double[n, m];
            double[] Ns = new double[n], Ms = new double[m];
            try
            {
                for(i =0; i < n; i++)
                {
                    for (j = 0; j < m;j++)
                    {
                        Nij[i, j] = 0;
                        for (k = 0; k < Temp1.Count; k++)
                        {
                            if ((Temp1[k] >= MinX + i * ((MaxX - MinX) / n)) && (Temp1[k] < MinX + (i + 1) * ((MaxX - MinX) /n)) && (Temp2[k] >= MinY + (j) * ((MaxY - MinY) / m)) && (Temp2[k] < MinY + (j + 1) * ((MaxY - MinY) / m)))
                            {
                                Nij[i, j]++;
                            }
                        }
                    }
                }
            }
            catch
            {
                LogOutputTextBox.Text += "Theres mistake in your Grid" + Environment.NewLine;
                return;
            }
            for (i = 0; i < n; i++)
            {
                Ns[i] = 0;
                for (j = 0; j < m; j++)
                {
                    Ns[i] += Nij[i, j];
                }
            }
            for (j = 0; j < m; j++)
            {
                Ms[j] = 0;
                for (i = 0; i < n; i++)
                {
                    Ms[j] += Nij[i, j];
                }
            }
            double sum = 0;
            for (i = 1; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    sum += Math.Pow(Nij[i, j] - (Ns[i] * Ms[j]) / (Temp1.Count), 2) / ((Ns[i] * Ms[j]) / (Temp1.Count));
                }
            }
            if (sum <= Quantile.HirsQuan(1 - alfa, (n - 1) * (m - 1)))
            {
                LogOutputTextBox.Text += "Згідно критерія Пірсона звязок між ознаками відсутній. Отримані оцінки скоріш за все не мають жодної значущості" + Environment.NewLine;
            }
            double C = Math.Sqrt((sum) / (sum + Temp1.Count));
            double temp;
            dataGridView4.Rows[0].Cells[1].Value = ""+Math.Round(C,Data.NumberOfNum);
            if (n == m)
            {
                double P = 0, Q = 0, T1 = 0, T2 = 0;
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < m; j++)
                    {
                        temp = 0;
                        for (k = i + 1; k < n; k++)
                        {
                            for (l = j + 1; l < m; l++)
                            {
                                temp += Nij[k, l];
                            }
                        }
                        P += temp * Nij[i, j];
                    }
                }
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < m; j++)
                    {
                        temp = 0;
                        for (k = i + 1; k < n; k++)
                        {
                            for (l = 0; l < j; l++)
                            {
                                temp += Nij[k, l];
                            }
                        }
                        Q += temp * Nij[i, j];
                    }
                }
                for (i = 0; i < n; i++)
                {
                    T1 += Ns[i] * (Ns[i] - 1);
                }
                T1 *= 0.5;
                for (i = 0; i < m; i++)
                {
                    T2 += Ms[i] * (Ms[i] - 1);
                }
                T2 *= 0.5;
                double Tk = (P - Q) / (Math.Sqrt((0.5 * (Temp1.Count) * (Temp1.Count - 1) - T1) * (0.5 * Temp1.Count * (Temp1.Count - 1) - T2)));
                dataGridView4.Rows[1].Cells[1].Value = "" + Math.Round(Tk, Data.NumberOfNum);
            }
            else
            {
                double P = 0, Q = 0, T1 = 0, T2 = 0;
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < m; j++)
                    {
                        temp = 0;
                        for (k = i + 1; k < n; k++)
                        {
                            for (l = j + 1; l < m; l++)
                            {
                                temp += Nij[k, l];
                            }
                        }
                        P += temp * Nij[i, j];
                    }
                }
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < m; j++)
                    {
                        temp = 0;
                        for (k = i + 1; k < n; k++)
                        {
                            for (l = 0; l < j; l++)
                            {
                                temp += Nij[k, l];
                            }
                        }
                        Q += temp * Nij[i, j];
                    }
                }
                double Tst = (2*(P-Q)*Math.Min(m,n))/(Temp1.Count*Temp1.Count*(Math.Min(m,n)-1));
                dataGridView4.Rows[2].Cells[1].Value = "" + Math.Round(Tst, Data.NumberOfNum);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int i, j, k, l;
            dataGridView4.Rows[0].Cells[1].Value = "";
            dataGridView4.Rows[1].Cells[1].Value = "";
            dataGridView4.Rows[2].Cells[1].Value = "";
            if (Data.TwoDemSamples.Count <= 0)
            {
                LogOutputTextBox.Text += "Nothing to do" + Environment.NewLine;
                return;
            }
            List<double> Temp1 = new List<double>(), Temp2 = new List<double>();
            for (i = 0; i < Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].Count; i++)
            {
                Temp1.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]][i]);
                Temp2.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][1]][i]);
            }
            int CountX = ToolsForWork.CompNumOfClasses(Temp1.Count), CountY = ToolsForWork.CompNumOfClasses(Temp2.Count);
            double MaxX = double.MinValue, MaxY = double.MinValue, MinX = double.MaxValue, MinY = double.MaxValue;
            for (i = 0; i < Temp1.Count; i++)
            {
                if (Temp1[i] < MinX)
                {
                    MinX = Temp1[i];
                }
                if (Temp2[i] < MinY)
                {
                    MinY = Temp2[i];
                }
                if (Temp1[i] > MaxX)
                {
                    MaxX = Temp1[i];
                }
                if (Temp2[i] > MaxY)
                {
                    MaxY = Temp2[i];
                }
            }
            //////////////
            int n, m;
            try
            {
                n = Convert.ToInt32(textBox7.Text);
                m = Convert.ToInt32(textBox8.Text);
                if (n < 0 || m < 0 || n > 20 || m > 20)
                    throw new Exception();
            }
            catch
            {
                LogOutputTextBox.Text += "Значення n або m введено невірно" + Environment.NewLine;
                return;
            }
            double alfa;
            try
            {
                alfa = Convert.ToDouble(textBox9.Text);
            }
            catch
            {
                textBox9.Text = "" + 0.1;
                alfa = 0.1;
            }
            if (alfa <= 0 || alfa >= 1)
            {
                textBox9.Text = "" + 0.1;
                alfa = 0.1;
            }
            double[,] Nij = new double[n, m];
            double[] Ns = new double[n], Ms = new double[m];
            try
            {
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < m; j++)
                    {
                        Nij[i, j] = 0;
                        for (k = 0; k < Temp1.Count; k++)
                        {
                            if ((Temp1[k] >= MinX + i * ((MaxX - MinX) / n)) && (Temp1[k] < MinX + (i + 1) * ((MaxX - MinX) / n)) && (Temp2[k] >= MinY + (j) * ((MaxY - MinY) / m)) && (Temp2[k] < MinY + (j + 1) * ((MaxY - MinY) / m)))
                            {
                                Nij[i, j]++;
                            }
                        }
                    }
                }
            }
            catch
            {
                LogOutputTextBox.Text += "Theres mistake in your Grid" + Environment.NewLine;
                return;
            }
            for (i = 0; i < n; i++)
            {
                Ns[i] = 0;
                for (j = 0; j < m; j++)
                {
                    Ns[i] += Nij[i, j];
                }
            }
            for (j = 0; j < m; j++)
            {
                Ms[j] = 0;
                for (i = 0; i < n; i++)
                {
                    Ms[j] += Nij[i, j];
                }
            }
            double sum = 0;
            double temp;
            if (n == m)
            {
                LogOutputTextBox.Text += "Theres mistake in your Grid" + Environment.NewLine;
                return;
            }
            {
                double P = 0, Q = 0, T1 = 0, T2 = 0;
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < m; j++)
                    {
                        temp = 0;
                        for (k = i + 1; k < n; k++)
                        {
                            for (l = j + 1; l < m; l++)
                            {
                                temp += Nij[k, l];
                            }
                        }
                        P += temp * Nij[i, j];
                    }
                }
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < m; j++)
                    {
                        temp = 0;
                        for (k = i + 1; k < n; k++)
                        {
                            for (l = 0; l < j; l++)
                            {
                                temp += Nij[k, l];
                            }
                        }
                        Q += temp * Nij[i, j];
                    }
                }
                double Tst = (2 * (P - Q) * Math.Min(m, n)) / (Temp1.Count * Temp1.Count * (Math.Min(m, n) - 1));
                
            }
        }

        private void dataGridView3_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int Num = Convert.ToInt32(e.Row.Cells[4].Value);
            if (Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].Count <= 4)
            {
                LogOutputTextBox.Text += "Dangerous. I cant let u proceed" + Environment.NewLine;
                e.Cancel = true;
                return;
            }
            int j;
            for (int i = 0; i < Data.MultiDemSamples.Count; i++)
            {
                for (j = 0; j < Data.MultiDemSamples[i].Length; j++)
                {
                    if (Data.CurrentSample == Data.MultiDemSamples[i][j])
                    {
                        LogOutputTextBox.Text += "U cant delete what is part of multi dimentional world!" + Environment.NewLine;
                        e.Cancel = true;
                    }
                }
            }
        }

        private void dataGridView3_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            int Num = Convert.ToInt32(e.Row.Cells[4].Value);
            double[] FW = new double[2];
            FW[0] = Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]][Num];
            FW[1] = Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][1]][Num];
            Data.TwoDemStepBack[Data.TwoDemCurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.twodemdeleted, FW));
            Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].RemoveAt(Num);
            Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][1]].RemoveAt(Num);
            UpdateForm();
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            int j,i ,k;
            for (i = 0; i < Data.MultiDemSamples.Count; i++)
            {
                for (j = 0; j < Data.MultiDemSamples[i].Length; j++)
                {
                    if (Data.CurrentSample == Data.MultiDemSamples[i][j])
                    {
                        LogOutputTextBox.Text += "U cant delete what is part of multi dimentional world!" + Environment.NewLine;
                        return;
                    }
                }
            }
            double alfa;
            try
            {
                alfa = Convert.ToDouble(textBox10.Text);
            }
            catch
            {
                textBox10.Text = "" + 0.05;
                alfa = 0.05;
            }
            if(alfa<=0||alfa>=1)
            {
                textBox10.Text = "" + 0.05;
                alfa = 0.05;
            }
            //List<double> Temp1 = new List<double>(), Temp2 = new List<double>();
            List<double> Temp1 = Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]], Temp2 = Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][1]];
            /*for (i = 0; i < Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].Count; i++)
            {
                Temp1.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]][i]);
                Temp2.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][1]][i]);
            }*/
            int CountX = ToolsForWork.CompNumOfClasses(Temp1.Count), CountY = ToolsForWork.CompNumOfClasses(Temp2.Count);
            double MaxX = double.MinValue, MaxY = double.MinValue, MinX = double.MaxValue, MinY = double.MaxValue;
            PictureBox[,] Hist = new PictureBox[CountX, CountY];
            for (i = 0; i < Temp1.Count; i++)
            {
                if (Temp1[i] < MinX)
                {
                    MinX = Temp1[i];
                }
                if (Temp2[i] < MinY)
                {
                    MinY = Temp2[i];
                }
                if (Temp1[i] > MaxX)
                {
                    MaxX = Temp1[i];
                }
                if (Temp2[i] > MaxY)
                {
                    MaxY = Temp2[i];
                }
            }
            MinX = MinX - 0.000001;
            MinY = MinY - 0.000001;
            MaxX = MaxX + 0.000001;
            MaxY = MaxY + 0.000001;
            int[,] Ns = new int[CountX, CountY];
            double[,] Ps = new double[CountX, CountY];
            for (i = 0; i < CountX; i++)
            {
                for (j = 0; j < CountY; j++)
                {
                    Ns[i, j] = 0;
                    for (k = 0; k < Temp1.Count; k++)
                    {
                        if ((Temp1[k] >= MinX + i * ((MaxX - MinX) / CountX)) && (Temp1[k] < MinX + (i + 1) * ((MaxX - MinX) / CountX)) && (Temp2[k] >= MinY + (j) * ((MaxY - MinY) / CountY)) && (Temp2[k] < MinY + (j + 1) * ((MaxY - MinY) / CountY)))
                        {
                            Ns[i, j]++;
                        }   
                    }
                    Ps[i, j] = ((double)Ns[i, j]) / Temp1.Count;
                    //  Hist[i, j].Left = (int)chart2.ChartAreas[0].InnerPlotPosition.X + (int)(i * ((chart2.ChartAreas[0].InnerPlotPosition.Width) / CountX));
                    //Hist[i, j].Top = (int)chart2.ChartAreas[0].InnerPlotPosition.Y + (int)(j * ((chart2.ChartAreas[0].InnerPlotPosition.Height) / CountY));
                }
            }
            int alrDel=0;
            for (i = 0; i < CountX; i++)
            {
                for (j = 0; j < CountY; j++)
                {
                    for (k = 0; k < Temp1.Count; k++)
                    {
                       
                        if ((Temp1[k] >= MinX + i * ((MaxX - MinX) / CountX)) && (Temp1[k] < MinX + (i + 1) * ((MaxX - MinX) / CountX)) && (Temp2[k] >= MinY + (j) * ((MaxY - MinY) / CountY)) && (Temp2[k] < MinY + (j + 1) * ((MaxY - MinY) / CountY)) && (Ps[i, j] < alfa) && (Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].Count >= 5))
                        {
                            double[] FW = new double[2];
                            FW[0] = Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]][k];
                            FW[1] = Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][1]][k];
                            Data.TwoDemStepBack[Data.TwoDemCurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.twodemdeleted, FW));
                            Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].RemoveAt(k);
                            Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][1]].RemoveAt(k);
                        }
                    }
                    //  Hist[i, j].Left = (int)chart2.ChartAreas[0].InnerPlotPosition.X + (int)(i * ((chart2.ChartAreas[0].InnerPlotPosition.Width) / CountX));
                    //Hist[i, j].Top = (int)chart2.ChartAreas[0].InnerPlotPosition.Y + (int)(j * ((chart2.ChartAreas[0].InnerPlotPosition.Height) / CountY));
                }
            }
            UpdateForm();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double alfa;
            try
            {
                alfa = Convert.ToDouble(textBox11.Text);
            }
            catch
            {
                textBox11.Text = "" + 0.1;
                alfa = 0.1;
            }
            if (alfa <= 0 || alfa >= 1)
            {
                textBox11.Text = "" + 0.1;
                alfa = 0.1;
            }
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
            chart1.Series[4].Points.Clear();
            chart1.Series[5].Points.Clear();
            chart1.Series[6].Points.Clear();
            chart1.Series[7].Points.Clear();
            chart1.Series[8].Points.Clear();
            int i, j, k;
            List<double> Temp1 = new List<double>(), Temp2 = new List<double>();
            for (i = 0; i < Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].Count; i++)
            {
                Temp1.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]][i]);
                Temp2.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][1]][i]);
            }
            int CountX = ToolsForWork.CompNumOfClasses(Temp1.Count), CountY = ToolsForWork.CompNumOfClasses(Temp2.Count);
            double MaxX = double.MinValue, MaxY = double.MinValue, MinX = double.MaxValue, MinY = double.MaxValue;
            for (i = 0; i < Temp1.Count; i++)
            {
                if (Temp1[i] < MinX)
                {
                    MinX = Temp1[i];
                }
                if (Temp2[i] < MinY)
                {
                    MinY = Temp2[i];
                }
                if (Temp1[i] > MaxX)
                {
                    MaxX = Temp1[i];
                }
                if (Temp2[i] > MaxY)
                {
                    MaxY = Temp2[i];
                }
            }
            //////////////
            double Xexp, Yexp, StX, StY, KK, Kvx, Kvy, Ts, Tk;
            {
                double Sum1 = 0;
                double Sum2 = 0;
                for (i = 0; i < Temp1.Count; i++)
                {
                    Sum1 += Temp1[i];
                    Sum2 += Temp2[i];
                }
                Xexp = Sum1 / Temp1.Count;
                Yexp = Sum2 / Temp1.Count;
                if (Math.Abs(Data.EvalData.ExpValues) < 0.00000000001)
                {
                    Data.EvalData.ExpValues = 0;
                }
            }
            {
                {
                    StX = 0; StY = 0;
                    for (i = 0; i < Temp1.Count; i++)
                    {
                        // Data.EvalData.StandDevZ += Data.DataForWork[Data.CurrentSample][i] * Data.DataForWork[Data.CurrentSample][i] - Data.EvalData.ExpValues * Data.EvalData.ExpValues;
                        StX += Math.Pow((Temp1[i] - Xexp), 2);
                        StY += Math.Pow((Temp2[i] - Yexp), 2);
                    }
                    // Data.EvalData.StandDevZ *= (1.0) / Data.DataForWork[Data.CurrentSample].Count;
                    StX *= (1.0) / (Temp1.Count - 1);
                    StY *= (1.0) / (Temp2.Count - 1);
                    //Data.EvalData.StandDevZ = (Math.Sqrt(Data.EvalData.StandDevZ));
                    StX = (Math.Sqrt(StX));
                    StY = (Math.Sqrt(StY));
                }
            }

            {
                double CrosSum = 0;
                for (i = 0; i < Temp1.Count; i++)
                {
                    CrosSum += Temp1[i] * Temp2[i];
                }
                CrosSum /= Temp1.Count;
                KK = ((double)Temp1.Count / (Temp1.Count - 1)) * ((CrosSum - Xexp * Yexp) / (StX * StY));
            }
            double a, b;
            if (radioButton1.Checked)
            {
                b = KK * (StY / StX);
                a = Yexp - b * Xexp;
            }
            else
            {
                List<double> TailList = new List<double>();
                for (i = 0; i < Temp1.Count - 1; i++)
                {
                    for (j = i+1; j < Temp1.Count; j++)
                    {
                        TailList.Add((Temp2[j] - Temp2[i]) / (Temp1[j] - Temp1[i]));
                    }
                }
                b = ToolsForWork.ComputeMediana(TailList);
                TailList.Clear();
                for (i = 0; i < Temp1.Count; i++)
                {
                    TailList.Add(Temp2[i]-b*Temp1[i]);
                }
                a = ToolsForWork.ComputeMediana(TailList);
            }
            if (LogCheckBox.Checked)
            {
                LogOutputTextBox.Text += "Оцінка параметрів за методом " + ((radioButton1.Checked)?"МНК":"Тейла") + ":"+ Environment.NewLine;
                LogOutputTextBox.Text += "а = " + Math.Round(a,Data.NumberOfNum) + Environment.NewLine;
                LogOutputTextBox.Text += "b = " + Math.Round(b, Data.NumberOfNum) + Environment.NewLine;
            }
            for (i = 0; i < 2000; i++)
            {
                chart1.Series[2].Points.AddXY(MinX + i * ((MaxX - MinX) / 2000), a + b * (MinX + i * ((MaxX - MinX) / 2000)));
            }
            double Szal = 0;
            for (i = 0; i < Temp1.Count; i++)
            {
                Szal += Math.Pow(Temp2[i] - a - b * Temp1[i], 2);
            }
            Szal *= 1.0 / (Temp1.Count - 2);
            double KD = (1 - Szal / (StY*StY))*100;
            LogOutputTextBox.Text += "Коефіціент детермінації = "+Math.Round(KD,Data.NumberOfNum) +"%" + Environment.NewLine;
            double Na, Nb;
            try
            {
                Na = Convert.ToDouble(textBox13.Text);
            }
            catch 
            {
                textBox13.Text = "" + 0;
                Na = 0;
            }
            try
            {
                Nb = Convert.ToDouble(textBox14.Text);
            }
            catch
            {
                textBox14.Text = "" + 0;
                Nb = 0;
            }
            double Sa, Sb;
            Sa = Math.Sqrt(Szal) * Math.Sqrt((1.0/Temp1.Count)+((Xexp*Xexp)/(StX*StX*(Temp1.Count-1))));
            Sb = Math.Sqrt(Szal) / (StX * Math.Sqrt(Temp1.Count - 1));
            if (Math.Abs((Na - a) / Sa) <= Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2))
            {
                LogOutputTextBox.Text += "Гіпотеза про збіг параметра а з наданим значенням була підтвержена (якщо ви нічого не вводили, то була доведена гіпотеза про незначущість а)" + Environment.NewLine;
            }
            else
            {
                LogOutputTextBox.Text += "Гіпотеза про збіг параметра а з наданим значенням не була підтвержена (якщо ви нічого не вводили, то була доведена гіпотеза про значущість а)" + Environment.NewLine;
            }
            if (Math.Abs((Nb - b) / Sb) <= Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2))
            {
                LogOutputTextBox.Text += "Гіпотеза про збіг параметра b з наданим значенням була підтвержена (якщо ви нічого не вводили, то була доведена гіпотеза про незначущість b)" + Environment.NewLine;
            }
            else
            {
                LogOutputTextBox.Text += "Гіпотеза про збіг параметра b з наданим значенням не була підтвержена (якщо ви нічого не вводили, то була доведена гіпотеза про значущість b)" + Environment.NewLine;
            }
            if (Math.Abs((b) / Sb) <= Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2))
            {
                LogOutputTextBox.Text += "Було доведено незначущість параметра b, а отже, і регресійного звязку. Спробуйте інший вид регресії" + Environment.NewLine;
            }
            else
            {
                LogOutputTextBox.Text += "Вітаємо! Було доведено значущість параметра b, і, відповідно, регресійного звязку" + Environment.NewLine;
            }
            LogOutputTextBox.Text += "Інтервальне оцінювання параметра а: " + Math.Round(a - Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2) * Sa, Data.NumberOfNum) + "<а=" + Math.Round(a, Data.NumberOfNum) + "<" + Math.Round(a + Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2) * Sa,Data.NumberOfNum) + Environment.NewLine;
            LogOutputTextBox.Text += "Інтервальне оцінювання параметра b: " + Math.Round(b - Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2) * Sb, Data.NumberOfNum) + "<b=" + Math.Round(b, Data.NumberOfNum) + "<" + Math.Round(b + Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2) * Sb, Data.NumberOfNum) + Environment.NewLine;
            double temp;
            for (i = 0; i < 2000; i++)
            {
                chart1.Series[3].Points.AddXY(MinX + i * ((MaxX - MinX) / 2000), a + b * (MinX + i * ((MaxX - MinX) / 2000)) + Math.Sqrt(Szal) * Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2));
                chart1.Series[4].Points.AddXY(MinX + i * ((MaxX - MinX) / 2000), a + b * (MinX + i * ((MaxX - MinX) / 2000)) - Math.Sqrt(Szal) * Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2));
                temp = Math.Sqrt(Szal * (1 + 1.0 / Temp1.Count) + Sb * Sb * Math.Pow(MinX + i * ((MaxX - MinX) / 2000) - Xexp, 2));
                chart1.Series[5].Points.AddXY(MinX + i * ((MaxX - MinX) / 2000), a + b * (MinX + i * ((MaxX - MinX) / 2000)) - temp * Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2));
                chart1.Series[6].Points.AddXY(MinX + i * ((MaxX - MinX) / 2000), a + b * (MinX + i * ((MaxX - MinX) / 2000)) + temp * Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2));
                temp = Math.Sqrt(Szal * (1.0 / Temp1.Count) + Sb * Sb * Math.Pow(MinX + i * ((MaxX - MinX) / 2000) - Xexp, 2));
                chart1.Series[7].Points.AddXY(MinX + i * ((MaxX - MinX) / 2000), a + b * (MinX + i * ((MaxX - MinX) / 2000)) - temp * Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2));
                chart1.Series[8].Points.AddXY(MinX + i * ((MaxX - MinX) / 2000), a + b * (MinX + i * ((MaxX - MinX) / 2000)) + temp * Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2));
                
            }
            double f = Szal/(StY*StY);
            if(f<Quantile.FishQuan(1-alfa,Temp1.Count-1,Temp1.Count-3))
            {
                LogOutputTextBox.Text += "Гіпотеза про адекватність відтвореної моделі регресії була прийнята" + Environment.NewLine;
            }
            else
            {
                LogOutputTextBox.Text += "Гіпотеза про адекватність відтвореної моделі регресії була спростована" + Environment.NewLine;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double alfa;
            try
            {
                alfa = Convert.ToDouble(textBox11.Text);
            }
            catch
            {
                textBox11.Text = "" + 0.1;
                alfa = 0.1;
            }
            if (alfa <= 0 || alfa >= 1)
            {
                textBox11.Text = "" + 0.1;
                alfa = 0.1;
            }
            chart1.Series[2].Points.Clear();
            int i, j, k;
            List<double> Temp1 = new List<double>(), Temp2 = new List<double>();
            for (i = 0; i < Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].Count; i++)
            {
                Temp1.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]][i]);
                Temp2.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][1]][i]);
            }
            int CountX = ToolsForWork.CompNumOfClasses(Temp1.Count), CountY = ToolsForWork.CompNumOfClasses(Temp2.Count);
            double MaxX = double.MinValue, MaxY = double.MinValue, MinX = double.MaxValue, MinY = double.MaxValue;
            for (i = 0; i < Temp1.Count; i++)
            {
                if (Temp1[i] < MinX)
                {
                    MinX = Temp1[i];
                }
                if (Temp2[i] < MinY)
                {
                    MinY = Temp2[i];
                }
                if (Temp1[i] > MaxX)
                {
                    MaxX = Temp1[i];
                }
                if (Temp2[i] > MaxY)
                {
                    MaxY = Temp2[i];
                }
            }
            MinX = MinX - 0.000001;
            MinY = MinY - 0.000001;
            MaxX = MaxX + 0.000001;
            MaxY = MaxY + 0.000001;
            double Xexp, Yexp, StX, StY, KK, Kvx, Kvy, Ts, Tk;
            {
                double Sum1 = 0;
                double Sum2 = 0;
                for (i = 0; i < Temp1.Count; i++)
                {
                    Sum1 += Temp1[i];
                    Sum2 += Temp2[i];
                }
                Xexp = Sum1 / Temp1.Count;
                Yexp = Sum2 / Temp1.Count;
                if (Math.Abs(Data.EvalData.ExpValues) < 0.00000000001)
                {
                    Data.EvalData.ExpValues = 0;
                }
            }
            {
                {
                    StX = 0; StY = 0;
                    for (i = 0; i < Temp1.Count; i++)
                    {
                        // Data.EvalData.StandDevZ += Data.DataForWork[Data.CurrentSample][i] * Data.DataForWork[Data.CurrentSample][i] - Data.EvalData.ExpValues * Data.EvalData.ExpValues;
                        StX += Math.Pow((Temp1[i] - Xexp), 2);
                        StY += Math.Pow((Temp2[i] - Yexp), 2);
                    }
                    // Data.EvalData.StandDevZ *= (1.0) / Data.DataForWork[Data.CurrentSample].Count;
                    StX *= (1.0) / (Temp1.Count - 1);
                    StY *= (1.0) / (Temp2.Count - 1);
                    //Data.EvalData.StandDevZ = (Math.Sqrt(Data.EvalData.StandDevZ));
                    StX = (Math.Sqrt(StX));
                    StY = (Math.Sqrt(StY));
                }
            }
            {
                double CrosSum = 0;
                for (i = 0; i < Temp1.Count; i++)
                {
                    CrosSum += Temp1[i] * Temp2[i];
                }
                CrosSum /= Temp1.Count;
                KK = ((double)Temp1.Count / (Temp1.Count - 1)) * ((CrosSum - Xexp * Yexp) / (StX * StY));
                dataGridView1.Rows[5].Cells[2].Value = "" + Math.Round(KK, Data.NumberOfNum);
            }
            int Count1 = 1;
            try
            {
                Count1 = Convert.ToInt32(textBox12.Text);
            }
            catch (Exception)
            {
                textBox12.Text = ""+ToolsForWork.CompNumOfClasses(Temp1.Count);
                Count1 = ToolsForWork.CompNumOfClasses(Temp2.Count);
            }
            if ((Count1 <= 1) || (Count1 >= 50))
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Хибна кількість розбиттів для кореляційного відношення" + Environment.NewLine;
                textBox12.Text = ""+ToolsForWork.CompNumOfClasses(Temp1.Count);
                Count1 = ToolsForWork.CompNumOfClasses(Temp2.Count);
            }
            if ((Count1 <= 1))
            {
                Count1 += 2;
            }
            double sum = 0;
            List<List<double>> Tx = new List<List<double>>(), Ty = new List<List<double>>();
            List<double> expxs = new List<double>(), expys = new List<double>();
            for (i = 0; i < Count1; i++)
            {
                Tx.Add(new List<double>());
                sum = 0;
                for (j = 0; j < Temp1.Count; j++)
                {
                    if ((Temp1[j] >= MinX + i * ((MaxX - MinX) / Count1)) && (Temp1[j] < MinX + (i + 1) * ((MaxX - MinX) / Count1)))
                    {
                        Tx[i].Add(Temp2[j]);
                        sum += Temp2[j];
                    }
                }
                if (i == Count1 - 1)
                {
                    for (j = 0; j < Temp1.Count; j++)
                    {
                        if ((Temp1[j] >= MinX + i * ((MaxX - MinX) / Count1)) && (Temp1[j] <= MinX + (i + 1) * ((MaxX - MinX) / Count1)))
                        {
                            Tx[i].Add(Temp2[j]);
                            sum += Temp2[j];
                        }
                    }
                }
                expys.Add(sum / Tx[i].Count);
            }
            double temp1 = 0, temp2 = 0;
            for (i = 0; i < Count1; i++)
            {
                if (double.IsNaN(expys[i]))
                    continue;
                temp1 += Tx[i].Count * Math.Pow(Yexp - expys[i], 2);
                for (j = 0; j < Tx[i].Count; j++)
                {
                    temp2 += Math.Pow(Yexp - Tx[i][j], 2);
                }
            }
            Kvx = Math.Sqrt(temp1 / temp2);
            {
                int[] Numbers = new int[Count1];
                double[] ExpVals = new double[Count1];
                double[] StD = new double[Count1];
                for (i = 0; i < Count1; i++)
                {
                    Numbers[i] = Tx[i].Count;
                    ExpVals[i] = 0;
                    for (j = 0; j < Numbers[i]; j++)
                    {
                        ExpVals[i] += Tx[i][j];
                    }
                    ExpVals[i] = ExpVals[i] / Numbers[i];
                    StD[i] = 0;
                    for (j = 0; j < Numbers[i]; j++)
                    {
                        StD[i] += Math.Pow((Tx[i][j] - ExpVals[i]), 2);
                    }
                    StD[i] *= (1.0) / (Numbers[i] - 1);
                }
                double S2 = 0;
                double sumup = 0;
                double sumdown = 0;
                for (i = 0; i < Count1; i++)
                {
                    sumdown += (Numbers[i] - 1);
                    sumup += (Numbers[i] - 1) * StD[i];
                }
                S2 = sumup / sumdown;
                double B = 0;
                for (i = 0; i < Count1; i++)
                {
                    B += (Numbers[i] - 1) * Math.Log(StD[i] / S2);
                }
                B *= -1;
                double C1 = 0;
                double C2 = 0;
                for (i = 0; i < Count1; i++)
                {
                    C1 += (1.0 / (Numbers[i] - 1));
                    C2 += (Numbers[i] - 1);
                }
                double C = 1 + (1.0 / (3 * (Count1 - 1))) * (C1 - (1.0 / C2));
                double result = B / C;
                LogOutputTextBox.Text += "Основний критерій Бартлетта" + Environment.NewLine;
                if (result > Quantile.HirsQuan(1 - alfa, Count1 - 1))
                {
                    LogOutputTextBox.Text += "Значення статистики = " + Math.Round(result, Data.NumberOfNum) + ", що перевищує значення квантилю " + Math.Round(Quantile.HirsQuan(1 - alfa, Count1 - 1), Data.NumberOfNum) + ", а отже, гіпотеза про збіг дисперсій у розбитті  має бути відхилена, інакше кажучи, дисперсія не залишається сталою. Подальша робота з регресіями може бути непродуктивна, бо порушена умова регресійного аналізу" + Environment.NewLine;
                }
                else
                {
                    LogOutputTextBox.Text += "Значення статистики = " + Math.Round(result, Data.NumberOfNum) + ", що є меншим за значення квантилю " + Math.Round(Quantile.HirsQuan(1 - alfa, Count1 - 1), Data.NumberOfNum) + ", а отже, гіпотеза про збіг дисперсій у розбитті  має бути прийнята" + Environment.NewLine;
                }
            }
            {
                double C = 0, S2 = 0;
                double[] Sxi = new double[Count1];
                for (i = 0; i < Count1; i++)
                {
                    Sxi[i] = 0;
                    for (j = 0; j < Tx[i].Count; j++)
                    {
                        Sxi[i] += Math.Pow(expys[i] - Tx[i][j], 2);
                    }
                    Sxi[i] *= (1.0 / (Tx[i].Count - 1));
                }
                for (i = 0; i < Count1; i++)
                {
                    S2 += (Tx[i].Count - 1) * Sxi[i];
                }
                S2 *= (1.0 / (Temp1.Count - Count1));
                double temp = 0;
                for (i = 0; i < Count1; i++)
                {
                    temp += 1.0 / Tx[i].Count;
                }
                C = 1.0 + (1.0 / (3 * (Count1 - 1))) * (temp - 1.0 / Temp1.Count);
                double L = 0;
                for (i = 0; i < Count1; i++)
                {
                    L += Tx[i].Count * Math.Log(Sxi[i] / S2);
                }
                L *= -1.0 / C;
                LogOutputTextBox.Text += "Критерій Бартлетта - додаткова перевірка" + Environment.NewLine;
                if (L > Quantile.HirsQuan(1 - alfa, Count1 - 1))
                {
                    LogOutputTextBox.Text += "Значення статистики = " + Math.Round(L, Data.NumberOfNum) + ", що перевищує значення квантилю " + Math.Round(Quantile.HirsQuan(1 - alfa, Count1 - 1), Data.NumberOfNum) + ", а отже, гіпотеза про збіг дисперсій у розбитті  має бути відхилена, інакше кажучи, дисперсія не залишається сталою. Подальша робота з регресіями може бути непродуктивна, бо порушена умова регресійного аналізу" + Environment.NewLine;
                }
                else
                {
                    LogOutputTextBox.Text += "Значення статистики = " + Math.Round(L, Data.NumberOfNum) + ", що є меншим за значення квантилю " + Math.Round(Quantile.HirsQuan(1 - alfa, Count1 - 1), Data.NumberOfNum) + ", а отже, гіпотеза про збіг дисперсій у розбитті  має бути прийнята" + Environment.NewLine;
                }

            }
            {
                {
                    double[,] Ns = new double[CountX, CountY];
                    double[,] Ps = new double[CountX, CountY];
                    chart1.Series[1].Points.AddXY(Xexp, Yexp);
                    for (i = 0; i < Temp1.Count; i++)
                    {
                        chart1.Series[0].Points.AddXY(Temp1[i], Temp2[i]);
                        chart2.Series[10].Points.AddXY(Temp1[i], Temp2[i]);
                    }
                    for (i = 0; i < CountX; i++)
                    {
                        for (j = 0; j < CountY; j++)
                        {
                            Ns[i, j] = 0;
                            for (k = 0; k < Temp1.Count; k++)
                            {
                                if ((Temp1[k] >= MinX + i * ((MaxX - MinX) / CountX)) && (Temp1[k] < MinX + (i + 1) * ((MaxX - MinX) / CountX)) && (Temp2[k] >= MinY + (j) * ((MaxY - MinY) / CountY)) && (Temp2[k] < MinY + (j + 1) * ((MaxY - MinY) / CountY)))
                                {
                                    Ns[i, j]++;
                                }
                            }
                            Ps[i, j] = ((double)Ns[i, j]) / Temp1.Count;
                            //  Hist[i, j].Left = (int)chart2.ChartAreas[0].InnerPlotPosition.X + (int)(i * ((chart2.ChartAreas[0].InnerPlotPosition.Width) / CountX));
                            //Hist[i, j].Top = (int)chart2.ChartAreas[0].InnerPlotPosition.Y + (int)(j * ((chart2.ChartAreas[0].InnerPlotPosition.Height) / CountY));
                        }
                    }
                    double temp;
                    sum = 0;
                    for (i = 0; i < CountX; i++)
                    {
                        for (j = 0; j < CountY; j++)
                        {
                            temp = (1.0 / (2 * Math.PI * StX * StY * Math.Sqrt(1 - KK * KK))) * Math.Exp(((-1.0) / (2 * (1 - KK * KK))) * (Math.Pow((MinX + (i + 0.5) * ((MaxX - MinX) / CountX) - Xexp) / (StX), 2) - (2 * KK * ((MinX + (i + 0.5) * ((MaxX - MinX) / CountX) - Xexp) / (StX)) * ((MinY + (j + 0.5) * ((MaxY - MinY) / CountY) - Yexp) / (StY))) + Math.Pow((MinY + (j + 0.5) * ((MaxY - MinY) / CountY) - Yexp) / (StY), 2)));
                            temp *= ((MaxX - MinX) / CountX) * ((MaxY - MinY) / CountY);
                            if (temp != 0)
                            {
                                sum += Math.Pow(Ps[i, j] - temp, 2) / temp;
                            }
                        }
                    }
                    dataGridView1.Rows[4].Cells[5].Value = Math.Round(sum, Data.NumberOfNum);
                    if (sum <= Quantile.HirsQuan(1 - alfa, CountX * CountY - 2))
                    {
                        LogOutputTextBox.Text += "Гіпотеза про нормальність  розподілу підтвержена";
                    }
                    else
                    {
                        LogOutputTextBox.Text +=  "Не вдаося підтвердити гіпотезу про нормальнсть розподілу";
                        LogOutputTextBox.Text += "Увага! Через хибність гіпотези про нормальність розподілу відтворення регресії може бути недостовірним!" + Environment.NewLine;
                    }
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double alfa;
            try
            {
                alfa = Convert.ToDouble(textBox11.Text);
            }
            catch
            {
                textBox11.Text = "" + 0.1;
                alfa = 0.1;
            }
            if (alfa <= 0 || alfa >= 1)
            {
                textBox11.Text = "" + 0.1;
                alfa = 0.1;
            }
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
            chart1.Series[4].Points.Clear();
            chart1.Series[5].Points.Clear();
            chart1.Series[6].Points.Clear();
            chart1.Series[7].Points.Clear();
            chart1.Series[8].Points.Clear();
            int i, j, k;
            List<double> TempSx = new List<double>(), TempSy = new List<double>();
            List<double> Temp1 = new List<double>(), Temp2 = new List<double>();
            for (i = 0; i < Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].Count; i++)
            {
                TempSx.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]][i]);
                TempSy.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][1]][i]);
            }
            for (i = 0; i < Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].Count; i++)
            {
                Temp1.Add(Math.Log(TempSx[i]));
                Temp2.Add(Math.Log(TempSy[i]));
            }
            double temp;
            int CountX = ToolsForWork.CompNumOfClasses(Temp1.Count), CountY = ToolsForWork.CompNumOfClasses(Temp2.Count);
            double MaxX = double.MinValue, MaxY = double.MinValue, MinX = double.MaxValue, MinY = double.MaxValue;
            //////////////
            //////////////
            double Xexp, Yexp, StX, StY, KK, Kvx, Kvy, Ts, Tk;
            //////////////
            for (i = 0; i < TempSx.Count; i++)
            {
                if (TempSx[i] < MinX)
                {
                    MinX = TempSx[i];
                }
                if (TempSy[i] < MinY)
                {
                    MinY = TempSy[i];
                }
                if (TempSx[i] > MaxX)
                {
                    MaxX = TempSx[i];
                }
                if (TempSy[i] > MaxY)
                {
                    MaxY = TempSy[i];
                }
            }
            //////////////
            List<double[,]> Lines = new List<double[,]>();
            for (i = 0; i < 2000; i++)
            {
                //MinX + i * ((MaxX - MinX) / 2000)
                Lines.Add(new double[,] { { MinX + i * ((MaxX - MinX) / 2000), MinX + i * ((MaxX - MinX) / 2000), MinX + i * ((MaxX - MinX) / 2000), MinX + i * ((MaxX - MinX) / 2000), MinX + i * ((MaxX - MinX) / 2000), MinX + i * ((MaxX - MinX) / 2000), MinX + i * ((MaxX - MinX) / 2000) }, { 0, 0, 0, 0, 0, 0, 0 } });
            }
            for (i = 0; i < 2000; i++)
            {
                for(j=0; j<7;j++)
                {
                    Lines[i][0,j] = Math.Log(Lines[i][0,j]);
                }
            }
            if (!checkBox2.Checked)
            {
                {
                    double Sum1 = 0;
                    double Sum2 = 0;
                    for (i = 0; i < Temp1.Count; i++)
                    {
                        Sum1 += Temp1[i];
                        Sum2 += Temp2[i];
                    }
                    Xexp = Sum1 / Temp1.Count;
                    Yexp = Sum2 / Temp1.Count;
                    if (Math.Abs(Xexp) < 0.00000000001)
                    {
                        Xexp = 0;
                    }
                    if (Math.Abs(Yexp) < 0.00000000001)
                    {
                        Yexp = 0;
                    }
                }
                {
                    {
                        StX = 0; StY = 0;
                        for (i = 0; i < Temp1.Count; i++)
                        {
                            // Data.EvalData.StandDevZ += Data.DataForWork[Data.CurrentSample][i] * Data.DataForWork[Data.CurrentSample][i] - Data.EvalData.ExpValues * Data.EvalData.ExpValues;
                            StX += Math.Pow((Temp1[i] - Xexp), 2);
                            StY += Math.Pow((Temp2[i] - Yexp), 2);
                        }
                        // Data.EvalData.StandDevZ *= (1.0) / Data.DataForWork[Data.CurrentSample].Count;
                        StX *= (1.0) / (Temp1.Count - 1);
                        StY *= (1.0) / (Temp2.Count - 1);
                        //Data.EvalData.StandDevZ = (Math.Sqrt(Data.EvalData.StandDevZ));
                        StX = (Math.Sqrt(StX));
                        StY = (Math.Sqrt(StY));
                    }
                }

                {
                    double CrosSum = 0;
                    for (i = 0; i < Temp1.Count; i++)
                    {
                        CrosSum += Temp1[i] * Temp2[i];
                    }
                    CrosSum /= Temp1.Count;
                    KK = ((double)Temp1.Count / (Temp1.Count - 1)) * ((CrosSum - Xexp * Yexp) / (StX * StY));
                }
            }
            else
            {
                {
                    double Sumx1 = 0;
                    double Sumx2 = 0;
                    double Sumy1 = 0;
                    double Sumy2 = 0;
                    for (i = 0; i < Temp1.Count; i++)
                    {
                        Sumx1 += (Temp1[i] * TempSy[i] * TempSy[i])/(TempSx[i]*TempSx[i]);
                        Sumy1 += (Temp2[i] * TempSy[i] * TempSy[i]) / (TempSx[i] * TempSx[i]);
                        Sumx2 += (TempSy[i] * TempSy[i]) / (TempSx[i] * TempSx[i]);
                        Sumy2 += (TempSy[i] * TempSy[i]) / (TempSx[i] * TempSx[i]);

                    }
                    Xexp = Sumx1 / Sumx2;
                    Yexp = Sumy1 / Sumy2;
                    if (Math.Abs(Xexp) < 0.00000000001)
                    {
                        Xexp = 0;
                    }
                    if (Math.Abs(Yexp) < 0.00000000001)
                    {
                        Yexp = 0;
                    }
                }
                {
                    {
                        double StX1 = 0; 
                        double StY1 = 0;
                        double StX2 = 0;
                        double StY2 = 0;
                        for (i = 0; i < Temp1.Count; i++)
                        {
                            // Data.EvalData.StandDevZ += Data.DataForWork[Data.CurrentSample][i] * Data.DataForWork[Data.CurrentSample][i] - Data.EvalData.ExpValues * Data.EvalData.ExpValues;
                            StX1 += (Math.Pow((Temp1[i] - Xexp), 2)* TempSy[i] * TempSy[i])/(TempSx[i]*TempSx[i]);
                            StY1 += (Math.Pow((Temp2[i] - Yexp), 2) * TempSy[i] * TempSy[i])/(TempSx[i]*TempSx[i]);
                            StX2 += (TempSy[i] * TempSy[i]) / (TempSx[i] * TempSx[i]);
                            StY2 += (TempSy[i] * TempSy[i]) / (TempSx[i] * TempSx[i]);
                        }
                        // Data.EvalData.StandDevZ *= (1.0) / Data.DataForWork[Data.CurrentSample].Count;
                        //Data.EvalData.StandDevZ = (Math.Sqrt(Data.EvalData.StandDevZ));
                        StX = (Math.Sqrt(StX1/StX2));
                        StY = (Math.Sqrt(StY1/StY2));
                    }
                }

                {
                    double CrosSum1 = 0;
                    double CrosSum2 = 0;
                    for (i = 0; i < Temp1.Count; i++)
                    {
                        CrosSum1 += (Temp1[i] * Temp2[i] * TempSy[i] * TempSy[i]) / (TempSx[i] * TempSx[i]);
                        CrosSum2 += (TempSy[i] * TempSy[i]) / (TempSx[i] * TempSx[i]);
                    }
                    KK = CrosSum1 / CrosSum2;
                }
            }
            double a, b ;
            if (radioButton3.Checked)
            {
                b = KK * (StY / StX);
                a = Yexp - b * Xexp;
            }
            else
            {
                List<double> TailList = new List<double>();
                for (i = 0; i < Temp1.Count - 1; i++)
                {
                    for (j = i + 1; j < Temp1.Count; j++)
                    {
                        TailList.Add((Temp2[j] - Temp2[i]) / (Temp1[j] - Temp1[i]));
                    }
                }
                b = ToolsForWork.ComputeMediana(TailList);
                TailList.Clear();
                for (i = 0; i < Temp1.Count; i++)
                {
                    TailList.Add(Temp2[i] - b * Temp1[i]);
                }
                a = ToolsForWork.ComputeMediana(TailList);
            }
            if (LogCheckBox.Checked)
            {
                LogOutputTextBox.Text += "Оцінка параметрів за методом " + ((radioButton1.Checked) ? "МНК" : "Тейла") + ":" + Environment.NewLine;
                LogOutputTextBox.Text += "а = " + Math.Round(Math.Exp(a), Data.NumberOfNum) + Environment.NewLine;
                LogOutputTextBox.Text += "b = " + Math.Round(b, Data.NumberOfNum) + Environment.NewLine;
            }
            for (i = 0; i < 2000; i++)
            {
                Lines[i][1,0] =  a + b * (Lines[i][0,0]);
            }
            double Szal = 0;
            for (i = 0; i < Temp1.Count; i++)
            {
                Szal += Math.Pow(Temp2[i] - a - b * Temp1[i], 2);
            }
            Szal *= 1.0 / (Temp1.Count - 2);

            double KD = (1 - Szal / (StY * StY)) * 100;
            LogOutputTextBox.Text += "Коефіціент детермінації = " + Math.Round(KD, Data.NumberOfNum) + "%" + Environment.NewLine;
            double Na, Nb;
            try
            {
                Na = Convert.ToDouble(textBox15.Text);
            }
            catch
            {
                textBox16.Text = "" + 1;
                Na = 1;
            }
            try
            {
                Nb = Convert.ToDouble(textBox16.Text);
            }
            catch
            {
                textBox15.Text = "" + 0;
                Nb = 0;
            }
            double Sa, Sb;
            Sa = Math.Sqrt(Szal) * Math.Sqrt((1.0 / Temp1.Count) + ((Xexp * Xexp) / (StX * StX * (Temp1.Count - 1))));
            Sb = Math.Sqrt(Szal) / (StX * Math.Sqrt(Temp1.Count - 1));
            if (Math.Abs((Math.Log(Na) - a) / Sa) <= Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2))
            {
                LogOutputTextBox.Text += "Гіпотеза про збіг параметра а з наданим значенням була підтвержена " + Environment.NewLine;
            }
            else
            {
                LogOutputTextBox.Text += "Гіпотеза про збіг параметра а з наданим значенням не була підтвержена " + Environment.NewLine;
            }
            if (Math.Abs((Math.Log(Nb) - b) / Sb) <= Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2))
            {
                LogOutputTextBox.Text += "Гіпотеза про збіг параметра b з наданим значенням була підтвержена " + Environment.NewLine;
            }
            else
            {
                LogOutputTextBox.Text += "Гіпотеза про збіг параметра b з наданим значенням не була підтвержена " + Environment.NewLine;
            }
            if (Math.Abs((b) / Sb) <= Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2))
            {
                LogOutputTextBox.Text += "Було доведено незначущість параметра b, а отже, і регресійного звязку. Спробуйте інший вид регресії" + Environment.NewLine;
            }
            else
            {
                LogOutputTextBox.Text += "Вітаємо! Було доведено значущість параметра b, і, відповідно, регресійного звязку" + Environment.NewLine;
            }
            LogOutputTextBox.Text += "Інтервальне оцінювання параметра а: " + Math.Round(Math.Exp(a - Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2) * Sa), Data.NumberOfNum) + "<а=" + Math.Round(Math.Exp(a), Data.NumberOfNum) + "<" + Math.Round(Math.Exp(a + Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2) * Sa), Data.NumberOfNum) + Environment.NewLine;
            LogOutputTextBox.Text += "Інтервальне оцінювання параметра b: " + Math.Round(b - Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2) * Sb, Data.NumberOfNum) + "<b=" + Math.Round(b, Data.NumberOfNum) + "<" + Math.Round(b + Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2) * Sb, Data.NumberOfNum) + Environment.NewLine;
            for (i = 0; i < 2000; i++)
            {
                Lines[i][1,1] =  a + b * Lines[i][0,1] + Math.Sqrt(Szal) * Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2);
                Lines[i][1,2] =  a + b * Lines[i][0,2] - Math.Sqrt(Szal) * Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2);
                temp = Math.Sqrt(Szal * (1 + 1.0 / Temp1.Count) + Sb * Sb * Math.Pow(Lines[i][0,1] - Xexp, 2));
                Lines[i][1,3] = a + b * Lines[i][0,3] - temp * Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2);
                Lines[i][1,4] = a + b * Lines[i][0,4] + temp * Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2);
                temp = Math.Sqrt(Szal * (1.0 / Temp1.Count) + Sb * Sb * Math.Pow(Lines[i][0,1] - Xexp, 2));
                Lines[i][1,5] = a + b * Lines[i][0,5] - temp * Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2);
                Lines[i][1,6] = a + b * Lines[i][0,6] + temp * Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2);

            }
            double f = Szal / (StY * StY);
            if (f < Quantile.FishQuan(1 - alfa, Temp1.Count - 1, Temp1.Count - 3))
            {
                LogOutputTextBox.Text += "Гіпотеза про адекватність відтвореної моделі регресії була прийнята" + Environment.NewLine;
            }
            else
            {
                LogOutputTextBox.Text += "Гіпотеза про адекватність відтвореної моделі регресії була спростована" + Environment.NewLine;
            }
            for (i = 0; i < 2000; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    Lines[i][1, j] = Math.Exp(Lines[i][1, j]);
                    Lines[i][0, j] = Math.Exp(Lines[i][0, j]);
                }
            }
            for (i = 0; i < 2000; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    chart1.Series[j + 2].Points.AddXY(Lines[i][0, j], Lines[i][1, j]);
                }
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double alfa;
            try
            {
                alfa = Convert.ToDouble(textBox11.Text);
            }
            catch
            {
                textBox11.Text = "" + 0.1;
                alfa = 0.1;
            }
            if (alfa <= 0 || alfa >= 1)
            {
                textBox11.Text = "" + 0.1;
                alfa = 0.1;
            }
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
            chart1.Series[4].Points.Clear();
            chart1.Series[5].Points.Clear();
            chart1.Series[6].Points.Clear();
            chart1.Series[7].Points.Clear();
            chart1.Series[8].Points.Clear();
            int i, j, k;
            List<double> Temp1 = new List<double>(), Temp2 = new List<double>();
            for (i = 0; i < Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].Count; i++)
            {
                Temp1.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]][i]);
                Temp2.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][1]][i]);
            }
            int CountX = ToolsForWork.CompNumOfClasses(Temp1.Count), CountY = ToolsForWork.CompNumOfClasses(Temp2.Count);
            double MaxX = double.MinValue, MaxY = double.MinValue, MinX = double.MaxValue, MinY = double.MaxValue;
            for (i = 0; i < Temp1.Count; i++)
            {
                if (Temp1[i] < MinX)
                {
                    MinX = Temp1[i];
                }
                if (Temp2[i] < MinY)
                {
                    MinY = Temp2[i];
                }
                if (Temp1[i] > MaxX)
                {
                    MaxX = Temp1[i];
                }
                if (Temp2[i] > MaxY)
                {
                    MaxY = Temp2[i];
                }
            }
            //////////////
            double Xexp, Yexp, StX, StY, KK, Kvx, Kvy, Ts, Tk;
            {
                double Sum1 = 0;
                double Sum2 = 0;
                for (i = 0; i < Temp1.Count; i++)
                {
                    Sum1 += Temp1[i];
                    Sum2 += Temp2[i];
                }
                Xexp = Sum1 / Temp1.Count;
                Yexp = Sum2 / Temp1.Count;
                if (Math.Abs(Data.EvalData.ExpValues) < 0.00000000001)
                {
                    Data.EvalData.ExpValues = 0;
                }
            }
            {
                {
                    StX = 0; StY = 0;
                    for (i = 0; i < Temp1.Count; i++)
                    {
                        // Data.EvalData.StandDevZ += Data.DataForWork[Data.CurrentSample][i] * Data.DataForWork[Data.CurrentSample][i] - Data.EvalData.ExpValues * Data.EvalData.ExpValues;
                        StX += Math.Pow((Temp1[i] - Xexp), 2);
                        StY += Math.Pow((Temp2[i] - Yexp), 2);
                    }
                    // Data.EvalData.StandDevZ *= (1.0) / Data.DataForWork[Data.CurrentSample].Count;
                    StX *= (1.0) / (Temp1.Count - 1);
                    StY *= (1.0) / (Temp2.Count - 1);
                    //Data.EvalData.StandDevZ = (Math.Sqrt(Data.EvalData.StandDevZ));
                    StX = (Math.Sqrt(StX));
                    StY = (Math.Sqrt(StY));
                }
            }

            {
                double CrosSum = 0;
                for (i = 0; i < Temp1.Count; i++)
                {
                    CrosSum += Temp1[i] * Temp2[i];
                }
                CrosSum /= Temp1.Count;
                KK = ((double)Temp1.Count / (Temp1.Count - 1)) * ((CrosSum - Xexp * Yexp) / (StX * StY));
            }
            double a, b, c;
            double x2 = 0, x3 = 0, x4 = 0;
            for (i = 0; i < Temp1.Count; i++)
            {
                x2 += Temp1[i] * Temp1[i];
                x3 += Temp1[i] * Temp1[i] * Temp1[i];
                x4 += Temp1[i] * Temp1[i] * Temp1[i] * Temp1[i];
            }
            x2 /= Temp1.Count;
            x3 /= Temp1.Count;
            x4 /= Temp1.Count;
            double SH = 0;
            for (i = 0; i < Temp1.Count; i++)
            {
                SH += (Temp1[i] * Temp1[i] - x2) * (Temp2[i] - Yexp);
            }
            SH /= Temp1.Count;
            if (radioButton5.Checked)
            {
                b = ((x4 - x2 * x2) * KK * StX * StY - (x3 - x2 * Xexp) * SH) / (StX * StX * (x4 - x2 * x2) - Math.Pow(x3 - x2 * Xexp, 2));
                c = (StX * StX * SH - (x3 - x2 * Xexp) * KK * StX * StY) / (StX * StX * (x4 - x2 * x2) - Math.Pow(x3 - x2 * Xexp, 2));
                a = Yexp - b * Xexp - c * x2;
            }
            else
            {
                a = Yexp;
                {
                    double sum1 = 0, sum2 = 0;
                    for (i = 0; i < Temp1.Count; i++)
                    {
                        sum1 += (Temp1[i] - Xexp) * Temp2[i];
                        sum2 += Math.Pow(Temp1[i] - Xexp, 2);
                    }
                    b = sum1 / sum2;
                }
                {
                    double sum1 = 0, sum2 = 0;
                    for (i = 0; i < Temp1.Count; i++)
                    {
                        sum1 += fix2(Temp1[i], Xexp, x2, x3, StX) * Temp2[i];
                        sum2 += Math.Pow(fix2(Temp1[i], Xexp, x2, x3, StX), 2);
                    }
                    c = sum1 / sum2;
                }
            }
            if (LogCheckBox.Checked)
            {
                LogOutputTextBox.Text += "Оцінка параметрів за " + ((radioButton5.Checked) ? " першим" : "другим") + " методом:" + Environment.NewLine;
                LogOutputTextBox.Text += "а = " + Math.Round(a, Data.NumberOfNum) + Environment.NewLine;
                LogOutputTextBox.Text += "b = " + Math.Round(b, Data.NumberOfNum) + Environment.NewLine;
                LogOutputTextBox.Text += "с = " + Math.Round(c, Data.NumberOfNum) + Environment.NewLine;
            }
            if (radioButton5.Checked)
            {
                for (i = 0; i < 2000; i++)
                {
                    chart1.Series[2].Points.AddXY(MinX + i * ((MaxX - MinX) / 2000), a + b * (MinX + i * ((MaxX - MinX) / 2000)) + c * Math.Pow((MinX + i * ((MaxX - MinX) / 2000)), 2));
                }
            }
            else
            {
                for (i = 0; i < 2000; i++)
                {
                    chart1.Series[2].Points.AddXY(MinX + i * ((MaxX - MinX) / 2000), a + b * fix1((MinX + i * ((MaxX - MinX) / 2000)),Xexp) + c * fix2((MinX + i * ((MaxX - MinX) / 2000)),Xexp,x2,x3,StX));
                }
            }
            double Szal = 0;
            if (radioButton5.Checked)
            {
                for (i = 0; i < Temp1.Count; i++)
                {
                    Szal += Math.Pow(Temp2[i] - a - b * Temp1[i] - c * Temp1[i] * Temp1[i], 2);
                }
                Szal /= Temp1.Count;

            }
            else
            {
                for (i = 0; i < Temp1.Count; i++)
                {
                    Szal += Math.Pow(Temp2[i] - a - b * fix1(Temp1[i],Xexp) - c * fix2(Temp1[i],Xexp,x2,x3,StX), 2);
                }
                Szal /= Temp1.Count;
            }
            double KD = (1 - Szal / (StY * StY)) * 100;
            LogOutputTextBox.Text += "Коефіціент детермінації = " + Math.Round(KD, Data.NumberOfNum) + "%" + Environment.NewLine;
            if (radioButton6.Checked)
            {
                double ta, tb, tc;
                double na, nb, nc;
                try
                {
                    na = Convert.ToDouble(textBox17.Text);
                }
                catch
                {
                    textBox17.Text = "" + 0;
                    na = 0;
                }
                try
                {
                    nb = Convert.ToDouble(textBox18.Text);
                }
                catch
                {
                    textBox18.Text = "" + 0;
                    nb = 0;
                }
                try
                {
                    nc = Convert.ToDouble(textBox19.Text);
                }
                catch
                {
                    textBox19.Text = "" + 0;
                    nc = 0;
                }
                ta = ((a - na) * Math.Sqrt(Temp1.Count)) / (Math.Sqrt(Szal));
                tb = ((b - nb) * StX * Math.Sqrt(Temp1.Count)) / (Math.Sqrt(Szal));
                {
                    double sum2 = 0;
                    for (i = 0; i < Temp1.Count; i++)
                    {
                        sum2 += Math.Pow(fix2(Temp1[i], Xexp, x2, x3, StX), 2);
                    }
                    tc = ((c - nc) * Math.Sqrt(Temp1.Count * sum2)) / (Math.Sqrt(Szal));
                }
                if (Math.Abs(ta) <= Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2))
                {
                    LogOutputTextBox.Text += "Гіпотеза про збіг параметра а з наданим значенням була підтвержена (якщо ви нічого не вводили, то була доведена гіпотеза про незначущість а)" + Environment.NewLine;
                }
                else
                {
                    LogOutputTextBox.Text += "Гіпотеза про збіг параметра а з наданим значенням не була підтвержена (якщо ви нічого не вводили, то була доведена гіпотеза про значущість а)" + Environment.NewLine;
                }
                if (Math.Abs(tb) <= Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2))
                {
                    LogOutputTextBox.Text += "Гіпотеза про збіг параметра b з наданим значенням була підтвержена (якщо ви нічого не вводили, то була доведена гіпотеза про незначущість а)" + Environment.NewLine;
                }
                else
                {
                    LogOutputTextBox.Text += "Гіпотеза про збіг параметра b з наданим значенням не була підтвержена (якщо ви нічого не вводили, то була доведена гіпотеза про значущість а)" + Environment.NewLine;
                }
                if (Math.Abs(tc) <= Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2))
                {
                    LogOutputTextBox.Text += "Гіпотеза про збіг параметра c з наданим значенням була підтвержена (якщо ви нічого не вводили, то була доведена гіпотеза про незначущість а)" + Environment.NewLine;
                }
                else
                {
                    LogOutputTextBox.Text += "Гіпотеза про збіг параметра c з наданим значенням не була підтвержена (якщо ви нічого не вводили, то була доведена гіпотеза про значущість а)" + Environment.NewLine;
                }

                tb = ((b - 0) * StX * Math.Sqrt(Temp1.Count)) / (Math.Sqrt(Szal));
                {
                    double sum2 = 0;
                    for (i = 0; i < Temp1.Count; i++)
                    {
                        sum2 += Math.Pow(fix2(Temp1[i], Xexp, x2, x3, StX), 2);
                    }
                    tc = ((c - 0) * Math.Sqrt(Temp1.Count * sum2)) / (Math.Sqrt(Szal));
                }

                if (Math.Abs(tc) <= Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2))
                {
                    LogOutputTextBox.Text += "Гіпотеза про збіг параметра с з нулем бул підтвержена. Це може свідчити про незначущість параболічної регресії. Йде подальша перевірка..." + Environment.NewLine;
                    if (Math.Abs(tb) <= Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2))
                    {
                        LogOutputTextBox.Text += "Гіпотеза про збіг параметра b з нулем також була підтвержена. Це може свідчити про незначущість поліноміального регресійнго  звязку" + Environment.NewLine;
                    }
                    else
                    {
                        LogOutputTextBox.Text += "Гіпотеза про збіг параметра b з нулем не була підтвержена. Це означає, що існує принаймні лінійний регресійний звязок" + Environment.NewLine;
                    }
                }
                else
                {
                    LogOutputTextBox.Text += "Гіпотеза про збіг параметра c з нулем не була підтвержена. Отже, можна говорити про значущість параболічного регресійного звязку" + Environment.NewLine;
                }
                double Sa, Sb, Sc;
                Sa = (Math.Sqrt(Szal)) / (Math.Sqrt(Temp1.Count));
                Sb = (Math.Sqrt(Szal)) / (StX * Math.Sqrt(Temp1.Count)); ;
                {
                    double sum2 = 0;
                    for (i = 0; i < Temp1.Count; i++)
                    {
                        sum2 += Math.Pow(fix2(Temp1[i], Xexp, x2, x3, StX), 2);
                    }
                    Sc = (Math.Sqrt(Szal)) / (Math.Sqrt(Temp1.Count * sum2));
                }
                LogOutputTextBox.Text += "Інтервальне оцінювання параметра а: " + Math.Round(a - Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2) * Sa, Data.NumberOfNum) + "<а=" + Math.Round(a, Data.NumberOfNum) + "<" + Math.Round(a + Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2) * Sa, Data.NumberOfNum) + Environment.NewLine;
                LogOutputTextBox.Text += "Інтервальне оцінювання параметра b: " + Math.Round(b - Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2) * Sb, Data.NumberOfNum) + "<b=" + Math.Round(b, Data.NumberOfNum) + "<" + Math.Round(b + Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2) * Sb, Data.NumberOfNum) + Environment.NewLine;
                LogOutputTextBox.Text += "Інтервальне оцінювання параметра с: " + Math.Round(c - Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2) * Sc, Data.NumberOfNum) + "<c=" + Math.Round(c, Data.NumberOfNum) + "<" + Math.Round(c + Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2) * Sc, Data.NumberOfNum) + Environment.NewLine;
            }
            double temp;
            if (radioButton5.Checked)
            {
                for (i = 0; i < 2000; i++)
                {
                    chart1.Series[3].Points.AddXY(MinX + i * ((MaxX - MinX) / 2000), a + b * (MinX + i * ((MaxX - MinX) / 2000)) + Math.Pow((MinX + i * ((MaxX - MinX) / 2000)), 2) * c + Math.Sqrt(Szal) * Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2));
                    chart1.Series[4].Points.AddXY(MinX + i * ((MaxX - MinX) / 2000), a + b * (MinX + i * ((MaxX - MinX) / 2000)) + Math.Pow((MinX + i * ((MaxX - MinX) / 2000)), 2) * c - Math.Sqrt(Szal) * Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2));
                }
            }
            else
            {
                double sum2 = 0;
                 for (i = 0; i < Temp1.Count; i++)
                 {
                     sum2 += Math.Pow(fix2(Temp1[i], Xexp, x2, x3, StX), 2);
                 }
                for (i = 0; i < 2000; i++)
                {
                    chart1.Series[3].Points.AddXY(MinX + i * ((MaxX - MinX) / 2000), a + b * fix1(MinX + i * ((MaxX - MinX) / 2000), Xexp) + c * fix2(MinX + i * ((MaxX - MinX) / 2000), Xexp, x2, x3, StX) + Math.Sqrt(Szal) * Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2));
                    chart1.Series[4].Points.AddXY(MinX + i * ((MaxX - MinX) / 2000), a + b * fix1(MinX + i * ((MaxX - MinX) / 2000), Xexp) + c * fix2(MinX + i * ((MaxX - MinX) / 2000), Xexp, x2, x3, StX) - Math.Sqrt(Szal) * Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2));
                    temp = ((Szal) * (Math.Sqrt(1.0 + Temp1.Count + ((Math.Pow(fix1(MinX + i * ((MaxX - MinX) / 2000), Xexp), 2)) / (StX * StX)) + ((Math.Pow(fix2(MinX + i * ((MaxX - MinX) / 2000), Xexp, x2, x3, StX), 2) / (sum2)))))) / Math.Sqrt(Temp1.Count);
                    chart1.Series[5].Points.AddXY(MinX + i * ((MaxX - MinX) / 2000), a + b * fix1(MinX + i * ((MaxX - MinX) / 2000), Xexp) + c * fix2(MinX + i * ((MaxX - MinX) / 2000), Xexp, x2, x3, StX) - temp * Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2));
                    chart1.Series[6].Points.AddXY(MinX + i * ((MaxX - MinX) / 2000), a + b * fix1(MinX + i * ((MaxX - MinX) / 2000), Xexp) + c * fix2(MinX + i * ((MaxX - MinX) / 2000), Xexp, x2, x3, StX) + temp * Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2));
                     temp = ((Szal)*(Math.Sqrt(1.0+((Math.Pow(fix1(MinX + i * ((MaxX - MinX) / 2000),Xexp),2))/(StX*StX))+((Math.Pow(fix2(MinX + i * ((MaxX - MinX) / 2000),Xexp,x2,x3,StX),2)/(sum2))))))/Math.Sqrt(Temp1.Count);
                     chart1.Series[7].Points.AddXY(MinX + i * ((MaxX - MinX) / 2000), a + b * fix1(MinX + i * ((MaxX - MinX) / 2000), Xexp) + c * fix2(MinX + i * ((MaxX - MinX) / 2000), Xexp, x2, x3, StX) - temp * Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2));
                     chart1.Series[8].Points.AddXY(MinX + i * ((MaxX - MinX) / 2000), a + b * fix1(MinX + i * ((MaxX - MinX) / 2000), Xexp) + c * fix2(MinX + i * ((MaxX - MinX) / 2000), Xexp, x2, x3, StX) + temp * Quantile.StudQuan(1 - alfa / 2, Temp1.Count - 2));

                }
            }
            double f = Szal / (StY * StY);
            if (f < Quantile.FishQuan(1 - alfa, Temp1.Count - 1, Temp1.Count - 3))
            {
                LogOutputTextBox.Text += "Гіпотеза про адекватність відтвореної моделі регресії була прийнята" + Environment.NewLine;
            }
            else
            {
                LogOutputTextBox.Text += "Гіпотеза про адекватність відтвореної моделі регресії була спростована" + Environment.NewLine;
            }
        }

        double fix1(double x, double Xs)
        {
            return x - Xs;
        }

        double fix2(double x, double x1, double x2, double x3, double DX)
        {
            return x*x-(((x3-x2*x1)*(x-x1))/(DX*DX))-x2;
        }

        private void відкритиБагатовимірнуВибіркуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Mistaken = false;
            ArgIntMM NumberOfDimentions = new ArgIntMM(3, "", "Кількість вимірів", "Кількість вимірів у вибіці, що ви бажаєте відкрити", "<>");
            NumberOfDimentions.setMin(1);
            OkCancelDlg it = new OkCancelDlg("Визначення кількості вимірів вибірки", null
                                , NumberOfDimentions
                                );
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                OpenFileDialog OpeningDialog = new OpenFileDialog();
                OpeningDialog.InitialDirectory = Application.StartupPath.ToString();
                OpeningDialog.Filter = "txt files (*.txt)|*.txt| dat files (*.dat)|*.dat";
                OpeningDialog.FilterIndex = 1;
                OpeningDialog.RestoreDirectory = true;
                if (OpeningDialog.ShowDialog() == DialogResult.OK)
                {
                    //this.ProgressBar.Step = 100;
                    //this.ProgressBar.PerformStep();
                    //this.ProgressBar.Value = 50;
                    Data.TwoDemCurrentSample.set(Data.TwoDemSamples.Count);
                    Data.CurrentSample.set(Data.DataForWork.Count);
                    Data.MultiDemCurrentSample.set(Data.MultiDemSamples.Count);
                    for (int i = 0; i < NumberOfDimentions; i++)
                    {
                        Data.DataForWork.Add(new List<double>());
                    }
                    int j;
                    try
                    {
                        string[] FileLikeStrings = File.ReadAllLines(OpeningDialog.FileName);
                        char[] separators = new char[] { ' ', '\t', '\n' };
                        string[] valuesInLine;
                        int DimSamples = ToolsForWork.FindMinLength(FileLikeStrings);
                        if (DimSamples == 2 || NumberOfDimentions == 2)
                        {
                            LogOutputTextBox.Text += "Maybe u shall try to open this one as two dimentional file?" + Environment.NewLine;
                        }
                        if (DimSamples < NumberOfDimentions)
                        {
                            LogOutputTextBox.Text += "Theres not enough columns on your file" + Environment.NewLine;
                            return;
                        }

                            for (int i = 0; i < FileLikeStrings.Length; i++)
                            {
                                ToolsForWork.RemoveComments(ref FileLikeStrings[i]);
                                valuesInLine = FileLikeStrings[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                                Mistaken = false;
                                for (j = 0; j < NumberOfDimentions; j++)
                                {
                                    double x;
                                    try
                                    {
                                        x = Convert.ToDouble(valuesInLine[j]);
                                    }
                                    catch
                                    {
                                        try
                                        {
                                            valuesInLine[j] = valuesInLine[j].Replace(".", ",");
                                            x = Convert.ToDouble(valuesInLine[j]);
                                        }
                                        catch
                                        {
                                            if (LogCheckBox.Checked == true)
                                                LogOutputTextBox.Text += "Theres mistake in string #" + i + Environment.NewLine;
                                            Mistaken = true;
                                            break;
                                        }
                                    }
                                    Data.DataForWork[Data.CurrentSample + j].Add(x);
                                }
                                if (Mistaken)
                                {
                                    //j--;
                                    for (int k = 0; k < j; k++)
                                    {
                                        Data.DataForWork[Data.CurrentSample + k].RemoveAt(Data.DataForWork[Data.CurrentSample + k].Count - 1);
                                    }
                                }
                            }
                        for (; Data.CurrentSample < Data.DataForWork.Count; Data.CurrentSample.set(Data.CurrentSample + 1))
                        {
                            Data.NamesOfFiles.Add(OpeningDialog.FileName);
                            Data.StepBack.Add(new List<ToolsForWork.Changing>());
                            //Data.DataForWork[Data.CurrentSample].Sort();
                        }
                        for (Data.CurrentSample.set(Data.DataForWork.Count - 1); Data.CurrentSample > 0 && (Data.DataForWork.Count != 0); Data.CurrentSample.set(Data.CurrentSample - 1))
                        {
                            if (Data.DataForWork[Data.CurrentSample].Count == 0)
                            {
                                // LogOutputTextBox.Text += "File is empty" + Environment.NewLine;
                                Data.DataForWork.RemoveAt(Data.CurrentSample);
                                Data.StepBack.RemoveAt(Data.CurrentSample);
                                Data.NamesOfFiles.RemoveAt(Data.CurrentSample);
                            }
                        }
                        //Data.DataForWork[Data.CurrentSample].Sort();
                        //Data.NamesOfFiles.Add(OpeningDialog.FileName);
                       // Data.StepBack.Add(new List<ToolsForWork.Changing>());
                        StatusLabelNameOfFile.Text = Data.NamesOfFiles[Data.CurrentSample];
                        HistData.NumberOfClassesChangedByUser = false;
                        DistrFuncData.NumberOfClassesChangedByUser = false;
                        Data.DistrCreated = false;
                        if (Data.DataForWork.Count != 0)
                        {
                            int[] temp = new int[(int)NumberOfDimentions];
                            for (j = 0; j < NumberOfDimentions; j++)
                            {
                                temp[j] = Data.DataForWork.Count - NumberOfDimentions + j;
                            }
                            Data.MultiDemSamples.Add(temp);
                            Data.MultiDemStepBack.Add(new List<ToolsForWork.Changing>());
                            Data.CurrentSample.set(Data.DataForWork.Count - NumberOfDimentions);
                            Data.TwoDemCurrentSample.set(Data.TwoDemSamples.Count-1);
                            Data.MultiDemCurrentSample.set(Data.MultiDemSamples.Count - 1);
                            Build();
                            BuildMultiDem();
                        }
                    }
                    catch (Exception ExThatOccured)
                    {
                        LogOutputTextBox.Text += ("Error happened while reading the file. Original error: " + ExThatOccured.Message + Environment.NewLine);
                    }
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            ArgInt Num1 = new ArgInt(1, "", "Номер вибірки", "Вибір вибірки, яка буде відповідати першій регресії", "<Size>");
            ArgInt Num2 = new ArgInt(2, "", "Номер вибірки", "Вибір вибірки, яка буде відповідати другій регресії", "<Size>");
            OkCancelDlg it = new OkCancelDlg("Виберіть вибірки для перевірки збігу регресій", null, Num1, Num2);
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                if ((Num1 < 1) || (Num2 < 1) || (Num1 > Data.TwoDemSamples.Count) || (Num2 > Data.TwoDemSamples.Count))
                {
                    LogOutputTextBox.Text += "Невірно заданий номер розподілу " + Environment.NewLine;
                    return;
                }
                
            }
        }

        private void багатовимірнийНормальнийРозподілToolStripMenuItem_Click(object sender, EventArgs e)
        {
             ArgIntMM NumberOfElements = new ArgIntMM(100, "", "Кількість елементів", "Кількість елементів", "<>");
             ArgIntMM NumberOfDimentions = new ArgIntMM(3, "", "Кількість вимірів", "Кількість вимірів", "<>");
            NumberOfElements.setMin(1);
            NumberOfDimentions.setMin(3);
            OkCancelDlg it = new OkCancelDlg("Сторення двовимірного нормального розподілу", null
                                , NumberOfElements
                                , NumberOfDimentions
                                );
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                double[,] matrixDC = new double[NumberOfDimentions, NumberOfDimentions];
                double[,] matrixExp = new double[NumberOfDimentions,1];
                TableForMultiDem Temp = new TableForMultiDem(NumberOfDimentions, matrixDC,0);
                Temp.ShowDialog();
                if (Temp.DialogResult == DialogResult.Abort)
                {
                    LogOutputTextBox.Text += ("Error occured while creating mulidimentional sample. Mb wrong input. " + Environment.NewLine);
                    return;
                }
                int i,j,k;
                for (i = 0; i < NumberOfDimentions; i++)
                {
                    if (matrixDC[i, i] <= 0)
                    {
                        LogOutputTextBox.Text += ("Wrong DC " + Environment.NewLine);
                        return;
                    }
                }
                Temp = new TableForMultiDem(NumberOfDimentions, matrixExp, 1);
                Temp.ShowDialog();
                if (Temp.DialogResult == DialogResult.Abort)
                {
                    LogOutputTextBox.Text += ("Error occured while creating mulidimentional sample. Mb wrong input. " + Environment.NewLine);
                    return;
                }
                double[,] A = new double[NumberOfDimentions, NumberOfDimentions];
                double [,] U = new double[NumberOfDimentions,1];
                double[,] newX = new double[NumberOfDimentions, 1];
                double[,] Tem = new double[NumberOfDimentions, 1];
                double sum;
                for (i = 0; i < NumberOfDimentions; i++)
                {
                    for (j = 0; j < NumberOfDimentions; j++)
                    {
                        if (i < j)
                        {
                            A[i, j] = 0;
                        }
                        else
                        {
                            sum = 0;
                            if (i == j)
                            {
                                for (k = 0; k < i; k++)
                                {
                                    sum += A[i, k] * A[i, k];
                                }
                                A[i, j] = Math.Sqrt(matrixDC[i, j]-sum);
                            }
                            else
                            {
                                for (k = 0; k < j; k++)
                                {
                                    sum += A[i, k] * A[j, k];
                                }
                                A[i, j] = (matrixDC[i, j] - sum)/(A[j,j]);
                            }

                        }
                    }
                }
                double x,y,s, result;
                Random a = new Random(), b = new Random(), c = new Random();
                int[] TempAr = new int[NumberOfDimentions];
                for (i = 0; i < NumberOfDimentions; i++)
                {
                    TempAr[i] = Data.DataForWork.Count;
                    Data.DataForWork.Add(new List<double>());
                    Data.NamesOfFiles.Add("Автоматично сгенерований багатовимірний нормальний розподіл, " + (int)NumberOfElements + ", μx = " + (float)matrixExp[i,0] + ", " + (i+1) + " вимір");
                    Data.StepBack.Add(new List<ToolsForWork.Changing>());
                }
                Data.CurrentSample.set(Data.DataForWork.Count-NumberOfDimentions);
                Data.MultiDemStepBack.Add(new List<ToolsForWork.Changing>());
                Data.MultiDemSamples.Add(TempAr);
                for (k = 0; k < NumberOfElements; k++)
                {
                    for (i = 0; i < NumberOfDimentions; i++)
                    { 
                        x = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
                        y = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
                        s = x * x + y * y;
                        if ((s == 0) || (s > 1))
                        {
                            i--;
                            continue;
                        }
                        U[i,0] = y * Math.Pow(((-2 * Math.Log(s)) / s), 0.5);
                    }
                    for (i = 0; i < NumberOfDimentions; i++)
                    {
                        sum = 0;
                        for (j = 0; j < NumberOfDimentions; j++)
                        {
                            sum += A[i, j] * U[j, 0];
                        }
                        Data.DataForWork[Data.DataForWork.Count - NumberOfDimentions + i].Add(matrixExp[i,0]+sum);
                    }
                }
                StatusLabelNameOfFile.Text = Data.NamesOfFiles[Data.CurrentSample];
                Data.DistrCreated = false;
                Build();
                Data.MultiDemCurrentSample.set(Data.MultiDemSamples.Count - 1);
                BuildMultiDem();
            }
            /*

                if (SigmaX <= 0 || SigmaY <= 0)
                {
                    LogOutputTextBox.Text += "Невірне значення σ " + Environment.NewLine;
                    return;
                }
                if (KK < -1 || KK > 1)
                {
                    LogOutputTextBox.Text += "Невірне значення r " + Environment.NewLine;
                    return;
                }
                Data.DataForWork.Add(new List<double>());
                Data.DataForWork.Add(new List<double>());
                Data.CurrentSample.set(Data.DataForWork.Count - 2);
                Random a = new Random();
                Random b = new Random();
                Random c = new Random();
                double result1, result2, x, y, s;
                for (int i = 0; i < (int)NumberOfElements; i++)
                {
                    x = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
                    y = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
                    s = x * x + y * y;
                    if ((s == 0) || (s > 1))
                    {
                        i--;
                        continue;
                    }
                    result1 = y * Math.Pow(((-2 * Math.Log(s)) / s), 0.5);
                    x = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
                    y = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
                    s = x * x + y * y;
                    if ((s == 0) || (s > 1))
                    {
                        i--;
                        continue;
                    }
                    result2 = y * Math.Pow(((-2 * Math.Log(s)) / s), 0.5);
                    Data.DataForWork[Data.CurrentSample].Add(((float)ExpValX + result1 * (float)SigmaX));
                    Data.DataForWork[Data.CurrentSample + 1].Add(((float)ExpValY + (result2 * Math.Sqrt(1 - KK * KK) + result1 * KK) * (float)SigmaY));

                }
                //Data.DataForWork[Data.CurrentSample].Sort();
                Data.NamesOfFiles.Add("Автоматично сгенерований двовимірний нормальний розподіл, " + (int)NumberOfElements + " елементів, σx = " + (float)SigmaX + ", μx = " + (float)ExpValX + "1 вимір");
                Data.NamesOfFiles.Add("Автоматично сгенерований двовимірний нормальний розподіл, " + (int)NumberOfElements + " елементів, σy = " + (float)SigmaY + ", μy = " + (float)ExpValY + "2 вимір");
                Data.StepBack.Add(new List<ToolsForWork.Changing>());
                Data.StepBack.Add(new List<ToolsForWork.Changing>());
                StatusLabelNameOfFile.Text = Data.NamesOfFiles[Data.CurrentSample];
                Data.DistrCreated = false;
                Build();
                Data.TwoDemStepBack.Add(new List<ToolsForWork.Changing>());
                Data.TwoDemSamples.Add(new int[] { Data.DataForWork.Count - 2, Data.DataForWork.Count - 1 });
                Data.TwoDemCurrentSample.set(Data.TwoDemSamples.Count - 1);
                BuildTwoDem();
            }*/
        }

        private void вибратиБагатовимірнуВибіркуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int temp = Data.MultiDemCurrentSample;
            Data.MultiDemCurrentSample.set(Data.MultiDemCurrentSample + 1);
            OkCancelDlg it = new OkCancelDlg("Виберіть вибірку", null, Data.MultiDemCurrentSample);
            DialogResult rc = it.ShowDialog();
            Data.MultiDemCurrentSample.set(Data.MultiDemCurrentSample - 1);
            if (rc == DialogResult.OK)
            {
                if ((Data.MultiDemCurrentSample < 0) || (Data.MultiDemCurrentSample >= Data.MultiDemSamples.Count))
                {
                    LogOutputTextBox.Text += "Вибірки з таким номером не існує " + Environment.NewLine;
                    Data.MultiDemCurrentSample.set(temp);
                    return;
                }
                // StatusLabelNameOfFile.Text = Data.NamesOfFiles[Data.CurrentSample];
                //   HistData.NumberOfClassesChangedByUser = false;
                //  DistrFuncData.NumberOfClassesChangedByUser = false;
                //   Data.DistrCreated = false;
                BuildMultiDem();
            }
        }

        private void видалитиБагатовимірнуВибіркуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Data.DataForWork.Count <= 0 || Data.MultiDemSamples.Count == 0)
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Нема з чим працювати " + Environment.NewLine;
                return;
            }
            int temp = Data.MultiDemCurrentSample;
            Data.MultiDemCurrentSample.set(Data.MultiDemCurrentSample + 1);
            OkCancelDlg it = new OkCancelDlg("Виберіть вибірку для видалення", null, Data.MultiDemCurrentSample);
            DialogResult rc = it.ShowDialog();
            Data.MultiDemCurrentSample.set(Data.MultiDemCurrentSample - 1);
            if (rc == DialogResult.OK)
            {
                if ((Data.MultiDemCurrentSample < 0) || (Data.MultiDemCurrentSample >= Data.MultiDemSamples.Count))
                {
                    LogOutputTextBox.Text += "Вибірки з таким номером не існує " + Environment.NewLine;
                    return;
                }
                //Data.TwoDemNamesOfFiles.RemoveAt(Data.TwoDemCurrentSample);
                Data.MultiDemSamples.RemoveAt(Data.MultiDemCurrentSample);
                Data.MultiDemStepBack.RemoveAt(Data.MultiDemCurrentSample);
                if (Data.MultiDemSamples.Count == 0)
                {
                    dataGridView5.Rows.Clear();
                    dataGridView6.Rows.Clear();
                    dataGridView5.Columns.Clear();
                    dataGridView6.Columns.Clear();
                    dataGridView7.Columns.Clear();
                    dataGridView7.Rows.Clear();
                    dataGridView8.Rows.Clear();
                    dataGridView8.Columns.Clear();
                    dataGridView9.Rows.Clear();
                    dataGridView9.Columns.Clear();
                    chart5.Series[0].Points.Clear();
                    dataGridView13.Rows.Clear();
                    dataGridView12.Rows.Clear();
                    tableLayoutPanel1.ColumnStyles.Clear();
                    tableLayoutPanel1.RowStyles.Clear();
                    tableLayoutPanel1.Controls.Clear();
                    comboBox4.Items.Clear();
                    pictureBox1.Image = null;
                    DataGridForChkk = null;
                }
                else
                {
                    if (Data.MultiDemCurrentSample == temp)
                        Data.MultiDemCurrentSample.set(0);
                    else
                    {
                        if (temp < Data.MultiDemCurrentSample)
                        {
                            Data.MultiDemCurrentSample.set(temp);
                        }
                        else
                        {
                            Data.MultiDemCurrentSample.set(temp-1);
                        }
                    }
                    BuildMultiDem();
                }
            }
        }

        private void обєднатиУБагатовимірнуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArgInt NumOfDims = new ArgInt(3, "", "Кількість вимірів", "Вибір кількості вимірів, які будуть у новій багатовимірній вибірці", "<Size>");
            OkCancelDlg it = new OkCancelDlg("Введіть кількість вимірів", null, NumOfDims);
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                if ((NumOfDims < 2) || (NumOfDims > Data.DataForWork.Count))
                {
                    LogOutputTextBox.Text += "На жаль, створити таку вибірку на даний момент неможливо" + Environment.NewLine;
                    return;
                }
                Arg[] ArrayOfNumbers = new Arg[NumOfDims];
                for (int i = 0; i < NumOfDims; i++)
                {
                    ArrayOfNumbers[i] = new ArgInt(i + 1, "", "Номер вибірки", "Вибір вибірки, яка стане частиною нової багатовимірної вибірки", "<Size>");
                }
                it = new OkCancelDlg("Виберіть вибірки для поєднання у багатовимірну", null, ArrayOfNumbers);
                rc = it.ShowDialog();
                if (rc == DialogResult.OK)
                {
                    int[] Targ = new int[NumOfDims];
                    for (int i = 0; i < NumOfDims; i++)
                    {
                        if (((ArrayOfNumbers[i] as ArgInt) < 1) || ((ArrayOfNumbers[i] as ArgInt) > Data.DataForWork.Count))
                        {
                            LogOutputTextBox.Text += "Невірно заданий номер " + Environment.NewLine;
                            return;
                        }
                        Targ[i] = (ArrayOfNumbers[i] as ArgInt)-1;
                    }
                    Data.MultiDemStepBack.Add(new List<ToolsForWork.Changing>());
                    Data.MultiDemSamples.Add(Targ);
                    Data.MultiDemCurrentSample.set(Data.MultiDemSamples.Count - 1);
                    BuildMultiDem();
                }
            }
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            BuildBubble();
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            BuildBubble();
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            BuildBubble();
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            int target;
            try
            {
                target = Convert.ToInt32(textBox23.Text);
            }
            catch
            {
                target = 0;
                return;
            }
            if (target <= 0 || target > Data.MultiDemSamples[Data.MultiDemCurrentSample].Length - 2)
            {
                target = 0;
                textBox23.Text = ""+0;
            }
            dataGridView10.Rows.Clear();
            for (int i = 0; i < target; i++)
            {
                dataGridView10.Rows.Add();
            }
        }

        private void comboBox4_SelectedValueChanged(object sender, EventArgs e)
        {
            int NewGrid;
            try
            {
                NewGrid = Convert.ToInt32((sender as ComboBox).SelectedItem);
            }
            catch
            {
                LogOutputTextBox.Text += "Wrong name";
                return;
            }
            ToolsForWork.FillDGVText(dataGridView9,DataGridForChkk[NewGrid - 1]);
            dataGridView9.Refresh();
            this.groupBox9.Refresh();
            this.groupBox9.Invalidate();
            this.dataGridView9.Invalidate();
            /*this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).BeginInit();
            dataGridView9.Invalidate();
            this.groupBox9.Controls.Add(this.dataGridView9);
            this.dataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView9.Location = new System.Drawing.Point(7, 20);
            this.dataGridView9.Name = "dataGridView9";
            this.dataGridView9.Size = new System.Drawing.Size(573, 374);
            this.dataGridView9.TabIndex = 0;
            this.groupBox9.Controls.Add(dataGridView9);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).EndInit();
          //  dataGridView9.Refresh();
            this.groupBox9.Refresh();
            this.groupBox9.Invalidate();
            //this.dataGridView9.Invalidate();*/

        }

        private void button31_Click(object sender, EventArgs e)
        {
            int FV, SV;
            List<int> Temp = new List<int>();
            if (Data.MultiDemSamples.Count == 0)
            {
                LogOutputTextBox.Text += "Безсенсно" + Environment.NewLine;
                return;
            }
           double alfa = 0.05;
            try
            {
                alfa = Convert.ToDouble(textBox27.Text);
                FV = Convert.ToInt32(textBox21.Text);
                SV = Convert.ToInt32(textBox22.Text);
                FV--;
                SV--;
                if (SV < 0 || FV < 0 || SV >= Data.MultiDemSamples[Data.MultiDemCurrentSample].Length || FV >= Data.MultiDemSamples[Data.MultiDemCurrentSample].Length||FV==SV)
                {
                    throw new Exception();
                }
                for (int i = 0; i < dataGridView10.Rows.Count; i++)
                {
                    Temp.Add(Convert.ToInt32(dataGridView10.Rows[i].Cells[0].Value));
                    Temp[i]--;
                    if (Temp[i] < 0 || Temp[i] >= Data.MultiDemSamples[Data.MultiDemCurrentSample].Length)
                    {
                        LogOutputTextBox.Text += "Wrong number for cc" + Environment.NewLine;
                        return;
                    }
                }
            }
            catch
            {
                LogOutputTextBox.Text += "Wrong number for cc" + Environment.NewLine;
                return;
            }
            if (Temp.Count == 0)
            {
                LogOutputTextBox.Text += "It doesnt work like this" + Environment.NewLine;
                return;
            }
            int j;
            for (int i = 0; i < dataGridView10.Rows.Count; i++)
            {
                if (SV == Temp[i] || Temp[i] == FV)
                {
                    LogOutputTextBox.Text += "Wrong number for cc" + Environment.NewLine;
                    return;
                }
                for (j = i + 1; j < dataGridView10.Rows.Count; j++)
                {
                    if (Temp[i] == Temp[j])
                    {
                        LogOutputTextBox.Text += "Wrong number for cc" + Environment.NewLine;
                        return;
                    }
                }
            }
                if (alfa <= 0 || alfa >= 1)
                {
                    alfa = 0.05;
                    textBox27.Text = "" + 0.05;
                }
            double result = FindChkk(FV, SV, Temp);
            double Hip = (result*Math.Sqrt(Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count - Temp.Count - 2 ))/(1-result*result);
            LogOutputTextBox.Text += "Ваш частковій кк = " + Math.Round(result,Data.NumberOfNum) + Environment.NewLine;
            if (Math.Abs(Hip) < Quantile.StudQuan(alfa, Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count - Temp.Count - 2))
            {
                LogOutputTextBox.Text += "t-тест не пройдено, даний чкк є незначущим" + Environment.NewLine;
            }
            else
            {
                LogOutputTextBox.Text += "t-тест пройдено, даний чкк є значущим" + Environment.NewLine;
            }
            LogOutputTextBox.Text += "Довірчі інтервали" + Environment.NewLine;
            double v1, v2;
            v1 = 0.5 * Math.Log((1 + result) / (1 - result)) - Quantile.StanQuanDv(alfa / 2) / (Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count - Temp.Count - 3);
            v2 = 0.5 * Math.Log((1 + result) / (1 - result)) + Quantile.StanQuanDv(alfa / 2) / (Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count - Temp.Count - 3);
            LogOutputTextBox.Text += "" + Math.Round((Math.Exp(2 * v1) - 1) / (Math.Exp(2 * v1) + 1), Data.NumberOfNum) + "<=" + Math.Round(result, Data.NumberOfNum) + "<=" + Math.Round((Math.Exp(2 * v2) - 1) / (Math.Exp(2 * v2) + 1), Data.NumberOfNum) + Environment.NewLine;
            
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView9.Columns.Count == 0)
            {
                return;
            }
            if ((sender as RadioButton).Checked)
            {
                int i, j,k;
                double result, quan, Hip;
                for (i = 0; i < Data.MultiDemSamples[Data.MultiDemCurrentSample].Length; i++)
                {
                   
                    for (k = 0; k < Data.MultiDemSamples[Data.MultiDemCurrentSample].Length; k++)
                    {
                        for (j = 0; j < Data.MultiDemSamples[Data.MultiDemCurrentSample].Length; j++)
                        {
                            if (k == i || j == i)
                            {
                                DataGridForChkk[i].Rows[k].Cells[j].Value = "-";
                                continue;
                            }
                            if (k == j)
                            {
                                DataGridForChkk[i].Rows[k].Cells[k].Value = "1";
                                continue;
                            }
                            else
                            {
                                result = Convert.ToDouble(DataGridForChkk[i].Rows[k].Cells[j].Value);
                                quan = Quantile.StudQuan(0.95, Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count -3);
                                Hip = (result * Math.Sqrt(Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count - 3)) / (1 - result * result);
                                if (Math.Abs(Hip) < quan)
                                {
                                    DataGridForChkk[i].Rows[k].Cells[j].Style.BackColor = Color.DarkGray;
                                }
                                else
                                {
                                    DataGridForChkk[i].Rows[k].Cells[j].Style.BackColor = Color.White;
                                }
                            }
                        }
                    }
                    

                }
                int NewGrid;
                try
                {
                    NewGrid = Convert.ToInt32(comboBox4.SelectedItem);
                }
                catch
                {
                    LogOutputTextBox.Text += "Wrong name";
                    return;
                }
                if (NewGrid == 0)
                    NewGrid++;
                ToolsForWork.FillDGVText(dataGridView9, DataGridForChkk[NewGrid - 1]);
                dataGridView9.Refresh();
                this.groupBox9.Refresh();
                this.groupBox9.Invalidate();
                this.dataGridView9.Invalidate();
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView9.Columns.Count == 0)
            {
                return;
            }
            if ((sender as RadioButton).Checked)
            {
                int i, j, k;
                double result, quan, Hip;
                for (i = 0; i < Data.MultiDemSamples[Data.MultiDemCurrentSample].Length; i++)
                {

                    for (k = 0; k < Data.MultiDemSamples[Data.MultiDemCurrentSample].Length; k++)
                    {
                        for (j = 0; j < Data.MultiDemSamples[Data.MultiDemCurrentSample].Length; j++)
                        {
                            if (k == i || j == i)
                            {
                                DataGridForChkk[i].Rows[k].Cells[j].Value = "-";
                                continue;
                            }
                            if (k == j)
                            {
                                DataGridForChkk[i].Rows[k].Cells[k].Value = "1";
                                continue;
                            }
                            else
                            {
                                result = Convert.ToDouble(DataGridForChkk[i].Rows[k].Cells[j].Value);
                                quan = Quantile.StudQuan(0.95, Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count - 3);
                                Hip = ((result - Convert.ToDouble(dataGridView6.Rows[k].Cells[j].Value)) * Math.Sqrt(Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count - 3)) / (1 - result * result);
                                if (Math.Abs(Hip) < quan)
                                {
                                    DataGridForChkk[i].Rows[k].Cells[j].Style.BackColor = Color.DarkGray;
                                }
                                else
                                {
                                    DataGridForChkk[i].Rows[k].Cells[j].Style.BackColor = Color.White;
                                }
                            }
                        }
                    }


                }
                int NewGrid;
                try
                {
                    NewGrid = Convert.ToInt32(comboBox4.SelectedItem);
                }
                catch
                {
                    LogOutputTextBox.Text += "Wrong name";
                    return;
                }
                if (NewGrid == 0)
                    NewGrid++;
                ToolsForWork.FillDGVText(dataGridView9, DataGridForChkk[NewGrid - 1]);
                dataGridView9.Refresh();
                this.groupBox9.Refresh();
                this.groupBox9.Invalidate();
                this.dataGridView9.Invalidate();
            }
        }

        /*private void FillDeepList(int iterator, object target, int Length)
        {
            if (iterator == 0)
            {
                target = new List<double>();
                (target as List<double>).Add(0.0);
            }
            else
            {
                target = new List<object>();
                for (int l = 0; l < Length; l++)
                {
                    (target as List<object>).Add(new object());
                    FillDeepList(iterator-1, (target as List<object>)[l],  Length);
                }
            }
        }*/

       /* private void IncValueInDeepList(object target, int[] Counters)
        {
            if (Counters.Length == 0)
            {
                (target as List<double>)[0]++;
            }
            else
            {
                int[] TempArr = new int[Counters.Length - 1];
                for (int i = 1; i < Counters.Length; i++)
                {
                    TempArr[i - 1] = Counters[i];
                }
                IncValueInDeepList((target as List<object>)[Counters[0]], TempArr);
            }
        }*/

      /*  private void SetValueInDeepList(object target, int[] Counters, double Value)
        {
            if (Counters.Length == 0)
            {
                (target as List<double>)[0] = Value;
            }
            else
            {
                int[] TempArr = new int[Counters.Length - 1];
                for (int i = 1; i < Counters.Length; i++)
                {
                    TempArr[i - 1] = Counters[i];
                }
                SetValueInDeepList((target as List<object>)[Counters[0]], TempArr, Value);
            }
        }*/

       /* private double GetValueInDeepList(object target, int[] Counters)
        {
            if (Counters.Length == 0)
            {
                return (target as List<double>)[0];
            }
            else
            {
                int[] TempArr = new int[Counters.Length - 1];
                for (int i = 1; i < Counters.Length; i++)
                {
                    TempArr[i - 1] = Counters[i];
                }
                return GetValueInDeepList((target as List<object>)[Counters[0]], TempArr);
            }
        }*/

        private void button30_Click(object sender, EventArgs e)
        {
            if (Data.DataForWork.Count == 0 || Data.MultiDemSamples.Count == 0)
            {
                LogOutputTextBox.Text += "Nothing to work with" + Environment.NewLine;
                return;
            }
            int i, j, k;
            double[] ExpVals = new double[Data.MultiDemSamples[Data.MultiDemCurrentSample].Length];
            double Alfa;
            try
            {
                Alfa = Convert.ToDouble(textBox20.Text);
            }
            catch
            {
                Alfa = 0.05;
                textBox20.Text = "0,01";
            }
            if (Alfa <= 0 || Alfa >= 1)
            {
                Alfa = 0.05;
                textBox20.Text = "0,01";
            }
            /////
            int DimNum = Data.MultiDemSamples[Data.MultiDemCurrentSample].Length;
            int[] temp = new int[DimNum];
            int NumberOfPoints = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count;
            int ClassNumber = ToolsForWork.CompNumOfClasses(NumberOfPoints);
            for (i = 0; i < DimNum; i++)
            {
                temp[i] = ClassNumber;
            }
            var VarR = Array.CreateInstance(typeof(int), temp);
            ////
            int Sum = 0;
            i = 0;
            string temps;
            double[] Maxs = new double[DimNum];
            double[] Mins = new double[DimNum];
            for (j = 0; j < DimNum; j++)
            {
                Maxs[j] = double.MinValue;
                Mins[j] = double.MaxValue;
            }
            for (j = 0; j < NumberOfPoints; j++)
            {
                for (k = 0; k < DimNum; k++)
                {
                    if (Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][j] > Maxs[k])
                    {
                        Maxs[k] = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][j];
                    }
                    if (Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][j] < Mins[k])
                    {
                        Mins[k] = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][j];
                    }
                }
            }
            for (k = 0; k < DimNum; k++)
            {
                Maxs[k] += ((double)Maxs[k] - Mins[k]) / 10000;
            }
            List<int> ToDelete = new List<int>();
            int Counter;
            int Deleted = 0;
            foreach (int item in VarR)
            {
                int[] coor = ComputeIndex(i++, VarR);
                temps = "";
                for (j = coor.Length - 1; j > 0; j--)
                {
                    temps += coor[j] + "|";
                }
                temps += coor[0];
                VarR.SetValue(0, coor);
                for (j = 0; j < Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count; j++)
                {
                    Counter = 0;
                    for (k = 0; k < DimNum; k++)
                    {
                        if ((Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][j] >= (Mins[k] + ((Maxs[k] - Mins[k]) / ClassNumber) * coor[k])) && (Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][j] < (Mins[k] + ((Maxs[k] - Mins[k]) / ClassNumber) * (coor[k] + 1))))
                        {
                            Counter++;
                        }
                    }
                    if (Counter == DimNum)
                    {
                        Sum++;
                        VarR.SetValue(1 + Convert.ToInt32(VarR.GetValue(coor)), coor);
                    }
                }
                if ((Convert.ToDouble(VarR.GetValue(coor)) / NumberOfPoints) < Alfa)
                {
                    for (j = 0; j < Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count; j++)
                    {
                        Counter = 0;
                        for (k = 0; k < DimNum; k++)
                        {
                            if ((Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][j] >= (Mins[k] + ((Maxs[k] - Mins[k]) / ClassNumber) * coor[k])) && (Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][j] < (Mins[k] + ((Maxs[k] - Mins[k]) / ClassNumber) * (coor[k] + 1))))
                            {
                                Counter++;
                            }
                        }
                        if (Counter == DimNum)
                        {
                            ToDelete.Add(j);
                        }
                    }
                }
                //////////
                for (k = ToDelete.Count - 1; k >= 0; k--)
                {
                    double[] FW = new double[DimNum];
                    for (j = 0; j < DimNum; j++)
                    {
                        FW[j] = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][j]][ToDelete[k]];
                        Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][j]].RemoveAt(ToDelete[k]);
                    }
                    ToDelete.RemoveAt(k);
                    Deleted++;
                    Data.MultiDemStepBack[Data.MultiDemCurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.multidemdeleted, FW));
                }
                //////////
            }
            if (Sum != NumberOfPoints)
            {
                LogOutputTextBox.Text += " Something bad happned. Weve counted only" + Sum + " elements" +Environment.NewLine;
            }
            LogOutputTextBox.Text+=  "Успішно відилалено " + Deleted + " елементів" +Environment.NewLine;
            ////
            UpdateForm();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (Data.DataForWork.Count == 0 || Data.MultiDemSamples.Count == 0)
            {
                LogOutputTextBox.Text += "Nothing to work with" + Environment.NewLine;
                return;
            }
            int i,j,k;
            double[] ExpVals = new double[Data.MultiDemSamples[Data.MultiDemCurrentSample].Length];
            double Alfa;
            try
            {
                Alfa = Convert.ToDouble(textBox20.Text);
            }
            catch
            {
                Alfa = 0.05;
                textBox20.Text = "0,05";
            }
            if(Alfa<=0||Alfa>=1)
            {
                Alfa = 0.05;
                textBox20.Text = "0,05";
            }

            /////////////////
           // LogOutputTextBox.Text += "This part is currently unaviable. Please try later" + Environment.NewLine;
            //return;
            double[][] R = new double[dataGridView6.Rows.Count][];
            for (i = 0; i < dataGridView6.Rows.Count; i++)
            {
                ExpVals[i] = Convert.ToDouble(dataGridView7.Rows[i].Cells[0].Value);
                R[i] = new double[dataGridView6.Rows.Count];
            }
            for (i = 0; i < dataGridView6.Rows.Count; i++)
            {
                for (j = 0; j < dataGridView6.Rows.Count; j++)
                {
                    R[i][j] = Convert.ToDouble(dataGridView6.Rows[i].Cells[j].Value);
                }
            }
            double det = Matrixes.GetDet(R);
            double[,] RT = new double[dataGridView6.Rows.Count, dataGridView6.Rows.Count];
            for (i = 0; i < dataGridView6.Rows.Count; i++)
            {
                for (j = 0; j < dataGridView6.Rows.Count; j++)
                {
                    RT[i,j] = R[i][j];
                }
            }
            if (Math.Abs(det) < 0.005)
            {
                LogOutputTextBox.Text += "На жаль, кореляційна матриця вироджена. Перевірка на належність до класу багатовимірних нормальних розподілів не пройдена." + Environment.NewLine;
                return;
            }
            double Multiplier = 1.0 / (Math.Pow(2 * Math.PI, ((double)dataGridView6.Rows.Count) / 2) * Math.Sqrt(Math.Abs(det)));
            double[,] RevR = Matrixes.GetReverse(RT, dataGridView6.Rows.Count);
            /////
            int DimNum = Data.MultiDemSamples[Data.MultiDemCurrentSample].Length;
            int[] temp = new int[DimNum];
            int NumberOfPoints = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count;
            int ClassNumber = ToolsForWork.CompNumOfClasses(NumberOfPoints);
            for (i = 0; i < DimNum; i++)
            {
                temp[i] = ClassNumber;
            }
            var VarR = Array.CreateInstance(typeof(int), temp);
            ////
            int Sum = 0;
            double funval;
            double Hi = 0;
            i = 0;
            string temps;
            double[] Maxs = new double[DimNum];
            double[] Mins = new double[DimNum];
            for (j = 0; j < DimNum; j++)
            {
                Maxs[j] = double.MinValue;
                Mins[j] = double.MaxValue;
            }
            for (j = 0; j < NumberOfPoints; j++)
            {
                for (k = 0; k < DimNum; k++)
                {
                    if (Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][j] > Maxs[k])
                    {
                        Maxs[k] = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][j];
                    }
                    if (Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][j] < Mins[k])
                    {
                        Mins[k] = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][j];
                    }
                }
            }
            for (k = 0; k < DimNum; k++)
            {
                Maxs[k] += ((double)Maxs[k] - Mins[k]) / 10000;
            }
            int Counter;
            foreach (int item in VarR)
            {
                int[] coor = ComputeIndex(i++, VarR);
                temps = "";
                for (j = coor.Length - 1; j > 0; j--)
                {
                    temps += coor[j] + "|";
                }
                temps += coor[0];
                VarR.SetValue(0, coor);
                for (j = 0; j < NumberOfPoints; j++)
                {
                    Counter = 0;
                    for (k = 0; k < DimNum; k++)
                    {
                        if ((Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][j] >= (Mins[k] + ((Maxs[k] - Mins[k]) / ClassNumber) * coor[k])) && (Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][j] < (Mins[k] + ((Maxs[k] - Mins[k]) / ClassNumber) * (coor[k] + 1))))
                        {
                            Counter++;
                        }
                    }
                    if (Counter == DimNum)
                    {
                        Sum++;
                        VarR.SetValue(1 + Convert.ToInt32(VarR.GetValue(coor)), coor);
                    }
                }
                funval = 0;
                for (k = 0; k < DimNum; k++)
                {
                    for (j = 0; j < DimNum; j++)
                    {
                        funval += (((Mins[k] + ((Maxs[k] - Mins[k]) / ClassNumber)) * (coor[k] + 0.5)) - ExpVals[k]) * RevR[k, j] * (((Mins[j] + ((Maxs[j] - Mins[j]) / ClassNumber)) * (coor[j] + 0.5)) - ExpVals[j]);
                    }
                }
                funval = Multiplier * Math.Exp(funval * -0.5);
                if (Math.Abs(funval) < 0.00001)
                {
                    funval = 0.00001;
                }
                Hi += (Math.Pow((((double)Convert.ToInt32(VarR.GetValue(coor))) / NumberOfPoints) - funval, 2)) / (funval);
                if (double.IsInfinity(Hi) || double.IsNaN(Hi))
                {

                    LogOutputTextBox.Text += " Something bad happned. Weve counted only";
                }
            }
            if (Sum != NumberOfPoints)
            {
                LogOutputTextBox.Text += " Something bad happned. Weve counted only" + Sum + " elements" + Environment.NewLine;
            }
            ////
            double quan = Quantile.HirsQuan(1 - Alfa,NumberOfPoints-DimNum);
            if (Hi <= quan)
            {
                LogOutputTextBox.Text += "Вітаємо! Гіпотеза про нормальність багатовимірного розподілу була доведена. Значення квантилю - " + Math.Round(quan, Data.NumberOfNum) + "; значення статистики - " + Math.Round(Hi, Data.NumberOfNum) + Environment.NewLine;
            }
            else
            {
                LogOutputTextBox.Text += "Гіпотеза про збіг нормальність багатовимірної вибірки була спростована; значення квантилю - " + Math.Round(quan, Data.NumberOfNum) + "; значення статистики - " + Math.Round(Hi, Data.NumberOfNum) + Environment.NewLine;
            }
        }

        private void dataGridView8_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            int Num = Convert.ToInt32(e.Row.Cells[e.Row.Cells.Count - 1].Value);
            double[] FW = new double[Data.MultiDemSamples[Data.MultiDemCurrentSample].Length];
            for (int i = 0; i < Data.MultiDemSamples[Data.MultiDemCurrentSample].Length; i++)
            {
                FW[i] = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][i]][Num];
                Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][i]].RemoveAt(Num);
            }
            Data.MultiDemStepBack[Data.MultiDemCurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.multidemdeleted, FW));
            UpdateForm();
        }

        private void dataGridView8_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int Num = Convert.ToInt32(e.Row.Cells[e.Row.Cells.Count - 1].Value);
            if (Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count <= 4)
            {
                LogOutputTextBox.Text += "Dangerous. I cant let u proceed" + Environment.NewLine;
                e.Cancel = true;
                return;
            }
           
        }

        private void перевіркаГіпотезПроЗбігПараметрівБагатовимірнихВибірокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArgStr Type = new ArgStr("Рівність середніх за умови рівності ДС", "p", "тип гіпотези для перевірки", "Виберіть гіпотезу, яку бажаєте перевірити", "", PossibleMultiHips.Hips);
            OkCancelDlg it = new OkCancelDlg("Перевірка вибірок на однорідність", null, Type);
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                switch (Type)
                {
                    case "Рівність середніх за умови рівності ДС":
                        {
                            CallTwoExpComp();
                            break;
                        }
                    case "збіг к середніх при розбіжності ДС":
                        {
                            CallKExpComp();
                            break;
                        }
                    case "збіг ДС":
                        {
                            CallTwoDCComp();
                            break;
                        }
                }
            }
        }

        private void CallTwoExpComp()
        {
            ArgInt Number1 = new ArgInt(1, "", "Номер першої вибірки для звірки", "...", "<Size>");
            ArgInt Number2 = new ArgInt(2, "", "Номер другої вибірки для звірки", "...", "<Size>");
            ArgFloat Alfa = new ArgFloat(0.05, "", "Критичне значення", "Критичне значення", "<Size>");
            OkCancelDlg it = new OkCancelDlg("Уточнення деталей", null, Number1, Number2, Alfa);
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                if ((Number1 < 1) || (Number1 > Data.MultiDemSamples.Count) || (Number2 < 1) || (Number2 > Data.MultiDemSamples.Count))
                {
                    LogOutputTextBox.Text += "Безсенсно" + Environment.NewLine;
                    return;
                }
                Number1.set(Number1 - 1);
                Number2.set(Number2 - 1);
                if (Data.MultiDemSamples[Number1].Length != Data.MultiDemSamples[Number2].Length)
                {
                    LogOutputTextBox.Text += "Безсенсно" + Environment.NewLine;
                    return;
                }
                if ((Alfa <= 0) || (Alfa >= 1))
                {
                    LogOutputTextBox.Text += "Безсенсно" + Environment.NewLine;
                    return;
                }
                double[,] S0 = new double[Data.MultiDemSamples[Number1].Length, Data.MultiDemSamples[Number1].Length], S1 = new double[Data.MultiDemSamples[Number1].Length, Data.MultiDemSamples[Number1].Length];
                double tempsum1, tempsum2,tempsum3;
                int Len1 = Data.DataForWork[Data.MultiDemSamples[Number1][0]].Count, Len2 = Data.DataForWork[Data.MultiDemSamples[Number2][0]].Count;
                int i, j, k, l;
                for (i = 0; i < Data.MultiDemSamples[Number1].Length; i++)
                {
                    for (j = 0; j < Data.MultiDemSamples[Number1].Length; j++)
                    {
                        tempsum1 = 0;
                        for (l = 0; l < Len1; l++)
                        {
                            tempsum1 += Data.DataForWork[Data.MultiDemSamples[Number1][i]][l] * Data.DataForWork[Data.MultiDemSamples[Number1][j]][l];
                        }
                        S0[i, j] = tempsum1;
                        tempsum1 = 0;
                        for (l = 0; l < Len2; l++)
                        {
                            tempsum1 += Data.DataForWork[Data.MultiDemSamples[Number2][i]][l] * Data.DataForWork[Data.MultiDemSamples[Number2][j]][l];
                        }
                        S0[i,j]+=tempsum1;
                        tempsum1=0; 
                        tempsum2=0;
                        for (l = 0; l < Len1; l++)
                        {
                            tempsum1 += Data.DataForWork[Data.MultiDemSamples[Number1][i]][l];
                        }
                        for (l = 0; l < Len2; l++)
                        {
                            tempsum2 += Data.DataForWork[Data.MultiDemSamples[Number2][i]][l] ;
                        }
                        tempsum3=tempsum1+tempsum2;
                        tempsum1=0; 
                        tempsum2=0;
                        for (l = 0; l < Len1; l++)
                        {
                            tempsum1 += Data.DataForWork[Data.MultiDemSamples[Number1][j]][l];
                        }
                        for (l = 0; l < Len2; l++)
                        {
                            tempsum2 += Data.DataForWork[Data.MultiDemSamples[Number2][j]][l] ;
                        }
                         tempsum3*=tempsum1+tempsum2;
                        tempsum3*=(1.0)/(Len1+Len2);
                        S0[i,j]-=tempsum3;
                        S0[i,j]*=(1.0)/(Len1+Len2-2);
                        ////////////////////////////////
                        tempsum1 = 0;
                        for (l = 0; l < Len1; l++)
                        {
                            tempsum1 += Data.DataForWork[Data.MultiDemSamples[Number1][i]][l] * Data.DataForWork[Data.MultiDemSamples[Number1][j]][l];
                        }
                        S1[i, j] = tempsum1;
                        tempsum1 = 0;
                        for (l = 0; l < Len2; l++)
                        {
                            tempsum1 += Data.DataForWork[Data.MultiDemSamples[Number2][i]][l] * Data.DataForWork[Data.MultiDemSamples[Number2][j]][l];
                        }
                        S1[i,j]+=tempsum1;
                        tempsum1=0; 
                        tempsum2=0;
                        for (l = 0; l < Len1; l++)
                        {
                            tempsum1 += Data.DataForWork[Data.MultiDemSamples[Number1][i]][l];
                            tempsum2 += Data.DataForWork[Data.MultiDemSamples[Number1][j]][l];
                        }
                        tempsum3 = (tempsum1 * tempsum2)/(Len1);
                        S1[i, j] -= tempsum3;
                        tempsum1 = 0;
                        tempsum2 = 0;
                        for (l = 0; l < Len2; l++)
                        {
                            tempsum1 += Data.DataForWork[Data.MultiDemSamples[Number2][i]][l];
                            tempsum2 += Data.DataForWork[Data.MultiDemSamples[Number2][j]][l];
                        }
                        tempsum3 = (tempsum1 * tempsum2) / (Len2);
                        S1[i, j] -= tempsum3;     
                        S1[i,j]*=(1.0)/(Len1+Len2-2);

                    }
                }
                double [][] Temp1 = new double[Data.MultiDemSamples[Number1].Length][], Temp2 = new double[Data.MultiDemSamples[Number1].Length][]; 
                for(i=0; i < Data.MultiDemSamples[Number1].Length;i++)
                {
                    Temp1[i] = new double[Data.MultiDemSamples[Number1].Length];
                    Temp2[i] = new double[Data.MultiDemSamples[Number1].Length];
                }
                for (i = 0; i < Data.MultiDemSamples[Number1].Length; i++)
                {
                    for (j = 0; j < Data.MultiDemSamples[Number1].Length; j++)
                    {
                        Temp1[i][j] = S0[i,j];
                        Temp2[i][j] = S1[i,j];
                    }
                }
                double det1 = Matrixes.GetDet(Temp2), det2 = Matrixes.GetDet(Temp1);
                double V = -1 * (Len1 + Len2 - 2 - ((double)Data.MultiDemSamples[Number1].Length) / 2) * Math.Log(Matrixes.GetDet(Temp2) / Matrixes.GetDet(Temp1));
                double quan = Quantile.HirsQuan(1-Alfa, Data.MultiDemSamples[Number1].Length);
                if (V <= quan)
                {
                    LogOutputTextBox.Text += "Вітаємо! Була доведена гіпотеза про збіг середніх двох багатовимірних вибірок: " + (int)Number1 + "-ої та " + (int)Number2 + "-ої; значення квантилю - " + Math.Round(quan, Data.NumberOfNum) + "; значення статистики - " + Math.Round(V, Data.NumberOfNum) + Environment.NewLine;
                }
                else
                {
                    LogOutputTextBox.Text += "Гіпотеза про збіг середніх двох багатовимірних вибірок: " + (int)Number1 + "-ої та " + (int)Number2 + "-ої була спростована; значення квантилю - " + Math.Round(quan, Data.NumberOfNum) + "; значення статистики - " + Math.Round(V, Data.NumberOfNum) + Environment.NewLine;
                }
            }
        }

        private void CallKExpComp()
        {
            ArgInt Number = new ArgInt(2, "", "Кількість вибірок для звірки", "...", "<Size>");
            ArgFloat Alfa = new ArgFloat(0.05, "", "Критичне значення", "Критичне значення", "<Size>");
            OkCancelDlg it = new OkCancelDlg("Уточнення деталей", null, Number, Alfa);
            DialogResult rc = it.ShowDialog();
            int i,j,k;
            if (rc == DialogResult.OK)
            {
                if ((Number < 2) || (Number > Data.MultiDemSamples.Count))
                {
                    LogOutputTextBox.Text += "На жаль, безсенсно" + Environment.NewLine;
                    return;
                }
                if ((Alfa <= 0) || (Alfa >= 1))
                {
                    LogOutputTextBox.Text += "Безсенсно" + Environment.NewLine;
                    return;
                }
                Arg[] ArrayOfNumbers = new Arg[Number];
                for (i = 0; i < Number; i++)
                {
                    ArrayOfNumbers[i] = new ArgInt(i + 1, "", "Номер вибірки", "Номер вибірки, яка буде частиною гіпотези про рівність...", "<Size>");
                }
                it = new OkCancelDlg("Виберіть вибірки для звірки середніх", null, ArrayOfNumbers);
                rc = it.ShowDialog();
                if (rc == DialogResult.OK)
                {
                    for (i = 0; i < Number; i++)
                    {
                        (ArrayOfNumbers[i] as ArgInt).set((ArrayOfNumbers[i] as ArgInt)-1);
                    }
                    for (i = 0; i < Number; i++)
                    {
                        if ((ArrayOfNumbers[i] as ArgInt) < 0 || (ArrayOfNumbers[i] as ArgInt) >= Data.MultiDemSamples.Count)
                        {
                            LogOutputTextBox.Text += "Безсенсно" + Environment.NewLine;
                            return;
                        }
                    }
                    int NumDim = Data.MultiDemSamples[ArrayOfNumbers[0] as ArgInt].Length;
                    int[] Lens = new int[Number];
                    for(i=0; i < Number-1; i++)
                    {
                        for (j = i+1; j < Number; j++)
                        {
                            if ((int)(ArrayOfNumbers[i] as ArgInt) == (int)(ArrayOfNumbers[j] as ArgInt))
                            {
                                LogOutputTextBox.Text += "Безсенсно порівнювати між собою одну і ту ж саму вибірку" + Environment.NewLine;
                                return;
                            }
                        }
                        if (NumDim != Data.MultiDemSamples[ArrayOfNumbers[i] as ArgInt].Length)
                        {
                            LogOutputTextBox.Text += "Розмірність вибірок не співпадає" + Environment.NewLine;
                            return;
                        }
                        Lens[i] = Data.DataForWork[Data.MultiDemSamples[ArrayOfNumbers[i] as ArgInt][0]].Count;
                    }
                    if (NumDim != Data.MultiDemSamples[ArrayOfNumbers[Number-1] as ArgInt].Length)
                    {
                        LogOutputTextBox.Text += "Розмірність вибірок не співпадає" + Environment.NewLine;
                        return;
                    }
                    Lens[Number-1] = Data.DataForWork[Data.MultiDemSamples[ArrayOfNumbers[Number-1] as ArgInt][0]].Count;
                    double[][] ExpD = new double[Number][];
                    double temp, temp1=0,temp2=0 ;
                    double[] tempar;
                    double[] SD = new double[Number];
                    double[] ExpAll = new double[NumDim];
                    for (i = 0; i < Number; i++)
                    {
                        ExpD[i] = new double[NumDim];
                        for(k=0; k < NumDim;k++)
                        {
                             temp = 0;
                            for (j = 0; j < Lens[i]; j++)
                            {
                                temp += Data.DataForWork[Data.MultiDemSamples[ArrayOfNumbers[i] as ArgInt][k]][j];
                            }
                            ExpD[i][k] = temp / Lens[i];
                        }
                    }
                    for (i = 0; i < Number; i++)
                    {
                        temp = 0;
                        tempar = new double[NumDim];
                        for (j = 0; j < Lens[i]; j++)
                        {
                            tempar = new double[NumDim];
                            for (k = 0; k < NumDim; k++)
                            {
                                tempar[k] += Data.DataForWork[Data.MultiDemSamples[ArrayOfNumbers[i] as ArgInt][k]][j]-ExpD[i][k];
                                temp += tempar[k] * tempar[k];
                            }
                        }
                        temp /= Lens[i] - 1;
                        SD[i] = temp;
                    }
                    tempar = new double[NumDim];
                    for (i = 0; i < Number; i++)
                    {
                        temp1 += Lens[i] * (1d / SD[i]);
                        for (j = 0; j < NumDim; j++)
                        {
                            tempar[j] += Lens[i] * (1d / SD[i]) * ExpD[i][j];
                        }
                    }
                    temp1 = 1d / temp1;
                    for (j = 0; j < NumDim; j++)
                    {
                        ExpAll[j] = tempar[j] * temp1;
                    }
                    double V=0;
                    for (i = 0; i < Number; i++)
                    {
                        temp=0;
                        for (j = 0; j < NumDim; j++)
                        {
                            temp+=(ExpD[i][j]-ExpAll[j])*(1d/SD[i])*(ExpD[i][j]-ExpAll[j]);
                        }
                        V += Lens[i] * temp;
                    }
                    double quan = Quantile.HirsQuan(1 - Alfa, (Number-1)*NumDim);
                    if (V <= quan)
                    {
                        LogOutputTextBox.Text += "Вітаємо! Була доведена гіпотеза про збіг середніх " + (int)Number + " багатовимірних вибірок; значення квантилю - " + Math.Round(quan, Data.NumberOfNum) + "; значення статистики - " + Math.Round(V, Data.NumberOfNum) + Environment.NewLine;
                    }
                    else
                    {
                        LogOutputTextBox.Text += "Гіпотеза про збіг середніх  " + (int)Number + " багатовимірних вибірок була спростована; значення квантилю - " + Math.Round(quan, Data.NumberOfNum) + "; значення статистики - " + Math.Round(V, Data.NumberOfNum) + Environment.NewLine;
                    }
                }
            }
        }

        private void CallTwoDCComp()
        {
            ArgInt Number = new ArgInt(2, "", "Кількість вибірок для звірки", "...", "<Size>");
            ArgFloat Alfa = new ArgFloat(0.05, "", "Критичне значення", "Критичне значення", "<Size>");
            OkCancelDlg it = new OkCancelDlg("Уточнення деталей", null, Number,Alfa);
            DialogResult rc = it.ShowDialog();
            int i, j, k;
            if (rc == DialogResult.OK)
            {
                if ((Number < 2) || (Number > Data.DataForWork.Count))
                {
                    LogOutputTextBox.Text += "На жаль, безсенсно" + Environment.NewLine;
                    return;
                }
                if ((Alfa <= 0) || (Alfa >= 1))
                {
                    LogOutputTextBox.Text += "Безсенсно" + Environment.NewLine;
                    return;
                }
                Arg[] ArrayOfNumbers = new Arg[Number];
                for (i = 0; i < Number; i++)
                {
                    ArrayOfNumbers[i] = new ArgInt(i + 1, "", "Номер вибірки", "Номер вибірки, яка буде частиною гіпотези про рівність...", "<Size>");
                }
                it = new OkCancelDlg("Виберіть вибірки для звірки ДС", null, ArrayOfNumbers);
                rc = it.ShowDialog();
                if (rc == DialogResult.OK)
                {
                    for (i = 0; i < Number; i++)
                    {
                        (ArrayOfNumbers[i] as ArgInt).set((ArrayOfNumbers[i] as ArgInt) - 1);
                    }
                    for (i = 0; i < Number; i++)
                    {
                        if ((ArrayOfNumbers[i] as ArgInt) < 0 || (ArrayOfNumbers[i] as ArgInt) >= Data.MultiDemSamples.Count)
                        {
                            LogOutputTextBox.Text += "Безсенсно" + Environment.NewLine;
                            return;
                        }
                    }
                    int NumDim = Data.MultiDemSamples[ArrayOfNumbers[0] as ArgInt].Length;
                    int[] Lens = new int[Number];
                    int AllNum = 0;
                    for (i = 0; i < Number - 1; i++)
                    {
                        for (j = i + 1; j < Number; j++)
                        {
                            if ((int)(ArrayOfNumbers[i] as ArgInt) == (int)(ArrayOfNumbers[j] as ArgInt))
                            {
                                LogOutputTextBox.Text += "Безсенсно порівнювати між собою одну і ту ж саму вибірку" + Environment.NewLine;
                                return;
                            }
                        }
                        if (NumDim != Data.MultiDemSamples[ArrayOfNumbers[i] as ArgInt].Length)
                        {
                            LogOutputTextBox.Text += "Розмірність вибірок не співпадає" + Environment.NewLine;
                            return;
                        }
                        Lens[i] = Data.DataForWork[Data.MultiDemSamples[ArrayOfNumbers[i] as ArgInt][0]].Count;
                        AllNum += Lens[i];
                    }
                    if (NumDim != Data.MultiDemSamples[ArrayOfNumbers[Number - 1] as ArgInt].Length)
                    {
                        LogOutputTextBox.Text += "Розмірність вибірок не співпадає" + Environment.NewLine;
                        return;
                    }
                    Lens[Number - 1] = Data.DataForWork[Data.MultiDemSamples[ArrayOfNumbers[Number - 1] as ArgInt][0]].Count;
                    AllNum += Lens[Number - 1];
                    double[][] ExpD = new double[Number][];
                    double temp;
                    double[] tempar;
                    double[] SD = new double[Number];
                    for (i = 0; i < Number; i++)
                    {
                        ExpD[i] = new double[NumDim];
                        for (k = 0; k < NumDim; k++)
                        {
                            temp = 0;
                            for (j = 0; j < Lens[i]; j++)
                            {
                                temp += Data.DataForWork[Data.MultiDemSamples[ArrayOfNumbers[i] as ArgInt][k]][j];
                            }
                            ExpD[i][k] = temp / Lens[i];
                        }
                    }
                    for (i = 0; i < Number; i++)
                    {
                        temp = 0;
                        tempar = new double[NumDim];
                        for (j = 0; j < Lens[i]; j++)
                        {
                            tempar = new double[NumDim];
                            for (k = 0; k < NumDim; k++)
                            {
                                tempar[k] += Data.DataForWork[Data.MultiDemSamples[ArrayOfNumbers[i] as ArgInt][k]][j] - ExpD[i][k];
                                temp += tempar[k] * tempar[k];
                            }
                        }
                        temp /= Lens[i] - 1;
                        SD[i] = temp;
                    }
                    temp = 0;
                    for (i = 0; i < Number; i++)
                    {
                        temp += (Lens[i] - 1) * SD[i];
                    }
                    double S = (temp) / (AllNum - Number);
                    double V = 0;
                    for (i = 0; i < Number; i++)
                    {
                        V += ((-1d + Lens[i]) / 2) * Math.Log(Math.Abs(S)/Math.Abs(SD[i]));
                    }
                    double quan = Quantile.HirsQuan(1 - Alfa, (int)((double)(Number-1)*NumDim*(NumDim+1))/2);
                    if (V <= quan)
                    {
                        LogOutputTextBox.Text += "Вітаємо! Була доведена гіпотеза про збіг DC " + (int)Number + " багатовимірних вибірок; значення квантилю - " + Math.Round(quan, Data.NumberOfNum) + "; значення статистики - " + Math.Round(V, Data.NumberOfNum) + Environment.NewLine;
                    }
                    else
                    {
                        LogOutputTextBox.Text += "Гіпотеза про збіг DC  " + (int)Number + " багатовимірних вибірок була спростована; значення квантилю - " + Math.Round(quan, Data.NumberOfNum) + "; значення статистики - " + Math.Round(V, Data.NumberOfNum) + Environment.NewLine;
                    }
                }
            }
        }

        private void зберегтиБагатовимірнуВибіркуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Data.MultiDemSamples.Count <= 0)
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Нема з чим працювати " + Environment.NewLine;
                return;
            }
            // Stream myStream;
            SaveFileDialog savingFileDialog = new SaveFileDialog();
            savingFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            savingFileDialog.FilterIndex = 2;
            savingFileDialog.RestoreDirectory = true;
            savingFileDialog.RestoreDirectory = true;
            int i,j;
            if (savingFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter FileToWrite = new System.IO.StreamWriter(savingFileDialog.FileName, true))
                {
                    for (i = 0; i < Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count; i++)
                    {
                        for (j = 0; j < Data.MultiDemSamples[Data.MultiDemCurrentSample].Length; j++)
                        {
                            FileToWrite.Write("" + Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][j]][i] + " ");
                        }
                        FileToWrite.WriteLine("");
                    }
                }
            }
        }

        private void UpdateForm(int NumberOfTarget)
        {
            int i;
            if (NumberOfTarget == Data.CurrentSample)
            {
                Build();
            }
            if (Data.TwoDemSamples.Count > 0 && (Data.TwoDemSamples[Data.TwoDemCurrentSample][0] == NumberOfTarget || Data.TwoDemSamples[Data.TwoDemCurrentSample][1] == NumberOfTarget))
            {
                BuildTwoDem();
            }
            if (Data.MultiDemSamples.Count > 0)
            {
                for (i = 0; i < Data.MultiDemSamples[Data.MultiDemCurrentSample].Length; i++)
                {
                    if (Data.MultiDemSamples[Data.MultiDemCurrentSample][i] == NumberOfTarget)
                    {
                        BuildMultiDem();
                    }
                }
            }
        }

        private void UpdateForm()
        {
            Build();
            BuildTwoDem();
            BuildMultiDem();
        }

        private void оновитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (Data.DataForWork.Count == 0 || Data.MultiDemSamples.Count == 0)
            {
                LogOutputTextBox.Text += "Nothing to work with";
                return;
            }
            int i, j;
            double Summ;
            double[] tempExp = new double[Data.MultiDemSamples[Data.MultiDemCurrentSample].Length];
            double[] Temps = new double[Data.MultiDemSamples[Data.MultiDemCurrentSample].Length];
            int NumOfPoints = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count;//Number of points in each sample
            double[] FW = new double[Data.MultiDemSamples[Data.MultiDemCurrentSample].Length * 2];
            for (i = 0; i < Data.MultiDemSamples[Data.MultiDemCurrentSample].Length; i++)
            {
                Summ = 0;
                for (j = 0; j < NumOfPoints; j++)
                {
                    Summ += Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][i]][j];
                }
                tempExp[i] = Summ / NumOfPoints;
                Temps[i] = 0;
                for (j = 0; j < NumOfPoints; j++)
                {
                    Temps[i] += Math.Pow((Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][i]][j] - tempExp[i]), 2);
                }
                Temps[i] *= (1.0) / (NumOfPoints - 1);
                Temps[i] = (Math.Sqrt(Temps[i]));
                if(Temps[i]==0)
                    continue;

                for (j = 0; j < NumOfPoints; j++)
                {
                    Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][i]][j] = ((double)Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][i]][j] - tempExp[i]) / (Temps[i]);
                }
                FW[i*2] = tempExp[i];
                FW[i*2+1] = Temps[i];
            }
            Data.MultiDemStepBack[Data.MultiDemCurrentSample].Add(new ToolsForWork.Changing(ToolsForWork.TypeOfCHange.multidemstand, FW));
            UpdateForm();
        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void MakeStepBackTwo()
        {
            ToolsForWork.Changing FW = Data.TwoDemStepBack[Data.TwoDemCurrentSample][Data.TwoDemStepBack[Data.TwoDemCurrentSample].Count - 1];
            Data.TwoDemStepBack[Data.TwoDemCurrentSample].RemoveAt(Data.TwoDemStepBack[Data.TwoDemCurrentSample].Count - 1);
            int i, j;
            switch (FW.ChangeStyle)
            {
                case (ToolsForWork.TypeOfCHange.twodemdeleted):
                    {
                        for (i = 0; i < Data.MultiDemSamples.Count; i++)
                        {
                            for (j = 0; j < Data.MultiDemSamples[i].Length; j++)
                            {
                                if (Data.TwoDemSamples[Data.TwoDemCurrentSample][0] == Data.MultiDemSamples[i][j] || Data.TwoDemSamples[Data.TwoDemCurrentSample][1] == Data.MultiDemSamples[i][j])
                                {
                                    LogOutputTextBox.Text += "Returning values to multidim samples shall be done by specialised button" + Environment.NewLine;
                                    return;
                                }
                            }
                        }
                        //Console.WriteLine("" + FW.paramsOfChange[0] );
                        Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].Add(FW.paramsOfChange[0]);
                        Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][1]].Add(FW.paramsOfChange[1]);
                        //Data.DataForWork[Data.CurrentSample].Sort();
                        break;
                    }
            }
        }

        private void крокНазаддвовимірніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Data.TwoDemStepBack[Data.TwoDemCurrentSample].Count == 0)
            {
                LogOutputTextBox.Text += "Нема з чим працювати " + Environment.NewLine;
                return;
            }
            if (Data.TwoDemSamples.Count <= 0)
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Нема з чим працювати " + Environment.NewLine;
                return;
            }
            MakeStepBackTwo();
            UpdateForm();
        }

        private void MakeStepBackMulti()
        {
            ToolsForWork.Changing FW = Data.MultiDemStepBack[Data.MultiDemCurrentSample][Data.MultiDemStepBack[Data.MultiDemCurrentSample].Count - 1];
            Data.MultiDemStepBack[Data.MultiDemCurrentSample].RemoveAt(Data.MultiDemStepBack[Data.MultiDemCurrentSample].Count - 1);
            int i, j;
            switch (FW.ChangeStyle)
            {
                case (ToolsForWork.TypeOfCHange.multidemdeleted):
                    {
                        ////
                        double[] Param = FW.paramsOfChange;
                        //Console.WriteLine("" + FW.paramsOfChange[0] );
                        for (i = 0; i < Param.Length; i++)
                        {
                            Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][i]].Add(FW.paramsOfChange[i]);
                        }
                        //Data.DataForWork[Data.CurrentSample].Sort();
                        break;
                    }
                case (ToolsForWork.TypeOfCHange.multidemstand):
                    {
                        ////
                        int len = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count;
                        double[] Param = FW.paramsOfChange;
                        //Console.WriteLine("" + FW.paramsOfChange[0] );
                        for (i = 0; i < Param.Length; i+=2)
                        {
                            for (j = 0; j < len; j++)
                            {
                                Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][(int)(i / 2)]][j] *= Param[i + 1];
                                Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][(int)(i / 2)]][j] += Param[i];
                            }
                        }
                        //Data.DataForWork[Data.CurrentSample].Sort();
                        break;
                    }

            }
        }

        private void крокНазадбагатовимірніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Data.MultiDemSamples.Count <= 0)
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Нема з чим працювати " + Environment.NewLine;
                return;
            }
            if (Data.MultiDemStepBack[Data.MultiDemCurrentSample].Count == 0)
            {
                LogOutputTextBox.Text += "Нема з чим працювати " + Environment.NewLine;
                return;
            }
            MakeStepBackMulti();
            UpdateForm();
        }

        private void доПочатковихЗначеньДвовимірніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Data.TwoDemSamples.Count <= 0)
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Нема з чим працювати " + Environment.NewLine;
                return;
            }
            while (Data.TwoDemStepBack[Data.TwoDemCurrentSample].Count != 0)
            {
                MakeStepBackTwo();
            }
            UpdateForm();
        }

        private void доПочатковихЗначеньБагатовимірніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Data.MultiDemSamples.Count <= 0)
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Нема з чим працювати " + Environment.NewLine;
                return;
            }
            while (Data.MultiDemStepBack[Data.MultiDemCurrentSample].Count != 0)
            {
                MakeStepBackMulti();
            }
            UpdateForm();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (Data.MultiDemSamples.Count <= 0)
            {
                if (LogCheckBox.Checked)
                    LogOutputTextBox.Text += "Нема з чим працювати " + Environment.NewLine;
                return;
            }
            int DimNum = Data.MultiDemSamples[Data.MultiDemCurrentSample].Length;
            int i, j, k;
            int[] temp = new int[DimNum];
            int NumberOfPoints = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count;
            int ClassNumber = ToolsForWork.CompNumOfClasses(NumberOfPoints);
            for (i = 0; i < DimNum; i++)
            {
                temp[i] = ClassNumber;
            }
            var VarR = Array.CreateInstance(typeof(int), temp);
            OutputArray(VarR, NumberOfPoints,DimNum, ClassNumber);
            

        }

        
        int[] ComputeIndex(int i, Array arr)
        {
            var dims = Enumerable.Range(0, arr.Rank)
                .Select(arr.GetLength)
                .ToArray();

            Func<int, int, int> product = (i1, i2) => i1 * i2;

            return dims.Select((d, n) => (i / dims.Take(n).Aggregate(1, product)) % d).ToArray();
        }

        void OutputArray(Array arr, int NumOfPoints, int DimNumber, int NumOfClasses)
        {
            int Sum = 0;
            var i = 0;
            int j,k;
            string temp;
            double[] Maxs = new double[DimNumber];
            double[] Mins = new double[DimNumber];
            for (j = 0; j < DimNumber; j++)
            {
                Maxs[j] = double.MinValue;
                Mins[j] = double.MaxValue;
            }
            for (j = 0; j < NumOfPoints; j++)
            {
                for (k = 0; k < DimNumber; k++)
                {
                    if(Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][j]>Maxs[k])
                    {
                        Maxs[k] = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][j];
                    }
                    if(Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][j]<Mins[k])
                    {
                        Mins[k] = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][j];
                    }
                }
            }
            for (k = 0; k < DimNumber; k++)
            {
                Maxs[k]+=((double)Maxs[k]-Mins[k])/10000;
            }
           int Counter;
            foreach (int item in arr)
            {
                int[] coor = ComputeIndex(i++, arr);
                temp = "";
                for (j = coor.Length - 1; j > 0; j--)
                {
                    temp += coor[j] + "|";
                }
                temp += coor[0];
                arr.SetValue(0, coor);
                for (j = 0; j < NumOfPoints; j++)
                {
                    Counter = 0;
                    for (k = 0; k < DimNumber; k++)
                    {
                        if ((Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][j] >= (Mins[k] + ((Maxs[k] - Mins[k]) / NumOfClasses) * coor[k])) && (Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][j] < (Mins[k] + ((Maxs[k] - Mins[k]) / NumOfClasses) * (coor[k] + 1))))
                        {
                            Counter++;
                        }
                    }
                    if (Counter == DimNumber)
                    {
                        Sum++;
                        arr.SetValue(1+Convert.ToInt32(arr.GetValue(coor)), coor);
                    }
                }
                LogOutputTextBox.Text += temp + " " + arr.GetValue(coor) + "  , p=" + ((double)Convert.ToInt32(arr.GetValue(coor))) / NumOfPoints + Environment.NewLine;
            }
            if (Sum != NumOfPoints)
            {
                LogOutputTextBox.Text += " Something bad happened. Weve counted only"+ Sum + " elements"+ Environment.NewLine;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if(Data.MultiDemSamples.Count==0)
            {
                LogOutputTextBox.Text += "Nothing to work with";
                return;
            }
            int i, j,k;
            int NumOfPoints = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][0]].Count;
            int DimNum = Data.MultiDemSamples[Data.MultiDemCurrentSample].Length;
            int target;
            if (!radioButton9.Checked && !radioButton10.Checked && !radioButton11.Checked)
            {
                LogOutputTextBox.Text += "Виберіть тип регрессії" + Environment.NewLine;
                return;
            }
            try
            {
                target = Convert.ToInt32(textBox28.Text);
                target--;
                if (target < 0 || target >= Data.MultiDemSamples[Data.MultiDemCurrentSample].Length)
                {
                    throw new Exception();
                }
            }
            catch
            {
                LogOutputTextBox.Text += "Номер залежного виміру введений невірно" + Environment.NewLine;
                return;
            }
            double alfa;
            try
            {
                alfa = Convert.ToDouble(textBox29.Text);
            }
            catch
            {
                textBox29.Text = "" + 0.05;
                alfa = 0.05;
            }
            if (alfa <= 0 || alfa >= 1)
            {
                textBox29.Text = "" + 0.05;
                alfa = 0.05;
            }
            double[] tempExp = new double[Data.MultiDemSamples[Data.MultiDemCurrentSample].Length];
            double Summ, temp;
            double[] Temps = new double[Data.MultiDemSamples[Data.MultiDemCurrentSample].Length];
            double S2zal = 0, Szal;
            double fval = 0;
            double fstat = 0;
            double R2;
            double quan;
            for (i = 0; i < Data.MultiDemSamples[Data.MultiDemCurrentSample].Length; i++)
            {
                Summ = 0;
                for (j = 0; j < NumOfPoints; j++)
                {
                    Summ += Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][i]][j];
                }
                tempExp[i] = Summ / NumOfPoints;
                Temps[i] = 0;
                for (j = 0; j < NumOfPoints; j++)
                {
                    Temps[i] += Math.Pow((Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][i]][j] - tempExp[i]), 2);
                }
                Temps[i] *= (1.0) / (NumOfPoints - 1);
                Temps[i] = (Math.Sqrt(Temps[i]));
            }
            /////
            double[,] X = new double[NumOfPoints,DimNum-1], Xm1 = new double [DimNum-1,NumOfPoints];
            double[,] Xv = new double[1,DimNum-1];
            int y;
            y = target;
            for (i = 0; i < NumOfPoints; i++)
            {
                for (j = 0,k=0; k < DimNum; j++)
                {
                    if (k != y)
                    {
                        X[i, j] = (Xm1[j, i] = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][i]);
                        k++;
                    }
                    else
                    {
                        k++;
                        j--;
                    }
                }
            }
            double[,] Temp1Mat = Matrixes.Multiply(Xm1, X);
            double[,] C = Matrixes.GetReverse(Temp1Mat, DimNum - 1);
            double alfa1=1-alfa/2, alfa2=alfa/2;
            double Multipl;
            double[,] temp1;
            /////
            if (radioButton9.Checked)
            {
                if (Data.MultiDemSamples[Data.MultiDemCurrentSample].Length != 3)
                {
                    LogOutputTextBox.Text += "Неможливо відтворити тривимірну регресію на цій виборці   " + Environment.NewLine;
                    return;
                }
                double[] A = new double[DimNum];
                int x1, x2;
                x1 = (y == 0) ? (1) : (0);
                x2 = (y == 2) ? (1) : (2);
                double x12 = 0, x22 = 0, yx1 = 0, yx2 = 0,x1x2=0;
                for (i = 0; i < NumOfPoints; i++)
                {
                    x1x2 += Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][x1]][i] * Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][x2]][i];
                    yx1 += Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][x1]][i] * Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][y]][i];
                    yx2 += Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][x2]][i] * Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][y]][i];
                    x12 += Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][x1]][i] * Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][x1]][i];
                    x22 += Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][x2]][i] * Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][x2]][i];
                }
                x1x2/=NumOfPoints;
                yx1 /=NumOfPoints;
                yx2 /=NumOfPoints;
                x12 /=NumOfPoints;
                x22 /= NumOfPoints;
                double delta = x12 * x22 + 2 * tempExp[x1] * tempExp[x2] * x1x2 - x12 * tempExp[x2] * tempExp[x2] - x1x2 * x1x2 - x22 * tempExp[x1] * tempExp[x1];
                A[0] =  (tempExp[y]*x12*x22+tempExp[x1]*x1x2*yx2+yx1*x1x2*tempExp[x2]-yx2*x12*tempExp[x2]-yx1*x22* tempExp[x1]-x1x2*x1x2*tempExp[y])/(delta);
                A[1] =  (yx1*x22+tempExp[y]*x1x2*tempExp[x2]+yx2*tempExp[x1] * tempExp[x2]-tempExp[x2] * tempExp[x2]*yx1-x1x2*yx2-x22*tempExp[y] * tempExp[x1])/(delta);
                A[2] = (x12 * yx2 + yx1 * tempExp[x1] * tempExp[x2] + x1x2 * tempExp[x1] * tempExp[y] - x12 * tempExp[x2] * tempExp[y] - x1x2 * yx1 - yx2 * tempExp[x1] * tempExp[x1]) / (delta);
                /////R2
                for (i = 0; i < NumOfPoints; i++)
                {
                    fval = A[0];
                    k = 1;
                    for (j = 0; j < DimNum; j++)
                    {
                        if (j != y)
                        {
                            fval += Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][j]][i] * A[k];
                            k++;
                        }
                    }
                    S2zal += Math.Pow(fval - Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][y]][i], 2);
                }
                S2zal /= (NumOfPoints - DimNum);
                Szal = Math.Sqrt(S2zal);
                /////
                LogOutputTextBox.Text += "Коефіціент a" + (0) + "=" + Math.Round(A[0], Data.NumberOfNum) + Environment.NewLine;
                for (i = 1; i < A.Length; i++)
                {
                    quan = Quantile.StudQuan(alfa, NumOfPoints - DimNum);
                    if (Math.Abs(A[i] / (Szal * Math.Sqrt(C[i-1, i-1]))) > quan)
                    {
                        LogOutputTextBox.Text += "Коефіціент a" + (i) + " є значущим, інтервальна оцінка: " + Math.Round((A[i] - quan * Szal * Math.Sqrt(C[i - 1, i - 1])), Data.NumberOfNum) + "<=" + Math.Round(A[i], Data.NumberOfNum) + "<=" + Math.Round((A[i] + quan * Szal * Math.Sqrt(C[i - 1, i - 1])), Data.NumberOfNum) + Environment.NewLine;
                    }
                    else
                    {
                        LogOutputTextBox.Text += "Коефіціент a" + (i) + " не  є значущим, інтервальна оцінка: " + Math.Round((A[i] - quan * Szal * Math.Sqrt(C[i - 1, i - 1])), Data.NumberOfNum) + "<=" + Math.Round(A[i], Data.NumberOfNum) + "<=" + Math.Round((A[i] + quan * Szal * Math.Sqrt(C[i - 1, i - 1])), Data.NumberOfNum) + Environment.NewLine;
                    }
                    try
                    {
                        temp = Convert.ToDouble(dataGridView12.Rows[i].Cells[1].Value);
                        if (Math.Abs(A[i] - temp) / (Szal * Math.Sqrt(C[i - 1, i - 1])) > quan)
                        {
                            LogOutputTextBox.Text += "Коефіціент a не співпадає з заданим користувачем значенням" + Environment.NewLine;
                        }
                        else
                        {
                            LogOutputTextBox.Text += "Коефіціент a співпадає з заданим користувачем значенням" + Environment.NewLine;
                        }
                    }
                    catch
                    { 
                    }
                }
                LogOutputTextBox.Text += "Стандартизовані оцінки параметрів :" + Environment.NewLine;
               // for (i = 1; i < A.Length; i++)
                {
                    LogOutputTextBox.Text += "а1* = " + Math.Round(((A[1] * Temps[x1]) / Temps[y]), Data.NumberOfNum) + Environment.NewLine;
                    LogOutputTextBox.Text += "а2* = " + Math.Round(((A[2] * Temps[x2]) / Temps[y]), Data.NumberOfNum) + Environment.NewLine;
                }
                ////
                LogOutputTextBox.Text += "Коефіціент детермінацій = " + Math.Round((R2 = 1 - (S2zal / (Temps[y] * Temps[y]))) * 100, Data.NumberOfNum) + "%" + Environment.NewLine;
                //Значущість регрессії
                fstat = ((-1d + NumOfPoints - DimNum) / (DimNum)) * (((1d) / (1 - R2 * R2)) - 1);
                quan = Quantile.FishQuan(1-alfa,DimNum,NumOfPoints-DimNum-1);
                if (fstat > quan)
                {
                    LogOutputTextBox.Text += "Вітаємо! Доведено значущість відтвореної регрессії. Значення статистики - " + Math.Round(fstat, Data.NumberOfNum) + ", значення квантилю - " + Math.Round(quan, Data.NumberOfNum) + Environment.NewLine;
                }
                else
                {
                    LogOutputTextBox.Text += "На жаль, гапотеза про значущість регресії була спростована. Значення статистики - " + Math.Round(fstat, Data.NumberOfNum) + ", значення квантилю - " + Math.Round(quan, Data.NumberOfNum) + Environment.NewLine;
                }
                /////
                LogOutputTextBox.Text += "Довірчі інтервали залишкової дисперсії: " + Math.Round((S2zal * (NumOfPoints - DimNum)) / (Quantile.HirsQuan(alfa2, NumOfPoints - DimNum)), Data.NumberOfNum) + "<=" + Math.Round(S2zal, Data.NumberOfNum) + "<=" + Math.Round((S2zal * (NumOfPoints - DimNum)) / (Quantile.HirsQuan(alfa1, NumOfPoints - DimNum)), Data.NumberOfNum) + Environment.NewLine;
                ///////
                dataGridView13.Rows.Clear();
                chart5.Series[0].Points.Clear();
                quan = Quantile.StudQuan(alfa, NumOfPoints - DimNum);
                for (i = 0; i < NumOfPoints; i++)
                {
                    fval = A[0];
                    k = 1;
                    for (j = 0; j < DimNum; j++)
                    {
                        if (j != y)
                        {
                            fval += Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][j]][i] * A[k];
                            k++;
                        }
                    }
                    chart5.Series[0].Points.AddXY(Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][y]][i], Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][y]][i] - fval);
                    for (j = 0,k = 0; j < DimNum-1; j++,k++)
                    {
                        if(k==y)
                        {
                            k++;
                        }
                        Xv[0,j] = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][i];
                    }
                   // S2zal += Math.Pow(fval - Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][y]][i], 2);
                    temp = fval - Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][y]][i];
                    temp1 = Matrixes.Multiply(Matrixes.Multiply(Xv, C), Matrixes.GetTransp(Xv, 1, DimNum-1));
                    Multipl = Szal * Math.Sqrt(1 + Matrixes.Multiply(Matrixes.Multiply(Xv, C), Matrixes.GetTransp(Xv, 1, DimNum-1))[0, 0]);
                    temp/= (Multipl);
                    dataGridView13.Rows.Add((i + 1), Math.Round(fval - quan * Multipl,Data.NumberOfNum), Math.Round(Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][y]][i],Data.NumberOfNum),Math.Round(fval + quan * Multipl,Data.NumberOfNum), (Math.Abs(temp) > quan) ? ("-") : ("+"));
                    //'/не забудь что не нужно оценивать а0
                }

            }
            if (radioButton10.Checked)
            {
                double[] A = new double[DimNum];
                double[,] Y0 = new double[NumOfPoints, 1];
                for (i = 0; i < NumOfPoints; i++)
                {
                    Y0[i, 0] = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][y]][i];
                }
                Temp1Mat = Matrixes.Multiply(Xm1, Y0);
                Temp1Mat = Matrixes.Multiply(C, Temp1Mat);
                for (i = 0; i < DimNum - 1; i++)
                {
                    A[i + 1] = Temp1Mat[i, 0];
                }
                /////R2
                for (i = 0; i < NumOfPoints; i++)
                {
                    fval = 0;
                    k = 1;
                    for (j = 0; j < DimNum; j++)
                    {
                        if (j != y)
                        {
                            fval += Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][j]][i] * A[k];
                            k++;
                        }
                    }
                    S2zal += Math.Pow(fval - Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][y]][i], 2);
                }
                S2zal /= (NumOfPoints - DimNum);
                Szal = Math.Sqrt(S2zal);
                /////
                for (i = 1; i < A.Length; i++)
                {
                    quan = Quantile.StudQuan(alfa, NumOfPoints - DimNum);
                    if (Math.Abs(A[i] / (Szal * Math.Sqrt(C[i - 1, i - 1]))) > quan)
                    {
                        LogOutputTextBox.Text += "Коефіціент a" + (i) + " є значущим, інтервальна оцінка: " + Math.Round((A[i] - quan * Szal * Math.Sqrt(C[i - 1, i - 1])), Data.NumberOfNum) + "<=" + Math.Round(A[i], Data.NumberOfNum) + "<=" + Math.Round((A[i] + quan * Szal * Math.Sqrt(C[i - 1, i - 1])), Data.NumberOfNum) + Environment.NewLine;
                    }
                    else
                    {
                        LogOutputTextBox.Text += "Коефіціент a" + (i) + " не  є значущим, інтервальна оцінка: " + Math.Round((A[i] - quan * Szal * Math.Sqrt(C[i - 1, i - 1])), Data.NumberOfNum) + "<=" + Math.Round(A[i], Data.NumberOfNum) + "<=" + Math.Round((A[i] + quan * Szal * Math.Sqrt(C[i - 1, i - 1])), Data.NumberOfNum) + Environment.NewLine;
                    }
                    try
                    {
                        temp = Convert.ToDouble(dataGridView12.Rows[i].Cells[1].Value);
                        if (Math.Abs(A[i] - temp) / (Szal * Math.Sqrt(C[i - 1, i - 1])) > quan)
                        {
                            LogOutputTextBox.Text += "Коефіціент a не співпадає з заданим користувачем значенням" + Environment.NewLine;
                        }
                        else
                        {
                            LogOutputTextBox.Text += "Коефіціент a співпадає з заданим користувачем значенням" + Environment.NewLine;
                        }
                    }
                    catch
                    {
                    }
                }
                k = 0;
                LogOutputTextBox.Text += "Стандартизовані оцінки параметрів :" + Environment.NewLine;
                for (i = 1; i < A.Length; i++)
                {
                    if (k == y)
                    {
                        k++;
                    }
                    LogOutputTextBox.Text += "а" + i + "* = " + Math.Round(((A[1] * Temps[k]) / Temps[y]), Data.NumberOfNum) + Environment.NewLine;
                    k++;
                }
                ////
                LogOutputTextBox.Text += "Коефіціент детермінацій = " + Math.Round((R2 = 1 - (S2zal / (Temps[y] * Temps[y]))) * 100, Data.NumberOfNum) + "%" + Environment.NewLine;
                //Значущість регрессії
                fstat = ((-1d + NumOfPoints - DimNum) / (DimNum)) * (((1d) / (1 - R2 * R2)) - 1);
                quan = Quantile.FishQuan(1 - alfa, DimNum, NumOfPoints - DimNum - 1);
                if (fstat > quan)
                {
                    LogOutputTextBox.Text += "Вітаємо! Доведено значущість відтвореної регрессії. Значення статистики - " + Math.Round(fstat, Data.NumberOfNum) + ", значення квантилю - " + Math.Round(quan, Data.NumberOfNum) + Environment.NewLine;
                }
                else
                {
                    LogOutputTextBox.Text += "На жаль, гапотеза про значущість регресії була спростована. Значення статистики - " + Math.Round(fstat, Data.NumberOfNum) + ", значення квантилю - " + Math.Round(quan, Data.NumberOfNum) + Environment.NewLine;
                }
                /////
                LogOutputTextBox.Text += "Довірчі інтервали залишкової дисперсії: " + Math.Round((S2zal * (NumOfPoints - DimNum)) / (Quantile.HirsQuan(alfa2, NumOfPoints - DimNum)), Data.NumberOfNum) + "<=" + Math.Round(S2zal, Data.NumberOfNum) + "<=" + Math.Round((S2zal * (NumOfPoints - DimNum)) / (Quantile.HirsQuan(alfa1, NumOfPoints - DimNum)), Data.NumberOfNum) + Environment.NewLine;
                ///////
                dataGridView13.Rows.Clear();
                chart5.Series[0].Points.Clear();
                quan = Quantile.StudQuan(alfa, NumOfPoints - DimNum);
                for (i = 0; i < NumOfPoints; i++)
                {
                    fval = 0;
                    k = 1;
                    for (j = 0; j < DimNum; j++)
                    {
                        if (j != y)
                        {
                            fval += Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][j]][i] * A[k];
                            k++;
                        }
                    }
                    chart5.Series[0].Points.AddXY(Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][y]][i], Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][y]][i] - fval);
                    for (j = 0, k = 0; j < DimNum - 1; j++, k++)
                    {
                        if (k == y)
                        {
                            k++;
                        }
                        Xv[0, j] = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][i];
                    }
                    // S2zal += Math.Pow(fval - Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][y]][i], 2);
                    temp = fval - Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][y]][i];
                    temp1 = Matrixes.Multiply(Matrixes.Multiply(Xv, C), Matrixes.GetTransp(Xv, 1, DimNum - 1));
                    Multipl = Szal * Math.Sqrt(1 + Matrixes.Multiply(Matrixes.Multiply(Xv, C), Matrixes.GetTransp(Xv, 1, DimNum - 1))[0, 0]);
                    temp /= (Multipl);
                    dataGridView13.Rows.Add((i + 1), Math.Round(fval - quan * Multipl,Data.NumberOfNum), Math.Round(Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][y]][i],Data.NumberOfNum), Math.Round(fval + quan * Multipl,Data.NumberOfNum), (Math.Abs(temp) > quan) ? ("-") : ("+"));
                    //'/не забудь что не нужно оценивать а0
                }
            }
            if (radioButton11.Checked)
            {
                double[] A = new double[DimNum];
                for (i = 0; i < NumOfPoints; i++)
                {
                    for (j = 0,k=0; j < DimNum; j++,k++)
                    {
                        if (j != y)
                        {
                            X[i, k] -= tempExp[j];
                            Xm1[k, i] -= tempExp[j];
                        }
                        else
                        {
                            k--;
                        }
                    }
                }
                double[,] Y0 = new double[NumOfPoints, 1];
                for (i = 0; i < NumOfPoints; i++)
                {
                    Y0[i,0] = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][y]][i]-tempExp[y];
                }
                Temp1Mat = Matrixes.Multiply(Xm1,X);
                Temp1Mat = Matrixes.GetReverse(Temp1Mat,DimNum-1);
                Temp1Mat = Matrixes.Multiply(Temp1Mat, Xm1);
                Temp1Mat = Matrixes.Multiply(Temp1Mat, Y0);
                for (i = 0; i < DimNum - 1; i++)
                {
                    A[i + 1] = Temp1Mat[i, 0];
                }
                Summ =0;
                k = 0;
                for (i = 0; i < DimNum; i++)
                {
                    if (i != y)
                    {
                        Summ += A[k + 1] * tempExp[i];
                        k++;
                    }
                }
                A[0] = tempExp[y] - Summ;
                    /////R2
                    for (i = 0; i < NumOfPoints; i++)
                    {
                        fval = A[0];
                        k = 1;
                        for (j = 0; j < DimNum; j++)
                        {
                            if (j != y)
                            {
                                fval += Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][j]][i] * A[k];
                                k++;
                            }
                        }
                        S2zal += Math.Pow(fval - Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][y]][i], 2);
                    }
                S2zal /= (NumOfPoints - DimNum);
                Szal = Math.Sqrt(S2zal);
                /////
                LogOutputTextBox.Text += "Коефіціент a" + (0) + "=" + Math.Round(A[0], Data.NumberOfNum) + Environment.NewLine;
                for (i = 1; i < A.Length; i++)
                {
                    quan = Quantile.StudQuan(alfa, NumOfPoints - DimNum);
                    if (Math.Abs(A[i] / (Szal * Math.Sqrt(C[i - 1, i - 1]))) > quan)
                    {
                        LogOutputTextBox.Text += "Коефіціент a" + (i) + " є значущим, інтервальна оцінка: " + Math.Round((A[i] - quan * Szal * Math.Sqrt(C[i - 1, i - 1])), Data.NumberOfNum) + "<=" + Math.Round(A[i], Data.NumberOfNum) + "<=" + Math.Round((A[i] + quan * Szal * Math.Sqrt(C[i - 1, i - 1])), Data.NumberOfNum) + Environment.NewLine;
                    }
                    else
                    {
                        LogOutputTextBox.Text += "Коефіціент a" + (i) + " не  є значущим, інтервальна оцінка: " + Math.Round((A[i] - quan * Szal * Math.Sqrt(C[i - 1, i - 1])), Data.NumberOfNum) + "<=" + Math.Round(A[i], Data.NumberOfNum) + "<=" + Math.Round((A[i] + quan * Szal * Math.Sqrt(C[i - 1, i - 1])), Data.NumberOfNum) + Environment.NewLine;
                    }
                    try
                    {
                        temp = Convert.ToDouble(dataGridView12.Rows[i].Cells[1].Value);
                        if (Math.Abs(A[i] - temp) / (Szal * Math.Sqrt(C[i - 1, i - 1])) > quan)
                        {
                            LogOutputTextBox.Text += "Коефіціент a не співпадає з заданим користувачем значенням" + Environment.NewLine;
                        }
                        else
                        {
                            LogOutputTextBox.Text += "Коефіціент a співпадає з заданим користувачем значенням" + Environment.NewLine;
                        }
                    }
                    catch
                    {
                    }
                }
                k = 0;
                LogOutputTextBox.Text += "Стандартизовані оцінки параметрів :" + Environment.NewLine;
                 for (i = 1; i < A.Length; i++)
                {
                    if (k == y)
                    {
                        k++;
                    }
                    LogOutputTextBox.Text += "а" + i + "* = " + Math.Round(((A[1] * Temps[k]) / Temps[y]), Data.NumberOfNum) + Environment.NewLine;
                    k++;
                }
                ////
                LogOutputTextBox.Text += "Коефіціент детермінацій = " + Math.Round((R2 = 1 - (S2zal / (Temps[y] * Temps[y]))) * 100, Data.NumberOfNum) + "%" + Environment.NewLine;
                //Значущість регрессії
                fstat = ((-1d + NumOfPoints - DimNum) / (DimNum)) * (((1d) / (1 - R2 * R2)) - 1);
                quan = Quantile.FishQuan(1 - alfa, DimNum, NumOfPoints - DimNum - 1);
                if (fstat > quan)
                {
                    LogOutputTextBox.Text += "Вітаємо! Доведено значущість відтвореної регрессії. Значення статистики - " + Math.Round(fstat, Data.NumberOfNum) + ", значення квантилю - " + Math.Round(quan, Data.NumberOfNum) + Environment.NewLine;
                }
                else
                {
                    LogOutputTextBox.Text += "На жаль, гапотеза про значущість регресії була спростована. Значення статистики - " + Math.Round(fstat, Data.NumberOfNum) + ", значення квантилю - " + Math.Round(quan, Data.NumberOfNum) + Environment.NewLine;
                }
                /////
                LogOutputTextBox.Text += "Довірчі інтервали залишкової дисперсії: " + Math.Round((S2zal * (NumOfPoints - DimNum)) / (Quantile.HirsQuan(alfa2, NumOfPoints - DimNum)), Data.NumberOfNum) + "<=" + Math.Round(S2zal, Data.NumberOfNum) + "<=" + Math.Round((S2zal * (NumOfPoints - DimNum)) / (Quantile.HirsQuan(alfa1, NumOfPoints - DimNum)), Data.NumberOfNum) + Environment.NewLine;
                ///////
                dataGridView13.Rows.Clear();
                chart5.Series[0].Points.Clear();
                quan = Quantile.StudQuan(alfa, NumOfPoints - DimNum);
                for (i = 0; i < NumOfPoints; i++)
                {
                    fval = A[0];
                    k = 1;
                    for (j = 0; j < DimNum; j++)
                    {
                        if (j != y)
                        {
                            fval += Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][j]][i] * A[k];
                            k++;
                        }
                    }
                    chart5.Series[0].Points.AddXY(Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][y]][i],  Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][y]][i]- fval);
                    for (j = 0, k = 0; j < DimNum - 1; j++, k++)
                    {
                        if (k == y)
                        {
                            k++;
                        }
                        Xv[0, j] = Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][k]][i];
                    }
                    // S2zal += Math.Pow(fval - Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][y]][i], 2);
                    temp = fval - Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][y]][i];
                    temp1 = Matrixes.Multiply(Matrixes.Multiply(Xv, C), Matrixes.GetTransp(Xv, 1, DimNum - 1));
                    Multipl = Szal * Math.Sqrt(1 + Matrixes.Multiply(Matrixes.Multiply(Xv, C), Matrixes.GetTransp(Xv, 1, DimNum - 1))[0, 0]);
                    temp /= (Multipl);
                    dataGridView13.Rows.Add((i + 1), Math.Round(fval - quan * Multipl,Data.NumberOfNum),Math.Round( Data.DataForWork[Data.MultiDemSamples[Data.MultiDemCurrentSample][y]][i],Data.NumberOfNum), Math.Round(fval + quan * Multipl,Data.NumberOfNum), (Math.Abs(temp) > quan) ? ("-") : ("+"));
                    //'/не забудь что не нужно оценивать а0
                }
            }
        }

        private void застосуватиМГКдвовимірніToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (Data.DataForWork.Count == 0)
            {
                LogOutputTextBox.Text += "Нема з чим працювати" + Environment.NewLine;
                return;
            }
            if (Data.TwoDemSamples.Count == 0)
            {
                LogOutputTextBox.Text += "Нема з чим працювати - нема двовимірних вибірок" + Environment.NewLine;
                return;
            }
            int i, j, k;
            List<double> Temp1 = new List<double>(), Temp2 = new List<double>();
            for (i = 0; i < Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]].Count; i++)
            {
                Temp1.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][0]][i]);
                Temp2.Add(Data.DataForWork[Data.TwoDemSamples[Data.TwoDemCurrentSample][1]][i]);
            }
            //////////////
            double Xexp, Yexp, StX, StY, KK, Kvx, Kvy, Ts, Tk,CrosSum;
            {
                double Sum1 = 0;
                double Sum2 = 0;
                for (i = 0; i < Temp1.Count; i++)
                {
                    Sum1 += Temp1[i];
                    Sum2 += Temp2[i];
                }
                Xexp = Sum1 / Temp1.Count;
                Yexp = Sum2 / Temp1.Count;
            }
            {
                {
                    StX = 0; StY = 0;
                    for (i = 0; i < Temp1.Count; i++)
                    {
                        // Data.EvalData.StandDevZ += Data.DataForWork[Data.CurrentSample][i] * Data.DataForWork[Data.CurrentSample][i] - Data.EvalData.ExpValues * Data.EvalData.ExpValues;
                        StX += Math.Pow((Temp1[i] - Xexp), 2);
                        StY += Math.Pow((Temp2[i] - Yexp), 2);
                    }
                    // Data.EvalData.StandDevZ *= (1.0) / Data.DataForWork[Data.CurrentSample].Count;
                    StX *= (1.0) / (Temp1.Count - 1);
                    StY *= (1.0) / (Temp2.Count - 1);
                    //Data.EvalData.StandDevZ = (Math.Sqrt(Data.EvalData.StandDevZ));
                    StX = (Math.Sqrt(StX));
                    StY = (Math.Sqrt(StY));
                }
            }

            {
                CrosSum = 0;
                for (i = 0; i < Temp1.Count; i++)
                {
                    CrosSum += Temp1[i] * Temp2[i];
                }
                CrosSum /= Temp1.Count;
                KK = ((double)Temp1.Count / (Temp1.Count - 1)) * ((CrosSum - Xexp * Yexp) / (StX * StY));
            }

            for (i = 0; i < Temp1.Count; i++)
            {
                Temp1[i] -= Xexp;
                Temp2[i] -= Yexp;
            }
            {
                double Sum1 = 0;
                double Sum2 = 0;
                for (i = 0; i < Temp1.Count; i++)
                {
                    Sum1 += Temp1[i];
                    Sum2 += Temp2[i];
                }
                Xexp = Sum1 / Temp1.Count;
                Yexp = Sum2 / Temp1.Count;
            }
            {
                StX = 0; StY = 0;
                for (i = 0; i < Temp1.Count; i++)
                {
                    // Data.EvalData.StandDevZ += Data.DataForWork[Data.CurrentSample][i] * Data.DataForWork[Data.CurrentSample][i] - Data.EvalData.ExpValues * Data.EvalData.ExpValues;
                    StX += Math.Pow((Temp1[i] - Xexp), 2);
                    StY += Math.Pow((Temp2[i] - Yexp), 2);
                }
                // Data.EvalData.StandDevZ *= (1.0) / Data.DataForWork[Data.CurrentSample].Count;
                StX *= (1.0) / (Temp1.Count - 1);
                StY *= (1.0) / (Temp2.Count - 1);
                //Data.EvalData.StandDevZ = (Math.Sqrt(Data.EvalData.StandDevZ));
                StX = (Math.Sqrt(StX));
                StY = (Math.Sqrt(StY));
            }
            {
                CrosSum = 0;
                for (i = 0; i < Temp1.Count; i++)
                {
                    CrosSum += Temp1[i] * Temp2[i];
                }
                CrosSum /= Temp1.Count;
                KK = ((double)Temp1.Count / (Temp1.Count - 1)) * ((CrosSum - Xexp * Yexp) / (StX * StY));
            }
            double tg2fi = 2 * ((CrosSum)/(StX*StX - StY*StY));
            double fi = Math.Atan(tg2fi) / 2;
            double t1, t2;
            double alfaxx, alfaxy, alfayx, alfayy;
            alfaxx = Math.Cos(fi);
            alfaxy = -1*Math.Sin(fi);
            alfayx = Math.Sin(fi);
            alfayy = Math.Cos(fi);
            for (i = 0; i < Temp1.Count; i++)
            {
                t1 = alfaxx * Temp1[i] + alfayx * Temp2[i];
                t2 = alfaxy * Temp1[i] + alfayy * Temp2[i];
                Temp1[i] = t1;
                Temp2[i] = t2;
            }
            ///////////////
            Data.DataForWork.Add(Temp1);
            Data.DataForWork.Add(Temp2);
            int temp = (int)Data.CurrentSample;
            for (Data.CurrentSample.set(Data.DataForWork.Count-2); Data.CurrentSample < Data.DataForWork.Count; Data.CurrentSample.set(Data.CurrentSample + 1))
            {
                Data.NamesOfFiles.Add("Результат дії МГК на двовимірну вибірку, вимір номер " + Math.Abs(Data.DataForWork.Count - Data.CurrentSample - 1));
                Data.StepBack.Add(new List<ToolsForWork.Changing>());
                //Data.DataForWork[Data.CurrentSample].Sort();
            }
            for (Data.CurrentSample.set(Data.DataForWork.Count - 1); Data.CurrentSample > 0 && (Data.DataForWork.Count != 0); Data.CurrentSample.set(Data.CurrentSample - 1))
            {
                if (Data.DataForWork[Data.CurrentSample].Count == 0)
                {
                    // LogOutputTextBox.Text += "File is empty" + Environment.NewLine;
                    //Data.DataForWork.RemoveAt(Data.CurrentSample);
                    //Data.StepBacTwoDemCurrentSample.RemoveAt(Data.CurrentSample);
                    //Data.NamesOfFiles.RemoveAt(Data.CurrentSample);
                }
            }
            Data.CurrentSample.set(temp);
            //this thing is needed but later
            //Data.DataForWork[Data.CurrentSample].Sort();
            //Data.NamesOfFiles.Add(OpeningDialog.FileName);
            Data.TwoDemStepBack.Add(new List<ToolsForWork.Changing>());
            StatusLabelNameOfFile.Text = Data.NamesOfFiles[Data.CurrentSample];
            HistData.NumberOfClassesChangedByUser = false;
            DistrFuncData.NumberOfClassesChangedByUser = false;
            Data.DistrCreated = false;
            Data.TwoDemDistrCreated = false;
            Data.TwoDemNamesOfFiles.Add("Результат дії МГК на вібирку "+ Data.TwoDemNamesOfFiles[Data.TwoDemCurrentSample]);
            if (Data.DataForWork.Count != 0)
            {
                Data.TwoDemSamples.Add(new int[] { Data.DataForWork.Count - 2, Data.DataForWork.Count - 1 });
              //  Data.CurrentSample.set(0);
                Data.TwoDemCurrentSample.set(Data.TwoDemSamples.Count - 1);
                Build();
                BuildTwoDem();
            }
        }
    }

    class PointOfStart
    {
        [STAThread]
        static void Main(string[] args)
        {

            //Checking arguments for help request
            for (int i = 0; i < args.Length; i++)
            {
                if ((args[i] == ("-?")) || (args[i] == ("-help")) || (args[i] == ("/help")) || (args[i] == ("/h")) || (args[i] == ("/?")) || (args[i] == ("-h")))
                {
                    Console.WriteLine("Some help");
                    return;
                }
            }
            //Starting ...
            BodyOfForm MainForm = new BodyOfForm();
            Application.EnableVisualStyles();
            Application.Run(MainForm);
        }
    }
}
