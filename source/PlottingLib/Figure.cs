﻿using System;
using System.Threading.Tasks;
using PlottingLib.Options;

namespace PlottingLib
{
    /// <summary>
    ///     The main object to create a new figure.
    /// </summary>
    public class Figure
    {
        /// <summary>
        ///     Action to perform once the plot was created.
        ///     Use this method to export the plot as image file.
        /// </summary>
        public Func<string, Task> ExportAction { get; set; }

        /// <summary>
        /// Exports the image to the specified file.
        /// </summary>
        /// <param name="fullPath">Full path to the file.</param>
        public Task ExportAsync(string fullPath)
        {
            return this.ExportAction?.Invoke(fullPath);
        }

        /// <summary>
        ///     Options for a single plot.
        /// </summary>
        public PlotOptions PlotOptions { get; } = new PlotOptions();

        /// <summary>
        ///     Options for the figure to be created.
        /// </summary>
        public FigureOptions FigureOptions { get; } = new FigureOptions();

        /// <summary>
        ///     xData for the plot.
        /// </summary>
        public double[] XData { get; }

        /// <summary>
        ///     yData for the plot.
        /// </summary>
        public double[] YData { get; }

        /// <summary>
        ///     Creates a new instance of the <see cref="Figure" />
        /// </summary>
        /// <param name="xData">xData to use for the plot.</param>
        /// <param name="yData">yData to use for the plot.</param>
        public Figure(double[] xData, double[] yData)
        {
            this.XData = xData;
            this.YData = yData;
        }

        /// <summary>
        ///     Creates a new instance of the <see cref="Figure" />
        /// </summary>
        /// <param name="xData">xData to use for the plot.</param>
        /// <param name="yData">yData to use for the plot.</param>
        /// <param name="options">Plot options to use.</param>
        public Figure(double[] xData, double[] yData, FigureOptions options) : this(xData, yData)
        {
            this.FigureOptions = options;
        }
    }
}