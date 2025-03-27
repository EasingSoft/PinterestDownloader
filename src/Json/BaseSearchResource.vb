Imports System.Runtime.Serialization
Public Class Root
    Public Property resource_response As ResourceResponse
    'Public Property client_context As ClientContext
    'Public Property resource As Resource
    'Public Property request_identifier As String
End Class
Public Class ImageX
    Public Property width As Integer
    Public Property height As Integer
    Public Property url As String
    Public Property dominant_color As String
End Class


Public Class Action
    Public Property id_reformatted As String
    Public Property filter_type As Integer
    Public Property type As String
    Public Property title As String
    Public Property id As String
    Public Property filters As List(Of Filter)
    Public Property feed_url As Object
    Public Property search_query As String
    Public Property request_params As RequestParams
    Public Property one_bar_filters As List(Of Object)
    Public Property search_parameters As List(Of Object)
    Public Property annotated_title As Object
    Public Property filter_keys As List(Of Object)
End Class

Public Class AggregatedPinData
    Public Property node_id As String
    Public Property has_xy_tags As Boolean
End Class

Public Class AnalysisUa
    Public Property app_type As Integer
    Public Property app_version As String
    Public Property browser_name As String
    Public Property browser_version As String
    Public Property device_type As Object
    Public Property device As String
    Public Property os_name As String
    Public Property os_version As String
End Class

Public Class AppleTouchIconImages
    Public Property orig As String
    <DataMember(Name:="50x")>
    Public Property _50x As String
End Class

Public Class AuxData
    Public Property pos As Integer
    Public Property w As Object
    Public Property rs As String
    Public Property label As String
    Public Property x As Object
    Public Property module_type As String
    Public Property query As String
    Public Property y As Object
    Public Property hybrid_search_params As Object
    Public Property top_level_selection_label As Object
    Public Property filter As Object
    Public Property entered_query As String
    Public Property subtracted_attributes As List(Of Object)
    Public Property options As List(Of Object)
    Public Property image_signature As Object
    Public Property journey_depth As Integer
    Public Property source_module_id As Object
    Public Property module_id As String
    Public Property h As Object
    Public Property product_filter_type As Object
End Class

Public Class Block
    Public Property block_type As Integer
    Public Property image As Object
    Public Property text As String
    Public Property block_style As BlockStyle
    Public Property type As String
    Public Property tracking_id As String
    Public Property image_signature As String
End Class

Public Class BlockStyle
    Public Property x_coord As Integer
    Public Property rotation As Integer
    Public Property corner_radius As Integer
    Public Property width As Integer
    Public Property height As Integer
    Public Property y_coord As Integer
End Class

Public Class Board
    Public Property node_id As String
    Public Property collaborating_users As List(Of CollaboratingUser)
    Public Property cover_images As CoverImages
    Public Property url As String
    Public Property type As String
    Public Property owner As Owner
    Public Property name As String
    Public Property id As String
    Public Property is_collaborative As Boolean
    Public Property collaborator_count As Integer
    Public Property section_count As Integer
    Public Property pin_count As Integer
    Public Property images As Images
    Public Property board_order_modified_at As String
End Class

Public Class ClientContext
    Public Property analysis_ua As AnalysisUa
    Public Property app_type_detailed As Integer
    Public Property app_version As String
    Public Property batch_exp As Boolean
    Public Property browser_locale As String
    Public Property browser_name As String
    Public Property browser_type As Integer
    Public Property browser_version As String
    Public Property country As String
    Public Property country_from_hostname As String
    Public Property country_from_ip As String
    Public Property csp_nonce As String
    Public Property current_url As String
    Public Property debug As Boolean
    Public Property deep_link As String
    Public Property enabled_advertiser_countries As List(Of String)
    Public Property facebook_token As Object
    Public Property full_path As String
    Public Property http_referrer As String
    Public Property impersonator_user_id As Object
    Public Property invite_code As String
    Public Property invite_sender_id As String
    Public Property is_authenticated As Boolean
    Public Property is_bot As String
    Public Property is_full_page As Boolean
    Public Property is_mobile_agent As Boolean
    Public Property is_sterling_on_steroids As Boolean
    Public Property is_tablet_agent As Boolean
    Public Property language As String
    Public Property locale As String
    Public Property origin As String
    Public Property path As String
    Public Property placed_experiences As Object
    Public Property referrer As Object
    Public Property region_from_ip As String
    Public Property request_host As String
    Public Property request_identifier As String
    Public Property social_bot As String
    Public Property stage As String
    Public Property sterling_on_steroids_ldap As Object
    Public Property sterling_on_steroids_user_type As Object
    Public Property theme As String
    Public Property unauth_id As String
    Public Property seo_debug As Boolean
    Public Property user_agent_can_use_native_app As Boolean
    Public Property user_agent_platform As String
    Public Property user_agent_platform_version As Object
    Public Property user_agent As String
    Public Property user As User
    Public Property utm_campaign As Object
    Public Property visible_url As String
