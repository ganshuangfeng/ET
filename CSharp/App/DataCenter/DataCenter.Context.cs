﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataCenter
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DataCenterEntities : DbContext
    {
        public DataCenterEntities()
            : base("name=DataCenterEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<t_account> t_account { get; set; }
        public DbSet<t_account_active_code> t_account_active_code { get; set; }
        public DbSet<t_account_login_auth_response_cookie> t_account_login_auth_response_cookie { get; set; }
        public DbSet<t_active_code> t_active_code { get; set; }
        public DbSet<t_attribute> t_attribute { get; set; }
        public DbSet<t_auction_item> t_auction_item { get; set; }
        public DbSet<t_available_map> t_available_map { get; set; }
        public DbSet<t_battle_gameover_statistic> t_battle_gameover_statistic { get; set; }
        public DbSet<t_battle_kill_detail> t_battle_kill_detail { get; set; }
        public DbSet<t_battle_summary> t_battle_summary { get; set; }
        public DbSet<t_beginner_group_config> t_beginner_group_config { get; set; }
        public DbSet<t_beginner_group_cong> t_beginner_group_cong { get; set; }
        public DbSet<t_beginner_group_event> t_beginner_group_event { get; set; }
        public DbSet<t_challenge_activity> t_challenge_activity { get; set; }
        public DbSet<t_challenge_activity_schedule> t_challenge_activity_schedule { get; set; }
        public DbSet<t_challenge_character_elect_hero> t_challenge_character_elect_hero { get; set; }
        public DbSet<t_challenge_elect_hero_stat> t_challenge_elect_hero_stat { get; set; }
        public DbSet<t_challenge_game_player> t_challenge_game_player { get; set; }
        public DbSet<t_challenge_guess_game_over> t_challenge_guess_game_over { get; set; }
        public DbSet<t_challenge_guess_reward> t_challenge_guess_reward { get; set; }
        public DbSet<t_challenge_kfz_hero> t_challenge_kfz_hero { get; set; }
        public DbSet<t_challenge_statue_info> t_challenge_statue_info { get; set; }
        public DbSet<t_challenge_task_reward> t_challenge_task_reward { get; set; }
        public DbSet<t_character> t_character { get; set; }
        public DbSet<t_character_achievement> t_character_achievement { get; set; }
        public DbSet<t_character_appearance> t_character_appearance { get; set; }
        public DbSet<t_character_assets> t_character_assets { get; set; }
        public DbSet<t_character_default_fighting_options> t_character_default_fighting_options { get; set; }
        public DbSet<t_character_item> t_character_item { get; set; }
        public DbSet<t_character_options> t_character_options { get; set; }
        public DbSet<t_character_questionnaire> t_character_questionnaire { get; set; }
        public DbSet<t_charge_list> t_charge_list { get; set; }
        public DbSet<t_city_buff> t_city_buff { get; set; }
        public DbSet<t_city_task_finish_sub_state> t_city_task_finish_sub_state { get; set; }
        public DbSet<t_city_task_info> t_city_task_info { get; set; }
        public DbSet<t_client_config> t_client_config { get; set; }
        public DbSet<t_common_spell> t_common_spell { get; set; }
        public DbSet<t_daily_online_time> t_daily_online_time { get; set; }
        public DbSet<t_employ_notice_status> t_employ_notice_status { get; set; }
        public DbSet<t_employ_relation> t_employ_relation { get; set; }
        public DbSet<t_employee_info> t_employee_info { get; set; }
        public DbSet<t_employee_notice> t_employee_notice { get; set; }
        public DbSet<t_employer_notice> t_employer_notice { get; set; }
        public DbSet<t_fighting_evaluation_info> t_fighting_evaluation_info { get; set; }
        public DbSet<t_friend> t_friend { get; set; }
        public DbSet<t_friend_ban_match> t_friend_ban_match { get; set; }
        public DbSet<t_friend_group> t_friend_group { get; set; }
        public DbSet<t_game_hero_use_info> t_game_hero_use_info { get; set; }
        public DbSet<t_game_info> t_game_info { get; set; }
        public DbSet<t_gs_code> t_gs_code { get; set; }
        public DbSet<t_hero_color_scheme> t_hero_color_scheme { get; set; }
        public DbSet<t_hero_level_state> t_hero_level_state { get; set; }
        public DbSet<t_hero_pet> t_hero_pet { get; set; }
        public DbSet<t_hero_suggest_equipment> t_hero_suggest_equipment { get; set; }
        public DbSet<t_hero_unlock_hero> t_hero_unlock_hero { get; set; }
        public DbSet<t_illegal_term_rules> t_illegal_term_rules { get; set; }
        public DbSet<t_item_roll_list> t_item_roll_list { get; set; }
        public DbSet<t_login_reward> t_login_reward { get; set; }
        public DbSet<t_mail> t_mail { get; set; }
        public DbSet<t_mail_item> t_mail_item { get; set; }
        public DbSet<t_mall_items_sales_count> t_mall_items_sales_count { get; set; }
        public DbSet<t_map_play_info> t_map_play_info { get; set; }
        public DbSet<t_map_play_info_hero> t_map_play_info_hero { get; set; }
        public DbSet<t_map_play_info_hero_pet> t_map_play_info_hero_pet { get; set; }
        public DbSet<t_meta> t_meta { get; set; }
        public DbSet<t_offline_message> t_offline_message { get; set; }
        public DbSet<t_pve_equipment_scheme> t_pve_equipment_scheme { get; set; }
        public DbSet<t_pve_equipment_strength> t_pve_equipment_strength { get; set; }
        public DbSet<t_questionnaire> t_questionnaire { get; set; }
        public DbSet<t_rune_scheme> t_rune_scheme { get; set; }
        public DbSet<t_social_group_basic> t_social_group_basic { get; set; }
        public DbSet<t_social_group_manager> t_social_group_manager { get; set; }
        public DbSet<t_social_group_member> t_social_group_member { get; set; }
        public DbSet<t_title_info> t_title_info { get; set; }
        public DbSet<t_treasure> t_treasure { get; set; }
        public DbSet<t_tutorial> t_tutorial { get; set; }
        public DbSet<t_tutorial_status_info> t_tutorial_status_info { get; set; }
    }
}
