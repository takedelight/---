using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ср
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text; // Ввід користувача
            if (string.IsNullOrEmpty(text)) return;

            int textLength = text.Length;
            int startIndex = 0;
            int maxLength = 1;

            for (int center = 0; center < textLength; center++)
            {
                // Непарні (центр - один символ)
                int left = center, right = center;
                while (left >= 0 && right < textLength && text[left] == text[right])
                {
                    if (right - left + 1 > maxLength)
                    {
                        maxLength = right - left + 1;
                        startIndex = left;
                    }
                    left--; right++;
                }

                // Парні (центр - між символами)
                left = center; right = center + 1;
                while (left >= 0 && right < textLength && text[left] == text[right])
                {
                    if (right - left + 1 > maxLength)
                    {
                        maxLength = right - left + 1;
                        startIndex = left;
                    }
                    left--; right++;
                }
            }

            // Вивід у лейбли
            label1.Text = maxLength.ToString();                // Довжина
            label2.Text = text.Substring(startIndex, maxLength); // Слово-паліндром
        }
    }
}
