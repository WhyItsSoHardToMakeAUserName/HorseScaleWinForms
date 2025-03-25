using HorseScale.services;
using System.Diagnostics;
using System.Windows.Forms;

namespace HorseScale
{
    public partial class Form1 : Form
    {
        private Point? Point1 = new Point(0, 0);
        private Point? Point2 = new Point(0, 0);
        private double CmPerPx = 0;
        private double HeightAtTheWithers = 0;
        private double ObliqueBodyLength = 0;
        private double ChestCircumference = 0;
        private double PasternGirth = 0;
        private string SelectedBreed = "";

        private double? ReferenceLengthInCm = 100;
        private double? HorseMassInKg = 100;

        private int CurrentState = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void начатьИзмерениеПромеровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialogue = new MeasurementParameterInputDialogue())
            {
                if (dialogue.ShowDialog() == DialogResult.OK)
                {
                    SelectedBreed = dialogue.SelectedBreed;
                    HorseBreedLabel.Text = $"Порода выбранной лошади - {SelectedBreed}";
                    HorseMassInKg = dialogue.HorseMassInKg;
                    HorseMassLabel.Text = $"Масса выбранной лошади - {HorseMassInKg} кг";
                }
            }
            ChangeAppState(3);
        }

        private void setCmPerPxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeAppState(1);
        }

        private void загрузитьИзображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(openFileDialog.FileName);
                // Load the image into the PictureBox
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.Size = pictureBox1.Image.Size; // Set the PictureBox size to match the image size


            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            // Get the mouse click position relative to the PictureBox
            Point clickPosition = pictureBox.PointToClient(MousePosition);

            if (Point1 == null)
            {
                Point1 = clickPosition;
                Point1Label.Text = $"Координаты первой выбранной точки {Point1}";
            }
            else if (Point2 == null)
            {
                Point2 = clickPosition;
                Point2Label.Text = $"Координаты первой выбранной точки {Point2}";
                HandleStateLogic();
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HandleStateLogic()
        {
            if (ReferenceLengthInCm == null && HorseMassInKg == null) return;
            switch (CurrentState)
            {
                case 1:
                    //CmPerPx calculation
                    if (ReferenceLengthInCm == null) return;

                    CmPerPx = (double)(ReferenceLengthInCm / DistanceBetweenTwoPointsInPx(Point1, Point2));
                    CmPerPxLabel.Text = $"{CmPerPx} сантиметров на пиксель";
                    break;
                case 2:
                    //Distance in Cm between two points with reference CmPerPx
                    DistanceLabel.Text = $"Дистанция между двумя точками в см - {DistanceBetweenTwoPointsInCm(Point1, Point2)}";
                    break;
                case 3:
                    if (HeightAtTheWithers == 0)
                    {
                        HeightAtTheWithers = CmPerPx * YAxisDistanceBetweenTwoPointsInPx(Point1, Point2);
                        HeightAtTheWithersLabel.Text = $"Высота в холке - {HeightAtTheWithers}";
                        ResetPoints();
                    }
                    else if (ObliqueBodyLength == 0)
                    {
                        ObliqueBodyLength = DistanceBetweenTwoPointsInCm(Point1, Point2);
                        ObliqueBodyLengthLabel.Text = $"Косая длина тела - {ObliqueBodyLength}";
                        ChestCircumference = Formula.GetFormula(SelectedBreed)((double)HorseMassInKg, HeightAtTheWithers, ObliqueBodyLength);
                        ChestCircumferenceLabel.Text = $"Обхват груди - {ChestCircumference}";
                        ResetPoints();

                    }
                    else if (PasternGirth == 0)
                    {
                        PasternGirth = Math.PI * (3 * (DistanceBetweenTwoPointsInCm(Point1, Point2) + 3) - Math.Sqrt((3 * DistanceBetweenTwoPointsInCm(Point1, Point2) + 3) * (DistanceBetweenTwoPointsInCm(Point1, Point2) + 3 * 3)));
                        PasternGirthLabel.Text = $"Обхват пясти - {PasternGirth}";
                        ChangeAppState(0);
                    }
                    else
                    {
                        HeightAtTheWithers = 0;
                        ObliqueBodyLength = 0;
                        PasternGirth = 0;
                        HeightAtTheWithersLabel.Text = $"Высота в холке - {HeightAtTheWithers}";
                        ObliqueBodyLengthLabel.Text = $"Косая длина тела - {ObliqueBodyLength}";
                        ChestCircumferenceLabel.Text = $"Обхват груди - {ChestCircumference}";
                        PasternGirthLabel.Text = $"Обхват пясти - {PasternGirth}";

                        ResetPoints();
                    }
                    break;
                default:
                    // Default state logic
                    break;
            }
        }

        public double DistanceBetweenTwoPointsInPx(Point? point1, Point? point2)
        {
            if (point1 == null || point2 == null) return 0;
            return Math.Sqrt(Math.Pow(point1.Value.X - point2.Value.X, 2) + Math.Pow(point1.Value.Y - point2.Value.Y, 2));
        }
        public double DistanceBetweenTwoPointsInCm(Point? point1, Point? point2)
        {
            if (point1 == null || point2 == null) return 0;
            return CmPerPx * Math.Sqrt(Math.Pow(point1.Value.X - point2.Value.X, 2) + Math.Pow(point1.Value.Y - point2.Value.Y, 2));
        }

        public double YAxisDistanceBetweenTwoPointsInPx(Point? point1, Point? point2)
        {
            if (point1 == null || point2 == null) return 0;
            return Math.Abs(point1.Value.Y - point2.Value.Y);
        }

        public void ChangeAppState(int stateValue)
        {
            CurrentState = stateValue;
            if (CurrentState != 0)
            {
                ResetPoints();
            }
        }

        private void ResetPoints()
        {
            Point1 = null;
            Point2 = null;
        }

        private void measureDistanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeAppState(2);
        }



        private void HeightAtTheWithers_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HorseBreedLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
