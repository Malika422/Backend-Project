// <auto-generated />
using System;
using EduHome1.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EduHome1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EduHome1.Models.Professional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ProfessionalName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Professionals");
                });

            modelBuilder.Entity("EduHome1.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("Teacher")
                        .HasColumnType("int");

                    b.Property<string>("TeacherImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Teacher")
                        .IsUnique()
                        .HasFilter("[Teacher] IS NOT NULL");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("EduHome1.Models.TeacherContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MailMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MakeACall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skype")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TeacherContacts");
                });

            modelBuilder.Entity("EduHome1.Models.TeacherDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Degree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Faculty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hobbies")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TeacherDetail");
                });

            modelBuilder.Entity("EduHome1.Models.TeacherProfessional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ProfessionalId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfessionalId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherProfessionals");
                });

            modelBuilder.Entity("EduHome1.Models.TeacherSkills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Communication")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Design")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Development")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Innovation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("TeamLeader")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TeacherDetailsId")
                        .IsUnique();

                    b.ToTable("TeacherSkill");
                });

            modelBuilder.Entity("EduHome1.Models.Teacher", b =>
                {
                    b.HasOne("EduHome1.Models.TeacherDetails", "TeacherDetails")
                        .WithOne("Teacher")
                        .HasForeignKey("EduHome1.Models.Teacher", "Teacher");

                    b.Navigation("TeacherDetails");
                });

            modelBuilder.Entity("EduHome1.Models.TeacherProfessional", b =>
                {
                    b.HasOne("EduHome1.Models.Professional", "Professional")
                        .WithMany("TeacherProfessional")
                        .HasForeignKey("ProfessionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduHome1.Models.Teacher", "Teacher")
                        .WithMany("TeacherProfessional")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professional");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("EduHome1.Models.TeacherSkills", b =>
                {
                    b.HasOne("EduHome1.Models.TeacherDetails", "TeacherDetails")
                        .WithOne("TeacherSkills")
                        .HasForeignKey("EduHome1.Models.TeacherSkills", "TeacherDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TeacherDetails");
                });

            modelBuilder.Entity("EduHome1.Models.Professional", b =>
                {
                    b.Navigation("TeacherProfessional");
                });

            modelBuilder.Entity("EduHome1.Models.Teacher", b =>
                {
                    b.Navigation("TeacherProfessional");
                });

            modelBuilder.Entity("EduHome1.Models.TeacherDetails", b =>
                {
                    b.Navigation("Teacher");

                    b.Navigation("TeacherSkills");
                });
#pragma warning restore 612, 618
        }
    }
}
