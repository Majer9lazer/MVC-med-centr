// <auto-generated />
namespace MedCentr.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.2.0-61023")]
    public sealed partial class Hello : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(Hello));
        
        string IMigrationMetadata.Id
        {
            get { return "201809081612092_Hello"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}