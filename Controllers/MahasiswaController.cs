using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class MahasiswaController : ControllerBase
{
    private static List<Mahasiswa> mahasiswa = new List<Mahasiswa>
    {
        new Mahasiswa { Nama = "Dynasty Danna Gunawan", Nim = "103082400037" },
        new Mahasiswa { Nama = "Gilbbran", Nim = "103082400001" },
        new Mahasiswa { Nama = "Tora", Nim = "103082400002" }
    };

    [HttpGet]
    public List<Mahasiswa> Get()
    {
        return mahasiswa;
    }

    [HttpGet("{index}")]
    public Mahasiswa Get(int index)
    {
        return mahasiswa[index];
    }

    [HttpPost]
    public void Post([FromBody] Mahasiswa mhs)
    {
        mahasiswa.Add(mhs);
    }

    [HttpDelete("{index}")]
    public void Delete(int index)
    {
        mahasiswa.RemoveAt(index);
    }
}