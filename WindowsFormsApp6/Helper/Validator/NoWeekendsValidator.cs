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
                .When(fecha => fecha._fechaCitatorio != default);
                

            RuleFor(x=> x._fechaNotificacion)
                .Must(fecha => DateTime.TryParse(fecha.ToString(), out _))
                .Must(NotBeHoliday).WithMessage("No puede ser un día feriado")
                //.Must(BeAValidDate).WithMessage("La FechaCitatorio no es una fecha válida")
                .Must(NotBeWeekend)
                .WithMessage("La fecha de citatorio no puede ser fin de semana");


            RuleFor(x => x._fechaNotificacion)
                .GreaterThan(CUserLoggin.DetalleEmision._fechaImpresion)
                .When(fecha => fecha._fechaNotificacion != default);

        }
        private bool NotBeWeekend(DateTime date)
        {
            return date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday;
        }
        private bool BeAValidDate(DateTime date)
        {
            return date != default(DateTime);
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