End Class

Public Class CollaboratingUser
    Public Property node_id As String
    Public Property image_large_url As String
    Public Property username As String
    Public Property image_small_url As String
    Public Property follower_count As Integer
    Public Property is_primary_website_verified As Boolean
    Public Property ads_only_profile_site As Object
    Public Property verified_identity As VerifiedIdentity
    Public Property id As String
    Public Property is_verified_merchant As Boolean
    Public Property image_medium_url As String
    Public Property full_name As String
    Public Property is_ads_only_profile As Boolean
End Class

Public Class CoverImages
    <DataMember(Name:="222x")>
    Public Property _222x As ImageX
End Class

Public Class Data
    'Public Property clientTrackingParams As String
    'Public Property nag As Nag
    'Public Property shouldAppendGlobalSearch As Boolean
    Public Property results As List(Of Result)
    'Public Property rankedGuides As List(Of RankedGuide)
    'Public Property sensitivity As Sensitivity
    'Public Property oneBarModules As List(Of OneBarModule)
    'Public Property modeIcon As Object
    'Public Property queryL1VerticalIds As List(Of Long)
End Class

Public Class Display
    Public Property background_color_hex As List(Of String)
    Public Property border_color_hex As List(Of Object)
    Public Property id_reformatted As String
    Public Property text_color_hex As List(Of String)
    Public Property selected_text_color_hex As List(Of String)
    Public Property selected_border_color_hex As List(Of Object)
    Public Property icon_url As Object
    Public Property type As String
    Public Property selected_background_color_hex As List(Of String)
    Public Property id As String
    Public Property image_urls As List(Of Object)
    Public Property image_medium_url As String
    Public Property is_selected As Boolean
    Public Property icon As Integer
    Public Property alt_text As Object
    Public Property display_text As String
End Class

Public Class FaviconImages
    Public Property orig As String
    <DataMember(Name:="50x")>
    Public Property _50x As String
End Class

Public Class Filter
    Public Property disabled As Boolean
    Public Property type As String
    Public Property is_selected As Boolean
    Public Property id As String
    Public Property display As Display
    Public Property action As Action
    Public Property id_reformatted As String
End Class

Public Class ImageCrop
    Public Property min_y As Integer
    Public Property max_y As Integer
End Class

Public Class Images
    Public Property p170x As ImageX
    Public Property p236x As ImageX
    Public Property p474x As ImageX
    Public Property p736x As ImageX
    Public Property orig As ImageX
End Class

Public Class LinkDomain
    Public Property node_id As String
    Public Property official_user As OfficialUser
End Class

Public Class Metadata
    Public Property unity_search_query As Object
    Public Property canvas_aspect_ratio As Double
    Public Property pin_image_signature As String
    Public Property showreel_data As Object
    Public Property compatible_version As String
    Public Property template_type As Object
    Public Property pin_title As String
    Public Property is_promotable As Boolean
    Public Property root_pin_id As String
    Public Property is_compatible As Boolean
    Public Property recipe_data As Object
    Public Property is_editable As Boolean
    Public Property version As String
    Public Property root_user_id As String
    Public Property basics As Object
    Public Property diy_data As Object
End Class

Public Class Nag
End Class

Public Class NativeCreator
    Public Property node_id As String
    Public Property image_large_url As String
    Public Property username As String
    Public Property image_small_url As String
    Public Property follower_count As Integer
    Public Property is_primary_website_verified As Boolean
    Public Property ads_only_profile_site As Object
    Public Property verified_identity As VerifiedIdentity
    Public Property id As String
    Public Property is_verified_merchant As Boolean
    Public Property image_medium_url As String
    Public Property full_name As String
    Public Property is_ads_only_profile As Boolean
End Class

Public Class OfficialUser
    Public Property node_id As String
    Public Property image_large_url As String
    Public Property username As String
    Public Property image_small_url As String
    Public Property follower_count As Integer
    Public Property is_primary_website_verified As Boolean
    Public Property ads_only_profile_site As Object
    Public Property verified_identity As VerifiedIdentity
    Public Property id As String
    Public Property is_verified_merchant As Boolean
    Public Property image_medium_url As String
    Public Property full_name As String
    Public Property is_ads_only_profile As Boolean
