using ellabi.ViewModels;
using System;
using System.Globalization;
using System.Windows.Data;

namespace ellabi.Converters
{
    // Build personalizado: traduz o estado atual (enum MouseState) para um rotulo em portugues.
    public class MouseStateToDisplayConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                if ((value != null) && Enum.TryParse(value.ToString(), true, out MouseWindowViewModel.MouseState state))
                {
                    switch (state)
                    {
                        case MouseWindowViewModel.MouseState.Idle: return "Ocioso";
                        case MouseWindowViewModel.MouseState.Running: return "Em execução";
                        case MouseWindowViewModel.MouseState.Paused: return "Pausado";
                        case MouseWindowViewModel.MouseState.Executing: return "Executando ação";
                        case MouseWindowViewModel.MouseState.Sleeping: return "Em espera";
                        case MouseWindowViewModel.MouseState.OnBattery: return "Na bateria";
                        case MouseWindowViewModel.MouseState.Locked: return "Bloqueado";
                    }
                }
            }
            catch (Exception ex)
            {
                StaticCode.Logger?.Here().Error(ex.Message);
            }

            return value?.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
