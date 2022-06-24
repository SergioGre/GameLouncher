using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;

namespace GameLouncher
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();



            Global.mainForm = this;
            Global.BgImage = bgImage;
            Global.mainBut = button1;
            Global.theName = textName;

            Global.picBox1 = pictureBox1;
            Global.picBox2 = pictureBox2;
            Global.picBox3 = pictureBox3;

            Global.waylb = waylable;


            updateList();


        }


        public void GameEnter(Image img)
        {
            bgImage.Image = img;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Process.Start(Global.way);


        }

        private void LayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bgImage_Click(object sender, EventArgs e)
        {

        }

        private void bgImage_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }


        public class Global
        {
            public static Form mainForm;
            public static PictureBox BgImage;
            public static Button mainBut;
            public static Label theName;

            public static PictureBox picBox1;
            public static PictureBox picBox2;
            public static PictureBox picBox3;

            public static string way;
            public static Label waylb;
        }

        [Serializable]
        public class GameApp
        {
            [XmlElement("ProcesWay")]
            public string processWay;
            [XmlElement("Name")]
            public string name;

            [XmlElement("Scrn1")]
            public string scrn1;
            [XmlElement("Scrn2")]
            public string scrn2;
            [XmlElement("Scrn3")]
            public string scrn3;
            [XmlElement("Scrn4")]
            public string scrn4;
            [XmlIgnore]
            Icon io;

            public Button CreateButton()
            {
                io = Icon.ExtractAssociatedIcon(processWay);

                Button gameBut = new Button()
                {
                    Size = new Size(64, 64),
                    BackgroundImage = io.ToBitmap(),
                    BackgroundImageLayout = ImageLayout.Stretch,

                };
                gameBut.Click += new EventHandler(butClick);

                return gameBut;
            }


            public void startGame()
            {
                Process.Start(processWay);

            }

            public GameApp(string gameName, string way, string pictureWay1, string pictureWay2, string pictureWay3, string pictureWay4)
            {
                scrn1 = pictureWay1;
                scrn2 = pictureWay2;
                scrn3 = pictureWay3;
                scrn4 = pictureWay4;

                name = gameName;
                processWay = way;


            }

            public GameApp()
            {

            }

            private void butClick(object sender, EventArgs e)
            {
                Global.BgImage.BackgroundImage = new Bitmap(scrn1);


                Global.way = processWay;
                Global.theName.Text = name;

                Global.picBox1.BackgroundImage = new Bitmap(scrn2);
                Global.picBox1.Visible = true;

                Global.picBox2.BackgroundImage = new Bitmap(scrn3);
                Global.picBox2.Visible = true;

                Global.picBox3.BackgroundImage = new Bitmap(scrn4);
                Global.picBox3.Visible = true;

                Global.waylb.Text = processWay;
            }

            private void StartGames(object sender, EventArgs e)
            {
                Process.Start(processWay);
            }


        }

        [Serializable]
        public class Serializ
        {

            public static void Save(List<GameApp> GmList)
            {
                FileStream fs = new FileStream("SaveLoad.xml", FileMode.OpenOrCreate);
                XmlSerializer serializer = new XmlSerializer(typeof(List<GameApp>));
                serializer.Serialize(fs, GmList);

                fs.Close();
            }
            public static List<GameApp> Load(List<GameApp> GmList)
            {
                FileStream fs = new FileStream("SaveLoad.xml", FileMode.OpenOrCreate);
                XmlSerializer serializer = new XmlSerializer(typeof(List<GameApp>));

                GmList = (List<GameApp>)serializer.Deserialize(fs);

                fs.Close();

                return GmList;
            }
        }




        private void UpdateBut_Click(object sender, EventArgs e)
        {
            updateList();
        }

        void updateList()
        {
            List<GameApp> gameList = new List<GameApp>();

            gameList = Serializ.Load(gameList);

            Form2.gameList = gameList;


            LayoutPanel1.Controls.Clear();
            for (int i = 0; i < gameList.Count; i++)
            {
                LayoutPanel1.Controls.Add(gameList[i].CreateButton());
            }


        }


    }

}   

    