End Class

Public Class OneBarModule
    Public Property animation As Integer
    Public Property type As String
    Public Property id As String
    Public Property module_type As Integer
    Public Property display As Display
    Public Property aux_data As AuxData
    Public Property action As Action
    Public Property tracking_params As String
End Class

Public Class Options
    Public Property bookmarks As List(Of String)
    Public Property applied_unified_filters As Object
    Public Property appliedProductFilters As String
    Public Property article As Object
    Public Property auto_correction_disabled As Boolean
    Public Property corpus As Object
    Public Property customized_rerank_type As Object
    Public Property domains As Object
    Public Property dynamicPageSizeExpGroup As Object
    Public Property filters As Object
    Public Property journey_depth As Object
    Public Property page_size As Object
    Public Property price_max As Object
    Public Property price_min As Object
    Public Property query_pin_sigs As Object
    Public Property query As String
    Public Property redux_normalize_feed As Boolean
    Public Property request_params As Object
    Public Property rs As String
    Public Property scope As String
    Public Property selected_one_bar_modules As Object
    Public Property seoDrawerEnabled As Boolean
    Public Property source_id As Object
    Public Property source_module_id As Object
    Public Property source_url As String
    Public Property top_pin_id As Object
    Public Property top_pin_ids As Object
End Class

Public Class Owner
    Public Property node_id As String
    Public Property image_large_url As String
    Public Property username As String
    Public Property image_small_url As String
    Public Property follower_count As Integer
    Public Property is_primary_website_verified As Boolean
    Public Property ads_only_profile_site As Object
    Public Property verified_identity As VerifiedIdentity
    Public Property id As String
    Public Property is_verified_merchant As Boolean
    Public Property image_medium_url As String
    Public Property full_name As String
    Public Property is_ads_only_profile As Boolean
End Class

Public Class Page
    Public Property layout As Integer
    Public Property image_adjusted As Object
    Public Property type As String
    Public Property should_mute As Boolean
    Public Property music_attributions As List(Of Object)
    Public Property image As Object
    Public Property id As String
    Public Property video As Object
    Public Property blocks As List(Of Block)
    Public Property video_signature As Object
    Public Property image_signature_adjusted As String
    Public Property style As Style
    Public Property image_signature As String
End Class

Public Class PagesPreview
    Public Property layout As Integer
    Public Property image_adjusted As Object
    Public Property type As String
    Public Property should_mute As Boolean
    Public Property music_attributions As List(Of Object)
    Public Property image As Object
    Public Property id As String
    Public Property video As Object
    Public Property blocks As List(Of Block)
    Public Property video_signature As Object
    Public Property image_signature_adjusted As String
    Public Property style As Style
    Public Property image_signature As String
End Class

Public Class Pinner
    'Public Property node_id As String
    'Public Property image_large_url As String
    Public Property username As String
    'Public Property image_small_url As String
    'Public Property follower_count As Integer
    'Public Property is_primary_website_verified As Boolean
    'Public Property ads_only_profile_site As Object
    'Public Property verified_identity As VerifiedIdentity
    Public Property id As String
    'Public Property is_verified_merchant As Boolean
    'Public Property image_medium_url As String
    Public Property full_name As String
    'Public Property is_ads_only_profile As Boolean
End Class

Public Class RankedGuide
    Public Property term As String
    Public Property display As String
    Public Property position As Integer
    Public Property dominant_color As String
    Public Property source As Integer
    Public Property guideType As Integer
    Public Property image_medium_url As String
    Public Property subtracted_attributes As List(Of Object)
    Public Property canonicalized_attr_id As Object
    Public Property score As Double
End Class

Public Class ReactionCounts
    <DataMember(Name:="1")>
    Public Property _1 As Integer
    <DataMember(Name:="7")>
    Public Property _7 As Integer
    <DataMember(Name:="11")>
    Public Property _11 As Integer?
    <DataMember(Name:="13")>
    Public Property _13 As Integer?
End Class

Public Class RequestParams
    Public Property source_module_id As String
    Public Property journey_depth As Integer
End Class

Public Class Resource
    Public Property name As String
    Public Property options As Options
End Class

Public Class ResourceResponse
    'Public Property bookmark As String
    'Public Property code As Integer
    'Public Property endpoint_name As String
    'Public Property http_status As Integer
    'Public Property message As String
    'Public Property status As String
    'Public Property x_pinterest_sli_endpoint_name As String
    'Public Property metadata As Metadata
    Public Property data As Data
