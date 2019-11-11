using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Notary.Data.Main_Core.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "citizen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_citizen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "external_visit_requests",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    request_ticket_number = table.Column<string>(nullable: true),
                    request_date_time = table.Column<DateTime>(nullable: true),
                    requestor_name = table.Column<string>(nullable: true),
                    notes = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    request_decision = table.Column<bool>(nullable: true),
                    office_id = table.Column<int>(nullable: false),
                    user_id = table.Column<int>(nullable: false),
                    transaction_type_id = table.Column<int>(nullable: false),
                    justicewriter_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_external_visit_requests", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "NotaryDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image_Content = table.Column<byte[]>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaryDocuments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "transaction_common_data",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tr_ticket_number = table.Column<string>(nullable: true),
                    tr_public_number = table.Column<int>(nullable: true),
                    tr_record_number = table.Column<int>(nullable: true),
                    tr_official_date = table.Column<DateTime>(nullable: false),
                    tr_copy_count = table.Column<int>(nullable: false),
                    tr_paid_fees = table.Column<decimal>(nullable: true),
                    tr_receipt_number = table.Column<string>(nullable: true),
                    tr_receipt_date = table.Column<DateTime>(nullable: true),
                    tr_is_internal = table.Column<bool>(nullable: false),
                    transaction_type_id = table.Column<int>(nullable: false),
                    office_id = table.Column<int>(nullable: false),
                    external_visit_requests_id = table.Column<int>(nullable: true),
                    final_status = table.Column<int>(nullable: true),
                    tr_basic_paid_fees = table.Column<double>(nullable: true),
                    IsUsed = table.Column<bool>(nullable: true),
                    LastWorkingUserId = table.Column<int>(nullable: true),
                    TransactionNo = table.Column<string>(nullable: true),
                    tr_total_original_fees = table.Column<decimal>(nullable: true),
                    tr_total_addtional_fees = table.Column<decimal>(nullable: true),
                    tr_value = table.Column<decimal>(nullable: true),
                    HasValue = table.Column<bool>(nullable: true),
                    IsExemptable = table.Column<bool>(nullable: true),
                    RefrenceId = table.Column<int>(nullable: false),
                    transaction_Content = table.Column<string>(nullable: true),
                    transaction_Content_Sub1 = table.Column<string>(nullable: true),
                    transaction_Content_Sub2 = table.Column<string>(nullable: true),
                    external_visit_requestsid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction_common_data", x => x.Id);
                    table.ForeignKey(
                        name: "FK_transaction_common_data_external_visit_requests_external_visit_requestsid",
                        column: x => x.external_visit_requestsid,
                        principalTable: "external_visit_requests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "citizen_transaction_common_data",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transaction_common_data_id = table.Column<int>(nullable: false),
                    citizen_id = table.Column<int>(nullable: false),
                    citizen_id_type_id = table.Column<int>(nullable: false),
                    citizen_id_number = table.Column<string>(nullable: true),
                    citizen_id_date = table.Column<DateTime>(nullable: false),
                    citizen_role_id = table.Column<int>(nullable: false),
                    citizen_nationality_id = table.Column<int>(nullable: false),
                    citizen_id_record = table.Column<string>(nullable: true),
                    citizen_id_sahefa = table.Column<string>(nullable: true),
                    citizen_id_tanzeem_date = table.Column<DateTime>(nullable: true),
                    citizen_id_mahfaza = table.Column<string>(nullable: true),
                    citizen_address = table.Column<string>(nullable: true),
                    citizen_job = table.Column<string>(nullable: true),
                    citizen_job_adress = table.Column<string>(nullable: true),
                    citizen_job_office = table.Column<string>(nullable: true),
                    citizen_id_issued_from = table.Column<string>(nullable: true),
                    citizen_phone_number = table.Column<string>(nullable: true),
                    citizen_tamwen_number = table.Column<string>(nullable: true),
                    citizen_tamwen_center = table.Column<string>(nullable: true),
                    citizen_info_center = table.Column<string>(nullable: true),
                    citizen_housing_id_number = table.Column<string>(nullable: true),
                    citizen_nearstPoint = table.Column<string>(nullable: true),
                    MotherName = table.Column<string>(nullable: true),
                    citizenId = table.Column<int>(nullable: true),
                    transaction_common_dataId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_citizen_transaction_common_data", x => x.Id);
                    table.ForeignKey(
                        name: "FK_citizen_transaction_common_data_citizen_citizenId",
                        column: x => x.citizenId,
                        principalTable: "citizen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_citizen_transaction_common_data_transaction_common_data_transaction_common_dataId",
                        column: x => x.transaction_common_dataId,
                        principalTable: "transaction_common_data",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "transaction_additional_data",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transaction_common_data_id = table.Column<int>(nullable: false),
                    TT2_piece_description = table.Column<string>(nullable: true),
                    TT2_province_description = table.Column<string>(nullable: true),
                    TT3_purpose = table.Column<string>(nullable: true),
                    TT5_vehicle_number = table.Column<string>(nullable: true),
                    TT5_vehicle_type = table.Column<string>(nullable: true),
                    TT5_vehicle_year_number = table.Column<string>(nullable: true),
                    TT5_vehicle_color = table.Column<string>(nullable: true),
                    TT5_vehicle_manufact_year = table.Column<int>(nullable: true),
                    TT5_vehicle_passenger_count = table.Column<int>(nullable: true),
                    TT5_vehicle_cargo = table.Column<string>(nullable: true),
                    TT5_vehicle_engine_number = table.Column<string>(nullable: true),
                    TT5_vehicle_shase_number = table.Column<string>(nullable: true),
                    TT5_vehicle_owner_name = table.Column<string>(nullable: true),
                    TT5_vehicle_holder_name = table.Column<string>(nullable: true),
                    TT6_amount = table.Column<double>(nullable: true),
                    TT6_attendance_at = table.Column<string>(nullable: true),
                    TT6_attendance_for = table.Column<string>(nullable: true),
                    TT6_payment_safe = table.Column<string>(nullable: true),
                    TT7_amount = table.Column<double>(nullable: true),
                    TT7_court_name = table.Column<string>(nullable: true),
                    TT7_court_case_number = table.Column<string>(nullable: true),
                    TT8_partner_name = table.Column<string>(nullable: true),
                    TT9_student_name = table.Column<string>(nullable: true),
                    TT9_donor = table.Column<string>(nullable: true),
                    TT9_certificate_name = table.Column<string>(nullable: true),
                    TT10_martyr_name = table.Column<string>(nullable: true),
                    TT10_martyr_date = table.Column<DateTime>(nullable: true),
                    TT12_transaction_description = table.Column<string>(nullable: true),
                    TT12_transaction_conditions = table.Column<string>(nullable: true),
                    TT13_confession = table.Column<string>(nullable: true),
                    TT16_chapter1 = table.Column<string>(nullable: true),
                    TT16_chapter2 = table.Column<string>(nullable: true),
                    TT16_period = table.Column<string>(nullable: true),
                    TT19_current_record_count = table.Column<string>(nullable: true),
                    TT19_current_record_date = table.Column<DateTime>(nullable: true),
                    TT19_current_record_lather = table.Column<string>(nullable: true),
                    TT19_from_record_count = table.Column<string>(nullable: true),
                    TT19_from_record_date = table.Column<DateTime>(nullable: true),
                    TT19_from_record_lather = table.Column<string>(nullable: true),
                    TT19_to_record_count = table.Column<string>(nullable: true),
                    TT19_to_record_date = table.Column<DateTime>(nullable: true),
                    TT19_to_record_lather = table.Column<string>(nullable: true),
                    TT19_judgement = table.Column<string>(nullable: true),
                    TT19_district_id = table.Column<int>(nullable: true),
                    TT19_building = table.Column<string>(nullable: true),
                    TT19_piece = table.Column<string>(nullable: true),
                    TT19_province = table.Column<string>(nullable: true),
                    TT19_owner_name = table.Column<string>(nullable: true),
                    TT19_factory_name = table.Column<string>(nullable: true),
                    TT19_mortgage_from = table.Column<string>(nullable: true),
                    TT19_mortgage_to = table.Column<string>(nullable: true),
                    TT19_mortgage_type = table.Column<string>(nullable: true),
                    TT19_mortgage_amount = table.Column<double>(nullable: true),
                    TT19_mortgage_start_date = table.Column<DateTime>(nullable: true),
                    TT19_mortgage_end_date = table.Column<DateTime>(nullable: true),
                    TT19_mortgage_other = table.Column<string>(nullable: true),
                    TT19_mortgage_over_date = table.Column<DateTime>(nullable: true),
                    TT19_machine_type = table.Column<string>(nullable: true),
                    TT19_machine_specifications = table.Column<string>(nullable: true),
                    TT19_machine_origin = table.Column<string>(nullable: true),
                    TT19_machine_fuel_type = table.Column<string>(nullable: true),
                    TT19_machine_horse_power = table.Column<string>(nullable: true),
                    TT19_machine_volume = table.Column<string>(nullable: true),
                    TT19_machine_class = table.Column<string>(nullable: true),
                    TT19_machine_purpose = table.Column<string>(nullable: true),
                    TT19_machine_information = table.Column<string>(nullable: true),
                    TT19_machine_purchase = table.Column<string>(nullable: true),
                    TT19_machine_value = table.Column<double>(nullable: true),
                    TT19_current_actions = table.Column<string>(nullable: true),
                    TT19_governorate_id = table.Column<int>(nullable: true),
                    TT20_governorate_id = table.Column<int>(nullable: true),
                    TT20_judgement = table.Column<string>(nullable: true),
                    TT20_district_id = table.Column<int>(nullable: true),
                    TT20_building = table.Column<string>(nullable: true),
                    TT20_piece = table.Column<string>(nullable: true),
                    TT20_province = table.Column<string>(nullable: true),
                    TT20_owner_name = table.Column<string>(nullable: true),
                    TT20_factory_name = table.Column<string>(nullable: true),
                    TT20_edbara_number = table.Column<string>(nullable: true),
                    TT20_mortgage_from = table.Column<string>(nullable: true),
                    TT20_mortgage_to = table.Column<string>(nullable: true),
                    TT20_mortgage_type = table.Column<string>(nullable: true),
                    TT20_mortgage_amount = table.Column<double>(nullable: true),
                    TT20_mortgage_start_date = table.Column<DateTime>(nullable: true),
                    TT20_mortgage_end_date = table.Column<DateTime>(nullable: true),
                    TT20_record_lether = table.Column<string>(nullable: true),
                    TT20_survey_wage = table.Column<double>(nullable: true),
                    TT20_survey_employee = table.Column<string>(nullable: true),
                    TT20_survey_expert = table.Column<string>(nullable: true),
                    TT20_survey_date = table.Column<DateTime>(nullable: true),
                    TT20_current_actions = table.Column<string>(nullable: true),
                    TT21_Edbara_number = table.Column<string>(nullable: true),
                    TT21_current_record_count = table.Column<int>(nullable: true),
                    TT21_current_record_date = table.Column<DateTime>(nullable: true),
                    TT21_current_record_lather = table.Column<string>(nullable: true),
                    TT21_from_record_count = table.Column<int>(nullable: true),
                    TT21_from_record_date = table.Column<DateTime>(nullable: true),
                    TT21_from_record_lather = table.Column<string>(nullable: true),
                    TT21_to_record_count = table.Column<int>(nullable: true),
                    TT21_to_record_date = table.Column<DateTime>(nullable: true),
                    TT21_to_record_lather = table.Column<string>(nullable: true),
                    TT21_governorate_id = table.Column<int>(nullable: true),
                    TT21_judgement = table.Column<string>(nullable: true),
                    TT21_district_id = table.Column<int>(nullable: true),
                    TT21_building = table.Column<string>(nullable: true),
                    TT21_piece = table.Column<string>(nullable: true),
                    TT21_province = table.Column<string>(nullable: true),
                    TT21_owner_name = table.Column<string>(nullable: true),
                    TT21_factory_name = table.Column<string>(nullable: true),
                    TT21_mortgage_from = table.Column<string>(nullable: true),
                    TT21_mortgage_to = table.Column<string>(nullable: true),
                    TT21_mortgage_type = table.Column<string>(nullable: true),
                    TT21_mortgage_amount = table.Column<double>(nullable: true),
                    TT21_mortgage_start_date = table.Column<DateTime>(nullable: true),
                    TT21_mortgage_end_date = table.Column<DateTime>(nullable: true),
                    TT21_mortgage_other = table.Column<string>(nullable: true),
                    TT21_mortgage_over_date = table.Column<DateTime>(nullable: true),
                    TT21_machine_type = table.Column<string>(nullable: true),
                    TT21_machine_specifications = table.Column<string>(nullable: true),
                    TT21_machine_origin = table.Column<string>(nullable: true),
                    TT21_machine_fuel_type = table.Column<string>(nullable: true),
                    TT21_machine_horse_power = table.Column<string>(nullable: true),
                    TT21_machine_volume = table.Column<string>(nullable: true),
                    TT21_machine_class = table.Column<string>(nullable: true),
                    TT21_machine_purpose = table.Column<string>(nullable: true),
                    TT21_machine_information = table.Column<string>(nullable: true),
                    TT21_machine_purchase = table.Column<string>(nullable: true),
                    TT21_machine_value = table.Column<double>(nullable: true),
                    TT21_current_actions = table.Column<string>(nullable: true),
                    TT23_recorded1 = table.Column<string>(nullable: true),
                    TT23_recorded1_date = table.Column<DateTime>(nullable: true),
                    TT23_recorded2 = table.Column<string>(nullable: true),
                    TT24_amount = table.Column<double>(nullable: true),
                    TT24_amount_text = table.Column<string>(nullable: true),
                    TT24_amount_reason = table.Column<string>(nullable: true),
                    TT25_due_date = table.Column<DateTime>(nullable: true),
                    TT25_amount = table.Column<double>(nullable: true),
                    TT25_amount_text = table.Column<string>(nullable: true),
                    TT25_amount_reason = table.Column<string>(nullable: true),
                    TT29_warning_description = table.Column<string>(nullable: true),
                    TT30_warning_description = table.Column<string>(nullable: true),
                    TT33_warning_description = table.Column<string>(nullable: true),
                    TT34_warning_Number = table.Column<string>(nullable: true),
                    TT34_warning_Date = table.Column<DateTime>(nullable: true),
                    TT34_warning_description = table.Column<string>(nullable: true),
                    TT34_intimation_date = table.Column<DateTime>(nullable: true),
                    TT34_intimation_name = table.Column<string>(nullable: true),
                    TT31_previous_JW = table.Column<string>(nullable: true),
                    TT31_previous_transaction_number = table.Column<string>(nullable: true),
                    TT31_previous_date = table.Column<DateTime>(nullable: true),
                    TT31_previous_record_number = table.Column<int>(nullable: true),
                    TT36_previous_JW_office = table.Column<string>(nullable: true),
                    TT36_previous_public_number = table.Column<int>(nullable: true),
                    TT36_previous_date = table.Column<DateTime>(nullable: true),
                    TT36_previous_record_number = table.Column<int>(nullable: true),
                    TT36_warning_description = table.Column<string>(nullable: true),
                    TT16_contact_value = table.Column<double>(nullable: true),
                    TT19_contract_deccription = table.Column<string>(nullable: true),
                    TT19_contract_confitions = table.Column<string>(nullable: true),
                    TT19_contact_value = table.Column<double>(nullable: true),
                    TT26_PagesCount = table.Column<int>(nullable: true),
                    TT27_source_trans_public_nuber = table.Column<int>(nullable: true),
                    TT36_transaction_number = table.Column<string>(nullable: true),
                    TT38_association_type = table.Column<string>(nullable: true),
                    TT38_record_number = table.Column<string>(nullable: true),
                    TT38_record_number_owner = table.Column<string>(nullable: true),
                    TT40_association_transaction_number = table.Column<string>(nullable: true),
                    TT27_PagesCount = table.Column<int>(nullable: true),
                    TT29_warning_acting = table.Column<string>(nullable: true),
                    TT29_warning_notification_to = table.Column<string>(nullable: true),
                    TT31_warning_acting = table.Column<string>(nullable: true),
                    TT31_warning_notification_to = table.Column<string>(nullable: true),
                    TT33_transaction_number = table.Column<string>(nullable: true),
                    TT33_warning_acting = table.Column<string>(nullable: true),
                    TT33_warning_notification_to = table.Column<string>(nullable: true),
                    TT30_real_Estate_number = table.Column<string>(nullable: true),
                    TT30_district_id = table.Column<int>(nullable: true),
                    TT30_rent_value = table.Column<double>(nullable: true),
                    TT30_warning_acting = table.Column<string>(nullable: true),
                    TT30_warning_notification_to = table.Column<string>(nullable: true),
                    TT30_Secretariats = table.Column<bool>(nullable: true),
                    TT29_print_warning_notification = table.Column<bool>(nullable: true),
                    TT29_print_warning_notification_book = table.Column<bool>(nullable: true),
                    TT30_print_warning_notification = table.Column<bool>(nullable: true),
                    TT30_print_warning_notification_book = table.Column<bool>(nullable: true),
                    TT31_print_warning_notification = table.Column<bool>(nullable: true),
                    TT31_print_warning_notification_book = table.Column<bool>(nullable: true),
                    TT33_print_warning_notification = table.Column<bool>(nullable: true),
                    TT33_print_warning_notification_book = table.Column<bool>(nullable: true),
                    TT43_amount = table.Column<double>(nullable: true),
                    TT43_attendance_at = table.Column<string>(nullable: true),
                    TT43_attendance_for = table.Column<string>(nullable: true),
                    TT43_payment_safe = table.Column<string>(nullable: true),
                    TT15_contract_deccription = table.Column<string>(nullable: true),
                    TT15_contract_confitions = table.Column<string>(nullable: true),
                    TT15_contract_value = table.Column<double>(nullable: true),
                    TT14_contract_deccription = table.Column<string>(nullable: true),
                    TT14_contract_confitions = table.Column<string>(nullable: true),
                    TT14_is_contract_withvalue = table.Column<bool>(nullable: true),
                    TT14_contract_value = table.Column<double>(nullable: true),
                    TT17_contract_deccription = table.Column<string>(nullable: true),
                    TT17_contract_confitions = table.Column<string>(nullable: true),
                    TT17_is_contract_withvalue = table.Column<bool>(nullable: true),
                    TT17_contract_value = table.Column<double>(nullable: true),
                    TT18_contract_deccription = table.Column<string>(nullable: true),
                    TT18_contract_confitions = table.Column<string>(nullable: true),
                    TT18_is_contract_withvalue = table.Column<bool>(nullable: true),
                    TT18_contract_value = table.Column<double>(nullable: true),
                    TT32_previous_JW = table.Column<string>(nullable: true),
                    TT32_previous_transaction_number = table.Column<string>(nullable: true),
                    TT32_previous_date = table.Column<DateTime>(nullable: true),
                    TT32_previous_record_number = table.Column<int>(nullable: true),
                    TT32_warning_acting = table.Column<string>(nullable: true),
                    TT32_warning_notification_to = table.Column<string>(nullable: true),
                    TT32_print_warning_notification = table.Column<bool>(nullable: true),
                    TT32_print_warning_notification_book = table.Column<bool>(nullable: true),
                    TT44_contract_deccription = table.Column<string>(nullable: true),
                    TT44_contract_confitions = table.Column<string>(nullable: true),
                    TT44_contract_value = table.Column<double>(nullable: true),
                    TT41_request_type = table.Column<string>(nullable: true),
                    TT41_nameof_almukhtas_visit = table.Column<string>(nullable: true),
                    TT41_placefor_almukhtas = table.Column<string>(nullable: true),
                    TT41_resonfor_visit = table.Column<string>(nullable: true),
                    TT41_machine_description = table.Column<string>(nullable: true),
                    TT41_placefor_machine = table.Column<string>(nullable: true),
                    transaction_common_dataId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction_additional_data", x => x.Id);
                    table.ForeignKey(
                        name: "FK_transaction_additional_data_transaction_common_data_transaction_common_dataId",
                        column: x => x.transaction_common_dataId,
                        principalTable: "transaction_common_data",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "transaction_additional_data_sub",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transaction_common_data_id = table.Column<int>(nullable: false),
                    TT20_sub_machine_type = table.Column<string>(nullable: true),
                    TT20_sub_machine_specifications = table.Column<string>(nullable: true),
                    TT20_sub_machine_origin = table.Column<string>(nullable: true),
                    TT20_sub_machine_purchase = table.Column<string>(nullable: true),
                    TT20_sub_machine_value = table.Column<double>(nullable: true),
                    transaction_common_dataId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction_additional_data_sub", x => x.Id);
                    table.ForeignKey(
                        name: "FK_transaction_additional_data_sub_transaction_common_data_transaction_common_dataId",
                        column: x => x.transaction_common_dataId,
                        principalTable: "transaction_common_data",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "transaction_common_data_FeesSetting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionId = table.Column<int>(nullable: false),
                    FeesTypeId = table.Column<int>(nullable: false),
                    PercentageForOriginal = table.Column<decimal>(nullable: true),
                    PercentageForCopies = table.Column<decimal>(nullable: true),
                    MinValueForOriginal = table.Column<decimal>(nullable: true),
                    MaxValueForOriginal = table.Column<decimal>(nullable: true),
                    MinValueForCopies = table.Column<decimal>(nullable: true),
                    MaxValueForCopies = table.Column<decimal>(nullable: true),
                    ValueOfOriginal = table.Column<decimal>(nullable: true),
                    ValueOfCopies = table.Column<decimal>(nullable: true),
                    OriginalFinalPercentageValue = table.Column<decimal>(nullable: true),
                    CopiesFinalPercentageValue = table.Column<decimal>(nullable: true),
                    transaction_common_dataId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction_common_data_FeesSetting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_transaction_common_data_FeesSetting_transaction_common_data_transaction_common_dataId",
                        column: x => x.transaction_common_dataId,
                        principalTable: "transaction_common_data",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "transaction_common_data_transaction_status",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transaction_common_data_id = table.Column<int>(nullable: false),
                    transaction_status_id = table.Column<int>(nullable: false),
                    start_timestamp = table.Column<DateTime>(nullable: false),
                    end_timestamp = table.Column<DateTime>(nullable: true),
                    user_id = table.Column<int>(nullable: false),
                    isCurrent = table.Column<bool>(nullable: false),
                    RejectionReason = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    transaction_common_dataId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction_common_data_transaction_status", x => x.Id);
                    table.ForeignKey(
                        name: "FK_transaction_common_data_transaction_status_transaction_common_data_transaction_common_dataId",
                        column: x => x.transaction_common_dataId,
                        principalTable: "transaction_common_data",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "transaction_copy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transaction_common_data_id = table.Column<int>(nullable: false),
                    scanned_copy = table.Column<byte[]>(nullable: true),
                    scanned_description = table.Column<string>(nullable: true),
                    CopyTypeID = table.Column<int>(nullable: true),
                    transaction_common_dataId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction_copy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_transaction_copy_transaction_common_data_transaction_common_dataId",
                        column: x => x.transaction_common_dataId,
                        principalTable: "transaction_common_data",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "transaction_document",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    document_description = table.Column<string>(nullable: true),
                    document_type_id = table.Column<int>(nullable: false),
                    transaction_common_data_id = table.Column<int>(nullable: false),
                    documentCategoryId = table.Column<int>(nullable: true),
                    NotaryDocumentsId = table.Column<int>(nullable: true),
                    transaction_common_dataId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction_document", x => x.Id);
                    table.ForeignKey(
                        name: "FK_transaction_document_NotaryDocuments_NotaryDocumentsId",
                        column: x => x.NotaryDocumentsId,
                        principalTable: "NotaryDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_transaction_document_transaction_common_data_transaction_common_dataId",
                        column: x => x.transaction_common_dataId,
                        principalTable: "transaction_common_data",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "user_activity_log",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    log_timestamp = table.Column<DateTime>(nullable: false),
                    log_description = table.Column<string>(nullable: true),
                    user_activity_log_type_id = table.Column<int>(nullable: false),
                    transaction_common_data_id = table.Column<int>(nullable: true),
                    user_id = table.Column<int>(nullable: false),
                    transaction_common_dataId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_activity_log", x => x.Id);
                    table.ForeignKey(
                        name: "FK_user_activity_log_transaction_common_data_transaction_common_dataId",
                        column: x => x.transaction_common_dataId,
                        principalTable: "transaction_common_data",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CitizenIdentity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    citizen_id_number = table.Column<string>(nullable: true),
                    citizen_id_date = table.Column<DateTime>(nullable: true),
                    citizen_id_issued_from = table.Column<string>(nullable: true),
                    citizen_id_type_id = table.Column<int>(nullable: true),
                    CitizenTransactionCommonDataId = table.Column<int>(nullable: true),
                    citizen_id_record = table.Column<string>(nullable: true),
                    citizen_id_sahefa = table.Column<string>(nullable: true),
                    citizen_id_m = table.Column<string>(nullable: true),
                    citizen_id_z = table.Column<string>(nullable: true),
                    citizen_id_d = table.Column<string>(nullable: true),
                    citizen_id_form_number = table.Column<string>(nullable: true),
                    citizen_id_information_office = table.Column<string>(nullable: true),
                    citizen_bookdate = table.Column<string>(nullable: true),
                    citizen_transaction_common_dataId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitizenIdentity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CitizenIdentity_citizen_transaction_common_data_citizen_transaction_common_dataId",
                        column: x => x.citizen_transaction_common_dataId,
                        principalTable: "citizen_transaction_common_data",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "transaction_fp_photo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transaction_common_data_id = table.Column<int>(nullable: false),
                    finger_print = table.Column<byte[]>(nullable: true),
                    citizen_photo = table.Column<byte[]>(nullable: true),
                    citizen_transaction_common_data_id = table.Column<int>(nullable: true),
                    citizen_transaction_common_dataId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction_fp_photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_transaction_fp_photo_citizen_transaction_common_data_citizen_transaction_common_dataId",
                        column: x => x.citizen_transaction_common_dataId,
                        principalTable: "citizen_transaction_common_data",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "transaction_updates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    field_name = table.Column<string>(nullable: true),
                    required_updates = table.Column<string>(nullable: true),
                    transaction_common_data_id = table.Column<int>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: false),
                    citizen_transaction_common_data_Id = table.Column<int>(nullable: true),
                    citizen_transaction_common_dataId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction_updates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_transaction_updates_citizen_transaction_common_data_citizen_transaction_common_dataId",
                        column: x => x.citizen_transaction_common_dataId,
                        principalTable: "citizen_transaction_common_data",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_citizen_transaction_common_data_citizenId",
                table: "citizen_transaction_common_data",
                column: "citizenId");

            migrationBuilder.CreateIndex(
                name: "IX_citizen_transaction_common_data_transaction_common_dataId",
                table: "citizen_transaction_common_data",
                column: "transaction_common_dataId");

            migrationBuilder.CreateIndex(
                name: "IX_CitizenIdentity_citizen_transaction_common_dataId",
                table: "CitizenIdentity",
                column: "citizen_transaction_common_dataId");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_additional_data_transaction_common_dataId",
                table: "transaction_additional_data",
                column: "transaction_common_dataId");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_additional_data_sub_transaction_common_dataId",
                table: "transaction_additional_data_sub",
                column: "transaction_common_dataId");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_common_data_external_visit_requestsid",
                table: "transaction_common_data",
                column: "external_visit_requestsid");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_common_data_FeesSetting_transaction_common_dataId",
                table: "transaction_common_data_FeesSetting",
                column: "transaction_common_dataId");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_common_data_transaction_status_transaction_common_dataId",
                table: "transaction_common_data_transaction_status",
                column: "transaction_common_dataId");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_copy_transaction_common_dataId",
                table: "transaction_copy",
                column: "transaction_common_dataId");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_document_NotaryDocumentsId",
                table: "transaction_document",
                column: "NotaryDocumentsId");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_document_transaction_common_dataId",
                table: "transaction_document",
                column: "transaction_common_dataId");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_fp_photo_citizen_transaction_common_dataId",
                table: "transaction_fp_photo",
                column: "citizen_transaction_common_dataId");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_updates_citizen_transaction_common_dataId",
                table: "transaction_updates",
                column: "citizen_transaction_common_dataId");

            migrationBuilder.CreateIndex(
                name: "IX_user_activity_log_transaction_common_dataId",
                table: "user_activity_log",
                column: "transaction_common_dataId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CitizenIdentity");

            migrationBuilder.DropTable(
                name: "transaction_additional_data");

            migrationBuilder.DropTable(
                name: "transaction_additional_data_sub");

            migrationBuilder.DropTable(
                name: "transaction_common_data_FeesSetting");

            migrationBuilder.DropTable(
                name: "transaction_common_data_transaction_status");

            migrationBuilder.DropTable(
                name: "transaction_copy");

            migrationBuilder.DropTable(
                name: "transaction_document");

            migrationBuilder.DropTable(
                name: "transaction_fp_photo");

            migrationBuilder.DropTable(
                name: "transaction_updates");

            migrationBuilder.DropTable(
                name: "user_activity_log");

            migrationBuilder.DropTable(
                name: "NotaryDocuments");

            migrationBuilder.DropTable(
                name: "citizen_transaction_common_data");

            migrationBuilder.DropTable(
                name: "citizen");

            migrationBuilder.DropTable(
                name: "transaction_common_data");

            migrationBuilder.DropTable(
                name: "external_visit_requests");
        }
    }
}
