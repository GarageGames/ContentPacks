singleton TSShapeConstructor(PlayerAnim_Disposition_Crouch_ForwardDAE)
{
   baseShape = "./PlayerAnim_Disposition_Crouch_Forward.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_Crouch_ForwardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Forward", "370", "399");
}
