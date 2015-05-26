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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace Tanpura_WP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        private void volumechange()
        {
            try
            {
                _aa.Volume = volume.Value / 10;
                _ash.Volume = volume.Value / 10;
                _b.Volume = volume.Value / 10;
                c.Volume = volume.Value / 10;
                cs.Volume = volume.Value / 10;
                d.Volume = volume.Value / 10;
                ds.Volume = volume.Value / 10;
                ee.Volume = volume.Value / 10;
                f.Volume = volume.Value / 10;
                fs.Volume = volume.Value / 10;
                g.Volume = volume.Value / 10;
                gs.Volume = volume.Value / 10;
                aa.Volume = volume.Value / 10;
                ash.Volume = volume.Value / 10;
                b.Volume = volume.Value / 10;
            }
            catch (Exception)
            {

                // throw;
            }
        }
        private void play(int keyindex)
        {
            stop();
            switch (keyindex)
            {
                case 0:
                    _aa.Play();
                    break;
                case 1:
                    _ash.Play();
                    break;
                case 2:
                    _b.Play();
                    break;
                case 3:
                    c.Play();
                    break;
                case 4:
                    cs.Play();
                    break;
                case 5:
                    d.Play();
                    break;
                case 6:
                    ds.Play();
                    break;
                case 7:
                    ee.Play();
                    break;
                case 8:
                    f.Play();
                    break;
                case 9:
                    fs.Play();
                    break;
                case 10:
                    g.Play();
                    break;
                case 11:
                    gs.Play();
                    break;
                case 12:
                    aa.Play();
                    break;
                case 13:
                    ash.Play();
                    break;
                case 14:
                    b.Play();
                    break;
                default:
                    break;
            }
        }
        private void stop()
        {
            try
            {
                _aa.Stop(); _ash.Stop(); _b.Stop(); c.Stop(); cs.Stop(); d.Stop(); ds.Stop(); ee.Stop(); f.Stop(); fs.Stop(); g.Stop(); gs.Stop(); aa.Stop(); ash.Stop(); b.Stop();
            }
            catch (Exception)
            {

                //throw;
            }
        }
        private void playbut_Click(object sender, RoutedEventArgs e)
        {
            volumechange();
            play(key.SelectedIndex);
        }

        private void stopbut_Click(object sender, RoutedEventArgs e)
        {
            stop();
        }

        private void volume_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            volumechange();


        }

        private void key_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            stop();
            volumechange();
            try
            {
                play(key.SelectedIndex);
            }
            catch (Exception)
            {

                //throw;
            }

        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }
    }
}
