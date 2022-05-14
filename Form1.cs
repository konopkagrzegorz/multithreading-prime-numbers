using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multithreading
{

    public partial class PrimeNumberFinder : Form
    {

        int maxPrimeNumber;
        long totalTimeInMultithreading = 0;
        private ConcurrentStack<int> primeNumbers = new ConcurrentStack<int>();
        System.Diagnostics.Stopwatch Stoper;

        public PrimeNumberFinder()
        {
            InitializeComponent();
        }

        private void btnOneThread_Click(object sender, EventArgs e)
        {
            Stoper = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < maxPrimeNumber + 1; i++)
            {
               if (isItPrime(i))
                {
                    primeNumbers.Push(i);
                    outputTextBox.AppendText(Environment.NewLine + i);
                }
            }
            Stoper.Stop();
            TextBoxTotalTime.Text += Stoper.ElapsedMilliseconds;
        }

        private bool isItPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        private void btnMultithreading_Click(object sender, EventArgs e)
        {
            var partitioner = Partitioner.Create(0, maxPrimeNumber + 1);

            Parallel.ForEach(partitioner, p =>
            {
                Stoper = System.Diagnostics.Stopwatch.StartNew();
                for (int i = p.Item1; i < p.Item2; i++)
                {
                    if (isItPrime(i))
                    {
                        primeNumbers.Push(i);
                    }
                }
                Stoper.Stop();
                totalTimeInMultithreading += Stoper.ElapsedMilliseconds;
            });
            TextBoxTotalTime.Text += totalTimeInMultithreading;
            for (int i = 0; i < primeNumbers.Count; i++)
            {
                outputTextBox.Invoke((MethodInvoker)delegate { outputTextBox.Text += (Environment.NewLine + i); });
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TextBoxTotalTime.Text = "";
            outputTextBox.Text = "";
            maxPrimeNumber = 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            maxPrimeNumber = Int32.Parse(numericUpDown1.Value.ToString());
        }
    }
}
