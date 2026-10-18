using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace ellabi.Converters
{
    // Build personalizado: traduz valores de enums usados nos dropdowns para rotulos em portugues.
    // A chave e "NomeDoEnum.Valor"; o valor armazenado/serializado continua sendo o enum original.
    public class EnumToDisplayConverter : IValueConverter
    {
        private static readonly Dictionary<string, string> Map = new Dictionary<string, string>
        {
            // EventTrigger
            { "EventTrigger.Start", "Início" },
            { "EventTrigger.Interval", "Intervalo" },
            { "EventTrigger.Stop", "Parada" },
            // IntervalRepeatMode
            { "IntervalRepeatMode.Forever", "Para sempre" },
            { "IntervalRepeatMode.Throttle", "Limitar" },
            // SearchMode
            { "SearchMode.Process", "Processo" },
            { "SearchMode.Window", "Janela" },
            // MouseButton
            { "MouseButton.Left", "Esquerdo" },
            { "MouseButton.Middle", "Meio" },
            { "MouseButton.Right", "Direito" },
            // InputMethod
            { "InputMethod.Sequential", "Sequencial" },
            { "InputMethod.Simultaneous", "Simultâneo" },
            // CursorDirection
            { "CursorDirection.Square", "Quadrado" },
            { "CursorDirection.None", "Nenhuma" },
            { "CursorDirection.Random", "Aleatória" },
            { "CursorDirection.North", "Norte" },
            { "CursorDirection.NorthEast", "Nordeste" },
            { "CursorDirection.East", "Leste" },
            { "CursorDirection.SouthEast", "Sudeste" },
            { "CursorDirection.South", "Sul" },
            { "CursorDirection.SouthWest", "Sudoeste" },
            { "CursorDirection.West", "Oeste" },
            { "CursorDirection.NorthWest", "Noroeste" },
            { "CursorDirection.UpAndDown", "Cima e baixo" },
            { "CursorDirection.DownAndUp", "Baixo e cima" },
            { "CursorDirection.LeftAndRight", "Esquerda e direita" },
            { "CursorDirection.RightAndLeft", "Direita e esquerda" },
            // CursorSpeed
            { "CursorSpeed.Slow", "Lenta" },
            { "CursorSpeed.Normal", "Normal" },
            { "CursorSpeed.Fast", "Rápida" },
            { "CursorSpeed.Custom", "Personalizada" },
            // WheelDirection
            { "WheelDirection.Up", "Cima" },
            { "WheelDirection.Down", "Baixo" },
            { "WheelDirection.Left", "Esquerda" },
            { "WheelDirection.Right", "Direita" },
            { "WheelDirection.Random", "Aleatória" },
            // ScheduleAction
            { "ScheduleAction.Start", "Início" },
            { "ScheduleAction.Stop", "Parada" },
        };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                if (value != null)
                {
                    var key = value.GetType().Name + "." + value.ToString();
                    if (Map.TryGetValue(key, out var pt)) return pt;
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
