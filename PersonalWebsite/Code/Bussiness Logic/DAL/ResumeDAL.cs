using PersonalWebsite.Code.Identifyers;
using PersonalWebsite.DB;
using PersonalWebsite.Models;
using PersonalWebsite.Models.Resume;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace PersonalWebsite.Code.Bussiness_Logic.DAL
{
    public class ResumeDAL
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
        }

        public Resume GetResume(ResumeID resumeID)
        {
            var context = new PersonalWebsite.DB.DatabaseContextDataContext(GetConnectionString());
            return (from resumes in context.Resumes
                     where resumes.Id == 1
                     select resumes).SingleOrDefault();
        }

        public IEnumerable<ResumeEducationModel> GetResumeEducation(ResumeID resumeID)
        {
            var context = new PersonalWebsite.DB.DatabaseContextDataContext(GetConnectionString());
            var education = (from Connection in context.ResumeEducationConnections
                             join Education in context.ResumeEducations on Connection.ResumeEducationID equals Education.Id
                             join DegreeType in context.DegreeTypeCodes on Education.DegreeTypeCode equals DegreeType.DegreeTypeCode1
                             where Connection.ResumeID == 1
                             select new ResumeEducationModel
                             {
                                 DegreeType = DegreeType.Description,
                                 Description = Education.Description,
                                 GPA = Education.GPA,
                                 University = Education.University,
                                 StartDate = Education.StartDate,
                                 EndDate = Education.EndDate
                             });

            return education;
        }

        public IEnumerable<TechnicalSkillsModel> GetResumeTechnicalSkills(ResumeID resumeID)
        {
            var context = new PersonalWebsite.DB.DatabaseContextDataContext(GetConnectionString());
            var technicalSkills = (from Connection in context.ResumeTechnicalGroupConnections
                                   join TechnicalGroup in context.ResumeTechnicalSkillGroups on Connection.ResumeTechnicalSkillGroupID equals TechnicalGroup.Id
                                   where Connection.ResumeID == 1
                                   select new TechnicalSkillsModel
                                   {
                                       Title = TechnicalGroup.Title,
                                       Items = (from TechnicalGroupItem in context.ResumeTechnicalSkillItems
                                                where TechnicalGroupItem.ResumeTechnicalGroupID == TechnicalGroup.Id
                                                select TechnicalGroupItem.Text)
                                   });

            return technicalSkills;
        }

        public IEnumerable<WorkExperienceModel> GetWorkExperience(ResumeID resumeID)
        {
            var context = new PersonalWebsite.DB.DatabaseContextDataContext(GetConnectionString());
            var workExperience = (from Connection in context.ResumeWorkExperienceConnections
                                  join WorkExperience in context.ResumeWorkExperiences on Connection.ResumeWorkExperienceID equals WorkExperience.Id
                                  where Connection.ResumeID == 1
                                  select new WorkExperienceModel
                                  {
                                      Employer = WorkExperience.Employer,
                                      Title = WorkExperience.Title,
                                      StartDate = WorkExperience.StartDate,
                                      EndDate = WorkExperience.EndDate,

                                      RoleDescriptions = (from WorkExperienceDescription in context.ResumeWorkExperienceDescriptions
                                                          where WorkExperienceDescription.WorkExperienceID == WorkExperience.Id
                                                          select new WorkRoleDescriptionModel
                                                          {
                                                              GeneralDescription = WorkExperienceDescription.Description,
                                                              Details = (from WorkExperienceDescriptionDetails in context.ResumeWorkExperienceDescriptionDetails
                                                                         where WorkExperienceDescriptionDetails.ResumeWorkExperienceDescriptionsID == WorkExperienceDescription.Id
                                                                         select WorkExperienceDescriptionDetails.Text)
                                                          })

                                  });

            return workExperience;
        }

        public IEnumerable<ResumeOtherExperienceModel> GetOtherExperience(ResumeID resumeID)
        {
            var context = new PersonalWebsite.DB.DatabaseContextDataContext(GetConnectionString());
            var otherExperience = (from Connection in context.ResumeOtherExperienceConnections
                                   join OtherExperience in context.ResumeOtherExperiences on Connection.ResumeOtherExperienceID equals OtherExperience.Id
                                   where Connection.ResumeID == 1
                                   select new ResumeOtherExperienceModel
                                   {
                                       Title = OtherExperience.Title,
                                       Platform = OtherExperience.Platform,
                                       Role = OtherExperience.Role,
                                       StartDate = OtherExperience.StartDate,
                                       EndDate = OtherExperience.EndDate,

                                       RoleDescriptions = (from OtherExperienceDescription in context.ResumeOtherExperienceDescriptions
                                                           where OtherExperienceDescription.OtherExperienceID == OtherExperience.Id
                                                           select new WorkRoleDescriptionModel
                                                           {
                                                               GeneralDescription = OtherExperienceDescription.GeneralDescription,
                                                               Details = (from OtherExperienceDescriptionDetails in context.ResumeOtherExperienceDescriptionDetails
                                                                          where OtherExperienceDescriptionDetails.OtherExperienceDescriptionID == OtherExperienceDescription.OtherExperienceID
                                                                          select OtherExperienceDescriptionDetails.Text)
                                                           })

                                   });

            return otherExperience;
        }
    }
}