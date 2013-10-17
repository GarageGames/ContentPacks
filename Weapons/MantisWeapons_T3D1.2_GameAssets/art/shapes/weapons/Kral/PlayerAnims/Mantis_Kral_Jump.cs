singleton TSShapeConstructor(Mantis_Kral_JumpDAE)
{
   baseShape = "./Mantis_Kral_Jump.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kral_JumpDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Jump", "800", "815", true, true);
}
