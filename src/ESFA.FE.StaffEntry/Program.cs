using System;
using System.Windows.Forms;
using ESFA.DC.DateTimeProvider;
using ESFA.DC.DateTimeProvider.Interface;
using ESFA.DC.FEW.FileProcessingService.Model.Loose;
using ESFA.DC.FEW.FileProcessingService.Rules.MainContract;
using ESFA.DC.FEW.FileProcessingService.Rules.Message;
using ESFA.DC.FEW.FileProcessingService.Rules.Role;
using ESFA.DC.FEW.FileProcessingService.Rules.Staff;
using ESFA.DC.FEW.FileProcessingService.Rules.Teacher;
using ESFA.DC.FEW.FileProcessingService.Service.ReferenceData.Interface;
using ESFA.FE.StaffEntry.Models;
using ESFA.FE.StaffEntry.Service;
using ESFA.FEW.StaffEntry.Validation;
using ESFA.FEW.StaffEntry.Validation.Interfaces;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Message = ESFA.DC.FEW.FileProcessingService.Model.Loose.Message;

namespace ESFA.FE.StaffEntry
{
    public static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();

            Application.Run(new GridView(
                (IStaffValidationService)ServiceProvider.GetService(typeof(IStaffValidationService)),
                (ColumnToModelMapper)ServiceProvider.GetService(typeof(ColumnToModelMapper)),
                (IValidationMessagesProvider)ServiceProvider.GetService(typeof(IValidationMessagesProvider)),
                (ReleaseDetails)ServiceProvider.GetService(typeof(ReleaseDetails))));
        }

        private static void ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

            services.AddSingleton<IStaffValidationService, StaffValidationService>();
            services.AddSingleton<IValidationMessagesProvider, ValidationMessagesProvider>();

            AddValidators(services);

            services.AddSingleton<ColumnToModelMapper>();
            services.AddSingleton<IReferenceDataCache, ReferenceDataCache>();
            services.AddSingleton<IReferenceDataKeys, ReferenceDataKeys>();
            services.AddSingleton<ICampusIdReferenceDataCache, CampusIdReferenceDataCache>();

            services.AddSingleton<ReleaseDetails>();
            ServiceProvider = services.BuildServiceProvider();
        }

        private static void AddValidators(ServiceCollection services)
        {
            services.AddTransient<IValidator<MessageStaffData[]>, StaffListValidator>();
            services.AddTransient<IValidator<MessageStaffData>, StaffValidator>();
            services.AddTransient<IValidator<MessageStaffDataMainContract>, MainContractRulesValidator>();
            services.AddTransient<IValidator<MessageStaffDataTeacherData>, TeacherValidator>();
            services.AddTransient<IValidator<MessageStaffDataRole>, RoleValidator>();
            services.AddTransient<IValidator<Message>, MessageValidator>();
        }
    }
}
