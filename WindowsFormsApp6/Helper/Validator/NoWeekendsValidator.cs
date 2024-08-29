using FluentValidation;
using System;
using System.Linq;
using WindowsFormsApp6.Cache;
using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.Helper.Validator
{
    public class NoWeekendsValidator : AbstractValidator<CTableroAdminBO>
    {

        public NoWeekendsValidator()
        {
            RuleFor(x => x._fechaCitatorio)
                .Must(NotBeWeekend)
                .Must(NotBeHoliday).WithMessage("No puede ser un día feriado")
                .Must(fecha=> DateTime.TryParse(fecha.ToString(), out _))
                .WithMessage("La fecha de citatorio no puede ser fin de semana");

            RuleFor(x => x._fechaCitatorio)
                .GreaterThan(CUserLoggin.DetalleEmision._fechaImpresion)
                .WithMessage(modelo => $"El citatorio es mayor a la fecha de emisión{CUserLoggin.DetalleEmision._fechaImpresion:dd/MM/yyyy}")
                .When(fecha => fecha._fechaCitatorio != default)
                .LessThanOrEqualTo(DateTime.Today)
                .WithMessage("La fecha no puede ser mayor al día actual.");


            RuleFor(x => x._fechaNotificacion)
                .Must(fecha => DateTime.TryParse(fecha.ToString(), out _))
                .Must(NotBeHoliday).WithMessage("No puede ser un día feriado")
                .Must(NotBeWeekend)
                .WithMessage("La fecha de citatorio no puede ser fin de semana")
                .LessThanOrEqualTo(DateTime.Today)
                .WithMessage("La fecha no puede ser mayor al día actual.");




            RuleFor(x => x._fechaNotificacion)
                .GreaterThan(CUserLoggin.DetalleEmision._fechaImpresion)
                .When(fecha => fecha._fechaNotificacion != default);

        }
        private bool EsDiaHabilSiguiente(DateTime fechaCitatorio, DateTime fechaNotificacion)
        {
            if(fechaCitatorio == default) 
            {
                return false;
            }

            DateTime siguienteDiaHabil = ObtenerSiguienteDiaHabil(fechaCitatorio);

            return fechaNotificacion.Date == siguienteDiaHabil.Date;
        }

        private DateTime ObtenerSiguienteDiaHabil(DateTime fecha)
        {
            DateTime siguienteDia = fecha.AddDays(1);

            // Si el siguiente día es sábado o domingo, busca el siguiente día hábil (lunes)
            while (siguienteDia.DayOfWeek == DayOfWeek.Saturday || siguienteDia.DayOfWeek == DayOfWeek.Sunday)
            {
                siguienteDia = siguienteDia.AddDays(1);
            }

            return siguienteDia;
        }

        private bool NotBeWeekend(DateTime date)
        {
            return date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday;
        }
        private bool NotBeHoliday(DateTime date)
        {

           var res= CUserLoggin.DiasFestivos.FirstOrDefault(x => x.DiaFeriado.Equals(date));
            if (res == null)
                return true;
            else
                return false;
        }
    }
}
