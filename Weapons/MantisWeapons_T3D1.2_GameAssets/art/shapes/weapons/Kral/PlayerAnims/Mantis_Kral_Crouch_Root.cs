singleton TSShapeConstructor(Mantis_Kral_Crouch_RootDAE)
{
   baseShape = "./Mantis_Kral_Crouch_Root.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kral_Crouch_RootDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Root", "580", "639", true, true);
}
