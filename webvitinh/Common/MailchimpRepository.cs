using MailChimp.Net;
using MailChimp.Net.Core;
using MailChimp.Net.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
class MailchimpRepository
{
    private const string ApiKey = "f5419ac5e9d1ee587a39d565fb0f02ca-us3";
    private const string ListId = "32d6e649f6";
    private const int TemplateId = 339009; // (your template id)
    private MailChimpManager _mailChimpManager = new MailChimpManager(ApiKey);
    private Setting _campaignSettings = new Setting
    {
        ReplyTo = "tonyne142@gmail.com",
        FromName = "Admin123 from Webvitinh",
        Title = "Product Promotion",
        SubjectLine = "Try it out !!",
    };

    // `html` contains the content of your email using html notation
    public void CreateAndSendCampaign(string html)
    {
        var campaign = _mailChimpManager.Campaigns.AddAsync(new Campaign
        {
            Settings = _campaignSettings,
            Recipients = new Recipient { ListId = ListId },
            Type = CampaignType.Regular
        }).Result;
        var timeStr = DateTime.Now.ToString();
        var content = _mailChimpManager.Content.AddOrUpdateAsync(
        campaign.Id,
         new ContentRequest()
         {
             Template = new ContentTemplate
             {
                 Id = TemplateId,
                 Sections = new Dictionary<string, object>()
            {
       { "body_content", html },
       { "preheader_leftcol_content", $"<p>{timeStr}</p>" }
            }
             }
         }).Result;
        _mailChimpManager.Campaigns.SendAsync(campaign.Id).Wait();
    }
    public List<Template> GetAllTemplates()
      => _mailChimpManager.Templates.GetAllAsync().Result.ToList();
    public List<List> GetAllMailingLists()
      => _mailChimpManager.Lists.GetAllAsync().Result.ToList();
    public Content GetTemplateDefaultContent(string templateId)
      => (Content)_mailChimpManager.Templates.GetDefaultContentAsync(templateId).Result;
}