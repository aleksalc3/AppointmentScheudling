using AppointmentScheudling.Services;
using AppointmentScheudling.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentScheudling.Controllers
{
    [Authorize]
    public class ApointmentController : Controller
    {
        private readonly IAppointmentService _appointmentService;
        public ApointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;

        }
        //[Authorize(Roles =Helper.Admin)]
        public IActionResult Index()
        {
            ViewBag.Duration = Helper.GetTimeDropDown();
            ViewBag.DoctorList =_appointmentService.GetDoctorList();
            ViewBag.PatientList = _appointmentService.GetPatientList();

            return View();
        }


    }
}
