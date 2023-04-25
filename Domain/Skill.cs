using System.ComponentModel.DataAnnotations;

namespace Domain;

public abstract class Node<T1> where T1 : class
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } // .NET
    public string? Description { get; set; }
    public List<T1>? SubNodes { get; set; } // C#, EF

    // A tag could be a different skill that works well with the one having this tag,
    // it could be a category that the skill belongs to,
    // it could be a subskill of the aforementioned skill.
    //public List<Tag>? Tags { get; set; } 
    public Skill()
    {
        
    }

}
public class Department : Node<Department>
{

}

public class Skill2023 : Node<Skill2023>
{

}
public class Tag
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } // C#, EF, BackEnd
    public int SkillId { get; set; }
}

public class HardSkill : Skill<HardSkill>
{
    public HardSkill()
    {
        
    }
}

public class SoftSkill : Skill<SoftSkill>
{
    public SoftSkill()
    {

    }
}