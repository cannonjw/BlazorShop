using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorShop.Data;
using BlazorShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Services
{
    public class AppointmentService
    {
        private readonly ApplicationDbContext _db;

        public AppointmentService(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool CreateAppointment(Appointment appointment)
        {
            appointment.ProductId = appointment.Product.Id;
            appointment.Product = null;
            _db.Appointments.Add(appointment);
            _db.SaveChanges();
            return true;
        }

        public Appointment GetAppointment(int appointmentId)
        {
            return _db.Appointments.FirstOrDefault(x => x.Id == appointmentId);
        }

        public List<Appointment> GetAppointments()
        {
            return _db.Appointments.Include(u => u.Product).Include(u => u.Product.Category).ToList<Appointment>();
        }

        public bool ConfirmAppointment(Appointment appointment)
        {
            Appointment _appointment = _db.Appointments.FirstOrDefault(x => x.Id == appointment.Id);
            if (_appointment != null)
            {
                _appointment.IsConfirmed = true;
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteAppointment(Appointment appointment)
        {
            Appointment _appointment = _db.Appointments.FirstOrDefault(x => x.Id == appointment.Id);
            if (_appointment != null)
            {
                _db.Appointments.Remove(appointment);
                _db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}