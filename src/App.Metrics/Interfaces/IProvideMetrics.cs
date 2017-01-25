﻿// Copyright (c) Allan Hardy. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using App.Metrics.Apdex;
using App.Metrics.Apdex.Interfaces;
using App.Metrics.Counter;
using App.Metrics.Counter.Interfaces;
using App.Metrics.Gauge.Interfaces;
using App.Metrics.Histogram;
using App.Metrics.Histogram.Interfaces;
using App.Metrics.Meter;
using App.Metrics.Meter.Interfaces;
using App.Metrics.Registry.Interfaces;
using App.Metrics.Timer;
using App.Metrics.Timer.Interfaces;

namespace App.Metrics.Interfaces
{
    /// <summary>
    ///     Provides access to APIs which get or add metrics to the <see cref="IMetricsRegistry" /> and return the instance.
    /// </summary>
    public interface IProvideMetrics
    {
        /// <summary>
        ///     Gets the Apdex API to register and retrieve <see cref="IApdexMetric" />s to be measured.
        /// </summary>
        /// <value>
        ///     The Apdex API for registering and retrieving <see cref="IApdexMetric" />s to be measured
        /// </value>
        IProvideApdexMetrics Apdex { get; }

        /// <summary>
        ///     Gets the Counter API to register and retrieve <see cref="ICounterMetric" />s to be measured.
        /// </summary>
        /// <value>
        ///     The Counter API for registering and retrieving <see cref="ICounterMetric" />s to be measured
        /// </value>
        IProvideCounterMetrics Counter { get; }

        /// <summary>
        ///     Gets the Gauge API to register and retrieve <see cref="IGaugeMetric" />s to be measured.
        /// </summary>
        /// <value>
        ///     The Gauge API for registering and retrieving <see cref="IGaugeMetric" />s to be measured
        /// </value>
        IProvideGaugeMetrics Gauge { get; }

        /// <summary>
        ///     Gets the Histogram API to register and retrieve <see cref="IHistogramMetric" />s to be measured.
        /// </summary>
        /// <value>
        ///     The Histogram API for registering and retrieving <see cref="IHistogramMetric" />s to be measured
        /// </value>
        IProvideHistogramMetrics Histogram { get; }

        /// <summary>
        ///     Gets the Meter API to register and retrieve <see cref="IMeterMetric" />s to be measured.
        /// </summary>
        /// <value>
        ///     The Meter API for registering and retrieving <see cref="IMeterMetric" />s to be measured
        /// </value>
        IProvideMeterMetrics Meter { get; }

        /// <summary>
        ///     Gets the Timer API to register and retrieve <see cref="ITimerMetric" />s to be measured.
        /// </summary>
        /// <value>
        ///     The Timer API for registering and retrieving <see cref="ITimerMetric" />s to be measured
        /// </value>
        IProvideTimerMetrics Timer { get; }
    }
}