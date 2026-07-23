using Core.Modules.Manifest;
using Summary.Liyam;

[assembly: Feature(
    Id = Liyam.Features.Liyam,
    Name = Liyam.Localize.SubjectOfLiyam,
    Description =Liyam.Localize.DescriptionOfLiyam,
    Category = Liyam.Public.Category,
    Dependencies = new[] { "Core.Workflows" }
)]