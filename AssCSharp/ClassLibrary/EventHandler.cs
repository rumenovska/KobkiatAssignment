using System;

namespace ClassLibrary
{
    public class HttpHandller
    {
        public event EventHandler WebContentReturned;
        protected virtual void onWebContentReturned(HttpResponseArgs e) {
            EventHandler handler = WebContentReturned;
            handler?.Invoke(this, e);

        
        }
        public delegate void WebContentReturnedEventHandler(object sender, HttpResponseArgs e);

    }
}
