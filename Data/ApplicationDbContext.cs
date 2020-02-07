using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Managemnet.Data
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<AnnualModel> AnnualModels { get; set; }

		public DbSet<AttendanceModel> AttendanceModels { get; set; }

		public DbSet<DesignationModel> DesignationModels { get; set; }

		public DbSet<ExamModel> ExamModels { get; set; }

		public DbSet<ExpensesTypeModel> ExpensesTypeModels { get; set; }

		public DbSet<ExamSettingModel> ExamSettingModels { get; set; }

		public DbSet<ExpensesModel> ExpensesModels { get; set; }

		public DbSet<ExpensesTypeModel> GetExpensesTypeModels { get; set; }

		public DbSet<ProgramSessionModel> ProgramSessionModels { get; set; }

		public DbSet<TimeTableModel> TimeTableModels { get; set; }

		public DbSet<SessionModel> SessionModels { get; set; }

		public DbSet<SubjectModel> SubjectModels { get; set; }

		public DbSet<UserModel> UserModels { get; set; }

		public DbSet<StaffAttendanceModel> StaffAttendanceModels { get; set; }

		public DbSet<StaffModel> StaffModels { get; set; }

		public DbSet<UserTypeModel> UserTypeModels { get; set; }

		public DbSet<StudentModel> StudentModels { get; set; }

		public DbSet<SessionProgramSubjectSettingModel> SessionProgramSubjectSettingModels { get; set; }

		public DbSet<ProgramModel> ProgramModels { get; set; }

		public DbSet<SubmissionFeeModel> SubmissionFeeModels { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=RADON;Initial Catalog=school_management_1;Integrated Security=True");
		}
	}
}
