using Orthodox.Data.Models;
using Orthodox.Service.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orthodox.Service.Services
{
    public class EventoService
    {
        // Inyección de Dependecias
        private readonly OrthodoxDbContext _orthodoxDbContext;

        public EventoService(OrthodoxDbContext dbContext)
        {
            _orthodoxDbContext = dbContext;
        }

        // Traducir el día a Español
        CultureInfo culture = new System.Globalization.CultureInfo("es-ES");

        public List<EventoResponse> ObtenerTodos()
        {
            try
            {
                var eventos = _orthodoxDbContext.Eventos.ToList();

                List<EventoResponse> eventoList = new List<EventoResponse>();

                foreach (var evento in eventos)
                {
                    eventoList.Add(new EventoResponse()
                    {
                        Id = evento.Id,
                        FechaInicio = evento.FechaInicio,
                        FechaFin = evento.FechaFin,
                        DiaCalendarioJuliano = evento.FechaInicio.AddDays(-13),
                        DiaCalendarioCivil = culture.DateTimeFormat.GetDayName(evento.FechaInicio.DayOfWeek).ToUpper(),
                        DescripcionDia = evento.DescripcionDia,
                        TonoCantico = evento.TonoCantico,
                        GuiaAyuno = evento.GuiaAyuno,
                        CodigoDeColoresAyuno = evento.CodigoDeColoresAyuno,
                        FiestasLiturgicas = evento.FiestasLiturgicas,
                        SantosCelebrados = evento.SantosCelebrados,
                        GuiaLiturgia = evento.GuiaLiturgia,
                        LecturaDiariaEpistola = evento.LecturaDiariaEpistola,
                        LecturaDiariaEvangelio = evento.LecturaDiariaEvangelio,
                        TituloIcono = evento.TituloIcono,
                        DescripcionIcono = evento.DescripcionIcono
                    });
                }

                return eventoList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public EventoResponse ObtenerPorId(int id)
        {
            try
            {
                var evento = _orthodoxDbContext.Eventos
                    .FirstOrDefault(x => x.Id == id);

                var eventoResponse = new EventoResponse()
                {
                    Id = evento.Id,
                    FechaInicio = evento.FechaInicio,
                    FechaFin = evento.FechaFin,
                    DiaCalendarioJuliano = evento.FechaInicio.AddDays(-13),
                    DiaCalendarioCivil = culture.DateTimeFormat.GetDayName(evento.FechaInicio.DayOfWeek).ToUpper(),
                    DescripcionDia = evento.DescripcionDia,
                    TonoCantico = evento.TonoCantico,
                    GuiaAyuno = evento.GuiaAyuno,
                    CodigoDeColoresAyuno = evento.CodigoDeColoresAyuno,
                    FiestasLiturgicas = evento.FiestasLiturgicas,
                    SantosCelebrados = evento.SantosCelebrados,
                    GuiaLiturgia = evento.GuiaLiturgia,
                    LecturaDiariaEpistola = evento.LecturaDiariaEpistola,
                    LecturaDiariaEvangelio = evento.LecturaDiariaEvangelio,
                    TituloIcono = evento.TituloIcono,
                    DescripcionIcono = evento.DescripcionIcono
                };

                return eventoResponse;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Evento Agregar(EventoCreateRequest peticion)
        {
            try
            {
                var evento = new Evento()
                {
                    FechaInicio = peticion.FechaInicio,
                    FechaFin = peticion.FechaFin,
                    DescripcionDia = peticion.DescripcionDia,
                    TonoCantico = peticion.TonoCantico,
                    GuiaAyuno = peticion.GuiaAyuno,
                    CodigoDeColoresAyuno = peticion.CodigoDeColoresAyuno,
                    FiestasLiturgicas = peticion.FiestasLiturgicas,
                    SantosCelebrados = peticion.SantosCelebrados,
                    GuiaLiturgia = peticion.GuiaLiturgia,
                    LecturaDiariaEpistola = peticion.LecturaDiariaEpistola,
                    LecturaDiariaEvangelio = peticion.LecturaDiariaEvangelio,
                    TituloIcono = peticion.TituloIcono,
                    DescripcionIcono = peticion.DescripcionIcono
                };

                _orthodoxDbContext.Eventos.Add(evento);
                _orthodoxDbContext.SaveChanges();

                return evento;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Evento Actualizar(EventoUpdateRequest peticion)
        {
            try
            {
                var evento = _orthodoxDbContext.Eventos
                    .FirstOrDefault(x => x.Id == peticion.Id);
                
                evento.FechaInicio = peticion.FechaInicio;
                evento.FechaFin = peticion.FechaFin;
                evento.DescripcionDia = peticion.DescripcionDia;
                evento.TonoCantico = peticion.TonoCantico;
                evento.GuiaAyuno = peticion.GuiaAyuno;
                evento.CodigoDeColoresAyuno = peticion.CodigoDeColoresAyuno;
                evento.FiestasLiturgicas = peticion.FiestasLiturgicas;
                evento.SantosCelebrados = peticion.SantosCelebrados;
                evento.GuiaLiturgia = peticion.GuiaLiturgia;
                evento.LecturaDiariaEpistola = peticion.LecturaDiariaEpistola;
                evento.LecturaDiariaEvangelio = peticion.LecturaDiariaEvangelio;
                evento.TituloIcono = peticion.TituloIcono;
                evento.DescripcionIcono = peticion.DescripcionIcono;

                _orthodoxDbContext.SaveChanges();

                return evento;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Evento? Eliminar(int id)
        {
            try
            {
                var evento = _orthodoxDbContext.Eventos
                    .FirstOrDefault(x => x.Id == id);

                _orthodoxDbContext.Remove(evento);
                _orthodoxDbContext.SaveChanges();

                return evento;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
