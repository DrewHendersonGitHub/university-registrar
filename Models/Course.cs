using System.Collections.Generic;
using System.Linq;

namespace UniversityRegistrar.Models
{
  public class Course
  {
    public Course()
    {
      this.JoinEntities = new HashSet<Enrollment>();
    }
    public int CourseId { get; set; }
    public string Name { get; set; }
    public string CourseNumber { get; set; }
    
    public virtual ICollection<Enrollment> JoinEntities { get; set; }
  }
}