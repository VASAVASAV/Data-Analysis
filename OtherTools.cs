using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Args;
using System.Windows.Forms;

namespace thing_2._1
{
    class TableForMultiDem : Form
    {

        private DataGridView dataGridView1;
        private Button button1;
        private bool SelfCall = false;
        double[,] matrix;

        public TableForMultiDem(int NumOfDim, double[,] matrixres, int type)
        {
            InitializeComponent();
            matrix = matrixres;
            int i;
            switch (type)
            { 
                case 0:
                    {
                        for (i = 0; i < NumOfDim; i++)
                        {
                            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        }
                        break;
                    }
                case 1:
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[0].HeaderText = "Матсподівання";
                        break;
                    }
            }
            for (i = 0; i < NumOfDim; i++)
            {
                dataGridView1.Rows.Add();
            }
        }
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(350, 251);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Підтвердити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TableForMultiDem
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(350, 315);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TableForMultiDem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            int i, j;
            try
            {
                for (i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        matrix[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                    }
                }
            }
            catch
            {
                DialogResult = DialogResult.Abort;
                this.Close();
            }
            DialogResult = DialogResult.OK;
            this.Close();

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns.Count == 0 || dataGridView1.Rows.Count == 0)
                return;
            int RowId = e.RowIndex;
            int ColId = e.ColumnIndex;
            int i, j;
            if (RowId == ColId)
            {
                try
                {
                    double St = Math.Sqrt(Convert.ToDouble(dataGridView1.Rows[ColId].Cells[ColId].Value));
                    for (i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (i != ColId)
                        {
                            SelfCall = true;
                            dataGridView1.Rows[i].Cells[ColId].Value = St * (Convert.ToDouble(dataGridView1.Rows[i].Cells[ColId].Value));
                            dataGridView1.Rows[ColId].Cells[i].Value = St * (Convert.ToDouble(dataGridView1.Rows[ColId].Cells[i].Value));
                            SelfCall = false;
                        }
                    }
                }
                catch
                {
                }
            }
            else
            {
                if (!SelfCall)
                {
                    dataGridView1.Rows[ColId].Cells[RowId].Value = dataGridView1.Rows[RowId].Cells[ColId].Value;
                }
            }
        }
    }
    class Evaletions
    {
        public double ExpValues;
        public double ExpValDev;
        public double SampleMed;
        public double WallshMed;
        public double TrunMean;
        public double StandDevZ;
        public double StandDevNeZ;
        public double StandDevDev;
        public double MAD;
        public double Skewness;//CoefOfAssimetry;
        public double SkewnessDev;
        public double KurtosisZ;//Ecscess;
        public double KurtosisDev;
        public double KurtosisNeZ;
        public double ContrKurtosis;
        public double CoV;
        public Evaletions()
        {
            ExpValues = 0;
            SampleMed = 0;
            WallshMed = 0;
            TrunMean = 0;
            StandDevZ = 0;
            StandDevNeZ = 0;
            MAD = 0;
            Skewness = 0; //CoefOfAssimetry;
            KurtosisZ = 0;//Ecscess;
            KurtosisNeZ = 0;
            ContrKurtosis = 0;
            CoV = 0;
        }
    }

    class TwoDemEvaletions
    {
        double ExpX;
        double ExpY;
        double StandDevX;
        double StandDevY;
        public TwoDemEvaletions()
        {
            ExpX = 0 ;
            ExpY = 0;
            StandDevX = 0;
            StandDevY = 0;
        }
    }

    class DataOfForm
    {
        public int PictureNumber;
        public List<int[]> TwoDemSamples;
        public List<int[]> MultiDemSamples;
        public ArgIntMM NumberOfNum;
        public double[] Parameters;
        public double[] TwoDemPars;
        public double[] MultiDemPars;
        public bool Scaled;
        public bool VarNeeded;
        public bool MEDNeeded;
        public bool DistrCreated;
        public bool TwoDemDistrCreated;
        public ArgFloatMM Gamma;
        public ArgStr TypeOfDistr; 
        public Evaletions EvalData;
        public TwoDemEvaletions TDEvalData;
        public ArgIntMM CurrentSample;
        public ArgIntMM TwoDemCurrentSample;
        public ArgIntMM MultiDemCurrentSample;
        public List<List<double>> DataForWork;
        //public List<List<double[]>> TwoDemDataForWork;
        public List<string> NamesOfFiles;
        public List<string> TwoDemNamesOfFiles;
        public List<string> MultiNamesOfFiles;
        public List<List<ToolsForWork.Changing>> StepBack;
        public List<List<ToolsForWork.Changing>> TwoDemStepBack;
        public List<List<ToolsForWork.Changing>> MultiDemStepBack;
        //public List<List<ToolsForWork.Changing>> 
        public string NameOfFile;
        public DataOfForm()
        {
            PictureNumber = 0;
            MultiDemSamples = new List<int[]>();
            TwoDemSamples = new List<int[]>();
            Parameters = new double[] {0,0};
            TwoDemPars = new double[] { 0, 0,0,0 };
            VarNeeded = true;
            MEDNeeded = true;
            Scaled = false;
            Gamma = new ArgFloatMM(0.05, "", "Ймовірність для довірчих інтервалів", "Ймовірність промаху функції розподілу повз довірчі інтервали", "<Size>");
            DistrCreated = false;
            TwoDemDistrCreated = false;
            TypeOfDistr = new ArgStr(PossibleDistributions.Distributions[0], "", "Виберіть тип розподілу", "Тип розподілу, який буде змодельовано", "<>", PossibleDistributions.Distributions);
            NumberOfNum = new ArgIntMM(5, "s", "Поточна вибіркаКількість знаків після коми", "Кількість знаків після коми, яка буде відображатися у оцінках, результатах обчислень та інш.", "<Size>");
            CurrentSample = new ArgIntMM(0, "s", "Поточна вибірка", "Виберіть вибірку, з якою будете працювати", "<Size>");
            TwoDemCurrentSample = new ArgIntMM(0, "s", "Поточна двовимірна вибірка ", "Виберіть двовимірну вибірку, з якою будете працювати", "<Size>");
            MultiDemCurrentSample = new ArgIntMM(0, "s", "Поточна багатовимірна вибірка ", "Виберіть багатовимірну вибірку, з якою будете працювати", "<Size>");
            //CurrentSample.setMin(0);  //CurrentSample.setMax(0);
            NameOfFile = null;
            DataForWork = new List<List<double>>();
            //TwoDemDataForWork = new List<List<double[]>>();
            NamesOfFiles =  new List<string>();
            TwoDemNamesOfFiles = new List<string>();
            StepBack = new List<List<ToolsForWork.Changing>>();
            EvalData = new Evaletions();
            TDEvalData = new TwoDemEvaletions();
            TwoDemStepBack = new List<List<ToolsForWork.Changing>>();
            MultiDemStepBack = new List<List<ToolsForWork.Changing>>();
        }
    }
    /// 
    /// 
    ///
    class DataOfHist
    {
        public ArgStr ColorOfHist;
        public ArgStr ColorOfTheor;
        public ArgIntMM NumberOfClasses;
        //public int NumberOfClasses;
        public bool NumberOfClassesChangedByUser;
        public double Step;
        public double MaxLimit;
        public double MinLimit;
        public DataOfHist()
        {
            NumberOfClassesChangedByUser = false;
            NumberOfClasses = new ArgIntMM(1, "s", "Кількість класів", "Кількість класів для гістограми", "<Size>");
            ColorOfHist = new ArgStr("Black", "p", "Колір гістограми", "Колір, яким будуть відображені стовпці гістограми", "<color>", PossibleColours.colours);
            ColorOfTheor = new ArgStr("Red", "p", "Колір статистично відтвореної функції щільності", "Колір, яким буде зображено статистично відтворену і масштабовану функцію щільності після моделювання","", PossibleColours.colours);
            NumberOfClasses.setMin(1);
            MinLimit = 0;
            MaxLimit = 0;
            Step = 0;
        }
    }

    class DataOfDsitrFun
    {
        public double[] DistrFunction;
        public ArgIntMM NumberOfClasses;
        public ArgStr ColorOfLimits;
        public ArgStr ColorOfTheorFunc;
        public ArgStr ColorOfEmpFunc;
        public ArgStr ColorOfClassFunc;
        //public int NumberOfClasses;
        public bool NumberOfClassesChangedByUser;
        public double Step;
        public double MaxLimit;
        public double MinLimit;
        public DataOfDsitrFun()
        {
            DistrFunction = null;
            ColorOfLimits = new ArgStr("DarkGreen", "p", "Колір довірчих інтервалів", "Цим кольором будуть малюватися довірчі інтервали після відтворення розподілу", "<color>", PossibleColours.colours);
            ColorOfTheorFunc = new ArgStr("Grey", "p", " Колір статистично відтвореної функції розподілу", "Цим кольором буде малюватися статистична функція розподілу після відтворення розподілу", "<color>", PossibleColours.colours); 
            ColorOfEmpFunc = new ArgStr("Red", "p", "Колір емпіричної функції розподілу", "Цим кольором буде зображено емпіричну функцію розподілу", "<color>", PossibleColours.colours);
            ColorOfClassFunc = new ArgStr("Black", "p", "Колір емпіричної функції розподілу, розбитої на класи", "Цим кольором буде зображено емпіричну функцію розподілу, розбиту на класи", "<color>", PossibleColours.colours); 
            NumberOfClassesChangedByUser = false;
            NumberOfClasses = new ArgIntMM(1, "s", "Кількість класів", "Кількість класів для емпіричної функції розподілу, розбитої на класи", "<Size>");
            NumberOfClasses.setMin(1);
            MinLimit = 0;
            MaxLimit = 0;
            Step = 0;
        }
    }

    class ParamsExp
    {
        public static string[] parameters;
        static ParamsExp()
        {
            parameters = new string[] { "λ" };
        }
    }

    class ParamsNorm
    {
        public static string[] parameters;
        static ParamsNorm()
        {
            parameters = new string[] { "σ", "μ" };
        }
    }

    class ParamsRel
    {
        public static string[] parameters;
        static ParamsRel()
        {
            parameters = new string[] { "σ" };
        }
    }

    class ParamsLaplas
    {
        public static string[] parameters;
        static ParamsLaplas()
        {
            parameters = new string[] { "λ", "μ" };
        }
    }

    class ParamsArc
    {
        public static string[] parameters;
        static ParamsArc()
        {
            parameters = new string[] { "a" };
        }
    }

   /* class ParamsRavn
    {
        public static string[] parameters;
        static ParamsRavn()
        {
            parameters = new string[] { "a", "b"};
        }
    }

    class ParamsVeib
    {
        public static string[] parameters;
        static ParamsVeib()
        {
            parameters = new string[] { "α", "β" };
        }
    }*/

    static class PossibleColours
    {
        public static string[] colours = new string[] { "White", "Black", "DarkBlue", "Gray", "DarkMagenta", "DarkBlue", "DarkGreen", "Red" };
        /*static PossibleColors()
        {
            colours = new string[] { "White", "Black", "DarkBlue", "Gray", "DarkMagenta", "DarkBlue", "DarkGreen", "Red" };
        }*/
    }

    class PossibleDistributions
    {
        public static string[] Distributions = new string[] { "Експоненціальний", "Нормальний", "Релея", "Релея - старий", "Арксинуса", "Арксинуса - старий", "Лапласа", "Рівномірний", "Вейбулла" };
        /*static PossibleDistributions()
        {
            Distributions = new string[] { "Експоненціальний", "Нормальний", "Релея", "Релея - старий", "Арксинуса", "Арксинуса - старий", "Лапласа", "Рівномірний", "Вейбулла" };
        }*/
    }
    class PossibleCriterion
    {
        public static string[] Criterions;
        static PossibleCriterion()
        {
            Criterions = new string[] { "Уточнений Колмогорова", "χ^2 Пірсона" };
        }
    }
    class PossibleOperations
    {
        public static string[] operations;
        static PossibleOperations()
        {
            operations = new string[] {"Зсув","Множення", "Логарифмування",  "Піднесення у степінь" };
        }
    }
    class PossibleMultiHips
    {
        public static string[] Hips;
        static PossibleMultiHips()
        {
            Hips = new string[] {"Рівність середніх за умови рівності ДС","збіг к середніх при розбіжності ДС", "збіг ДС"};
        }
    }
    class PossibleDepen
    {
        public static string[] depen;
        static PossibleDepen()
        {
            depen = new string[] { "Залежні", "Незалежні" };
        }
    }
    class IndepenCritTwo
    {
        public static string[] crit;
        static IndepenCritTwo()
        {
            crit = new string[] { "Перевірка збігу середніх", "Перевірка збігу дисперсій", "критерій Бартлетта", "Однофакторний дисперсійний аналіз", "Критерій Вілкоксона", "U-критерій Манна–Уїтні", "критерій різниці середніх рангів вибірок" };//, "критерій однорідності Смирнова-Колмогорова", "Н-критерій"
        }
    }
    class DepenCritTwo
    {
        public static string[] crit;
        static DepenCritTwo()
        {
            crit = new string[] { "Перевірка збігу середніх", "Перевірка збігу дисперсій", "критерій Бартлетта", "Однофакторний дисперсійний аналіз", "Критерій Вілкоксона", "U-критерій Манна–Уїтні", "критерій різниці середніх рангів вибірок", "Н-критерій", "критерій Аббе" };//, "критерій однорідності Смирнова-Колмогорова","Критерій знаків",
        }
    }
    class IndepenCritK
    {
        public static string[] crit;
        static IndepenCritK()
        {
            crit = new string[] { "критерій Бартлетта", "Однофакторний дисперсійний аналіз" };// "Н-критерій" 
        }
    }
    class DepenCritK
    {
        public static string[] crit;
        static DepenCritK()
        {
            crit = new string[] { "критерій Бартлетта", "Однофакторний дисперсійний аналіз" };//"Н-критерій"
        }
    }
	/// 
	/// 
	///
	class ToolsForWork
	{

		public enum TypeOfCHange
		{
			deleted,
			sliped,
			logarithm,
			powered,
			standardized,
			multiplyed,
			massivedelete,
			added,
			twodemdeleted,
			multidemdeleted,
			multidemstand
		}
		public class Changing
		{
			public TypeOfCHange ChangeStyle;
			public double[] paramsOfChange;
			public Changing(TypeOfCHange inpChangeStyle, double[] inpparamsOfChange)
			{
				ChangeStyle = inpChangeStyle;
				paramsOfChange = inpparamsOfChange;
			}
		}
		public static double ComputeDistrExp(double x, double[] parametrs)
		{
			if (x >= 0)
				return 1 - Math.Pow(Math.E, -1 * parametrs[0] * x);
			else return 0;
		}
		public static double ComputeDistrArc(double x, double[] parametrs)
		{
			if ((x < (-1) * parametrs[0]) || (x > parametrs[0]))
			{
				if (x < (-1) * parametrs[0])
				{
					return 0;
				}
				else
					return 1;
			}
			else
			{
				return 0.5 + (1.0 / Math.PI) * Math.Asin(x / parametrs[0]);
			}
		}
		public static double ComputeDistrRel(double x, double[] parametrs)
		{
			if (x >= 0)
				return 1 - Math.Pow(Math.E, ((-1 * x * x) / (2 * parametrs[0] * parametrs[0])));
			else
				return 0;
		}
		public static double ComputeDistrLaps(double x, double[] parametrs)
		{
			if (x < parametrs[0])
				return 0.5 * Math.Pow(Math.E, (parametrs[1] * (x - parametrs[0])));
			else
				return 1 - 0.5 * Math.Pow(Math.E, (-1 * parametrs[1] * (x - parametrs[0])));
		}
		public static double ComputeDistrVieb(double x, double[] parametrs)
		{
			if (x >= 0)
				return 1 - Math.Pow(Math.E, ((Math.Pow(x, parametrs[1]) * -1) / parametrs[0]));
			else return 0;
		}
		public static double ComputeDistrRivn(double x, double[] parametrs)
		{
			if ((x > parametrs[0]) && (x < parametrs[1]))
				return (x - parametrs[0]) / (parametrs[1] - parametrs[0]);
			else
			{
				if (x < parametrs[0])
					return 0;
				else
					return 1;
			}
		}
		public static double ComputeDistr(ArgStr TypeOF, double x, double[] par)
		{
			switch (TypeOF)
			{
				case "Експоненціальний":
					{
						return ComputeDistrExp(x, par);
					}
				case "Нормальний":
					{
						return ComputeFi((x - par[0]) / par[1]);
					}
				case "Релея":
					{
						return ComputeDistrRel(x, par);
					}
				case "Релея - старий":
					{
						return ComputeDistrRel(x, par);
					}
				case "Арксинуса":
					{
						return ComputeDistrArc(x, par);
					}
				case "Арксинуса - старий":
					{
						return ComputeDistrArc(x, par);
					}
				case "Лапласа":
					{
						return ComputeDistrLaps(x, par);
					}
				case "Рівномірний":
					{
						return ComputeDistrRivn(x, par);
					}
				case "Вейбулла":
					{
						return ComputeDistrVieb(x, par);
					}
				default: return 0;
			}
		}
		public static double ComputeMediana(List<double> Target)
		{
			if (Target.Count == 1)
			{
				return Target[0];
			}
			List<double> Aim = new List<double>();
			for (int i = 0; i < Target.Count; i++)
			{
				Aim.Add(Target[i]);
			}
			Aim.Sort();
			double result = 0;
			if (Aim.Count % 2 == 0)
			{
				result = ((Aim[(int)Math.Floor((double)Aim.Count / 2)] + Aim[(int)Math.Ceiling((double)Aim.Count / 2)]) / 2);
			}
			else
			{
				result = (Aim[(int)Aim.Count / 2]);
			}
			return result;
		}
		public static void RemoveComments(ref string s)
		{
			char[] b = new char[s.Length];
			char[] z = s.ToCharArray();
			int Len = 0;
			for (int i = 0; i < z.Length; i++)
			{
				if (z[i] != '#')
				{
					Len++;
					b[i] = z[i];
				}
				else break;
			}

			if (b.Length == 0)
				s = null;
			s = "";
			for (int i = 0; i < Len; i++)
			{
				s += b[i];
			}
		}
		public static double ComputeTrunMean(List<double> Target, double alfa)
		{
			int k = (int)Math.Floor(alfa * Target.Count);
			double TrunMean = 0;
			for (int i = k; i < Target.Count - k; i++)
			{
				TrunMean += Target[i];
			}
			TrunMean *= (1.0) / (Target.Count - 2 * k);
			return TrunMean;
		}
		public static int ComputeSizeOfPoint(int Number)
		{
			if (Number < 13)
			{
				if (Number < 4)
					return 5;
				if (Number > 8)
					return 3;
				return 4;
			}
			else
			{
				if (Number > 25)
					return 1;
				return 2;
			}
		}

		public static double ComputeKol(double zet, int Number)
		{
			double sum = 0;
			double tempsum = 0;
			double k = 1;
			do
			{
				double f1 = fu1(k);
				double f2 = fu2(k);
				double MainPart = Math.Pow(-1, k) * Math.Exp(-2 * k * k * zet * zet);
				double a = 1 - (2 * k * k * zet) / (3 * Math.Sqrt(Number));
				double b = (1.0 / (18 * Number)) * ((f1 - 4 * (f1 + 3)) * k * k * zet * zet + 8 * Math.Pow(k, 4) * Math.Pow(zet, 4));
				double c = ((k * k * zet) / (27 * Math.Pow(Number, 3.0 / 2))) *
						   ((f2 * f2) / 5 - ((4 * (f2 + 45) * k * k * zet * zet) / 15) + 8 * Math.Pow(k, 4) * Math.Pow(zet, 4));
				tempsum = MainPart * (a - b + c);
				sum += tempsum;
				k++;

			}
			while (Math.Abs(tempsum) >= 0.000001);
			/*double sum1 = 0; ;
            k = 0;
            do
            {
                k++;
                double MainPart = Math.Pow(-1, k) * Math.Exp(-2 * k * k * zet * zet);
                tempsum = MainPart;
                sum1 += tempsum;

            }
            while (tempsum >= 0.0000001);
            sum1 = 1 + 2 * sum1;*/
			sum = 1 + 2 * sum;
			return sum;
		}

		public static double fu1(double k)
		{
			return k * k - 0.5 * (1 - Math.Pow(-1, k));
		}
		public static double fu2(double k)
		{
			return 5 * k * k + 22 - 7.5 * (1 - Math.Pow(-1, k));
		}
		public static int CompNumOfClasses(int Number)
		{
			int FinalNumber = 0;
			if (Number > 100)
			{
				FinalNumber = (int)Math.Ceiling(Math.Pow(Number, 1.0 / 3));
			}
			else
			{
				FinalNumber = (int)Math.Pow(Number, 1.0 / 2);
			}
			if ((FinalNumber % 2) == 0)
			{
				return FinalNumber + 1;
			}
			else
			{
				return FinalNumber;
			}
		}
		public static double ComputeRawMoment(List<double> Target, int Number)
		{
			double sum = 0;
			for (int i = 0; i < Target.Count; i++)
			{
				sum += Math.Pow(Target[i], Number);
			}
			sum = sum / Target.Count;
			return sum;
		}

		public static double ComputeCentralMoment(List<double> Target, int Number)
		{
			double sum = 0;
			double Nu1 = ComputeRawMoment(Target, 1);
			for (int i = 0; i < Target.Count; i++)
			{
				sum += Math.Pow(Target[i] - Nu1, Number);
			}
			sum *= (1.0) / Target.Count;
			return sum;
		}

		public static double ComputeFi(double u)
		{
			if (u < 0)
			{
				return 1 - ComputeFi(Math.Abs(u));
			}
			double ro = 0.2316419;
			double t = 1.0 / (1 + ro * u);
			double b1 = 0.31938153;
			double b2 = -0.356563782;
			double b3 = 1.781477937;
			double b4 = -1.821255978;
			double b5 = 1.330274429;
			return 1 - (1.0 / Math.Sqrt(2 * Math.PI)) * Math.Pow(Math.E, ((-1 * u * u) / 2)) * (b1 * t + b2 * t * t + b3 * t * t * t + b4 * t * t * t * t + b5 * t * t * t * t * t);
		}

		public static int FindMinLength(string[] InputStrings)
		{
			string[] valuesInLine;
			char[] separators = new char[] { ' ', '\t', '\n' };
			int MinVal = 10000;
			for (int i = 0; i < InputStrings.Length; i++)
			{
				ToolsForWork.RemoveComments(ref InputStrings[i]);
				valuesInLine = InputStrings[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
				if (MinVal >= valuesInLine.Length && valuesInLine.Length != 0)
				{
					MinVal = valuesInLine.Length;
				}
			}
			return MinVal;
		}

		public static void FillDGVText(DataGridView TargetToFill, DataGridView TargetFrom)
		{
			TargetToFill.Rows.Clear();
			TargetToFill.Columns.Clear();
			int i, j;
			TargetToFill.AllowUserToAddRows = TargetFrom.AllowUserToAddRows;
			TargetToFill.AllowUserToDeleteRows = TargetFrom.AllowUserToDeleteRows;
			TargetToFill.AllowUserToOrderColumns = TargetFrom.AllowUserToOrderColumns;
			for (i = 0; i < TargetFrom.Columns.Count; i++)
			{
				TargetToFill.Columns.Add(new DataGridViewTextBoxColumn());
				TargetToFill.Columns[i].HeaderText = TargetFrom.Columns[i].HeaderText;
				TargetToFill.Columns[i].ReadOnly = TargetFrom.Columns[i].ReadOnly;
			}
			for (i = 0; i < TargetFrom.Rows.Count; i++)
			{
				TargetToFill.Rows.Add();
			}
			for (i = 0; i < TargetFrom.Columns.Count; i++)
			{
				for (j = 0; j < TargetFrom.Rows.Count; j++)
				{
					TargetToFill.Rows[j].Cells[i].Value = TargetFrom.Rows[j].Cells[i].Value;
					TargetToFill.Rows[j].Cells[i].Style.BackColor = TargetFrom.Rows[j].Cells[i].Style.BackColor;
				}
			}

		}

		public static double[,,] GetEileganValues (double[,] TargMatr, double ep)
		{
			int i, j;
			int Size = TargMatr.GetLength(0);
			double[,] V = new double[Size,Size];
			for (i = 0; i < Size; i++)
			{
				V[i,i] = 1;
			}
			double[,] matrix = new double[Size,Size];
			for(i =0; i < Size; i++)
			{
				for (j = 0; j < Size; j++)
				{
					matrix[i, j] = TargMatr[i, j];
				}
			}
			int Numi = 0;
			int Numj = 1;
			double Fi;
			double P;
			for (i = 0; i < Size - 1; i++)
			{
				for (j = i + 1; j < Size; j++)
				{
                    if (Math.Abs(matrix[i, j]) > Math.Abs(matrix[Numi, Numj]))
					{
						Numi = i;
						Numj = j;
					}
				}
			}
			int k = 0;
            while (Math.Abs(matrix[Numi, Numj]) > ep)//TargMatr
			{
                P = (2 * matrix[Numi, Numj]) / (matrix[Numi, Numi] - matrix[Numj, Numj]);
				Fi = 0.5 * Math.Atan(P);
				double[,] H = new double[Size,Size];
				double[,] Ht = new double[Size,Size];
				for (i = 0; i < Size; i++)
				{
					H[i,i] = 1;
					Ht[i,i] = 1;
				}
				double MyCos = Math.Cos(Fi);
				double MySin = Math.Sin(Fi);
				H[Numi,Numi] = MyCos;
				H[Numj,Numj] = MyCos;
				Ht[Numi,Numi] = MyCos;
				Ht[Numj,Numj] = MyCos;

				H[Numi,Numj] = -1 * MySin;
				H[Numj,Numi] = MySin;
				Ht[Numi,Numj] = MySin;
				Ht[Numj, Numi] = -1 * MySin;
				V = Matrixes.Multiply(V, H);

				matrix = Matrixes.Multiply(Matrixes.Multiply(Ht, matrix),H);

				for (i = 0; i < Size - 1; i++)
				{
					for (j = i + 1; j < Size; j++)
					{
						if (Math.Abs(matrix[i,j]) > Math.Abs(matrix[Numi,Numj]))
						{
							Numi = i;
							Numj = j;
						}
					}
				}
				k++;
			}
			for (i = 0; i < Size-1; i++)
			{
				for (j = i+1; j < Size; j++)
				{
					if (matrix[j, j] > matrix[i, i])
					{
						double temp = matrix[j, j];
						matrix[j, j] = matrix[i, i];
						matrix[i, i] = temp;
						for (k = 0; k < Size; k++)
						{
							temp = V[j, k];
							V[j, k] = V[i, k];
							V[i, k] = temp;
						}
					}
				}
			}
			double[,,] result = new double[2, Size, Size];
			for (i = 0; i < Size; i++)
			{
				for (j = 0; j < Size; j++)
				{
					result[0, i, j] = matrix[i, j];
					result[1, i, j] = V[i, j];
				}	
			}
			return result;
				
		}

    }
}