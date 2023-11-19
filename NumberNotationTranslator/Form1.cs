using NumberNotationTranslatorClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberNotationTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие нажатия на кнопку
        /// </summary>
        /// <param name="sender">Элемент управления, который вызвал событие</param>
        /// <param name="e">Параметры события</param>
        private void button1_Click(object sender, EventArgs e)
        {
            private void button1_Click(object sender, EventArgs e)
            {
                string xStr;
                if (textBoxInputNumber.Text != "")
                {
                    xStr = textBoxInputNumber.Text;
                }
                else
                {
                    MessageBox.Show("Некорректный ввод.\n+" +
                        "Поле \"Введите число\" не может быть пустым.");
                    return;
                }
                bool Negative = false;//Забираем минус у числа если оно отриц
                if (xStr[0] == Convert.ToChar("-"))
                {
                    Negative = true;
                    xStr = xStr.Remove(0, 1);
                }
            }

            private NotationTranslationHandler GetValues(NotationTranslationHandler translationHandler)
            {
                try
                {
                    double inputNumber = double.Parse(textBoxInputNumber.Text);
                    int notationFrom = int.Parse(textBoxNotationFrom.Text);
                    int notationTo = int.Parse(textBoxNotationTo.Text);

                    translationHandler =
                            new NotationTranslationHandler(inputNumber,
                            notationFrom, notationTo);


                    return translationHandler;
                }
                catch
                {
                    MessageBox.Show("Неверно указаны значения цветов RGB", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

            }

            private void textBoxInputNumber_TextChanged(object sender, EventArgs e)
            {

            }

            private void button2_Click(object sender, EventArgs e)
            {

            }
        }
    }
