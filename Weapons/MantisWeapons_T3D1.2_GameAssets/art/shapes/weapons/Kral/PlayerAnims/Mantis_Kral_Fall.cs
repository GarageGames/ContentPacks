singleton TSShapeConstructor(Mantis_Kral_FallDAE)
{
   baseShape = "./Mantis_Kral_Fall.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kral_FallDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Fall", "860", "879", true, true);
}
