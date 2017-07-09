using Business.DDEXFactory.Schemas.ERN_382;
using Business.DDEXFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DDEX.Generation.ERN_382
{
    public partial class ERN_382GenerationFormAudioAlbumMusicOnly : GenerationForm
    {
        public ERN_382GenerationFormAudioAlbumMusicOnly()
        {
            InitializeComponent();
        }

        public ERN_382GenerationFormAudioAlbumMusicOnly(IXmlGenerationFactory factory): this()
        {
            _Factory = factory;
        }

        public override IXmlObject GetXmlObject()
        {
            var ret = new NewReleaseMessage()
            {
                ReleaseProfileVersionId = "CommonReleaseTypes/13/AudioSingle",
                LanguageAndScriptCode ="en",
                MessageSchemaVersionId = "ern/382"
            };

            PartyId[] senderIDs = { new PartyId() { Value = "DPID_OF_THE_SENDER" } };
            PartyId[] recipientIDs = { new PartyId() { Value = "DPID_OF_THE_RECIPIENT" } };
            var o = new MessagingParty() { PartyId = recipientIDs };
            MessagingParty[] messageRecipient = { o };

            ret.MessageHeader = new MessageHeader()
            {
                MessageThreadId = "", // unique za seriju poruka 
                MessageId = "", // svaka poruka ima ovo unique (new guid ili sl)
                MessageSender = new MessagingParty() { PartyId = senderIDs },
                MessageRecipient = messageRecipient,
                MessageCreatedDateTime = DateTime.Now
            };

            ret.UpdateIndicator = UpdateIndicator.OriginalMessage;
            ret.UpdateIndicatorSpecified = true;
            ret.IsBackfill = false;
            ret.IsBackfillSpecified = true;

            ret.ResourceList = new ResourceList();
            var lsSoundRecordings = new List<SoundRecording>();
            lsSoundRecordings.Add(
                new SoundRecording()
                {
                    SoundRecordingCollectionReferenceList = new SoundRecordingCollectionReferenceList() {  SoundRecordingCollectionReference = new SoundRecordingCollectionReference[] { new SoundRecordingCollectionReference() {  SequenceNumber = "1" } } },
                    SoundRecordingType = new SoundRecordingType1() {  Value =  SoundRecordingType.MusicalWorkSoundRecording },
                    SoundRecordingId = new List<SoundRecordingId>() { new SoundRecordingId() {  ISRC = "CASE00000001" } }.ToArray(),
                    IndirectSoundRecordingId = new List<MusicalWorkId>() { new MusicalWorkId() { ISWC = "T1234567890" } }.ToArray(), // ovo maknuti
                    ResourceReference = "A1",
                    ReferenceTitle = new ReferenceTitle() {  TitleText = new TitleText() { Value = "Prva pjesma" } },
                    Duration = "PT3M33S",
                    RightsAgreementId = new RightsAgreementId() { ProprietaryId = new ProprietaryId[] { new ProprietaryId() { Value = "DPID:xxx" } } }
                }
            );
            ret.ResourceList.SoundRecording = lsSoundRecordings.ToArray();
            var lsImages = new List<Image>();
            var lsImageId = new List<ResourceProprietaryId>();
            var lsProprietaryId = new List<ProprietaryId>();
            var lsImageDetailsByTerritory = new List<ImageDetailsByTerritory>();
            lsImageDetailsByTerritory.Add(
                new ImageDetailsByTerritory()
                        {
                            ParentalWarningType = new ParentalWarningType1[] { new ParentalWarningType1() {  Value = ParentalWarningType.NotExplicit } },
                        }
                );
            lsProprietaryId.Add(
                new ProprietaryId() {  Namespace = "DPID:xxx", Value = "PID0001" }
            );
            lsImageId.Add(
                new ResourceProprietaryId() {  ProprietaryId = lsProprietaryId.ToArray() }  
                );
            lsImages.Add(
                new Image()
                {
                    ImageType = new ImageType1() { Value = ImageType.FrontCoverImage },
                    ImageId = lsImageId.ToArray(),
                    ResourceReference = "A2",
                    ImageDetailsByTerritory = lsImageDetailsByTerritory.ToArray()

                }
            );
            ret.ResourceList.Image = lsImages.ToArray();

            ret.ReleaseList = new ReleaseList()
            {
                 Release = new Release[] {
                     new Release()
                     {
                          IsMainRelease = true,
                          ReleaseId = new ReleaseId[] { new ReleaseId() {  GRid = "A1UCASE00000001X", ISRC = "CASE000001" } },
                          ReleaseReference = new string[] { "R0" },
                          ReferenceTitle = new ReferenceTitle() {  TitleText = new TitleText() { Value = "Moj prvi release" } },
                          //ReleaseCollectionReferenceList = new ReleaseCollectionReferenceList() {  }
                          //ReleaseType = new ReleaseType1[] { new ReleaseType1() {  Value = ReleaseType.Single } },
                          ReleaseDetailsByTerritory = new ReleaseDetailsByTerritory [] 
                          {
                              new ReleaseDetailsByTerritory()
                              {
                                  DisplayArtistName = new Name[] { new Name() {  Value = "Lima"} },
                                  LabelName = new  LabelName [] { new LabelName() {  Value = "Longplay records" } },
                                  Title = new Title[] 
                                  {
                                      new Title() {  TitleText = new TitleText() {  Value = "Moj prvi release" } , TitleType = TitleType.FormalTitle },
                                      new Title() {  TitleText = new TitleText() {  Value = "Moj prvi release display" } , TitleType = TitleType.DisplayTitle }
                                  },
                                  DisplayArtist = new Artist[]
                                  {
                                      new Artist()
                                      {
                                          SequenceNumber = "1",
                                          Items = new object[] { new PartyName() { FullName = new Name() {  Value = "Lima" } } }
                                      },
                                      new Artist()
                                      {
                                          SequenceNumber = "2",
                                          Items = new object[] { new PartyName() { FullName = new Name() {  Value = "Miro" } } }
                                      }
                                  },
                                  ParentalWarningType = new ParentalWarningType1[]
                                  {
                                      new ParentalWarningType1() {  Value = ParentalWarningType.NotExplicit }
                                  },
                                  ResourceGroup = new ResourceGroup[]
                                  {
                                      new ResourceGroup()
                                      {
                                          Title = new Title[]
                                          {
                                              new Title() {  TitleText = new TitleText() {  Value = "Moja prva pjesma" } }
                                          },
                                          SequenceNumber = "1"
                                      }
                                  },
                                  PLine = new PLine[]
                                  {
                                      new PLine() {  Year = "2016", PLineText = "(P) 2010 Longplay music" }
                                  },
                                  CLine = new CLine[]
                                  {
                                      new CLine() {  Year = "2016", CLineText = "(P) 2010 Longplay music"}
                                  },
                                  OriginalReleaseDate = new EventDate() {  Value = "2016-12-01" }

                              }
                          }
                          
                     }
                 }
            };

            return ret;
        }

        private NewReleaseMessage XmlObject { get; set; }
        private void btnLoadXml_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.RestoreDirectory = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    lblPath.Text = dlg.FileName;

                    IXmlGenerator gen = Factory.GetGenerator();
                    
                    string value = System.IO.File.ReadAllText(lblPath.Text);
                    var obj = gen.DeserializeNewReleaseMessage(value);

                    XmlObject = (NewReleaseMessage)obj;
                    BindToForm();
                }
            }
        }
        private void LoadFile(string fileName)
        {
            IXmlGenerator gen = Factory.GetGenerator();

            string value = System.IO.File.ReadAllText(fileName);
            var obj = gen.DeserializeNewReleaseMessage(value);

            XmlObject = (NewReleaseMessage)obj;
            BindToForm();
        }

        private void BindToForm()
        {
            if (XmlObject != null)
            { 
            if (XmlObject.MessageHeader != null)
                {
                    txtMessageID.Text = XmlObject.MessageHeader.MessageId;
                    if (XmlObject.MessageHeader.MessageSender.PartyId.Length > 0)
                    {
                        txtMessageSender_PartyID.Text = XmlObject.MessageHeader.MessageSender.PartyId[0].Value;
                    }
                    if (XmlObject.MessageHeader.MessageSender.PartyName != null && XmlObject.MessageHeader.MessageSender.PartyName.FullName != null)
                    {
                        txtMessageSender_PartyName.Text = XmlObject.MessageHeader.MessageSender.PartyName.FullName.Value;
                    }
                    if (XmlObject.MessageHeader.MessageRecipient != null && XmlObject.MessageHeader.MessageRecipient.Length > 0 && XmlObject.MessageHeader.MessageRecipient[0].PartyId != null && XmlObject.MessageHeader.MessageRecipient[0].PartyId.Length > 0)
                    {
                        txtMessageRecipient_PartyID.Text = XmlObject.MessageHeader.MessageRecipient[0].PartyId[0].Value;
                    }
                    if (XmlObject.MessageHeader.MessageRecipient != null && XmlObject.MessageHeader.MessageRecipient.Length > 0 && XmlObject.MessageHeader.MessageRecipient[0].PartyName != null && XmlObject.MessageHeader.MessageRecipient[0].PartyName.FullName != null)
                    {
                        txtMessageRecipient_PartyName.Text = XmlObject.MessageHeader.MessageRecipient[0].PartyName.FullName.Value;
                    }
                    dpMessageCreatedDateTime.Value = XmlObject.MessageHeader.MessageCreatedDateTime;
                }
            }
        }
        private void BindToObject()
        {
            if (XmlObject != null)
            {
                XmlObject.UpdateIndicator = UpdateIndicator.OriginalMessage;
                if (XmlObject.MessageHeader != null)
                {
                    XmlObject.MessageHeader.MessageId = txtMessageID.Text;
                    XmlObject.MessageHeader.MessageThreadId = txtMessageID.Text;

                    if (XmlObject.MessageHeader.MessageSender.PartyId == null)
                    {
                        PartyId[] senderIDs = { new PartyId() };
                        XmlObject.MessageHeader.MessageSender.PartyId = senderIDs;
                    }
                    XmlObject.MessageHeader.MessageSender.PartyId[0].Value = txtMessageSender_PartyID.Text;
                
                    if (XmlObject.MessageHeader.MessageSender.PartyName == null)
                    {
                        XmlObject.MessageHeader.MessageSender.PartyName = new PartyName();
                    }
                    if (XmlObject.MessageHeader.MessageSender.PartyName.FullName == null)
                    {
                        XmlObject.MessageHeader.MessageSender.PartyName.FullName = new Business.DDEXFactory.Schemas.ERN_382.Name();
                    }
                    XmlObject.MessageHeader.MessageSender.PartyName.FullName.Value = txtMessageSender_PartyName.Text;

                    if (XmlObject.MessageHeader.MessageRecipient == null)
                    {
                        var o = new MessagingParty();
                        MessagingParty[] messageRecipient = { o };
                        XmlObject.MessageHeader.MessageRecipient = messageRecipient;
                    }

                    XmlObject.MessageHeader.MessageRecipient[0].PartyId[0].Value = txtMessageRecipient_PartyID.Text;                

                    if (XmlObject.MessageHeader.MessageRecipient[0].PartyName == null)
                    {
                        XmlObject.MessageHeader.MessageRecipient[0].PartyName = new PartyName();
                    }
                    if (XmlObject.MessageHeader.MessageRecipient[0].PartyName.FullName == null)
                    {
                        XmlObject.MessageHeader.MessageRecipient[0].PartyName.FullName = new Business.DDEXFactory.Schemas.ERN_382.Name();
                    }

                    XmlObject.MessageHeader.MessageRecipient[0].PartyName.FullName.Value = txtMessageRecipient_PartyName.Text;
                    XmlObject.MessageHeader.MessageCreatedDateTime = dpMessageCreatedDateTime.Value;
                    XmlObject.MessageHeader.MessageCreatedDateTime = new DateTime(dpMessageCreatedDateTime.Value.Ticks, DateTimeKind.Local);
                    
                }
            }
        }
        private bool ValidateXmlObject()
        {
            IXmlGenerator gen = Factory.GetGenerator();
            var str = gen.SerializeNewReleaseMessage(XmlObject);
            //string fileName = @"c:\temp\file.xml";
            string fileName = System.IO.Path.GetTempFileName();

            System.IO.File.WriteAllText(fileName, str);
            string msg = "";
            bool isValid = gen.IsValid(fileName, out msg);
            rtbOutput.Text = msg;

            return isValid;
        }

        private void WriteXml()
        {
            IXmlGenerator gen = Factory.GetGenerator();
            var str = gen.SerializeNewReleaseMessage(XmlObject);
            string fileName = lblPath.Text;
            System.IO.File.WriteAllText(fileName, str);
        }
        protected override void OnGenerateClicked(object sender, EventArgs e)
        {
            base.OnGenerateClicked(sender, e);
            BindToObject();
            bool isValid = ValidateXmlObject();
            if (isValid)
            {
                WriteXml();
            }
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            
        }

        private void ERN_382GenerationFormAudioAlbumMusicOnly_Load(object sender, EventArgs e)
        {
            lblPath.Text = "C:\\temp\\file.xml";
            LoadFile(lblPath.Text);
        }
        
    }
}
