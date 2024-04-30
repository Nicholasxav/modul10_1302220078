using Microsoft.AspNetCore.Mvc;

namespace modul10_1302220078.Controllers;
[ApiController]
[Route("[controller]")]
public class MahasiswaControler : ControllerBase
{
    public static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
    {
        new Mahasiswa ("Nicholas Xavier", "1302220078", new List<string>(){"PBO", "KPL", "BASDAT"}, 2022),
        new Mahasiswa ("Nicholas Xavier", "1302220078", new List<string>(){"PBO", "KPL", "BASDAT"}, 2022),
        new Mahasiswa ("Nicholas Xavier", "1302220078", new List<string>(){"PBO", "KPL", "BASDAT"}, 2022),
    };
    [HttpGet]
    public IEnumerable<Mahasiswa> Get()
    {
        return dataMahasiswa;
    }

    [HttpGet("{id}")]
    public Mahasiswa Get (int id)
    {
        return dataMahasiswa[id];
    }
    [HttpPost]
    public void Post([FromBody] Mahasiswa value)
    {
       dataMahasiswa.Add(value);
    }
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        dataMahasiswa.RemoveAt(id);
    }
}
