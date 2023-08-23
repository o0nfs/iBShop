using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class ArtMonthlyReport
{
    public int ArtMonthlyReportId { get; set; }

    public int Year { get; set; }

    public string Month { get; set; } = null!;

    public int MonthNumber { get; set; }

    public int MrkReq { get; set; }

    public int CompStudy { get; set; }

    public int ArchiveDesignQty { get; set; }

    public int MediaFailureQty { get; set; }

    public int SiteBannerAvgTime { get; set; }

    public int BrochureDesignAvgTime { get; set; }

    public int StoryDesignAvgTime { get; set; }

    public int GifDesignAvgTime { get; set; }

    public int StandDesignAvgTime { get; set; }

    public int BannerDesignQty { get; set; }

    public int BrochureDesignQty { get; set; }

    public int StoryDesignQty { get; set; }

    public int GifDesignQty { get; set; }

    public int StandDesigQty { get; set; }

    public int MotionQty { get; set; }

    public int ArchivedmotionQty { get; set; }

    public int AppliedMotionAvgTime { get; set; }

    public int RecordedvideoQty { get; set; }

    public int RecordedQty { get; set; }

    public int NarrationEditQty { get; set; }

    public int VideoArchiveQty { get; set; }

    public int VideoProduceAvgTime { get; set; }
}
