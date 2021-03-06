// This file was generated automatically by GenerateFromSchema.  Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer

using CesiumLanguageWriter.Advanced;
using System;
using System.Drawing;
using System.Collections.Generic;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>Billboard</c> to a <see cref="CesiumOutputStream" />.  A <c>Billboard</c> is a billboard, or viewport-aligned image.  The billboard is positioned in the scene by the <c>position</c> property.  A billboard is sometimes called a marker.
    /// </summary>
    public class BillboardCesiumWriter : CesiumPropertyWriter<BillboardCesiumWriter>
    {
        /// <summary>
        /// The name of the <c>show</c> property.
        /// </summary>
        public const string ShowPropertyName = "show";

        /// <summary>
        /// The name of the <c>image</c> property.
        /// </summary>
        public const string ImagePropertyName = "image";

        /// <summary>
        /// The name of the <c>scale</c> property.
        /// </summary>
        public const string ScalePropertyName = "scale";

        /// <summary>
        /// The name of the <c>pixelOffset</c> property.
        /// </summary>
        public const string PixelOffsetPropertyName = "pixelOffset";

        /// <summary>
        /// The name of the <c>eyeOffset</c> property.
        /// </summary>
        public const string EyeOffsetPropertyName = "eyeOffset";

        /// <summary>
        /// The name of the <c>horizontalOrigin</c> property.
        /// </summary>
        public const string HorizontalOriginPropertyName = "horizontalOrigin";

        /// <summary>
        /// The name of the <c>verticalOrigin</c> property.
        /// </summary>
        public const string VerticalOriginPropertyName = "verticalOrigin";

        /// <summary>
        /// The name of the <c>heightReference</c> property.
        /// </summary>
        public const string HeightReferencePropertyName = "heightReference";

        /// <summary>
        /// The name of the <c>color</c> property.
        /// </summary>
        public const string ColorPropertyName = "color";

        /// <summary>
        /// The name of the <c>rotation</c> property.
        /// </summary>
        public const string RotationPropertyName = "rotation";

        /// <summary>
        /// The name of the <c>alignedAxis</c> property.
        /// </summary>
        public const string AlignedAxisPropertyName = "alignedAxis";

        /// <summary>
        /// The name of the <c>sizeInMeters</c> property.
        /// </summary>
        public const string SizeInMetersPropertyName = "sizeInMeters";

        /// <summary>
        /// The name of the <c>width</c> property.
        /// </summary>
        public const string WidthPropertyName = "width";

        /// <summary>
        /// The name of the <c>height</c> property.
        /// </summary>
        public const string HeightPropertyName = "height";

        /// <summary>
        /// The name of the <c>scaleByDistance</c> property.
        /// </summary>
        public const string ScaleByDistancePropertyName = "scaleByDistance";

        /// <summary>
        /// The name of the <c>translucencyByDistance</c> property.
        /// </summary>
        public const string TranslucencyByDistancePropertyName = "translucencyByDistance";

        /// <summary>
        /// The name of the <c>pixelOffsetScaleByDistance</c> property.
        /// </summary>
        public const string PixelOffsetScaleByDistancePropertyName = "pixelOffsetScaleByDistance";

        /// <summary>
        /// The name of the <c>imageSubRegion</c> property.
        /// </summary>
        public const string ImageSubRegionPropertyName = "imageSubRegion";

        private readonly Lazy<BooleanCesiumWriter> m_show = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(ShowPropertyName), false);
        private readonly Lazy<UriCesiumWriter> m_image = new Lazy<UriCesiumWriter>(() => new UriCesiumWriter(ImagePropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_scale = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(ScalePropertyName), false);
        private readonly Lazy<PixelOffsetCesiumWriter> m_pixelOffset = new Lazy<PixelOffsetCesiumWriter>(() => new PixelOffsetCesiumWriter(PixelOffsetPropertyName), false);
        private readonly Lazy<EyeOffsetCesiumWriter> m_eyeOffset = new Lazy<EyeOffsetCesiumWriter>(() => new EyeOffsetCesiumWriter(EyeOffsetPropertyName), false);
        private readonly Lazy<HorizontalOriginCesiumWriter> m_horizontalOrigin = new Lazy<HorizontalOriginCesiumWriter>(() => new HorizontalOriginCesiumWriter(HorizontalOriginPropertyName), false);
        private readonly Lazy<VerticalOriginCesiumWriter> m_verticalOrigin = new Lazy<VerticalOriginCesiumWriter>(() => new VerticalOriginCesiumWriter(VerticalOriginPropertyName), false);
        private readonly Lazy<HeightReferenceCesiumWriter> m_heightReference = new Lazy<HeightReferenceCesiumWriter>(() => new HeightReferenceCesiumWriter(HeightReferencePropertyName), false);
        private readonly Lazy<ColorCesiumWriter> m_color = new Lazy<ColorCesiumWriter>(() => new ColorCesiumWriter(ColorPropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_rotation = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(RotationPropertyName), false);
        private readonly Lazy<AlignedAxisCesiumWriter> m_alignedAxis = new Lazy<AlignedAxisCesiumWriter>(() => new AlignedAxisCesiumWriter(AlignedAxisPropertyName), false);
        private readonly Lazy<BooleanCesiumWriter> m_sizeInMeters = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(SizeInMetersPropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_width = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(WidthPropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_height = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(HeightPropertyName), false);
        private readonly Lazy<NearFarScalarCesiumWriter> m_scaleByDistance = new Lazy<NearFarScalarCesiumWriter>(() => new NearFarScalarCesiumWriter(ScaleByDistancePropertyName), false);
        private readonly Lazy<NearFarScalarCesiumWriter> m_translucencyByDistance = new Lazy<NearFarScalarCesiumWriter>(() => new NearFarScalarCesiumWriter(TranslucencyByDistancePropertyName), false);
        private readonly Lazy<NearFarScalarCesiumWriter> m_pixelOffsetScaleByDistance = new Lazy<NearFarScalarCesiumWriter>(() => new NearFarScalarCesiumWriter(PixelOffsetScaleByDistancePropertyName), false);
        private readonly Lazy<BoundingRectangleCesiumWriter> m_imageSubRegion = new Lazy<BoundingRectangleCesiumWriter>(() => new BoundingRectangleCesiumWriter(ImageSubRegionPropertyName), false);

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public BillboardCesiumWriter(string propertyName)
            : base(propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected BillboardCesiumWriter(BillboardCesiumWriter existingInstance)
            : base(existingInstance)
        {
        }

        /// <inheritdoc />
        public override BillboardCesiumWriter Clone()
        {
            return new BillboardCesiumWriter(this);
        }

        /// <summary>
        /// Gets the writer for the <c>show</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>show</c> property defines whether or not the billboard is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        public BooleanCesiumWriter ShowWriter
        {
            get { return m_show.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>show</c> property.  The <c>show</c> property defines whether or not the billboard is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        public BooleanCesiumWriter OpenShowProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ShowWriter);
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>boolean</c> value.  The <c>show</c> property specifies whether or not the billboard is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteShowProperty(bool value)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the billboard is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteShowPropertyReference(Reference value)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the billboard is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteShowPropertyReference(string value)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the billboard is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteShowPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the billboard is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteShowPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>image</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>image</c> property defines the URI of the image displayed on the billboard.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        public UriCesiumWriter ImageWriter
        {
            get { return m_image.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>image</c> property.  The <c>image</c> property defines the URI of the image displayed on the billboard.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        public UriCesiumWriter OpenImageProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ImageWriter);
        }

        /// <summary>
        /// Writes a value for the <c>image</c> property as a <c>uri</c> value.  The <c>image</c> property specifies the URI of the image displayed on the billboard.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        /// <param name="resource">A resource object describing external data.</param>
        public void WriteImageProperty(CesiumResource resource)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteUri(resource);
            }
        }

        /// <summary>
        /// Writes a value for the <c>image</c> property as a <c>uri</c> value.  The <c>image</c> property specifies the URI of the image displayed on the billboard.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        /// <param name="uri">The URI of the data.</param>
        /// <param name="resourceBehavior">An enumeration describing how to include the URI in the document. For even more control, use the overload that takes a ICesiumUriResolver.</param>
        public void WriteImageProperty(Uri uri, CesiumResourceBehavior resourceBehavior)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteUri(uri, resourceBehavior);
            }
        }

        /// <summary>
        /// Writes a value for the <c>image</c> property as a <c>uri</c> value.  The <c>image</c> property specifies the URI of the image displayed on the billboard.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        /// <param name="uri">The URI of the data.</param>
        /// <param name="resourceBehavior">An enumeration describing how to include the URI in the document. For even more control, use the overload that takes a ICesiumUriResolver.</param>
        public void WriteImageProperty(string uri, CesiumResourceBehavior resourceBehavior)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteUri(uri, resourceBehavior);
            }
        }

        /// <summary>
        /// Writes a value for the <c>image</c> property as a <c>uri</c> value.  The <c>image</c> property specifies the URI of the image displayed on the billboard.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        /// <param name="uri">The URI of the data.  The provided ICesiumUriResolver will be used to build the final URI embedded in the document.</param>
        /// <param name="resolver">An ICesiumUriResolver used to build the final URI that will be embedded in the document.</param>
        public void WriteImageProperty(Uri uri, ICesiumUriResolver resolver)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteUri(uri, resolver);
            }
        }

        /// <summary>
        /// Writes a value for the <c>image</c> property as a <c>uri</c> value.  The <c>image</c> property specifies the URI of the image displayed on the billboard.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        /// <param name="uri">The URI of the data.  The provided ICesiumUriResolver will be used to build the final URI embedded in the document.</param>
        /// <param name="resolver">An ICesiumUriResolver used to build the final URI that will be embedded in the document.</param>
        public void WriteImageProperty(string uri, ICesiumUriResolver resolver)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteUri(uri, resolver);
            }
        }

        /// <summary>
        /// Writes a value for the <c>image</c> property as a <c>uri</c> value.  The <c>image</c> property specifies the URI of the image displayed on the billboard.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        /// <param name="image">The image.  A data URI will be created for this image, using PNG encoding.</param>
        public void WriteImageProperty(Image image)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteUri(image);
            }
        }

        /// <summary>
        /// Writes a value for the <c>image</c> property as a <c>uri</c> value.  The <c>image</c> property specifies the URI of the image displayed on the billboard.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        /// <param name="image">The image.  A data URI will be created for this image.</param>
        /// <param name="imageFormat">The image format to use to encode the image in the data URI.</param>
        public void WriteImageProperty(Image image, CesiumImageFormat imageFormat)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteUri(image, imageFormat);
            }
        }

        /// <summary>
        /// Writes a value for the <c>image</c> property as a <c>reference</c> value.  The <c>image</c> property specifies the URI of the image displayed on the billboard.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteImagePropertyReference(Reference value)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>image</c> property as a <c>reference</c> value.  The <c>image</c> property specifies the URI of the image displayed on the billboard.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteImagePropertyReference(string value)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>image</c> property as a <c>reference</c> value.  The <c>image</c> property specifies the URI of the image displayed on the billboard.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteImagePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>image</c> property as a <c>reference</c> value.  The <c>image</c> property specifies the URI of the image displayed on the billboard.  For broadest client compatibility, the URI should be accessible via Cross-Origin Resource Sharing (CORS).  The URI may also be a <a href="https://developer.mozilla.org/en/data_URIs">data URI</a>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteImagePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenImageProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>scale</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>scale</c> property defines the scale of the billboard.  The scale is multiplied with the pixel size of the billboard's <c>image</c>.  For example, if the scale is 2.0, the billboard will be rendered with twice the number of pixels, in each direction, of the <c>image</c>.  If not specified, the default value is 1.0.
        /// </summary>
        public DoubleCesiumWriter ScaleWriter
        {
            get { return m_scale.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>scale</c> property.  The <c>scale</c> property defines the scale of the billboard.  The scale is multiplied with the pixel size of the billboard's <c>image</c>.  For example, if the scale is 2.0, the billboard will be rendered with twice the number of pixels, in each direction, of the <c>image</c>.  If not specified, the default value is 1.0.
        /// </summary>
        public DoubleCesiumWriter OpenScaleProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ScaleWriter);
        }

        /// <summary>
        /// Writes a value for the <c>scale</c> property as a <c>number</c> value.  The <c>scale</c> property specifies the scale of the billboard.  The scale is multiplied with the pixel size of the billboard's <c>image</c>.  For example, if the scale is 2.0, the billboard will be rendered with twice the number of pixels, in each direction, of the <c>image</c>.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteScaleProperty(double value)
        {
            using (var writer = OpenScaleProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scale</c> property as a <c>number</c> value.  The <c>scale</c> property specifies the scale of the billboard.  The scale is multiplied with the pixel size of the billboard's <c>image</c>.  For example, if the scale is 2.0, the billboard will be rendered with twice the number of pixels, in each direction, of the <c>image</c>.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteScaleProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenScaleProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scale</c> property as a <c>number</c> value.  The <c>scale</c> property specifies the scale of the billboard.  The scale is multiplied with the pixel size of the billboard's <c>image</c>.  For example, if the scale is 2.0, the billboard will be rendered with twice the number of pixels, in each direction, of the <c>image</c>.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteScaleProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenScaleProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scale</c> property as a <c>reference</c> value.  The <c>scale</c> property specifies the scale of the billboard.  The scale is multiplied with the pixel size of the billboard's <c>image</c>.  For example, if the scale is 2.0, the billboard will be rendered with twice the number of pixels, in each direction, of the <c>image</c>.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteScalePropertyReference(Reference value)
        {
            using (var writer = OpenScaleProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scale</c> property as a <c>reference</c> value.  The <c>scale</c> property specifies the scale of the billboard.  The scale is multiplied with the pixel size of the billboard's <c>image</c>.  For example, if the scale is 2.0, the billboard will be rendered with twice the number of pixels, in each direction, of the <c>image</c>.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteScalePropertyReference(string value)
        {
            using (var writer = OpenScaleProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scale</c> property as a <c>reference</c> value.  The <c>scale</c> property specifies the scale of the billboard.  The scale is multiplied with the pixel size of the billboard's <c>image</c>.  For example, if the scale is 2.0, the billboard will be rendered with twice the number of pixels, in each direction, of the <c>image</c>.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteScalePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenScaleProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scale</c> property as a <c>reference</c> value.  The <c>scale</c> property specifies the scale of the billboard.  The scale is multiplied with the pixel size of the billboard's <c>image</c>.  For example, if the scale is 2.0, the billboard will be rendered with twice the number of pixels, in each direction, of the <c>image</c>.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteScalePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenScaleProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>pixelOffset</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>pixelOffset</c> property defines the offset, in viewport pixels, of the billboard origin from the <c>position</c>.  A pixel offset is the number of pixels up and to the right to place the billboard, relative to the <c>position</c>.
        /// </summary>
        public PixelOffsetCesiumWriter PixelOffsetWriter
        {
            get { return m_pixelOffset.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>pixelOffset</c> property.  The <c>pixelOffset</c> property defines the offset, in viewport pixels, of the billboard origin from the <c>position</c>.  A pixel offset is the number of pixels up and to the right to place the billboard, relative to the <c>position</c>.
        /// </summary>
        public PixelOffsetCesiumWriter OpenPixelOffsetProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(PixelOffsetWriter);
        }

        /// <summary>
        /// Writes a value for the <c>pixelOffset</c> property as a <c>cartesian2</c> value.  The <c>pixelOffset</c> property specifies the offset, in viewport pixels, of the billboard origin from the <c>position</c>.  A pixel offset is the number of pixels up and to the right to place the billboard, relative to the <c>position</c>.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WritePixelOffsetProperty(Rectangular value)
        {
            using (var writer = OpenPixelOffsetProperty())
            {
                writer.WriteCartesian2(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>pixelOffset</c> property as a <c>cartesian2</c> value.  The <c>pixelOffset</c> property specifies the offset, in viewport pixels, of the billboard origin from the <c>position</c>.  A pixel offset is the number of pixels up and to the right to place the billboard, relative to the <c>position</c>.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        public void WritePixelOffsetProperty(double x, double y)
        {
            using (var writer = OpenPixelOffsetProperty())
            {
                writer.WriteCartesian2(x, y);
            }
        }

        /// <summary>
        /// Writes a value for the <c>pixelOffset</c> property as a <c>cartesian2</c> value.  The <c>pixelOffset</c> property specifies the offset, in viewport pixels, of the billboard origin from the <c>position</c>.  A pixel offset is the number of pixels up and to the right to place the billboard, relative to the <c>position</c>.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WritePixelOffsetProperty(IList<JulianDate> dates, IList<Rectangular> values)
        {
            using (var writer = OpenPixelOffsetProperty())
            {
                writer.WriteCartesian2(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>pixelOffset</c> property as a <c>cartesian2</c> value.  The <c>pixelOffset</c> property specifies the offset, in viewport pixels, of the billboard origin from the <c>position</c>.  A pixel offset is the number of pixels up and to the right to place the billboard, relative to the <c>position</c>.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WritePixelOffsetProperty(IList<JulianDate> dates, IList<Rectangular> values, int startIndex, int length)
        {
            using (var writer = OpenPixelOffsetProperty())
            {
                writer.WriteCartesian2(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>pixelOffset</c> property as a <c>reference</c> value.  The <c>pixelOffset</c> property specifies the offset, in viewport pixels, of the billboard origin from the <c>position</c>.  A pixel offset is the number of pixels up and to the right to place the billboard, relative to the <c>position</c>.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WritePixelOffsetPropertyReference(Reference value)
        {
            using (var writer = OpenPixelOffsetProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>pixelOffset</c> property as a <c>reference</c> value.  The <c>pixelOffset</c> property specifies the offset, in viewport pixels, of the billboard origin from the <c>position</c>.  A pixel offset is the number of pixels up and to the right to place the billboard, relative to the <c>position</c>.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WritePixelOffsetPropertyReference(string value)
        {
            using (var writer = OpenPixelOffsetProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>pixelOffset</c> property as a <c>reference</c> value.  The <c>pixelOffset</c> property specifies the offset, in viewport pixels, of the billboard origin from the <c>position</c>.  A pixel offset is the number of pixels up and to the right to place the billboard, relative to the <c>position</c>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WritePixelOffsetPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenPixelOffsetProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>pixelOffset</c> property as a <c>reference</c> value.  The <c>pixelOffset</c> property specifies the offset, in viewport pixels, of the billboard origin from the <c>position</c>.  A pixel offset is the number of pixels up and to the right to place the billboard, relative to the <c>position</c>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WritePixelOffsetPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenPixelOffsetProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>eyeOffset</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>eyeOffset</c> property defines the eye offset of the billboard, which is the offset in eye coordinates at which to place the billboard relative to the <c>position</c> property.  Eye coordinates are a left-handed coordinate system where the X-axis points toward the viewer's right, the Y-axis points up, and the Z-axis points into the screen.
        /// </summary>
        public EyeOffsetCesiumWriter EyeOffsetWriter
        {
            get { return m_eyeOffset.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>eyeOffset</c> property.  The <c>eyeOffset</c> property defines the eye offset of the billboard, which is the offset in eye coordinates at which to place the billboard relative to the <c>position</c> property.  Eye coordinates are a left-handed coordinate system where the X-axis points toward the viewer's right, the Y-axis points up, and the Z-axis points into the screen.
        /// </summary>
        public EyeOffsetCesiumWriter OpenEyeOffsetProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(EyeOffsetWriter);
        }

        /// <summary>
        /// Writes a value for the <c>eyeOffset</c> property as a <c>cartesian</c> value.  The <c>eyeOffset</c> property specifies the eye offset of the billboard, which is the offset in eye coordinates at which to place the billboard relative to the <c>position</c> property.  Eye coordinates are a left-handed coordinate system where the X-axis points toward the viewer's right, the Y-axis points up, and the Z-axis points into the screen.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteEyeOffsetProperty(Cartesian value)
        {
            using (var writer = OpenEyeOffsetProperty())
            {
                writer.WriteCartesian(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>eyeOffset</c> property as a <c>cartesian</c> value.  The <c>eyeOffset</c> property specifies the eye offset of the billboard, which is the offset in eye coordinates at which to place the billboard relative to the <c>position</c> property.  Eye coordinates are a left-handed coordinate system where the X-axis points toward the viewer's right, the Y-axis points up, and the Z-axis points into the screen.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteEyeOffsetProperty(IList<JulianDate> dates, IList<Cartesian> values)
        {
            using (var writer = OpenEyeOffsetProperty())
            {
                writer.WriteCartesian(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>eyeOffset</c> property as a <c>cartesian</c> value.  The <c>eyeOffset</c> property specifies the eye offset of the billboard, which is the offset in eye coordinates at which to place the billboard relative to the <c>position</c> property.  Eye coordinates are a left-handed coordinate system where the X-axis points toward the viewer's right, the Y-axis points up, and the Z-axis points into the screen.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteEyeOffsetProperty(IList<JulianDate> dates, IList<Cartesian> values, int startIndex, int length)
        {
            using (var writer = OpenEyeOffsetProperty())
            {
                writer.WriteCartesian(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>eyeOffset</c> property as a <c>reference</c> value.  The <c>eyeOffset</c> property specifies the eye offset of the billboard, which is the offset in eye coordinates at which to place the billboard relative to the <c>position</c> property.  Eye coordinates are a left-handed coordinate system where the X-axis points toward the viewer's right, the Y-axis points up, and the Z-axis points into the screen.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteEyeOffsetPropertyReference(Reference value)
        {
            using (var writer = OpenEyeOffsetProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>eyeOffset</c> property as a <c>reference</c> value.  The <c>eyeOffset</c> property specifies the eye offset of the billboard, which is the offset in eye coordinates at which to place the billboard relative to the <c>position</c> property.  Eye coordinates are a left-handed coordinate system where the X-axis points toward the viewer's right, the Y-axis points up, and the Z-axis points into the screen.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteEyeOffsetPropertyReference(string value)
        {
            using (var writer = OpenEyeOffsetProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>eyeOffset</c> property as a <c>reference</c> value.  The <c>eyeOffset</c> property specifies the eye offset of the billboard, which is the offset in eye coordinates at which to place the billboard relative to the <c>position</c> property.  Eye coordinates are a left-handed coordinate system where the X-axis points toward the viewer's right, the Y-axis points up, and the Z-axis points into the screen.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteEyeOffsetPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenEyeOffsetProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>eyeOffset</c> property as a <c>reference</c> value.  The <c>eyeOffset</c> property specifies the eye offset of the billboard, which is the offset in eye coordinates at which to place the billboard relative to the <c>position</c> property.  Eye coordinates are a left-handed coordinate system where the X-axis points toward the viewer's right, the Y-axis points up, and the Z-axis points into the screen.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteEyeOffsetPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenEyeOffsetProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>horizontalOrigin</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>horizontalOrigin</c> property defines the horizontal origin of the billboard, which determines whether the billboard image is left-, center-, or right-aligned with the <c>position</c>.  If not specified, the default value is CENTER.
        /// </summary>
        public HorizontalOriginCesiumWriter HorizontalOriginWriter
        {
            get { return m_horizontalOrigin.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>horizontalOrigin</c> property.  The <c>horizontalOrigin</c> property defines the horizontal origin of the billboard, which determines whether the billboard image is left-, center-, or right-aligned with the <c>position</c>.  If not specified, the default value is CENTER.
        /// </summary>
        public HorizontalOriginCesiumWriter OpenHorizontalOriginProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(HorizontalOriginWriter);
        }

        /// <summary>
        /// Writes a value for the <c>horizontalOrigin</c> property as a <c>horizontalOrigin</c> value.  The <c>horizontalOrigin</c> property specifies the horizontal origin of the billboard, which determines whether the billboard image is left-, center-, or right-aligned with the <c>position</c>.  If not specified, the default value is CENTER.
        /// </summary>
        /// <param name="value">The horizontal origin.</param>
        public void WriteHorizontalOriginProperty(CesiumHorizontalOrigin value)
        {
            using (var writer = OpenHorizontalOriginProperty())
            {
                writer.WriteHorizontalOrigin(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>horizontalOrigin</c> property as a <c>reference</c> value.  The <c>horizontalOrigin</c> property specifies the horizontal origin of the billboard, which determines whether the billboard image is left-, center-, or right-aligned with the <c>position</c>.  If not specified, the default value is CENTER.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteHorizontalOriginPropertyReference(Reference value)
        {
            using (var writer = OpenHorizontalOriginProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>horizontalOrigin</c> property as a <c>reference</c> value.  The <c>horizontalOrigin</c> property specifies the horizontal origin of the billboard, which determines whether the billboard image is left-, center-, or right-aligned with the <c>position</c>.  If not specified, the default value is CENTER.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteHorizontalOriginPropertyReference(string value)
        {
            using (var writer = OpenHorizontalOriginProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>horizontalOrigin</c> property as a <c>reference</c> value.  The <c>horizontalOrigin</c> property specifies the horizontal origin of the billboard, which determines whether the billboard image is left-, center-, or right-aligned with the <c>position</c>.  If not specified, the default value is CENTER.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteHorizontalOriginPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenHorizontalOriginProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>horizontalOrigin</c> property as a <c>reference</c> value.  The <c>horizontalOrigin</c> property specifies the horizontal origin of the billboard, which determines whether the billboard image is left-, center-, or right-aligned with the <c>position</c>.  If not specified, the default value is CENTER.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteHorizontalOriginPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenHorizontalOriginProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>verticalOrigin</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>verticalOrigin</c> property defines the vertical origin of the billboard, which determines whether the billboard image is bottom-, center-, or top-aligned with the <c>position</c>.  If not specified, the default value is CENTER.
        /// </summary>
        public VerticalOriginCesiumWriter VerticalOriginWriter
        {
            get { return m_verticalOrigin.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>verticalOrigin</c> property.  The <c>verticalOrigin</c> property defines the vertical origin of the billboard, which determines whether the billboard image is bottom-, center-, or top-aligned with the <c>position</c>.  If not specified, the default value is CENTER.
        /// </summary>
        public VerticalOriginCesiumWriter OpenVerticalOriginProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(VerticalOriginWriter);
        }

        /// <summary>
        /// Writes a value for the <c>verticalOrigin</c> property as a <c>verticalOrigin</c> value.  The <c>verticalOrigin</c> property specifies the vertical origin of the billboard, which determines whether the billboard image is bottom-, center-, or top-aligned with the <c>position</c>.  If not specified, the default value is CENTER.
        /// </summary>
        /// <param name="value">The vertical origin.</param>
        public void WriteVerticalOriginProperty(CesiumVerticalOrigin value)
        {
            using (var writer = OpenVerticalOriginProperty())
            {
                writer.WriteVerticalOrigin(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>verticalOrigin</c> property as a <c>reference</c> value.  The <c>verticalOrigin</c> property specifies the vertical origin of the billboard, which determines whether the billboard image is bottom-, center-, or top-aligned with the <c>position</c>.  If not specified, the default value is CENTER.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteVerticalOriginPropertyReference(Reference value)
        {
            using (var writer = OpenVerticalOriginProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>verticalOrigin</c> property as a <c>reference</c> value.  The <c>verticalOrigin</c> property specifies the vertical origin of the billboard, which determines whether the billboard image is bottom-, center-, or top-aligned with the <c>position</c>.  If not specified, the default value is CENTER.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteVerticalOriginPropertyReference(string value)
        {
            using (var writer = OpenVerticalOriginProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>verticalOrigin</c> property as a <c>reference</c> value.  The <c>verticalOrigin</c> property specifies the vertical origin of the billboard, which determines whether the billboard image is bottom-, center-, or top-aligned with the <c>position</c>.  If not specified, the default value is CENTER.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteVerticalOriginPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenVerticalOriginProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>verticalOrigin</c> property as a <c>reference</c> value.  The <c>verticalOrigin</c> property specifies the vertical origin of the billboard, which determines whether the billboard image is bottom-, center-, or top-aligned with the <c>position</c>.  If not specified, the default value is CENTER.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteVerticalOriginPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenVerticalOriginProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>heightReference</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>heightReference</c> property defines the height reference of the billboard, which indicates if the position is relative to terrain or not.  If not specified, the default value is NONE.
        /// </summary>
        public HeightReferenceCesiumWriter HeightReferenceWriter
        {
            get { return m_heightReference.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>heightReference</c> property.  The <c>heightReference</c> property defines the height reference of the billboard, which indicates if the position is relative to terrain or not.  If not specified, the default value is NONE.
        /// </summary>
        public HeightReferenceCesiumWriter OpenHeightReferenceProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(HeightReferenceWriter);
        }

        /// <summary>
        /// Writes a value for the <c>heightReference</c> property as a <c>heightReference</c> value.  The <c>heightReference</c> property specifies the height reference of the billboard, which indicates if the position is relative to terrain or not.  If not specified, the default value is NONE.
        /// </summary>
        /// <param name="value">The height reference.</param>
        public void WriteHeightReferenceProperty(CesiumHeightReference value)
        {
            using (var writer = OpenHeightReferenceProperty())
            {
                writer.WriteHeightReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>heightReference</c> property as a <c>reference</c> value.  The <c>heightReference</c> property specifies the height reference of the billboard, which indicates if the position is relative to terrain or not.  If not specified, the default value is NONE.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteHeightReferencePropertyReference(Reference value)
        {
            using (var writer = OpenHeightReferenceProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>heightReference</c> property as a <c>reference</c> value.  The <c>heightReference</c> property specifies the height reference of the billboard, which indicates if the position is relative to terrain or not.  If not specified, the default value is NONE.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteHeightReferencePropertyReference(string value)
        {
            using (var writer = OpenHeightReferenceProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>heightReference</c> property as a <c>reference</c> value.  The <c>heightReference</c> property specifies the height reference of the billboard, which indicates if the position is relative to terrain or not.  If not specified, the default value is NONE.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteHeightReferencePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenHeightReferenceProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>heightReference</c> property as a <c>reference</c> value.  The <c>heightReference</c> property specifies the height reference of the billboard, which indicates if the position is relative to terrain or not.  If not specified, the default value is NONE.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteHeightReferencePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenHeightReferenceProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>color</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>color</c> property defines the color of the billboard.  This color value is multiplied with the values of the billboard's "image" to produce the final color.
        /// </summary>
        public ColorCesiumWriter ColorWriter
        {
            get { return m_color.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>color</c> property.  The <c>color</c> property defines the color of the billboard.  This color value is multiplied with the values of the billboard's "image" to produce the final color.
        /// </summary>
        public ColorCesiumWriter OpenColorProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ColorWriter);
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value.  The <c>color</c> property specifies the color of the billboard.  This color value is multiplied with the values of the billboard's "image" to produce the final color.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteColorProperty(Color color)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value.  The <c>color</c> property specifies the color of the billboard.  This color value is multiplied with the values of the billboard's "image" to produce the final color.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 255.</param>
        /// <param name="green">The green component in the range 0 to 255.</param>
        /// <param name="blue">The blue component in the range 0 to 255.</param>
        /// <param name="alpha">The alpha component in the range 0 to 255.</param>
        public void WriteColorProperty(int red, int green, int blue, int alpha)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value.  The <c>color</c> property specifies the color of the billboard.  This color value is multiplied with the values of the billboard's "image" to produce the final color.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteColorProperty(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value.  The <c>color</c> property specifies the color of the billboard.  This color value is multiplied with the values of the billboard's "image" to produce the final color.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteColorProperty(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value.  The <c>color</c> property specifies the color of the billboard.  This color value is multiplied with the values of the billboard's "image" to produce the final color.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteColorPropertyRgbaf(Color color)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value.  The <c>color</c> property specifies the color of the billboard.  This color value is multiplied with the values of the billboard's "image" to produce the final color.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 1.0.</param>
        /// <param name="green">The green component in the range 0 to 1.0.</param>
        /// <param name="blue">The blue component in the range 0 to 1.0.</param>
        /// <param name="alpha">The alpha component in the range 0 to 1.0.</param>
        public void WriteColorPropertyRgbaf(float red, float green, float blue, float alpha)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value.  The <c>color</c> property specifies the color of the billboard.  This color value is multiplied with the values of the billboard's "image" to produce the final color.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value.  The <c>color</c> property specifies the color of the billboard.  This color value is multiplied with the values of the billboard's "image" to produce the final color.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value.  The <c>color</c> property specifies the color of the billboard.  This color value is multiplied with the values of the billboard's "image" to produce the final color.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteColorPropertyReference(Reference value)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value.  The <c>color</c> property specifies the color of the billboard.  This color value is multiplied with the values of the billboard's "image" to produce the final color.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteColorPropertyReference(string value)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value.  The <c>color</c> property specifies the color of the billboard.  This color value is multiplied with the values of the billboard's "image" to produce the final color.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteColorPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value.  The <c>color</c> property specifies the color of the billboard.  This color value is multiplied with the values of the billboard's "image" to produce the final color.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteColorPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>rotation</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>rotation</c> property defines the rotation of the billboard, in radians, counter-clockwise from the alignedAxis.  If not specified, the default value is 0.0.
        /// </summary>
        public DoubleCesiumWriter RotationWriter
        {
            get { return m_rotation.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>rotation</c> property.  The <c>rotation</c> property defines the rotation of the billboard, in radians, counter-clockwise from the alignedAxis.  If not specified, the default value is 0.0.
        /// </summary>
        public DoubleCesiumWriter OpenRotationProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(RotationWriter);
        }

        /// <summary>
        /// Writes a value for the <c>rotation</c> property as a <c>number</c> value.  The <c>rotation</c> property specifies the rotation of the billboard, in radians, counter-clockwise from the alignedAxis.  If not specified, the default value is 0.0.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteRotationProperty(double value)
        {
            using (var writer = OpenRotationProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>rotation</c> property as a <c>number</c> value.  The <c>rotation</c> property specifies the rotation of the billboard, in radians, counter-clockwise from the alignedAxis.  If not specified, the default value is 0.0.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteRotationProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenRotationProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>rotation</c> property as a <c>number</c> value.  The <c>rotation</c> property specifies the rotation of the billboard, in radians, counter-clockwise from the alignedAxis.  If not specified, the default value is 0.0.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteRotationProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenRotationProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>rotation</c> property as a <c>reference</c> value.  The <c>rotation</c> property specifies the rotation of the billboard, in radians, counter-clockwise from the alignedAxis.  If not specified, the default value is 0.0.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteRotationPropertyReference(Reference value)
        {
            using (var writer = OpenRotationProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>rotation</c> property as a <c>reference</c> value.  The <c>rotation</c> property specifies the rotation of the billboard, in radians, counter-clockwise from the alignedAxis.  If not specified, the default value is 0.0.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteRotationPropertyReference(string value)
        {
            using (var writer = OpenRotationProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>rotation</c> property as a <c>reference</c> value.  The <c>rotation</c> property specifies the rotation of the billboard, in radians, counter-clockwise from the alignedAxis.  If not specified, the default value is 0.0.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteRotationPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenRotationProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>rotation</c> property as a <c>reference</c> value.  The <c>rotation</c> property specifies the rotation of the billboard, in radians, counter-clockwise from the alignedAxis.  If not specified, the default value is 0.0.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteRotationPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenRotationProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>alignedAxis</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>alignedAxis</c> property defines the aligned axis is the unit vector, in world coordinates, that the billboard up vector points towards.  The default is the zero vector, which means the billboard is aligned to the screen up vector.
        /// </summary>
        public AlignedAxisCesiumWriter AlignedAxisWriter
        {
            get { return m_alignedAxis.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>alignedAxis</c> property.  The <c>alignedAxis</c> property defines the aligned axis is the unit vector, in world coordinates, that the billboard up vector points towards.  The default is the zero vector, which means the billboard is aligned to the screen up vector.
        /// </summary>
        public AlignedAxisCesiumWriter OpenAlignedAxisProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(AlignedAxisWriter);
        }

        /// <summary>
        /// Writes a value for the <c>alignedAxis</c> property as a <c>unitCartesian</c> value.  The <c>alignedAxis</c> property specifies the aligned axis is the unit vector, in world coordinates, that the billboard up vector points towards.  The default is the zero vector, which means the billboard is aligned to the screen up vector.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteAlignedAxisProperty(UnitCartesian value)
        {
            using (var writer = OpenAlignedAxisProperty())
            {
                writer.WriteUnitCartesian(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>alignedAxis</c> property as a <c>unitCartesian</c> value.  The <c>alignedAxis</c> property specifies the aligned axis is the unit vector, in world coordinates, that the billboard up vector points towards.  The default is the zero vector, which means the billboard is aligned to the screen up vector.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteAlignedAxisProperty(IList<JulianDate> dates, IList<UnitCartesian> values)
        {
            using (var writer = OpenAlignedAxisProperty())
            {
                writer.WriteUnitCartesian(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>alignedAxis</c> property as a <c>unitCartesian</c> value.  The <c>alignedAxis</c> property specifies the aligned axis is the unit vector, in world coordinates, that the billboard up vector points towards.  The default is the zero vector, which means the billboard is aligned to the screen up vector.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteAlignedAxisProperty(IList<JulianDate> dates, IList<UnitCartesian> values, int startIndex, int length)
        {
            using (var writer = OpenAlignedAxisProperty())
            {
                writer.WriteUnitCartesian(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>alignedAxis</c> property as a <c>unitSpherical</c> value.  The <c>alignedAxis</c> property specifies the aligned axis is the unit vector, in world coordinates, that the billboard up vector points towards.  The default is the zero vector, which means the billboard is aligned to the screen up vector.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteAlignedAxisPropertyUnitSpherical(UnitSpherical value)
        {
            using (var writer = OpenAlignedAxisProperty())
            {
                writer.WriteUnitSpherical(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>alignedAxis</c> property as a <c>unitSpherical</c> value.  The <c>alignedAxis</c> property specifies the aligned axis is the unit vector, in world coordinates, that the billboard up vector points towards.  The default is the zero vector, which means the billboard is aligned to the screen up vector.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteAlignedAxisPropertyUnitSpherical(IList<JulianDate> dates, IList<UnitSpherical> values)
        {
            using (var writer = OpenAlignedAxisProperty())
            {
                writer.WriteUnitSpherical(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>alignedAxis</c> property as a <c>unitSpherical</c> value.  The <c>alignedAxis</c> property specifies the aligned axis is the unit vector, in world coordinates, that the billboard up vector points towards.  The default is the zero vector, which means the billboard is aligned to the screen up vector.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteAlignedAxisPropertyUnitSpherical(IList<JulianDate> dates, IList<UnitSpherical> values, int startIndex, int length)
        {
            using (var writer = OpenAlignedAxisProperty())
            {
                writer.WriteUnitSpherical(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>alignedAxis</c> property as a <c>reference</c> value.  The <c>alignedAxis</c> property specifies the aligned axis is the unit vector, in world coordinates, that the billboard up vector points towards.  The default is the zero vector, which means the billboard is aligned to the screen up vector.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteAlignedAxisPropertyReference(Reference value)
        {
            using (var writer = OpenAlignedAxisProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>alignedAxis</c> property as a <c>reference</c> value.  The <c>alignedAxis</c> property specifies the aligned axis is the unit vector, in world coordinates, that the billboard up vector points towards.  The default is the zero vector, which means the billboard is aligned to the screen up vector.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteAlignedAxisPropertyReference(string value)
        {
            using (var writer = OpenAlignedAxisProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>alignedAxis</c> property as a <c>reference</c> value.  The <c>alignedAxis</c> property specifies the aligned axis is the unit vector, in world coordinates, that the billboard up vector points towards.  The default is the zero vector, which means the billboard is aligned to the screen up vector.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteAlignedAxisPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenAlignedAxisProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>alignedAxis</c> property as a <c>reference</c> value.  The <c>alignedAxis</c> property specifies the aligned axis is the unit vector, in world coordinates, that the billboard up vector points towards.  The default is the zero vector, which means the billboard is aligned to the screen up vector.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteAlignedAxisPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenAlignedAxisProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Writes a value for the <c>alignedAxis</c> property as a <c>velocityReference</c> value.  The <c>alignedAxis</c> property specifies the aligned axis is the unit vector, in world coordinates, that the billboard up vector points towards.  The default is the zero vector, which means the billboard is aligned to the screen up vector.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteAlignedAxisPropertyVelocityReference(Reference value)
        {
            using (var writer = OpenAlignedAxisProperty())
            {
                writer.WriteVelocityReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>alignedAxis</c> property as a <c>velocityReference</c> value.  The <c>alignedAxis</c> property specifies the aligned axis is the unit vector, in world coordinates, that the billboard up vector points towards.  The default is the zero vector, which means the billboard is aligned to the screen up vector.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteAlignedAxisPropertyVelocityReference(string value)
        {
            using (var writer = OpenAlignedAxisProperty())
            {
                writer.WriteVelocityReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>alignedAxis</c> property as a <c>velocityReference</c> value.  The <c>alignedAxis</c> property specifies the aligned axis is the unit vector, in world coordinates, that the billboard up vector points towards.  The default is the zero vector, which means the billboard is aligned to the screen up vector.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteAlignedAxisPropertyVelocityReference(string identifier, string propertyName)
        {
            using (var writer = OpenAlignedAxisProperty())
            {
                writer.WriteVelocityReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>alignedAxis</c> property as a <c>velocityReference</c> value.  The <c>alignedAxis</c> property specifies the aligned axis is the unit vector, in world coordinates, that the billboard up vector points towards.  The default is the zero vector, which means the billboard is aligned to the screen up vector.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteAlignedAxisPropertyVelocityReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenAlignedAxisProperty())
            {
                writer.WriteVelocityReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>sizeInMeters</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>sizeInMeters</c> property defines whether this billboard's size (<c>width</c> and <c>height</c>) should be measured in meters, otherwise size is measured in pixels.  If not specified, the default value is <see langword="false"/>.
        /// </summary>
        public BooleanCesiumWriter SizeInMetersWriter
        {
            get { return m_sizeInMeters.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>sizeInMeters</c> property.  The <c>sizeInMeters</c> property defines whether this billboard's size (<c>width</c> and <c>height</c>) should be measured in meters, otherwise size is measured in pixels.  If not specified, the default value is <see langword="false"/>.
        /// </summary>
        public BooleanCesiumWriter OpenSizeInMetersProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(SizeInMetersWriter);
        }

        /// <summary>
        /// Writes a value for the <c>sizeInMeters</c> property as a <c>boolean</c> value.  The <c>sizeInMeters</c> property specifies whether this billboard's size (<c>width</c> and <c>height</c>) should be measured in meters, otherwise size is measured in pixels.  If not specified, the default value is <see langword="false"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteSizeInMetersProperty(bool value)
        {
            using (var writer = OpenSizeInMetersProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>sizeInMeters</c> property as a <c>reference</c> value.  The <c>sizeInMeters</c> property specifies whether this billboard's size (<c>width</c> and <c>height</c>) should be measured in meters, otherwise size is measured in pixels.  If not specified, the default value is <see langword="false"/>.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteSizeInMetersPropertyReference(Reference value)
        {
            using (var writer = OpenSizeInMetersProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>sizeInMeters</c> property as a <c>reference</c> value.  The <c>sizeInMeters</c> property specifies whether this billboard's size (<c>width</c> and <c>height</c>) should be measured in meters, otherwise size is measured in pixels.  If not specified, the default value is <see langword="false"/>.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteSizeInMetersPropertyReference(string value)
        {
            using (var writer = OpenSizeInMetersProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>sizeInMeters</c> property as a <c>reference</c> value.  The <c>sizeInMeters</c> property specifies whether this billboard's size (<c>width</c> and <c>height</c>) should be measured in meters, otherwise size is measured in pixels.  If not specified, the default value is <see langword="false"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteSizeInMetersPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenSizeInMetersProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>sizeInMeters</c> property as a <c>reference</c> value.  The <c>sizeInMeters</c> property specifies whether this billboard's size (<c>width</c> and <c>height</c>) should be measured in meters, otherwise size is measured in pixels.  If not specified, the default value is <see langword="false"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteSizeInMetersPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenSizeInMetersProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>width</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>width</c> property defines the width of the billboard, in pixels (or meters, if <c>sizeInMeters</c> is true). By default, the native width of the image is used.
        /// </summary>
        public DoubleCesiumWriter WidthWriter
        {
            get { return m_width.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>width</c> property.  The <c>width</c> property defines the width of the billboard, in pixels (or meters, if <c>sizeInMeters</c> is true). By default, the native width of the image is used.
        /// </summary>
        public DoubleCesiumWriter OpenWidthProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(WidthWriter);
        }

        /// <summary>
        /// Writes a value for the <c>width</c> property as a <c>number</c> value.  The <c>width</c> property specifies the width of the billboard, in pixels (or meters, if <c>sizeInMeters</c> is true). By default, the native width of the image is used.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteWidthProperty(double value)
        {
            using (var writer = OpenWidthProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>width</c> property as a <c>number</c> value.  The <c>width</c> property specifies the width of the billboard, in pixels (or meters, if <c>sizeInMeters</c> is true). By default, the native width of the image is used.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteWidthProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenWidthProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>width</c> property as a <c>number</c> value.  The <c>width</c> property specifies the width of the billboard, in pixels (or meters, if <c>sizeInMeters</c> is true). By default, the native width of the image is used.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteWidthProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenWidthProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>width</c> property as a <c>reference</c> value.  The <c>width</c> property specifies the width of the billboard, in pixels (or meters, if <c>sizeInMeters</c> is true). By default, the native width of the image is used.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteWidthPropertyReference(Reference value)
        {
            using (var writer = OpenWidthProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>width</c> property as a <c>reference</c> value.  The <c>width</c> property specifies the width of the billboard, in pixels (or meters, if <c>sizeInMeters</c> is true). By default, the native width of the image is used.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteWidthPropertyReference(string value)
        {
            using (var writer = OpenWidthProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>width</c> property as a <c>reference</c> value.  The <c>width</c> property specifies the width of the billboard, in pixels (or meters, if <c>sizeInMeters</c> is true). By default, the native width of the image is used.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteWidthPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenWidthProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>width</c> property as a <c>reference</c> value.  The <c>width</c> property specifies the width of the billboard, in pixels (or meters, if <c>sizeInMeters</c> is true). By default, the native width of the image is used.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteWidthPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenWidthProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>height</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>height</c> property defines the height of the billboard, in pixels (or meters, if <c>sizeInMeters</c> is true). By default, the native height of the image is used.
        /// </summary>
        public DoubleCesiumWriter HeightWriter
        {
            get { return m_height.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>height</c> property.  The <c>height</c> property defines the height of the billboard, in pixels (or meters, if <c>sizeInMeters</c> is true). By default, the native height of the image is used.
        /// </summary>
        public DoubleCesiumWriter OpenHeightProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(HeightWriter);
        }

        /// <summary>
        /// Writes a value for the <c>height</c> property as a <c>number</c> value.  The <c>height</c> property specifies the height of the billboard, in pixels (or meters, if <c>sizeInMeters</c> is true). By default, the native height of the image is used.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteHeightProperty(double value)
        {
            using (var writer = OpenHeightProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>height</c> property as a <c>number</c> value.  The <c>height</c> property specifies the height of the billboard, in pixels (or meters, if <c>sizeInMeters</c> is true). By default, the native height of the image is used.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteHeightProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenHeightProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>height</c> property as a <c>number</c> value.  The <c>height</c> property specifies the height of the billboard, in pixels (or meters, if <c>sizeInMeters</c> is true). By default, the native height of the image is used.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteHeightProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenHeightProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>height</c> property as a <c>reference</c> value.  The <c>height</c> property specifies the height of the billboard, in pixels (or meters, if <c>sizeInMeters</c> is true). By default, the native height of the image is used.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteHeightPropertyReference(Reference value)
        {
            using (var writer = OpenHeightProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>height</c> property as a <c>reference</c> value.  The <c>height</c> property specifies the height of the billboard, in pixels (or meters, if <c>sizeInMeters</c> is true). By default, the native height of the image is used.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteHeightPropertyReference(string value)
        {
            using (var writer = OpenHeightProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>height</c> property as a <c>reference</c> value.  The <c>height</c> property specifies the height of the billboard, in pixels (or meters, if <c>sizeInMeters</c> is true). By default, the native height of the image is used.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteHeightPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenHeightProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>height</c> property as a <c>reference</c> value.  The <c>height</c> property specifies the height of the billboard, in pixels (or meters, if <c>sizeInMeters</c> is true). By default, the native height of the image is used.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteHeightPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenHeightProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>scaleByDistance</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>scaleByDistance</c> property defines how the billboard's scale should change based on the billboard's distance from the camera.  This scalar value will be multiplied by <c>scale</c>.
        /// </summary>
        public NearFarScalarCesiumWriter ScaleByDistanceWriter
        {
            get { return m_scaleByDistance.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>scaleByDistance</c> property.  The <c>scaleByDistance</c> property defines how the billboard's scale should change based on the billboard's distance from the camera.  This scalar value will be multiplied by <c>scale</c>.
        /// </summary>
        public NearFarScalarCesiumWriter OpenScaleByDistanceProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ScaleByDistanceWriter);
        }

        /// <summary>
        /// Writes a value for the <c>scaleByDistance</c> property as a <c>nearFarScalar</c> value.  The <c>scaleByDistance</c> property specifies how the billboard's scale should change based on the billboard's distance from the camera.  This scalar value will be multiplied by <c>scale</c>.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteScaleByDistanceProperty(NearFarScalar value)
        {
            using (var writer = OpenScaleByDistanceProperty())
            {
                writer.WriteNearFarScalar(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scaleByDistance</c> property as a <c>nearFarScalar</c> value.  The <c>scaleByDistance</c> property specifies how the billboard's scale should change based on the billboard's distance from the camera.  This scalar value will be multiplied by <c>scale</c>.
        /// </summary>
        /// <param name="nearDistance">The lower bound of the camera distance range.</param>
        /// <param name="nearValue">The value to use at the lower bound of the camera distance range.</param>
        /// <param name="farDistance">The upper bound of the camera distance range.</param>
        /// <param name="farValue">The value to use at the upper bound of the camera distance range.</param>
        public void WriteScaleByDistanceProperty(double nearDistance, double nearValue, double farDistance, double farValue)
        {
            using (var writer = OpenScaleByDistanceProperty())
            {
                writer.WriteNearFarScalar(nearDistance, nearValue, farDistance, farValue);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scaleByDistance</c> property as a <c>nearFarScalar</c> value.  The <c>scaleByDistance</c> property specifies how the billboard's scale should change based on the billboard's distance from the camera.  This scalar value will be multiplied by <c>scale</c>.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteScaleByDistanceProperty(IList<JulianDate> dates, IList<NearFarScalar> values)
        {
            using (var writer = OpenScaleByDistanceProperty())
            {
                writer.WriteNearFarScalar(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scaleByDistance</c> property as a <c>nearFarScalar</c> value.  The <c>scaleByDistance</c> property specifies how the billboard's scale should change based on the billboard's distance from the camera.  This scalar value will be multiplied by <c>scale</c>.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteScaleByDistanceProperty(IList<JulianDate> dates, IList<NearFarScalar> values, int startIndex, int length)
        {
            using (var writer = OpenScaleByDistanceProperty())
            {
                writer.WriteNearFarScalar(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scaleByDistance</c> property as a <c>reference</c> value.  The <c>scaleByDistance</c> property specifies how the billboard's scale should change based on the billboard's distance from the camera.  This scalar value will be multiplied by <c>scale</c>.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteScaleByDistancePropertyReference(Reference value)
        {
            using (var writer = OpenScaleByDistanceProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scaleByDistance</c> property as a <c>reference</c> value.  The <c>scaleByDistance</c> property specifies how the billboard's scale should change based on the billboard's distance from the camera.  This scalar value will be multiplied by <c>scale</c>.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteScaleByDistancePropertyReference(string value)
        {
            using (var writer = OpenScaleByDistanceProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scaleByDistance</c> property as a <c>reference</c> value.  The <c>scaleByDistance</c> property specifies how the billboard's scale should change based on the billboard's distance from the camera.  This scalar value will be multiplied by <c>scale</c>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteScaleByDistancePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenScaleByDistanceProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scaleByDistance</c> property as a <c>reference</c> value.  The <c>scaleByDistance</c> property specifies how the billboard's scale should change based on the billboard's distance from the camera.  This scalar value will be multiplied by <c>scale</c>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteScaleByDistancePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenScaleByDistanceProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>translucencyByDistance</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>translucencyByDistance</c> property defines how the billboard's translucency should change based on the billboard's distance from the camera.  This scalar value should range from 0 to 1.
        /// </summary>
        public NearFarScalarCesiumWriter TranslucencyByDistanceWriter
        {
            get { return m_translucencyByDistance.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>translucencyByDistance</c> property.  The <c>translucencyByDistance</c> property defines how the billboard's translucency should change based on the billboard's distance from the camera.  This scalar value should range from 0 to 1.
        /// </summary>
        public NearFarScalarCesiumWriter OpenTranslucencyByDistanceProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(TranslucencyByDistanceWriter);
        }

        /// <summary>
        /// Writes a value for the <c>translucencyByDistance</c> property as a <c>nearFarScalar</c> value.  The <c>translucencyByDistance</c> property specifies how the billboard's translucency should change based on the billboard's distance from the camera.  This scalar value should range from 0 to 1.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteTranslucencyByDistanceProperty(NearFarScalar value)
        {
            using (var writer = OpenTranslucencyByDistanceProperty())
            {
                writer.WriteNearFarScalar(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>translucencyByDistance</c> property as a <c>nearFarScalar</c> value.  The <c>translucencyByDistance</c> property specifies how the billboard's translucency should change based on the billboard's distance from the camera.  This scalar value should range from 0 to 1.
        /// </summary>
        /// <param name="nearDistance">The lower bound of the camera distance range.</param>
        /// <param name="nearValue">The value to use at the lower bound of the camera distance range.</param>
        /// <param name="farDistance">The upper bound of the camera distance range.</param>
        /// <param name="farValue">The value to use at the upper bound of the camera distance range.</param>
        public void WriteTranslucencyByDistanceProperty(double nearDistance, double nearValue, double farDistance, double farValue)
        {
            using (var writer = OpenTranslucencyByDistanceProperty())
            {
                writer.WriteNearFarScalar(nearDistance, nearValue, farDistance, farValue);
            }
        }

        /// <summary>
        /// Writes a value for the <c>translucencyByDistance</c> property as a <c>nearFarScalar</c> value.  The <c>translucencyByDistance</c> property specifies how the billboard's translucency should change based on the billboard's distance from the camera.  This scalar value should range from 0 to 1.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteTranslucencyByDistanceProperty(IList<JulianDate> dates, IList<NearFarScalar> values)
        {
            using (var writer = OpenTranslucencyByDistanceProperty())
            {
                writer.WriteNearFarScalar(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>translucencyByDistance</c> property as a <c>nearFarScalar</c> value.  The <c>translucencyByDistance</c> property specifies how the billboard's translucency should change based on the billboard's distance from the camera.  This scalar value should range from 0 to 1.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteTranslucencyByDistanceProperty(IList<JulianDate> dates, IList<NearFarScalar> values, int startIndex, int length)
        {
            using (var writer = OpenTranslucencyByDistanceProperty())
            {
                writer.WriteNearFarScalar(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>translucencyByDistance</c> property as a <c>reference</c> value.  The <c>translucencyByDistance</c> property specifies how the billboard's translucency should change based on the billboard's distance from the camera.  This scalar value should range from 0 to 1.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteTranslucencyByDistancePropertyReference(Reference value)
        {
            using (var writer = OpenTranslucencyByDistanceProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>translucencyByDistance</c> property as a <c>reference</c> value.  The <c>translucencyByDistance</c> property specifies how the billboard's translucency should change based on the billboard's distance from the camera.  This scalar value should range from 0 to 1.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteTranslucencyByDistancePropertyReference(string value)
        {
            using (var writer = OpenTranslucencyByDistanceProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>translucencyByDistance</c> property as a <c>reference</c> value.  The <c>translucencyByDistance</c> property specifies how the billboard's translucency should change based on the billboard's distance from the camera.  This scalar value should range from 0 to 1.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteTranslucencyByDistancePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenTranslucencyByDistanceProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>translucencyByDistance</c> property as a <c>reference</c> value.  The <c>translucencyByDistance</c> property specifies how the billboard's translucency should change based on the billboard's distance from the camera.  This scalar value should range from 0 to 1.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteTranslucencyByDistancePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenTranslucencyByDistanceProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>pixelOffsetScaleByDistance</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>pixelOffsetScaleByDistance</c> property defines how the billboard's pixel offset should change based on the billboard's distance from the camera.  This scalar value will be multiplied by <c>pixelOffset</c>.
        /// </summary>
        public NearFarScalarCesiumWriter PixelOffsetScaleByDistanceWriter
        {
            get { return m_pixelOffsetScaleByDistance.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>pixelOffsetScaleByDistance</c> property.  The <c>pixelOffsetScaleByDistance</c> property defines how the billboard's pixel offset should change based on the billboard's distance from the camera.  This scalar value will be multiplied by <c>pixelOffset</c>.
        /// </summary>
        public NearFarScalarCesiumWriter OpenPixelOffsetScaleByDistanceProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(PixelOffsetScaleByDistanceWriter);
        }

        /// <summary>
        /// Writes a value for the <c>pixelOffsetScaleByDistance</c> property as a <c>nearFarScalar</c> value.  The <c>pixelOffsetScaleByDistance</c> property specifies how the billboard's pixel offset should change based on the billboard's distance from the camera.  This scalar value will be multiplied by <c>pixelOffset</c>.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WritePixelOffsetScaleByDistanceProperty(NearFarScalar value)
        {
            using (var writer = OpenPixelOffsetScaleByDistanceProperty())
            {
                writer.WriteNearFarScalar(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>pixelOffsetScaleByDistance</c> property as a <c>nearFarScalar</c> value.  The <c>pixelOffsetScaleByDistance</c> property specifies how the billboard's pixel offset should change based on the billboard's distance from the camera.  This scalar value will be multiplied by <c>pixelOffset</c>.
        /// </summary>
        /// <param name="nearDistance">The lower bound of the camera distance range.</param>
        /// <param name="nearValue">The value to use at the lower bound of the camera distance range.</param>
        /// <param name="farDistance">The upper bound of the camera distance range.</param>
        /// <param name="farValue">The value to use at the upper bound of the camera distance range.</param>
        public void WritePixelOffsetScaleByDistanceProperty(double nearDistance, double nearValue, double farDistance, double farValue)
        {
            using (var writer = OpenPixelOffsetScaleByDistanceProperty())
            {
                writer.WriteNearFarScalar(nearDistance, nearValue, farDistance, farValue);
            }
        }

        /// <summary>
        /// Writes a value for the <c>pixelOffsetScaleByDistance</c> property as a <c>nearFarScalar</c> value.  The <c>pixelOffsetScaleByDistance</c> property specifies how the billboard's pixel offset should change based on the billboard's distance from the camera.  This scalar value will be multiplied by <c>pixelOffset</c>.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WritePixelOffsetScaleByDistanceProperty(IList<JulianDate> dates, IList<NearFarScalar> values)
        {
            using (var writer = OpenPixelOffsetScaleByDistanceProperty())
            {
                writer.WriteNearFarScalar(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>pixelOffsetScaleByDistance</c> property as a <c>nearFarScalar</c> value.  The <c>pixelOffsetScaleByDistance</c> property specifies how the billboard's pixel offset should change based on the billboard's distance from the camera.  This scalar value will be multiplied by <c>pixelOffset</c>.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WritePixelOffsetScaleByDistanceProperty(IList<JulianDate> dates, IList<NearFarScalar> values, int startIndex, int length)
        {
            using (var writer = OpenPixelOffsetScaleByDistanceProperty())
            {
                writer.WriteNearFarScalar(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>pixelOffsetScaleByDistance</c> property as a <c>reference</c> value.  The <c>pixelOffsetScaleByDistance</c> property specifies how the billboard's pixel offset should change based on the billboard's distance from the camera.  This scalar value will be multiplied by <c>pixelOffset</c>.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WritePixelOffsetScaleByDistancePropertyReference(Reference value)
        {
            using (var writer = OpenPixelOffsetScaleByDistanceProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>pixelOffsetScaleByDistance</c> property as a <c>reference</c> value.  The <c>pixelOffsetScaleByDistance</c> property specifies how the billboard's pixel offset should change based on the billboard's distance from the camera.  This scalar value will be multiplied by <c>pixelOffset</c>.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WritePixelOffsetScaleByDistancePropertyReference(string value)
        {
            using (var writer = OpenPixelOffsetScaleByDistanceProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>pixelOffsetScaleByDistance</c> property as a <c>reference</c> value.  The <c>pixelOffsetScaleByDistance</c> property specifies how the billboard's pixel offset should change based on the billboard's distance from the camera.  This scalar value will be multiplied by <c>pixelOffset</c>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WritePixelOffsetScaleByDistancePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenPixelOffsetScaleByDistanceProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>pixelOffsetScaleByDistance</c> property as a <c>reference</c> value.  The <c>pixelOffsetScaleByDistance</c> property specifies how the billboard's pixel offset should change based on the billboard's distance from the camera.  This scalar value will be multiplied by <c>pixelOffset</c>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WritePixelOffsetScaleByDistancePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenPixelOffsetScaleByDistanceProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>imageSubRegion</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>imageSubRegion</c> property defines a sub-region of the image which will be used for the billboard, rather than the entire image, measured in pixels from the bottom-left.
        /// </summary>
        public BoundingRectangleCesiumWriter ImageSubRegionWriter
        {
            get { return m_imageSubRegion.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>imageSubRegion</c> property.  The <c>imageSubRegion</c> property defines a sub-region of the image which will be used for the billboard, rather than the entire image, measured in pixels from the bottom-left.
        /// </summary>
        public BoundingRectangleCesiumWriter OpenImageSubRegionProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ImageSubRegionWriter);
        }

        /// <summary>
        /// Writes a value for the <c>imageSubRegion</c> property as a <c>boundingRectangle</c> value.  The <c>imageSubRegion</c> property specifies a sub-region of the image which will be used for the billboard, rather than the entire image, measured in pixels from the bottom-left.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteImageSubRegionProperty(BoundingRectangle value)
        {
            using (var writer = OpenImageSubRegionProperty())
            {
                writer.WriteBoundingRectangle(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>imageSubRegion</c> property as a <c>boundingRectangle</c> value.  The <c>imageSubRegion</c> property specifies a sub-region of the image which will be used for the billboard, rather than the entire image, measured in pixels from the bottom-left.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteImageSubRegionProperty(IList<JulianDate> dates, IList<BoundingRectangle> values)
        {
            using (var writer = OpenImageSubRegionProperty())
            {
                writer.WriteBoundingRectangle(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>imageSubRegion</c> property as a <c>boundingRectangle</c> value.  The <c>imageSubRegion</c> property specifies a sub-region of the image which will be used for the billboard, rather than the entire image, measured in pixels from the bottom-left.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteImageSubRegionProperty(IList<JulianDate> dates, IList<BoundingRectangle> values, int startIndex, int length)
        {
            using (var writer = OpenImageSubRegionProperty())
            {
                writer.WriteBoundingRectangle(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>imageSubRegion</c> property as a <c>reference</c> value.  The <c>imageSubRegion</c> property specifies a sub-region of the image which will be used for the billboard, rather than the entire image, measured in pixels from the bottom-left.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteImageSubRegionPropertyReference(Reference value)
        {
            using (var writer = OpenImageSubRegionProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>imageSubRegion</c> property as a <c>reference</c> value.  The <c>imageSubRegion</c> property specifies a sub-region of the image which will be used for the billboard, rather than the entire image, measured in pixels from the bottom-left.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteImageSubRegionPropertyReference(string value)
        {
            using (var writer = OpenImageSubRegionProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>imageSubRegion</c> property as a <c>reference</c> value.  The <c>imageSubRegion</c> property specifies a sub-region of the image which will be used for the billboard, rather than the entire image, measured in pixels from the bottom-left.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteImageSubRegionPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenImageSubRegionProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>imageSubRegion</c> property as a <c>reference</c> value.  The <c>imageSubRegion</c> property specifies a sub-region of the image which will be used for the billboard, rather than the entire image, measured in pixels from the bottom-left.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteImageSubRegionPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenImageSubRegionProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

    }
}
