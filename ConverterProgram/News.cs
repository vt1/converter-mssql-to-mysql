using System;

namespace ConverterProgram
{
    class News
    {
        private int id;
        private int newsID;
        private int categoryID;
        private int langID;
        private string title;
        private DateTime pubDate;
        private string shortText;
        private string fullText;
        private string sourceText;
        private int isActive;
        private string tags;

        public News(int id, int newsID, int categoryID, int langID, string title, DateTime pubDate,
                    string shortText, string fullText, string sourceText, int isActive, string tags)
        {
            this.id = id;
            this.newsID = id;
            this.categoryID = categoryID;
            this.langID = langID;
            this.title = title;
            this.pubDate = pubDate;
            this.shortText = shortText;
            this.fullText = fullText;
            this.sourceText = sourceText;
            this.isActive = isActive;
            this.tags = tags;
        }
        
        public void setId(int id)
        {
            this.id = id;
        }
        public void setNewsID(int newsID)
        {
            this.newsID = newsID;
        }
        public void setCategoryID(int categoryID)
        {
            this.categoryID = categoryID;
        }
        public void setLangID(int langID)
        {
            this.langID = langID;
        }
        public void setTitle(string title)
        {
            this.title = title;
        }
        public void setPubDate(DateTime pubDate)
        {
            this.pubDate = pubDate;
        }
        public void setShortText(string shortText)
        {
            this.shortText = shortText;
        }
        public void setFullText(string fullText)
        {
            this.fullText = fullText;
        }
        public void setSourceText(string sourceText)
        {
            this.sourceText = sourceText;
        }
        public void setIsActive(int isActive)
        {
            this.isActive = isActive;
        }
        public void setTags(string tags)
        {
            this.tags = tags;
        }


        public int getId()
        {
            return id;
        }
        public int getNewsID()
        {
            return newsID;
        }
        public int getCategoryID()
        {
            return categoryID;
        }
        public int getLangID()
        {
            return langID;
        }
        public string getTitle()
        {
            return title;
        }
        public DateTime getPubDate()
        {
            return pubDate;
        }
        public string getShortText()
        {
            return shortText;
        }
        public string getFullText()
        {
            return fullText;
        }
        public string getSourceText()
        {
            return sourceText;
        }
        public int getIsActive()
        {
            return isActive;
        }
        public string getTags()
        {
            return tags;
        }

    }
}
