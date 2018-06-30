using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, IViewFor<MainViewModel>
    {
        public MainPage()
        {
            this.InitializeComponent();
	        
	        ViewModel = new MainViewModel();

	        this.Bind(ViewModel, m => m.DummyText, v => v.TheTextBox.Text);
	        this.OneWayBind(ViewModel, m => m.DummyText, v => v.TheTextBlock.Text);

        }

	    object IViewFor.ViewModel
	    {
		    get => ViewModel;
		    set => ViewModel = (MainViewModel) value;
	    }

	    public MainViewModel ViewModel { get; set; }
    }

	public class MainViewModel : ReactiveObject
	{
		[Reactive]
		public string DummyText { get; set; } = "";
	}
}
