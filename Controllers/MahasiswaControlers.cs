using Microsoft.AspNetCore.Mvc;
using TP_mod_10_103022300159.Models;

namespace TP_mod_10_103022300159.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaControlers : ControllerBase
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Achmad fadjry adlil faqih", Nim = "103022300159" },
            new Mahasiswa { Nama = "⁠Muhammad Ihsan Romdhon", Nim = "103022330150" },
            new Mahasiswa { Nama = "Intan Nur Aini ", Nim = "103022330067" },
            new Mahasiswa { Nama = "Gamaliel Pradana Pangestu", Nim = "103022300015" },
            new Mahasiswa { Nama = "Raihan Ananda Putra ", Nim = "103022330075" },
            new Mahasiswa { Nama = "Muthi'ah Az-Zahra ", Nim = "103022330117" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> GetAll()
        {
            return Ok(mahasiswaList);
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
                return NotFound("Index tidak ditemukan.");

            return Ok(mahasiswaList[index]);
        }

        [HttpPost]
        public ActionResult AddMahasiswa([FromBody] Mahasiswa newMahasiswa)
        {
            mahasiswaList.Add(newMahasiswa);
            return Ok("Mahasiswa berhasil ditambahkan.");
        }

        [HttpDelete("{index}")]
        public ActionResult DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
                return NotFound("Index tidak ditemukan.");

            mahasiswaList.RemoveAt(index);
            return Ok("Mahasiswa berhasil dihapus.");
        }
    }
}