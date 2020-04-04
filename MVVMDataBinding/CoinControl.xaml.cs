using CashRegister;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVMDataBinding
{
    /// <summary>
    /// Interaction logic for CoinControl.xaml
    /// </summary>
    public partial class CoinControl : UserControl
    {
        /// <summary>
        /// Dependency Property for Denomination
        /// </summary>
        public static readonly DependencyProperty DenominationProperty =
            DependencyProperty.Register(
                "Denomination",
                typeof(Coins),
                typeof(CoinControl),
                new PropertyMetadata(Coins.Penny)
            );

        /// <summary>
        /// The denomination this control displays and modifies.
        /// </summary>
        public Coins Denomination
        {
            get
            {
                return (Coins)GetValue(DenominationProperty);
            }
            set
            {
                SetValue(DenominationProperty, value);
            }
        }

        /// <summary>
        /// Dependency Property for Quantity
        /// </summary>
        public static readonly DependencyProperty QuantityProperty =
          DependencyProperty.Register(
              "Quantity",
              typeof(int),
              typeof(CoinControl),
              new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
          );
        
        /// <summary>
        /// Property for the Quantity of coins.
        /// </summary>
        public int Quantity
        {
            get => (int)GetValue(QuantityProperty);
            set => SetValue(QuantityProperty, value);
        }


        public CoinControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event for increasing coins.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnIncreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity++;
        }

        /// <summary>
        /// Event for increasing coins.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDecreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity--;
        }
    }
}
