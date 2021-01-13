using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubikCube
{
    public partial class RubikCubeForm : Form
    {
        private SetupForm _setupForm;
        private Label[] digitLabel;
        private Button[] moveVerticalUpButton;
        private Button[] moveVerticalDownButton;
        private Button[] moveHorizonLeftButton;
        private Button[] moveHorizonRightButton;
        private int _rubiksize;
        private int _digitLabelSize;
        private List<Button> _buttonList;
        private bool _isFirst = true;
        internal int _clickCount;
        Random random = new Random();
        public RubikCubeForm()
        {
            _setupForm = new SetupForm();
            _setupForm.ShowDialog();
            InitializeComponent();
        }

        private void RubikCubeForm_Load(object sender, EventArgs e)
        {
            if (int.TryParse(_setupForm._rubikSize, out _rubiksize) == false)
            {
                Application.Exit();
                return;
            }
            _tempDigitLabel = new string[_rubiksize];
            _buttonList = new List<Button>();
            var level = _setupForm._level * 5;
            CreateRubikCube();
            do
            {
                for (var count = 0; count < level; count++)
                {
                    _buttonList[random.Next(_buttonList.Count - 1)].PerformClick();
                }
            } while (IsDigitCorrect());
            _isFirst = false;
            _clickCount = 0;
            labelcount.Text = _clickCount.ToString();
        }
        private void resetbutton_Click(object sender, EventArgs e)
        {
            var level = _setupForm._level * 5;
            _rubiksize = int.Parse(_setupForm._rubikSize);
            _tempDigitLabel = new string[_rubiksize];
            _buttonList = new List<Button>();
            _isFirst = true;
            CreateRubikCube();
            do
            {
                for (var count = 0; count < level; count++)
                {
                    _buttonList[random.Next(_buttonList.Count - 1)].PerformClick();
                }
            } while (IsDigitCorrect());
            _isFirst = false;
            _clickCount = 0;
            labelcount.Text = _clickCount.ToString();
        }

        private void backToSetupbutton_Click(object sender, EventArgs e)
        {
            _setupForm.ShowDialog();
            _rubiksize = int.Parse(_setupForm._rubikSize);
            _tempDigitLabel = new string[_rubiksize];
            _buttonList = new List<Button>();
            _isFirst = true;
            var level = _setupForm._level * 5;
            CreateRubikCube();
            do
            {
                for (var count = 0; count < level; count++)
                {
                    _buttonList[random.Next(_buttonList.Count - 1)].PerformClick();
                }
            } while (IsDigitCorrect());
            _isFirst = false;
            _clickCount = 0;
            labelcount.Text = _clickCount.ToString();
        }

        private bool IsDigitCorrect()
        {
            for (var i = 0; i < digitLabel.Length; i++)
            {
                if (!digitLabel[i].Text.Equals((i + 1).ToString()))
                {
                    return false;
                }
            }
            return true;
        }

        private void CreateRubikCube()
        {
            if (digitLabel != null)
            {
                SuspendLayout();
                //数字削除
                foreach (var label in digitLabel)
                {
                    Controls.Remove(label);
                }
                for (var i = 0; i < moveVerticalUpButton.Length; i++)
                {
                    moveVerticalUpButton[i].Click -= new EventHandler(MoveUp_Click);
                    Controls.Remove(moveVerticalUpButton[i]);
                    moveVerticalDownButton[i].Click -= new EventHandler(MoveDown_Click);
                    Controls.Remove(moveVerticalDownButton[i]);
                    moveHorizonRightButton[i].Click -= new EventHandler(MoveRight_Click);
                    Controls.Remove(moveHorizonRightButton[i]);
                    moveHorizonLeftButton[i].Click -= new EventHandler(MoveLeft_Click);
                    Controls.Remove(moveHorizonLeftButton[i]);
                }
                ResumeLayout();
            }
            //端から真ん中までのブロック数
            int tempCreateRubikCube = _rubiksize / 2;
            _digitLabelSize = 50;
            //左上の座標を求める。画面の真ん中からブロックの長さ分引く
            var startDigitLabelX = Width / 2 - (tempCreateRubikCube * _digitLabelSize);
            var startDigitLabelY = Height / 2 - (tempCreateRubikCube * _digitLabelSize) - 50;
            digitLabel = new Label[_rubiksize * _rubiksize];
            moveVerticalUpButton = new Button[_rubiksize];
            moveVerticalDownButton = new Button[_rubiksize];
            moveHorizonLeftButton = new Button[_rubiksize];
            moveHorizonRightButton = new Button[_rubiksize];
            SuspendLayout();
            for (var i = 0; i < _rubiksize; i++)
            {
                for (var j = 0; j < _rubiksize; j++)
                {

                    //数字配置
                    digitLabel[j + _rubiksize * i] = new Label();
                    digitLabel[j + _rubiksize * i].Text = (1 + j + _rubiksize * i).ToString();
                    digitLabel[j + _rubiksize * i].Location = new Point(startDigitLabelX + j * _digitLabelSize,
                                  startDigitLabelY + i * _digitLabelSize);
                    digitLabel[j + _rubiksize * i].Size = new Size(_digitLabelSize, _digitLabelSize);
                    digitLabel[j + _rubiksize * i].TextAlign = ContentAlignment.MiddleCenter;
                    digitLabel[j + _rubiksize * i].Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                    Controls.Add(digitLabel[j + _rubiksize * i]);

                }
                //ボタン配置
                //上
                moveVerticalUpButton[i] = new Button();
                moveVerticalUpButton[i].Text = "↓";
                moveVerticalUpButton[i].Name = i.ToString();
                moveVerticalUpButton[i].Location =
                        new Point(startDigitLabelX + i * _digitLabelSize,
                                  startDigitLabelY - _digitLabelSize);
                moveVerticalUpButton[i].Size = new Size(_digitLabelSize, _digitLabelSize);
                moveVerticalUpButton[i].TextAlign = ContentAlignment.MiddleCenter;
                moveVerticalUpButton[i].Font = new Font("MS UI Gothic", 18, FontStyle.Regular);
                moveVerticalUpButton[i].Click += new EventHandler(MoveUp_Click);
                //下
                moveVerticalDownButton[i] = new Button();
                moveVerticalDownButton[i].Text = "↑";
                moveVerticalDownButton[i].Name = i.ToString();
                moveVerticalDownButton[i].Location =
                        new Point(startDigitLabelX + i * _digitLabelSize,
                                  startDigitLabelY + (_rubiksize * _digitLabelSize));
                moveVerticalDownButton[i].Size = new Size(_digitLabelSize, _digitLabelSize);
                moveVerticalDownButton[i].TextAlign = ContentAlignment.MiddleCenter;
                moveVerticalDownButton[i].Font = new Font("MS UI Gothic", 18, FontStyle.Regular);
                moveVerticalDownButton[i].Click += new EventHandler(MoveDown_Click);
                //左
                moveHorizonLeftButton[i] = new Button();
                moveHorizonLeftButton[i].Text = "→";
                moveHorizonLeftButton[i].Name = i.ToString();
                moveHorizonLeftButton[i].Location =
                        new Point(startDigitLabelX - _digitLabelSize,
                                  startDigitLabelY + i * _digitLabelSize);
                moveHorizonLeftButton[i].Size = new Size(_digitLabelSize, _digitLabelSize);
                moveHorizonLeftButton[i].TextAlign = ContentAlignment.MiddleCenter;
                moveHorizonLeftButton[i].Font = new Font("MS UI Gothic", 18, FontStyle.Regular);
                moveHorizonLeftButton[i].Click += new EventHandler(MoveLeft_Click);
                //右
                moveHorizonRightButton[i] = new Button();
                moveHorizonRightButton[i].Text = "←";
                moveHorizonRightButton[i].Name = i.ToString();
                moveHorizonRightButton[i].Location =
                        new Point(startDigitLabelX + (_rubiksize * _digitLabelSize),
                                  startDigitLabelY + i * _digitLabelSize);
                moveHorizonRightButton[i].Size = new Size(_digitLabelSize, _digitLabelSize);
                moveHorizonRightButton[i].TextAlign = ContentAlignment.MiddleCenter;
                moveHorizonRightButton[i].Font = new Font("MS UI Gothic", 18, FontStyle.Regular);
                moveHorizonRightButton[i].Click += new EventHandler(MoveRight_Click);
            }
            Controls.AddRange(moveVerticalUpButton);
            Controls.AddRange(moveVerticalDownButton);
            Controls.AddRange(moveHorizonLeftButton);
            Controls.AddRange(moveHorizonRightButton);
            _buttonList.AddRange(moveVerticalUpButton);
            _buttonList.AddRange(moveVerticalDownButton);
            _buttonList.AddRange(moveHorizonLeftButton);
            _buttonList.AddRange(moveHorizonRightButton);
            ResumeLayout();
        }

        private int _clickButtonNum;
        private string[] _tempDigitLabel;
        private void MoveUp_Click(object sender, EventArgs e)
        {
            _clickButtonNum = int.Parse(((Button)sender).Name);
            for (var i = 0; i < _rubiksize; i++)
            {
                _tempDigitLabel[i] = digitLabel[_clickButtonNum + i * _rubiksize].Text;
            }
            for (var i = 0; i < _rubiksize; i++)
            {
                if (i == 0)
                {
                    digitLabel[_clickButtonNum + i * _rubiksize].Text = _tempDigitLabel[_rubiksize - 1];
                }
                else
                    digitLabel[_clickButtonNum + i * _rubiksize].Text = _tempDigitLabel[i - 1];
            }
            if (_isFirst == false)
            {
                _clickCount++;
                labelcount.Text = _clickCount.ToString();
                if (IsDigitCorrect())
                {
                    var clearForm = new CreaForm(_clickCount);
                    clearForm.ShowDialog();
                }
            }
        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            _clickButtonNum = int.Parse(((Button)sender).Name);
            for (var i = 0; i < _rubiksize; i++)
            {
                _tempDigitLabel[i] = digitLabel[_clickButtonNum + i * _rubiksize].Text;
            }
            for (var i = 0; i < _rubiksize; i++)
            {
                if (i == _rubiksize - 1)
                {
                    digitLabel[_clickButtonNum + i * _rubiksize].Text = _tempDigitLabel[0];
                }
                else
                    digitLabel[_clickButtonNum + i * _rubiksize].Text = _tempDigitLabel[i + 1];
            }
            if (_isFirst == false)
            {
                _clickCount++;
                labelcount.Text = _clickCount.ToString();
                if (IsDigitCorrect())
                {
                    var clearForm = new CreaForm(_clickCount);
                    clearForm.ShowDialog();
                }
            }
        }

        private void MoveLeft_Click(object sender, EventArgs e)
        {
            _clickButtonNum = int.Parse(((Button)sender).Name);
            for (var i = 0; i < _rubiksize; i++)
            {
                _tempDigitLabel[i] = digitLabel[i + _clickButtonNum * _rubiksize].Text;
            }
            for (var i = 0; i < _rubiksize; i++)
            {
                if (i == 0)
                {
                    digitLabel[i + _clickButtonNum * _rubiksize].Text = _tempDigitLabel[_rubiksize - 1];
                }
                else
                    digitLabel[i + _clickButtonNum * _rubiksize].Text = _tempDigitLabel[i - 1];
            }
            if (_isFirst == false)
            {
                _clickCount++;
                labelcount.Text = _clickCount.ToString();
                if (IsDigitCorrect())
                {
                    var clearForm = new CreaForm(_clickCount);
                    clearForm.ShowDialog();
                }
            }
        }

        private void MoveRight_Click(object sender, EventArgs e)
        {
            _clickButtonNum = int.Parse(((Button)sender).Name);
            for (var i = 0; i < _rubiksize; i++)
            {
                _tempDigitLabel[i] = digitLabel[i + _clickButtonNum * _rubiksize].Text;
            }
            for (var i = 0; i < _rubiksize; i++)
            {
                if (i == _rubiksize - 1)
                {
                    digitLabel[i + _clickButtonNum * _rubiksize].Text = _tempDigitLabel[0];
                }
                else
                    digitLabel[i + _clickButtonNum * _rubiksize].Text = _tempDigitLabel[i + 1];
            }
            if (_isFirst == false)
            {
                _clickCount++;
                labelcount.Text = _clickCount.ToString();
                if (IsDigitCorrect())
                {
                    var clearForm = new CreaForm(_clickCount);
                    clearForm.ShowDialog();
                }
            }
        }
    }
}