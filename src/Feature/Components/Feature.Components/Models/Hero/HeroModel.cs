using Glass.Mapper.Sc.Configuration.Attributes;

namespace Feature.Components.Models.Hero
{
    [SitecoreType(AutoMap = true)]
    public class HeroModel
    {
        public virtual string Title { get; set; }
        public virtual string Subtitle { get; set; }
        public virtual string CtaText { get; set; }
        public virtual Glass.Mapper.Sc.Fields.Link CtaLink { get; set; }
        public virtual Glass.Mapper.Sc.Fields.Image Image { get; set; }
    }
}
