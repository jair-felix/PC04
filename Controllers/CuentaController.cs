using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC04.Models;

namespace PC04.Controllers{

    public class CuentaController : Controller
    {
        
        private readonly ILogger<CuentaController> _logger;
         private readonly ApplicationDbContext _context;

    }

}