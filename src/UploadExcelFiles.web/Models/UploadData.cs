namespace UploadExcelFiles.web.Models
{
    using Npoi.Mapper.Attributes;

public class UploadData
{
    [Ignore]
    public int Id { get; set; }

    [Column("seq")]
    public int AlternateKey { get; set; }

    [Column("first")]
    public string FirstName { get; set; }

    [Column("last")]
    public string LastName { get; set; }

    [Column("email")]
    public string Email { get; set; }

    [Column("gender")]
    public string Gender { get; set; }
}
}