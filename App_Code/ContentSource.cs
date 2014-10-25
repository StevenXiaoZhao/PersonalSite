<<<<<<< HEAD
﻿using System;

public class ContentSource {
    public ContentSource(string header, string title, string pagePath, bool shouldCacheContent = true) {
        if (header == null) {
            throw new ArgumentNullException("header");
        }

        if (pagePath == null) {
            throw new ArgumentNullException("pagePath");
        }

        if (title == null) {
            throw new ArgumentNullException("title");
        }

        // use the Header as the ID.
        Id = header.Replace(" ", "_");

        Title = title;
        Header = header;
        PagePath = pagePath;
        ShouldCacheContent = shouldCacheContent;
    }

    public string Id { get; private set; }
    public string Header { get; private set; }
    public string Title { get; private set; }
    public string PagePath { get; private set; }
    public bool ShouldCacheContent { get; private set; }
=======
﻿using System;

public class ContentSource {
    public ContentSource(string header, string title, string pagePath, bool shouldCacheContent = true) {
        if (header == null) {
            throw new ArgumentNullException("header");
        }

        if (pagePath == null) {
            throw new ArgumentNullException("pagePath");
        }

        if (title == null) {
            throw new ArgumentNullException("title");
        }

        // use the Header as the ID.
        Id = header.Replace(" ", "_");

        Title = title;
        Header = header;
        PagePath = pagePath;
        ShouldCacheContent = shouldCacheContent;
    }

    public string Id { get; private set; }
    public string Header { get; private set; }
    public string Title { get; private set; }
    public string PagePath { get; private set; }
    public bool ShouldCacheContent { get; private set; }
>>>>>>> c40e365373ba58d1c4f199631118a688e2256da7
}