singleton TSShapeConstructor(Soldier_Kral_BackDAE)
{
   baseShape = "./Soldier_Kral_Back.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kral_BackDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Back", "240", "259", true, true);
}