End Class

Public Class Result
    'Public Property node_id As String
    'Public Property is_eligible_for_related_products As Boolean
    'Public Property is_downstream_promotion As Boolean
    'Public Property attribution As Object
    'Public Property title As String
    'Public Property image_crop As ImageCrop
    'Public Property should_open_in_stream As Boolean
    'Public Property is_oos_product As Boolean
    'Public Property debug_info_html As Object
    'Public Property reaction_counts As ReactionCounts
    Public Property images As Images
    'Public Property aggregated_pin_data As AggregatedPinData
    Public Property dominant_color As String
    'Public Property did_its As List(Of Object)
    'Public Property domain As String
    'Public Property is_eligible_for_pre_loved_goods_label As Boolean
    'Public Property is_promoted As Boolean
    'Public Property carousel_data As Object
    'Public Property promoted_is_removable As Boolean
    'Public Property digital_media_source_type As Object
    'Public Property rich_summary As RichSummary
    'Public Property pinner As Pinner
    'Public Property is_eligible_for_filters As Boolean
    'Public Property access As List(Of Object)
    'Public Property link_user_website As Object
    'Public Property shopping_flags As List(Of Object)
    'Public Property embed As Object
    'Public Property alt_text As String
    'Public Property promoter As Object
    'Public Property promoted_is_lead_ad As Boolean
    Public Property videos As videos
    'Public Property call_to_action_text As Object
    'Public Property native_creator As NativeCreator
    'Public Property sponsorship As Object
    'Public Property type As String
    'Public Property is_eligible_for_pdp As Boolean
    'Public Property is_stale_product As Boolean
    'Public Property is_shoppable As Boolean
    'Public Property is_go_linkless As Boolean
    'Public Property ad_match_reason As Integer
    'Public Property campaign_id As Object
    'Public Property has_required_attribution_provider As Boolean
    'Public Property collection_pin As Object
    'Public Property promoted_lead_form As Object
    'Public Property is_uploaded As Boolean
    'Public Property image_signature As String
    'Public Property grid_title As String
    'Public Property insertion_id As Object
    'Public Property story_pin_data As StoryPinData
    'Public Property is_prefetch_enabled As Boolean
    'Public Property description As String
    'Public Property is_eligible_for_web_closeup As Boolean
    Public Property created_at As String
    Public Property id As String
    'Public Property link As String
    'Public Property story_pin_data_id As String
    'Public Property board As Board
    Public Property auto_alt_text As String
    'Public Property tracking_params As String
    'Public Property link_domain As LinkDomain
End Class
Public Class videos
    Public Property video_list As video
    Public Property videoList As video
End Class
Public Class video
    Public Property V_HLSV4 As m3u8
    Public Property V_HLSV3_MOBILE As m3u8
    Public Property vHLSV3MOBILE As m3u8
    Public Property vHLSV4 As m3u8
    Public Property v720P As m3u8
End Class
Public Class m3u8
    Public Property url As String
    'Public Property width As Integer
    'Public Property height As Integer
    'Public Property duration As Integer
    'Public Property thumbnail As String
    'Public Property captions_urls As String
End Class

Public Class RichSummary
    Public Property favicon_link As String
    Public Property favicon_images As FaviconImages
    Public Property display_description As String
    Public Property type_name As String
    Public Property url As String
    Public Property type As String
    Public Property site_name As String
    Public Property apple_touch_icon_images As AppleTouchIconImages
    Public Property products As List(Of Object)
    Public Property actions As List(Of Object)
    Public Property display_name As String
    Public Property id As String
    Public Property apple_touch_icon_link As String
End Class

Public Class Sensitivity
End Class

Public Class StoryPinData
    Public Property node_id As String
    Public Property has_affiliate_products As Boolean
    Public Property total_video_duration As Integer
    Public Property static_page_count As Integer
    Public Property type As String
    Public Property metadata As Metadata
    Public Property pages As List(Of Page)
    Public Property pages_preview As List(Of PagesPreview)
    Public Property id As String
    Public Property last_edited As Object
    Public Property has_product_pins As Boolean
    Public Property page_count As Integer
End Class

Public Class Style
    Public Property background_color As String
    Public Property media_fit As Object
End Class

Public Class User
    Public Property unauth_id As String
    Public Property ip_country As String
    Public Property ip_region As Object
End Class

Public Class VerifiedIdentity
    Public Property verified As Boolean
End Class
