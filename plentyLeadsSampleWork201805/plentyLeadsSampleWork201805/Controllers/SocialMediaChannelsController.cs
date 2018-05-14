using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using plentyLeadsSampleWork201805.Models;

namespace plentyLeadsSampleWork201805.Controllers
{
    public class SocialMediaChannelsController : ApiController
    {
        private DataContext db = new DataContext();

        /*
         * ToDo: Arbeitsprobe
         */ 
        // DELETE: api/SocialMediaChannels/5
        [ResponseType(typeof(SocialMediaChannel))]
        public object DeleteSocialMediaChannel(int id)
        {
            return new { success = false };
        }

        // GET: api/SocialMediaChannels
        public object GetSocialMediaChannels()
        {
            try
            {
                return new { success = true, data = db.SocialMediaChannels };
            }
            catch (Exception ex)
            {

            }
            return new { success = false};
        }

        // GET: api/SocialMediaChannels/5
        [ResponseType(typeof(SocialMediaChannel))]
        public object GetSocialMediaChannel(int id)
        {
            if(id > 0)
            {
                SocialMediaChannel socialMediaChannel = db.SocialMediaChannels.Find(id);
                if (socialMediaChannel == null)
                {
                    return new { success = false };
                }
                return new { success = true, data = socialMediaChannel };
            }
            return new { success = false };
        }

        // PUT: api/SocialMediaChannels/5
        [ResponseType(typeof(void))]
        public object PutSocialMediaChannel(int id, SocialMediaChannel socialMediaChannel)
        {
            if (!ModelState.IsValid || id != socialMediaChannel.Id)
            {
                return new { success = false, data = socialMediaChannel };
            }

            db.Entry(socialMediaChannel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SocialMediaChannelExists(id))
                {
                    return new { success = false, data = socialMediaChannel };
                }
                else
                {
                    throw;
                }
            }

            return new { success = true };
        }

        // POST: api/SocialMediaChannels
        [ResponseType(typeof(SocialMediaChannel))]
        public object PostSocialMediaChannel(SocialMediaChannel socialMediaChannel)
        {
            if (!ModelState.IsValid)
            {
                return new { success = false, data = socialMediaChannel };
            }

            db.SocialMediaChannels.Add(socialMediaChannel);
            db.SaveChanges();

            return new { success = true, data = socialMediaChannel };
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SocialMediaChannelExists(int id)
        {
            return db.SocialMediaChannels.Count(e => e.Id == id) > 0;
        }
    }
}
