﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the SlideMasterPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SlideMasterPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.presentationml.slideMaster+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideMaster";
        private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
        private static Dictionary<string, PartConstraintRule> _partConstraint;

        /// <summary>
        /// Creates an instance of the SlideMasterPart OpenXmlType
        /// </summary>
        internal protected SlideMasterPart()
        {
        }

        /// <summary>
        /// Gets the ChartParts of the SlideMasterPart
        /// </summary>
        public IEnumerable<ChartPart> ChartParts => GetPartsOfType<ChartPart>();

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <summary>
        /// Gets the CustomXmlParts of the SlideMasterPart
        /// </summary>
        public IEnumerable<CustomXmlPart> CustomXmlParts => GetPartsOfType<CustomXmlPart>();

        /// <summary>
        /// Gets the DiagramColorsParts of the SlideMasterPart
        /// </summary>
        public IEnumerable<DiagramColorsPart> DiagramColorsParts => GetPartsOfType<DiagramColorsPart>();

        /// <summary>
        /// Gets the DiagramDataParts of the SlideMasterPart
        /// </summary>
        public IEnumerable<DiagramDataPart> DiagramDataParts => GetPartsOfType<DiagramDataPart>();

        /// <summary>
        /// Gets the DiagramLayoutDefinitionParts of the SlideMasterPart
        /// </summary>
        public IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts => GetPartsOfType<DiagramLayoutDefinitionPart>();

        /// <summary>
        /// Gets the DiagramPersistLayoutParts of the SlideMasterPart
        /// </summary>
        public IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts => GetPartsOfType<DiagramPersistLayoutPart>();

        /// <summary>
        /// Gets the DiagramStyleParts of the SlideMasterPart
        /// </summary>
        public IEnumerable<DiagramStylePart> DiagramStyleParts => GetPartsOfType<DiagramStylePart>();

        /// <summary>
        /// Gets the EmbeddedControlPersistenceBinaryDataParts of the SlideMasterPart
        /// </summary>
        public IEnumerable<EmbeddedControlPersistenceBinaryDataPart> EmbeddedControlPersistenceBinaryDataParts => GetPartsOfType<EmbeddedControlPersistenceBinaryDataPart>();

        /// <summary>
        /// Gets the EmbeddedControlPersistenceParts of the SlideMasterPart
        /// </summary>
        public IEnumerable<EmbeddedControlPersistencePart> EmbeddedControlPersistenceParts => GetPartsOfType<EmbeddedControlPersistencePart>();

        /// <summary>
        /// Gets the EmbeddedObjectParts of the SlideMasterPart
        /// </summary>
        public IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts => GetPartsOfType<EmbeddedObjectPart>();

        /// <summary>
        /// Gets the EmbeddedPackageParts of the SlideMasterPart
        /// </summary>
        public IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts => GetPartsOfType<EmbeddedPackagePart>();

        /// <summary>
        /// Gets the ImageParts of the SlideMasterPart
        /// </summary>
        public IEnumerable<ImagePart> ImageParts => GetPartsOfType<ImagePart>();

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets the SlideLayoutParts of the SlideMasterPart
        /// </summary>
        public IEnumerable<SlideLayoutPart> SlideLayoutParts => GetPartsOfType<SlideLayoutPart>();

        /// <summary>
        /// Gets the SlideParts of the SlideMasterPart
        /// </summary>
        public IEnumerable<SlidePart> SlideParts => GetPartsOfType<SlidePart>();

        /// <inheritdoc/>
        internal sealed override string TargetName => "slideMaster";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "slideMasters";

        /// <summary>
        /// Gets the ThemePart of the SlideMasterPart
        /// </summary>
        public ThemePart ThemePart => GetSubPartOfType<ThemePart>();

        /// <summary>
        /// Gets the UserDefinedTagsParts of the SlideMasterPart
        /// </summary>
        public IEnumerable<UserDefinedTagsPart> UserDefinedTagsParts => GetPartsOfType<UserDefinedTagsPart>();

        /// <summary>
        /// Gets the VmlDrawingParts of the SlideMasterPart
        /// </summary>
        public IEnumerable<VmlDrawingPart> VmlDrawingParts => GetPartsOfType<VmlDrawingPart>();

        /// <summary>
        /// Adds a AudioReferenceRelationship to the SlideMasterPart
        /// </summary>
        /// <param name="mediaDataPart">The part type of the AudioReferenceRelationship</param>
        /// <return>The newly added part</return>
        public AudioReferenceRelationship AddAudioReferenceRelationship(MediaDataPart mediaDataPart)
        {return AddDataPartReferenceRelationship<AudioReferenceRelationship>(mediaDataPart);
        }

        /// <summary>
        /// Adds a AudioReferenceRelationship to the SlideMasterPart
        /// </summary>
        /// <param name="mediaDataPart">The part type of the AudioReferenceRelationship</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public AudioReferenceRelationship AddAudioReferenceRelationship(MediaDataPart mediaDataPart, string id)
        {return AddDataPartReferenceRelationship<AudioReferenceRelationship>(mediaDataPart, id);
        }

        /// <summary>
        /// Adds a CustomXmlPart to the SlideMasterPart
        /// </summary>
        /// <param name="contentType">The content type of the CustomXmlPart</param>
        /// <return>The newly added part</return>
        public CustomXmlPart AddCustomXmlPart(string contentType)
        {
            var childPart = new CustomXmlPart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a CustomXmlPart to the SlideMasterPart
        /// </summary>
        /// <param name="contentType">The content type of the CustomXmlPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public CustomXmlPart AddCustomXmlPart(string contentType, string id)
        {
            var childPart = new CustomXmlPart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a CustomXmlPart to the SlideMasterPart
        /// </summary>
        /// <param name="partType">The part type of the CustomXmlPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType, string id)
        {
            var contentType = CustomXmlPartTypeInfo.GetContentType(partType);
            var partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddCustomXmlPart(contentType, id);
        }

        /// <summary>
        /// Adds a CustomXmlPart to the SlideMasterPart
        /// </summary>
        /// <param name="partType">The part type of the CustomXmlPart</param>
        /// <return>The newly added part</return>
        public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType)
        {
            var contentType = CustomXmlPartTypeInfo.GetContentType(partType);
            var partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddCustomXmlPart(contentType);
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistenceBinaryDataPart to the SlideMasterPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedControlPersistenceBinaryDataPart</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType)
        {
            var childPart = new EmbeddedControlPersistenceBinaryDataPart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistenceBinaryDataPart to the SlideMasterPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedControlPersistenceBinaryDataPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType, string id)
        {
            var childPart = new EmbeddedControlPersistenceBinaryDataPart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistenceBinaryDataPart to the SlideMasterPart
        /// </summary>
        /// <param name="partType">The part type of the EmbeddedControlPersistenceBinaryDataPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType, string id)
        {
            var contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
            var partExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddEmbeddedControlPersistenceBinaryDataPart(contentType, id);
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistenceBinaryDataPart to the SlideMasterPart
        /// </summary>
        /// <param name="partType">The part type of the EmbeddedControlPersistenceBinaryDataPart</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType)
        {
            var contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
            var partExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddEmbeddedControlPersistenceBinaryDataPart(contentType);
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistencePart to the SlideMasterPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedControlPersistencePart</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType)
        {
            var childPart = new EmbeddedControlPersistencePart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistencePart to the SlideMasterPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedControlPersistencePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType, string id)
        {
            var childPart = new EmbeddedControlPersistencePart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistencePart to the SlideMasterPart
        /// </summary>
        /// <param name="partType">The part type of the EmbeddedControlPersistencePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType, string id)
        {
            var contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
            var partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddEmbeddedControlPersistencePart(contentType, id);
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistencePart to the SlideMasterPart
        /// </summary>
        /// <param name="partType">The part type of the EmbeddedControlPersistencePart</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType)
        {
            var contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
            var partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddEmbeddedControlPersistencePart(contentType);
        }

        /// <summary>
        /// Adds a EmbeddedObjectPart to the SlideMasterPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedObjectPart</param>
        /// <return>The newly added part</return>
        public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
        {
            var childPart = new EmbeddedObjectPart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a EmbeddedPackagePart to the SlideMasterPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedPackagePart</param>
        /// <return>The newly added part</return>
        public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
        {
            var childPart = new EmbeddedPackagePart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a ImagePart to the SlideMasterPart
        /// </summary>
        /// <param name="contentType">The content type of the ImagePart</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(string contentType)
        {
            var childPart = new ImagePart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a ImagePart to the SlideMasterPart
        /// </summary>
        /// <param name="contentType">The content type of the ImagePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(string contentType, string id)
        {
            var childPart = new ImagePart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a ImagePart to the SlideMasterPart
        /// </summary>
        /// <param name="partType">The part type of the ImagePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(ImagePartType partType, string id)
        {
            var contentType = ImagePartTypeInfo.GetContentType(partType);
            var partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddImagePart(contentType, id);
        }

        /// <summary>
        /// Adds a ImagePart to the SlideMasterPart
        /// </summary>
        /// <param name="partType">The part type of the ImagePart</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(ImagePartType partType)
        {
            var contentType = ImagePartTypeInfo.GetContentType(partType);
            var partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddImagePart(contentType);
        }

        /// <summary>
        /// Adds a MediaReferenceRelationship to the SlideMasterPart
        /// </summary>
        /// <param name="mediaDataPart">The part type of the MediaReferenceRelationship</param>
        /// <return>The newly added part</return>
        public MediaReferenceRelationship AddMediaReferenceRelationship(MediaDataPart mediaDataPart)
        {return AddDataPartReferenceRelationship<MediaReferenceRelationship>(mediaDataPart);
        }

        /// <summary>
        /// Adds a MediaReferenceRelationship to the SlideMasterPart
        /// </summary>
        /// <param name="mediaDataPart">The part type of the MediaReferenceRelationship</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public MediaReferenceRelationship AddMediaReferenceRelationship(MediaDataPart mediaDataPart, string id)
        {return AddDataPartReferenceRelationship<MediaReferenceRelationship>(mediaDataPart, id);
        }

        /// <summary>
        /// Adds a VideoReferenceRelationship to the SlideMasterPart
        /// </summary>
        /// <param name="mediaDataPart">The part type of the VideoReferenceRelationship</param>
        /// <return>The newly added part</return>
        public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart)
        {return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart);
        }

        /// <summary>
        /// Adds a VideoReferenceRelationship to the SlideMasterPart
        /// </summary>
        /// <param name="mediaDataPart">The part type of the VideoReferenceRelationship</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart, string id)
        {return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart, id);
        }

        /// <inheritdoc/>
        internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
        {
            ThrowIfObjectDisposed();
            if (relationshipType is null)
            {
                throw new ArgumentNullException(nameof(relationshipType));
            }

            switch (relationshipType)
            {
                case CustomXmlPart.RelationshipTypeConstant:
                    return new CustomXmlPart();
                case ChartPart.RelationshipTypeConstant:
                    return new ChartPart();
                case DiagramColorsPart.RelationshipTypeConstant:
                    return new DiagramColorsPart();
                case DiagramDataPart.RelationshipTypeConstant:
                    return new DiagramDataPart();
                case DiagramPersistLayoutPart.RelationshipTypeConstant:
                    return new DiagramPersistLayoutPart();
                case DiagramLayoutDefinitionPart.RelationshipTypeConstant:
                    return new DiagramLayoutDefinitionPart();
                case DiagramStylePart.RelationshipTypeConstant:
                    return new DiagramStylePart();
                case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
                case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
                case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
                case VmlDrawingPart.RelationshipTypeConstant:
                    return new VmlDrawingPart();
                case EmbeddedControlPersistenceBinaryDataPart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistenceBinaryDataPart();
                case ThemePart.RelationshipTypeConstant:
                    return new ThemePart();
                case SlidePart.RelationshipTypeConstant:
                    return new SlidePart();
                case SlideLayoutPart.RelationshipTypeConstant:
                    return new SlideLayoutPart();
                case EmbeddedControlPersistencePart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistencePart();
                case UserDefinedTagsPart.RelationshipTypeConstant:
                    return new UserDefinedTagsPart();
            }

            throw new ArgumentOutOfRangeException(nameof(relationshipType));
        }

        /// <inheritdoc/>
        internal sealed override IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
        {
            if (_dataPartReferenceConstraint is null)
            {
                _dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>(StringComparer.Ordinal)
                {
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/audio",
                        new PartConstraintRule(nameof(AudioReferenceRelationship), null, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/video",
                        new PartConstraintRule(nameof(VideoReferenceRelationship), null, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.microsoft.com/office/2007/relationships/media",
                        new PartConstraintRule(nameof(MediaReferenceRelationship), null, false, true, FileFormatVersions.Office2010.AndLater())
                    }
                };
            }

            return _dataPartReferenceConstraint;
        }

        /// <inheritdoc/>
        internal sealed override IDictionary<string, PartConstraintRule> GetPartConstraint()
        {
            if (_partConstraint is null)
            {
                _partConstraint = new Dictionary<string, PartConstraintRule>(StringComparer.Ordinal)
                {
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml",
                        new PartConstraintRule(nameof(CustomXmlPart), null, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart",
                        new PartConstraintRule(nameof(ChartPart), ChartPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors",
                        new PartConstraintRule(nameof(DiagramColorsPart), DiagramColorsPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData",
                        new PartConstraintRule(nameof(DiagramDataPart), DiagramDataPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.microsoft.com/office/2007/relationships/diagramDrawing",
                        new PartConstraintRule(nameof(DiagramPersistLayoutPart), DiagramPersistLayoutPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout",
                        new PartConstraintRule(nameof(DiagramLayoutDefinitionPart), DiagramLayoutDefinitionPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle",
                        new PartConstraintRule(nameof(DiagramStylePart), DiagramStylePart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject",
                        new PartConstraintRule(nameof(EmbeddedObjectPart), null, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package",
                        new PartConstraintRule(nameof(EmbeddedPackagePart), null, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image",
                        new PartConstraintRule(nameof(ImagePart), null, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing",
                        new PartConstraintRule(nameof(VmlDrawingPart), VmlDrawingPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary",
                        new PartConstraintRule(nameof(EmbeddedControlPersistenceBinaryDataPart), null, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme",
                        new PartConstraintRule(nameof(ThemePart), ThemePart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide",
                        new PartConstraintRule(nameof(SlidePart), SlidePart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideLayout",
                        new PartConstraintRule(nameof(SlideLayoutPart), SlideLayoutPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/control",
                        new PartConstraintRule(nameof(EmbeddedControlPersistencePart), null, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags",
                        new PartConstraintRule(nameof(UserDefinedTagsPart), UserDefinedTagsPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    }
                };
            }

            return _partConstraint;
        }
    }
}